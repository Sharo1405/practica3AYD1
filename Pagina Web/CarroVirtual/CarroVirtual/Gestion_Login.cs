using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarroVirtual
{
    public class Gestion_Login
    {
        public static int Ingreso(String nombre, String contrasenia)
        {
            if (nombre.Equals("administrador") && contrasenia.ToLower().Equals("1234"))
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}