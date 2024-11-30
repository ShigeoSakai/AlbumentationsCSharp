using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlbumentationsCSharp
{
    /// <summary>
    /// コマンド実行クラス
    /// </summary>
    internal class CmdExecutor :IDisposable
    {
        /// <summary>
        /// コマンド実行終了イベントハンドラ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="sendCmd"></param>
        /// <param name="isOK"></param>
        public delegate void CommandComplete(object sender, string sendCmd,string recvText, bool isOK);

        /// <summary>
        /// コマンドエラー発生イベントハンドラ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="err_txt"></param>
        public delegate void CmdErrorEventHander(object sender, string err_txt);

        /// <summary>
        /// コマンドと応答のクラス
        /// </summary>
        public class COMMAND_AND_RESPONSE
        {
            /// <summary>
            /// 送信するコマンド
            /// </summary>
            public string Command { get; private set; }
            /// <summary>
            /// 期待するレスポンス
            /// </summary>
            public string Response { get; private set; }
            /// <summary>
            /// 応答イベント
            /// </summary>
            public CommandComplete CompleteCallback { get; private set; } = null;
            /// <summary>
            /// コンストラクタ
            /// </summary>
            /// <param name="cmd"></param>
            public COMMAND_AND_RESPONSE(string cmd)
            {
                Command = cmd;
                Response = "";
            }
            /// <summary>
            /// コンストラクタ
            /// </summary>
            /// <param name="cmd"></param>
            /// <param name="resp"></param>
            public COMMAND_AND_RESPONSE(string cmd, string resp) :this(cmd) 
            {
                Response = resp;
            }
            /// <summary>
            /// コンストラクタ
            /// </summary>
            /// <param name="cmd"></param>
            /// <param name="resp"></param>
            /// <param name="func"></param>
            public COMMAND_AND_RESPONSE(string cmd, string resp,CommandComplete func) : this(cmd,resp)
            {
                CompleteCallback = func;
            }
        }

        /// <summary>
        /// コマンド要求Queue
        /// </summary>
        private ConcurrentQueue<COMMAND_AND_RESPONSE> Commands = new ConcurrentQueue<COMMAND_AND_RESPONSE>();

        /// <summary>
        /// コマンド実行要求Queue
        /// </summary>
        private ConcurrentQueue<COMMAND_AND_RESPONSE> ExecCommands = new ConcurrentQueue<COMMAND_AND_RESPONSE>();

        /// <summary>
        /// コマンド要求できるか？
        /// </summary>
        private volatile bool RequestEnable = false;
        /// <summary>
        /// コマンドタスク
        /// </summary>
        private Task CmdTask;
        /// <summary>
        /// キャンセルトークンソース
        /// </summary>
        private CancellationTokenSource CancellationTokenSource = new CancellationTokenSource();
        /// <summary>
        /// キャンセルトークン
        /// </summary>
        private CancellationToken CancellationToken;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public CmdExecutor() : this(Directory.GetCurrentDirectory()) { }
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public CmdExecutor(string word_dir, CmdErrorEventHander errHandler = null) 
        {
            // エラー出力用タイマーハンドラ
            ErrTimer.Elapsed += ErrTimer_Tick;
            ErrTimer.AutoReset = false;

            // エラーハンドラ追加
            if (errHandler != null)
                CmdError += errHandler;

            // Cancelトークン
            CancellationToken = CancellationTokenSource.Token;

            // コマンド実行タスク
            CmdTask = Task.Run(() => 
            {
                //Processオブジェクトを作成
                System.Diagnostics.Process p = new System.Diagnostics.Process();

                //入力できるようにする
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.RedirectStandardInput = true;

                //非同期で出力を読み取れるようにする
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.RedirectStandardError = true;
                p.OutputDataReceived += p_OutputDataReceived;
                p.ErrorDataReceived += p_ErrorDataReceived;

                // 終了イベント
                p.Exited += p_Exited;

                // コマンドプロンプト
                p.StartInfo.FileName =
                    System.Environment.GetEnvironmentVariable("ComSpec");
                p.StartInfo.CreateNoWindow = true;

                // ワークディレクトリ
                p.StartInfo.WorkingDirectory = word_dir; 

                //起動
                p.Start();

                //非同期で出力の読み取りを開始
                p.BeginOutputReadLine();
                p.BeginErrorReadLine();

                //入力のストリームを取得
                System.IO.StreamWriter sw = p.StandardInput;

                try
                {
                    // タスクがキャンセルされない間
                    while (CancellationToken.IsCancellationRequested == false)
                    {
                        // 実行コマンドQueueのチェック
                        if (ExecCommands.IsEmpty == false)
                        {
                            // 実行コマンドQueueから取り出し
                            if (ExecCommands.TryDequeue(out COMMAND_AND_RESPONSE command))
                            {
                                if (sw.BaseStream.CanWrite)
                                {
                                    // コマンド送信
                                    Console.WriteLine("Send:{0}", command.Command);
                                    sw.WriteLine(command.Command);
                                }
                            }
                        }
                    }
                    Console.WriteLine("--- Cancel!!");
                } 
                catch (Exception ex)
                {   // 例外発生
                    Console.WriteLine("CmdTask:", ex.ToString());
                }
                // 標準入力を閉じる
                sw.Close();
                // プロセスをKILL
                p.Kill();
                p.WaitForExit();
                // プロセスをClose
                p.Close();
                Console.WriteLine("--- Task Exit");

            }, CancellationToken);

            // コマンド要求可にする
            RequestEnable = true;
        }
        /// <summary>
        /// 解放処理
        /// </summary>
        public void Dispose()
        {
            // タスクが動いているかチェック
            if ((CmdTask != null) && (CmdTask.Status == TaskStatus.Running))
            {
                // キャンセルを送信して終了を待つ
                CancellationTokenSource.Cancel(true);
                CmdTask.Wait();

                Console.WriteLine("Dispose Status:{0}",CmdTask.Status);
                CmdTask = null;

            }
            // 登録されているイベントを全て削除する
            foreach(var evt in CmdError.GetInvocationList())
            {
                CmdError -= (CmdErrorEventHander)evt;
            }
        }
        /// <summary>
        /// プロセス終了イベント処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void p_Exited(object sender, EventArgs e)
        {
            Console.WriteLine("Process Exited");
        }
        /// <summary>
        /// コマンドエラー発生イベント
        /// </summary>
        public event CmdErrorEventHander CmdError;
        /// <summary>
        /// コマンドエラーイベント発行
        /// </summary>
        /// <param name="err_text"></param>
        protected virtual void OnCmdErr(string err_text)
        {
            CmdError?.Invoke(this, err_text);
        }

        /// <summary>
        /// 500msのWaitタイマー(100ms)
        /// </summary>
        private System.Timers.Timer ErrTimer = new System.Timers.Timer(100.0);

        /// <summary>
        /// エラー出力結果
        /// </summary>
        private ConcurrentQueue<string> ErrMsgQueye = new ConcurrentQueue<string>();
        /// <summary>
        /// エラータイマー満了
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ErrTimer_Tick(object sender, System.Timers.ElapsedEventArgs e)
        {
            // タイマー停止
            ErrTimer.Stop();
            if (ErrMsgQueye.IsEmpty == false)
            {
                string err_text = string.Empty;
                while(ErrMsgQueye.TryDequeue(out string msg))
                {
                    err_text += msg + Environment.NewLine;
                }
                // エラー送信
                OnCmdErr(err_text);
                if (err_text.Trim().StartsWith("## ") == false)
                {
                    // コマンド要求不可にする
                    RequestEnable = false;
                }
            }
        }
        /// <summary>
        /// エラーテキストの書き込み
        /// </summary>
        /// <param name="err_text"></param>
        private void SetErrText(string err_text)
        {
            ErrTimer.Stop();
            ErrMsgQueye.Enqueue(err_text);
            ErrTimer.Start();
        }

        /// <summary>
        /// エラー出力
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void p_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            Console.WriteLine("StdErr({0}):{1}",
                (e.Data == null) ? 0:e.Data.Length , 
                (e.Data == null) ? "null" : e.Data);

            // 待ちの先頭を取り除く
            if (Commands.TryDequeue(out COMMAND_AND_RESPONSE err_cmd))
            {   // コールバックを呼び出す
                if (err_cmd.CompleteCallback != null)
                {
                    err_cmd.CompleteCallback(this, err_cmd.Command,e.Data, false);
                }
            }
            // エラーを送信
            SetErrText(e.Data);

            // 次のコマンドを要求する
            //if (Commands.IsEmpty == false)
            //    if (Commands.TryPeek(out COMMAND_AND_RESPONSE command))
            //        ExecCommands.Enqueue(command);
        }
        /// <summary>
        /// 通常出力
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void p_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            Console.WriteLine("StdOut({0}):{1}",
                (e.Data == null) ? 0 : e.Data.Length,
                (e.Data == null) ? "null" : e.Data);
            if (Commands.TryPeek(out COMMAND_AND_RESPONSE command))
            {
                Console.WriteLine("Waiting:{0}",command.Response);
                if (((e.Data == null) && (string.IsNullOrEmpty(command.Response))) ||
                    (string.IsNullOrEmpty(command.Response)) ||
                    (e.Data.StartsWith(command.Response)))
                {   // 応答が一致したので先頭を取り除く
                    Commands.TryDequeue(out COMMAND_AND_RESPONSE ok_cmd);
                    // コールバックを呼び出す
                    if (ok_cmd.CompleteCallback != null)
                    {
                        ok_cmd.CompleteCallback(this, ok_cmd.Command,e.Data, true);
                    }

                    Console.WriteLine("Next Command Send");
                    // 次のコマンドを要求する
                    if (Commands.IsEmpty == false)
                        if (Commands.TryPeek(out COMMAND_AND_RESPONSE new_command))
                            ExecCommands.Enqueue(new_command);
                }
            }

        }
        /// <summary>
        /// コマンド登録(ローカル)
        /// </summary>
        /// <param name="command"></param>
        private void ExecCommandLocal(COMMAND_AND_RESPONSE command)
        {
            if (RequestEnable)
            {
                Commands.Enqueue(command);
                if (Commands.Count == 1)
                {   // 実行要求へ
                    ExecCommands.Enqueue(command);
                }
            }

        }
        /// <summary>
        /// コマンド登録
        /// </summary>
        /// <param name="command">実行するコマンド</param>
        public void ExecCommand(string command)
        {
            ExecCommandLocal(new COMMAND_AND_RESPONSE(command));
        }
        /// <summary>
        /// コマンド登録
        /// </summary>
        /// <param name="command">実行するコマンド</param>
        /// <param name="resp">期待する応答</param>
        public void ExecCommand(string command,string resp)
        {
            ExecCommandLocal(new COMMAND_AND_RESPONSE(command,resp));
        }
        /// <summary>
        /// コマンド登録
        /// </summary>
        /// <param name="command">実行するコマンド</param>
        /// <param name="resp">期待する応答</param>
        /// <param name="func">応答受信時の処理関数</param>
        public void ExecCommand(string command, string resp,CommandComplete func)
        {
            ExecCommandLocal(new COMMAND_AND_RESPONSE(command, resp, func));
        }
        
        /// <summary>
        /// 即コマンド実行
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        public static string InstantlyExecute(string command)
        {
            // インスタンス生成
            Process process = new Process();
            //ComSpec(cmd.exe)のパスを取得して、FileNameプロパティに指定
            process.StartInfo.FileName = System.Environment.GetEnvironmentVariable("ComSpec");
            //出力を読み取れるようにする
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardInput = false;
            //ウィンドウを表示しないようにする
            process.StartInfo.CreateNoWindow = true;
            //コマンドラインを指定（"/c"は実行後閉じるために必要）
            process.StartInfo.Arguments = string.Format("/c {0}", command);

            //起動
            process.Start();

            //出力を読み取る
            string results = process.StandardOutput.ReadToEnd();

            //プロセス終了まで待機する
            //WaitForExitはReadToEndの後である必要がある
            //(親プロセス、子プロセスでブロック防止のため)
            process.WaitForExit();
            process.Close();

            return results;
        }

    }
}
