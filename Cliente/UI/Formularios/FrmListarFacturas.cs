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
    public partial class FrmListarFacturas : Form
    {
        ServicioWCF.ServicioWCFClient servicio;

        DataTable dtFacturas;

        void ReestablecerCampos()
        {
            LlenarDataGrid();
        }

        void LlenarDataGrid()
        {
            dtFacturas = servicio.GetDataTable("Facturas");

            dtGridFacturas.DataSource = dtFacturas;

            dtGridFacturas.Columns["id"].HeaderText = "Id";
            dtGridFacturas.Columns["ced_cliente"].HeaderText = "Cédula del cliente";
            dtGridFacturas.Columns["fecha"].HeaderText = "Fecha";
        }

        void BuscarDataGrid(string cadena, int modo)
        {
            int n;

            if (int.TryParse(cadena, out n))
            {
                if (modo == 0)
                {
                    var query = from b in dtFacturas.AsEnumerable()
                                where
                                b.Field<int?>("id").Equals(n)
                                select b;

                    if (query.Count<DataRow>() >= 1)
                        dtGridFacturas.DataSource = query.CopyToDataTable();
                }
                else if (modo == 1)
                {
                    var query = from b in dtFacturas.AsEnumerable()
                                where
                                b.Field<int?>("ced_cliente").Equals(n)
                                select b;

                    if (query.Count<DataRow>() >= 1)
                        dtGridFacturas.DataSource = query.CopyToDataTable();
                }
            }
        }

        public FrmListarFacturas(ServicioWCF.ServicioWCFClient servicio_)
        {
            servicio = servicio_;

            InitializeComponent();

            ReestablecerCampos();
        }

        private void BtnDescartar_Click(object sender, EventArgs e)
        {
            ReestablecerCampos();
        }

        private void BtnBuscarId_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
                BuscarDataGrid(txtBuscar.Text, 0);
        }

        private void BtnBuscarCedula_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
                BuscarDataGrid(txtBuscar.Text, 1);
        }

        private void DtGridFacturas_DoubleClick(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dtGridFacturas.CurrentRow.Cells[0].Value.ToString());

            FrmVerFactura frmFactura = new FrmVerFactura(servicio, id);
            frmFactura.Show();
        }
    }
}
