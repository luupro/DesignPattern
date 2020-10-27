namespace DesignParttern.BehavioralDP.COR
{
    /// <summary>
    /// Primitive components may be fine with default help
    /// implementation...
    /// </summary>
    class Button : Component
    {
        public Button(int x, int y, int width, int height, string name)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            this.name = name;
        }
    }
}
