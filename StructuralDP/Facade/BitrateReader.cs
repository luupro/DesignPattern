using System;
using System.Collections.Generic;
using System.Text;

namespace DesignParttern.StructuralDP.Facade
{
    class BitrateReader
    {
        public static object Read(string fileName, VideoConverter sourceCodec)
        {
            throw new NotImplementedException();
        }

        public static object Convert(object buffer, ICompressionCodec destinationCodec)
        {
            throw new NotImplementedException();
        }
    }
}
