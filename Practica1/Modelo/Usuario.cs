using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    public class Usuario
    {
        String user;
        String pass;
        bool esAdmin;

        //Usuario del que mantendremos la sesión
        public static Usuario u;

        public Usuario(string user, string pass, bool esAdmin)
        {
            this.User = user;
            this.Pass = pass;
            this.EsAdmin = esAdmin;
        }
        public Usuario() { }

        public string User { get => user; set => user = value; }
        public string Pass { get => pass; set => pass = value; }
        public bool EsAdmin { get => esAdmin; set => esAdmin = value; }
    }
}
