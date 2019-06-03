namespace Cliente.UI.Formularios
{
    partial class FrmAgregarProductoFactura
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dtGridProductos = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnDescartar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id de producto:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(12, 25);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(146, 20);
            this.txtId.TabIndex = 1;
            this.txtId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCantidad_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Precio por unidad:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(12, 64);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(118, 20);
            this.txtPrecio.TabIndex = 1;
            this.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCantidad_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(136, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Bs.";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(681, 9);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(65, 27);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // dtGridProductos
            // 
            this.dtGridProductos.AllowUserToAddRows = false;
            this.dtGridProductos.AllowUserToDeleteRows = false;
            this.dtGridProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtGridProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridProductos.Location = new System.Drawing.Point(164, 42);
            this.dtGridProductos.Name = "dtGridProductos";
            this.dtGridProductos.ReadOnly = true;
            this.dtGridProductos.Size = new System.Drawing.Size(582, 275);
            this.dtGridProductos.TabIndex = 4;
            this.dtGridProductos.DoubleClick += new System.EventHandler(this.DtGridProductos_DoubleClick);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(529, 13);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(146, 20);
            this.txtBuscar.TabIndex = 1;
            // 
            // btnDescartar
            // 
            this.btnDescartar.Location = new System.Drawing.Point(316, 9);
            this.btnDescartar.Name = "btnDescartar";
            this.btnDescartar.Size = new System.Drawing.Size(65, 27);
            this.btnDescartar.TabIndex = 3;
            this.btnDescartar.Text = "Descartar";
            this.btnDescartar.UseVisualStyleBackColor = true;
            this.btnDescartar.Click += new System.EventHandler(this.BtnDescartar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Cantidad:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(12, 103);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(85, 20);
            this.txtCantidad.TabIndex = 1;
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCantidad_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(101, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Unidad/es";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(164, 9);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(146, 27);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar producto";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // FrmAgregarProductoFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 329);
            this.Controls.Add(this.dtGridProductos);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnDescartar);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FrmAgregarProductoFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Añadir producto a factura";
            ((System.ComponentModel.ISupportInitialize)(this.dtGridProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dtGridProductos;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnDescartar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAgregar;
    }
}