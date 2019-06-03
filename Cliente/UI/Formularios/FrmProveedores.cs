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
    public partial class FrmProveedores : Form
    {
        ServicioWCF.ServicioWCFClient servicio;

        int IdProveedor;

        DataTable dtProveedores;

        void ReestablecerCampos()
        {
            IdProveedor = 0;

            txtNombre.Text = null;
            txtRif.Text = null;
            txtDirFiscal.Text = null;

            btnAlterar.Text = "Añadir";

            btnEliminar.Enabled = false;

            LlenarDataGrid();
        }

        void LlenarDataGrid()
        {
            dtProveedores = servicio.GetDataTable("Proveedores");

            dtGridProveedores.DataSource = dtProveedores;

            dtGridProveedores.Columns["id"].HeaderText = "Id";
            dtGridProveedores.Columns["nombre"].HeaderText = "Nombre";
            dtGridProveedores.Columns["rif"].HeaderText = "Rif";
            dtGridProveedores.Columns["dir_fiscal"].HeaderText = "Dirección fiscal";
        }

        void BuscarDataGrid(string cadena)
        {
            int n;

            if (int.TryParse(cadena, out n))
            {
                var query = from b in dtProveedores.AsEnumerable()
                            where
                            b.Field<int?>("id").Equals(n)
                            select b;

                if (query.Count<DataRow>() >= 1)
                    dtGridProveedores.DataSource = query.CopyToDataTable();
            }
            else
            {
                var query = from b in dtProveedores.AsEnumerable()
                            where (
                            (b.Field<string>("nombre") != null) && b.Field<string>("nombre").ToLower().Contains(cadena.ToLower().Trim())
                            ||
                            (b.Field<string>("rif") != null) && b.Field<string>("rif").ToLower().Contains(cadena.ToLower().Trim())
                            ||
                            (b.Field<string>("dir_fiscal") != null) && b.Field<string>("dir_fiscal").ToLower().Contains(cadena.ToLower().Trim())
                            )
                            select b;

                if (query.Count<DataRow>() >= 1)
                    dtGridProveedores.DataSource = query.CopyToDataTable();
            }
        }

        public FrmProveedores(ServicioWCF.ServicioWCFClient servicio_)
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
                string strProveedorState = servicio.EliminarDeTabla(IdProveedor, "Proveedores");

                if (strProveedorState == "1")
                    ReestablecerCampos();
                else
                    MessageBox.Show(strProveedorState);

            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "")
            {
                if (btnAlterar.Text == "Añadir")
                {
                    string strAlterar = servicio.AlterarProveedor(
                        0,
                        txtNombre.Text,
                        txtRif.Text,
                        txtDirFiscal.Text);

                    if (strAlterar == "creado")
                        MessageBox.Show("Proveedor añadido.");
                    else
                        MessageBox.Show(strAlterar);
                }
                else if (btnAlterar.Text == "Modificar")
                {
                    string strAlterar = servicio.AlterarProveedor(
                        IdProveedor,
                        txtNombre.Text,
                        txtRif.Text,
                        txtDirFiscal.Text);

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

        private void DtGridProveedores_DoubleClick(object sender, EventArgs e)
        {
            if (dtGridProveedores.CurrentRow.Index != -1)
            {
                IdProveedor = Convert.ToInt32(dtGridProveedores.CurrentRow.Cells[0].Value.ToString());

                txtNombre.Text = dtGridProveedores.CurrentRow.Cells[1].Value.ToString();
                txtRif.Text = dtGridProveedores.CurrentRow.Cells[2].Value.ToString();
                txtDirFiscal.Text = dtGridProveedores.CurrentRow.Cells[3].Value.ToString();

                btnAlterar.Text = "Modificar";

                btnEliminar.Enabled = true;
            }
        }
    }
}
