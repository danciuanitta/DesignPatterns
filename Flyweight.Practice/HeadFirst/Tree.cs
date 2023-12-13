//concrete shared flyweight

namespace Flyweight.Practice.HeadFirst
{
    internal class Tree : ITree
    {
        //intrinsic state -- correct example?
        private readonly string Color;

        public Tree(string color)
        {
             Color = color;
        }
        public void Display(int x, int y)
        {
            Console.WriteLine($"Tree with given coordinates: X = {x} and Y= {y} has the color = {Color}");
        }
    }
}
