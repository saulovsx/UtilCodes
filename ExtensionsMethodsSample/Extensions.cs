using System.Text;
using System.Globalization;
namespace ExtensionsMethodsSample
{
    public static class Extensions
    {
        public static DateTime ToDate(this string value)
        {
            _ = DateTime.TryParse(value, out DateTime result);
            return result;
        }

        public static string RemoveAccent(this string text)
        {
            var textWithoutAccent = new string(text.Normalize(NormalizationForm.FormD)
                                 .Where(ch => CharUnicodeInfo.GetUnicodeCategory(ch) != UnicodeCategory.NonSpacingMark)
                                 .ToArray());
            return textWithoutAccent;
        }

        public static string ToPath(this DateTime date, string directoryBase = "")
        {
            if(date == DateTime.MinValue || date == DateTime.MaxValue)
                return string.Empty;
            return Path.Combine(directoryBase, $"{date.Year}",$"{date.Month:D2}",$"{date.Day:D2}");
        }

        public static bool ContainsValue(this string value)
        {
            return !string.IsNullOrWhiteSpace(value);
        }
    }
}