
namespace MaxInno.NUWEE.Common
{
    public static class ArrayUtils
    {
        public static T[] GenerateArray<T>(int length, Func<T> getValueFn)
        {
            return new T[length].Select(_ => getValueFn()).ToArray();
        }
        
        public static T[] GenerateArray<T>(int length, Func<int, T> getValueFn)
        {
            return new T[length].Select((_, i) => getValueFn(i)).ToArray();
        }
        
        public static T[,] Generate2DArray<T>(int length, int width, Func<T> getValueFn)
        {
            var tdArray = new T[length, width];
            foreach (int upperDimIndex in Enumerable.Range(0, length))
            {
                foreach (int lowerDimIndex in Enumerable.Range(0, width))
                {
                    tdArray[upperDimIndex, lowerDimIndex] = getValueFn();
                }
            }

            return tdArray;
        }

        public static T[][] GenerateJaggedArray<T>(int length, int width, Func<T> getValueFn)
        {
            var tdArray = new T[length][];

            foreach (int upperIndex in Enumerable.Range(0, length))
            {
                tdArray[upperIndex] = new T[width];

                foreach (int lowerIndex in Enumerable.Range(0, width))
                {
                    tdArray[upperIndex][lowerIndex] = getValueFn();
                }
            }
            
            return tdArray;
        }
    }
}