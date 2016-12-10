using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using netCoreCodeFirst.Entities;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace netCoreCodeFirst.Controllers
{
    [Route("[controller]/[action]")]
    public class Home : Controller
    {
        [Route("~/"),Route("~/Home"),Route("~/Home/Index")]
  
        public IActionResult Index()
        {
            return View();
        }
       
        public JsonResult Gonder(string kadi,string pass)
        {
            try
            {
                LikePanelEntities ent = new LikePanelEntities();
                var sorgu = new Kullanicilar();
                sorgu.Kadi = kadi;
                sorgu.Sifre = pass;
                ent.Kullanicilar.Add(sorgu);
                ent.SaveChanges();
                return Json("1");
            }
            catch (Exception ex)
            {
            return Json(ex.Message);
            }
        }

    }
}
