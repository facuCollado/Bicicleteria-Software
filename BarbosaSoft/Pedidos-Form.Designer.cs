namespace BarbosaSoft
{
    partial class Pedidos_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.title = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_lastname = new System.Windows.Forms.Label();
            this.lbl_tel = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_descrip = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_lastname = new System.Windows.Forms.TextBox();
            this.txt_tel = new System.Windows.Forms.TextBox();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_time = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txt_description = new System.Windows.Forms.RichTextBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.lbl_itemList = new System.Windows.Forms.Label();
            this.btn_accept = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.lbl_total = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold);
            this.title.Location = new System.Drawing.Point(217, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(158, 24);
            this.title.TabIndex = 0;
            this.title.Text = "Nuevo Pedido";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(43, 60);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(44, 13);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.Text = "Nombre";
            // 
            // lbl_lastname
            // 
            this.lbl_lastname.AutoSize = true;
            this.lbl_lastname.Location = new System.Drawing.Point(343, 60);
            this.lbl_lastname.Name = "lbl_lastname";
            this.lbl_lastname.Size = new System.Drawing.Size(44, 13);
            this.lbl_lastname.TabIndex = 2;
            this.lbl_lastname.Text = "Apellido";
            // 
            // lbl_tel
            // 
            this.lbl_tel.AutoSize = true;
            this.lbl_tel.Location = new System.Drawing.Point(43, 114);
            this.lbl_tel.Name = "lbl_tel";
            this.lbl_tel.Size = new System.Drawing.Size(49, 13);
            this.lbl_tel.TabIndex = 3;
            this.lbl_tel.Text = "Telefono";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(343, 114);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(32, 13);
            this.lbl_email.TabIndex = 4;
            this.lbl_email.Text = "Email";
            // 
            // lbl_descrip
            // 
            this.lbl_descrip.AutoSize = true;
            this.lbl_descrip.Location = new System.Drawing.Point(43, 183);
            this.lbl_descrip.Name = "lbl_descrip";
            this.lbl_descrip.Size = new System.Drawing.Size(63, 13);
            this.lbl_descrip.TabIndex = 5;
            this.lbl_descrip.Text = "Descripción";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(107, 60);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(145, 20);
            this.txt_name.TabIndex = 2;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(393, 107);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(145, 20);
            this.txt_email.TabIndex = 5;
            // 
            // txt_lastname
            // 
            this.txt_lastname.Location = new System.Drawing.Point(393, 57);
            this.txt_lastname.Name = "txt_lastname";
            this.txt_lastname.Size = new System.Drawing.Size(145, 20);
            this.txt_lastname.TabIndex = 3;
            // 
            // txt_tel
            // 
            this.txt_tel.Location = new System.Drawing.Point(107, 114);
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.Size = new System.Drawing.Size(145, 20);
            this.txt_tel.TabIndex = 4;
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Location = new System.Drawing.Point(9, 461);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(34, 13);
            this.lbl_date.TabIndex = 10;
            this.lbl_date.Text = "fecha";
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Location = new System.Drawing.Point(564, 461);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(26, 13);
            this.lbl_time.TabIndex = 11;
            this.lbl_time.Text = "time";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txt_description
            // 
            this.txt_description.Location = new System.Drawing.Point(132, 183);
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(406, 101);
            this.txt_description.TabIndex = 6;
            this.txt_description.Text = "";
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_back.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_back.ForeColor = System.Drawing.Color.White;
            this.btn_back.Location = new System.Drawing.Point(12, 9);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(103, 33);
            this.btn_back.TabIndex = 1;
            this.btn_back.Text = "Volver";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // lbl_itemList
            // 
            this.lbl_itemList.AutoSize = true;
            this.lbl_itemList.Location = new System.Drawing.Point(52, 321);
            this.lbl_itemList.Name = "lbl_itemList";
            this.lbl_itemList.Size = new System.Drawing.Size(56, 13);
            this.lbl_itemList.TabIndex = 12;
            this.lbl_itemList.Text = "Lista items";
            // 
            // btn_accept
            // 
            this.btn_accept.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_accept.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_accept.ForeColor = System.Drawing.Color.White;
            this.btn_accept.Location = new System.Drawing.Point(272, 407);
            this.btn_accept.Name = "btn_accept";
            this.btn_accept.Size = new System.Drawing.Size(103, 33);
            this.btn_accept.TabIndex = 13;
            this.btn_accept.Text = "Aceptar";
            this.btn_accept.UseVisualStyleBackColor = false;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_cancelar.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_cancelar.Location = new System.Drawing.Point(527, 407);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(73, 33);
            this.btn_cancelar.TabIndex = 14;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(132, 309);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(120, 56);
            this.richTextBox2.TabIndex = 15;
            this.richTextBox2.Text = "aca la idea sería agregar por ej  cambio de cadena --> 100$";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Location = new System.Drawing.Point(343, 321);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(31, 13);
            this.lbl_total.TabIndex = 16;
            this.lbl_total.Text = "Total";
            // 
            // txt_total
            // 
            this.txt_total.Location = new System.Drawing.Point(393, 318);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(145, 20);
            this.txt_total.TabIndex = 17;
            // 
            // Pedidos_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(642, 483);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_accept);
            this.Controls.Add(this.lbl_itemList);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.txt_description);
            this.Controls.Add(this.lbl_time);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.txt_tel);
            this.Controls.Add(this.txt_lastname);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lbl_descrip);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_tel);
            this.Controls.Add(this.lbl_lastname);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.title);
            this.Name = "Pedidos_Form";
            this.Text = "Nuevo Pedido";
            this.Load += new System.EventHandler(this.Pedidos_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_lastname;
        private System.Windows.Forms.Label lbl_tel;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_descrip;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_lastname;
        private System.Windows.Forms.TextBox txt_tel;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RichTextBox txt_description;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label lbl_itemList;
        private System.Windows.Forms.Button btn_accept;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.TextBox txt_total;
    }
}