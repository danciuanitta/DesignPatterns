
namespace Prototype.Practice
{
    internal class Report : IDocument
    {
        public string Title { get; set; }
        public string Content { get; set; }

        public void ShowInfo()
        {
            Console.WriteLine($"Report - Title: {Title}, Content: {Content}");
        }

        public object Clone()
        {
            return new Report { Title = this.Title, Content = this.Content };
        }
    }
}
