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
    public partial class frmOrdenDeCompra : Form
    {
        //Instancia para el filtro de los productos 
        private static frmOrdenDeCompra _Instancia;

        public static frmOrdenDeCompra GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new frmOrdenDeCompra();
            }
            return _Instancia;
        }

        // Variable con la cual se define si el procecimiento 
        // A realizar es Editar, Guardar, Buscar, Eliminar
        private bool Digitar = true;
        public bool Filtro = true;
        public bool Examinar = true;

        //Variables de Validaciones
        public int Idempleado; //Variable para Captura el Empleado Logueado
        private string Campo_Obligatorio = "Campo Obligatorio";

        //********** Variable para Metodo SQL Guardar, Eliminar, Editar, Consultar *************************

        public string Guardar, Editar, Consultar, Eliminar, Imprimir = "";

        public frmOrdenDeCompra()
        {
            InitializeComponent();
        }

        private void frmOrdenDeCompra_Load(object sender, EventArgs e)
        {
            //Inicio de Clase y Botones
            this.Botones();
            this.Habilitar();

            //Focus a Texboxt y Combobox
            this.TBCodigo.Select();

            //Ocultacion de Texboxt
            this.TBIdproducto.Visible = false;
            this.TBIdbodega.Visible = false;
            this.TBIdproveedor.Visible = false;
            this.TBIddetalle.Visible = false;
        }

        private void Habilitar()
        {

            //Panel - Datos Basicos

            this.TBCodigo.ReadOnly = false;
            this.TBCodigo.BackColor = Color.FromArgb(3, 155, 229);
            this.TBCodigo.ForeColor = Color.FromArgb(255, 255, 255);
            this.TBCodigo.Text = Campo_Obligatorio;
            this.TBCodigo_Proveedor.ReadOnly = false;
            this.TBCodigo_Proveedor.BackColor = Color.FromArgb(3, 155, 229);
            this.TBCodigo_Proveedor.ForeColor = Color.FromArgb(255, 255, 255);
            this.TBCodigo_Proveedor.Text = Campo_Obligatorio;
            this.TBCodigo_Producto.ReadOnly = false;
            this.TBCodigo_Producto.BackColor = Color.FromArgb(3, 155, 229);
            this.TBCodigo_Producto.ForeColor = Color.FromArgb(255, 255, 255);
            this.TBCodigo_Producto.Text = Campo_Obligatorio;

            //
            this.TBProveedor.Enabled = false;
            this.TBProveedor.BackColor = Color.FromArgb(72, 209, 204);
            this.TBProducto.Enabled = false;
            this.TBProducto.BackColor = Color.FromArgb(72, 209, 204);

            //Texboxt de Datos - Parte Inferior del Formulario
            this.TBCompraPromedio.Enabled = false;
            this.TBCompraPromedio.BackColor = Color.FromArgb(72, 209, 204);

            this.TBCompraFinal.Enabled = false;
            this.TBCompraFinal.BackColor = Color.FromArgb(72, 209, 204);
            this.TBValorVenta_SinImpuesto.Enabled = false;
            this.TBValorVenta_SinImpuesto.BackColor = Color.FromArgb(72, 209, 204);
            this.TBValorVenta.Enabled = false;
            this.TBValorVenta.BackColor = Color.FromArgb(72, 209, 204);
            this.TBVentaMayorista.Enabled = false;
            this.TBVentaMayorista.BackColor = Color.FromArgb(72, 209, 204);

            //
            this.TBUbicacion.Enabled = false;
            this.TBUbicacion.BackColor = Color.FromArgb(72, 209, 204);
            this.TBMarca.Enabled = false;
            this.TBMarca.BackColor = Color.FromArgb(72, 209, 204);
            this.TBEstante.Enabled = false;
            this.TBEstante.BackColor = Color.FromArgb(72, 209, 204);
            this.TBNivel.Enabled = false;
            this.TBNivel.BackColor = Color.FromArgb(72, 209, 204);
            this.TBUnidad.Enabled = false;
            this.TBUnidad.BackColor = Color.FromArgb(72, 209, 204);
            this.TBUnidad_Valor.Enabled = false;
            this.TBUnidad_Valor.BackColor = Color.FromArgb(72, 209, 204);
            this.TBUnidad_Valor.ForeColor = Color.FromArgb(255, 255, 255);

            //
            this.TBValorPromedio_Final.Enabled = false;
            this.TBValorPromedio_Final.BackColor = Color.FromArgb(224, 255, 255);
            this.TBValorCompra_Final.Enabled = false;
            this.TBValorCompra_Final.BackColor = Color.FromArgb(224, 255, 255);
            this.TBValorFinalExcento_Final.Enabled = false;
            this.TBValorFinalExcento_Final.BackColor = Color.FromArgb(224, 255, 255);
            this.TBValorVenta_Final.Enabled = false;
            this.TBValorVenta_Final.BackColor = Color.FromArgb(224, 255, 255);

            //Texboxt de Consulta
            this.TBBuscar.BackColor = Color.FromArgb(3, 155, 229);
        }

        private void Limpiar_Datos()
        {
            if (!Digitar)
            {
                //Panel - Datos Basicos


                this.TBIdbodega.Clear();
                this.TBIddetalle.Clear();
                this.TBIdproducto.Clear();
                this.TBIdproveedor.Clear();

                this.TBCodigo.Clear();
                this.TBCodigo.Text = Campo_Obligatorio;
                this.TBCodigo_Producto.Clear();
                this.TBCodigo_Producto.Text = Campo_Obligatorio;
                this.TBCodigo_Proveedor.Clear();
                this.TBCodigo_Proveedor.Text = Campo_Obligatorio;
                this.TBOrdendecompra.Clear();
                this.TBProducto.Clear();
                this.TBProveedor.Clear();
                
                //Panel Datos Basicos - Parte Inferior
                this.TBCompraPromedio.Clear();
                this.TBCompraFinal.Clear();
                this.TBValorVenta.Clear();
                this.TBValorVenta_SinImpuesto.Clear();
                
                this.TBUbicacion.Clear();
                this.TBMarca.Clear();
                this.TBEstante.Clear();
                this.TBNivel.Clear();
                this.TBUnidad.Clear();
                this.TBUnidad_Valor.Clear();
                                               
                //Se habilitan los botones a su estado por DEFAULT
                this.Digitar = true;
                this.Botones();
                this.Habilitar();
                
                //Se realiza el FOCUS al panel y campo de texto iniciales
                this.TBCodigo.Select();
            }
        }

        private void Botones()
        {
            if (Digitar)
            {
                //Se procede a habilitar los botones de operacion para realizar registros en el sistema
                this.btnGuardar.Enabled = true;
                this.btnCancelar.Enabled = true;
                this.btnEliminar.Enabled = false;
                this.btnImprimir.Enabled = false;
            }
            else if (!Digitar)
            {
                //Se procede a habilitar los botones de operacion para Editar registros en el sistema
                this.btnGuardar.Enabled = true;
                this.btnCancelar.Enabled = true;
                this.btnEliminar.Enabled = false;
                this.btnImprimir.Enabled = false;
            }
        }

    }
}
