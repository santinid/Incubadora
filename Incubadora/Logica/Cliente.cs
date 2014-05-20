using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Logica;
namespace Logica
{
    public class Cliente
    {
        #region Variables
        int idCliente;
        public int IdCliente
        {
            get { return idCliente; }
            set { idCliente = value; }
        }
        string nombre, apellido, nombreCompleto;

        public string NombreCompleto
        {
            get { return nombreCompleto; }
            set { nombreCompleto = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        #endregion

        #region Agregar
        public  void Agregar()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = BaseDatos.conn;
                cmd.CommandText = "INSERT INTO Cliente (Nombre,Apellido) VALUES (@Nombre, @Apellido)";
                cmd.Parameters.AddWithValue("@Nombre", this.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", this.Apellido);
                BaseDatos.conn.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                BaseDatos.conn.Close();
            }
        }
        #endregion

        #region Modificar
        public void Modificar()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = BaseDatos.conn;
                cmd.CommandText = "UPDATE Cliente SET Nombre=@Nombre,Apellido=@Apellido WHERE IdCliente=@IdCliente";
                cmd.Parameters.AddWithValue("@IdCliente", this.IdCliente );
                cmd.Parameters.AddWithValue("@Nombre", this.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", this.Apellido);
                BaseDatos.conn.Open();
                cmd.ExecuteNonQuery();
                BaseDatos.conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                BaseDatos.conn.Close();
            }
        }
        #endregion

        #region Eliminar
        public void Eliminar()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = BaseDatos.conn;
                cmd.CommandText = "DELETE FROM Cliente WHERE IdCliente=@IdCliente";
                cmd.Parameters.AddWithValue("@IdCliente", this.IdCliente);
                BaseDatos.conn.Open();
                cmd.ExecuteNonQuery();
                BaseDatos.conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                BaseDatos.conn.Close();
            }
        }
        #endregion

        #region Obtener
        public string Obtener()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = BaseDatos.conn;
                cmd.CommandText = "SELECT * FROM Cliente WHERE IdCliente=@IdCliente";
                cmd.Parameters.AddWithValue("@IdCliente", this.IdCliente);
                BaseDatos.conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    this.IdCliente = Convert.ToInt32(dr["IdCliente"].ToString());
                    this.Nombre = dr["Nombre"].ToString();
                    this.Apellido = dr["Apellido"].ToString();
                }
                BaseDatos.conn.Close();
                return this.IdCliente + "|" + this.Nombre + "|" + this.Apellido;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                BaseDatos.conn.Close();
            }
        }
        #endregion
     
        #region ObternerLista
        public  List<Cliente> ObtenerListado()
        {
            List<Cliente> lista = new List<Cliente>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = BaseDatos.conn;
                cmd.CommandText = "SELECT IdCliente, Nombre + ' ' + Apellido AS NombreCompleto FROM Cliente";
                BaseDatos.conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                Cliente c;
                while (dr.Read())
                {
                    c = new Cliente();
                    c.IdCliente = Convert.ToInt32(dr["IdCliente"].ToString());
                    c.NombreCompleto = dr["NombreCompleto"].ToString();
                  
                    lista.Add(c);
                }
                BaseDatos.conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                BaseDatos.conn.Close();
            }
            return lista;
        }
        #endregion

        #region ObternerListaPorNombre
        public List<Cliente> ObtenerListadoNombreCliente()
        {
            List<Cliente> lista = new List<Cliente>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = BaseDatos.conn;
                cmd.CommandText = "SELECT * FROM Cliente WHERE IdCliente = @IdCliente";
                cmd.Parameters.AddWithValue("@IdCliente", this.IdCliente);
                BaseDatos.conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                Cliente c;
                while (dr.Read())
                {
                    c = new Cliente();
                    c.IdCliente = Convert.ToInt32(dr["IdCliente"].ToString());
                    c.Nombre = dr["Nombre"].ToString();
                    c.Apellido = dr["Apellido"].ToString();
                    lista.Add(c);
                }
                BaseDatos.conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                BaseDatos.conn.Close();
            }
            return lista;
        }
        #endregion
    }
}
