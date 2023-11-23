using appNotas.Capas.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appNotas.Capas.Logica
{
    public class ProblemaUno
    {
        public List<Notas> listNotas;

        //Cálculo de los promedios
        public double GetPromedio6()
        {
            double promSum = 0;
            int cantidad = 0;

            foreach (var promedio in listNotas)
            {
                promSum += promedio.Promedio6;
                cantidad++;
            }
            return Math.Round(promSum / cantidad, 4);
        }

        public double GetPromedio5()
        {
            double promSum = 0;
            int cantidad = 0;

            foreach (var promedio in listNotas)
            {
                promSum += promedio.Promedio5;
                cantidad++;
            }
            return Math.Round(promSum / cantidad, 4);
        }

        //Desviación Estándar 6 año

        public double GetDesvEstandar6()
        {
            double xi = 0;
            int cantidad = 0;

            foreach (var promedio in listNotas)
            {
                xi += Math.Pow(promedio.Promedio6 - GetPromedio6(), 2);
                cantidad++;
            }

            return Math.Round(Math.Sqrt(xi / (cantidad - 1)), 4);
        }

        //Z de 6año
        public double GetZLi6()
        {
            double cantidad = 0, z = 2.33;

            foreach (var promedio in listNotas)
            {
                cantidad++;
            }

            return Math.Round(GetPromedio6() - z * (GetDesvEstandar6() / Math.Sqrt(cantidad)), 4);
        }

        public double GetZLs6()
        {
            double cantidad = 0, z = 2.33;

            foreach (var promedio in listNotas)
            {
                cantidad++;
            }

            return Math.Round(GetPromedio6() + z * (GetDesvEstandar6() / Math.Sqrt(cantidad)), 4);
        }

        public string GetTotalZ6()
        {
            return GetZLi6() + " ≤ µ ≤ " + GetZLs6();
        }

        public double GetRestaZ6()
        {
            return Math.Round(GetZLs6() - GetZLi6(), 4);
        }

        //Z de 5 año
        public double GetZLi5()
        {
            double cantidad = 0, z = 2.33;

            foreach (var promedio in listNotas)
            {
                cantidad++;
            }

            return Math.Round(GetPromedio5() - z * (GetDesvEstandar6() / Math.Sqrt(cantidad)), 4);
        }

        public double GetZLs5()
        {
            double cantidad = 0, z = 2.33;

            foreach (var promedio in listNotas)
            {
                cantidad++;
            }

            return Math.Round(GetPromedio5() + z * (GetDesvEstandar6() / Math.Sqrt(cantidad)), 4);
        }

        public string GetTotalZ5()
        {
            return GetZLi5() + " ≤ µ ≤ " + GetZLs5();
        }

        public double GetRestaZ5()
        {
            return Math.Round(GetZLs5() - GetZLi5(), 4);
        }

        //Respuesta 
        public override string ToString()
        {
            return "Gracias a un nivel de confianza del 98% se determina que los niveles " +
                "de quinto y sexto año poseen porcentajes iguales en el total promedios obtenidos a lo largo del año"; 
        }
    }
}
