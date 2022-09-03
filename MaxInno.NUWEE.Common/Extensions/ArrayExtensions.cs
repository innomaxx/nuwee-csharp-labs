
namespace MaxInno.NUWEE.Common.Extensions
{
    public static class ArrayExtensions
    {
        public static IEnumerable<T> ToLinearArray<T>(this T[,] array)
        {
            return from upperDimIndex in Enumerable.Range(0, array.GetLength(0))
                   from lowerDimIndex in Enumerable.Range(0, array.GetLength(1))
                   select array[upperDimIndex, lowerDimIndex];
        }
    }
}