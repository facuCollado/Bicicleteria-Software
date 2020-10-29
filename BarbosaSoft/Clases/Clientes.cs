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
        private long dni;
        private string direccion;
        private string localidad;        
        private string telefono;

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public long Dni { get; set; }
        public string Direccion { get; set; }
        public string Localidad { get; set; }        
        public string Telefono { get; set; }
    }
}
