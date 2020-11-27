using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.DataLayer.Banner
{
    public class BannerEdit
    {
        public bool Edit(Models.Banner banner)
        {
            try
            {
                using (Models.CMSContext db = new Models.CMSContext())
                {
                    var id = db.Banners.Find(banner.IdBanner);
                    id.Header = banner.Header;
                    db.Entry(id).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;

            }
        }
    }
}
