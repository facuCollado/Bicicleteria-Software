using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarbosaSoft
{
    public static class Autocompletar
    {
        public static DataTable Datos()
        {
            // creamos un datatable que almacena filas y columnas
            DataTable dt = new DataTable();

            //abrimos la conexion
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BicicleteriaDB.accdb");

            //creamos una consulta a la BD
            string consulta = "SELECT * FROM Clientes"; //consulta a la tabla articulos

            OleDbCommand com = new OleDbCommand(consulta, con);

            OleDbDataAdapter adap = new OleDbDataAdapter(com);

            adap.Fill(dt);
            return dt;
        }

        //funcion autocompletar
        public static AutoCompleteStringCollection Autocomplete()
        {
            DataTable dt = Datos();

            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();

            //recorrer y cargar los items para el autocompletado
            foreach (DataRow row in dt.Rows)
            {
                coleccion.Add(Convert.ToString(row["Nombre"]));     // busca por nombre
                coleccion.Add(Convert.ToString(row["Apellido"]));     // busca por apellido
            }

            return coleccion;
        }
    }
}
