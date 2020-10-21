namespace DesignParttern.StructuralDP.Decorator
{
    /// <summary>
    /// Option 2. Client code that uses an external data source.
    /// SalaryManager objects neither know nor care about data
    /// storage specifics. They work with a pre-configured data
    /// source received from the app configurator.
    /// </summary>
    public class SalaryManager
    {
        public IDataSource source;

        public SalaryManager(IDataSource source)
        {
            this.source = source;
        }

        public void Load()
        {
            source.ReadData();
        }

        public void Save()
        {
            source.WriteData();
        }
    }
}
