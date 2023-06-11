namespace ExtensionsMethodsSample
{
    public static class Extensions
    {
        public static DateTime ToDate(this string value)
        {
            _ = DateTime.TryParse(value, out DateTime result);
            return result;
        }        
    }
}