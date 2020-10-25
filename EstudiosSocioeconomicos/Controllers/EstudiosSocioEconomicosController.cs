using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EstudiosSocioeconomicos.Models;
using Microsoft.AspNet.Identity;

namespace EstudiosSocioeconomicos.Controllers
{
    public class EstudiosSocioEconomicosController : Controller
    {

        EstSocEcoModelContainer bd = new EstSocEcoModelContainer();
        // GET: EstudiosSocioEconomicos
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Encuestadores()
        {
            return View();
        }
        public JsonResult View_Encuestadores()
        {
            //string s_data = null;

            var s_data = bd.Encuestadores.ToList();
            
            var data = Json(s_data, JsonRequestBehavior.AllowGet);
            data.MaxJsonLength = int.MaxValue;
            return data;
        }
    }
}