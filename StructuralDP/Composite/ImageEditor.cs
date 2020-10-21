using System.Collections.Generic;

namespace DesignParttern.StructuralDP.Composite
{
    /// <summary>
    /// The client code work with all the components via their base
    /// interface. This way the client code can support simple leaf
    /// components as well as complex composites.
    /// </summary>
    public class ImageEditor
    {
        private CompoundGraphic all;
        public void load()
        {
            all = new CompoundGraphic();
            all.Add(new Dot(1, 2));
            all.Add(new Circle(5, 3, 10));
            //...
        }

        /// <summary>
        /// combine selected components into one complex composite
        /// component.
        /// </summary>
        /// <param name="components"></param>
        public void GroupSelected(List<IGraphic> components)
        {
            var group = new CompoundGraphic();
            group.Add(components);
            all.Remove(components);
            all.Add(group);
            all.Draw();
        }
    }
}
