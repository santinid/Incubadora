using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Logica
{
   public  class Marca
    {
        #region Variable
       
        bool  narizIzq, narizDer, izqIzq, izqDer, derIzq, derDer;
        string nombre;
        int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public bool NarizIzq
        {
            get { return narizIzq; }
            set { narizIzq = value; }
        }

        public bool NarizDer
        {
            get { return narizDer; }
            set { narizDer = value; }
        }

        public bool IzqIzq
        {
            get { return izqIzq; }
            set { izqIzq = value; }
        }

        public bool IzqDer
        {
            get { return izqDer; }
            set { izqDer = value; }
        }

        public bool DerIzq
        {
            get { return derIzq; }
            set { derIzq = value; }
        }

        public bool DerDer
        {
            get { return derDer; }
            set { derDer = value; }
        }
        #endregion

        #region Agregar
        public void Agregar()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = BaseDatos.conn;
                cmd.CommandText = "INSERT INTO Marca (Nombre,NarIzq,NarDer,IzqIzq,IzqDer,DerIzq,DerDer) VALUES (@Nombre,@NarIzq, @NarDer, @IzqIzq, @IzqDer, @DerIzq, @DerDer)";
                cmd.Parameters.AddWithValue("@Nombre", this.Nombre);
                cmd.Parameters.AddWithValue("@NarIzq", this.NarizIzq );
                cmd.Parameters.AddWithValue("@NarDer", this.NarizDer);
                cmd.Parameters.AddWithValue("@IzqIzq", this.IzqIzq);
                cmd.Parameters.AddWithValue("@IzqDer", this.IzqDer );
                cmd.Parameters.AddWithValue("@DerIzq", this.DerIzq);
                cmd.Parameters.AddWithValue("@DerDer", this.DerDer);
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
                cmd.CommandText = "UPDATE Marca SET Nombre = @Nombre, NarIzq = @NarIzq , NarDer= @NarDer , IzqIzq= @IzqIzq , IzqDer= @IzqDer,DerIzq= @DerIzq,DerDer= @DerDer WHERE Id=@Id";
                cmd.Parameters.AddWithValue("@Nombre", this.Nombre);
                cmd.Parameters.AddWithValue("@NarIzq", this.NarizIzq);
                cmd.Parameters.AddWithValue("@NarDer", this.NarizDer);
                cmd.Parameters.AddWithValue("@IzqIzq", this.IzqIzq);
                cmd.Parameters.AddWithValue("@IzqDer", this.IzqDer);
                cmd.Parameters.AddWithValue("@DerIzq", this.DerIzq);
                cmd.Parameters.AddWithValue("@DerDer", this.DerDer);
                cmd.Parameters.AddWithValue("@Id", this.Id);
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
                cmd.CommandText = "SELECT * FROM Marca WHERE Id=@Id";
                //cmd.Parameters.AddWithValue("@FechaNacido", this.FechaNacido);
                BaseDatos.conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    this.Nombre = dr["Nombre"].ToString();
                    this.NarizIzq  = Convert.ToBoolean (dr["NarIzq"].ToString());
                    this.NarizDer = Convert.ToBoolean(dr["NarDer"].ToString());
                    this.IzqIzq = Convert.ToBoolean(dr["IzqIzq"].ToString());
                    this.IzqDer = Convert.ToBoolean(dr["IzqDer"].ToString());
                    this.DerIzq = Convert.ToBoolean(dr["DerIzq"].ToString());
                    this.DerDer = Convert.ToBoolean(dr["DerDer"].ToString());
                }
                BaseDatos.conn.Close();
                return this.Nombre + "|" +this.NarizIzq  + "|" + this.NarizDer  + "|" + this.IzqIzq  + "|" + this.IzqDer  + "|" + this.DerIzq  + "|" + this.DerDer ;
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
        public List<Marca> ObtenerListado()
        {
            List<Marca> lista = new List<Marca>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = BaseDatos.conn;
                cmd.CommandText = "SELECT Nombre,NarIzq ,NarDer ,IzqIzq,IzqDer,DerIzq,DerDer, Id FROM Marca order by Id";
                BaseDatos.conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                Marca  m;
                while (dr.Read())
                {
                    m = new Marca ();
                    m.nombre = dr["Nombre"].ToString();
                    m.NarizIzq = Convert.ToBoolean(dr["NarIzq"].ToString());
                    m.NarizDer = Convert.ToBoolean(dr["NarDer"].ToString());
                    m.IzqIzq = Convert.ToBoolean(dr["IzqIzq"].ToString());
                    m.IzqDer = Convert.ToBoolean(dr["IzqDer"].ToString());
                    m.DerIzq = Convert.ToBoolean(dr["DerIzq"].ToString());
                    m.DerDer = Convert.ToBoolean(dr["DerDer"].ToString());
                    m.Id = Convert.ToInt32(dr["Id"].ToString());
                    lista.Add(m);
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

        #region ValidarMarca
        public List<Marca > ValidaMarcas()
        {
            List<Marca> lista = new List<Marca>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = BaseDatos.conn;
                cmd.CommandText = "SELECT NarIzq,NarDer,IzqIzq,IzqDer,DerIzq,DerDer FROM Marca";
                BaseDatos.conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                Marca m;
                while (dr.Read())
                {
                    m = new Marca();
                    m.NarizIzq = Convert.ToBoolean(dr["NarIzq"].ToString());
                    m.NarizDer = Convert.ToBoolean(dr["NarDer"].ToString());
                    m.IzqIzq = Convert.ToBoolean(dr["IzqIzq"].ToString());
                    m.IzqDer = Convert.ToBoolean(dr["IzqDer"].ToString());
                    m.DerIzq = Convert.ToBoolean(dr["DerIzq"].ToString());
                    m.DerDer = Convert.ToBoolean(dr["DerDer"].ToString());
                    lista.Add(m);
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

        #region ValidarMarcaconId
        public List<Marca> ValidaMarcasConIDs()
        {
            List<Marca> lista = new List<Marca>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = BaseDatos.conn;
                cmd.CommandText = "SELECT NarIzq,NarDer,IzqIzq,IzqDer,DerIzq,DerDer, Id FROM Marca";
                BaseDatos.conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                Marca m;
                while (dr.Read())
                {
                    m = new Marca();
                    m.NarizIzq = Convert.ToBoolean(dr["NarIzq"].ToString());
                    m.NarizDer = Convert.ToBoolean(dr["NarDer"].ToString());
                    m.IzqIzq = Convert.ToBoolean(dr["IzqIzq"].ToString());
                    m.IzqDer = Convert.ToBoolean(dr["IzqDer"].ToString());
                    m.DerIzq = Convert.ToBoolean(dr["DerIzq"].ToString());
                    m.DerDer = Convert.ToBoolean(dr["DerDer"].ToString());
                    m.Id  = Convert.ToInt32 (dr["Id"].ToString());
                    lista.Add(m);
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

        #region ObtenerMarcas
        public string ObtenerMarca()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = BaseDatos.conn;
                cmd.CommandText = "SELECT NarIzq,NarDer,IzqIzq,IzqDer,DerIzq,DerDer FROM Marca ";
                //cmd.Parameters.AddWithValue("@FechaNacido", this.FechaNacido);
                BaseDatos.conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    this.NarizIzq = Convert.ToBoolean(dr["NarIzq"].ToString());
                    this.NarizDer = Convert.ToBoolean(dr["NarDer"].ToString());
                    this.IzqIzq = Convert.ToBoolean(dr["IzqIzq"].ToString());
                    this.IzqDer = Convert.ToBoolean(dr["IzqDer"].ToString());
                    this.DerIzq = Convert.ToBoolean(dr["DerIzq"].ToString());
                    this.DerDer = Convert.ToBoolean(dr["DerDer"].ToString());
                }
                BaseDatos.conn.Close();
                return this.NarizIzq + "|" + this.NarizDer + "|" + this.IzqIzq + "|" + this.IzqDer + "|" + this.DerIzq + "|" + this.DerDer;
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
    }
}
