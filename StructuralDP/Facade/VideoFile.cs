using System;

namespace DesignParttern.StructuralDP.Facade
{
    public class VideoFile
    {
        private object result;

        public VideoFile(string filename)
        {
        }

        public VideoFile(object result)
        {
            this.result = result;
        }

        internal void save()
        {
            throw new NotImplementedException();
        }
    }
}
