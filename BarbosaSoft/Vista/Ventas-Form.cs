using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarbosaSoft
{
    public partial class Ventas_Form : Form
    {
        public Ventas_Form()
        {
            Timer timer1 = new Timer();
            timer1.Enabled = true;      // inicializamos el timer al momento de abrir el formulario
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e) //btn back
        {
            this.Hide();
            Form1 cl = new Form1();
            cl.Show();
        }

        private void Ventas_Form_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lbl_date.Text = DateTime.Now.ToLongDateString();
            lbl_time.Text = DateTime.Now.ToLongTimeString();
        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCantidad.Text = "";
            txtPrecio.Text = "";
            txtBuscar.Text = "";
            txtCodigo.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double total = 0;
            double subtotal;
            foreach (DataGridViewRow row in tablaVentas.Rows)

            {

                //suma = (Convert.ToDouble(row.Cells["Precio"].Value) * (Convert.ToDouble(row.Cells["Cantidad"].Value)));

                // subtotal=tablaVentas.CurrentRow.Cells("SubTotal").Value;
                //total += Convert.ToDouble(row.Cells["SubTotal"].Value);

                double pre = Convert.ToDouble(row.Cells["Precio"].Value);
                double cant = Convert.ToDouble(row.Cells["Cantidad"].Value);
                subtotal = pre * cant;
                total += subtotal;

            }

            txtSubtotal.Text = Convert.ToString(total);
            txtIva.Text = Convert.ToString(total * 0.21);
            txtTotal.Text = Convert.ToString(total * 1.21);

            if (chkDesc.Checked == true)
            {
                txtTotal.Text = Convert.ToString(total - total * 0.1);
            }
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            //agregamos los campos al datagrid
            double cant = Convert.ToDouble(txtCantidad.Text);
            double pre = Convert.ToDouble(txtPrecio.Text);
            double subtotal = pre * cant;
            tablaVentas.Rows.Add(txtCodigo.Text, txtBuscar.Text, txtCantidad.Text, txtPrecio.Text, subtotal);

            double total = 0;
            //  double subtotal;
            foreach (DataGridViewRow row in tablaVentas.Rows)

                /*{
                    double pre = Convert.ToDouble(row.Cells["Precio"].Value);
                    double cant = Convert.ToDouble(row.Cells["Cantidad"].Value);
                    subtotal = pre * cant;
                    
                }*/
                total += subtotal;
            txtSubtotal.Text = Convert.ToString(total);
            txtIva.Text = Convert.ToString(total * 0.21);
            txtTotal.Text = Convert.ToString(total * 1.21);

            if (chkDesc.Checked == true)
            {
                txtTotal.Text = Convert.ToString(total - total * 0.1);
            }
        }

        private void btnLimpiarDt_Click(object sender, EventArgs e)
        {
            tablaVentas.Rows.Clear();       // limpiar el datagrid
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_time.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void btnLimpiarDt_Click_1(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Close();
        }
    }
}
