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

namespace BarbosaSoft
{
    public partial class frmArticulos : Form
    {
        //iniciamos la conexion
        OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = D:\VS Projects\Bicicleteria-Software\BarbosaSoft\BicicleteriaDB.accdb");
        List<Articulos> articulos = new List<Articulos>();  //almacenará una lista de objetos articulos

        public frmArticulos()
        {
            InitializeComponent();
        }


        private void frmArticulos_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lbl_date.Text = DateTime.Now.ToLongDateString();
            lbl_time.Text = DateTime.Now.ToLongTimeString();
            bool estaConectado = false;

            try
            {
                con.Open();
                //MessageBox.Show(con.State.ToString());
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
                // Leemos todos los datos de la tabla articulos
                OleDbCommand cmd = new OleDbCommand("select * from Articulos", con);

                // Creamos un reader, que nos permitirá ejecutar la consulta
                OleDbDataReader r = cmd.ExecuteReader();

                int columnas = r.FieldCount; // Obtenemos la cantidad de columnas

                if (r.HasRows)//Tenemos una o mas filas
                {
                    while (r.Read()) // Recorremos todas las filas
                    {
                        Articulos ar = new Articulos();
                        ar.Codigo = r.GetInt32(0); // valor de la celda correspondiente a la fila actual y primera columna
                        ar.Nombre = r.GetString(1); // valor de la segunda columna
                        ar.Precio = r.GetInt32(2);

                        articulos.Add(ar);
                    }

                    inicializarTablaArticulos();
                    //Mostramos los datos en la grilla
                    for (int i = 0; i < articulos.Count(); i++)
                    {
                        tablaArticulos.Rows.Add(articulos[i].Codigo, articulos[i].Nombre, articulos[i].Precio);
                    }
                    articulos.Clear();

                }
                else // No hay filas para leer
                {
                    MessageBox.Show("No tenemos filas");
                }
                r.Close();
            }
        }

        private void inicializarTablaArticulos()
        {
            //Inicializamos la grilla
            tablaArticulos.AllowUserToAddRows = false;
            tablaArticulos.AllowUserToDeleteRows = false;
            tablaArticulos.AllowUserToOrderColumns = false;
            tablaArticulos.ReadOnly = true;
            tablaArticulos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tablaArticulos.EditMode = DataGridViewEditMode.EditProgrammatically;
            tablaArticulos.MultiSelect = false;
            tablaArticulos.AutoResizeColumns();
            tablaArticulos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            tablaArticulos.Columns.Add("codigo", "Codigo");
            tablaArticulos.Columns.Add("nombre", "Nombre");
            tablaArticulos.Columns.Add("precio", "Precio");

        }

        //Actualizar dataGrid
        private void actualizarTablaArticulos()
        {
            //Limpiamos la grilla
            tablaArticulos.Rows.Clear();
            tablaArticulos.Refresh();

            // Leemos todos los datos de la tabla clientes
            OleDbCommand cmd = new OleDbCommand("select * from Articulos", con);     //consulta SQL

            // Creamos un reader, que nos permitirá ejecutar la consulta
            OleDbDataReader r = cmd.ExecuteReader();

            if (r.HasRows) //Tenemos una o mas filas
            {
                while (r.Read()) // Recorremos todas las filas
                {
                    Articulos ar = new Articulos();
                    ar.Codigo = r.GetInt32(0); // valor de la celda correspondiente a la fila actual y primera columna
                    ar.Nombre = r.GetString(1); // valor de la segunda columna
                    ar.Precio = r.GetInt32(2);

                    articulos.Add(ar);
                }
                
                //Mostramos los datos en la grilla
                for (int i = 0; i < articulos.Count(); i++)
                {
                    tablaArticulos.AllowUserToAddRows = false;
                    tablaArticulos.Rows.Add(articulos[i].Codigo, articulos[i].Nombre, articulos[i].Precio);
                }
                articulos.Clear(); //limpio la lista de articulos para utilizarla en otros lugares
            }
            else
                inicializarTablaArticulos();
            r.Close();
        }
       
        //Nuevo registro
        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {

                if(String.IsNullOrEmpty(txtNombre.Text) || String.IsNullOrEmpty(txtPrecio.Text))
                {
                    MessageBox.Show("Ningun campo puede estar vacio");
                }
                else
                {
                    string nombre = txtNombre.Text;
                    float precio = Convert.ToSingle(txtPrecio.Text);                                    

                    //Escribimos el comando de inserción
                    //El codigo es autonumérico por lo cual no necesitamos establecerlo

                    string strinsert = "INSERT INTO Articulos (Nombre, Precio) Values(@nom, @pre)";
                    OleDbCommand cmd = new OleDbCommand(strinsert, con);

                    //Establecemos los parámetros que se utilizarán en el comando Insert
                    cmd.Parameters.AddWithValue("nom", nombre);
                    cmd.Parameters.AddWithValue("pre", precio);
                    
                    try
                    {
                        cmd.ExecuteNonQuery(); //Ejecutamos el comando
                        MessageBox.Show("Nuevo articulo agregado");
                    }
                    catch (OleDbException ex)
                    {
                        MessageBox.Show("Error al insertar los datos: " + ex);
                    }

                    //Actualizamos la grilla y limpiamos los campos
                    try
                    {
                        actualizarTablaArticulos();
                    }
                    catch (NullReferenceException ex)
                    {
                        MessageBox.Show("No se pudo actualizar la tabla: \n" + ex);
                        throw;
                    }
                    btnLimpiar_Click(this, null);
                }
                
            }
        }

        //Actualizar datos
        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                if (String.IsNullOrEmpty(txtNombre.Text) || String.IsNullOrEmpty(txtPrecio.Text))
                {
                    MessageBox.Show("Ningun campo puede estar vacio");
                }
                else
                {
                    string nombre = txtNombre.Text;
                    float precio = Convert.ToSingle(txtPrecio.Text);
                    int codigo = Convert.ToInt32(txtCodigo.Text);

                    //Escribimos el comando de actualización
                    string strupdate = "UPDATE Articulos Set Nombre = @nom, Precio = @pre WHERE Codigo = @codigo";

                    OleDbCommand cmd = new OleDbCommand(strupdate, con);
                    //Establecemos los parámetros que se utilizarán en el comando Update
                    cmd.Parameters.AddWithValue("nom", nombre);
                    cmd.Parameters.AddWithValue("pre", precio);
                    cmd.Parameters.AddWithValue("codigo", codigo);
                    cmd.ExecuteNonQuery(); //Ejecutamos el comando

                    MessageBox.Show("Registro modificado!");

                    //Actualizamos la grilla
                    actualizarTablaArticulos();
                }

            }
        }

        //Borrar registro
        private void btnBorrar_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar el registro?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                if (con.State == ConnectionState.Open)
                {
                    int cod = Convert.ToInt32(txtCodigo.Text);
                    //Escribimos el comando de eliminacion
                    string strdelete = "DELETE FROM Articulos WHERE codigo = @codigo;";

                    OleDbCommand cmd = new OleDbCommand(strdelete, con);
                    //Establecemos los parámetros que se utilizarán en el comando delete
                    cmd.Parameters.AddWithValue("codigo", cod);

                    cmd.ExecuteNonQuery(); //Ejecutamos el comando

                    MessageBox.Show("Registro eliminado");

                    //Actualizamos la grilla y borramos los campos
                    actualizarTablaArticulos();
                    btnLimpiar_Click(this, null);
                }
            }
            
        }

        //Limpiar campos
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtPrecio.Text = "";
        }

        //Volver al menu principal
        private void btnVolver_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Close();
        }

        //Click en el dataGrid
        private void tablaArticulos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = tablaArticulos.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = tablaArticulos.CurrentRow.Cells[1].Value.ToString();
            txtPrecio.Text = tablaArticulos.CurrentRow.Cells[2].Value.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_time.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }
    }
}
