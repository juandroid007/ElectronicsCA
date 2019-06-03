namespace Cliente.UI.Formularios
{
    partial class FrmVerFactura
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
            this.dtGridProductos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblCedula = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridProductos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtGridProductos
            // 
            this.dtGridProductos.AllowUserToAddRows = false;
            this.dtGridProductos.AllowUserToDeleteRows = false;
            this.dtGridProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtGridProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridProductos.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtGridProductos.Location = new System.Drawing.Point(6, 19);
            this.dtGridProductos.Name = "dtGridProductos";
            this.dtGridProductos.ReadOnly = true;
            this.dtGridProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGridProductos.Size = new System.Drawing.Size(643, 275);
            this.dtGridProductos.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cédula del cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Id de factura:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(219, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nombre de pila del cliente:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(12, 31);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(15, 13);
            this.lblId.TabIndex = 5;
            this.lblId.Text = "id";
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Location = new System.Drawing.Point(104, 31);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(39, 13);
            this.lblCedula.TabIndex = 5;
            this.lblCedula.Text = "cedula";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(219, 31);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(42, 13);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "nombre";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(507, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Fecha de expedición de factura:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(507, 31);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(34, 13);
            this.lblFecha.TabIndex = 5;
            this.lblFecha.Text = "fecha";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtGridProductos);
            this.groupBox1.Location = new System.Drawing.Point(12, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(655, 301);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Productos";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(386, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Teléfono del cliente:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(386, 31);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(45, 13);
            this.lblTelefono.TabIndex = 5;
            this.lblTelefono.Text = "telefono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(633, 360);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Total:";
            // 
            // txtTotal
            // 
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(528, 376);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTotal.Size = new System.Drawing.Size(135, 19);
            this.txtTotal.TabIndex = 7;
            this.txtTotal.Text = "0 Bs";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FrmVerFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 404);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCedula);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FrmVerFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Factura";
            ((System.ComponentModel.ISupportInitialize)(this.dtGridProductos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtGridProductos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotal;
    }
}