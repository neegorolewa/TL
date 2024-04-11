namespace CarFactory.Models.Engines
{
    internal class Electric : IEngine
    {
        public string Name { get; } = "Электрический";
        public int MaxSpeed { get; } = 300;
    }
}
