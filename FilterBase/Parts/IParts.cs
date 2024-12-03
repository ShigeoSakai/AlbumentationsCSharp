using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilterBase.Parts
{
    /// <summary>
    /// パーツのインターフェイス
    /// </summary>
    public interface IParts
    {
        /// <summary>
        /// 引数名
        /// </summary>
        string ArgumentName { get; set; }

        /// <summary>
        /// ヒント表示するテキスト
        /// </summary>
        string Description { get; set; }

        /// <summary>
        /// 最小バージョン
        /// </summary>
        string MinVersion { get; set; }
        /// <summary>
        /// 最大バージョン
        /// </summary>
        string MaxVersion { get; set; }

        /// <summary>
        /// バージョン情報の設定
        /// </summary>
        /// <param name="version"></param>
        /// <returns></returns>
        bool SetVersion(VersionInfo version);

        /// <summary>
        /// 入力チェック
        /// </summary>
        /// <returns>true:チェックOK</returns>
        bool Check(out string err_msg);
        /// <summary>
        /// 引数の取得
        /// </summary>
        /// <returns>引数の文字列。nullの場合はエラー。空白はパラメータなし</returns>
        string GetArgument();

        /// <summary>
        /// パラメータ変更イベント
        /// </summary>
        event ParameterChangeEventHandler ParameterChange;

        /// <summary>
        /// Tool Tipに説明文を追加する
        /// </summary>
        /// <param name="tip"></param>
        void SetToolTip(ToolTip tip);

        /// <summary>
        /// パラメータの設定
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        bool SetParameter(string text);
        /// <summary>
        /// 無効設定
        /// </summary>
        /// <returns></returns>
        bool SetInvalid();
    }
}
