namespace DesignParttern.StructuralDP.Decorator
{
    /// <summary>
    /// The component interface defines operations that can be
    /// altered by decorators.
    /// </summary>
    public interface IDataSource
    {
        public void WriteData();
        public void ReadData();
    }
}
