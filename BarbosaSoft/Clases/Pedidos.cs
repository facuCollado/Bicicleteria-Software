using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarbosaSoft.Clases
{
    class Pedidos
    {
        private int id;
        private string nombreCliente;
        private string apellidoCliente;
        private string telefono;
        private long dni;
        private string descripcion;
        private double total;

        public int Id { get => id; set => id = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string ApellidoCliente { get => apellidoCliente; set => apellidoCliente = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public long Dni { get => dni; set => dni = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public double Total { get => total; set => total = value; }
    }
}
