namespace DesignParttern.StructuralDP.Facade
{
    /// <summary>
    /// Application class don't depend on a bilion classes
    /// provided by the complex framework. Also, if you decide to
    /// switch frameworks, you only need to rewrite the facade class.
    /// </summary>
    public class Application
    {
        public void MainProcess()
        {
            var convertor = new VideoConverter();
            var mp4 = convertor.Convert("youtubevideo.ogg", "mp4");
            mp4.save();
        }
    }
}
