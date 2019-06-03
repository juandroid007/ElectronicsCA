namespace Cliente
{
    partial class FrmLoginEmpleado
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
            this.grpBoxLogin = new System.Windows.Forms.GroupBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRgPwd = new System.Windows.Forms.TextBox();
            this.txtRgApellido = new System.Windows.Forms.TextBox();
            this.txtRgPwdRe = new System.Windows.Forms.TextBox();
            this.txtRgNombre = new System.Windows.Forms.TextBox();
            this.txtRgDni = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnExpandirRegistro = new System.Windows.Forms.Button();
            this.grpBoxLogin.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxLogin
            // 
            this.grpBoxLogin.Controls.Add(this.btnLogin);
            this.grpBoxLogin.Controls.Add(this.txtPwd);
            this.grpBoxLogin.Controls.Add(this.txtDni);
            this.grpBoxLogin.Controls.Add(this.label3);
            this.grpBoxLogin.Controls.Add(this.label1);
            this.grpBoxLogin.Location = new System.Drawing.Point(12, 12);
            this.grpBoxLogin.Name = "grpBoxLogin";
            this.grpBoxLogin.Size = new System.Drawing.Size(172, 148);
            this.grpBoxLogin.TabIndex = 0;
            this.grpBoxLogin.TabStop = false;
            this.grpBoxLogin.Text = "Iniciar sesión:";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(6, 111);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(160, 31);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Iniciar sesión";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(6, 80);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(160, 20);
            this.txtPwd.TabIndex = 1;
            this.txtPwd.UseSystemPasswordChar = true;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(6, 41);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(160, 20);
            this.txtDni.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Contraseña:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cédula:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRegistrar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtRgPwd);
            this.groupBox1.Controls.Add(this.txtRgApellido);
            this.groupBox1.Controls.Add(this.txtRgPwdRe);
            this.groupBox1.Controls.Add(this.txtRgNombre);
            this.groupBox1.Controls.Add(this.txtRgDni);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(225, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 148);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registrar:";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(172, 111);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(160, 31);
            this.btnRegistrar.TabIndex = 2;
            this.btnRegistrar.Text = "Registrar empleado";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cédula:";
            // 
            // txtRgPwd
            // 
            this.txtRgPwd.Location = new System.Drawing.Point(172, 41);
            this.txtRgPwd.Name = "txtRgPwd";
            this.txtRgPwd.Size = new System.Drawing.Size(160, 20);
            this.txtRgPwd.TabIndex = 1;
            this.txtRgPwd.UseSystemPasswordChar = true;
            // 
            // txtRgApellido
            // 
            this.txtRgApellido.Location = new System.Drawing.Point(6, 119);
            this.txtRgApellido.Name = "txtRgApellido";
            this.txtRgApellido.Size = new System.Drawing.Size(160, 20);
            this.txtRgApellido.TabIndex = 1;
            // 
            // txtRgPwdRe
            // 
            this.txtRgPwdRe.Location = new System.Drawing.Point(172, 80);
            this.txtRgPwdRe.Name = "txtRgPwdRe";
            this.txtRgPwdRe.Size = new System.Drawing.Size(160, 20);
            this.txtRgPwdRe.TabIndex = 1;
            this.txtRgPwdRe.UseSystemPasswordChar = true;
            // 
            // txtRgNombre
            // 
            this.txtRgNombre.Location = new System.Drawing.Point(6, 80);
            this.txtRgNombre.Name = "txtRgNombre";
            this.txtRgNombre.Size = new System.Drawing.Size(160, 20);
            this.txtRgNombre.TabIndex = 1;
            // 
            // txtRgDni
            // 
            this.txtRgDni.Location = new System.Drawing.Point(6, 41);
            this.txtRgDni.Name = "txtRgDni";
            this.txtRgDni.Size = new System.Drawing.Size(160, 20);
            this.txtRgDni.TabIndex = 1;
            this.txtRgDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtRgDni_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(174, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Confirma tu contraseña:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Nombre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Apellido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(174, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Contraseña:";
            // 
            // btnExpandirRegistro
            // 
            this.btnExpandirRegistro.Location = new System.Drawing.Point(190, 67);
            this.btnExpandirRegistro.Name = "btnExpandirRegistro";
            this.btnExpandirRegistro.Size = new System.Drawing.Size(29, 31);
            this.btnExpandirRegistro.TabIndex = 1;
            this.btnExpandirRegistro.TabStop = false;
            this.btnExpandirRegistro.Text = "<<";
            this.btnExpandirRegistro.UseVisualStyleBackColor = true;
            this.btnExpandirRegistro.Click += new System.EventHandler(this.BtnExpandirRegistro_Click);
            // 
            // FrmLoginEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 172);
            this.Controls.Add(this.btnExpandirRegistro);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpBoxLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmLoginEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de sesión de empleado";
            this.Load += new System.EventHandler(this.FrmLoginEmpleado_Load);
            this.grpBoxLogin.ResumeLayout(false);
            this.grpBoxLogin.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxLogin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExpandirRegistro;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox txtRgPwd;
        private System.Windows.Forms.TextBox txtRgApellido;
        private System.Windows.Forms.TextBox txtRgNombre;
        private System.Windows.Forms.TextBox txtRgDni;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRgPwdRe;
    }
}

