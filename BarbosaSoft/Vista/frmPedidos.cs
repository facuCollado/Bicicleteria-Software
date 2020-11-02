using BarbosaSoft.Clases;
using BarbosaSoft.Vista;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Windows.Forms;

namespace BarbosaSoft
{
    public partial class Pedidos_Form : Form
    {
        //iniciamos la conexion
        OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\Usuario\Documents\Dev\Desktop\WindowsForm\Bicicleteria-Software-main\BarbosaSoft\BicicleteriaDB.accdb");
        List<Pedidos> pedidos = new List<Pedidos>();

        public Pedidos_Form()
        {
            InitializeComponent();
        }

        private void Pedidos_Form_Load(object sender, EventArgs e)
        {
           
            timer1.Start();
            lbl_date.Text = DateTime.Now.ToLongDateString();
            lbl_time.Text = DateTime.Now.ToLongTimeString();

            //Sugerencia en campo dni
            txtDni.AutoCompleteCustomSource = Autocompletar.Autocomplete();
            txtDni.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtDni.AutoCompleteSource = AutoCompleteSource.CustomSource;

            bool estaConectado = false;

            try
            {
                con.Open();
                estaConectado = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo conectar: \n" + ex);
                estaConectado = false;
            }

            if (estaConectado == true)
            {
                OleDbCommand cmd = new OleDbCommand("select * from Pedidos", con);
                OleDbDataReader r = cmd.ExecuteReader();

                int columnas = r.FieldCount;

                if (r.HasRows) //Si tenemos una o mas filas
                {
                    while (r.Read()) // Recorremos todas las filas
                    {
                        Pedidos c = new Pedidos();
                        c.Id = r.GetInt32(0);
                        c.NombreCliente = r.GetString(1);
                        c.ApellidoCliente = r.GetString(2);
                        c.Telefono = r.GetString(3);
                        c.Dni = r.GetInt32(4);
                        c.Descripcion = r.GetString(5);
                        c.Total = r.GetDouble(6);
                        c.Terminado = r.GetBoolean(7);
                        c.FechaPedido = r.GetDateTime(8);
                        c.FechaEntrega= r.GetDateTime(9);
                        pedidos.Add(c);
                    }

                    inicializarTablaPedidos();
                    //Mostramos los datos en la grilla
                    for (int i = 0; i < pedidos.Count(); i++)
                    {
                        tablaPedidos.Rows.Add
                           (pedidos[i].Id,
                            pedidos[i].NombreCliente,
                            pedidos[i].ApellidoCliente,
                            pedidos[i].Telefono,
                            pedidos[i].Dni,
                            pedidos[i].Descripcion,
                            pedidos[i].Total,
                            pedidos[i].Terminado,
                            pedidos[i].FechaPedido.ToString("dd/MM/yyyy"),
                            pedidos[i].FechaEntrega.ToString("dd/MM/yyyy"));
                    }

                    pedidos.Clear();                  
                }
                else // No hay filas para leer
                {
                    MessageBox.Show("No hay datos en la base de datos");
                }
                r.Close();
            }

        }

        //Inicializamos la grilla
        private void inicializarTablaPedidos()
        {
           tablaPedidos.AllowUserToAddRows = false;
            tablaPedidos.AllowUserToDeleteRows = false;
            tablaPedidos.AllowUserToOrderColumns = false;
            tablaPedidos.ReadOnly = true;
            tablaPedidos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //tablaPedidos.EditMode = DataGridViewEditMode.EditProgrammatically;
            tablaPedidos.MultiSelect = false;
            tablaPedidos.AutoResizeColumns();
            tablaPedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            //agrego el checkbox de terminado
            DataGridViewCheckBoxColumn checkTerminado = new DataGridViewCheckBoxColumn();
            checkTerminado.ValueType = typeof(bool);
            checkTerminado.ReadOnly = false;
            checkTerminado.Name = "Terminado";
            checkTerminado.HeaderText = "Terminado";
            
            tablaPedidos.Columns.Add("id", "Id");
            tablaPedidos.Columns.Add("nombre", "Nombre");
            tablaPedidos.Columns.Add("apellido", "Apellido");
            tablaPedidos.Columns.Add("telefono", "Telefono");
            tablaPedidos.Columns.Add("dni", "Dni");
            tablaPedidos.Columns.Add("descripcion", "Descripcion");
            tablaPedidos.Columns.Add("total", "Total");
            tablaPedidos.Columns.Add(checkTerminado);
            tablaPedidos.Columns.Add("fecha", "Fecha");
            tablaPedidos.Columns.Add("fechaEntrega", "Fecha Entrega");

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_time.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }
     
        //Busca por dni apretando enter
        private void txtDni_KeyDown(object sender, KeyEventArgs e)
        {
            if ((int)e.KeyCode == (int)Keys.Enter)      //al apretar enter se completan los campos
            {
                OleDbCommand cmd = new OleDbCommand("select * from Clientes WHERE Dni = @dni", con);
                cmd.Parameters.AddWithValue("@dni", txtDni.Text);

                OleDbDataReader r = cmd.ExecuteReader();
                if (r.Read())
                {
                    txtNombre.Text = r["Nombre"].ToString();
                    txtApellido.Text = r["Apellido"].ToString();
                    txtDni.Text = r["Dni"].ToString();
                    txtTelefono.Text = r["Telefono"].ToString();
                }

            }
        }

        //Limpiar campos
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDni.Text = "";
            txtTelefono.Text = "";
            txtDescripcion.Text = "";
            txtTotal.Text = "";
            
        }

        //Nuevo pedido
        private void btnNuevo_Click(object sender, EventArgs e)
        {
                     
            if (con.State == ConnectionState.Open)
            {
                if (String.IsNullOrEmpty(txtNombre.Text) || String.IsNullOrEmpty(txtApellido.Text) || String.IsNullOrEmpty(txtDni.Text) ||
                    String.IsNullOrEmpty(txtDescripcion.Text) || String.IsNullOrEmpty(txtTotal.Text))
                {
                    MessageBox.Show("Ningun campo puede estar vacio");
                }
                else
                {
                    string nombre = txtNombre.Text;
                    string apellido = txtApellido.Text;
                    string tel = txtTelefono.Text;
                    long dni = Convert.ToInt64(txtDni.Text);
                    string desc = txtDescripcion.Text;
                    double total = Convert.ToDouble(txtTotal.Text);
                    //obtengo la fecha
                    string fecha = DateTime.Now.ToString("dd/MM/yyyy"); 
                    string fecha_Entrega = dateTime_Entrega.Value.ToString("dd/MM/yyyy");
                  

                    //Escribimos el comando de inserción
                    //El ID del cliente es autonumérico por lo cual no necesitamos establecerlo

                    string strinsert = "INSERT into Pedidos (NombreCliente, ApellidoCliente, Telefono, Dni, Descripcion, Total, FechaPedido, EntregaPedido)" +
                        " Values(@nom, @ape, @tel, @dni, @desc, @total, @date, @returnDate)";
                    OleDbCommand cmd = new OleDbCommand(strinsert, con);
                    //Establecemos los parámetros que se utilizarán en el comando Insert

                    cmd.Parameters.AddWithValue("nom", nombre);
                    cmd.Parameters.AddWithValue("ape", apellido);
                    cmd.Parameters.AddWithValue("tel", tel);
                    cmd.Parameters.AddWithValue("dni", dni);
                    cmd.Parameters.AddWithValue("desc", desc);
                    cmd.Parameters.AddWithValue("total", total);
                    cmd.Parameters.AddWithValue("date", fecha);
                    cmd.Parameters.AddWithValue("returnDate", fecha_Entrega);

                    try
                    {
                        cmd.ExecuteNonQuery(); //Ejecutamos el comando
                        MessageBox.Show("Nuevo pedido agregado");
                    }
                    catch (OleDbException ex)
                    {
                        MessageBox.Show("Error al insertar los datos: " + ex);
                    }

                    //Veo si existe el dni ingresado
                    OleDbCommand find_Dni= new OleDbCommand("select * from Clientes WHERE Dni = @dni" , con);
                    find_Dni.Parameters.AddWithValue("dni", dni); 

                    OleDbDataReader r = find_Dni.ExecuteReader();
                    if (!r.Read())
                    {
                        if (MessageBox.Show("DNI no encontrado en la base de datos, ¿desea agregarlo?",
                            "DNI nuevo", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                        {
                            //si la respuesta es SI lo mando al form Clientes
                            this.Hide();
                            frmClientes clientes = new frmClientes();
                            clientes.txtDni.Text = txtDni.Text;
                            clientes.txtNombre.Text = txtNombre.Text;
                            clientes.txtApellido.Text = txtApellido.Text;
                            clientes.txtTelefono.Text = txtTelefono.Text;
                            clientes.ShowDialog();
                            this.Close();
                        }
                    }

                    actualizarTablaPedidos();
                    //Limpiamos los campos
                    btnLimpiar_Click(this, null);
                }

            }
        }

        //Actualizar tabla pedidos
        private void actualizarTablaPedidos()
        {
            //Limpiamos la grilla
            tablaPedidos.Rows.Clear();
            tablaPedidos.Refresh();

            // Leemos todos los datos de la tabla clientes
            OleDbCommand cmd = new OleDbCommand("select * from Pedidos", con);
            OleDbDataReader r = cmd.ExecuteReader();

            if (r.HasRows) //Si tenemos una o mas filas
            {
                while (r.Read()) // Recorremos todas las filas
                {
                    Pedidos c = new Pedidos();
                    c.Id = r.GetInt32(0);
                    c.NombreCliente = r.GetString(1);
                    c.ApellidoCliente = r.GetString(2);
                    c.Telefono = r.GetString(3);
                    c.Dni = r.GetInt32(4);
                    c.Descripcion = r.GetString(5);
                    c.Total = r.GetDouble(6);
                    c.Terminado = r.GetBoolean(7);
                    c.FechaPedido = r.GetDateTime(8);
                    c.FechaEntrega = r.GetDateTime(9);

                    pedidos.Add(c);
                }

                //Mostramos los datos en la grilla
                for (int i = 0; i < pedidos.Count(); i++)
                {
                    tablaPedidos.Rows.Add
                       (pedidos[i].Id,
                        pedidos[i].NombreCliente,
                        pedidos[i].ApellidoCliente,
                        pedidos[i].Telefono,
                        pedidos[i].Dni,
                        pedidos[i].Descripcion,
                        pedidos[i].Total,
                        pedidos[i].Terminado,
                        pedidos[i].FechaPedido.ToString("dd/MM/yyyy"),
                        pedidos[i].FechaEntrega.ToString("dd/MM/yyyy"));
                }

                pedidos.Clear();
            }
            else
            {
                inicializarTablaPedidos();
            }
            r.Close();
        }

        private void tablaPedidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNombre.Text = tablaPedidos.CurrentRow.Cells[1].Value.ToString();
            txtApellido.Text = tablaPedidos.CurrentRow.Cells[2].Value.ToString();
            txtTelefono.Text = tablaPedidos.CurrentRow.Cells[3].Value.ToString();
            txtDni.Text = tablaPedidos.CurrentRow.Cells[4].Value.ToString();
            txtDescripcion.Text = tablaPedidos.CurrentRow.Cells[5].Value.ToString();
            txtTotal.Text = tablaPedidos.CurrentRow.Cells[6].Value.ToString();
        }
        
        //Volver al menú
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Close();
        }

        private void tablaPedidos_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 7)
            {
                tablaPedidos.ReadOnly = false;
                //obtengo el valor del bool
                bool terminado = Convert.ToBoolean(this.tablaPedidos[e.ColumnIndex, e.RowIndex].Value.ToString());
                terminado = !terminado;
                int id = Convert.ToInt32(tablaPedidos.CurrentRow.Cells[0].Value.ToString());
                
                string strinsert = "Update Pedidos Set Terminado = "+ terminado +" WHERE Id = @id";
               
               OleDbCommand update = new OleDbCommand(strinsert, con);
                //Establecemos los parámetros que se utilizarán en el comando Insert
                update.Parameters.AddWithValue("id", id);
                update.Parameters.AddWithValue("terminado", true );

                try
                {
                    update.ExecuteNonQuery(); //Ejecutamos el comando
                    MessageBox.Show("Actualizado");
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show("Error al insertar los datos: " + ex);
                }
                actualizarTablaPedidos();

            }
        }
    }
}
