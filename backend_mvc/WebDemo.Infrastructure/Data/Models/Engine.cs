namespace WebDemo.Infrastructure.Data.Models
{
    public class Engine
    {
        public int Id { get; set; }
        public string SerialNumber { get; set; } = string.Empty;
        public double Liters { get; set; }
        public int HorsePower { get; set; }
        public int Nm { get; set; }
        public bool IsDiesel { get; set; }
        public bool IsTurbo { get; set; }
        public bool IsSupercharged { get; set; }
        public int NumberOfCylinders { get; set; }
    }
}