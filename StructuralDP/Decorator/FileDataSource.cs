namespace DesignParttern.StructuralDP.Decorator
{
    /// <summary>
    /// Concrete components provide default implementations for the 
    /// operations. There might be several variations of these 
    /// classes in a program.
    /// </summary>
    class FileDataSource : IDataSource
    {
        public FileDataSource(string path) { }

        /// <summary>
        /// Write data to file
        /// </summary>
        public void ReadData()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Read data from file
        /// </summary>
        public void WriteData()
        {
            throw new System.NotImplementedException();
        }
    }
}
