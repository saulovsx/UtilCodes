using System.Text;
using System.Globalization;
using System.Text.RegularExpressions;

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

        public static string ToTitleCase(this string value)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(value.ToLower());
        }

        public static string RemoveNonAlphanumeric(this string value)
        {
            return Regex.Replace(value, @"[^a-zA-Z0-9\s]", "");
        }

        public static string ToISO8601(this DateTime dateTime, TimeSpan offset = default)
        {
            var offsetDateTime = dateTime.ToUniversalTime().Add(offset);
            var sign = (offset < TimeSpan.Zero) ? "-" : "+";
            return $"{offsetDateTime:yyyy-MM-ddTHH:mm:ss}{sign}{offset:h\\:mm}";
        }

        public static DateTimeOffset ToDateOffSet(this DateTime dateTime, TimeSpan offset = default)
        {
            return new DateTimeOffset(dateTime, offset);
        }
    }
}