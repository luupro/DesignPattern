using System.Collections.Generic;

namespace DesignParttern.BehavioralDP.COR
{
    /// <summary>
    /// Container can contain both simple components and other
    /// containers as children. The chain relationship are 
    /// established here. The class inherits showHelp behavior from
    /// its parent.
    /// </summary>
    abstract class Container : Component
    {
        protected List<Component> children;


        public void Add(Component child)
        {
            children.Add(child);
            child.container = this;
        }


    }
}
