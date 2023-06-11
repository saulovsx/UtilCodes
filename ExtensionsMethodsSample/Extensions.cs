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

    }
}