using BarbosaSoft.Vista;
using System;
using System.Windows.Forms;

namespace BarbosaSoft
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lbl_date.Text = DateTime.Now.ToLongDateString();
            lbl_time.Text = DateTime.Now.ToLongTimeString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_time.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void btn_orderNew_Click(object sender, EventArgs e)  //cambio nuevo Pedido
        {
            this.Hide();
            Pedidos_Form pedidos = new Pedidos_Form();
            pedidos.ShowDialog();
            this.Close();
        }


        private void btn_compras_Click(object sender, EventArgs e)  //btn Compras
        {
            this.Hide();
            frmArticulos articulos = new frmArticulos();
            articulos.ShowDialog();
            this.Close();
        }

        private void btn_sales_Click(object sender, EventArgs e)    //btn Ventas
        {
            this.Hide();
            Ventas_Form ventas = new Ventas_Form();
            ventas.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmClientes clientes = new frmClientes();
            clientes.ShowDialog();
            this.Close();
        }
    }
}
