namespace DesignParttern.StructuralDP.Proxy
{
    public class Application
    {
        public void Init()
        {
            var aYouTubeService = new ThirdPartyYoutubeClass();
            var aYouTubeProxy = new CachedYoutubeClass(aYouTubeService);
            var manager = new YoutubeManager(aYouTubeProxy);
            manager.reactOnUserInput(3);
        }
    }
}
