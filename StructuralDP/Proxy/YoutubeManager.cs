namespace DesignParttern.StructuralDP.Proxy
{
    /// <summary>
    /// The GUI class, which used to work directly with a service
    /// object, stays unchanged as long as it works with the service
    /// object through an interface. We can safely pass a proxy
    /// object instead of a real service ojbect since they both
    /// implement the same interface.
    /// </summary>
    public class YoutubeManager
    {
        protected IThirdPartyYoutubeLib service;

        public YoutubeManager(IThirdPartyYoutubeLib service)
        {
            this.service = service;
        }

        public void RenderVideoPage(int id)
        {
            var info = service.GetVideoInfo(id);
            // Render the video page.
        }

        public void RenderListPanel()
        {
            var list = service.ListVideos();
            // Render the list of video thumbnails.
        }

        public void reactOnUserInput(int id)
        {
            RenderVideoPage(id);
            RenderListPanel();
        }
    }
}
