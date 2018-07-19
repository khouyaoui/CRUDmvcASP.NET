using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model.entity
{
    public class Empleado
    {
        //creamos los atributos
        private int idEmpleado;
        private String nombre;
        private String apellido;
        private String telefono;
        //para errores
        private int estado;

        public Empleado()
        {

        }
        public Empleado(int idEmpleado)
        {
            this.IdEmpleado = idEmpleado;

        }
        public Empleado(int idEmpleado,string nombre,string apellido, string telefono)
        {
            this.IdEmpleado = idEmpleado;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Telefono = telefono;
        }

        public int IdEmpleado { get => idEmpleado; set => idEmpleado = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public int Estado { get => estado; set => estado = value; }

    }
}
