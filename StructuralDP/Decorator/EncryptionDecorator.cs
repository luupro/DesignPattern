using System;
using System.Collections.Generic;
using System.Text;

namespace DesignParttern.StructuralDP.Decorator
{
    /// <summary>
    /// Concrete decorators must call methods on the wrapped object,
    /// but may add something of their own to the result. Decorators
    /// can execute the added behavior either before or after the 
    /// call to a wrapped object.
    /// </summary>
    public class EncryptionDecorator : DataSourceDecorator
    {
        public EncryptionDecorator(IDataSource source) : base(source)
        {
            this.wrappee = source;
        }

        /// <summary>
        /// 1. Encrypt passed data
        /// 2. Pass encrypted data to the wrappee's writeData
        /// method.
        /// </summary>
        public override void WriteData()
        {
            throw new NotImplementedException();

        }

        /// <summary>
        /// 1. Get data from wrappee's readData method.
        /// 2. Try to decrypt it if it's encrypted.
        /// 3. Return the result.
        /// </summary>
        public override void ReadData()
        {
            throw new NotImplementedException();

        }
    }
}
