namespace CarFactory.Models.Engines
{
    public class V8 : IEngine
    {
        public string Name { get; } = "V-8";
        public int MaxSpeed { get; } = 150;
    }
}
