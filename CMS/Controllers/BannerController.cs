using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CMS.DataLayer.Banner;
using CMS.DataLayer.Header;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BannerController : ControllerBase
    {
        [HttpGet]

        [Route("Get")]
        public ActionResult Get()
        {
            BannerGet banner = new BannerGet();
            return Ok(banner.Get());
        }
        [HttpPost]
        public ActionResult Post(Models.Banner banner)
        {
            BannerInsert bannerInsert = new BannerInsert();
            return Ok(bannerInsert.Insert(banner));
        }
        [HttpPut]
        public ActionResult Put(Models.Banner banner)
        {
            BannerEdit bannerEdit = new BannerEdit();
            return Ok(bannerEdit.Edit(banner));
        }
    }
}
