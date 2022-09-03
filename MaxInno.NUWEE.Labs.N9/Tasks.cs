
using MaxInno.NUWEE.Common;
using MaxInno.NUWEE.Common.Extensions;

namespace MaxInno.NUWEE.Labs.N9
{
    public static class Tasks
    {
        public static void WriteToFile()
        {
            int count = ConsoleUtils.ReadUserInputAsNumberOrThrow(" Введiть кiлькiсть автомобiлiв");

            Car[] cars = ArrayUtils.GenerateArray(count,
                index =>
                {
                    Console.WriteLine("\n [Автомобiль {0}]", index + 1);
                    return CarConsoleUtils.ReadOne();
                });
            
            Storage.WriteToFile(cars);
            
            Console.WriteLine("\n Данi записано. Вивiд записаних даних:");
            cars.ForEach((car, index) => Console.WriteLine("\n [Автомобiль {0}]\n{1}", index + 1, car));
        }

        public static void ReadFromFile()
        {
            List<Car> cars = Storage.ReadFromFile();
            
            Console.WriteLine(" Отримано записанi данi. Вивiд:");
            cars.Print();
            ConsoleUtils.WaitForInput();
            
            Console.WriteLine(" Сортуємо колекцiю по зростанню значень");
            cars.Sort();
            cars.Print();
            ConsoleUtils.WaitForInput();
            
            Console.WriteLine(" Додаємо новий запис:");
            Car newCar = CarConsoleUtils.ReadOne();
            cars.Add(newCar);
            cars.Sort();
            ConsoleUtils.WaitForInput();
            
            Console.WriteLine(" Перелiк машин: {0}", cars.Count);
            cars.Print();
            ConsoleUtils.WaitForInput();
            
            Console.WriteLine(" Видаляємо останнє значення:");
            cars.RemoveAt(cars.Count - 1);
            Console.WriteLine("\n Перелiк машин що залишилися: {0}", cars.Count);
            cars.Print();
        }
    }
}