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
        //Instancia para el filtro de los productos 
        private static frmTotalizar_OrdenDeCompra _Instancia;

        public static frmTotalizar_OrdenDeCompra GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new frmTotalizar_OrdenDeCompra();
            }
            return _Instancia;
        }

        public frmTotalizar_OrdenDeCompra()
        {
            InitializeComponent();
        }

        private void frmTotalizar_OrdenDeCompra_Load(object sender, EventArgs e)
        {
            //Inicio de Clase y Botones
            this.Habilitar();
            this.AutoCompletar_Combobox();
        }

        private void Habilitar()
        {
            //
            this.TBValorCotizado.ReadOnly = false;
            this.TBValorCotizado.BackColor = Color.FromArgb(3, 155, 229);
            this.TBDescuento_Porcentaje.ReadOnly = false;
            this.TBDescuento_Porcentaje.BackColor = Color.FromArgb(3, 155, 229);
            this.TBDescuento_Cotizado.ReadOnly = false;
            this.TBDescuento_Cotizado.BackColor = Color.FromArgb(3, 155, 229);
            this.TBValorFinal_Cotizado.ReadOnly = false;
            this.TBValorFinal_Cotizado.BackColor = Color.FromArgb(3, 155, 229);
            this.TBImpuesto_Cotizado.ReadOnly = false;
            this.TBImpuesto_Cotizado.BackColor = Color.FromArgb(3, 155, 229);
            this.TBTipoDePago_Cotizado.ReadOnly = false;
            this.TBTipoDePago_Cotizado.BackColor = Color.FromArgb(3, 155, 229);
            this.TBEnvio_Cotizado.ReadOnly = false;
            this.TBEnvio_Cotizado.BackColor = Color.FromArgb(3, 155, 229);

            //
            this.TBAdelanto.ReadOnly = false;
            this.TBAdelanto.BackColor = Color.FromArgb(3, 155, 229);
            this.TBAdelanto_Porcentaje.ReadOnly = false;
            this.TBAdelanto_Porcentaje.BackColor = Color.FromArgb(3, 155, 229);
            this.TBEfectivo.ReadOnly = false;
            this.TBEfectivo.BackColor = Color.FromArgb(3, 155, 229);
            this.TBCredito.ReadOnly = false;
            this.TBCredito.BackColor = Color.FromArgb(3, 155, 229);
            this.TBCheques.ReadOnly = false;
            this.TBCheques.BackColor = Color.FromArgb(3, 155, 229);
            this.TBTransferencia.ReadOnly = false;
            this.TBTransferencia.BackColor = Color.FromArgb(3, 155, 229);
            this.TBCreditoDisponible.ReadOnly = false;
            this.TBCreditoDisponible.BackColor = Color.FromArgb(3, 155, 229);
            this.TBDescuento_Final.ReadOnly = false;
            this.TBDescuento_Final.BackColor = Color.FromArgb(3, 155, 229);
            this.TBDias.ReadOnly = false;
            this.TBDias.BackColor = Color.FromArgb(3, 155, 229);
            this.TBValorGeneral.ReadOnly = false;
            this.TBValorGeneral.BackColor = Color.FromArgb(3, 155, 229);
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

        private void frmTotalizar_OrdenDeCompra_FormClosing(object sender, FormClosingEventArgs e)
        {
            _Instancia = null;
        }
    }
}
