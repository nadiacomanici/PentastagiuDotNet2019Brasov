namespace ExtentionMethodsSample.Helpers
{
    public static class StringExtentionMethods
    {
        public static bool IsEmpty(this string str)
        {
            return (str == null
                || string.IsNullOrEmpty(str.Trim())
                || string.IsNullOrWhiteSpace(str.Trim()));
        }
    }
}
