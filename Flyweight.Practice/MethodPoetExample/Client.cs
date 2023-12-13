
namespace Flyweight.Practice.MethodPoetExample
{
    internal class Client
    {
        public void Operation()
        {
            string[] draw = { "Triangle", "Rectangle", "Square", "Triangle" };

            DrawingFactory factory = new();

            // extrinsic state
            int position = 100;

            foreach (string drawing in draw)
            {
                position++;
                Shape shape = factory.GetShape(drawing);
                shape.Display(position);
            }
        }
    }
}
