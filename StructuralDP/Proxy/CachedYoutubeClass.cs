using System;
using System.Collections.Generic;

namespace DesignParttern.StructuralDP.Proxy
{
    /// <summary>
    /// To save some bandwidth, we can cache request results and keep
    /// them for some time. But it may be impossible to put such code
    /// directly into the service class. For example, it could have
    /// been provided as part of a third party library and/or defined
    /// as `final`. That's why we put the caching code into a new
    /// proxy class with implements the same interface as the
    /// service class. It delegates on the service object only when
    /// the real requests have to be sent.
    /// </summary>
    class CachedYoutubeClass : IThirdPartyYoutubeLib
    {
        private readonly ThirdPartyYoutubeClass service; // for CachedYoutubeClass
        private List<Video> listCache;
        private Video videoCache;

        public bool NeedReset { get; set; }

        public CachedYoutubeClass(ThirdPartyYoutubeClass service)
        {
            this.service = service;
        }

        public void DownloadVideo(int id)
        {
            if (!DownloadExists(id) || NeedReset)
            {
                service.DownloadVideo(id);
            }
        }

        private bool DownloadExists(int id)
        {
            var searchObj = listCache.Find(x => x.VideoId == id);

            return !(searchObj is null);
        }

        public Video GetVideoInfo(int id)
        {
            if (videoCache is null || NeedReset)
            {
                videoCache = service.GetVideoInfo(id);
            }
            return videoCache;
        }

        public List<Video> ListVideos()
        {
            if (listCache is null || NeedReset)
            {
                listCache = service.ListVideos();
            }
            return listCache;
        }
    }
}
