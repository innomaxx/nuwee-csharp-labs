
using MaxInno.NUWEE.Common;

namespace MaxInno.NUWEE.Labs.N3
{
    public static class Tasks
    {
        public static void Addition()
        {
            int number1 = ConsoleUtils.ReadUserInputAsNumberOrThrow(" Введiть число 1");
            int number2 = ConsoleUtils.ReadUserInputAsNumberOrThrow(" Введiть число 2");
            Console.WriteLine(" Результат {0} + {1} = {2}", number1, number2, number1 + number2);
        }

        public static void Subtraction()
        {
            int number1 = ConsoleUtils.ReadUserInputAsNumberOrThrow(" Введiть число 1");
            int number2 = ConsoleUtils.ReadUserInputAsNumberOrThrow(" Введiть число 2");
            Console.WriteLine(" Результат {0} - {1} = {2}", number1, number2, number1 - number2);
        }

        public static void Multiplication()
        {
            int number1 = ConsoleUtils.ReadUserInputAsNumberOrThrow(" Введiть число 1");
            int number2 = ConsoleUtils.ReadUserInputAsNumberOrThrow(" Введiть число 2");
            Console.WriteLine(" Результат {0} * {1} = {2}", number1, number2, number1 * number2);
        }

        public static void Division()
        {
            int number1 = ConsoleUtils.ReadUserInputAsNumberOrThrow(" Введiть число 1");
            int number2 = ConsoleUtils.ReadUserInputAsNumberOrThrow(" Введiть число 2");

            if (number2 is 0)
            {
                Console.WriteLine(" Не можна дiлити на 0");
            }
            else
            {
                Console.WriteLine(" Результат {0} / {1} = {2}", number1, number2, number1 / number2);
            }
        }

        public static void Power()
        {
            int number = ConsoleUtils.ReadUserInputAsNumberOrThrow(" Введiть число");
            int power  = ConsoleUtils.ReadUserInputAsNumberOrThrow(" Введiть степiнь");
            
            Console.WriteLine(" Результат {0} ^ {1} = {2}", number, power, Math.Pow(number, power));
        }
    }
}