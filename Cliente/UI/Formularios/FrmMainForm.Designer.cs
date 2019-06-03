namespace Cliente.UI.Formularios
{
    partial class FrmMainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPassRe = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblPassRe = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEditarEmpleado = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnProductos = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnProveedores = new System.Windows.Forms.Button();
            this.btnFacturar = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnFacturas = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPassRe);
            this.groupBox1.Controls.Add(this.txtPass);
            this.groupBox1.Controls.Add(this.lblPassRe);
            this.groupBox1.Controls.Add(this.txtApellido);
            this.groupBox1.Controls.Add(this.lblPass);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnEditarEmpleado);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCedula);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(173, 383);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del empleado:";
            // 
            // txtPassRe
            // 
            this.txtPassRe.Location = new System.Drawing.Point(6, 320);
            this.txtPassRe.Name = "txtPassRe";
            this.txtPassRe.ReadOnly = true;
            this.txtPassRe.Size = new System.Drawing.Size(161, 20);
            this.txtPassRe.TabIndex = 2;
            this.txtPassRe.TabStop = false;
            this.txtPassRe.UseSystemPasswordChar = true;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(6, 281);
            this.txtPass.Name = "txtPass";
            this.txtPass.ReadOnly = true;
            this.txtPass.Size = new System.Drawing.Size(161, 20);
            this.txtPass.TabIndex = 2;
            this.txtPass.TabStop = false;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // lblPassRe
            // 
            this.lblPassRe.AutoSize = true;
            this.lblPassRe.Enabled = false;
            this.lblPassRe.Location = new System.Drawing.Point(6, 304);
            this.lblPassRe.Name = "lblPassRe";
            this.lblPassRe.Size = new System.Drawing.Size(119, 13);
            this.lblPassRe.TabIndex = 1;
            this.lblPassRe.Text = "Confirma tu contraseña:";
            // 
            // txtApellido
            // 
            this.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellido.Location = new System.Drawing.Point(55, 233);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.ReadOnly = true;
            this.txtApellido.Size = new System.Drawing.Size(112, 13);
            this.txtApellido.TabIndex = 2;
            this.txtApellido.TabStop = false;
            this.txtApellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Enabled = false;
            this.lblPass.Location = new System.Drawing.Point(6, 265);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(64, 13);
            this.lblPass.TabIndex = 1;
            this.lblPass.Text = "Contraseña:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Apellido:";
            // 
            // btnEditarEmpleado
            // 
            this.btnEditarEmpleado.Location = new System.Drawing.Point(6, 346);
            this.btnEditarEmpleado.Name = "btnEditarEmpleado";
            this.btnEditarEmpleado.Size = new System.Drawing.Size(161, 31);
            this.btnEditarEmpleado.TabIndex = 50;
            this.btnEditarEmpleado.TabStop = false;
            this.btnEditarEmpleado.Text = "Editar empleado";
            this.btnEditarEmpleado.UseVisualStyleBackColor = true;
            this.btnEditarEmpleado.Click += new System.EventHandler(this.BtnEditarEmpleado_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Location = new System.Drawing.Point(55, 201);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(112, 13);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.TabStop = false;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // txtCedula
            // 
            this.txtCedula.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCedula.Location = new System.Drawing.Point(55, 169);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.ReadOnly = true;
            this.txtCedula.Size = new System.Drawing.Size(112, 13);
            this.txtCedula.TabIndex = 2;
            this.txtCedula.TabStop = false;
            this.txtCedula.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCedula_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cédula:";
            // 
            // btnProductos
            // 
            this.btnProductos.Location = new System.Drawing.Point(191, 48);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(217, 38);
            this.btnProductos.TabIndex = 2;
            this.btnProductos.Text = "Ver productos";
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.BtnProductos_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(185, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 33);
            this.label4.TabIndex = 2;
            this.label4.Text = "Electronics, C.A";
            // 
            // btnProveedores
            // 
            this.btnProveedores.Location = new System.Drawing.Point(191, 92);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Size = new System.Drawing.Size(217, 38);
            this.btnProveedores.TabIndex = 3;
            this.btnProveedores.Text = "Ver proveedores";
            this.btnProveedores.UseVisualStyleBackColor = true;
            this.btnProveedores.Click += new System.EventHandler(this.BtnProveedores_Click);
            // 
            // btnFacturar
            // 
            this.btnFacturar.Location = new System.Drawing.Point(191, 354);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(217, 38);
            this.btnFacturar.TabIndex = 1;
            this.btnFacturar.Text = "Facturar";
            this.btnFacturar.UseVisualStyleBackColor = true;
            this.btnFacturar.Click += new System.EventHandler(this.BtnFacturar_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Location = new System.Drawing.Point(191, 180);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(217, 38);
            this.btnClientes.TabIndex = 4;
            this.btnClientes.Text = "Administrar clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(191, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(217, 38);
            this.button1.TabIndex = 3;
            this.button1.Text = "Ver tipos de productos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnTiposProductos_Click);
            // 
            // btnFacturas
            // 
            this.btnFacturas.Location = new System.Drawing.Point(191, 224);
            this.btnFacturas.Name = "btnFacturas";
            this.btnFacturas.Size = new System.Drawing.Size(217, 38);
            this.btnFacturas.TabIndex = 4;
            this.btnFacturas.Text = "Consultar facturas";
            this.btnFacturas.UseVisualStyleBackColor = true;
            this.btnFacturas.Click += new System.EventHandler(this.BtnFacturas_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Cliente.Properties.Resources.Perfil;
            this.pictureBox1.Location = new System.Drawing.Point(22, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 401);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnFacturas);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.btnFacturar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnProveedores);
            this.Controls.Add(this.btnProductos);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel de empleado";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMainForm_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnProveedores;
        private System.Windows.Forms.Button btnFacturar;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnEditarEmpleado;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtPassRe;
        private System.Windows.Forms.Label lblPassRe;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnFacturas;
    }
}