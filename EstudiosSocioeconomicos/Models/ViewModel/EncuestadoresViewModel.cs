using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EstudiosSocioeconomicos.Models.ViewModel
{
    public class EncuestadoresViewModel
    {

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public Nullable<bool> IsActive { get; set; }

    }
}