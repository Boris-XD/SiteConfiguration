using Microsoft.AspNetCore.Mvc;
using SiteRecursives.Service.Sites;

namespace SiteRecursives.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SiteController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public SiteController(IConfiguration configuration) : base()
        {
            _configuration = configuration;
        }

        [HttpGet]
        public ActionResult<SiteMap> Get()
        {
            var site = new SiteRepository(_configuration);
            return Ok(site.GetSiteMap());
        }
    }
}
