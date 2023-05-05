using Microsoft.Extensions.Configuration;

namespace SiteRecursives.Service.Sites
{
    public class SiteRepository
    {
        private readonly IConfiguration _configuration;
        public const string SiteMapSectionName = "SiteMap";

        public SiteRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public SiteMap GetSiteMap()
        {
            var siteMapSection = _configuration.GetSection(SiteMapSectionName);
            return siteMapSection.Get<SiteMap>();
        }
    }
}
