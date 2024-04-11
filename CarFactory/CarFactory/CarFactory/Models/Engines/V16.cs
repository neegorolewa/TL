namespace CarFactory.Models.Engines
{
    public class V16 : IEngine
    {
        public string Name { get; } = "V-16";
        public int MaxSpeed { get; } = 200;
    }
}
