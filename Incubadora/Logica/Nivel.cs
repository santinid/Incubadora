using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;


namespace Logica
{
   public class Nivel
   {
        #region Variable
       int idNivel, charola;
        public int IdNivel
        {
            get { return idNivel; }
            set { idNivel = value; }
        }
        public int Charola
        {
            get { return charola; }
            set { charola = value; }
        }
       #endregion

        #region Agregar
        public void Agregar()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = BaseDatos.conn;
                cmd.CommandText = "INSERT INTO Nivel (IdNivel,Charola) VALUES (@IdNivel, @Charola)";
                cmd.Parameters.AddWithValue("@Charola", this.Charola);
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
                cmd.CommandText = "UPDATE Nivel SET IdNivel=@IdNivel,Charola=@Charola WHERE IdNivel=@IdNivel";
                cmd.Parameters.AddWithValue("@IdNivel", this.IdNivel);
                cmd.Parameters.AddWithValue("@Charola", this.Charola);
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
                cmd.CommandText = "DELETE FROM Nivel WHERE IdNivel=@IdNivel";
                cmd.Parameters.AddWithValue("@IdNivel", this.IdNivel);
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
                cmd.CommandText = "SELECT * FROM Nivel WHERE IdNivel=@IdNivel";
                cmd.Parameters.AddWithValue("@IdNivel", this.IdNivel);
                BaseDatos.conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    this.IdNivel = Convert.ToInt32(dr["IdNivel"].ToString());
                    this.Charola = Convert.ToInt32(dr["Charola"].ToString());
                }
                BaseDatos.conn.Close();
                return this.IdNivel + "|" + this.Charola;
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
        public List<Nivel> ObtenerListado()
        {
            List<Nivel> lista = new List<Nivel>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = BaseDatos.conn;
                cmd.CommandText = "SELECT * FROM Nivel";
                BaseDatos.conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                Nivel n;
                while (dr.Read())
                {
                    n = new Nivel();
                    n.IdNivel = Convert.ToInt32(dr["IdNivel"].ToString());
                    n.Charola = Convert.ToInt32(dr["Charola"].ToString());
                    lista.Add(n);
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
