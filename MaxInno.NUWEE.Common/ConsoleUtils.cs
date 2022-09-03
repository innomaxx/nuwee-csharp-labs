
using System.Text;
using MaxInno.NUWEE.Common.Extensions;

namespace MaxInno.NUWEE.Common
{
    public static class ConsoleUtils
    {
        public static string? ReadRawUserInput(string title)
        {
            Console.Write("{0}: ", title);
            return Console.ReadLine();
        }

        public static string ReadRawUserInputOrThrow(string title)
        {
            string? input = ReadRawUserInput(title);

            if (string.IsNullOrWhiteSpace(input))
            {
                throw new ArgumentException("порожнiй рядок");
            }

            return input;
        }

        public static int ReadUserInputAsNumberOrThrow(string title)
        {
            string input = ReadRawUserInputOrThrow(title);

            if (!int.TryParse(input, out int parsedNumber))
            {
                throw new ArgumentException("ввiд не є числом");
            }

            return parsedNumber;
        }

        public static TEnum ReadUserInputAsEnumOrThrow<TEnum>(string title) where TEnum : struct, Enum
        {
            string input = ReadRawUserInputOrThrow(title);

            if (!Enum.TryParse(input, out TEnum parsedValue))
            {
                string message = new StringBuilder()
                    .AppendLine($"перелiчення \"{typeof(TEnum).Name}\" не мiстить елементу \"{input}\"")
                    .AppendLine($" Можливi значення: {string.Join(" / ", Enum.GetNames(typeof(TEnum)))}")
                    .ToString().TrimEnd();
                
                throw new ArgumentException(message);
            }

            return parsedValue;
        }

        public static void PrintEnumerable<T>(IEnumerable<T> array, int width = 5)
        {
            Console.WriteLine(" | {0} |", string.Join(" | ", array.Select(item => item.ToString().WrapValue(width))));
        }
        
        public static void Print2DArray<T>(T[,] array, int width = 5)
        {
            foreach (int upperIndex in Enumerable.Range(0, array.GetLength(0)))
            {
                Console.Write(" ");
                foreach (int lowerIndex in Enumerable.Range(0, array.GetLength(1)))
                {
                    Console.Write("| {0} ", array[upperIndex, lowerIndex].ToString().WrapValue(width));
                }
                Console.WriteLine(" |");
            }
        }

        public static void PrintJaggedArray<T>(T[][] array, int width = 5)
        {
            foreach (int upperIndex in Enumerable.Range(0, array.Length))
            {
                Console.Write(" ");
                foreach (int lowerIndex in Enumerable.Range(0, array[upperIndex].Length))
                {
                    Console.Write("| {0} ", array[upperIndex][lowerIndex].ToString().WrapValue(width));
                }
                Console.WriteLine(" |");
            }
        }

        public static void WaitForInput(string message = "Натиснiть Enter для продовження...")
        {
            Console.WriteLine($"\n {message}");
            Console.ReadLine();
        }
    }
}