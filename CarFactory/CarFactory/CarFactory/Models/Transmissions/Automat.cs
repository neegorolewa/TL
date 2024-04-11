namespace CarFactory.Models.Transmissions
{
    public class Automat : ITransmission
    {
        public string Name { get; } = "Автомат";
        public int CountGear { get; } = 6;
    }
}
