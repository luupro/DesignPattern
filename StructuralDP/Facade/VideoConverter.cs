using System.IO;

namespace DesignParttern.StructuralDP.Facade
{
    /// <summary>
    /// We create the facade class to hide framework's complexity
    /// behind the simple interface. It's a trade-off between functionality
    /// and simplicity.
    /// </summary>
    public class VideoConverter
    {
        public VideoFile Convert(string fileName, string format)
        {
            var file = new VideoFile(fileName);
            var codecFactory = new CodecFactory();
            var sourceCodec = codecFactory.Extract(file);
            ICompressionCodec destinationCodec;
            if ("mpy4".Equals(format))
            {
                destinationCodec = new MPEG4CompressionCodec();
            }
            else
            {
                destinationCodec = new OggCompressionCodec();
            }

            var buffer = BitrateReader.Read(fileName, sourceCodec);
            var result = BitrateReader.Convert(buffer, destinationCodec);

            var audioMixer = new AudioMixer();
            result = audioMixer.Fix(result);

            return new VideoFile(result);
        }
    }
}
