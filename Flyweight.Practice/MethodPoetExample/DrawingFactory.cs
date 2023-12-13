
namespace Flyweight.Practice.MethodPoetExample
{
    //flyweight factory
    internal class DrawingFactory
    {
        private Dictionary<string, Shape> shapes = new();
        Shape? shape = null;
        public Shape GetShape(string key)
        {
            if (shapes.ContainsKey(key))
            {
                shape = shapes[key];
            }
            else
            {
                switch (key)
                {
                    case "Triangle": shape = new Triangle(); break;
                    case "Square": shape = new Square(); break;
                    case "Rectangle": shape = new Rectangle(); break;
                }
                shapes.Add(key, shape);
            }
            return shape;
        }
    }
}
