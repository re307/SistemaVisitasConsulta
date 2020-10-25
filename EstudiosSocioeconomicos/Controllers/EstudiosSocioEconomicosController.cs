using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EstudiosSocioeconomicos.Models;
using EstudiosSocioeconomicos.Models.ViewModel;
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

            List<EncuestadoresViewModel> s_data = new List<EncuestadoresViewModel>();
            s_data = bd.Encuestadores.Select(x => new EncuestadoresViewModel
            {
                Nombre = x.Nombre
                ,ApellidoPaterno = x.ApellidoPaterno
                ,ApellidoMaterno = x.ApellidoMaterno
                ,IsActive = x.IsActive

            }).ToList();
            
            var data = Json(s_data, JsonRequestBehavior.AllowGet);
            data.MaxJsonLength = int.MaxValue;
            return data;
        }
        public ActionResult Encuestas()
        {
            return View();
        }
        public JsonResult View_Encuestas()
        {
            List<EncuestasViewModel> s_data = new List<EncuestasViewModel>();

            s_data = bd.Encuestas.Select(x => new EncuestasViewModel{ 

                Nombre = x.Nombre
                ,ApellidoPaterno = x.ApellidoPaterno
                ,ApellidoMaterno = x.ApellidoMaterno
                ,IsActive = x.IsActive
                ,Encuestadores_Id = x.Encuestadores_Id
                ,AsingEncuestor = x.AsingEncuestor
                ,s_CreateRow = x.CreateRow.ToString()
                ,s_ActiveCount = x.ActiveCount.ToString()
                ,s_DesactiveCount = x.DesactiveCount.ToString()
                ,s_UpdateCount = x.UpdateCount.ToString()

            }).ToList();

            var data = Json(s_data, JsonRequestBehavior.AllowGet);
            data.MaxJsonLength = int.MaxValue;
            return data;
        }
    }
}