namespace DesignParttern.StructuralDP.Decorator
{
    public class DataSourceDecorator : IDataSource
    {
        protected IDataSource wrappee;

        public DataSourceDecorator(IDataSource source)
        {
            this.wrappee = source;
        }

        /// <summary>
        /// The base decorator simply delegates all work to the
        /// wrapped component. Extra behavior can be added in
        /// concrete decorators.
        /// </summary>
        public virtual void WriteData()
        {
            wrappee.WriteData();
        }

        /// <summary>
        /// Concrete decorator may call the parent implementation of 
        /// the operation instead of calling the wrapped object
        /// directly. This approach simplifies extension of decorator classes
        /// </summary>
        public virtual void ReadData()
        {
            wrappee.ReadData();
        }
    }
}
