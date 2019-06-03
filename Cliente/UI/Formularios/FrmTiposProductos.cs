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
    public partial class FrmTiposProductos : Form
    {
        ServicioWCF.ServicioWCFClient servicio;

        int IdTipoProducto;

        DataTable dtTiposProductos;

        void ReestablecerCampos()
        {
            IdTipoProducto = 0;

            txtDescripcion.Text = null;

            btnAlterar.Text = "Añadir";

            btnEliminar.Enabled = false;

            LlenarDataGrid();
        }

        void LlenarDataGrid()
        {
            dtTiposProductos = servicio.GetDataTable("TiposProductos");

            dtGridTiposProductos.DataSource = dtTiposProductos;

            dtGridTiposProductos.Columns["id"].HeaderText = "Id";
            dtGridTiposProductos.Columns["descripcion"].HeaderText = "Descripción";
        }

        void BuscarDataGrid(string cadena)
        {
            int n;

            if (int.TryParse(cadena, out n))
            {
                var query = from b in dtTiposProductos.AsEnumerable()
                            where
                            b.Field<int?>("id").Equals(n)
                            select b;

                if (query.Count<DataRow>() >= 1)
                    dtGridTiposProductos.DataSource = query.CopyToDataTable();
            }
            else
            {
                var query = from b in dtTiposProductos.AsEnumerable()
                            where (
                            (b.Field<string>("descripcion") != null) && b.Field<string>("descripcion").ToLower().Contains(cadena.ToLower().Trim())
                            )
                            select b;

                if (query.Count<DataRow>() >= 1)
                    dtGridTiposProductos.DataSource = query.CopyToDataTable();
            }
        }

        public FrmTiposProductos(ServicioWCF.ServicioWCFClient servicio_)
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
            if (MessageBox.Show("Si elimina el proveedor seleccionado, se podrían eliminar consecutivamente los productos relacionados", "¿Desea borrar el proveedor de la tabla?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string strTipoProductoState = servicio.EliminarDeTabla(IdTipoProducto, "TiposProductos");

                if (strTipoProductoState == "1")
                    ReestablecerCampos();
                else
                    MessageBox.Show(strTipoProductoState);

            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtDescripcion.Text != "")
            {
                if (btnAlterar.Text == "Añadir")
                {
                    string strAlterar = servicio.AlterarTipoProducto(
                        0,
                        txtDescripcion.Text);

                    if (strAlterar == "creado")
                        MessageBox.Show("TipoProducto añadido.");
                    else
                        MessageBox.Show(strAlterar);
                }
                else if (btnAlterar.Text == "Modificar")
                {
                    string strAlterar = servicio.AlterarTipoProducto(
                        IdTipoProducto,
                        txtDescripcion.Text);

                    if (strAlterar != "modificado")
                        MessageBox.Show(strAlterar);
                }
            }
            else
                MessageBox.Show("Los campos marcados con asteriscos son obligatorios.");

            ReestablecerCampos();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text != null)
                BuscarDataGrid(txtBuscar.Text);
        }

        private void DtGridTiposProductos_DoubleClick(object sender, EventArgs e)
        {

            if (dtGridTiposProductos.CurrentRow.Index != -1)
            {
                IdTipoProducto = Convert.ToInt32(dtGridTiposProductos.CurrentRow.Cells[0].Value.ToString());

                txtDescripcion.Text = dtGridTiposProductos.CurrentRow.Cells[1].Value.ToString();

                btnAlterar.Text = "Modificar";

                btnEliminar.Enabled = true;
            }
        }
    }
}
