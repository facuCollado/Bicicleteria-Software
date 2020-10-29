using BarbosaSoft.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarbosaSoft
{
    public partial class Pedidos_Form : Form
    {
        //iniciamos la conexion
        OleDbConnection con = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = D:\\VS Projects\\Bicicleteria-Software\\BarbosaSoft\\BicicleteriaDB.accdb");
        
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
                //MessageBox.Show(cn.State.ToString());
                estaConectado = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo conectar: \n" + ex);
                estaConectado = false;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_time.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        //Volver al menú
        private void btn_back_Click(object sender, EventArgs e)  
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Close();
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


                    //Escribimos el comando de inserción
                    //El ID del cliente es autonumérico por lo cual no necesitamos establecerlo

                    string strinsert = "INSERT into Pedidos (NombreCliente, ApellidoCliente, Telefono, Dni, Descripcion, Total) Values(@nom, @ape, @tel, @dni, @desc, @total)";
                    OleDbCommand cmd = new OleDbCommand(strinsert, con);
                    //Establecemos los parámetros que se utilizarán en el comando Insert

                    cmd.Parameters.AddWithValue("nom", nombre);
                    cmd.Parameters.AddWithValue("ape", apellido);
                    cmd.Parameters.AddWithValue("tel", tel);
                    cmd.Parameters.AddWithValue("dni", dni);
                    cmd.Parameters.AddWithValue("desc", desc);
                    cmd.Parameters.AddWithValue("total", total);
                    

                    try
                    {
                        cmd.ExecuteNonQuery(); //Ejecutamos el comando
                        MessageBox.Show("Nuevo pedido agregado");
                    }
                    catch (OleDbException ex)
                    {
                        MessageBox.Show("Error al insertar los datos: " + ex);
                    }

                   //Limpiamos los campos
                    btnLimpiar_Click(this, null);
                }

            }
        }
    }
}
