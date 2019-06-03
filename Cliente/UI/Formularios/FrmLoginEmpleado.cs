using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cliente.UI.Formularios;

namespace Cliente
{
    public partial class FrmLoginEmpleado : Form
    {
        ServicioWCF.ServicioWCFClient servicio = new ServicioWCF.ServicioWCFClient();

        // Fecha:       23-05-2019
        // Descripción: Clase que funciona como máquina de estados para manejar el tamaño de la ventana
        //              con el fin de visualizar el formulario de registro.
        private class cEstadoVentanaDeRegistro
        {
            private bool isExpanded;
            public Size Size { get; set; }

            public string BtnText { get; set; }

            public cEstadoVentanaDeRegistro()
            {
                isExpanded = false;
                ExpandirRegistro();
            }

            public void ExpandirRegistro()
            {
                if (isExpanded)
                {
                    BtnText = "<<";
                    Size = new Size(592, 207);
                }
                else
                {
                    BtnText = ">>";
                    Size = new Size(241, 207);
                }

                isExpanded = !isExpanded;
            }
        }

        private cEstadoVentanaDeRegistro estadoVentanaDeRegistro = new cEstadoVentanaDeRegistro();

        public FrmLoginEmpleado()
        {
            InitializeComponent();
        }

        private void FrmLoginEmpleado_Load(object sender, EventArgs e)
        {
            Size = estadoVentanaDeRegistro.Size;
            btnExpandirRegistro.Text = estadoVentanaDeRegistro.BtnText;
        }

        private void BtnExpandirRegistro_Click(object sender, EventArgs e)
        {
            estadoVentanaDeRegistro.ExpandirRegistro();
            Size = estadoVentanaDeRegistro.Size;
            btnExpandirRegistro.Text = estadoVentanaDeRegistro.BtnText;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (txtDni.Text != "" && txtPwd.Text != "")
            {
                ServicioWCF.cEmpleado empleado = servicio.LoginEmpleado(Convert.ToInt32(txtDni.Text), txtPwd.Text);

                if (empleado != null)
                {
                    MessageBox.Show("Hola, " + empleado.Nombre + " " + empleado.Apellido + ". Bienvenido al sistema de Electronics C.A.");
                    FrmMainForm form = new FrmMainForm(empleado, servicio);
                    form.Show();
                    Hide();
                }
                else
                    MessageBox.Show("Datos inválidos.");
            }
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtRgPwd.Text != txtRgPwdRe.Text)
                {
                    MessageBox.Show("Las contraseñas no coinciden.");
                }
                else
                {
                    if (txtRgNombre.Text != "" && txtRgApellido.Text != "" && txtRgDni.Text != "")
                    {
                        string strEmpleado = servicio.CrearEmpleado(Convert.ToInt32(txtRgDni.Text), txtRgNombre.Text, txtRgApellido.Text, txtRgPwd.Text);
                        if (strEmpleado == "1")
                            MessageBox.Show("Usuario creado correctamente.");
                        else
                            MessageBox.Show(strEmpleado);
                    }
                    else
                    {
                        MessageBox.Show("Ingrese todos los datos.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TxtRgDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}