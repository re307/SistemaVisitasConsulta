using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EstudiosSocioeconomicos.Models.ViewModel
{
    public class EncuestasViewModel
    {

        public int id { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<int> Encuestadores_Id { get; set; }
        public Nullable<System.DateTime> AsingEncuestor { get; set; }
        public Nullable<System.DateTime> CreateRow { get; set; }
        public string s_CreateRow { get; set; }
        public Nullable<System.DateTime> ActiveCount { get; set; }
        public string s_ActiveCount { get; set; }
        public Nullable<System.DateTime> DesactiveCount { get; set; }
        public string s_DesactiveCount { get; set; }
        public Nullable<System.DateTime> UpdateCount { get; set; }
        public string s_UpdateCount { get; set; }

    }
}