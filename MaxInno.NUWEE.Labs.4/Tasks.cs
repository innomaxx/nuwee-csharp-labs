
using MaxInno.NUWEE.Common;
using MaxInno.NUWEE.Common.Extensions;
using MaxInno.NUWEE.Labs.N4.Library;

namespace MaxInno.NUWEE.Labs.N4
{
    public static class Tasks
    {
        public static void Task1()
        {
            Car car = CarConsoleUtils.ReadOne();
            Console.WriteLine("\n Данi про автомобiль:\n{0}", car);
        }

        public static void Task2()
        {
            int count = ConsoleUtils.ReadUserInputAsNumberOrThrow(" Введiть кiлькiсть автомобiлiв");

            Car[] cars = ArrayUtils.GenerateArray(count,
                index =>
                {
                    Console.WriteLine("\n [Автомобiль {0}]", index + 1);
                    return CarConsoleUtils.ReadOne();
                });

            Console.WriteLine("\n Данi записано. Вивiд записаних даних:");
            cars.ForEach((car, index) => Console.WriteLine("\n [Автомобiль {0}]\n{1}", index + 1, car));
        }
    }
}