using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appNotas.Capas.Entidades
{
    public class Notas
    {
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public string Nombre { get; set;  }
        public string Cedula { get; set; }
        public string Correo { get; set; }
        public string EscuelaProcendencia { get; set; }
        public float Porcentaje { get; set; }
        public float Espanniol5 { get; set; } 
        public float Matematica5 { get; set; }
        public float Ciencias5 { get; set; }
        public float EstudiosSociales5 { get; set; }
        public float Ingles5 { get; set; }
        public float Promedio5 { get; set; }
        public float Espanniol6 { get; set; }
        public float Matematica6 { get; set; }
        public float Ciencias6 { get; set; }
        public float EstudiosSociales6 { get; set; }
        public float Ingles6 { get; set; }
        public float Promedio6 { get; set; }
        public float PromedioTotalNotas { get; set; }
        public float PorcentajeNotas { get; set; }
        public float NotaConductaSexto { get; set; }
        public float PorcentajeConducta { get; set; }
        public float Sumatoria { get; set; }

        public override string ToString()
        {
            return $"Primer apellido: {Apellido1}, Segundo apellido: {Apellido2}, Nombre: {Nombre}, " +
                   $"Cédula: {Cedula}, Correo: {Correo}, Escuela de Procendencia: {EscuelaProcendencia}, " +
                   $"Porcentaje: {Porcentaje}, Nota español de 5°: {Espanniol5}, Nota matématica de 5°: {Matematica5}, " +
                   $"Ciencias5: {Ciencias5}, EstudiosSociales5: {EstudiosSociales5}, Ingles5: {Ingles5}, " +
                   $"Promedio5: {Promedio5}, Espanniol6: {Espanniol6}, Matematica6: {Matematica6}, " +
                   $"Ciencias6: {Ciencias6}, EstudiosSociales6: {EstudiosSociales6}, Ingles6: {Ingles6}, " +
                   $"Promedio6: {Promedio6}, PromedioTotalNotas: {PromedioTotalNotas}, " +
                   $"PorcentajeNotas: {PorcentajeNotas}, NotaConductaSexto: {NotaConductaSexto}, " +
                   $"PorcentajeConducta: {PorcentajeConducta}, Sumatoria: {Sumatoria}";
        }

    }
}
