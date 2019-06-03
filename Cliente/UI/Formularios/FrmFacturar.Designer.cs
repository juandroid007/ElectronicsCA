namespace Cliente.UI.Formularios
{
    partial class FrmFacturar
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
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtGridProductos = new System.Windows.Forms.DataGridView();
            this.btnFacturar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(12, 25);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(149, 20);
            this.txtCedula.TabIndex = 0;
            this.txtCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCedula_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cédula del cliente:";
            // 
            // dtGridProductos
            // 
            this.dtGridProductos.AllowUserToAddRows = false;
            this.dtGridProductos.AllowUserToDeleteRows = false;
            this.dtGridProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtGridProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtGridProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridProductos.Location = new System.Drawing.Point(10, 51);
            this.dtGridProductos.Name = "dtGridProductos";
            this.dtGridProductos.ReadOnly = true;
            this.dtGridProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGridProductos.Size = new System.Drawing.Size(582, 275);
            this.dtGridProductos.TabIndex = 5;
            // 
            // btnFacturar
            // 
            this.btnFacturar.Location = new System.Drawing.Point(482, 12);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(110, 30);
            this.btnFacturar.TabIndex = 6;
            this.btnFacturar.Text = "Facturar";
            this.btnFacturar.UseVisualStyleBackColor = true;
            this.btnFacturar.Click += new System.EventHandler(this.BtnFacturar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(10, 332);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(110, 30);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Añadir producto";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(126, 332);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(110, 30);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar producto";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(453, 348);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTotal.Size = new System.Drawing.Size(135, 19);
            this.txtTotal.TabIndex = 9;
            this.txtTotal.Text = "0 Bs";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(558, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Total:";
            // 
            // FrmFacturar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 369);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnFacturar);
            this.Controls.Add(this.dtGridProductos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCedula);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FrmFacturar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Factura nueva";
            ((System.ComponentModel.ISupportInitialize)(this.dtGridProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtGridProductos;
        private System.Windows.Forms.Button btnFacturar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label4;
    }
}