using CMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CMS.DataLayer.Header
{
    public class BannerGet
    {

        public List<Models.Banner> Get()
        {
            using (CMS.Models.CMSContext db = new CMS.Models.CMSContext())
            {
                var List = (from d in db.Banners
                            select d).ToList();
                return List;
            }
        }
    }
}
