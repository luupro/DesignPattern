namespace DesignParttern.StructuralDP.Decorator
{
    /// <summary>
    /// Option 1. A simple example of a decorator assembly.
    /// </summary>
    class Application
    {
        public void DumbUsageExample()
        {
            IDataSource source = new FileDataSource("somefile.data");
            source.WriteData();
            // The target file has been written with plain data.

            source = new CompressionDecorator(source);
            source.WriteData();
            // The target file has been written with compressed data.

            source = new EncryptionDecorator(source);
            source.WriteData();
            // The target file has been written with encrypted data.
        }
    }
}
