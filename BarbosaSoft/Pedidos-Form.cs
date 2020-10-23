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
    public partial class Pedidos_Form : Form
    {
        //hago la conexion con la db
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Usuario\Documents\Dev\Desktop\WindowsForm\BicicleteriaDB.accdb");

        public Pedidos_Form()
        {
            InitializeComponent();
        }

        private void Pedidos_Form_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lbl_date.Text = DateTime.Now.ToLongDateString();
            lbl_time.Text = DateTime.Now.ToLongTimeString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_time.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        } //timer de la hora

        private void btn_back_Click(object sender, EventArgs e)  //vuelvo a menú
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Close();
        }

        private void btn_accept_Click(object sender, EventArgs e)
        {

            con.Open();
            OleDbCommand getID = con.CreateCommand(); //creo la consulta para ID
            OleDbCommand getName = con.CreateCommand(); //creo la consulta para Nombre
            OleDbCommand getLastName= con.CreateCommand(); //creo la consulta Apellido
            OleDbCommand query1 = con.CreateCommand(); //creo la consulta sql

            query1.CommandText = "INSERT INTO Clientes (Nombre, Apellido, Telefono, Email) Values(@Nombre, @Apellido," +
                                                          "@Telefono, @Email)";
            query1.Parameters.AddWithValue("@Nombre", txt_name.Text);
            query1.Parameters.AddWithValue("@Apellido", txt_lastname.Text);
            query1.Parameters.AddWithValue("@Telefono", txt_tel.Text);
            query1.Parameters.AddWithValue("@Email", txt_email.Text);

            query1.ExecuteNonQuery();

            getID.CommandText = "SELECT TOP 1 id FROM Clientes ORDER BY Id DESC";
            getName.CommandText = "SELECT TOP 1 Nombre FROM Clientes ORDER BY Id DESC";
            getLastName.CommandText = "SELECT TOP 1 Apellido FROM Clientes ORDER BY Id DESC";

       
            int ID_Cliente = (Int32)getID.ExecuteScalar();
            String Nombre_Cliente = (String)getName.ExecuteScalar();
            String Apellido_Cliente = (String)getLastName.ExecuteScalar();

            OleDbCommand query2 = con.CreateCommand();

            query2.CommandText = "INSERT INTO Pedidos(Descripcion, Total, Cliente_ID, Terminado, Nombre_Cliente, Apellido_Cliente)" +
                " Values(@Descripcion, @Total, @Cliente_ID, @Terminado, @Nombre_Cliente, @Apellido_Cliente)";
            query2.Parameters.AddWithValue("@Descripcion", txt_description.Text);
            query2.Parameters.AddWithValue("@Total", txt_total.Text);
            query2.Parameters.AddWithValue("@Cliente_ID", ID_Cliente);
            query2.Parameters.AddWithValue("@Terminado", false);
            query2.Parameters.AddWithValue("@Nombre_Cliente", Nombre_Cliente);
            query2.Parameters.AddWithValue("@Apellido", Apellido_Cliente);
            query2.ExecuteNonQuery();
          
            con.Close();
            MessageBox.Show("Se guardó");

        }
    }
}
