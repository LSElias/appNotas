using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using appNotas.Capas.Entidades;

namespace appNotas.Capas.Logica
{
    internal class DALNotas
    {
        public List<Notas> GetAllNotas()
        {
            SqlCommand command = new SqlCommand();
            List<Notas> lista = new List<Notas>();
            try
            {
                using (IDataBase db = FactoryDatabase.CreateDefaultDataBase())
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.CommandText = "dbo.usp_SELECT_NOTAS_All";

                    DataSet ds = db.ExecuteDataSet(command);

                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        Notas notas = new Notas();
                        notas.Apellido1 = dr["Apellido1"].ToString();
                        notas.Apellido2 = dr["Apellido2"].ToString();
                        notas.Nombre = dr["Nombre "].ToString();
                        notas.Cedula = dr["Cedula"].ToString();
                        notas.Correo = dr["Correo"].ToString();
                        notas.EscuelaProcendencia = dr["EscuelaProcedencia "].ToString();
                        notas.Porcentaje = float.Parse(dr["Porcentaje "].ToString());
                        notas.Espanniol5 = float.Parse(dr["Espanniol5"].ToString());
                        notas.Matematica5 = float.Parse(dr["Matematica5"].ToString());
                        notas.Ciencias5 = float.Parse(dr["Ciencias5"].ToString());
                        notas.EstudiosSociales5 = float.Parse(dr["EstudiosSociales5"].ToString());
                        notas.Ingles5 = float.Parse(dr["Ingles5"].ToString());
                        notas.Promedio5 = float.Parse(dr["Promedio5 "].ToString());
                        notas.Espanniol6 = float.Parse(dr["Espanniol6"].ToString());
                        notas.Matematica6 = float.Parse(dr["Matematica6"].ToString());
                        notas.Ciencias6 = float.Parse(dr["Ciencias6"].ToString());
                        notas.EstudiosSociales6 = float.Parse(dr["EstudiosSociales6"].ToString());
                        notas.Ingles6 = float.Parse(dr["Ingles6"].ToString());
                        notas.Promedio6 = float.Parse(dr["Promedio6"].ToString());
                        notas.PromedioTotalNotas = float.Parse(dr["PromedioTotalNotas"].ToString());
                        notas.PorcentajeNotas = float.Parse(dr["PorcentajeNotas "].ToString());
                        notas.NotaConductaSexto = float.Parse(dr["NotaConductaSexto"].ToString());
                        notas.PorcentajeConducta = float.Parse(dr["PorcentajeConducta "].ToString());
                        notas.Sumatoria = float.Parse(dr["Sumatoria "].ToString());

                        lista.Add(notas);
                    }
                    return lista;
                }
            }
            catch (SqlException sqlError)
            {
                Console.WriteLine(sqlError.Message);
                throw;
            }
            catch (Exception er)
            {
                Console.WriteLine(er.Message);
                throw;
            }
        }
    }
}
