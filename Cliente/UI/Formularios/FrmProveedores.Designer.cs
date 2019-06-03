namespace Cliente.UI.Formularios
{
    partial class FrmProveedores
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
            this.txtRif = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDirFiscal = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dtGridProveedores = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnDescartar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridProveedores)).BeginInit();
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
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Rif:";
            // 
            // txtRif
            // 
            this.txtRif.Location = new System.Drawing.Point(12, 64);
            this.txtRif.Name = "txtRif";
            this.txtRif.Size = new System.Drawing.Size(146, 20);
            this.txtRif.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Dirección fiscal:";
            // 
            // txtDirFiscal
            // 
            this.txtDirFiscal.Location = new System.Drawing.Point(12, 103);
            this.txtDirFiscal.Name = "txtDirFiscal";
            this.txtDirFiscal.Size = new System.Drawing.Size(146, 20);
            this.txtDirFiscal.TabIndex = 1;
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
            this.btnBuscar.Location = new System.Drawing.Point(529, 9);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(65, 27);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // dtGridProveedores
            // 
            this.dtGridProveedores.AllowUserToAddRows = false;
            this.dtGridProveedores.AllowUserToDeleteRows = false;
            this.dtGridProveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtGridProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridProveedores.Location = new System.Drawing.Point(164, 42);
            this.dtGridProveedores.Name = "dtGridProveedores";
            this.dtGridProveedores.ReadOnly = true;
            this.dtGridProveedores.Size = new System.Drawing.Size(430, 275);
            this.dtGridProveedores.TabIndex = 4;
            this.dtGridProveedores.DoubleClick += new System.EventHandler(this.DtGridProveedores_DoubleClick);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(377, 13);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(146, 20);
            this.txtBuscar.TabIndex = 1;
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
            // FrmProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 329);
            this.Controls.Add(this.dtGridProveedores);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnDescartar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtDirFiscal);
            this.Controls.Add(this.txtRif);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FrmProveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proveedores";
            ((System.ComponentModel.ISupportInitialize)(this.dtGridProveedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRif;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDirFiscal;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dtGridProveedores;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnDescartar;
    }
}