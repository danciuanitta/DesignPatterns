
namespace Flyweight.Practice.HeadFirst
{
    //client
    internal class LandscapeClient
    {
        public void DrawTree()
        {
            //this is hardcoded only to show example
            TreeType[] neededTrees = { TreeType.Oak, TreeType.Magnolia, TreeType.Oak, TreeType.Beech, TreeType.Beech };

            TreesManager factory = new();

            // extrinsic state
            int xCoordinate = 1;
            int yCoordinate = 1;

            foreach (var tree in neededTrees)
            {
                xCoordinate++;
                yCoordinate++;
                ITree shape = factory.GetFlyweight(tree);
                shape.Display(xCoordinate, yCoordinate);
            }
        }
    }
}
