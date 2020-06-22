using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Negocio;

namespace Presentacion
{
    public partial class frmTotalizar_OrdenDeCompra : Form
    {
        public frmTotalizar_OrdenDeCompra()
        {
            InitializeComponent();
        }

        private void frmTotalizar_OrdenDeCompra_Load(object sender, EventArgs e)
        {
            this.AutoCompletar_Combobox();
        }

        private void AutoCompletar_Combobox()
        {
            try
            {
                this.CBTipodepago.DataSource = fTipoDePago.Lista();
                this.CBTipodepago.ValueMember = "Codigo";
                this.CBTipodepago.DisplayMember = "Tipo";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void CBRetencion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
