namespace BarbosaSoft
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.title = new System.Windows.Forms.Label();
            this.btn_orderNew = new System.Windows.Forms.Button();
            this.btn_orderList = new System.Windows.Forms.Button();
            this.btnArticulos = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_time = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(211, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(182, 32);
            this.title.TabIndex = 0;
            this.title.Text = "BarbosaSoft";
            // 
            // btn_orderNew
            // 
            this.btn_orderNew.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_orderNew.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_orderNew.ForeColor = System.Drawing.Color.White;
            this.btn_orderNew.Location = new System.Drawing.Point(217, 78);
            this.btn_orderNew.Name = "btn_orderNew";
            this.btn_orderNew.Size = new System.Drawing.Size(166, 54);
            this.btn_orderNew.TabIndex = 1;
            this.btn_orderNew.Text = "Nuevo Pedido";
            this.btn_orderNew.UseVisualStyleBackColor = false;
            this.btn_orderNew.Click += new System.EventHandler(this.btn_orderNew_Click);
            // 
            // btn_orderList
            // 
            this.btn_orderList.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_orderList.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_orderList.ForeColor = System.Drawing.Color.White;
            this.btn_orderList.Location = new System.Drawing.Point(217, 138);
            this.btn_orderList.Name = "btn_orderList";
            this.btn_orderList.Size = new System.Drawing.Size(166, 54);
            this.btn_orderList.TabIndex = 2;
            this.btn_orderList.Text = "Pedidos";
            this.btn_orderList.UseVisualStyleBackColor = false;
            this.btn_orderList.Click += new System.EventHandler(this.btn_orderList_Click);
            // 
            // btnArticulos
            // 
            this.btnArticulos.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnArticulos.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnArticulos.ForeColor = System.Drawing.Color.White;
            this.btnArticulos.Location = new System.Drawing.Point(217, 198);
            this.btnArticulos.Name = "btnArticulos";
            this.btnArticulos.Size = new System.Drawing.Size(166, 54);
            this.btnArticulos.TabIndex = 3;
            this.btnArticulos.Text = "Articulos";
            this.btnArticulos.UseVisualStyleBackColor = false;
            this.btnArticulos.Click += new System.EventHandler(this.btn_compras_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnVentas.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnVentas.ForeColor = System.Drawing.Color.White;
            this.btnVentas.Location = new System.Drawing.Point(217, 318);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(166, 54);
            this.btnVentas.TabIndex = 4;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.UseVisualStyleBackColor = false;
            this.btnVentas.Click += new System.EventHandler(this.btn_sales_Click);
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Location = new System.Drawing.Point(12, 9);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(28, 13);
            this.lbl_date.TabIndex = 5;
            this.lbl_date.Text = "date";
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Location = new System.Drawing.Point(529, 9);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(26, 13);
            this.lbl_time.TabIndex = 6;
            this.lbl_time.Text = "time";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnClientes.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnClientes.ForeColor = System.Drawing.Color.White;
            this.btnClientes.Location = new System.Drawing.Point(217, 258);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(166, 54);
            this.btnClientes.TabIndex = 7;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSalir.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(483, 407);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(99, 31);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(594, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.lbl_time);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.btnVentas);
            this.Controls.Add(this.btnArticulos);
            this.Controls.Add(this.btn_orderList);
            this.Controls.Add(this.btn_orderNew);
            this.Controls.Add(this.title);
            this.Name = "Form1";
            this.Text = "BarbosaSoft";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button btn_orderNew;
        private System.Windows.Forms.Button btn_orderList;
        private System.Windows.Forms.Button btnArticulos;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnSalir;
    }
}

