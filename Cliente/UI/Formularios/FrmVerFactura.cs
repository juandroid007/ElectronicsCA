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
    public partial class FrmVerFactura : Form
    {
        ServicioWCF.ServicioWCFClient servicio;

        int IdFactura;

        DataTable dtFactura;
        DataTable dtProductos;

        void ReestablecerCampos()
        {
            LlenarDataGrid();

            lblId.Text = IdFactura.ToString();
            lblCedula.Text = dtFactura.Rows[0][1].ToString();
            lblNombre.Text = dtFactura.Rows[0][2].ToString() + " " + dtFactura.Rows[0][3].ToString();
            lblTelefono.Text = dtFactura.Rows[0][4].ToString();
            lblFecha.Text = dtFactura.Rows[0][5].ToString();

            int total = 0;

            for (int i = 0; i < dtProductos.Rows.Count; i++)
            {
                total += Convert.ToInt32(dtProductos.Rows[i][4].ToString());
            }

            txtTotal.Text = total.ToString() + " Bs";
        }

        void LlenarDataGrid()
        {
            dtFactura = servicio.GetDataTable("fnVerFactura(" + IdFactura.ToString() +")");
            dtProductos = servicio.GetDataTable("fnVerDetalleFactura(" + IdFactura.ToString() +")");

            dtProductos.Columns.Add("subtotal", typeof(int), "cantidad * precio");

            dtGridProductos.DataSource = dtProductos;

            dtGridProductos.Columns["id"].HeaderText = "Id";
            dtGridProductos.Columns["cantidad"].HeaderText = "Cantidad";
            dtGridProductos.Columns["producto"].HeaderText = "Producto";
            dtGridProductos.Columns["precio"].HeaderText = "Precio unitario";
            dtGridProductos.Columns["subtotal"].HeaderText = "Subtotal";
        }

        public FrmVerFactura(ServicioWCF.ServicioWCFClient servicio_, int id)
        {
            servicio = servicio_;

            IdFactura = id;

            InitializeComponent();

            Text = "Factura Nº " + IdFactura.ToString();

            ReestablecerCampos();
        }
    }
}
