namespace DesignParttern.StructuralDP.Decorator
{
    /// <summary>
    /// The app can assemble different stacks of decorators at
    /// runtime, depending on the configuration or environment.
    /// </summary>
    class ApplicationConfigurator
    {
        public void ConfigurationExample()
        {
            var source = new FileDataSource("salary.data");

            // if (enabledEncryption)
            // source = new EncryptionDecorator(source)
            // if (enabledCompression)
            // source = new CompressionDecorator(source)

            var logger = new SalaryManager(source);
            //var salary = logger.Load();
        }
    }
}
