
using System.ComponentModel;
using System.Reflection;
using System.Text;
using MaxInno.NUWEE.Common.Extensions;

namespace MaxInno.NUWEE.Labs.N10
{
    [Serializable]
    public class Car : IComparable<Car>
    {
        [Description("Виробник")]
        public string Vendor { get; init; }
        
        [Description("Модель")]
        public string Model { get; init; }
        
        [Description("Тип кузова")]
        public CarType Type { get; init; }
        
        [Description("Тип палива")]
        public FuelType FuelType { get; init; }

        [Description("Кiлькiсть сидiнь")]
        public int NumberOfSeats { get; init; }
        
        [Description("Загальна довжина")]
        public int Length { get; init; }
        
        [Description("Вага")]
        public int Weight { get; init; }

        [Description("Екологiчно чистий?")]
        public bool IsEcologicalVehicle => FuelType is FuelType.Electric;

        [Description("Економiчно вигiдний?")]
        public bool IsEconomicallyAffordable => new[] { FuelType.Electric, FuelType.Gas }.Contains(FuelType);

        public override string ToString()
        {
            var builder = new StringBuilder();
            
            foreach (PropertyInfo property in
                     GetType().GetProperties().Where(property =>
                         property.CanRead &&
                         property.IsDefined(typeof(DescriptionAttribute))))
            {
                object? rawValue = property.GetValue(this);
                if (rawValue is null) continue;

                string value = property switch
                {
                    { PropertyType.IsEnum: true }
                        => Enum.GetName(property.PropertyType, rawValue)!,
                    
                    { } info when info.PropertyType == typeof(bool)
                        => ((bool) rawValue).ToUserString(),

                    _ => rawValue.ToString()!
                };

                string description = property.GetCustomAttribute<DescriptionAttribute>()!.Description;
                builder.AppendLine($" * {description}: {value}");
            }

            return builder.ToString().TrimEnd();
        }

        public int CompareTo(Car? other)
        {
            if (other is null)
            {
                throw new ArgumentNullException(nameof(other));
            }
            
            return string.CompareOrdinal(Model, other.Model);
        }
    }
}