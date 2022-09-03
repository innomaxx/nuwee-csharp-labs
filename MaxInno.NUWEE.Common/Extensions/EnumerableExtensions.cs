
namespace MaxInno.NUWEE.Common.Extensions
{
    public static class EnumerableExtensions
    {
        public static void ForEach<T>(this IEnumerable<T> collection, Action<T, int> function)
        {
            var counter = 0;

            foreach (T element in collection)
            {
                function(element, counter);
                counter++;
            }
        }
    }
}