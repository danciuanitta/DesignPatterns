
namespace Prototype.Practice
{
    // Dynamic Object Creation
    internal class Client
    {
        public void SomeMethod()
        {
            // Create prototype instances
            IDocument resumePrototype = new Resume { Name = "John Doe", Experience = "5 years" };
            IDocument reportPrototype = new Report { Title = "Monthly Report", Content = "Lorem ipsum" };

            // Create instances dynamically based on the prototype
            IDocument newResume = (IDocument)resumePrototype.Clone();
            IDocument newReport = (IDocument)reportPrototype.Clone();

            // Display information
            newResume.ShowInfo();
            newReport.ShowInfo();
        }
    }
}
