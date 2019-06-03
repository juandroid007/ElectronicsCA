namespace Cliente.UI.Formularios
{
    partial class FrmTiposProductos
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
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dtGridTiposProductos = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnDescartar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridTiposProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 333);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "* Descripción:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(88, 330);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(146, 20);
            this.txtDescripcion.TabIndex = 1;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Location = new System.Drawing.Point(311, 326);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(65, 27);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(240, 326);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(65, 27);
            this.btnAlterar.TabIndex = 3;
            this.btnAlterar.Text = "Añadir";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(311, 12);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(65, 27);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // dtGridTiposProductos
            // 
            this.dtGridTiposProductos.AllowUserToAddRows = false;
            this.dtGridTiposProductos.AllowUserToDeleteRows = false;
            this.dtGridTiposProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtGridTiposProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridTiposProductos.Location = new System.Drawing.Point(12, 45);
            this.dtGridTiposProductos.Name = "dtGridTiposProductos";
            this.dtGridTiposProductos.ReadOnly = true;
            this.dtGridTiposProductos.Size = new System.Drawing.Size(364, 275);
            this.dtGridTiposProductos.TabIndex = 4;
            this.dtGridTiposProductos.DoubleClick += new System.EventHandler(this.DtGridTiposProductos_DoubleClick);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(159, 16);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(146, 20);
            this.txtBuscar.TabIndex = 1;
            // 
            // btnDescartar
            // 
            this.btnDescartar.Location = new System.Drawing.Point(12, 12);
            this.btnDescartar.Name = "btnDescartar";
            this.btnDescartar.Size = new System.Drawing.Size(65, 27);
            this.btnDescartar.TabIndex = 3;
            this.btnDescartar.Text = "Descartar";
            this.btnDescartar.UseVisualStyleBackColor = true;
            this.btnDescartar.Click += new System.EventHandler(this.BtnDescartar_Click);
            // 
            // FrmTiposProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 362);
            this.Controls.Add(this.dtGridTiposProductos);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnDescartar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FrmTiposProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proveedores";
            ((System.ComponentModel.ISupportInitialize)(this.dtGridTiposProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dtGridTiposProductos;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnDescartar;
    }
}