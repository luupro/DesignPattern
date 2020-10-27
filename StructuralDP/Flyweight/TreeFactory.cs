using System.Collections.Generic;

namespace DesignParttern.StructuralDP.Flyweight
{
    /// <summary>
    /// Flyweight factory decides whether to re-use existing
    /// flyweight or to create a new object.
    /// </summary>
    public static class TreeFactory
    {
        private static List<TreeType> treeTypes = new List<TreeType>();
        public static TreeType GetTreeType(string name, string color, string texture)
        {
            var result = treeTypes.Find(x => FindWithStringCondition(name, x.Name) &&
                FindWithStringCondition(color, x.Color) &&
                FindWithStringCondition(texture, x.Texture));

            if (result is null)
            {
                var type = new TreeType(name, color, texture);
                treeTypes.Add(type);
            }

            return result;
        }

        private static bool FindWithStringCondition(string name, string currentValue)
        {
            return string.IsNullOrEmpty(name) || name.Equals(currentValue);
        }
    }
}
