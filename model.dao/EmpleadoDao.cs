using model.entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model.dao
{
    public class EmpleadoDao : Obligatorio<Empleado>
    {
        private Conexion objConexion;
        private SqlCommand comando;

        public EmpleadoDao()
        {
            objConexion = Conexion.saberEstado();
        }


        public void create(Empleado objEmpleado)
        {
            string create = recursodao.insertdb + objEmpleado.IdEmpleado+"','"+objEmpleado.Nombre+"','" +objEmpleado.Apellido+",'"+objEmpleado.Telefono + "')";
            try
            {
                comando = new SqlCommand(create, objConexion.getCon());
                objConexion.getCon().Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                objConexion.getCon().Close();
                objConexion.cerrarConexion();
            }
        }

        public void delete(Empleado objEmpleado)
        {
            string delete = "delete from Empleado where IdEmpleado='" + objEmpleado.IdEmpleado +"'";
                            try
            {
                comando = new SqlCommand(delete, objConexion.getCon());
                objConexion.getCon().Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                objConexion.getCon().Close();
                objConexion.cerrarConexion();
            }
        }

        public bool find(Empleado objEmpleado)
        {

            bool hayRegistro;
            string find="select * from Empleado where IdEmpleado='"+objEmpleado.IdEmpleado+ " ' ";
            try
            {
                comando = new SqlCommand(find, objConexion.getCon());
                objConexion.getCon().Open();
                SqlDataReader read = comando.ExecuteReader();
                hayRegistro = read.Read();
                if (hayRegistro)
                {
                    objEmpleado.IdEmpleado = Convert.ToInt32(read[0]);
                    objEmpleado.Nombre = read[1].ToString();
                    objEmpleado.Apellido = read[2].ToString();
                    objEmpleado.Telefono = read[3].ToString();

                    objEmpleado.Estado = 99;

                }
                else
                {
                    objEmpleado.Estado = 1;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return hayRegistro;
        }

        public List<Empleado> FindAll()
        {
            List<Empleado> listaEmpleados = new List<Empleado>();

            string FindAll = "select * from Empleado";
            try
            {
                comando = new SqlCommand(FindAll, objConexion.getCon());
                objConexion.getCon().Open();
                SqlDataReader read = comando.ExecuteReader();
                while (read.Read())
                {
                    Empleado objEmpleado = new Empleado();

                    objEmpleado.IdEmpleado = Convert.ToInt32(read[0]);
                    objEmpleado.Nombre = read[1].ToString();
                    objEmpleado.Apellido = read[2].ToString();
                    objEmpleado.Telefono = read[3].ToString();
                    listaEmpleados.Add(objEmpleado);
                }
            }
            catch (Exception)
            {

                throw;
            }
            return listaEmpleados;
        }

        public void update(Empleado objEmpleado)
        {
            string update = "update Empleado set Nombre='" + objEmpleado.Nombre + "',Apellido='" + objEmpleado.Apellido + "',Telefono'" + objEmpleado.Telefono + "' where IdEmpleado='" + objEmpleado.IdEmpleado + "'";
            try
            {
                comando = new SqlCommand(update, objConexion.getCon());
                objConexion.getCon().Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                objConexion.getCon().Close();
                objConexion.cerrarConexion();
            }
        }
    }
}
