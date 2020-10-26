using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarbosaSoft.Clases
{
    class Clientes
    {
        private int id;
        private string nombre;
        private string apellido;
        private string direccion;
        private string provincia;
        private string ciudad;
        private long dni;
        private long telefono;


        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }

        }

        public string Apellido
        {
            get
            {
                return apellido;
            }
            set
            {
                apellido = value;
            }
        }

        public string Direccion
        {
            get
            {
                return direccion;
            }
            set
            {
                direccion = value;
            }
        }

        public string Provincia
        {
            get
            {
                return provincia;
            }
            set
            {
                provincia = value;
            }
        }

        public string Ciudad
        {
            get
            {
                return ciudad;
            }
            set
            {
                ciudad = value;
            }
        }

        public long Dni
        {
            get
            {
                return dni;
            }
            set
            {
                dni = value;
            }
        }

        public long Telefono
        {
            get
            {
                return telefono;
            }
            set
            {
                telefono = value;
            }
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }
    }
}
