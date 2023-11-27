using appNotas.Capas.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appNotas.Capas.Logica
{
    public class ProblemaDos
    {

        public List<Notas> listNotas;

        //Cálculo de el promedio 6
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

        //Cálculo de el promedio 5
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

        //Cálculo de la desviación estándar del nivel de sexto año
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

        //Cálculo de Z utilizando su fórmula.
        public double GetZ()
        {
            double cantidad = 0, z = 0;

            foreach (var promedio in listNotas)
            {
                cantidad++;
            }

            z = Math.Round((GetPromedio6() - GetPromedio5()) / (GetDesvEstandar6() / Math.Sqrt(cantidad)), 4);

            return z;
        }

        public override string ToString()
        {
            return "Con un nivel de significancia del 5% no se rechaza la hipótesis nula, " +
                "debido a que no hay evidencia estadística suficiente para determinar que el " +
                "promedio de notas de los niveles de sexto año sean superiores al promedio de " +
                "notas de los niveles de quinto año. ";
        }

    }
}
