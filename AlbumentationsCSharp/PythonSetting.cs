using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbumentationsCSharp
{
    public class PythonSetting
    {
        public enum PYTHON_ENV
        {
            ANACONDA = 1,
            VENV = 2,
            NORMAL = 0
        }
        /// <summary>
        /// Python環境選択
        /// </summary>
        public PYTHON_ENV UsePythonEnv { get; set; } = PYTHON_ENV.NORMAL;
        /// <summary>
        /// Anacondaパス
        /// </summary>
        public string AnacondaPath { get; set; } = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
            ".conda"
            );
        /// <summary>
        /// Anaconda環境名
        /// </summary>
        public string AnacondaEnv { get; set; } = "base";

        /// <summary>
        /// Python venvパス
        /// </summary>
        public string vEnvPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);

        /// <summary>
        /// Python venv名
        /// </summary>
        public string vEnvName { get; set; } = string.Empty;

        /// <summary>
        /// Pythonのパス
        /// </summary>
        public string PythonPath { get; set; } = string.Empty;
        /// <summary>
        /// 起動ディレクトリ
        /// </summary>
        public string InitDirectory { get; set; } = Directory.GetCurrentDirectory();

        /// <summary>
        /// デフォルトコンストラクタ
        /// </summary>
        public PythonSetting()
        {
            // Anacondaがインストールされているかチェック
            string conda_path = CmdExecutor.InstantlyExecute("where conda");
            if (string.IsNullOrEmpty(conda_path) == false)
            {
                if (conda_path.EndsWith(Environment.NewLine))
                    conda_path = conda_path.Substring(0, conda_path.Length - Environment.NewLine.Length);
                AnacondaPath = conda_path.Substring(0, conda_path.Length - "\\conda.bat".Length);
            }
            // Pythonのパス
            string python_path = CmdExecutor.InstantlyExecute("where python");
            if (string.IsNullOrEmpty(python_path) == false)
            {
                if (python_path.EndsWith(Environment.NewLine))
                    python_path = python_path.Substring(0, python_path.Length - Environment.NewLine.Length);
                PythonPath = python_path.Substring(0, python_path.Length - "\\python.exe".Length);
            }
        }
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="useEnv">使用するPython環境</param>
        /// <param name="anacondaPath">Anacondaパス</param>
        /// <param name="anacondaEnv">Anaconda環境名</param>
        /// <param name="venvPath">venvパス</param>
        /// <param name="venvName">venv名</param>
        /// <param name="initDirectory">起動ディレクトリ</param>
        public PythonSetting(PYTHON_ENV useEnv, string anacondaPath, string anacondaEnv,
            string venvPath, string venvName, string initDirectory, string pythonPath = null)
        {
            UsePythonEnv = useEnv;
            AnacondaPath = anacondaPath;
            AnacondaEnv = anacondaEnv;
            vEnvPath = venvPath;
            vEnvName = venvName;
            InitDirectory = initDirectory;
            PythonPath = pythonPath;
        }
        /// <summary>
        /// コピーコンストラクタ
        /// </summary>
        /// <param name="src"></param>
        public PythonSetting(PythonSetting src)
        {
            UsePythonEnv = src.UsePythonEnv;
            AnacondaPath = src.AnacondaPath;
            AnacondaEnv = src.AnacondaEnv;
            vEnvPath = src.vEnvPath;
            vEnvName = src.vEnvName;
            InitDirectory = src.InitDirectory;
            PythonPath = src.PythonPath;
        }
        /// <summary>
        /// 文字列から生成
        /// </summary>
        /// <param name="text"></param>
        public PythonSetting(string text)
        {
            FromString(text);
        }

        /// <summary>
        /// 環境のチェック
        /// </summary>
        /// <param name="err_msg"></param>
        /// <returns></returns>
        public bool Check(out string err_msg)
        {
            if (UsePythonEnv == PYTHON_ENV.ANACONDA)
            {
                if ((string.IsNullOrEmpty(AnacondaPath)) ||
                    (Directory.Exists(AnacondaPath) == false))
                {
                    err_msg = "Anacondaのパスが設定されていません。";
                    return false;
                }
                if (string.IsNullOrEmpty(AnacondaEnv))
                {
                    err_msg = "Anacondaの環境名が設定されていません。";
                    return false;
                }
            }
            else if (UsePythonEnv == PYTHON_ENV.VENV)
            {
                if ((string.IsNullOrEmpty(vEnvPath)) ||
                    (Directory.Exists(vEnvPath) == false))
                {
                    err_msg = "Python venvのパスが設定されていません。";
                    return false;
                }
                if (string.IsNullOrEmpty(vEnvName))
                {
                    err_msg = "Python venvの環境名が設定されていません。";
                    return false;
                }
            }
            else
            {
                if ((string.IsNullOrEmpty(PythonPath)) ||
                    (Directory.Exists(PythonPath) == false))
                {
                    err_msg = "Pythonが見つかりません。";
                    return false;
                }
            }
            if ((string.IsNullOrEmpty(InitDirectory) == false) && 
                (Directory.Exists(InitDirectory) == false))
            {
                err_msg = "起動ディレクトリが存在しません。";
                return false;
            }
            err_msg = string.Empty;
            return true;
        }
        /// <summary>
        /// 実行コマンドを取得
        /// </summary>
        /// <param name="arg"></param>
        /// <returns></returns>
        public List<string> StartPython(string arg,out string init_directory)
        {
            List<string> commands = new List<string>();
            if (UsePythonEnv == PYTHON_ENV.ANACONDA)
            {   // Anaconda環境を設定
                commands.Add("\"" + Path.Combine(AnacondaPath, "conda") + "\" activate  " + AnacondaEnv);
                commands.Add("python " + arg);
            }
            else if (UsePythonEnv == PYTHON_ENV.VENV)
            {
                commands.Add("\"" + Path.Combine(Path.Combine(vEnvPath,vEnvName), @"Scripts\activate") + "\"");
                commands.Add("python " + arg);
            }
            else
            {
                commands.Add("\"" + Path.Combine(PythonPath,"python") + "\" " + arg);    
            }
            init_directory = InitDirectory;
            return commands;
        }
        /// <summary>
        /// 設定を文字列変換
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string result = string.Empty;
            // UsePythonEnv
            result += "UsePythonEnv=" + UsePythonEnv.ToString();
            // AnacondaPath
            result += ";AnacondaPath=" + (string.IsNullOrEmpty(AnacondaPath) ? "" : AnacondaPath);
            // AnacondaEnv
            result += ";AnacondaEnv=" + (string.IsNullOrEmpty(AnacondaEnv) ? "" : AnacondaEnv);
            // vEnvPath
            result += ";vEnvPath=" + (string.IsNullOrEmpty(vEnvPath) ? "" : vEnvPath);
            // vEnvName
            result += ";vEnvName=" + (string.IsNullOrEmpty(vEnvName) ? "" : vEnvName);
            // PythonPath
            result += ";PythonPath=" + (string.IsNullOrEmpty(PythonPath) ? "" : PythonPath);
            // InitDirectory
            result += ";InitDirectory=" + (string.IsNullOrEmpty(InitDirectory) ? "" : InitDirectory);
            result += ";";
            return result;
        }
        /// <summary>
        /// 文字の切り出し
        /// </summary>
        /// <param name="text"></param>
        /// <param name="keyword"></param>
        /// <param name="next_keyword"></param>
        /// <returns></returns>
        private string CutPara(string text,string keyword,string next_keyword = null)
        {
            int pos = text.IndexOf(keyword);
            if (pos >= 0)
            {
                text = text.Substring(pos);
                int next_pos;
                if (string.IsNullOrEmpty(next_keyword) == false)
                {
                    next_pos = text.IndexOf(next_keyword);
                    if (next_pos >= 0)
                    {
                        text = text.Substring(keyword.Length, next_pos - keyword.Length);
                        return text;
                    }
                }
                next_pos = text.IndexOf(";");
                if (next_pos >= 0)
                {
                    text = text.Substring(keyword.Length, next_pos - keyword.Length);
                    return text;
                }
            }
            return "";
        }
        /// <summary>
        /// 文字列から設定
        /// </summary>
        /// <param name="str"></param>
        public void FromString(string str)
        {
            // UsePythonEnv
            string use_env = CutPara(str, "UsePythonEnv=", ";AnacondaPath=");
            if ((string.IsNullOrEmpty(use_env) == false) &&
                (Enum.TryParse<PYTHON_ENV>(use_env, out PYTHON_ENV use_value)))
                this.UsePythonEnv = use_value;
            else
                this.UsePythonEnv = PYTHON_ENV.NORMAL;

            // AnacondaPath
            string conda_path = CutPara(str, "AnacondaPath=", ";AnacondaEnv=");
            this.AnacondaPath = conda_path;

            // AnacondaEnv
            string conda_env = CutPara(str, "AnacondaEnv=", ";vEnvPath=");
            this.AnacondaEnv = conda_env;

            // vEnvPath
            string venv_path = CutPara(str, "vEnvPath=", ";vEnvName=");
            this.vEnvPath = venv_path;

            // vEnvName
            string venv_name = CutPara(str, "vEnvName=", ";PythonPath=");
            this.vEnvName = venv_name;

            // PythonPath
            string py_path = CutPara(str, "PythonPath=", ";InitDirectory=");
            this.PythonPath = py_path;

            // InitDirectory
            string init_dir = CutPara(str, "InitDirectory=");
            this.InitDirectory = init_dir;

        }

    }
}