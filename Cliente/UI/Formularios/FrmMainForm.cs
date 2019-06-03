using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente.UI.Formularios
{
    public partial class FrmMainForm : Form
    {
        ServicioWCF.cEmpleado empleado;
        ServicioWCF.ServicioWCFClient servicio;

        private void CargarEmpleado(ServicioWCF.cEmpleado empleado_)
        {
            empleado = empleado_;

            txtCedula.Text = Convert.ToString(empleado.Cedula);
            txtNombre.Text = empleado.Nombre;
            txtApellido.Text = empleado.Apellido;

            txtPass.Text = "";
            txtPassRe.Text = "";
        }

        public FrmMainForm(ServicioWCF.cEmpleado empleado, ServicioWCF.ServicioWCFClient servicio_)
        {
            InitializeComponent();

            servicio = servicio_;
            CargarEmpleado(empleado);
        }

        private void FrmMainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BtnEditarEmpleado_Click(object sender, EventArgs e)
        {
            if (txtCedula.ReadOnly && txtNombre.ReadOnly && txtApellido.ReadOnly)
            {
                //txtCedula.ReadOnly = false; txtCedula.BorderStyle = BorderStyle.Fixed3D;
                txtNombre.ReadOnly = false; txtNombre.BorderStyle = BorderStyle.Fixed3D;
                txtApellido.ReadOnly = false; txtApellido.BorderStyle = BorderStyle.Fixed3D;

                txtPass.ReadOnly = false; lblPass.Enabled = true;
                txtPassRe.ReadOnly = false; lblPassRe.Enabled = true;

                btnEditarEmpleado.Text = "Confirmar cambios";
            }
            else
            {
                txtCedula.ReadOnly = true; txtCedula.BorderStyle = BorderStyle.None;
                txtNombre.ReadOnly = true; txtNombre.BorderStyle = BorderStyle.None;
                txtApellido.ReadOnly = true; txtApellido.BorderStyle = BorderStyle.None;

                txtPass.ReadOnly = true; lblPass.Enabled = false;
                txtPassRe.ReadOnly = true; lblPassRe.Enabled = false;

                btnEditarEmpleado.Text = "Modificar empleado";

                try
                {
                    if ((txtPass.Text != "" && txtPassRe.Text != "") || (txtPass.Text != "" || txtPassRe.Text != ""))
                    {
                        if (txtPass.Text != txtPassRe.Text)
                        {
                            MessageBox.Show("Las contraseñas no coinciden.");
                        }
                        else
                        {
                            if (servicio.ModificarEmpleado(empleado.Cedula, Convert.ToInt32(txtCedula.Text), txtNombre.Text, txtApellido.Text, txtPass.Text) == "1")
                                MessageBox.Show("La contraseña ha sido modificada.");
                        }
                    }
                    else
                    {
                        servicio.ModificarEmpleado(empleado.Cedula, Convert.ToInt32(txtCedula.Text), txtNombre.Text, txtApellido.Text, "");
                    }

                    ServicioWCF.cEmpleado empleado_ = servicio.GetEmpleado(Convert.ToInt32(txtCedula.Text));

                    CargarEmpleado(empleado_);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void TxtCedula_KeyPress(object sender, KeyPressEventArgs e)
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

        private void BtnProductos_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(servicio);
            frmProductos.ShowDialog();
        }

        private void BtnProveedores_Click(object sender, EventArgs e)
        {
            FrmProveedores frmProveedores = new FrmProveedores(servicio);
            frmProveedores.ShowDialog();
        }

        private void btnTiposProductos_Click(object sender, EventArgs e)
        {
            FrmTiposProductos frmTiposProductos = new FrmTiposProductos(servicio);
            frmTiposProductos.ShowDialog();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FrmClientes frmClientes = new FrmClientes(servicio);
            frmClientes.ShowDialog();
        }

        private void BtnFacturar_Click(object sender, EventArgs e)
        {
            FrmFacturar frmFacturar = new FrmFacturar(servicio);
            frmFacturar.ShowDialog();
        }

        private void BtnFacturas_Click(object sender, EventArgs e)
        {
            FrmListarFacturas frmFacturas = new FrmListarFacturas(servicio);
            frmFacturas.ShowDialog();
        }
    }
}
