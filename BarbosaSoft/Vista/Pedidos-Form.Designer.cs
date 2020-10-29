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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_time = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtDescripcion = new System.Windows.Forms.RichTextBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.lbl_itemList = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.lbl_total = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.lbl_name.Location = new System.Drawing.Point(0, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(100, 23);
            this.lbl_name.TabIndex = 18;
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
            this.lbl_email.Location = new System.Drawing.Point(343, 117);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(23, 13);
            this.lbl_email.TabIndex = 4;
            this.lbl_email.Text = "Dni";
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
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(107, 57);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(145, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(403, 114);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(145, 20);
            this.txtDni.TabIndex = 5;
            this.txtDni.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDni_KeyDown);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(403, 57);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(145, 20);
            this.txtApellido.TabIndex = 3;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(107, 114);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(145, 20);
            this.txtTelefono.TabIndex = 4;
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Location = new System.Drawing.Point(12, 9);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(34, 13);
            this.lbl_date.TabIndex = 10;
            this.lbl_date.Text = "fecha";
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Location = new System.Drawing.Point(574, 9);
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
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(112, 180);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(426, 101);
            this.txtDescripcion.TabIndex = 6;
            this.txtDescripcion.Text = "";
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_back.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_back.ForeColor = System.Drawing.Color.White;
            this.btn_back.Location = new System.Drawing.Point(561, 438);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(73, 33);
            this.btn_back.TabIndex = 1;
            this.btn_back.Text = "Volver";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // lbl_itemList
            // 
            this.lbl_itemList.AutoSize = true;
            this.lbl_itemList.Location = new System.Drawing.Point(43, 321);
            this.lbl_itemList.Name = "lbl_itemList";
            this.lbl_itemList.Size = new System.Drawing.Size(56, 13);
            this.lbl_itemList.TabIndex = 12;
            this.lbl_itemList.Text = "Lista items";
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnNuevo.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Location = new System.Drawing.Point(244, 422);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(122, 49);
            this.btnNuevo.TabIndex = 13;
            this.btnNuevo.Text = "Nuevo ";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnLimpiar.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(482, 438);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(73, 33);
            this.btnLimpiar.TabIndex = 14;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(112, 314);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(140, 56);
            this.richTextBox2.TabIndex = 15;
            this.richTextBox2.Text = "aca la idea sería agregar por ej  cambio de cadena --> 100$";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Location = new System.Drawing.Point(343, 318);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(31, 13);
            this.lbl_total.TabIndex = 16;
            this.lbl_total.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(393, 314);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(145, 20);
            this.txtTotal.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Nombre";
            // 
            // Pedidos_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(642, 483);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.lbl_itemList);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lbl_time);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.txtNombre);
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
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RichTextBox txtDescripcion;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label lbl_itemList;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label1;
    }
}