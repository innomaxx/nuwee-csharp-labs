
namespace MaxInno.NUWEE.Common.Extensions
{
    public static class StringExtensions
    {
        public static string Repeat(this string str, int count)
        {
            var list = new List<string>();
        
            for (var i = 0; i < count; i++)
            {
                list.Add(str);
            }
        
            return string.Join("", list);
        }

        public static string WrapValue(this string value, int width)
        {
            int difference = width - value.Length;
            return $"{" ".Repeat(difference)}{value}";
        }

        private static readonly Dictionary<char, char> ReplacePairs = new()
        {
            { 'і', 'i' }
        };

        public static string ReplaceUnknownChars(this string value)
        {
            return ReplacePairs.Aggregate(value,
                (current, kvPair) => current.Replace(kvPair.Key, kvPair.Value));
        }
    }
}