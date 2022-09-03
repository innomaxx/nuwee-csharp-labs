
using MaxInno.NUWEE.Common;

namespace MaxInno.NUWEE.Labs.N4.Library
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
    }
}