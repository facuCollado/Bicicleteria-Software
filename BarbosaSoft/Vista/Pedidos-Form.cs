﻿using System;
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
    public partial class Pedidos_Form : Form
    {
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
        }

        private void btn_back_Click(object sender, EventArgs e)  //vuelvo a menú
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Close();
        }

        private void lbl_lastname_Click(object sender, EventArgs e)
        {

        }
    }
}