
namespace Flyweight.Practice.MethodPoetExample
{
    /// <summary>
    /// A 'ConcreteFlyweight' class
    /// </summary>
    public class Square : Shape
    {
        // Constructor
        public Square()
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
