
namespace Flyweight.Practice.HeadFirst
{
    //flyweight factory
    internal class TreesManager
    {
        private static Dictionary<TreeType, ITree> _flyweights = new();

        public ITree GetFlyweight(TreeType treeType)
        {
            //GoF: if flyweight exists, return existing flyweight
            //else create new, add to pool and return the new one
            if (_flyweights.ContainsKey(treeType))
                return _flyweights[treeType];
            else
            {
                ITree tree = new Tree("red");
                _flyweights.Add(treeType, tree);
                return tree;
            }
        }
    }
}
