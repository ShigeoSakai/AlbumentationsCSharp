using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilterBase.Parts
{
    public static class PartsFunc
    {
        /// <summary>
        /// デザインモード判定
        /// </summary>
        /// <param name="ctrl"></param>
        /// <returns></returns>
        public static bool IsDesigneMode(Control ctrl)
        {
            bool mode = false;
            if (ctrl != null)
            {
                if (ctrl.Site != null)
                    mode = ctrl.Site.DesignMode;
                Control parent = ctrl.Parent;
                while (parent != null)
                {
                    if (parent.Site != null)
                    {
                        mode |= parent.Site.DesignMode;
                    }
                    parent = parent.Parent;
                }
                return mode;
            }
            return false;
        }
        /// <summary>
        /// オブジェクトの文字列を取得する
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string GetObjectToString(object value)
        {
            return (value != null) ? value.ToString() : string.Empty;
        }
        /// <summary>
        /// オブジェクトに値を設定する
        /// </summary>
        /// <param name="obj">オブジェクト</param>
        /// <param name="value">設定する文字列</param>
        /// <returns>true:設定OK</returns>
        /// <remarks>
        ///   bool → 文字列 → Enum → 数値の順に判定をする
        ///   objがnullの場合は、文字列を設定する
        /// </remarks>
        public static bool SetObjectFromString(ref object obj, string value)
        {
            if (obj != null)
            {
                // objの型
                Type type = obj.GetType();

                if ((obj is bool) && (bool.TryParse(value, out bool b_value)))
                {   // bool型
                    obj = b_value;
                    return true;
                }
                else if (obj is string)
                {   // 文字列
                    obj = value;
                    return true;
                }
                else if (obj is Enum)
                {   // Enum

                    // TryParse()を検索する
                    foreach (MethodInfo m_info in typeof(Enum).GetMethods(BindingFlags.Static | BindingFlags.Public)
                        .Where(m => m.Name == "TryParse")
                        .OrderByDescending(m => m.GetParameters().Length))
                    {
                        // Enum.TryParse<TEnum>()が見つかる --> ジェネリックなので、
                        //   ContainsGenericParametersがtrue
                        if (m_info.ContainsGenericParameters)
                        {
                            // 型を指定してジェネリックメソッドを生成する
                            MethodInfo gen_mathod = m_info.MakeGenericMethod(new Type[] { type });
                            // パラメータ領域の確保
                            object[] para = new object[gen_mathod.GetParameters().Length];
                            // パラメータを格納する
                            int index = 0;
                            para[index++] = value;
                            //    パラメータ数が3の場合は、IgnoreCaseフラグを設定
                            if (para.Length > 2)
                                para[index++] = true;

                            // メソッドを呼び出す
                            bool result = (bool)gen_mathod.Invoke(obj, para);
                            // 結果を格納
                            obj = para[index];
                            return result;
                        }
                    }
                }
                else if (obj is ValueType)
                {   // 数値
                    //   TryParse()を検索する
                    MethodInfo info = type.GetMethod("TryParse",
                        BindingFlags.Static | BindingFlags.Public,
                        null,
                        new Type[] { typeof(string), type.MakeByRefType() },
                        null);
                    if (info != null)
                    {
                        // パラメータを作成
                        object[] para = new object[] { value, null };
                        // メソッドを呼び出す
                        bool result = (bool)info.Invoke(obj, para);
                        // 結果を格納
                        obj = para[1];
                        return result;
                    }
                }
            }
            else
            {
                // nullの場合は文字列を設定する
                obj = value;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Tuple同士に差があるか？
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool TupleDiff(Tuple<decimal, decimal> a, Tuple<decimal, decimal> b)
        {
            if ((a == null) && (b == null))
                return false;   // 違わない
            if ((a == null) || (b == null))
                return true;    // 違う
            if ((a.Item1 != b.Item1) || (a.Item2 != b.Item2))
                return true;    // 違う
            return false;       // 違わない
        }
		/// <summary>
		/// Tuple同士に差があるか？
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <returns></returns>
		public static bool TupleDiff(Tuple<decimal, decimal, decimal> a, Tuple<decimal, decimal,decimal> b)
		{
			if ((a == null) && (b == null))
				return false;   // 違わない
			if ((a == null) || (b == null))
				return true;    // 違う
			if ((a.Item1 != b.Item1) || (a.Item2 != b.Item2) || (a.Item3 != b.Item3))
				return true;    // 違う
			return false;       // 違わない
		}

		/// <summary>
		/// 値のタイプ
		/// </summary>
		public enum VALUE_TYPE
        {
            TYPE_INT,       // 整数
            TYPE_INT_ODD,   // 奇数のみ
            TYPE_INT_EVEN,  // 偶数のみ
            TYPE_FLOAT,     // float
        }
        /// <summary>
        /// Tupple<Decimal, Decimal>を文字列変換
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string GetTuppleToString(Tuple<decimal, decimal> value,VALUE_TYPE valueType,int decimalPlace)
        {
            if (value != null)
            {
                string num_format = "#0";
                if (valueType == VALUE_TYPE.TYPE_FLOAT)
                    num_format += "." + new string('0', decimalPlace);

                string fmt = "({0:" + num_format + "},{1:" + num_format + "})";
                return string.Format(fmt, value.Item1, value.Item2);
            }
            return string.Empty;
        }
		/// <summary>
		/// Tupple<Decimal, Decimal>を文字列変換
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		public static string GetTuppleToString(Tuple<decimal, decimal,decimal> value, VALUE_TYPE valueType, int decimalPlace)
		{
			if (value != null)
			{
				string num_format = "#0";
				if (valueType == VALUE_TYPE.TYPE_FLOAT)
					num_format += "." + new string('0', decimalPlace);

				string fmt = "({0:" + num_format + "},{1:" + num_format + "},{2:" + num_format + "})";
				return string.Format(fmt, value.Item1, value.Item2,value.Item3);
			}
			return string.Empty;
		}
		/// <summary>
		/// 文字列からTupple<>に変換
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		public static Tuple<decimal, decimal> GetTuppleFromString(string value, VALUE_TYPE valueType)
        {
            if (value != null)
            {
                string text = value.Trim();
                if (text.Length > 0)
                {
                    if ((text.StartsWith("(")) == (text.EndsWith(")")))
                    {
                        if (text.StartsWith("("))
                            text = text.Substring(1, text.Length - 2);

                        decimal? first = null;
                        decimal? second = null;
                        // 型のチェック
                        if (valueType != VALUE_TYPE.TYPE_FLOAT)
                        {
                            Match match = Regex.Match(text, @"([+-]?\d+)\s*\,\s*([+-]?\d+)");
                            if (match.Success)
                            {
                                if (match.Groups.Count > 2)
                                {
                                    if ((match.Groups[1].Success) && (match.Groups[1].Value != null) &&
                                        (match.Groups[1].Value.Trim().Length > 0) &&
                                        (int.TryParse(match.Groups[1].Value, out int v1)))
                                        first = v1;
                                    if ((match.Groups[2].Success) && (match.Groups[2].Value != null) &&
                                        (match.Groups[2].Value.Trim().Length > 0) &&
                                        (int.TryParse(match.Groups[2].Value, out int v2)))
                                        second = v2;
                                }
                            }
                        }
                        else
                        {
                            Match match = Regex.Match(text, @"([+-]?\d+\.?\d*)\s*\,\s*([+-]?\d+\.?\d*)");
                            if (match.Success)
                            {
                                if (match.Groups.Count > 2)
                                {
                                    if ((match.Groups[1].Success) && (match.Groups[1].Value != null) &&
                                        (match.Groups[1].Value.Trim().Length > 0) &&
                                        (float.TryParse(match.Groups[1].Value, out float v1)))
                                        first = (decimal)v1;
                                    if ((match.Groups[2].Success) && (match.Groups[2].Value != null) &&
                                        (match.Groups[2].Value.Trim().Length > 0) &&
                                        (float.TryParse(match.Groups[2].Value, out float v2)))
                                        second = (decimal)v2;
                                }
                            }
                        }
                        if ((first.HasValue) && (second.HasValue))
                        {
                            return new Tuple<decimal, decimal>(first.Value, second.Value);
                        }
                    }
                }
            }
            return null;
        }
		/// <summary>
		/// 文字列からTupple<>に変換
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		public static Tuple<decimal, decimal,decimal> Get3TuppleFromString(string value, VALUE_TYPE valueType)
		{
			if (value != null)
			{
				string text = value.Trim();
				if (text.Length > 0)
				{
					if ((text.StartsWith("(")) == (text.EndsWith(")")))
					{
						if (text.StartsWith("("))
							text = text.Substring(1, text.Length - 2);

						decimal? first = null;
						decimal? second = null;
                        decimal? third = null;
						// 型のチェック
						if (valueType != VALUE_TYPE.TYPE_FLOAT)
						{
							Match match = Regex.Match(text, @"([+-]?\d+)\s*\,\s*([+-]?\d+)\s*\,\s*([+-]?\d+)");
							if (match.Success)
							{
								if (match.Groups.Count > 3)
								{
									if ((match.Groups[1].Success) && (match.Groups[1].Value != null) &&
										(match.Groups[1].Value.Trim().Length > 0) &&
										(int.TryParse(match.Groups[1].Value, out int v1)))
										first = v1;
									if ((match.Groups[2].Success) && (match.Groups[2].Value != null) &&
										(match.Groups[2].Value.Trim().Length > 0) &&
										(int.TryParse(match.Groups[2].Value, out int v2)))
										second = v2;
									if ((match.Groups[3].Success) && (match.Groups[3].Value != null) &&
										(match.Groups[3].Value.Trim().Length > 0) &&
										(int.TryParse(match.Groups[3].Value, out int v3)))
										third = v3;
								}
							}
						}
						else
						{
							Match match = Regex.Match(text, @"([+-]?\d+\.?\d*)\s*\,\s*([+-]?\d+\.?\d*)\s*,\s*([+-]?\d+\.?\d*)");
							if (match.Success)
							{
								if (match.Groups.Count > 3)
								{
									if ((match.Groups[1].Success) && (match.Groups[1].Value != null) &&
										(match.Groups[1].Value.Trim().Length > 0) &&
										(float.TryParse(match.Groups[1].Value, out float v1)))
										first = (decimal)v1;
									if ((match.Groups[2].Success) && (match.Groups[2].Value != null) &&
										(match.Groups[2].Value.Trim().Length > 0) &&
										(float.TryParse(match.Groups[2].Value, out float v2)))
										second = (decimal)v2;
									if ((match.Groups[3].Success) && (match.Groups[3].Value != null) &&
										(match.Groups[3].Value.Trim().Length > 0) &&
										(float.TryParse(match.Groups[3].Value, out float v3)))
										third = (decimal)v3;
								}
							}
						}
						if ((first.HasValue) && (second.HasValue) && (third.HasValue))
						{
							return new Tuple<decimal, decimal,decimal>(first.Value, second.Value,third.Value);
						}
					}
				}
			}
			return null;
		}
		/// <summary>
		/// 偶数・奇数の補正をする
		/// </summary>
		/// <param name="value"></param>
		/// <param name="isEven">偶数か？</param>
		/// <param name="isUp">切り上げか？</param>
		/// <returns></returns>
		public static decimal GetAdjustValue(decimal value, bool isEven, bool isUp)
        {
            int adjust_value = (isUp) ? +1 : -1;
            int check_value = (isEven) ? 0 : 1;

            int item1 = (int)value;
            // 補正
            if ((item1 & 0x01) != check_value)
                item1 += adjust_value;
            return (decimal)item1;
        }
    }
}
