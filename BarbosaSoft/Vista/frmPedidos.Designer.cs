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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pedidos_Form));
            this.title = new System.Windows.Forms.Label();
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
            this.btnNuevo = new System.Windows.Forms.Button();
            this.lbl_total = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pedidosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bicicleteriaDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bicicleteriaDBDataSet = new BarbosaSoft.BicicleteriaDBDataSet();
            this.pedidosTableAdapter = new BarbosaSoft.BicicleteriaDBDataSetTableAdapters.PedidosTableAdapter();
            this.tablaPedidos = new System.Windows.Forms.DataGridView();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pedidosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bicicleteriaDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bicicleteriaDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold);
            this.title.Location = new System.Drawing.Point(366, 10);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(182, 24);
            this.title.TabIndex = 0;
            this.title.Text = "NUEVO PEDIDO";
            // 
            // lbl_lastname
            // 
            this.lbl_lastname.AutoSize = true;
            this.lbl_lastname.Location = new System.Drawing.Point(520, 246);
            this.lbl_lastname.Name = "lbl_lastname";
            this.lbl_lastname.Size = new System.Drawing.Size(44, 13);
            this.lbl_lastname.TabIndex = 2;
            this.lbl_lastname.Text = "Apellido";
            // 
            // lbl_tel
            // 
            this.lbl_tel.AutoSize = true;
            this.lbl_tel.Location = new System.Drawing.Point(511, 272);
            this.lbl_tel.Name = "lbl_tel";
            this.lbl_tel.Size = new System.Drawing.Size(49, 13);
            this.lbl_tel.TabIndex = 3;
            this.lbl_tel.Text = "Telefono";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(141, 246);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(23, 13);
            this.lbl_email.TabIndex = 4;
            this.lbl_email.Text = "Dni";
            // 
            // lbl_descrip
            // 
            this.lbl_descrip.AutoSize = true;
            this.lbl_descrip.Location = new System.Drawing.Point(132, 338);
            this.lbl_descrip.Name = "lbl_descrip";
            this.lbl_descrip.Size = new System.Drawing.Size(63, 13);
            this.lbl_descrip.TabIndex = 5;
            this.lbl_descrip.Text = "Descripción";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(201, 272);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(145, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(201, 243);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(95, 20);
            this.txtDni.TabIndex = 5;
            this.txtDni.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDni_KeyDown);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(580, 243);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(145, 20);
            this.txtApellido.TabIndex = 3;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(580, 272);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(145, 20);
            this.txtTelefono.TabIndex = 4;
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.Location = new System.Drawing.Point(9, 10);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(39, 13);
            this.lbl_date.TabIndex = 10;
            this.lbl_date.Text = "fecha";
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time.Location = new System.Drawing.Point(844, 10);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(30, 13);
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
            this.txtDescripcion.Location = new System.Drawing.Point(201, 298);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(524, 81);
            this.txtDescripcion.TabIndex = 6;
            this.txtDescripcion.Text = "";
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.Maroon;
            this.btnNuevo.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnNuevo.ForeColor = System.Drawing.Color.LightGray;
            this.btnNuevo.Location = new System.Drawing.Point(393, 426);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(117, 41);
            this.btnNuevo.TabIndex = 13;
            this.btnNuevo.Text = "Nuevo ";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Location = new System.Drawing.Point(764, 409);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(52, 13);
            this.lbl_total.TabIndex = 16;
            this.lbl_total.Text = "Total     $";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(814, 405);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(89, 20);
            this.txtTotal.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Nombre";
            // 
            // pedidosBindingSource
            // 
            this.pedidosBindingSource.DataMember = "Pedidos";
            this.pedidosBindingSource.DataSource = this.bicicleteriaDBDataSetBindingSource;
            // 
            // bicicleteriaDBDataSetBindingSource
            // 
            this.bicicleteriaDBDataSetBindingSource.DataSource = this.bicicleteriaDBDataSet;
            this.bicicleteriaDBDataSetBindingSource.Position = 0;
            // 
            // bicicleteriaDBDataSet
            // 
            this.bicicleteriaDBDataSet.DataSetName = "BicicleteriaDBDataSet";
            this.bicicleteriaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pedidosTableAdapter
            // 
            this.pedidosTableAdapter.ClearBeforeFill = true;
            // 
            // tablaPedidos
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tablaPedidos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaPedidos.Location = new System.Drawing.Point(12, 37);
            this.tablaPedidos.Name = "tablaPedidos";
            this.tablaPedidos.Size = new System.Drawing.Size(891, 183);
            this.tablaPedidos.TabIndex = 56;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Maroon;
            this.btnLimpiar.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnLimpiar.ForeColor = System.Drawing.Color.LightGray;
            this.btnLimpiar.Location = new System.Drawing.Point(822, 229);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(81, 30);
            this.btnLimpiar.TabIndex = 62;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Maroon;
            this.btnVolver.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnVolver.ForeColor = System.Drawing.Color.LightGray;
            this.btnVolver.Location = new System.Drawing.Point(831, 441);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(72, 26);
            this.btnVolver.TabIndex = 63;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // Pedidos_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(916, 478);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.tablaPedidos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.btnNuevo);
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
            this.Controls.Add(this.title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pedidos_Form";
            this.Text = "Nuevo Pedido";
            this.Load += new System.EventHandler(this.Pedidos_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pedidosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bicicleteriaDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bicicleteriaDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
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
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bicicleteriaDBDataSetBindingSource;
        private BicicleteriaDBDataSet bicicleteriaDBDataSet;
        private System.Windows.Forms.BindingSource pedidosBindingSource;
        private BicicleteriaDBDataSetTableAdapters.PedidosTableAdapter pedidosTableAdapter;
        private System.Windows.Forms.DataGridView tablaPedidos;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnVolver;
    }
}