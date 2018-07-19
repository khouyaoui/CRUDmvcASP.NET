using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using model.dao;
using model.entity;

namespace model.neg
{
    public class EmpleadoNeg
    {
        private EmpleadoDao objEmpleadoDao;
        public EmpleadoNeg()
        {
            objEmpleadoDao = new EmpleadoDao;
        }
        public void create(Empleado objEmpleado)
        {
            //validando is isha oyda aghd yozan nom,app,tel,id estado 1,2,3,4,5
            bool verificacion;
            string codigo = objEmpleado.IdEmpleado.ToString();
            int idEmpleado = 0;
            if (codigo == null)
            {
                objEmpleado.Estado = 10;
                return;
            }
            else
            {

                try {
                    idEmpleado = Convert.ToInt32(objEmpleado.IdEmpleado);
                    verificacion = idEmpleado >= 10 && idEmpleado <= 99;
                    if (!verificacion)
                    {
                        objEmpleado.Estado = 1;
                        return;
                    }
                } catch (Exception e)
                {
                    objEmpleado.Estado = 100;
                }
            }
            string nombre = objEmpleado.Nombre;
            if (nombre == null)
            {
                objEmpleado.Estado = 20;
                return;
            }
            else
            {
                nombre = objEmpleado.Nombre.Trim();
                verificacion = nombre.Length > 0 && nombre.Length <= 50;
                if (!verificacion)
                {
                    objEmpleado.Estado = 2;
                    return;
                }
            }

            string apellido = objEmpleado.Apellido;
            if (apellido == null)
            {
                objEmpleado.Estado = 30;
                return;
            }
            else
            {
                apellido = objEmpleado.Apellido.Trim();
                verificacion = apellido.Length > 0 && apellido.Length <= 50;
                if (!verificacion)
                {
                    objEmpleado.Estado = 3;
                    return;
                }
            }

            string telefono = objEmpleado.Telefono;
            if (apellido == null)
            {
                objEmpleado.Estado = 40;
                return;
            }
            else
            {
                telefono = objEmpleado.Telefono.Trim();
                verificacion = telefono.Length > 0 && telefono.Length <= 50;
                if (!verificacion)
                {
                    objEmpleado.Estado = 4;
                    return;
                }
            }

            Empleado objEmpleadoAux = new Empleado();
            objEmpleadoAux.IdEmpleado = objEmpleado.IdEmpleado;
            verificacion = 
        }
    }
}
