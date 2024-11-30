using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbumentationsCSharp
{
    public sealed class AppConfig : ApplicationSettingsBase
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public AppConfig() : base() { }

        /// <summary>
        /// 文字列値の取得
        /// </summary>
        /// <param name="key">キー</param>
        /// <param name="default_value">デフォルト値</param>
        /// <returns>文字列値</returns>
        private string GetString(string key, string default_value = "")
        {
            if ((this[key] != null) &&
                (this[key] is string s_value))
                return s_value;
            else
                return default_value;

        }
        /// <summary>
        /// Keyを指定して値を設定
        /// </summary>
        /// <param name="key">キー名</param>
        /// <param name="value">値</param>
        /// <returns>true:値を設定/更新した</returns>
        public bool SetValue<T>(string key, T value)
        {
            if ((this[key] == null) ||
                ((this[key] is T) == false) ||
                ((this[key] != null) &&
                 (this[key] is T s_value) &&
                 (s_value.Equals(value) == false)))
            {
                this[key] = value;
                Save();
                return true;
            }
            return false;
        }



        [UserScopedSetting()]
        public string PythonSetting
        {
            get => GetString("PythonSetting");
            set => SetValue("PythonSetting", value);            
        }
    }
}
