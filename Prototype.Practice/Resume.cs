
namespace Prototype.Practice
{
    internal class Resume : IDocument
    {
        public string Name { get; set; }
        public string Experience { get; set; }

        // Strongly typed Clone method
        public IDocument Clone()
        {
            return new Resume { Name = this.Name, Experience = this.Experience };
        }

        // Explicit interface implementation
        object ICloneable.Clone()
        {
            return Clone();
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Resume - Name: {Name}, Experience: {Experience}");
        }
    }
}
