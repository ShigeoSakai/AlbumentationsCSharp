﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FilterBase.Enums;
using FilterBase;
namespace Filter.Geometric
{
    [ModuleCategory("geometric", "幾何学変換"), Index(0), DisplayName("グリッド歪み"), Description("画像、マスク、境界ボックス、キーポイントにグリッド歪みを適用します。\r\n\r\n" +
        "この変換は、画像をグリッドに分割し、各セルをランダムに歪ませて、局所的なワーピング効果を作成します。" +
        "これは、医療画像分析、OCR、および局所的な幾何学的変化が意味を持つその他のドメインなどのタスクでのデータ拡張に特に役立ちます。")]
    public partial class GridDistortion : BaseFilterControl
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public GridDistortion():base()
        {
            InitializeComponent();
            // ボーダーモードの変更
            BorderModeChange(ParaBorderMode.Value);
        }
        /// <summary>
        /// コンストラクタ（パラメータ指定）
        /// </summary>
        /// <param name="parameters">パラメータ</param>
        public GridDistortion(Dictionary<string, string> parameters) : this()
        {
            // パラメータ設定
            SetParameters(parameters);
        }
        /// <summary>
        /// バージョン指定コンストラクタ
        /// </summary>
        /// <param name="version">バージョン</param>
        public GridDistortion(VersionInfo version) : this()
        {
            Version = version;
        }

        /// <summary>
        /// バージョンの設定
        /// </summary>
        /// <param name="version"></param>
        protected override void SetVersion(VersionInfo version)
        {
            base.SetVersion(version);
            // バージョンの設定
            SetVersion(version, FLPParam.Controls);
        }
        /// <summary>
        /// パラメータのチェック
        /// </summary>
        /// <param name="err_msg"></param>
        /// <returns></returns>
        public override bool CheckParameter(out string err_msg)
        {
            return CheckParameter(FLPParam.Controls, out err_msg);
        }

        /// <summary>
        /// パラメータ引数の生成
        /// </summary>
        /// <returns></returns>
        protected override string GetArguments(bool always_apply = false)
        {
            if (CheckParameter(out _))
                return GetArguments(FLPParam.Controls, always_apply);
            return null;
        }
        /// <summary>
        /// パラメータの設定
        /// </summary>
        /// <param name="controls"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        protected override bool SetParameters(Dictionary<string, string> parameters)
        {
            bool result = SetParameters(FLPParam.Controls, parameters);
            result |= base.SetParameters(parameters);
            return result;
        }


        /// <summary>
        /// パラメータ変更イベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="name"></param>
        /// <param name="value"></param>
        private void Param_ParameterChange(object sender, string name, object value)
        {
            // イベント発行
            OnParameterChange(name, value);
        }
        /// <summary>
        /// ボーダーモード変更
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="index"></param>
        /// <param name="value"></param>
        private void ParaBorderMode_SelectedIndexChanged(object sender, int index, object value)
        {
            // ボーダーモードの変更
            BorderModeChange(value);
        }
        /// <summary>
        /// ボーダーモードの変更
        /// </summary>
        /// <param name="value"></param>
        private void BorderModeChange(object value)
        {
            if (value is BorderTypes item)
            {
                ParaValue.Enabled = (item.Value == CV2_BORDER.CONSTANT);
                ParaMaskValue.Enabled = (item.Value == CV2_BORDER.CONSTANT);
            }
        }

    }
}
