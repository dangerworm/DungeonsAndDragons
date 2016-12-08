namespace DungeonsAndDragons_Data
{
    public static class StringHelper
    {
        public static bool IsNullOrWhiteSpace(string value)
        {
            return value == null || value.Trim().Length == 0;
        }

        public static string Trim(string value)
        {
            return string.IsNullOrEmpty(value) ? null : value.Trim();
        }
    }
}
