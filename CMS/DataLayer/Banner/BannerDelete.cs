using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.DataLayer.Banner
{
    public class BannerDelete
    {
        public bool Delete(Models.Banner banner)
        {
            try
            {
                using (Models.CMSContext db = new Models.CMSContext())
                {
                    var id = db.Banners.Find(banner.IdBanner);
                    db.Banners.Remove(id);
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
