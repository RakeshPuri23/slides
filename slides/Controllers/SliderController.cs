using slides.DS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using slides.Models;

namespace slides.Controllers
{
    public class SliderController : Controller
    {
        private readonly SliderContext context;
        public SliderController()
        {
            context = new SliderContext();
        }
        // GET: Slider
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult SaveSlider(Slider s)
        {
            s.Files = Request.Files;
            HttpPostedFileBase file = s.Files[0];
            string fp = "~/Images/" + file.FileName;
            s.Filepath = fp;
           
                context.Sliders.Add(s);
                context.SaveChanges();
                file.SaveAs(Server.MapPath(fp));
                List<Slider> sliders = context.Sliders.ToList();
                return View("DisplaySliders", sliders);
          
        }
        public ActionResult DisplaySliders()
        {
            List<Slider> sliders = context.Sliders.ToList();
            return View(sliders);
        }

    }
}