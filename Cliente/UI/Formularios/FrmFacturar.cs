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
    public partial class FrmFacturar : Form
    {
        ServicioWCF.ServicioWCFClient servicio;

        DataTable dt = new DataTable("Productos");

        public FrmFacturar(ServicioWCF.ServicioWCFClient servicio_)
        {
            servicio = servicio_;

            dt.Columns.Add("id", typeof(int));
            dt.Columns.Add("cantidad", typeof(int));
            dt.Columns.Add("nombre", typeof(string));
            dt.Columns.Add("precio", typeof(int));
            dt.Columns.Add("subtotal", typeof(int), "precio * cantidad");

            InitializeComponent();

            dtGridProductos.DataSource = dt;

            dtGridProductos.Columns["id"].HeaderText = "Id";
            dtGridProductos.Columns["cantidad"].HeaderText = "Cantidad";
            dtGridProductos.Columns["nombre"].HeaderText = "Producto";
            dtGridProductos.Columns["precio"].HeaderText = "Precio unitario";
            dtGridProductos.Columns["subtotal"].HeaderText = "Subtotal";

            CalcularTotal();
        }

        void CalcularTotal()
        {
            int total = 0;

            for (int i = 0; i < dtGridProductos.Rows.Count; i++)
            {
                total += Convert.ToInt32(dtGridProductos.Rows[i].Cells["subtotal"].Value.ToString());
            }

            txtTotal.Text = total.ToString() + " Bs";
        }

        private void BtnFacturar_Click(object sender, EventArgs e)
        {
            if (txtCedula.Text != "" && dtGridProductos.Rows.Count > 0)
            {
                if (servicio.VerificarCliente(Convert.ToInt32(txtCedula.Text)))
                {
                    string strFactura = servicio.AgregarFactura(Convert.ToInt32(txtCedula.Text));

                    int idFactura = 0;

                    if (int.TryParse(strFactura, out idFactura))
                    {
                        foreach (DataGridViewRow row in dtGridProductos.Rows)
                        {
                            int idProducto = Convert.ToInt32(row.Cells[0].Value.ToString());
                            int cantidad = Convert.ToInt32(row.Cells[1].Value.ToString());
                            int precio = Convert.ToInt32(row.Cells[3].Value.ToString());

                            string strDetalle = servicio.AgregarDetalleFactura(idFactura, idProducto, cantidad, precio);

                            if (strDetalle != "1")
                                MessageBox.Show("Detalle: " + strDetalle);
                        }

                        if (MessageBox.Show("La factura ha sido creada exitosamente, ¿quiere ver el reporte de la misma?", "Éxito", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            FrmVerFactura frmFactura = new FrmVerFactura(servicio, idFactura);
                            frmFactura.ShowDialog();
                        }

                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Factura: " + strFactura);
                    }
                }
                else
                {
                    if (MessageBox.Show("La cédula del cliente no está registrada, ¿quiere registrarla ahora mismo?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        FrmClientes frmClientes = new FrmClientes(servicio, Convert.ToInt32(txtCedula.Text));
                        frmClientes.ShowDialog();
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe asociar un cliente y al menos existir un producto en la factura.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        bool VerificarProducto(int id)
        {
            bool exist = false;

            foreach (DataGridViewRow row in dtGridProductos.Rows)
            {
                if (row.Cells[0].Value.ToString() == id.ToString())
                {
                    exist = true;
                }
                else
                    exist = false;
            }

            return exist;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            FrmAgregarProductoFactura frmAgregarProducto = new FrmAgregarProductoFactura(servicio);
            if (frmAgregarProducto.ShowDialog() == DialogResult.OK)
            {
                if (VerificarProducto(frmAgregarProducto.IdProducto))
                {
                    MessageBox.Show("Este producto ya existe en la factura.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dt.Rows.Add(frmAgregarProducto.IdProducto, frmAgregarProducto.CantidadProducto, frmAgregarProducto.NombreProducto, frmAgregarProducto.PrecioProducto);
                    CalcularTotal();
                    frmAgregarProducto.Close();
                    MessageBox.Show("Producto agregado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (dtGridProductos.Rows.Count > 0)
            {
                dtGridProductos.Rows.RemoveAt(dtGridProductos.CurrentRow.Index);
                CalcularTotal();
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
    }
}
