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
    public partial class Compras_Form : Form
    {
        public Compras_Form()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fr = new Form1();
            fr.Show();
        }

        private void Compras_Form_Load(object sender, EventArgs e)
        {
            
        }

        private void lbl_title_Click(object sender, EventArgs e)
        {

        }
    }
}
