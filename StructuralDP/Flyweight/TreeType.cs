namespace DesignParttern.StructuralDP.Flyweight
{
    /// <summary>
    /// The flyweight class contains a portion of the state of a
    /// tree, These fields store values that are unique for each
    /// particular tree. For instance, you won't find here the tree
    /// coordinates. But the texture and color shared between many
    /// tree are here. Since this data is usually BIG, you'd waste a
    /// lot of memory by keeping it in each tree object. Instead, we
    /// can extract texture, color and other repeating data into a
    /// separate object which lots of individual tree objects can
    /// reference.
    /// </summary>
    public class TreeType
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public string Texture { get; set; }

        public TreeType(string name, string color, string texture) { }

        public void Draw(int x, int y)
        {
            throw new System.NotImplementedException();
        } //params: canvas, x, y

    }
}
