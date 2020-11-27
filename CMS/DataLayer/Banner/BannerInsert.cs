using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.DataLayer.Banner
{
    public class BannerInsert
    {
        public bool Insert(Models.Banner banner)
        {
            using (Models.CMSContext db = new Models.CMSContext())
            {
                db.Banners.Add(banner);
            }
            return true;
        }
    }
}
