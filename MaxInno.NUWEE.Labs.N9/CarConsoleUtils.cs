
using MaxInno.NUWEE.Common;
using MaxInno.NUWEE.Common.Extensions;

namespace MaxInno.NUWEE.Labs.N9
{
    public static class CarConsoleUtils
    {
        public static Car ReadOne()
        {
            return new Car
            {
                Vendor =
                    ConsoleUtils.ReadRawUserInputOrThrow(FormPromptMessage("марку")),
                Model =
                    ConsoleUtils.ReadRawUserInputOrThrow(FormPromptMessage("марку")),
                Type =
                    ConsoleUtils.ReadUserInputAsEnumOrThrow<CarType>(FormPromptMessage("тип")),
                FuelType =
                    ConsoleUtils.ReadUserInputAsEnumOrThrow<FuelType>(FormPromptMessage("тип палива")),
                NumberOfSeats =
                    ConsoleUtils.ReadUserInputAsNumberOrThrow(FormPromptMessage("кiлькiсть мiсць")),
                Length =
                    ConsoleUtils.ReadUserInputAsNumberOrThrow(FormPromptMessage("довжину")),
                Weight =
                    ConsoleUtils.ReadUserInputAsNumberOrThrow(FormPromptMessage("вагу"))
            };
        }

        private static string FormPromptMessage(string subject) => $" Введiть {subject} автомобiля";

        public static void Print(this IEnumerable<Car> cars)
        {
            cars.ForEach((car, index) => Console.WriteLine("\n [Автомобiль {0}]\n{1}", index + 1, car));
        }
    }
}