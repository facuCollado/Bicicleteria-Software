using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using BarbosaSoft.Clases;

namespace BarbosaSoft.Vista
{
    public partial class frmClientes : Form
    {
        //iniciamos la conexion
        OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\Usuario\Documents\Dev\Desktop\WindowsForm\Bicicleteria-Software-Dev-Emi\BarbosaSoft\BicicleteriaDB.accdb");
        List<Clientes> clientes = new List<Clientes>(); //almacenará una lista de objetos clientes

        public frmClientes()
        {
            InitializeComponent();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lbl_date.Text = DateTime.Now.ToLongDateString();
            lbl_time.Text = DateTime.Now.ToLongTimeString();
            bool estaConectado = false;

            try
            {
                con.Open();
                //MessageBox.Show(cn.State.ToString());
                estaConectado = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo conectar: \n" + ex);
                estaConectado = false;
            }
            // Si logramos conectarnos entonces vamos a leer la DB
            if (estaConectado == true)
            {
                // Leemos todos los datos de la tabla clientes
                OleDbCommand cmd = new OleDbCommand("select * from Clientes", con);

                // Creamos un reader, que nos permitirá ejecutar la consulta
                OleDbDataReader r = cmd.ExecuteReader();

                int columnas = r.FieldCount; // Obtenemos la cantidad de columnas
                                             //MessageBox.Show("Tenemos " + columnas + " columnas en total");    

                if (r.HasRows) //Tenemos una o mas filas
                {
                    while (r.Read()) // Recorremos todas las filas
                    {
                        Clientes c = new Clientes();
                        c.Id = r.GetInt32(0); // valor de la celda correspondiente a la fila actual y primera columna
                        c.Nombre = r.GetString(1); // valor de la segunda columna
                        c.Apellido = r.GetString(2);
                        c.Telefono = r.GetString(3);
                        c.Direccion = r.GetString(4);
                        c.Dni = r.GetInt32(5);
                        c.Localidad = r.GetString(6);                        
                        
                        clientes.Add(c);
                    }

                    inicializarTablaClientes();
                    //Mostramos los datos en la grilla
                    for (int i = 0; i < clientes.Count(); i++)
                    {
                       tablaclientes.Rows.Add
                       (clientes[i].Id,
                        clientes[i].Nombre,
                        clientes[i].Apellido,
                        clientes[i].Dni,
                        clientes[i].Direccion,
                        clientes[i].Localidad,
                        clientes[i].Telefono);
                    }

                    clientes.Clear(); //limpio la lista de clientes para utilizarla en otros lugares

              

                }
                else // No hay filas para leer
                {
                    MessageBox.Show("No hay datos en la base de datos");
                }
                r.Close();
            }
            
        }

        private void inicializarTablaClientes()
        {
            //Inicializamos la grilla
            tablaclientes.AllowUserToAddRows = false;
            tablaclientes.AllowUserToDeleteRows = false;
            tablaclientes.AllowUserToOrderColumns = false;
            tablaclientes.ReadOnly = true;
            tablaclientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tablaclientes.EditMode = DataGridViewEditMode.EditProgrammatically;
            tablaclientes.MultiSelect = false;

            tablaclientes.Columns.Add("id", "Id");
            tablaclientes.Columns.Add("nombre", "Nombre");
            tablaclientes.Columns.Add("apellido", "Apellido");
            tablaclientes.Columns.Add("dni", "Dni");
            tablaclientes.Columns.Add("direccion", "Dirección");
            tablaclientes.Columns.Add("localidad", "Localidad");
            tablaclientes.Columns.Add("telefono", "Telefono");
           
        }

        //Actualizar grilla
        private void actualizarTablaClientes()
        {
            //Limpiamos la grilla
            tablaclientes.Rows.Clear();
            tablaclientes.Refresh();

            // Leemos todos los datos de la tabla clientes
            OleDbCommand cmd = new OleDbCommand("select * from Clientes", con);     //consulta SQL

            // Creamos un reader, que nos permitirá ejecutar la consulta
            OleDbDataReader r = cmd.ExecuteReader();

            if (r.HasRows) //Tenemos una o mas filas
            {
                while (r.Read()) // Recorremos todas las filas
                {
                    Clientes c = new Clientes();
                    c.Id = r.GetInt32(0); // valor de la celda correspondiente a la fila actual y primera columna
                    c.Nombre = r.GetString(1); // valor de la segunda columna
                    c.Apellido = r.GetString(2);
                    c.Telefono = r.GetString(3);
                    c.Direccion = r.GetString(4);
                    c.Dni = r.GetInt32(5);
                    c.Localidad = r.GetString(6);

                    clientes.Add(c);
                }

                //Mostramos los datos en la grilla
                for (int i = 0; i < clientes.Count(); i++)
                {
                    tablaclientes.Rows.Add
                       (clientes[i].Id,
                        clientes[i].Nombre, 
                        clientes[i].Apellido, 
                        clientes[i].Dni, 
                        clientes[i].Direccion, 
                        clientes[i].Localidad, 
                        clientes[i].Telefono);
                }
                clientes.Clear();
            }
            else
                inicializarTablaClientes();
            r.Close();
        }

        // Nuevo registro
        private void btnNuevoCliente_Click_1(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                if(String.IsNullOrEmpty(txtNombre.Text) || String.IsNullOrEmpty(txtApellido.Text) || String.IsNullOrEmpty(txtDni.Text) ||
                    String.IsNullOrEmpty(txtDireccion.Text) || String.IsNullOrEmpty(txtLocalidad.Text) || String.IsNullOrEmpty(txtTelefono.Text))
                {
                    MessageBox.Show("Ningun campo puede estar vacio");
                }
                else
                {
                    string nombre = txtNombre.Text;
                    string apellido = txtApellido.Text;
                    long dni = Convert.ToInt64(txtDni.Text);
                    string dir = txtDireccion.Text;
                    string loc = txtLocalidad.Text;
                    string tel = txtTelefono.Text;

                    //Escribimos el comando de inserción
                    //El ID del cliente es autonumérico por lo cual no necesitamos establecerlo

                    string strinsert = "INSERT into Clientes (Nombre, Apellido, Dni, Direccion, Localidad, Telefono) Values(@nom, @ape, @dni, @dir, @loc, @tel)";
                    OleDbCommand cmd = new OleDbCommand(strinsert, con);
                    //Establecemos los parámetros que se utilizarán en el comando Insert

                    cmd.Parameters.AddWithValue("nom", nombre);
                    cmd.Parameters.AddWithValue("ape", apellido);
                    cmd.Parameters.AddWithValue("dni", dni);
                    cmd.Parameters.AddWithValue("dir", dir);
                    cmd.Parameters.AddWithValue("loc", loc);
                    cmd.Parameters.AddWithValue("tel", tel);

                    try
                    {
                        cmd.ExecuteNonQuery(); //Ejecutamos el comando
                    }
                    catch (OleDbException ex)
                    {
                        MessageBox.Show("Error al insertar los datos: " + ex);                        
                    }
                                        
                    //Actualizamos la grilla
                    actualizarTablaClientes();
                    
                    //Limpiamos los campos
                    btnLimpiar_Click_1(this, null);
                }            

            }
        }

        // Actualizar registro
        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                if (String.IsNullOrEmpty(txtNombre.Text) || String.IsNullOrEmpty(txtApellido.Text) || String.IsNullOrEmpty(txtDni.Text) ||
                    String.IsNullOrEmpty(txtDireccion.Text) || String.IsNullOrEmpty(txtLocalidad.Text) || String.IsNullOrEmpty(txtTelefono.Text))
                {
                    MessageBox.Show("Ningun campo puede estar vacio");
                }
                else
                {
                    int id = Convert.ToInt32(txtId.Text);
                    string nombre = txtNombre.Text;
                    string apellido = txtApellido.Text;
                    long dni = Convert.ToInt64(txtDni.Text);
                    string dir = txtDireccion.Text;
                    string loc = txtLocalidad.Text;
                    string tel = txtTelefono.Text;


                    //Escribimos el comando de actualización
                    string strupdate = "Update Clientes Set Nombre = @nom, Apellido = @ape, Dni = @dni, Direccion = @dir, Localidad = @loc, Telefono = @tel WHERE Id = @id";

                    OleDbCommand cmd = new OleDbCommand(strupdate, con);
                    //Establecemos los parámetros que se utilizarán en el comando Update
                    cmd.Parameters.AddWithValue("nom", nombre);
                    cmd.Parameters.AddWithValue("ape", apellido);
                    cmd.Parameters.AddWithValue("dni", dni);
                    cmd.Parameters.AddWithValue("dir", dir);
                    cmd.Parameters.AddWithValue("loc", loc);
                    cmd.Parameters.AddWithValue("tel", tel);
                    cmd.Parameters.AddWithValue("id", id);

                    try
                    {
                        cmd.ExecuteNonQuery(); //Ejecutamos el comando
                    }
                    catch (OleDbException ex)
                    {
                        MessageBox.Show("Error al insertar los datos: " + ex);
                    }

                    //Actualizamos la grilla
                    actualizarTablaClientes();
                }               
               
            }
        }

        // Eliminar registro
        private void btnBorrar_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar el registro?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                if (con.State == ConnectionState.Open)
                {
                    int id = Convert.ToInt32(txtId.Text);
                    //Escribimos el comando de eliminacion
                    string strdelete = "DELETE FROM Clientes WHERE id = @id;";

                    OleDbCommand cmd = new OleDbCommand(strdelete, con);
                    //Establecemos los parámetros que se utilizarán en el comando delete
                    cmd.Parameters.AddWithValue("id", id);

                    cmd.ExecuteNonQuery(); //Ejecutamos el comando

                    //Actualizamos la grilla
                    actualizarTablaClientes();

                    //Limpiamos los campos
                    btnLimpiar_Click_1(this, null);
                }
            }                
        }

        //Limpiar campos
        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtApellido.Text = "";
            txtNombre.Text = "";
            txtTelefono.Text = "";
            txtDni.Text = "";
            txtDireccion.Text = "";
            txtLocalidad.Text = "";            
        }

        //volver al menu principal
        private void btnVolver_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Close();
        }

        //Rellenar campos con los datos en la grilla
        private void tablaclientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Al seleccionar cualquier fila, se cargan los datos en los textbox
            //Nota: por cuestiones de simplificar el ejemplo sólo cargamos los datos en pantalla
            //y no cargamos el objeto cliente. Cada campo en pantalla debería ser consistente
            //con el atributo del objeto persona que está seleccionado.

            txtId.Text = tablaclientes.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = tablaclientes.CurrentRow.Cells[1].Value.ToString();
            txtApellido.Text = tablaclientes.CurrentRow.Cells[2].Value.ToString();
            txtDni.Text = tablaclientes.CurrentRow.Cells[3].Value.ToString();
            txtDireccion.Text = tablaclientes.CurrentRow.Cells[4].Value.ToString();
            txtLocalidad.Text = tablaclientes.CurrentRow.Cells[5].Value.ToString();
            txtTelefono.Text = tablaclientes.CurrentRow.Cells[6].Value.ToString();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_time.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }
    }
}
