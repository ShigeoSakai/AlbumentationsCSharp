using AlbumentationsCSharp.Composition;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlbumentationsCSharp
{
    public partial class PythonEnvForm : Form
    {
        /// <summary>
        /// Python実行環境コンボボックス用クラス
        /// </summary>
        private class ComboboxItem
        {
            /// <summary>
            /// 名前
            /// </summary>
            public string Name { get; private set; }
            /// <summary>
            /// Enum値
            /// </summary>
            public PythonSetting.PYTHON_ENV PythonEnv { get; private set; }
            /// <summary>
            /// GroupBox
            /// </summary>
            public GroupBox GroupBox { get; private set; }

            /// <summary>
            /// コンストラクタ
            /// </summary>
            /// <param name="name"></param>
            /// <param name="env"></param>
            /// <param name="groupBox"></param>
            public ComboboxItem(string name, PythonSetting.PYTHON_ENV env, GroupBox groupBox)
            {
                Name = name;
                PythonEnv = env;
                GroupBox = groupBox;
            }
            /// <summary>
            /// 文字列変換
            /// </summary>
            /// <returns></returns>
            public override string ToString()
            {
                return Name;
            }
            /// <summary>
            /// コンボボックスに追加
            /// </summary>
            /// <param name="comboBox"></param>
            /// <param name="name"></param>
            /// <param name="env"></param>
            /// <param name="groupBox"></param>
            public static void Add(ComboBox comboBox,string name, PythonSetting.PYTHON_ENV env,GroupBox groupBox)
            {
                comboBox.Items.Add(new ComboboxItem(name, env ,groupBox));
            }
            /// <summary>
            /// コンボボックスの選択アイテムを取得
            /// </summary>
            /// <param name="comboBox"></param>
            /// <param name="default_value"></param>
            /// <returns></returns>
            public static PythonSetting.PYTHON_ENV GetValue(ComboBox comboBox, PythonSetting.PYTHON_ENV default_value)
            {
                if ((comboBox != null) && (comboBox.SelectedItem != null) &&
                    (comboBox.SelectedItem is ComboboxItem item))
                    return item.PythonEnv;
                return default_value;
            }

            /// <summary>
            /// コンボボックスで選択されているアイテムを取得し、パネルの有効無効を設定
            /// </summary>
            /// <param name="comboBox"></param>
            /// <param name="panel"></param>
            public static void ItemSelected(ComboBox comboBox,FlowLayoutPanel panel)
            {
                if ((comboBox != null) && (comboBox.SelectedItem != null))
                {
                    if (comboBox.SelectedItem is ComboboxItem item)
                    {
                        foreach(Control ctrl in panel.Controls)
                        {
                            ctrl.Visible = ctrl.Equals(item.GroupBox);
                        }
                    }
                }
            }
            /// <summary>
            /// コンボボックスの所定enumを選択
            /// </summary>
            /// <param name="comboBox"></param>
            /// <param name="env"></param>
            /// <returns></returns>
            public static bool Select(ComboBox comboBox, PythonSetting.PYTHON_ENV env)
            {
                if ((comboBox != null) && (comboBox.Items.Count > 0))
                {
                    for(int index = 0; index < comboBox.Items.Count; index ++)
                    {
                        if (comboBox.Items[index] is ComboboxItem item)
                            if (item.PythonEnv == env)
                            {
                                comboBox.SelectedIndex = index;
                                return true;
                            }
                    }
                }
                return false;
            }
        }
        /// <summary>
        /// Python設定
        /// </summary>
        public PythonSetting Setting { get; private set; }


        /// <summary>
        /// コンストラクタ(ダミー)
        /// </summary>
        /// <param name="dummy"></param>
        private PythonEnvForm(int dummy)
        {
            InitializeComponent();

            // コンボボックスの設定
            CbPythonSelect.Items.Clear();
            ComboboxItem.Add(CbPythonSelect, "Anaconda環境", PythonSetting.PYTHON_ENV.ANACONDA, GbAnaconda);
            ComboboxItem.Add(CbPythonSelect, "Python venv環境", PythonSetting.PYTHON_ENV.VENV, GbvEnv);
            ComboboxItem.Add(CbPythonSelect, "直接実行", PythonSetting.PYTHON_ENV.NORMAL, GbDirect);
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public PythonEnvForm() :this((PythonSetting)null)
        {
        }
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="setting"></param>
        public PythonEnvForm(PythonSetting setting) :this(0)
        {
            if (setting != null)
            {   // パラメータをコピー
                Setting = new PythonSetting(setting);
            }
            else
            {
                // デフォルトでパラメータを生成
                Setting = new PythonSetting();
                Setting.UsePythonEnv = PythonSetting.PYTHON_ENV.NORMAL;
            }

            // コンボボックスを選択
            ComboboxItem.Select(CbPythonSelect, Setting.UsePythonEnv);
            // パラメータ内容をコピー
            TbAnacondaPath.Text = Setting.AnacondaPath;
            TbvEnvPath.Text = Setting.vEnvPath;
            TbPythonPath.Text = Setting.PythonPath;
            TbBaseFolder.Text = Setting.InitDirectory;

            // コンボボックスに設定
            CbAnacondaEnv.Text = Setting.AnacondaEnv;
            CbvEnvName.Text = Setting.vEnvName;
        }

        /// <summary>
        /// OKボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtOK_Click(object sender, EventArgs e)
        {
            // 設定を生成
            PythonSetting temp = new PythonSetting(
                ComboboxItem.GetValue(CbPythonSelect, PythonSetting.PYTHON_ENV.NORMAL),
                TbAnacondaPath.Text,
                CbAnacondaEnv.Text,
                TbvEnvPath.Text,
                CbvEnvName.Text,
                TbBaseFolder.Text,
                TbPythonPath.Text);
            if (temp.Check(out string err_msg) == false) 
            {
                string msg = string.Format("設定エラーです。\r\n{0}\r\nこのままの内容でよろしいですか？", err_msg);
                DialogResult msgResult = MessageBox.Show(msg,"確認",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if (msgResult != DialogResult.Yes)
                    return;
            }
            // 設定をコピー
            Setting = new PythonSetting(temp);

            DialogResult = DialogResult.OK;
            this.Close();
        }
        /// <summary>
        /// キャンセルボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtCancel_Click(object sender, EventArgs e)
        {
            DialogResult= DialogResult.Cancel;
            this.Close();
        }
        /// <summary>
        /// Pythonコンボボックスの選択
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbPythonSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboboxItem.ItemSelected(CbPythonSelect, FLPanel);
        }

        /// <summary>
        /// Anaconda Envコンボボックス作成
        /// </summary>
        /// <param name="comboBox"></param>
        /// <param name="anacondaPath"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        private int MakeAnacondaComboBox(ComboBox comboBox, string anacondaPath, string value)
        {
            comboBox.Items.Clear();
            if ((anacondaPath != null) && (Directory.Exists(anacondaPath)))
            {
                string cmd = "\"" +Path.Combine(anacondaPath, "conda") + "\" env list";
                string result = CmdExecutor.InstantlyExecute(cmd);
                string[] results = result.Split(new string[] { Environment.NewLine },StringSplitOptions.RemoveEmptyEntries);
                foreach (string s in results)
                {
                    if (s.StartsWith("#") == false)
                    {
                        string[] p = s.Split(new string[] { "  " }, StringSplitOptions.RemoveEmptyEntries);
                        if (p.Length >= 2)
                        {
                            comboBox.Items.Add(p[0]);
                        }
                    }
                }
                if (comboBox.Items.Count > 0)
                {
                    bool isSet = false;
                    if (string.IsNullOrEmpty(value) == false)
                    {
                        for(int index = 0; index < comboBox.Items.Count; index++)
                        {
                            if (comboBox.Items[index].ToString() == value)
                            {
                                isSet = true;
                                comboBox.SelectedIndex = index; 
                                break;
                            }
                        }
                    }
                    if (isSet == false)
                        comboBox.SelectedIndex = 0;
                }
            }
            return comboBox.Items.Count;
        }
        /// <summary>
        /// Anaconda Env 一覧取得
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtGetCondaEnv_Click(object sender, EventArgs e)
        {
            // 現在の内容を保存
            string text = CbAnacondaEnv.Text;
            //　コンボボックス作成
            MakeAnacondaComboBox(CbAnacondaEnv, TbAnacondaPath.Text, text);
        }
        /// <summary>
        /// Python venv環境一覧作成
        /// </summary>
        /// <param name="comboBox"></param>
        /// <param name="vEnvPath"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        private int MakeVEnvComboBox(ComboBox comboBox, string vEnvPath, string value)
        {
            comboBox.Items.Clear();
            if ((vEnvPath != null) && (Directory.Exists(vEnvPath)))
            {
                foreach(string dir in Directory.GetDirectories(vEnvPath))
                {
                    if ((Directory.Exists(Path.Combine(dir, @"Scripts"))) && 
                        (File.Exists(Path.Combine(dir, @"Scripts\activate.bat"))))
                    {
                        comboBox.Items.Add(Path.GetFileName(dir));
                    }
                }
                if (comboBox.Items.Count > 0)
                {
                    bool isSet = false;
                    if (string.IsNullOrEmpty(value) == false)
                    {
                        for (int index = 0; index < comboBox.Items.Count; index++)
                        {
                            if (comboBox.Items[index].ToString() == value)
                            {
                                isSet = true;
                                comboBox.SelectedIndex = index;
                                break;
                            }
                        }
                    }
                    if (isSet == false)
                        comboBox.SelectedIndex = 0;
                }
            }
            return comboBox.Items.Count;
        }
        /// <summary>
        /// Python venv環境一覧取得
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtGetvEnv_Click(object sender, EventArgs e)
        {
            // 現在の内容を保存
            string text = CbvEnvName.Text;
            //　コンボボックス作成
            MakeVEnvComboBox(CbvEnvName, TbvEnvPath.Text, text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CompositionForm form = new CompositionForm();
            form.ShowDialog();
        }
    }
}
