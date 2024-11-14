 using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppAtusPies.Entidades
{
    public class ClAdminE
    {
        public int idVendedor { get; set; }
        public string nombre { get; set; }
        public string documento { get; set; }
        public string email { get; set; }
        public string telefono { get; set; }
        public string estado { get; set; }
        public string password { get; set; }
    }
}