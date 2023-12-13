
namespace Flyweight.Practice.MethodPoetExample
{
    /// <summary>
    /// A 'ConcreteFlyweight' class
    /// </summary>
    public class Rectangle : Shape
    {
        public Rectangle()
        {
            _name = "Square";
            _height = 100;
            _width = 120;
        }
        public override void Display(int position)
        {
            this._position = position;
            Console.WriteLine(_name +
                " (position " + this._position + ")");
        }
    }
}
