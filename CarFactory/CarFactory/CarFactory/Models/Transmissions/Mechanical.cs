namespace CarFactory.Models.Transmissions
{
    public class Mechanical : ITransmission
    {
        public string Name { get; } = "Механическая";
        public int CountGear { get; } = 5;
    }
}
