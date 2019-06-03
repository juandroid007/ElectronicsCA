namespace Cliente.UI.Formularios
{
    partial class FrmProductos
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dtGridProductos = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.cmbProveedor = new System.Windows.Forms.ComboBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.btnDescartar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "* Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(12, 25);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(146, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Descripción:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(12, 64);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(146, 20);
            this.txtDescripcion.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "* Proveedor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "* Tipo de producto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "* Precio:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(12, 103);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(118, 20);
            this.txtPrecio.TabIndex = 1;
            this.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_Cantidad_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(136, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Bs.";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Location = new System.Drawing.Point(235, 9);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(65, 27);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(164, 9);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(65, 27);
            this.btnAlterar.TabIndex = 3;
            this.btnAlterar.Text = "Añadir";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
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
            // cmbProveedor
            // 
            this.cmbProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProveedor.FormattingEnabled = true;
            this.cmbProveedor.Location = new System.Drawing.Point(9, 181);
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.Size = new System.Drawing.Size(146, 21);
            this.cmbProveedor.TabIndex = 5;
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(9, 221);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(146, 21);
            this.cmbTipo.TabIndex = 5;
            // 
            // btnDescartar
            // 
            this.btnDescartar.Location = new System.Drawing.Point(306, 9);
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
            this.label7.Location = new System.Drawing.Point(12, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "* Cantitad:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(12, 142);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(85, 20);
            this.txtCantidad.TabIndex = 1;
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_Cantidad_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(101, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Unidad/es";
            // 
            // FrmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 329);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.cmbProveedor);
            this.Controls.Add(this.dtGridProductos);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnDescartar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FrmProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos";
            ((System.ComponentModel.ISupportInitialize)(this.dtGridProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dtGridProductos;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ComboBox cmbProveedor;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Button btnDescartar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label8;
    }
}