namespace Flyweight.Practice.MethodPoetExample
{
    /// <summary>
    /// The 'Flyweight' abstract class
    /// </summary>
    public abstract class Shape
    {
        protected string _name = string.Empty;
        protected int _width;
        protected int _height;
        protected int _position;
        public abstract void Display(int position);
    }
}
