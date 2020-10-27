using System.Collections.Generic;

namespace DesignParttern.StructuralDP.Proxy
{
    /// <summary>
    /// The concrete implementation of a service connector. Methods 
    /// of this class can request information form Youtube. The speed
    /// of the request depend on a user's internet connection as 
    /// well as Youtube's. The application will slow down if a lot of
    /// requests are fired as a same time, even if they all request 
    /// the same information.
    /// </summary>
    class ThirdPartyYoutubeClass : IThirdPartyYoutubeLib
    {
        public void DownloadVideo(int id)
        {
            // Download a video file from Youtube.
            throw new System.NotImplementedException();
        }

        public Video GetVideoInfo(int id)
        {
            // Get metadata about some video.
            throw new System.NotImplementedException();
        }

        public List<Video> ListVideos()
        {
            // Send an API request to YouTube.
            throw new System.NotImplementedException();
        }
    }
}
