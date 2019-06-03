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
    public partial class FrmClientes : Form
    {
        ServicioWCF.ServicioWCFClient servicio;

        int IdCliente;

        DataTable dtClientes;

        void ReestablecerCampos()
        {
            IdCliente = 0;

            txtCedula.Text = null;
            txtNombre.Text = null;
            txtApellido.Text = null;
            txtTelefono.Text = null;

            btnAlterar.Text = "Añadir";

            btnEliminar.Enabled = false;

            LlenarDataGrid();
        }

        void LlenarDataGrid()
        {
            dtClientes = servicio.GetDataTable("Clientes");

            dtGridClientes.DataSource = dtClientes;

            dtGridClientes.Columns["id"].Visible = false;
            dtGridClientes.Columns["cedula"].HeaderText = "Cédula";
            dtGridClientes.Columns["nombre"].HeaderText = "Nombre";
            dtGridClientes.Columns["apellido"].HeaderText = "Apellido";
            dtGridClientes.Columns["telefono"].HeaderText = "Teléfono";
        }

        void BuscarDataGrid(string cadena)
        {
            int n;

            if (int.TryParse(cadena, out n))
            {
                var query = from b in dtClientes.AsEnumerable()
                            where
                            b.Field<int?>("cedula").Equals(n)
                            select b;

                if (query.Count<DataRow>() >= 1)
                    dtGridClientes.DataSource = query.CopyToDataTable();
            }
            else
            {
                var query = from b in dtClientes.AsEnumerable()
                            where (
                            (b.Field<string>("nombre") != null) && b.Field<string>("nombre").ToLower().Contains(cadena.ToLower().Trim())
                            ||
                            (b.Field<string>("apellido") != null) && b.Field<string>("apellido").ToLower().Contains(cadena.ToLower().Trim())
                            ||
                            (b.Field<string>("telefono") != null) && b.Field<string>("telefono").ToLower().Contains(cadena.ToLower().Trim())
                            )
                            select b;

                if (query.Count<DataRow>() >= 1)
                    dtGridClientes.DataSource = query.CopyToDataTable();
            }
        }

        public FrmClientes(ServicioWCF.ServicioWCFClient servicio_)
        {
            servicio = servicio_;

            InitializeComponent();

            ReestablecerCampos();
        }

        public FrmClientes(ServicioWCF.ServicioWCFClient servicio_, int cedula)
        {
            servicio = servicio_;

            InitializeComponent();

            ReestablecerCampos();

            txtCedula.Text = cedula.ToString();
        }

        private void BtnDescartar_Click(object sender, EventArgs e)
        {
            ReestablecerCampos();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Si elimina el proveedor seleccionado, se podrían eliminar consecutivamente los productos relacionados", "¿Desea borrar el proveedor de la tabla?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string strClienteState = servicio.EliminarDeTabla(IdCliente, "Clientes");

                if (strClienteState == "1")
                    ReestablecerCampos();
                else
                    MessageBox.Show(strClienteState);

            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtCedula.Text != "" && txtNombre.Text != "" && txtApellido.Text != "")
            {
                if (btnAlterar.Text == "Añadir")
                {
                    string strAlterar = servicio.AlterarCliente(
                        0,
                        Convert.ToInt32(txtCedula.Text),
                        txtNombre.Text,
                        txtApellido.Text,
                        txtTelefono.Text
                        );

                    if (strAlterar == "creado")
                        MessageBox.Show("Cliente añadido.");
                    else
                        MessageBox.Show(strAlterar);
                }
                else if (btnAlterar.Text == "Modificar")
                {
                    string strAlterar = servicio.AlterarCliente(
                        IdCliente,
                        Convert.ToInt32(txtCedula.Text),
                        txtNombre.Text,
                        txtApellido.Text,
                        txtTelefono.Text
                        );

                    if (strAlterar != "modificado")
                        MessageBox.Show(strAlterar);
                }
            }
            else
                MessageBox.Show("Los campos marcados con asteriscos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            ReestablecerCampos();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text != null)
                BuscarDataGrid(txtBuscar.Text);
        }

        private void DtGridClientes_DoubleClick(object sender, EventArgs e)
        {
            if (dtGridClientes.CurrentRow.Index != -1)
            {
                IdCliente = Convert.ToInt32(dtGridClientes.CurrentRow.Cells[0].Value.ToString());

                txtCedula.Text = dtGridClientes.CurrentRow.Cells[1].Value.ToString();
                txtNombre.Text = dtGridClientes.CurrentRow.Cells[2].Value.ToString();
                txtApellido.Text = dtGridClientes.CurrentRow.Cells[3].Value.ToString();
                txtTelefono.Text = dtGridClientes.CurrentRow.Cells[4].Value.ToString();

                btnAlterar.Text = "Modificar";

                btnEliminar.Enabled = true;
            }
        }
    }
}
