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
    public partial class frmProductos : Form
    {
        // Variable con la cual se define si el procecimiento 
        // A realizar es Editar, Guardar, Buscar,Eliminar
        private bool Digitar = true;
        public bool Filtro = true;
        private string Campo = "Campo Obligatorio - Leal Enterprise";


        //Variable para Captura el Empleado Logueado
        public int Idempleado;

        //Variable para Metodo SQL Guardar, Eliminar, Editar, Consultar
        public string Guardar = "";
        public string Editar = "";
        public string Consultar = "";
        public string Eliminar = "";
        public string Imprimir = "";

        //Parametros para AutoCompletar los Texboxt

        //Panel Datos Basicos
        public string Idbodega = "";
        public string Idsucurzal = "";
        public string Nombre = "";
        public string Tipo = "";
        public string Ciudad = "";
        public string Telefono = "";
        public string Movil = "";
        public string Correo = "";
        public string Responsable = "";
        public frmProductos()
        {
            InitializeComponent();
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            //Inicio de Clase y Botones
            this.Botones();
            this.Habilitar();

            //Focus a Texboxt y Combobox
            this.TBNombre.Select();

            //Ocultacion de Texboxt
            this.TBIdproducto.Visible = false;
        }

        private void Habilitar()
        {
            //Panel - Datos Basicos

            this.TBCodigo.ReadOnly = false;
            this.TBCodigo.BackColor = Color.FromArgb(3, 155, 229);
            this.TBCodigo.ForeColor = Color.FromArgb(255, 255, 255);
            this.TBCodigo.Text = Campo;
            this.TBNombre.ReadOnly = false;
            this.TBNombre.BackColor = Color.FromArgb(3, 155, 229);
            this.TBNombre.ForeColor = Color.FromArgb(255, 255, 255);
            this.TBNombre.Text = Campo;
            this.TBDescripcion01.ReadOnly = false;
            this.TBDescripcion01.BackColor = Color.FromArgb(3, 155, 229);
            this.TBDescripcion01.ForeColor = Color.FromArgb(255, 255, 255);
            this.TBDescripcion01.Text = Campo;

            this.TBReferencia.ReadOnly = false;
            this.TBReferencia.BackColor = Color.FromArgb(3, 155, 229);
            this.TBLotedeingreso.ReadOnly = false;
            this.TBLotedeingreso.BackColor = Color.FromArgb(3, 155, 229);
            this.TBPresentacion.ReadOnly = false;
            this.TBPresentacion.BackColor = Color.FromArgb(3, 155, 229);

            //
            this.TBValorCompraMinina.ReadOnly = false;
            this.TBValorCompraMinina.BackColor = Color.FromArgb(3, 155, 229);
            this.TBValorCompraMaxima.ReadOnly = false;
            this.TBValorCompraMaxima.BackColor = Color.FromArgb(3, 155, 229);
            this.TBValor01.ReadOnly = false;
            this.TBValor01.BackColor = Color.FromArgb(3, 155, 229);
            this.TBValor02.ReadOnly = false;
            this.TBValor02.BackColor = Color.FromArgb(3, 155, 229);
            this.TBValor03.ReadOnly = false;
            this.TBValor03.BackColor = Color.FromArgb(3, 155, 229);
            this.TBOferta01.ReadOnly = false;
            this.TBOferta01.BackColor = Color.FromArgb(3, 155, 229);
            this.TBOferta02.ReadOnly = false;
            this.TBOferta02.BackColor = Color.FromArgb(3, 155, 229);
            this.TBOferta03.ReadOnly = false;
            this.TBOferta03.BackColor = Color.FromArgb(3, 155, 229);

            //
            this.TBUbicacion.ReadOnly = false;
            this.TBUbicacion.BackColor = Color.FromArgb(3, 155, 229);
            this.TBEstante.ReadOnly = false;
            this.TBEstante.BackColor = Color.FromArgb(3, 155, 229);
            this.TBNivel.ReadOnly = false;
            this.TBNivel.BackColor = Color.FromArgb(3, 155, 229);

            //Panel - Otros Datos
            this.TBValorCompraMinina.ReadOnly = false;
            this.TBValorCompraMinina.BackColor = Color.FromArgb(3, 155, 229);
            this.TBValorCompraMaxima.ReadOnly = false;
            this.TBValorCompraMaxima.BackColor = Color.FromArgb(3, 155, 229);
            this.TBCantidadMininaCliente.ReadOnly = false;
            this.TBCantidadMininaCliente.BackColor = Color.FromArgb(3, 155, 229);
            this.TBCantidadMaximaCliente.ReadOnly = false;
            this.TBCantidadMaximaCliente.BackColor = Color.FromArgb(3, 155, 229);

            //Texboxt de Consulta
            this.TBBuscar.BackColor = Color.FromArgb(3, 155, 229);
        }

        private void Limpiar_Datos()
        {
            if (!Digitar)
            {
                //Panel - Datos Basicos

                this.TBCodigo.Clear();
                this.TBCodigo.Text = Campo;
                this.TBNombre.Clear();
                this.TBNombre.Text = Campo;
                this.TBDescripcion01.Clear();
                this.TBDescripcion01.Text = Campo;

                this.TBReferencia.ReadOnly = false;
                this.TBLotedeingreso.ReadOnly = false;
                this.TBPresentacion.ReadOnly = false;

                //
                this.TBValorCompraMinina.Clear();
                this.TBValorCompraMaxima.Clear();
                this.TBValor01.Clear();
                this.TBValor02.Clear();
                this.TBValor03.Clear();
                this.TBOferta01.Clear();
                this.TBOferta02.Clear();
                this.TBOferta03.Clear();

                //
                this.TBUbicacion.Clear();
                this.TBEstante.Clear();
                this.TBNivel.Clear();

                //Panel - Otros Datos
                this.TBValorCompraMinina.Clear();
                this.TBValorCompraMaxima.Clear();
                this.TBCantidadMininaCliente.Clear();
                this.TBCantidadMaximaCliente.Clear();

                //Se habilitan los botones a su estado por DEFAULT
                this.Digitar = true;
                this.Botones();
                this.Habilitar();
                //this.PB_Imagen.Image = Properties.Resources.

                //Se realiza el FOCUS al panel y campo de texto iniciales
                this.TBNombre.Focus();
            }

        }

        private void Botones()
        {
            if (Digitar)
            {
                ////El boton btnGuardar Mantendra su imagen original
                //this.btnGuardar.Enabled = true;
                //this.btnGuardar.Image = Properties.Resources.BV_Guardar;

                this.btnEliminar.Enabled = false;
                this.btnCancelar.Enabled = false;
                this.btnImprimir.Enabled = false;
            }
            else if (!Digitar)
            {
                ////El boton btnGuardar cambiara su imagen original de Guardar a Editar
                //this.btnGuardar.Enabled = true;
                //this.btnGuardar.Image = Properties.Resources.BV_Editar;

                this.btnEliminar.Enabled = false;
                this.btnCancelar.Enabled = true;
                this.btnImprimir.Enabled = false;
            }
        }

        private void Guardar_SQL()
        {
            try
            {
                string rptaDatosBasicos = "";

                // <<<<<<------ Panel Datos Basicos ------>>>>>

                if (this.TBNombre.Text == Campo)
                {
                    MensajeError("Ingrese el nombre del Producto a registrar");
                }
                else if (this.TBDescripcion01.Text == Campo)
                {
                    MensajeError("Ingrese la Descripcion del Producto");
                }
                else if (this.TBCodigo.Text == Campo)
                {
                    MensajeError("Ingrese el Codigo del Producto");
                }

                else
                {
                    //Parametros para poder guardar la imagen del producto

                    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                    this.PB_Imagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

                    byte[] Imagen_Producto = ms.GetBuffer();

                    if (this.Digitar)
                    {
                        rptaDatosBasicos = fProductos.Guardar_DatosBasicos

                            (
                                 //Datos Auxiliares
                                 1, Convert.ToInt32(this.CBMarca.SelectedValue), Convert.ToInt32(this.CBBodega.SelectedValue), Convert.ToInt32(this.CBProveedor.SelectedValue), Convert.ToInt32(this.CBImpuesto.SelectedValue),

                                 //Panel Datos Basicos
                                 this.TBCodigo.Text, this.TBNombre.Text, this.TBReferencia.Text, this.TBDescripcion01.Text, this.TBLotedeingreso.Text, this.TBPresentacion.Text,
                                 this.CBOrigen.Text, this.CBGrupo.Text, this.CBTipo.Text, this.CBEmpaque.Text,

                                 //
                                 this.CBOfertable.Text, this.CBVentaPublico.Text, this.TBValorCompraMinina.Text, this.TBValorCompraMaxima.Text, this.TBValor01.Text,
                                 this.TBValor02.Text, this.TBValor03.Text, this.TBOferta01.Text, this.TBOferta02.Text, this.TBValor03.Text,

                                 //
                                 this.TBUbicacion.Text, this.TBEstante.Text, this.TBNivel.Text,

                                 //
                                 this.CBUnidad.Text, this.TBCantidadMinima.Text, this.TBCantidadMaxima.Text, this.TBCantidadMininaCliente.Text, this.TBCantidadMaximaCliente.Text,
                                 this.CBVence.Text, this.DTFechadevencimiento.Value, this.CBPesoUnidad.Text, this.TBPeso.Text, Imagen_Producto,

                                 //                                 
                                 1
                            );
                    }

                    else
                    {
                        rptaDatosBasicos = fProductos.Editar_DatosBasicos

                            (
                                 //Datos Auxiliares
                                 1, Convert.ToInt32(this.TBIdproducto.Text), Convert.ToInt32(this.CBMarca.SelectedValue), Convert.ToInt32(this.CBBodega.SelectedValue), Convert.ToInt32(this.CBProveedor.SelectedValue), Convert.ToInt32(this.CBImpuesto.SelectedValue),

                                 //Panel Datos Basicos
                                 this.TBCodigo.Text, this.TBNombre.Text, this.TBReferencia.Text, this.TBDescripcion01.Text, this.TBLotedeingreso.Text, this.TBPresentacion.Text,
                                 this.CBOrigen.Text, this.CBGrupo.Text, this.CBTipo.Text, this.CBEmpaque.Text,

                                 //
                                 this.CBOfertable.Text, this.CBVentaPublico.Text, this.TBValorCompraMinina.Text, this.TBValorCompraMaxima.Text, this.TBValor01.Text,
                                 this.TBValor02.Text, this.TBValor03.Text, this.TBOferta01.Text, this.TBOferta02.Text, this.TBValor03.Text,

                                 //
                                 this.TBUbicacion.Text, this.TBEstante.Text, this.TBNivel.Text,

                                 //
                                 this.CBUnidad.Text, this.TBCantidadMinima.Text, this.TBCantidadMaxima.Text, this.TBCantidadMininaCliente.Text, this.TBCantidadMaximaCliente.Text,
                                 this.CBVence.Text, this.DTFechadevencimiento.Value, this.CBPesoUnidad.Text, this.TBPeso.Text, Imagen_Producto,

                                 //                                 
                                 2
                            );
                    }

                    if (rptaDatosBasicos.Equals("OK"))
                    {
                        if (this.Digitar)
                        {
                            this.MensajeOk("Registro Exitoso");
                        }

                        else
                        {
                            this.MensajeOk("Registro Actualizado");
                        }
                    }

                    else
                    {
                        this.MensajeError(rptaDatosBasicos);
                    }

                    //Llamada de Clase
                    this.Digitar = false;
                    this.Limpiar_Datos();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        //Mensaje de confirmacion
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Leal Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        //Mensaje de Error
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Leal Enterprise - Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void CBOfertable_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBOfertable.SelectedIndex == 0)
            {
                this.TBOferta01.ReadOnly = true;
                this.TBOferta02.ReadOnly = true;
                this.TBOferta03.ReadOnly = true;

                this.TBOferta01.Clear();
                this.TBOferta02.Clear();
                this.TBOferta03.Clear();
            }
            else
            {
                this.TBOferta01.ReadOnly = false;
                this.TBOferta02.ReadOnly = false;
                this.TBOferta03.ReadOnly = false;
            }
        }
    }
}
