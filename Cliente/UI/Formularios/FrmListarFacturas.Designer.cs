namespace Cliente.UI.Formularios
{
    partial class FrmListarFacturas
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
            this.dtGridFacturas = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnDescartar = new System.Windows.Forms.Button();
            this.btnBuscarCedula = new System.Windows.Forms.Button();
            this.btnBuscarId = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridFacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGridFacturas
            // 
            this.dtGridFacturas.AllowUserToAddRows = false;
            this.dtGridFacturas.AllowUserToDeleteRows = false;
            this.dtGridFacturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtGridFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridFacturas.Location = new System.Drawing.Point(12, 45);
            this.dtGridFacturas.Name = "dtGridFacturas";
            this.dtGridFacturas.ReadOnly = true;
            this.dtGridFacturas.Size = new System.Drawing.Size(441, 305);
            this.dtGridFacturas.TabIndex = 4;
            this.dtGridFacturas.DoubleClick += new System.EventHandler(this.DtGridFacturas_DoubleClick);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(83, 16);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(148, 20);
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
            // btnBuscarCedula
            // 
            this.btnBuscarCedula.Location = new System.Drawing.Point(348, 12);
            this.btnBuscarCedula.Name = "btnBuscarCedula";
            this.btnBuscarCedula.Size = new System.Drawing.Size(105, 27);
            this.btnBuscarCedula.TabIndex = 3;
            this.btnBuscarCedula.Text = "Buscar por cédula";
            this.btnBuscarCedula.UseVisualStyleBackColor = true;
            this.btnBuscarCedula.Click += new System.EventHandler(this.BtnBuscarCedula_Click);
            // 
            // btnBuscarId
            // 
            this.btnBuscarId.Location = new System.Drawing.Point(237, 12);
            this.btnBuscarId.Name = "btnBuscarId";
            this.btnBuscarId.Size = new System.Drawing.Size(105, 27);
            this.btnBuscarId.TabIndex = 3;
            this.btnBuscarId.Text = "Buscar por id";
            this.btnBuscarId.UseVisualStyleBackColor = true;
            this.btnBuscarId.Click += new System.EventHandler(this.BtnBuscarId_Click);
            // 
            // FrmListarFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 362);
            this.Controls.Add(this.dtGridFacturas);
            this.Controls.Add(this.btnBuscarId);
            this.Controls.Add(this.btnBuscarCedula);
            this.Controls.Add(this.btnDescartar);
            this.Controls.Add(this.txtBuscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FrmListarFacturas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturas";
            ((System.ComponentModel.ISupportInitialize)(this.dtGridFacturas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtGridFacturas;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnDescartar;
        private System.Windows.Forms.Button btnBuscarCedula;
        private System.Windows.Forms.Button btnBuscarId;
    }
}