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

        int placa, placaPadre, placaMadre;

        public int PlacaMadre
        {
            get { return placaMadre; }
            set { placaMadre = value; }
        }

        public int PlacaPadre
        {
            get { return placaPadre; }
            set { placaPadre = value; }
        }

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
        string raza, lugarFoto, sexo, observaciones;

        public string Observaciones
        {
            get { return observaciones; }
            set { observaciones = value; }
        }

        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        public string LugarFoto
        {
            get { return lugarFoto; }
            set { lugarFoto = value; }
        }

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
                cmd.CommandText = "INSERT INTO ControlAnimal (Placa,Raza,FechaNacido,Imagen,PlacaPadre,PlacaMadre,Observacion,Sexo) VALUES (@Placa, @Raza, @FechaNacido, @Imagen, @PlacaPadre, @PlacaMadre, @Observacion, @Sexo)";
                cmd.Parameters.AddWithValue("@Placa", this.Placa );
                cmd.Parameters.AddWithValue("@Raza", this.Raza);
                cmd.Parameters.AddWithValue("@FechaNacido", this.FechaNacido);
                cmd.Parameters.AddWithValue("@Imagen", this.LugarFoto );
                cmd.Parameters.AddWithValue("@PlacaPadre", this.PlacaPadre);
                cmd.Parameters.AddWithValue("@PlacaMadre", this.PlacaMadre);
                cmd.Parameters.AddWithValue("@Observacion", this.Observaciones );
                cmd.Parameters.AddWithValue("@Sexo", this.Sexo );
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
                cmd.CommandText = "UPDATE ControlAnimal SET Raza=@Raza ,FechaNacido=@FechaNacido, Imagen = @Imagen, PlacaPadre = @PlacaPadre, PlacaMadre = @PlacaMadre, Observacion = @Observacion, Sexo =  @Sexo WHERE Placa=@Placa";
                cmd.Parameters.AddWithValue("@Placa", this.Placa);
                cmd.Parameters.AddWithValue("@Raza", this.Raza);
                cmd.Parameters.AddWithValue("@FechaNacido", this.FechaNacido);
                cmd.Parameters.AddWithValue("@Imagen", this.LugarFoto);
                cmd.Parameters.AddWithValue("@PlacaPadre", this.PlacaPadre);
                cmd.Parameters.AddWithValue("@PlacaMadre", this.PlacaMadre);
                cmd.Parameters.AddWithValue("@Observacion", this.Observaciones);
                cmd.Parameters.AddWithValue("@Sexo", this.Sexo);
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

        #region ModificarSinFo
        public void ModificarSinFoto()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = BaseDatos.conn;
                cmd.CommandText = "UPDATE ControlAnimal SET Raza=@Raza ,FechaNacido=@FechaNacido,  PlacaPadre = @PlacaPadre, PlacaMadre = @PlacaMadre, Observacion = @Observacion, Sexo =  @Sexo WHERE Placa=@Placa";
                cmd.Parameters.AddWithValue("@Placa", this.Placa);
                cmd.Parameters.AddWithValue("@Raza", this.Raza);
                cmd.Parameters.AddWithValue("@FechaNacido", this.FechaNacido);
                cmd.Parameters.AddWithValue("@PlacaPadre", this.PlacaPadre);
                cmd.Parameters.AddWithValue("@PlacaMadre", this.PlacaMadre);
                cmd.Parameters.AddWithValue("@Observacion", this.Observaciones);
                cmd.Parameters.AddWithValue("@Sexo", this.Sexo);
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
                    this.LugarFoto  = dr["Imagen"].ToString();
                    this.PlacaPadre = Convert.ToInt32(dr["PlacaPadre"].ToString());
                    this.PlacaMadre = Convert.ToInt32(dr["PlacaMadre"].ToString());
                    this.Observaciones  = dr["Observacion"].ToString();
                    this.Sexo  = dr["Sexo"].ToString();
                }
                BaseDatos.conn.Close();
                return this.Placa + "|" + this.Raza + "|" + this.FechaNacido + "|" + this.PlacaPadre + "|" + this.PlacaMadre + "|" + this.Observaciones  + "|" + this.Sexo ;
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
                cmd.CommandText = "SELECT * FROM ControlAnimal order by Placa";
                BaseDatos.conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                ControlAnimal c;
                while (dr.Read())
                {
                    c = new ControlAnimal();
                    c.Placa = Convert.ToInt32(dr["Placa"].ToString());
                    c.Raza = dr["Raza"].ToString();
                    c.FechaNacido = Convert.ToDateTime(dr["FechaNacido"].ToString());
                    c.LugarFoto  = dr["Imagen"].ToString();
                    c.PlacaPadre = Convert.ToInt32(dr["PlacaPadre"].ToString());
                    c.PlacaMadre = Convert.ToInt32(dr["PlacaMadre"].ToString());
                    c.Observaciones = dr["Observacion"].ToString();
                    c.Sexo = dr["Sexo"].ToString();
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

        #region ObternerListaPorPlaca
        public List<ControlAnimal > ObtenerPorPlaca(int pla)
        {
            List<ControlAnimal> lista = new List<ControlAnimal>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = BaseDatos.conn;
                cmd.CommandText = "SELECT * FROM ControlAnimal WHERE Placa = @Pla Order By Placa";
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
                    c.LugarFoto  = dr["Imagen"].ToString();
                    c.PlacaPadre = Convert.ToInt32(dr["PlacaPadre"].ToString());
                    c.PlacaMadre = Convert.ToInt32(dr["PlacaMadre"].ToString());
                    c.Observaciones = dr["Observacion"].ToString();
                    c.Sexo = dr["Sexo"].ToString();
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

        #region ObternerListaPorRazas
        public List<ControlAnimal> ObtenerListaPorRaza(string raz)
        {
            List<ControlAnimal> lista = new List<ControlAnimal>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = BaseDatos.conn;
                //cmd.CommandText = "SELECT * FROM Controlanimal where Raza like '@Raz+%'";
                cmd.CommandText = "SELECT * FROM Controlanimal where Raza LIKE '" + raz + "%' ORDER BY Placa";
                cmd.Parameters.AddWithValue("@Raz", raz);
                BaseDatos.conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                ControlAnimal c;
                while (dr.Read())
                {
                    c = new ControlAnimal();
                    c.Placa = Convert.ToInt32(dr["Placa"].ToString());
                    c.Raza = dr["Raza"].ToString();
                    c.FechaNacido = Convert.ToDateTime(dr["FechaNacido"].ToString());
                    c.LugarFoto = dr["Imagen"].ToString();
                    c.PlacaPadre = Convert.ToInt32(dr["PlacaPadre"].ToString());
                    c.PlacaMadre = Convert.ToInt32(dr["PlacaMadre"].ToString());
                    c.Observaciones = dr["Observacion"].ToString();
                    c.Sexo = dr["Sexo"].ToString();
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

        #region ObtieneNombreRazas
        public List<ControlAnimal> ObtenerNombreRaza()
        {
            List<ControlAnimal> lista = new List<ControlAnimal>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = BaseDatos.conn;
                cmd.CommandText = "Select distinct raza from controlanimal ";
                BaseDatos.conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                ControlAnimal c;
                while (dr.Read())
                {
                    c = new ControlAnimal();
                    c.Raza = dr["Raza"].ToString();
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

        #region ValidarPlacas
        public List<ControlAnimal> ValidarPlaca()
        {
            List<ControlAnimal> lista = new List<ControlAnimal>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = BaseDatos.conn;
                cmd.CommandText = "SELECT Placa FROM ControlAnimal";
                BaseDatos.conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                ControlAnimal c;
                while (dr.Read())
                {
                    c = new ControlAnimal();
                    c.Placa = Convert.ToInt32(dr["Placa"].ToString());
                    //c.Raza = dr["Raza"].ToString();
                    //c.FechaNacido = Convert.ToDateTime(dr["FechaNacido"].ToString());
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

        #region ValidaPla
        public List<ControlAnimal> ValidaPla(int pla)
        {
            List<ControlAnimal> lista = new List<ControlAnimal>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = BaseDatos.conn;
                cmd.CommandText = "SELECT Placa FROM ControlAnimal WHERE Placa = @Pla";
                cmd.Parameters.AddWithValue("@Pla", pla);
                BaseDatos.conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                ControlAnimal c;
                while (dr.Read())
                {
                    c = new ControlAnimal();
                    c.Placa = Convert.ToInt32(dr["Placa"].ToString());

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
