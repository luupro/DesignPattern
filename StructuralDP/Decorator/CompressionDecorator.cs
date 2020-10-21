using System;
using System.Collections.Generic;
using System.Text;

namespace DesignParttern.StructuralDP.Decorator
{
    public class CompressionDecorator : DataSourceDecorator
    {
        public CompressionDecorator(IDataSource source) : base(source)
        {
            this.wrappee = source;
        }

        /// <summary>
        /// 1. Compress passed data.
        /// 2. Pass compressed data to the wrappee's writeData
        /// method.
        /// </summary>
        public override void WriteData()
        {
            throw new NotImplementedException();

        }

        /// <summary>
        /// 1. Get data from wrappee's readData method.
        /// 2. Try to decrypt it if it's compressed.
        /// 3. Return the result.
        /// </summary>
        public override void ReadData()
        {
            throw new NotImplementedException();

        }
    }
}
