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
    public partial class FrmAgregarProductoFactura : Form
    {
        ServicioWCF.ServicioWCFClient servicio;

        public int IdProducto;
        public string NombreProducto;
        public int PrecioProducto;
        public int CantidadProducto;

        DataTable dtProductos;

        void ReestablecerCampos()
        {
            IdProducto = 0;

            txtId.Text = null;
            txtPrecio.Text = null;
            txtCantidad.Text = null;

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

        public FrmAgregarProductoFactura(ServicioWCF.ServicioWCFClient servicio_)
        {
            servicio = servicio_;

            InitializeComponent();

            ReestablecerCampos();
        }

        private void BtnDescartar_Click(object sender, EventArgs e)
        {
            ReestablecerCampos();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            string strProductoState = servicio.EliminarDeTabla(IdProducto, "Productos");

            if (strProductoState == "1")
                ReestablecerCampos();
            else
                MessageBox.Show(strProductoState);
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text != null)
                BuscarDataGrid(txtBuscar.Text);
        }

        private void TxtCantidad_KeyPress(object sender, KeyPressEventArgs e)
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

        int GetCantidadProducto(int id)
        {
            DataRow[] dr = dtProductos.Select("id = " + id.ToString());

            return Convert.ToInt32(dr[0]["cantidad"].ToString());
        }

        private void DtGridProductos_DoubleClick(object sender, EventArgs e)
        {
            if (dtGridProductos.CurrentRow.Index != -1)
            {
                txtId.Text = dtGridProductos.CurrentRow.Cells[0].Value.ToString();
                txtPrecio.Text = dtGridProductos.CurrentRow.Cells[3].Value.ToString();
                //txtCantidad.Text = dtGridProductos.CurrentRow.Cells[4].Value.ToString();
            }
        }

        string GetNombreProducto(int id)
        {
            DataRow[] dr = dtProductos.Select("id = " + id.ToString());

            return dr[0]["nombre"].ToString();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "" && txtPrecio.Text != "" && txtCantidad.Text != "")
            {
                IdProducto = Convert.ToInt32(txtId.Text);

                if (Convert.ToInt32(txtCantidad.Text) > GetCantidadProducto(IdProducto))
                {
                    MessageBox.Show("La cantidad seleccionada del producto es mayor a la cantidad disponible.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    NombreProducto = GetNombreProducto(IdProducto);
                    PrecioProducto = Convert.ToInt32(txtPrecio.Text);
                    CantidadProducto = Convert.ToInt32(txtCantidad.Text);

                    DialogResult = DialogResult.OK;
                }
            }
            else
            {
                MessageBox.Show("Debe llenar todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
