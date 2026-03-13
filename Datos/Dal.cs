using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
    public class Dal
    {
        public static string SQL = string.Empty;
        public DataSet BuscarId(int pId)
        {
            SQL = "SELECT * FROM CLIENTEEMPRESA WHERE ID='" + pId + "'";
            SqlConnection con = new SqlConnection(Conexion.sConnection);
            DataSet objDataSet = new DataSet();
            SqlCommand com = new SqlCommand(SQL, con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = com;

            try
            {
                da.Fill(objDataSet);
            }
            catch (SqlException ex)
            {
                throw new Exception("ERROR en la base de datos" + ex.Message);
            }
            finally
            {
                con.Dispose();
                com.Dispose();
            }
            return objDataSet;
        }
        public DataSet BuscarNombre(string pNombre)
        {
            SQL = "SELECT * FROM CLIENTEEMPRESA WHERE NOMBRE LIKE '%" + pNombre + "%'";

            SqlConnection con = new SqlConnection(Conexion.sConnection);
            DataSet objDataSet = new DataSet();
            SqlCommand com = new SqlCommand(SQL, con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = com;
            try
            {
                da.Fill(objDataSet);
            }
            catch (SqlException ex)
            {
                throw new Exception("Error en la base de datos" + ex.Message);
            }
            finally
            {
                con.Dispose();
                com.Dispose();
            }
            return objDataSet;
        }
        private int identidad;
        public int Identidad
        {
            get
            {
                return identidad;
            }
            set
            {
                identidad = value;
            }
        }
        public static SqlTransaction objTransaction = null;

        public int AgregarEmpresa( string pNombre, string pContacto, string pCUIT, string pEmail, string pTelefono, string pDireccion, string pFotojpg)
        {
            SQL = "INSERT INTO CLIENTEEMPRESA (NOMBRE,CONTACTO,CUIT,MAIL,TELEFONO,DIRECCION,FOTO_JPG) VALUES ";
            SQL = SQL + "(@pNombre,@pContacto,@pCUIT,@pEmail,@pTelefono,@pDireccion,@pFotojpg)";

            SqlConnection con = new SqlConnection(Conexion.sConnection);
            SqlCommand com = new SqlCommand(SQL, con);
            SqlParameter retParam = com.Parameters.Add("@RETURN_VALUE", SqlDbType.Int);
            retParam.Direction = ParameterDirection.ReturnValue;
            //com.Parameters.Add("@pId", SqlDbType.Int, 1).Value = pId;
            com.Parameters.Add("@pNombre", SqlDbType.VarChar, 100).Value = pNombre;
            com.Parameters.Add("@pContacto", SqlDbType.VarChar).Value = pContacto;
            com.Parameters.Add("@pCUIT", SqlDbType.VarChar).Value = pCUIT;
            com.Parameters.Add("@pEmail", SqlDbType.VarChar).Value = pEmail;
            com.Parameters.Add("@pTelefono", SqlDbType.VarChar, 15).Value = pTelefono;
            com.Parameters.Add("@pDireccion", SqlDbType.VarChar, 30).Value = pDireccion;
            com.Parameters.Add("@pFotojpg", SqlDbType.VarChar, 16).Value = pFotojpg;
            try
            {
                con.Open();
                objTransaction = con.BeginTransaction();
                com.Transaction = objTransaction;

                com.ExecuteNonQuery();
                identidad = Convert.ToInt32(retParam.Value);
                objTransaction.Commit();
            }
            catch (SqlException ex)
            {
                objTransaction.Rollback();
                throw new Exception("Error en base de datos " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                con.Dispose();
                com.Dispose();
            }
            return identidad;
        }
        public DataSet BuscarEmpresas()
        {
            SQL = "SELECT * FROM CLIENTEEMPRESA ORDER BY ID ASC";

            SqlConnection con = new SqlConnection(Conexion.sConnection);
            DataSet objDataset = new DataSet();
            SqlCommand com = new SqlCommand(SQL, con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = com;

            try
            {
                da.Fill(objDataset);
            }
            catch (SqlException ex)
            {
                throw new Exception("error en la base de datos" + ex.Message);
            }
            finally
            {
                com.Dispose();
                com.Dispose();
            }
            return objDataset;
        }
        public int ModificarEmpresa(string pNombre, string pContacto, string pCUIT, string pEmail, string pTelefono, string pDireccion, string pFotojpg)
        {
            SQL = "UPDATE CLIENTEEMPRESA SET NOMBRE=@pNombre, CONTACTO=@pContacto, CUIT=@pCUIT, MAIL=@pEmail, ";
            SQL = SQL + "TELEFONO=@pTelefono, DIRECCION=@pDireccion, FOTO_JPG=@pFotojpg ";
            SQL = SQL + "WHERE NOMBRE='" + pNombre + "'";

            SqlConnection con = new SqlConnection(Conexion.sConnection);
            SqlCommand com = new SqlCommand(SQL, con);
            SqlParameter retParam = com.Parameters.Add("@RETURN_VALUE", SqlDbType.Int);
            retParam.Direction = ParameterDirection.ReturnValue;

            com.Parameters.Add("@pNombre", SqlDbType.VarChar, 100).Value = pNombre;
            com.Parameters.Add("@pContacto", SqlDbType.VarChar,100).Value = pContacto;
            com.Parameters.Add("@pCUIT", SqlDbType.VarChar,13).Value = pCUIT;
            com.Parameters.Add("@pEmail", SqlDbType.VarChar,30).Value = pEmail;
            com.Parameters.Add("@pTelefono", SqlDbType.VarChar, 15).Value = pTelefono;
            com.Parameters.Add("@pDireccion", SqlDbType.VarChar, 100).Value = pDireccion;
            com.Parameters.Add("@pFotojpg", SqlDbType.VarChar, 20).Value = pFotojpg;
            try
            {
                con.Open();
                objTransaction = con.BeginTransaction();
                com.Transaction = objTransaction;

                com.ExecuteNonQuery();
                identidad = Convert.ToInt32(retParam.Value);
                objTransaction.Commit();
            }
            catch (SqlException ex)
            {
                objTransaction.Rollback();
                throw new Exception("Error en base de datos " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                con.Dispose();
                com.Dispose();
            }
            return identidad;
        }
        public DataSet EliminarEmpresa(string pNombre)
        {
            SQL = "DELETE FROM CLIENTEEMPRESA ";
            SQL = SQL + "WHERE NOMBRE='" + pNombre + "'";
            SqlConnection con = new SqlConnection(Conexion.sConnection);
            DataSet objDataSet = new DataSet();
            SqlCommand com = new SqlCommand(SQL, con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = com;
            try
            {
                da.Fill(objDataSet);
            }
            catch (SqlException ex)
            {
                throw new Exception("Error en la base de datos" + ex.Message);
            }
            finally
            {
                con.Dispose();
                com.Dispose();
            }
            return objDataSet;
        }
    }
}
