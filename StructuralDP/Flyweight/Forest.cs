using System.Collections.Generic;

namespace DesignParttern.StructuralDP.Flyweight
{
    /// <summary>
    /// The tree and the Forest are the flyweight's clients.
    /// You can merge them if you don't plan to develop the Tree 
    /// class any further.
    /// </summary>
    class Forest
    {
        public List<Tree> trees { get; set; }

        public void PlanTree(int x, int y, string name, string color, string texture)
        {
            var type = TreeFactory.GetTreeType(name, color, texture);
            var tree = new Tree(x, y, type);
            trees.Add(tree);
        }

        public void Draw()
        {
            foreach (var elementTree in trees)
            {
                elementTree.Draw();
            }
        }
    }
}
