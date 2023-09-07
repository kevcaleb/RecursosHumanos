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



namespace RecursosHumanos
{
    class Datos : frmPrincipal
    {
        SqlConnection conexion = new SqlConnection(Properties.Settings.Default.INHGEOMIN);
                                                                                          

        public void AbrirConexion()
        {
            try
            {
                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }

                conexion.Open();
            }
            catch (SqlException ex)
            {
                MostrarError(ex.Message);
            }
        }

        public void CerrarConexion()
        {
            try
            {
                conexion.Close();
            }
            catch (SqlException ex)
            {
                MostrarError(ex.Message);
            }
        }

        


        public object ProcedimientoRetorno(string procedimiento, string variable1, object valor1, string variableRetorno)     
        {
            object resultado = 0;
            try
            {
                SqlCommand sql = new SqlCommand(procedimiento, conexion);
                sql.CommandType = System.Data.CommandType.StoredProcedure;
                sql.Parameters.AddWithValue(variable1, valor1);
                SqlParameter retorno = sql.Parameters.Add(variableRetorno, System.Data.SqlDbType.VarChar, 10);
                retorno.Direction = System.Data.ParameterDirection.Output;
                AbrirConexion();
                sql.ExecuteNonQuery();
                resultado = retorno.Value;
                CerrarConexion();
            }
            catch (SqlException ex)
            {
                MostrarError(ex.Message);
            }


            return resultado;
        }

        public object ProcedimientoRetorno(string procedimiento, string variable1, object valor1, string variable2, object valor2, string variableRetorno)   
        {
            object resultado = 0;
            try
            {
                SqlCommand sql = new SqlCommand(procedimiento, conexion);
                sql.CommandType = System.Data.CommandType.StoredProcedure;
                sql.Parameters.AddWithValue(variable1, valor1);
                sql.Parameters.AddWithValue(variable2, valor2);
                SqlParameter retorno = sql.Parameters.Add(variableRetorno, System.Data.SqlDbType.VarChar, 10);
                                                                                                              
                retorno.Direction = System.Data.ParameterDirection.Output;

                AbrirConexion();
                sql.ExecuteNonQuery();
                resultado = retorno.Value;
                CerrarConexion();
            }
            catch (SqlException ex)
            {
                MostrarError(ex.Message);
            }


            return resultado;
        }

        public DataTable ConsultaVista(string vista)
        {
            DataTable resultado = new DataTable();
            try
            {
                SqlCommand sql = new SqlCommand("SELECT * FROM " + vista, conexion);
                sql.CommandType = System.Data.CommandType.Text;
                SqlDataAdapter adaptador = new SqlDataAdapter(sql);
                AbrirConexion();
                sql.ExecuteNonQuery();
                CerrarConexion();
                adaptador.Fill(resultado);
            }
            catch (SqlException ex)
            {
                MostrarError(ex.Message);
            }
            return resultado;
        }

        public DataTable ConsultaTabla(string procedimiento)     
        {
            DataTable resultado = new DataTable();
            try
            {
                SqlCommand sql = new SqlCommand(procedimiento, conexion);
                sql.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataAdapter adaptador = new SqlDataAdapter(sql);
                AbrirConexion();
                sql.ExecuteNonQuery();
                CerrarConexion();
                adaptador.Fill(resultado);
            }
            catch (SqlException ex)
            {
                MostrarError(ex.Message);
            }
            return resultado;
        }


        public DataTable ConsultaTabla(string procedimiento, string variable1, object valor1)     
        {
            DataTable resultado = new DataTable();
            try
            {
                SqlCommand sql = new SqlCommand(procedimiento, conexion);
                sql.CommandType = System.Data.CommandType.StoredProcedure;
                sql.Parameters.AddWithValue(variable1, valor1);
                SqlDataAdapter adaptador = new SqlDataAdapter(sql);
                AbrirConexion();
                sql.ExecuteNonQuery();
                CerrarConexion();
                adaptador.Fill(resultado);
            }
            catch (SqlException ex)
            {
                MostrarError(ex.Message);
            }


            return resultado;
        }

        public DataTable ConsultaTabla(string procedimiento, string variable1, object valor1, string variable2, object valor2)  
        {
            DataTable resultado = new DataTable();
            try
            {
                SqlCommand sql = new SqlCommand(procedimiento, conexion);
                sql.CommandType = System.Data.CommandType.StoredProcedure;
                sql.Parameters.AddWithValue(variable1, valor1);
                sql.Parameters.AddWithValue(variable2, valor2);
                SqlDataAdapter adaptador = new SqlDataAdapter(sql);
                AbrirConexion();
                sql.ExecuteNonQuery();
                CerrarConexion();
                adaptador.Fill(resultado);
            }
            catch (SqlException ex)
            {
                MostrarError(ex.Message);
            }


            return resultado;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.ClientSize = new System.Drawing.Size(1914, 1073);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Datos";
            this.ResumeLayout(false);

        }

        public void Procedimiento(string procedimiento)     
        {
            object resultado = 0;
            try
            {
                SqlCommand sql = new SqlCommand(procedimiento, conexion);
                sql.CommandType = System.Data.CommandType.StoredProcedure;
                AbrirConexion();
                sql.ExecuteNonQuery();
                CerrarConexion();
            }
            catch (SqlException ex)
            {
                MostrarError(ex.Message);
            }

        }

        public void Procedimiento(string procedimiento, string variable1, object valor1)     
        {
            object resultado = 0;
            try
            {
                SqlCommand sql = new SqlCommand(procedimiento, conexion);
                sql.CommandType = System.Data.CommandType.StoredProcedure;
                sql.Parameters.AddWithValue(variable1, valor1);
                AbrirConexion();
                sql.ExecuteNonQuery();
                CerrarConexion();
            }
            catch (SqlException ex)
            {
                MostrarError(ex.Message);
            }

        }

        public void Procedimiento(string procedimiento, string variable1, object valor1, string variable2, object valor2)
        {
            object resultado = 0;
            try
            {
                SqlCommand sql = new SqlCommand(procedimiento, conexion);
                sql.CommandType = System.Data.CommandType.StoredProcedure;
                sql.Parameters.AddWithValue(variable1, valor1);
                sql.Parameters.AddWithValue(variable2, valor2);
                AbrirConexion();
                sql.ExecuteNonQuery();
                CerrarConexion();
            }
            catch (SqlException ex)
            {
                MostrarError(ex.Message);
            }
        }

        public void Procedimiento(string procedimiento, string variable1, object valor1, string variable2, object valor2, string variable3, object valor3)
        {
            object resultado = 0;
            try
            {
                SqlCommand sql = new SqlCommand(procedimiento, conexion);
                sql.CommandType = System.Data.CommandType.StoredProcedure;
                sql.Parameters.AddWithValue(variable1, valor1);
                sql.Parameters.AddWithValue(variable2, valor2);
                sql.Parameters.AddWithValue(variable3, valor3);
                AbrirConexion();
                sql.ExecuteNonQuery();
                CerrarConexion();
            }
            catch (SqlException ex)
            {
                MostrarError(ex.Message);
            }
        }

        public void Procedimiento(string procedimiento, string variable1, object valor1, string variable2, object valor2, string variable3, object valor3, string variable4, object valor4)//En este procedimiento se utiliza para llamar el procedimiento almacenado de la base de datos y que retorne un resultado, le estamos mandando los valores que necesita el mismo para funcionar, el nombre sera procedimiento por si se quiere reutilizar en otro metodo o funcion     
        {
            object resultado = 0;
            try
            {
                SqlCommand sql = new SqlCommand(procedimiento, conexion);
                sql.CommandType = System.Data.CommandType.StoredProcedure;

                sql.Parameters.AddWithValue(variable1, valor1);
                sql.Parameters.AddWithValue(variable2, valor2);
                sql.Parameters.AddWithValue(variable3, valor3);
                sql.Parameters.AddWithValue(variable4, valor4);
                AbrirConexion();
                sql.ExecuteNonQuery();
                CerrarConexion();
            }
            catch (SqlException ex)
            {
                MostrarError(ex.Message);
            }

        }

        public void Procedimiento(string procedimiento, string variable1, object valor1, string variable2, object valor2, string variable3, object valor3, string variable4, object valor4, string variable5, object valor5)//En este procedimiento se utiliza para llamar el procedimiento almacenado de la base de datos y que retorne un resultado, le estamos mandando los valores que necesita el mismo para funcionar, el nombre sera procedimiento por si se quiere reutilizar en otro metodo o funcion     
        {
            object resultado = 0;
            try
            {
                SqlCommand sql = new SqlCommand(procedimiento, conexion);
                sql.CommandType = System.Data.CommandType.StoredProcedure;

                sql.Parameters.AddWithValue(variable1, valor1);
                sql.Parameters.AddWithValue(variable2, valor2);
                sql.Parameters.AddWithValue(variable3, valor3);
                sql.Parameters.AddWithValue(variable4, valor4);
                sql.Parameters.AddWithValue(variable5, valor5);
                AbrirConexion();
                sql.ExecuteNonQuery();
                CerrarConexion();
            }
            catch (SqlException ex)
            {                
                MostrarError(ex.Message);
                throw ex;
            }

        }

        public void Procedimiento(string procedimiento, string variable1, object valor1, string variable2, object valor2, string variable3, object valor3, string variable4, object valor4, string variable5, object valor5, string variable6, object valor6)
        {
            object resultado = 0;
            try
            {
                SqlCommand sql = new SqlCommand(procedimiento, conexion);
                sql.CommandType = System.Data.CommandType.StoredProcedure;
                sql.Parameters.AddWithValue(variable1, valor1);
                sql.Parameters.AddWithValue(variable2, valor2);
                sql.Parameters.AddWithValue(variable3, valor3);
                sql.Parameters.AddWithValue(variable4, valor4);
                sql.Parameters.AddWithValue(variable5, valor5);
                sql.Parameters.AddWithValue(variable6, valor6);
                AbrirConexion();
                sql.ExecuteNonQuery();
                CerrarConexion();
            }
            catch (SqlException ex)
            {
                MostrarError(ex.Message);
            }
        }

        public void Procedimiento(string procedimiento, string variable1, object valor1, string variable2, object valor2, string variable3, object valor3, string variable4, object valor4, string variable5, object valor5, string variable6, object valor6, string variable7, object valor7)
        {
            object resultado = 0;
            try
            {
                SqlCommand sql = new SqlCommand(procedimiento, conexion);
                sql.CommandType = System.Data.CommandType.StoredProcedure;
                sql.Parameters.AddWithValue(variable1, valor1);
                sql.Parameters.AddWithValue(variable2, valor2);
                sql.Parameters.AddWithValue(variable3, valor3);
                sql.Parameters.AddWithValue(variable4, valor4);
                sql.Parameters.AddWithValue(variable5, valor5);
                sql.Parameters.AddWithValue(variable6, valor6);
                sql.Parameters.AddWithValue(variable7, valor7);
                AbrirConexion();
                sql.ExecuteNonQuery();
                CerrarConexion();
            }
            catch (SqlException ex)
            {
                MostrarError(ex.Message);
            }
        }

        public void Procedimiento(string procedimiento, string variable1, object valor1, string variable2, object valor2, string variable3, object valor3, string variable4, object valor4, string variable5, object valor5, string variable6, object valor6, string variable7, object valor7, string variable8, object valor8)
        {
            object resultado = 0;
            try
            {
                SqlCommand sql = new SqlCommand(procedimiento, conexion);
                sql.CommandType = System.Data.CommandType.StoredProcedure;
                sql.Parameters.AddWithValue(variable1, valor1);
                sql.Parameters.AddWithValue(variable2, valor2);
                sql.Parameters.AddWithValue(variable3, valor3);
                sql.Parameters.AddWithValue(variable4, valor4);
                sql.Parameters.AddWithValue(variable5, valor5);
                sql.Parameters.AddWithValue(variable6, valor6);
                sql.Parameters.AddWithValue(variable7, valor7);
                sql.Parameters.AddWithValue(variable8, valor8);
                AbrirConexion();
                sql.ExecuteNonQuery();
                CerrarConexion();
            }
            catch (SqlException ex)
            {
                MostrarError(ex.Message);
            }
        }

        public void Procedimiento(string procedimiento, string variable1, object valor1, string variable2, object valor2, string variable3, object valor3, string variable4, object valor4, string variable5, object valor5, string variable6, object valor6, string variable7, object valor7, string variable8, object valor8, string variable9, object valor9)
        {
            object resultado = 0;
            try
            {
                SqlCommand sql = new SqlCommand(procedimiento, conexion);
                sql.CommandType = System.Data.CommandType.StoredProcedure;
                sql.Parameters.AddWithValue(variable1, valor1);
                sql.Parameters.AddWithValue(variable2, valor2);
                sql.Parameters.AddWithValue(variable3, valor3);
                sql.Parameters.AddWithValue(variable4, valor4);
                sql.Parameters.AddWithValue(variable5, valor5);
                sql.Parameters.AddWithValue(variable6, valor6);
                sql.Parameters.AddWithValue(variable7, valor7);
                sql.Parameters.AddWithValue(variable8, valor8);
                sql.Parameters.AddWithValue(variable9, valor9);
                AbrirConexion();
                sql.ExecuteNonQuery();
                CerrarConexion();
            }
            catch (SqlException ex)
            {
                MostrarError(ex.Message);
            }
        }

        public void Procedimiento(string procedimiento, string variable1, object valor1, string variable2, object valor2, string variable3, object valor3, string variable4, object valor4, string variable5, object valor5, string variable6, object valor6, string variable7, object valor7, string variable8, object valor8, string variable9, object valor9, string variable10, object valor10, string variable11, object valor11, string variable12, object valor12, string variable13, object valor13, string variable14, object valor14, string variable15, object valor15, string variable16, object valor16, string variable17, object valor17, string variable18, object valor18, string variable19, object valor19, string variable20, object valor20, string variable21, object valor21, string variable22, object valor22, string variable23, object valor23, string variable24, object valor24, string variable25, object valor25, string variable26, object valor26, string variable27, object valor27, string variable28, object valor28, string variable29, object valor29, string variable30, object valor30, string variable31, object valor31)//En este procedimiento se utiliza para llamar el procedimiento almacenado de la base de datos y que retorne un resultado, le estamos mandando los valores que necesita el mismo para funcionar, el nombre sera procedimiento por si se quiere reutilizar en otro metodo o funcion     
        {
            object resultado = 0;
            try
            {
                SqlCommand sql = new SqlCommand(procedimiento, conexion);
                sql.CommandType = System.Data.CommandType.StoredProcedure;

                sql.Parameters.AddWithValue(variable1, valor1);
                sql.Parameters.AddWithValue(variable2, valor2);
                sql.Parameters.AddWithValue(variable3, valor3);
                sql.Parameters.AddWithValue(variable4, valor4);
                sql.Parameters.AddWithValue(variable5, valor5);
                sql.Parameters.AddWithValue(variable6, valor6);
                sql.Parameters.AddWithValue(variable7, valor7);
                sql.Parameters.AddWithValue(variable8, valor8);
                sql.Parameters.AddWithValue(variable9, valor9);
                sql.Parameters.AddWithValue(variable10, valor10);
                sql.Parameters.AddWithValue(variable11, valor11);
                sql.Parameters.AddWithValue(variable12, valor12);
                sql.Parameters.AddWithValue(variable13, valor13);
                sql.Parameters.AddWithValue(variable14, valor14);
                sql.Parameters.AddWithValue(variable15, valor15);
                sql.Parameters.AddWithValue(variable16, valor16);
                sql.Parameters.AddWithValue(variable17, valor17);
                sql.Parameters.AddWithValue(variable18, valor18);
                sql.Parameters.AddWithValue(variable19, valor19);
                sql.Parameters.AddWithValue(variable20, valor20);
                sql.Parameters.AddWithValue(variable21, valor21);
                sql.Parameters.AddWithValue(variable22, valor22);
                sql.Parameters.AddWithValue(variable23, valor23);
                sql.Parameters.AddWithValue(variable24, valor24);
                sql.Parameters.AddWithValue(variable25, valor25);
                sql.Parameters.AddWithValue(variable26, valor26);
                sql.Parameters.AddWithValue(variable27, valor27);
                sql.Parameters.AddWithValue(variable28, valor28);
                sql.Parameters.AddWithValue(variable29, valor29);
                sql.Parameters.AddWithValue(variable30, valor30);
                sql.Parameters.AddWithValue(variable31, valor31);

                AbrirConexion();
                sql.ExecuteNonQuery();
                CerrarConexion();
            }
            catch (SqlException ex)
            {
                MostrarError(ex.Message);
            }

        }

        public void Procedimiento(string procedimiento, string variable1, object valor1, string variable2, object valor2, string variable3, object valor3, string variable4, object valor4, string variable5, object valor5, string variable6, object valor6, string variable7, object valor7, string variable8, object valor8, string variable9, object valor9, string variable10, object valor10, string variable11, object valor11, string variable12, object valor12, string variable13, object valor13, string variable14, object valor14, string variable15, object valor15, string variable16, object valor16, string variable17, object valor17, string variable18, object valor18, string variable19, object valor19, string variable20, object valor20, string variable21, object valor21, string variable22, object valor22, string variable23, object valor23, string variable24, object valor24, string variable25, object valor25, string variable26, object valor26, string variable27, object valor27, string variable28, object valor28, string variable29, object valor29, string variable30, object valor30, string variable31, object valor31, string variable32, object valor32, string variable33, object valor33)    
        {
            object resultado = 0;
            try
            {
                SqlCommand sql = new SqlCommand(procedimiento, conexion);
                sql.CommandType = System.Data.CommandType.StoredProcedure;
                                                                         

                sql.Parameters.AddWithValue(variable1, valor1);
                sql.Parameters.AddWithValue(variable2, valor2);
                sql.Parameters.AddWithValue(variable3, valor3);
                sql.Parameters.AddWithValue(variable4, valor4);
                sql.Parameters.AddWithValue(variable5, valor5);
                sql.Parameters.AddWithValue(variable6, valor6);
                sql.Parameters.AddWithValue(variable7, valor7);
                sql.Parameters.AddWithValue(variable8, valor8);
                sql.Parameters.AddWithValue(variable9, valor9);
                sql.Parameters.AddWithValue(variable10, valor10);
                sql.Parameters.AddWithValue(variable11, valor11);
                sql.Parameters.AddWithValue(variable12, valor12);
                sql.Parameters.AddWithValue(variable13, valor13);
                sql.Parameters.AddWithValue(variable14, valor14);
                sql.Parameters.AddWithValue(variable15, valor15);
                sql.Parameters.AddWithValue(variable16, valor16);
                sql.Parameters.AddWithValue(variable17, valor17);
                sql.Parameters.AddWithValue(variable18, valor18);
                sql.Parameters.AddWithValue(variable19, valor19);
                sql.Parameters.AddWithValue(variable20, valor20);
                sql.Parameters.AddWithValue(variable21, valor21);
                sql.Parameters.AddWithValue(variable22, valor22);
                sql.Parameters.AddWithValue(variable23, valor23);
                sql.Parameters.AddWithValue(variable24, valor24);
                sql.Parameters.AddWithValue(variable25, valor25);
                sql.Parameters.AddWithValue(variable26, valor26);
                sql.Parameters.AddWithValue(variable27, valor27);
                sql.Parameters.AddWithValue(variable28, valor28);
                sql.Parameters.AddWithValue(variable29, valor29);
                sql.Parameters.AddWithValue(variable30, valor30);
                sql.Parameters.AddWithValue(variable31, valor31);
                sql.Parameters.AddWithValue(variable32, valor32);
                sql.Parameters.AddWithValue(variable33, valor33);

                AbrirConexion();
                sql.ExecuteNonQuery();
                CerrarConexion();
            }
            catch (SqlException ex)
            {
                MostrarError(ex.Message);
            }

        }

        public void Procedimiento(string procedimiento, string variable1, object valor1, string variable2, object valor2, string variable3, object valor3, string variable4, object valor4, string variable5, object valor5, string variable6, object valor6, string variable7, object valor7, string variable8, object valor8, string variable9, object valor9, string variable10, object valor10, string variable11, object valor11, string variable12, object valor12, string variable13, object valor13, string variable14, object valor14, string variable15, object valor15, string variable16, object valor16, string variable17, object valor17, string variable18, object valor18, string variable19, object valor19, string variable20, object valor20, string variable21, object valor21, string variable22, object valor22, string variable23, object valor23, string variable24, object valor24, string variable25, object valor25, string variable26, object valor26, string variable27, object valor27, string variable28, object valor28, string variable29, object valor29, string variable30, object valor30, string variable31, object valor31, string variable32, object valor32, string variable33, object valor33, string variable34, object valor34)//En este procedimiento se utiliza para llamar el procedimiento almacenado de la base de datos y que retorne un resultado, le estamos mandando los valores que necesita el mismo para funcionar, el nombre sera procedimiento por si se quiere reutilizar en otro metodo o funcion     
        {
            object resultado = 0;
            try
            {
                SqlCommand sql = new SqlCommand(procedimiento, conexion);
                sql.CommandType = System.Data.CommandType.StoredProcedure;
                                                                          

                sql.Parameters.AddWithValue(variable1, valor1);
                sql.Parameters.AddWithValue(variable2, valor2);
                sql.Parameters.AddWithValue(variable3, valor3);
                sql.Parameters.AddWithValue(variable4, valor4);
                sql.Parameters.AddWithValue(variable5, valor5);
                sql.Parameters.AddWithValue(variable6, valor6);
                sql.Parameters.AddWithValue(variable7, valor7);
                sql.Parameters.AddWithValue(variable8, valor8);
                sql.Parameters.AddWithValue(variable9, valor9);
                sql.Parameters.AddWithValue(variable10, valor10);
                sql.Parameters.AddWithValue(variable11, valor11);
                sql.Parameters.AddWithValue(variable12, valor12);
                sql.Parameters.AddWithValue(variable13, valor13);
                sql.Parameters.AddWithValue(variable14, valor14);
                sql.Parameters.AddWithValue(variable15, valor15);
                sql.Parameters.AddWithValue(variable16, valor16);
                sql.Parameters.AddWithValue(variable17, valor17);
                sql.Parameters.AddWithValue(variable18, valor18);
                sql.Parameters.AddWithValue(variable19, valor19);
                sql.Parameters.AddWithValue(variable20, valor20);
                sql.Parameters.AddWithValue(variable21, valor21);
                sql.Parameters.AddWithValue(variable22, valor22);
                sql.Parameters.AddWithValue(variable23, valor23);
                sql.Parameters.AddWithValue(variable24, valor24);
                sql.Parameters.AddWithValue(variable25, valor25);
                sql.Parameters.AddWithValue(variable26, valor26);
                sql.Parameters.AddWithValue(variable27, valor27);
                sql.Parameters.AddWithValue(variable28, valor28);
                sql.Parameters.AddWithValue(variable29, valor29);
                sql.Parameters.AddWithValue(variable30, valor30);
                sql.Parameters.AddWithValue(variable31, valor31);
                sql.Parameters.AddWithValue(variable32, valor32);
                sql.Parameters.AddWithValue(variable33, valor33);
                sql.Parameters.AddWithValue(variable34, valor34);

                AbrirConexion();
                sql.ExecuteNonQuery();
                CerrarConexion();
            }
            catch (SqlException ex)
            {
                MostrarError(ex.Message);
                throw ex;
            }

        }





        public string IDUsuario { get; set; }
    }
}
