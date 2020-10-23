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
    public partial class ListaPedidos_Form : Form
    {
        public ListaPedidos_Form()
        {
            InitializeComponent();
        }

        private void ListaPedidos_Form_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bicicleteriaDBDataSet.Clientes' Puede moverla o quitarla según sea necesario.
            this.pedidosTableAdapter.Fill(this.bicicleteriaDBDataSet.Pedidos);
            timer1.Start();
            lbl_date.Text = DateTime.Now.ToLongDateString();
            lbl_time.Text = DateTime.Now.ToLongTimeString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_time.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Close();
        }

        private void pedidosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pedidosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bicicleteriaDBDataSet);

        }
    }
}
