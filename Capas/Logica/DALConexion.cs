using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appNotas.Capas.Logica
{
    class DALConexion
    {
        public static string Cadena
        {
            get
            {
                return ConfigurationManager.ConnectionStrings
                    ["Properties.Settings.Cadena"].
                    ConnectionString;

            }
        }
    }
}
