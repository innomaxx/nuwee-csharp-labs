

using MaxInno.NUWEE.Common;
using MaxInno.NUWEE.Common.Extensions;

namespace MaxInno.NUWEE.Labs.N2
{
    public static class Tasks
    {
        private static readonly int[] GeneratedArray =
            ArrayUtils.GenerateArray(15, () => RandomUtils.GetRandomInt(-50, 50));

        public static void Task1() // Task 2
        {
            ConsoleUtils.PrintEnumerable(GeneratedArray, 3);
        }

        public static void Task2() // Task 7
        {
            Console.WriteLine(" Оригiнальний масив:");
            ConsoleUtils.PrintEnumerable(GeneratedArray, 3);
            
            // a
            Console.WriteLine("\n Замiнити на 0 числа кратнi 10:");
            ConsoleUtils.PrintEnumerable(GeneratedArray.Select(item => item % 10 is 0 ? 0 : item), 3);

            // b
            Console.WriteLine("\n Непарнi збiльшити вдвiчi, парнi зменшити вдвiчi:");
            ConsoleUtils.PrintEnumerable(GeneratedArray.Select(item => item % 2 is 0 ? item / 2 : item * 2), 3);
        }

        public static void Task3() // Task 10
        {
            Console.WriteLine(" Оригiнальний масив:");
            ConsoleUtils.PrintEnumerable(GeneratedArray, 3);
            
            // TODO: add writeln
            ConsoleUtils.PrintEnumerable(GeneratedArray.OrderBy(item => item), 3);
        }

        public static void Task4() // Task 2 (lab 2.2)
        {
            const int length = 3, width = 3, fromNumber = -50, toNumber = 50;

            int[,] tdArray = ArrayUtils.Generate2DArray(length, width,
                () => RandomUtils.GetRandomInt(fromNumber, toNumber));

            ConsoleUtils.Print2DArray(tdArray);
            int sum = tdArray.ToLinearArray().Sum();

            Console.WriteLine("Сума: {0}", sum);
        }

        public static void Task5() // Task 10 (lab 2.2)
        {
            const int length = 4, width = 4;
            
            int[][] array = ArrayUtils.GenerateJaggedArray(length, width,() => RandomUtils.GetRandomInt(-5, 5));
            ConsoleUtils.PrintJaggedArray(array);

            var temp = new int[width];

            int possibleMoves = length / 2, movesUsed = 0;
            foreach (int upperIndex in Enumerable.Range(0, length))
            {
                int[] row1 = array[upperIndex];
                int[] row2 = array[array.GetLength(0) - 1 - upperIndex];
                
                Array.Copy(row1, temp, width);
                Array.Copy(row2, row1, width);
                Array.Copy(temp, row2, width);

                movesUsed++;
                if (movesUsed >= possibleMoves) break;
            }

            Console.WriteLine("\nAfter manipulations");
            ConsoleUtils.PrintJaggedArray(array);
        }

        // private static string WrapNumber(int num)
        // {
        //     const int width = 5;
        //     var numStr = num.ToString();
        //     int difference = width - numStr.Length;
        //     return $"{" ".Repeat(difference)}{numStr}";
        // }
    }
}

// Console.WriteLine(Divider, string.Join(" | ", GeneratedArray.Select(WrapNumber)));
            
// Console.WriteLine(Divider,
//     string.Join(" | ", GeneratedArray
//         .Select(item => item % 10 is 0 ? 0 : item)
//         .Select(WrapNumber)));
            
// Console.WriteLine(Divider,
//     string.Join(" | ", GeneratedArray
//         .Select(item => item % 2 is 0 ? item / 2 : item * 2)
//         .Select(WrapNumber)));

// var tdArray = new int[sideA, sideB];
//
// foreach (int upperDimIndex in Enumerable.Range(0, sideA))
// {
//     foreach (int lowerDimIndex in Enumerable.Range(0, sideB))
//     {
//         tdArray[upperDimIndex, lowerDimIndex] = RandomUtils.GetRandomInt(fromNumber, toNumber);
//     }
// }
            
// int sum = (from upperDimIndex in Enumerable.Range(0, length)
//     from lowerDimIndex in Enumerable.Range(0, width)
//     select tdArray[upperDimIndex, lowerDimIndex]).Sum();

//Console.WriteLine(Divider, string.Join(" | ", GeneratedArray.Select(WrapNumber)));

// int[] sortedArray = GeneratedArray.OrderBy(item => item).ToArray();
// Console.WriteLine(Divider, string.Join(" | ", sortedArray.Select(WrapNumber)));