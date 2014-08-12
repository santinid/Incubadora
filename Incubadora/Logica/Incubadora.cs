using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data.Common;
using System.Web;


namespace Logica
{
    public class Incubadora
    {
        #region variables
        int idIncubadora, idCliente, idNivel, cantidadHuevos;
        string tipoHuevo, nombreCompleto;

       
        double total;
        DateTime fechaInicio, fechaFinal;   
       
        public int IdIncubadora
        {
            get { return idIncubadora; }
            set { idIncubadora = value; }
        }
        public int IdCliente
        {
            get { return idCliente; }
            set { idCliente = value; }
        }
        public string TipoHuevo
        {
            get { return tipoHuevo; }
            set { tipoHuevo = value; }
        }
        public int IdNivel
        {
            get { return idNivel; }
            set { idNivel = value; }
        }
        public int CantidadHuevos
        {
            get { return cantidadHuevos; }
            set { cantidadHuevos = value; }
        }
        public double Total
        {
            get { return total; }
            set { total = value; }
        }
        public DateTime FechaInicio
        {
            get { return fechaInicio; }
            set { fechaInicio = value; }
        }
        public DateTime FechaFinal
        {
            get { return fechaFinal; }
            set { fechaFinal = value; }
        }

        public string NombreCompleto
        {
            get { return nombreCompleto; }
            set { nombreCompleto = value; }
        }

        #endregion

        #region Agregar
        public void Agregar()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = BaseDatos.conn;
                cmd.CommandText = "INSERT INTO Incubadora (IdCliente,CantidadHuevos,TipoHuevo,FechaInicio,FechaFinal,Total,IdNivel) VALUES (@IdCliente, @CantidadHuevos, @TipoHuevo, @FechaInicio, @FechaFinal, @Total, @IdNivel)";
                cmd.Parameters.AddWithValue("@IdCliente", this.IdCliente);
                cmd.Parameters.AddWithValue("@CantidadHuevos", this.CantidadHuevos);
                cmd.Parameters.AddWithValue("@TipoHuevo", this.TipoHuevo);
                cmd.Parameters.AddWithValue("@FechaInicio", this.FechaInicio);
                cmd.Parameters.AddWithValue("@FechaFinal", this.FechaFinal);
                cmd.Parameters.AddWithValue("@Total", this.Total);
                cmd.Parameters.AddWithValue("@IdNivel" , this.IdNivel);
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
                cmd.CommandText = "UPDATE Incubadora SET IdCliente=@IdCliente,CantidadHuevos=@CantidadHuevos,TipoHuevo=@TipoHuevo, FechaInicio=@FechaInicio, FechaFinal=@FechaFinal,Total=@Total,IdNivel=@IdNivel WHERE IdIncubadora=@IdIncubadora";
                cmd.Parameters.AddWithValue("@IdCliente", this.IdCliente);
                cmd.Parameters.AddWithValue("@CantidadHuevos", this.CantidadHuevos);
                cmd.Parameters.AddWithValue("@TipoHuevo", this.TipoHuevo);
                cmd.Parameters.AddWithValue("@FechaInicio", this.FechaInicio);
                cmd.Parameters.AddWithValue("@FechaFinal", this.FechaFinal);
                cmd.Parameters.AddWithValue("@Total", this.Total);
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

        #region Eliminar
        public void Eliminar()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = BaseDatos.conn;
                cmd.CommandText = "DELETE FROM Incubadora WHERE IdIncubadora=@IdIncubadora";
                cmd.Parameters.AddWithValue("@IdIncubadora", this.IdIncubadora);
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
                cmd.CommandText = "SELECT * FROM Incubadora WHERE IdIncubadora=@IdIncubadora";
                cmd.Parameters.AddWithValue("@IdIncubadora", this.IdIncubadora);
                BaseDatos.conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    this.IdCliente = Convert.ToInt32(dr["IdCliente"].ToString());
                    this.CantidadHuevos = Convert.ToInt32(dr["CantidadHuevos"].ToString());
                    this.TipoHuevo = dr["TipoHuevo"].ToString();
                    this.FechaInicio = Convert.ToDateTime(dr["FechaInicio"].ToString());
                    this.FechaFinal = Convert.ToDateTime(dr["FechaFinal"].ToString());
                    this.Total = Convert.ToDouble(dr["Total"].ToString());
                    this.IdNivel = Convert.ToInt32(dr["IdNivel"].ToString());
                }
                BaseDatos.conn.Close();
                return this.IdCliente + "|" + this.CantidadHuevos + "|" + this.TipoHuevo + "|" + this.FechaInicio + "|" + this.FechaFinal + "|" + this.Total + "|" + this.IdNivel;
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
        public List<Incubadora> ObtenerListado()
        {
            List<Incubadora> lista = new List<Incubadora>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = BaseDatos.conn;
                cmd.CommandText = "SELECT Incubadora.IdIncubadora, Incubadora.CantidadHuevos, Incubadora.TipoHuevo, Incubadora.FechaInicio, Incubadora.FechaFinal, Incubadora.Total, Incubadora.IdNivel, Incubadora.IdCliente,  Cliente.Nombre + ' ' + Cliente.Apellido AS NombreCompleto FROM Cliente INNER JOIN (Incubadora INNER JOIN Nivel ON Incubadora.IdNivel = Nivel.IdNivel) ON Incubadora.IdCliente = Cliente.IdCliente";
                BaseDatos.conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                Incubadora i;
                while (dr.Read())
                {
                    i = new Incubadora();
                    i.IdCliente = Convert.ToInt32(dr["IdIncubadora"].ToString());
                    i.IdCliente = Convert.ToInt32(dr["IdCliente"].ToString());
                    i.CantidadHuevos = Convert.ToInt32(dr["CantidadHuevos"].ToString());
                    i.TipoHuevo = dr["TipoHuevo"].ToString();
                    i.FechaInicio = Convert.ToDateTime(dr["FechaInicio"].ToString());
                    i.FechaFinal = Convert.ToDateTime(dr["FechaFinal"].ToString());
                    i.Total = Convert.ToDouble(dr["Total"].ToString());
                    i.IdNivel = Convert.ToInt32(dr["IdNivel"].ToString());
                    i.NombreCompleto  = dr["NombreCompleto"].ToString();
                    lista.Add(i);
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

        #region ObternerListaPorIdCliente
        public List<Incubadora> ObtenerListadoIdCliente(int validar)
        {
            List<Incubadora> lista = new List<Incubadora>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = BaseDatos.conn;
                cmd.CommandText = "SELECT Incubadora.IdIncubadora, Incubadora.CantidadHuevos, Incubadora.TipoHuevo, Incubadora.FechaInicio, Incubadora.FechaFinal, Incubadora.Total, Incubadora.IdNivel, Incubadora.IdCliente,  Cliente.Nombre + ' ' + Cliente.Apellido AS NombreCompleto FROM Cliente INNER JOIN (Incubadora INNER JOIN Nivel ON Incubadora.IdNivel = Nivel.IdNivel) ON Incubadora.IdCliente = Cliente.IdCliente WHERE Incubadora.IdCliente = @Validar AND  Cliente.IdCliente = @Validar";
                cmd.Parameters.AddWithValue("@Validar", validar);
                BaseDatos.conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                Incubadora i;
                while (dr.Read())
                {
                    i = new Incubadora();
                    i.IdCliente = Convert.ToInt32(dr["IdIncubadora"].ToString());
                    i.IdCliente = Convert.ToInt32(dr["IdCliente"].ToString());
                    i.CantidadHuevos = Convert.ToInt32(dr["CantidadHuevos"].ToString());
                    i.TipoHuevo = dr["TipoHuevo"].ToString();
                    i.FechaInicio = Convert.ToDateTime(dr["FechaInicio"].ToString());
                    i.FechaFinal = Convert.ToDateTime(dr["FechaFinal"].ToString());
                    i.Total = Convert.ToDouble(dr["Total"].ToString());
                    i.IdNivel = Convert.ToInt32(dr["IdNivel"].ToString());
                    i.NombreCompleto = dr["NombreCompleto"].ToString();
                    lista.Add(i);
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

        #region ObtenerListadoIdCliente
        public List<Cliente> ObtenerIdCliente()
        {
            List<Cliente> lista = new List<Cliente>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = BaseDatos.conn;
                cmd.CommandText = "SELECT IdCliente, Nombre, Apellido FROM Cliente";
                BaseDatos.conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                Cliente c;
                while (dr.Read())
                {
                    c = new Cliente();
                    c.IdCliente = Convert.ToInt32(dr["idProveedor"].ToString());
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

        #region ObtenerListadoIdNivel
        public List<Incubadora> ObtenerIdNivel()
        {
            List<Incubadora> lista = new List<Incubadora>();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = BaseDatos.conn;
                cmd.CommandText = "SELECT  IdNivel, FechaFinal FROM Incubadora";
                BaseDatos.conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                Incubadora  i;
                while (dr.Read())
                {
                    i = new Incubadora();
                  
                    i.IdNivel  = Convert.ToInt32(dr["IdNivel"].ToString());
                    i.FechaFinal  = Convert.ToDateTime(dr["FechaFinal"].ToString());
                    
                    lista.Add(i);
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

        //#region ventaPorCliente
        //public List<Incubadora> ObtenerIdNivel()
        //{
        //    List<Incubadora> lista = new List<Incubadora>();
        //    try
        //    {
        //        SqlCommand cmd = new SqlCommand();
        //        cmd.Connection = BaseDatos.conn;
        //        cmd.CommandText = "SELECT  IdNivel, FechaFinal FROM Incubadora";
        //        BaseDatos.conn.Open();
        //        SqlDataReader dr = cmd.ExecuteReader();
        //        Incubadora i;
        //        while (dr.Read())
        //        {
        //            i = new Incubadora();

        //            i.IdNivel = Convert.ToInt32(dr["IdNivel"].ToString());
        //            i.FechaFinal = Convert.ToDateTime(dr["FechaFinal"].ToString());

        //            lista.Add(i);
        //        }
        //        BaseDatos.conn.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    finally
        //    {
        //        BaseDatos.conn.Close();
        //    }
        //    return lista;
        //}
        //#endregion
     
    }
}

