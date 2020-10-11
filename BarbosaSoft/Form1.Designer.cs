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
            this.btn_compras = new System.Windows.Forms.Button();
            this.btn_sales = new System.Windows.Forms.Button();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_time = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(226, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(140, 24);
            this.title.TabIndex = 0;
            this.title.Text = "BarbosaSoft";
            // 
            // btn_orderNew
            // 
            this.btn_orderNew.BackColor = System.Drawing.Color.MediumBlue;
            this.btn_orderNew.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_orderNew.ForeColor = System.Drawing.Color.White;
            this.btn_orderNew.Location = new System.Drawing.Point(217, 59);
            this.btn_orderNew.Name = "btn_orderNew";
            this.btn_orderNew.Size = new System.Drawing.Size(166, 54);
            this.btn_orderNew.TabIndex = 1;
            this.btn_orderNew.Text = "Nuevo Pedido";
            this.btn_orderNew.UseVisualStyleBackColor = false;
            this.btn_orderNew.Click += new System.EventHandler(this.btn_orderNew_Click);
            // 
            // btn_orderList
            // 
            this.btn_orderList.BackColor = System.Drawing.Color.MediumBlue;
            this.btn_orderList.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_orderList.ForeColor = System.Drawing.Color.White;
            this.btn_orderList.Location = new System.Drawing.Point(217, 144);
            this.btn_orderList.Name = "btn_orderList";
            this.btn_orderList.Size = new System.Drawing.Size(166, 54);
            this.btn_orderList.TabIndex = 2;
            this.btn_orderList.Text = "Pedidos";
            this.btn_orderList.UseVisualStyleBackColor = false;
            this.btn_orderList.Click += new System.EventHandler(this.btn_orderList_Click);
            // 
            // btn_compras
            // 
            this.btn_compras.BackColor = System.Drawing.Color.MediumBlue;
            this.btn_compras.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_compras.ForeColor = System.Drawing.Color.White;
            this.btn_compras.Location = new System.Drawing.Point(217, 236);
            this.btn_compras.Name = "btn_compras";
            this.btn_compras.Size = new System.Drawing.Size(166, 54);
            this.btn_compras.TabIndex = 3;
            this.btn_compras.Text = "Compras";
            this.btn_compras.UseVisualStyleBackColor = false;
            this.btn_compras.Click += new System.EventHandler(this.btn_compras_Click);
            // 
            // btn_sales
            // 
            this.btn_sales.BackColor = System.Drawing.Color.MediumBlue;
            this.btn_sales.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_sales.ForeColor = System.Drawing.Color.White;
            this.btn_sales.Location = new System.Drawing.Point(217, 321);
            this.btn_sales.Name = "btn_sales";
            this.btn_sales.Size = new System.Drawing.Size(166, 54);
            this.btn_sales.TabIndex = 4;
            this.btn_sales.Text = "Ventas";
            this.btn_sales.UseVisualStyleBackColor = false;
            this.btn_sales.Click += new System.EventHandler(this.btn_sales_Click);
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Location = new System.Drawing.Point(12, 425);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(28, 13);
            this.lbl_date.TabIndex = 5;
            this.lbl_date.Text = "date";
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Location = new System.Drawing.Point(531, 425);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(594, 450);
            this.Controls.Add(this.lbl_time);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.btn_sales);
            this.Controls.Add(this.btn_compras);
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
        private System.Windows.Forms.Button btn_compras;
        private System.Windows.Forms.Button btn_sales;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Timer timer1;
    }
}

