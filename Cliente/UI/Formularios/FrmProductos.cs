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
    public partial class FrmProductos : Form
    {
        ServicioWCF.ServicioWCFClient servicio;

        int IdProducto;

        DataTable dtProductos;

        void ReestablecerCampos()
        {
            IdProducto = 0;

            txtNombre.Text = null;
            txtDescripcion.Text = null;
            txtPrecio.Text = null;
            txtCantidad.Text = null;

            btnAlterar.Text = "Añadir";

            cmbProveedor.DataSource = servicio.GetDataTable("Proveedores");
            cmbProveedor.DisplayMember = "nombre";
            cmbProveedor.ValueMember = "id";
            cmbProveedor.SelectedIndex = -1;

            cmbTipo.DataSource = servicio.GetDataTable("TiposProductos");
            cmbTipo.DisplayMember = "descripcion";
            cmbTipo.ValueMember = "id";
            cmbTipo.SelectedIndex = -1;

            btnEliminar.Enabled = false;

            LlenarDataGrid();
        }

        void LlenarDataGrid()
        {
            dtProductos = servicio.GetDataTable("fnVerProductos()");

            dtGridProductos.DataSource = dtProductos;

            dtGridProductos.Columns["id"].HeaderText = "Id";
            dtGridProductos.Columns["nombre"].HeaderText = "Nombre";
            dtGridProductos.Columns["descripcion"].HeaderText = "Descripción";
            dtGridProductos.Columns["precio"].HeaderText = "Precio";
            dtGridProductos.Columns["cantidad"].HeaderText = "Cantidad";
            dtGridProductos.Columns["id_proveedor"].Visible = false;
            dtGridProductos.Columns["proveedor"].HeaderText = "Proveedor";
            dtGridProductos.Columns["id_tipo"].Visible = false;
            dtGridProductos.Columns["tipo"].HeaderText = "Tipo";
        }

        void BuscarDataGrid(string cadena)
        {
            int n;

            if (int.TryParse(cadena, out n))
            {
                var query = from b in dtProductos.AsEnumerable()
                            where
                            b.Field<int?>("id").Equals(n)
                            select b;

                if (query.Count<DataRow>() >= 1)
                    dtGridProductos.DataSource = query.CopyToDataTable();
            }
            else
            {
                var query = from b in dtProductos.AsEnumerable()
                            where (
                            (b.Field<string>("nombre") != null) && b.Field<string>("nombre").ToLower().Contains(cadena.ToLower().Trim())
                            ||
                            (b.Field<string>("descripcion") != null) && b.Field<string>("descripcion").ToLower().Contains(cadena.ToLower().Trim())
                            ||
                            (b.Field<string>("proveedor") != null) && b.Field<string>("proveedor").ToLower().Contains(cadena.ToLower().Trim())
                            ||
                            (b.Field<string>("tipo") != null) && b.Field<string>("tipo").ToLower().Contains(cadena.ToLower().Trim())
                            )
                            select b;

                if (query.Count<DataRow>() >= 1)
                    dtGridProductos.DataSource = query.CopyToDataTable();
            }
        }

        public FrmProductos(ServicioWCF.ServicioWCFClient servicio_)
        {
            servicio = servicio_;

            InitializeComponent();

            ReestablecerCampos();
        }

        private void BtnDescartar_Click(object sender, EventArgs e)
        {
            ReestablecerCampos();
        }

        private void DtGridProductos_DoubleClick(object sender, EventArgs e)
        {
            if (dtGridProductos.CurrentRow.Index != -1)
            {
                IdProducto = Convert.ToInt32(dtGridProductos.CurrentRow.Cells[0].Value.ToString());

                txtNombre.Text = dtGridProductos.CurrentRow.Cells[1].Value.ToString();
                txtDescripcion.Text = dtGridProductos.CurrentRow.Cells[2].Value.ToString();
                txtPrecio.Text = dtGridProductos.CurrentRow.Cells[3].Value.ToString();
                txtCantidad.Text = dtGridProductos.CurrentRow.Cells[4].Value.ToString();
                cmbProveedor.SelectedValue = dtGridProductos.CurrentRow.Cells[5].Value;
                cmbTipo.SelectedValue = dtGridProductos.CurrentRow.Cells[7].Value;

                btnAlterar.Text = "Modificar";

                btnEliminar.Enabled = true;
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            string strProductoState = servicio.EliminarDeTabla(IdProducto, "Productos");

            if (strProductoState == "1")
                ReestablecerCampos();
            else
                MessageBox.Show(strProductoState);

        }

        private void txtPrecio_Cantidad_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtPrecio.Text != "" && txtCantidad.Text != "" && cmbProveedor.SelectedIndex != -1 && cmbTipo.SelectedIndex != -1)
            {
                if (btnAlterar.Text == "Añadir")
                {
                    string strAlterar = servicio.AlterarProducto(
                        0,
                        txtNombre.Text,
                        txtDescripcion.Text,
                        Convert.ToInt32(txtPrecio.Text),
                        Convert.ToInt32(txtCantidad.Text),
                        Convert.ToInt32(cmbProveedor.SelectedValue.ToString()),
                        Convert.ToInt32(cmbTipo.SelectedValue.ToString()));

                    if (strAlterar == "creado")
                        MessageBox.Show("Producto añadido.");
                    else
                        MessageBox.Show(strAlterar);
                }
                else if (btnAlterar.Text == "Modificar")
                {
                    string strAlterar = servicio.AlterarProducto(
                        IdProducto,
                        txtNombre.Text,
                        txtDescripcion.Text,
                        Convert.ToInt32(txtPrecio.Text),
                        Convert.ToInt32(txtCantidad.Text),
                        Convert.ToInt32(cmbProveedor.SelectedValue.ToString()),
                        Convert.ToInt32(cmbTipo.SelectedValue.ToString()));

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
    }
}
