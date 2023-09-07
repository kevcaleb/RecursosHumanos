using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using System.IO;

namespace RecursosHumanos
{
    public static class Global
    {
        
        public static string IDUsuario;
        public static string NumeroIdentidad = "";
        public static string Puesto = "";
        public static int editar = 0;
        private static SqlConnection conexion = new SqlConnection(Properties.Settings.Default.INHGEOMIN);

        
        /// <summary>
        /// Comprueba que el usuario tiene los privilegios para realizar la accion.
        /// </summary>
        /// <param name="IdPrivilegio">Indicar el id del privilegio a mostrar</param>
        /// <returns></returns>
        public static Boolean ComprobarPrivilegio(int IdPrivilegio)
        {
            bool resultado = false;
            try
            {
                resultado =  Procedimiento("[dbo].[p_ConsultarPrivilegioUsuario]", "@Id_Usuario", IDUsuario, "@Codigo_Privilegio", IdPrivilegio, "@Habilitado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return resultado;
        }

        public static bool Procedimiento(string procedimiento, string variable1, object valor1, string variable2, object valor2, string variableRetorno)
        {
            Boolean resultado = false;
            try
            {
                SqlCommand sql = new SqlCommand(procedimiento, conexion);
                sql.CommandType = System.Data.CommandType.StoredProcedure;
                sql.Parameters.AddWithValue(variable1, valor1);
                sql.Parameters.AddWithValue(variable2, valor2);
                SqlParameter retorno = sql.Parameters.Add(variableRetorno, System.Data.SqlDbType.Bit);//Le enviamos los parametros para el procedimiento almacenado se ejecute con exito y
                                                                                                                //nos devuleva el resultado en variableretorno, SqlDbType lo utilizamos para mandar que tipo de dato es el paramentro que estamos enviando
                retorno.Direction = System.Data.ParameterDirection.Output;//Preguntar para que sirve este
                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
                conexion.Open();
                sql.ExecuteNonQuery();
                resultado = Convert.ToBoolean(retorno.Value);
                conexion.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return resultado;
        }

        public static void ExportarGridExcel(GridControl GridControl)
        {
            try
            {
                var hoy = DateTime.Now;
                string pathTemp = Path.GetPathRoot(Environment.SystemDirectory) + "temp";

                pathTemp = pathTemp + "\\" + hoy.Year.ToString() + hoy.Month.ToString() + hoy.Day.ToString() + hoy.Second.ToString() + hoy.Millisecond.ToString() + ".xlsx";
                GridControl.ExportToXlsx(pathTemp);
                System.Diagnostics.Process.Start(pathTemp);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void ComprobarCarpetaTemporal()
        {
            try
            {
                string pathTemp = Path.GetPathRoot(Environment.SystemDirectory) + "temp";

                if (Directory.Exists(pathTemp) == false)
                {
                    Directory.CreateDirectory(pathTemp);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }

    
}
