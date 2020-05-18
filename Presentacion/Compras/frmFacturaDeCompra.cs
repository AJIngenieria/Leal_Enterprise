using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frmFacturaDeCompra : Form
    {
        public frmFacturaDeCompra()
        {
            InitializeComponent();
        }

        private void frmFacturaDeCompra_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                frmTotalizarOrden frmTotalizarOrden = new frmTotalizarOrden();
                frmTotalizarOrden.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void CBOperacion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
