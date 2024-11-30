using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace FilterBase
{
    /// <summary>
    /// バージョン情報
    /// </summary>
    public class VersionInfo : IComparable<VersionInfo>
    {
        /// <summary>
        /// メジャーバージョン
        /// </summary>
        public int? Major { get; private set; } = null;
        /// <summary>
        /// マイナーバージョン
        /// </summary>
        public int? Minor { get; private set; } = null;
        /// <summary>
        /// ビルド番号
        /// </summary>
        public int? Build { get;private set; } = null;
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="text">バージョン文字列</param>
        public VersionInfo(string text)
        {
            Match match = Regex.Match(text, @"(\d+)\.(\d+)\.?(\d+)?");
            if ( match.Success)
            {
                if ((match.Groups.Count > 1) && (match.Groups[1].Success) &&
                    (match.Groups[1].Value != null) && (match.Groups[1].Value.Length > 0) &&
                    (int.TryParse(match.Groups[1].Value, out int n_1)))
                    Major = n_1;
                if ((match.Groups.Count > 2) && (match.Groups[2].Success) &&
                    (match.Groups[2].Value != null) && (match.Groups[2].Value.Length > 0) &&
                    (int.TryParse(match.Groups[2].Value, out int n_2)))
                    Minor = n_2;
                if ((match.Groups.Count > 3) && (match.Groups[3].Success) &&
                    (match.Groups[3].Value != null) && (match.Groups[3].Value.Length > 0) &&
                    (int.TryParse(match.Groups[3].Value, out int n_3)))
                    Build = n_3;
            }
        }
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="major">メジャーバージョン</param>
        /// <param name="minor">マイナーバージョン</param>
        /// <param name="build">ビルド番号</param>
        public VersionInfo(int? major=null, int? minor= null, int? build = null)
        {
            Major = major;
            Minor = minor;
            Build = build;
        }
        /// <summary>
        /// 比較
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        /// <remarks>
        /// 数値がnullの箇所は比較しない
        /// </remarks>
        public int CompareTo(VersionInfo other)
        {
            if (other == null) return 0;

            if ((Major.HasValue) && (other.Major.HasValue))
            {
                if (Major.Value != other.Major.Value)
                    return Major.Value - other.Major.Value;
            }
            if ((Minor.HasValue) && (other.Minor.HasValue))
            {
                if (Minor.Value != other.Minor.Value)
                    return Minor.Value - other.Minor.Value;
            }
            if ((Build.HasValue) && (other.Build.HasValue))
            {
                if (Build.Value != other.Build.Value)
                    return Build.Value - other.Build.Value;
            }
            return 0;
        }

        /// <summary>
        /// 比較
        /// </summary>
        /// <param name="major"></param>
        /// <param name="minor"></param>
        /// <param name="build"></param>
        /// <remarks>
        /// 数値がnullの箇所は比較しない
        /// </remarks>
        public int CompareTo(int? major = null,int? minor = null,int? build = null)
        {
            if ((Major.HasValue) && (major.HasValue))
            {
                if (Major.Value != major.Value)
                    return Major.Value - major.Value;
            }
            if ((Minor.HasValue) && (minor.HasValue))
            {
                if (Minor.Value != minor.Value)
                    return Minor.Value - minor.Value;
            }
            if ((Build.HasValue) && (build.HasValue))
            {
                if (Build.Value != build.Value)
                    return Build.Value - build.Value;
            }
            return 0;
        }
        /// <summary>
        /// 文字列変換
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string result = "";
            if (Major.HasValue) 
                result += Major.Value.ToString();
            if (Minor.HasValue)
                result += ((result.Length > 0) ? "." : "") + Minor.Value.ToString();
            if (Build.HasValue)
                result += ((result.Length > 0) ? "." : "") + Build.Value.ToString();

            return result;
        }
    }
}
