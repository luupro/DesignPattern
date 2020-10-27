using System.Collections.Generic;

namespace DesignParttern.StructuralDP.Proxy
{
    /// <summary>
    /// The interface of a remote service
    /// </summary>
    public interface IThirdPartyYoutubeLib
    {
        public List<Video> ListVideos();

        public Video GetVideoInfo(int id);

        public void DownloadVideo(int id);
    }
}
