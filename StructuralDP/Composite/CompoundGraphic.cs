using System;
using System.Collections.Generic;

namespace DesignParttern.StructuralDP.Composite
{
    /// <summary>
    /// The composite class represents complex components that may
    /// have children. Composite objects usually deletegate the actual
    /// work to their children and then "sum up" the result.
    /// </summary>
    class CompoundGraphic : IGraphic
    {
        public List<IGraphic> Children { get; set; }

        /// <summary>
        /// A composite object can add or remove other components.
        /// ( both simple or complex) to or from its child list.
        /// </summary>
        /// <param name="child"></param>
        public void Add(IGraphic child)
        {
            Children.Add(child);
        }

        public void Add(List<IGraphic> children)
        {
            Children.AddRange(children);
        }

        public void Remove(IGraphic child)
        {
            Children.Remove(child);
        }

        public void Remove(List<IGraphic> children)
        {
            foreach (var child in children)
            {
                if (Children.Contains(child))
                {
                    Children.Remove(child);
                }
            }
        }

        /// <summary>
        /// A composite executes its primary logic in a particular
        /// way. It traverses recursively through all its children,
        /// collecting and summing up their results. Since the
        /// composite's children pass these calls to their own
        /// children and so forth, the whole object tree is traversed
        /// as a result.
        /// </summary>
        public void Draw()
        {
            // 1. For each child component:
            //      - Draw the component.
            //      - Update the bounding rectangle
            // 2. Draw a dashed rectangle using the bounding
            // coordinates.
            throw new NotImplementedException();
        }

        public void Move(int x, int y)
        {
            foreach (var child in Children)
            {
                child.Move(x, y);
            }

        }
    }
}
