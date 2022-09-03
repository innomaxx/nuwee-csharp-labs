
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;

namespace MaxInno.NUWEE.Labs.N9
{
    public static class Storage
    {
        private const string FileName = "towns.json";
        
        private static readonly JsonSerializerOptions Options = new()
        {
            WriteIndented = true
        };
        
        public static void WriteToFile(ICollection<Car> cars)
        {
            if (cars.Count is 0) return;
            
            using FileStream fileStream = File.Open(FileName, FileMode.Create, FileAccess.Write);
            JsonSerializer.Serialize(fileStream, cars, Options);
            
            // using FileStream fileStream = File.Open(FileName, FileMode.Create, FileAccess.Write);
            //
            // var formatter = new BinaryFormatter();
            // formatter.Serialize(fileStream, cars);
        }

        public static List<Car> ReadFromFile()
        {
            using FileStream fileStream = File.Open(FileName, FileMode.Open, FileAccess.Read);
            var cars = JsonSerializer.Deserialize<List<Car>>(fileStream, Options);

            if (cars is null)
            {
                throw new Exception("Помилка при десеріалізацiї");
            }
            
            return cars;

            // var formatter = new BinaryFormatter();
            // using FileStream fileStream = File.Open(FileName, FileMode.Open, FileAccess.Read);
            //
            // object r = formatter.Deserialize(fileStream);
            // return (List<Car>) r;
        }
    }
}