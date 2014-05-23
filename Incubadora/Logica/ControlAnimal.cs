using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Logica
{
    public class ControlAnimal
    {
        #region variables

        int placa;

        public int Placa
        {
            get { return placa; }
            set { placa = value; }
        }
        DateTime fechaNacido;

        public DateTime FechaNacido
        {
            get { return fechaNacido; }
            set { fechaNacido = value; }
        }
        string raza;

        public string Raza
        {
            get { return raza; }
            set { raza = value; }
        }

        #endregion

        #region Agregar
        public void Agregar()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = BaseDatos.conn;
                cmd.CommandText = "INSERT INTO ControlAnimal (Placa,Raza,FechaNacido) VALUES (@Placa, @Raza, @FechaNacido)";
                cmd.Parameters.AddWithValue("@Placa", this.Placa );
                cmd.Parameters.AddWithValue("@Raza", this.Raza);
                cmd.Parameters.AddWithValue("@FechaNacido", this.FechaNacido);
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
                cmd.CommandText = "UPDATE ControlAnimal SET Raza=@Raza ,FechaNacido=@FechaNacido WHERE Placa=@Placa";
                cmd.Parameters.AddWithValue("@Placa", this.Placa);
                cmd.Parameters.AddWithValue("@Raza", this.Raza);
                cmd.Parameters.AddWithValue("@FechaNacido", this.FechaNacido);
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
                cmd.CommandText = "DELETE FROM ControlAnimal WHERE Placa=@Placa";
                cmd.Parameters.AddWithValue("@FechaNacido", this.FechaNacido);
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
                cmd.CommandText = "SELECT * FROM ControlAnimal WHERE Placa=@Placa";
                cmd.Parameters.AddWithValue("@FechaNacido", this.FechaNacido);
                BaseDatos.conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    this.Placa = Convert.ToInt32(dr["Placa"].ToString());
                    this.Raza = dr["Raza"].ToString();
                    this.FechaNacido = Convert.ToDateTime(dr["FechaNacido"].ToString());
                }
                BaseDatos.conn.Close();
                return this.Placa + "|" + this.Raza + "|" + this.FechaNacido;
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
        public List<ControlAnimal> ObtenerListado()
        {
            List<ControlAnimal> lista = new List<ControlAnimal>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = BaseDatos.conn;
                cmd.CommandText = "SELECT * FROM ControlAnimal";
                BaseDatos.conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                ControlAnimal c;
                while (dr.Read())
                {
                    c = new ControlAnimal();
                    c.Placa = Convert.ToInt32(dr["Placa"].ToString());
                    c.Raza = dr["Raza"].ToString();
                    c.FechaNacido = Convert.ToDateTime(dr["FechaNacido"].ToString());
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
        public List<ControlAnimal > ObtenerPorPlaca(int pla)
        {
            List<ControlAnimal> lista = new List<ControlAnimal>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = BaseDatos.conn;
                cmd.CommandText = "SELECT * FROM ControlAnimal WHERE Placa = @Pla";
                cmd.Parameters.AddWithValue("@Pla", pla);
                BaseDatos.conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                ControlAnimal c;
                while (dr.Read())
                {
                    c = new ControlAnimal();
                    c.Placa = Convert.ToInt32(dr["Placa"].ToString());
                    c.Raza = dr["Raza"].ToString();
                    c.FechaNacido = Convert.ToDateTime(dr["FechaNacido"].ToString());
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
