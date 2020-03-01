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

        //Variables de Validaciones
        public int Idempleado; //Variable para Captura el Empleado Logueado
        private string Campo = "Campo Obligatorio - Leal Enterprise";
        private string Numerico = "Campo Numerico - Leal Enterprise";
        private string Vacio = "";
        private string Valores = ""; //Especifica el Valor de venta Final en la base de datos 
                                     //segun el valor seleccionado e ingresado en los campos

        //********** Variables para AutoComplementar Combobox segun la Consulta en SQL **********

        //Panel Datos Basicos
        private string Empaque_SQL, Grupo_SQL, Marca_SQL, Origen_SQL, Tipo_SQL = "";
        private string Bodega_SQL, Proveedor_SQL, Impuesto_SQL = "";


        //********** Variable para Metodo SQL Guardar, Eliminar, Editar, Consultar **************

        public string Guardar = "";
        public string Editar = "";
        public string Consultar = "";
        public string Eliminar = "";
        public string Imprimir = "";

        //********** Parametros para AutoCompletar los Texboxt **********************************

        //Panel Datos Basicos - Llaves Primarias
        private string Idmarca, Idorigen, Idgrupo, Idtipo, Idempaque, Idbodega, Idproveedor, Idimpuesto = "";

        //Panel Datos Basicos
        private string Codigo, Barra, Nombre, Referencia, Descripcion, Lote, Presentacion = "";

        //Panel - Valores
        private string Ofertable, VentaFinal, CompraMinima, CompraMaxima, ValorVenta01, ValorVenta02,
                       Oferta01, Oferta02, Ubicacion, Estante, Nivel, Imagen;

        private string UnidadDeVenta, CantidadCompraMinima, CantidadCompraMaxima, CantidadMinimaCliente, CantidadMaximaCliente, Vence;
        private DateTime Fecha;
        private string UnidadDePeso;

        //***********************************************************************************************************************

        public frmProductos()
        {
            InitializeComponent();
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            //Inicio de Clase y Botones
            this.Botones();
            this.Habilitar();
            this.AutoCompletar_Combobox();

            //Focus a Texboxt y Combobox
            this.TBNombre.Select();

            //Ocultacion de Texboxt
            this.TBIdproducto.Visible = false;

            //Panel - Cantidades - Otros Datos
            this.CBUnidad.SelectedIndex = 0;
            this.CBVentaPublico.SelectedIndex = 0;

            this.PB_Imagen.Image = Properties.Resources.Logo_Leal_Enterprise;

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
            this.TBProveedor.ReadOnly = false;
            this.TBProveedor.BackColor = Color.FromArgb(3, 155, 229);
            this.TBProveedor.Text = Campo;
            this.TBImpuesto.ReadOnly = false;
            this.TBImpuesto.ForeColor = Color.FromArgb(255, 255, 255);
            this.TBImpuesto.Text = Campo;

            this.TBReferencia.ReadOnly = false;
            this.TBReferencia.BackColor = Color.FromArgb(3, 155, 229);
            this.TBPresentacion.ReadOnly = false;
            this.TBPresentacion.BackColor = Color.FromArgb(3, 155, 229);


            //Panel - Valores
            
            this.TBValorCompraMinina.ReadOnly = false;
            this.TBValorCompraMinina.BackColor = Color.FromArgb(3, 155, 229);
            this.TBValorCompraMinina.ForeColor = Color.FromArgb(255, 255, 255);
            this.TBValorCompraMinina.Text = Numerico;
            this.TBValorCompraMaxima.ReadOnly = false;
            this.TBValorCompraMaxima.BackColor = Color.FromArgb(3, 155, 229);
            this.TBValorCompraMaxima.ForeColor = Color.FromArgb(255, 255, 255);
            this.TBValorCompraMaxima.Text = Numerico;
            this.TBValor01.ReadOnly = false;
            this.TBValor01.BackColor = Color.FromArgb(3, 155, 229);
            this.TBValor01.ForeColor = Color.FromArgb(255, 255, 255);
            this.TBValor01.Text = Numerico;
            this.TBValor02.ReadOnly = false;
            this.TBValor02.BackColor = Color.FromArgb(3, 155, 229);
            this.TBValor02.ForeColor = Color.FromArgb(255, 255, 255);
            this.TBValor02.Text = Numerico;
            this.TBOferta01.ReadOnly = false;
            this.TBOferta01.BackColor = Color.FromArgb(3, 155, 229);
            this.TBOferta01.ForeColor = Color.FromArgb(255, 255, 255);
            this.TBOferta01.Text = Numerico;
            this.TBOferta02.ReadOnly = false;
            this.TBOferta02.BackColor = Color.FromArgb(3, 155, 229);
            this.TBOferta02.ForeColor = Color.FromArgb(255, 255, 255);
            this.TBOferta02.Text = Numerico;


            this.TBImpuesto_ValorInicial.ReadOnly = false;
            this.TBImpuesto_ValorInicial.BackColor = Color.FromArgb(72, 209, 204);
            this.TBImpuesto_ValorAuxiliar.ReadOnly = false;
            this.TBImpuesto_ValorAuxiliar.BackColor = Color.FromArgb(72, 209, 204);
            this.TBImpuesto_OfertaInicial.ReadOnly = false;
            this.TBImpuesto_OfertaInicial.BackColor = Color.FromArgb(72, 209, 204);
            this.TBImpuesto_OfertaAuxiliar.ReadOnly = false;
            this.TBImpuesto_OfertaAuxiliar.BackColor = Color.FromArgb(72, 209, 204);

            this.TBCantidadCompraMinima.ReadOnly = false;
            this.TBCantidadCompraMinima.BackColor = Color.FromArgb(3, 155, 229);
            this.TBCantidadCompraMinima.ForeColor = Color.FromArgb(255, 255, 255);
            this.TBCantidadCompraMinima.Text = Numerico;
            this.TBCantidadCompraMaxima.ReadOnly = false;
            this.TBCantidadCompraMaxima.BackColor = Color.FromArgb(3, 155, 229);
            this.TBCantidadCompraMaxima.ForeColor = Color.FromArgb(255, 255, 255);
            this.TBCantidadCompraMaxima.Text = Numerico;

            this.TBCantidadMininaCliente.ReadOnly = false;
            this.TBCantidadMininaCliente.BackColor = Color.FromArgb(3, 155, 229);
            this.TBCantidadMininaCliente.ForeColor = Color.FromArgb(255, 255, 255);
            this.TBCantidadMininaCliente.Text = Numerico;
            this.TBCantidadMaximaCliente.ReadOnly = false;
            this.TBCantidadMaximaCliente.BackColor = Color.FromArgb(3, 155, 229);
            this.TBCantidadMaximaCliente.ForeColor = Color.FromArgb(255, 255, 255);
            this.TBCantidadMaximaCliente.Text = Numerico;

            //Panel - Ubicacion
            this.TBUbicacion.ReadOnly = false;
            this.TBUbicacion.BackColor = Color.FromArgb(3, 155, 229);
            this.TBEstante.ReadOnly = false;
            this.TBEstante.BackColor = Color.FromArgb(3, 155, 229);
            this.TBNivel.ReadOnly = false;
            this.TBNivel.BackColor = Color.FromArgb(3, 155, 229);

            //Panel - Lote

            this.TBLotedeingreso.ReadOnly = false;
            this.TBLotedeingreso.BackColor = Color.FromArgb(3, 155, 229);
            this.TBValor_Lote.ReadOnly = false;
            this.TBValor_Lote.BackColor = Color.FromArgb(3, 155, 229);
            
            //Panel - Codigo de Barra

            this.TBCodigodeBarra.ReadOnly = false;
            this.TBCodigodeBarra.BackColor = Color.FromArgb(3, 155, 229);
            
            //Texboxt de Consulta
            this.TBBuscar.BackColor = Color.FromArgb(3, 155, 229);
        }

        private void Limpiar_Datos()
        {
            if (!Digitar)
            {
                //Panel - Datos Basicos

                this.TBIdproducto.Clear();

                this.TBCodigo.Clear();
                this.TBCodigo.Text = Campo;
                this.TBNombre.Clear();
                this.TBNombre.Text = Campo;
                this.TBDescripcion01.Clear();
                this.TBDescripcion01.Text = Campo;
                this.TBPresentacion.Clear();
                this.TBPresentacion.Text = Campo;
                this.TBReferencia.Clear();
                this.TBLotedeingreso.Clear();
                this.CBMarca.SelectedIndex = 0;
                this.CBGrupo.SelectedIndex = 0;
                this.CBTipo.SelectedIndex = 0;
                this.CBEmpaque.SelectedIndex = 0;

                //Panel - Valores
                this.CBProductosOfertable.Checked = false;
                this.CBVentaPublico.SelectedIndex = 0;

                this.TBValorCompraMinina.Text = Numerico;
                this.TBValorCompraMaxima.Text = Numerico;
                this.TBValor01.Text = Numerico;
                this.TBValor02.Text = Numerico;
                this.TBOferta01.Text = Numerico;
                this.TBOferta02.Text = Numerico;

                //Panel Ubicacion - Imagen
                this.CBBodega.SelectedIndex = 0;
                this.TBUbicacion.Clear();
                this.TBEstante.Clear();
                this.TBNivel.Clear();

                //Panel - Cantidades - Otros Datos
                this.CBUnidad.SelectedIndex = 0;
                //this.CBProveedor.SelectedIndex = 0;
                //this.CBImpuesto.SelectedIndex = 0;
                //this.CBPesoUnidad.SelectedIndex = 0;

                this.TBCantidadCompraMinima.Text = Numerico;
                this.TBCantidadCompraMaxima.Text = Numerico;
                this.TBCantidadMininaCliente.Text = Numerico;
                this.TBCantidadMaximaCliente.Text = Numerico;
                //this.TBPeso.Text = Numerico;

                //Se habilitan los botones a su estado por DEFAULT
                this.Digitar = true;
                this.Botones();
                this.Habilitar();
                this.PB_Imagen.BackgroundImage = Properties.Resources.Logo_Leal_Enterprise;

                //Se realiza el FOCUS al panel y campo de texto iniciales
                this.TBNombre.Focus();
                this.TCPrincipal.SelectedIndex = 0;
            }
        }

        private void Botones()
        {
            if (Digitar)
            {
                ////El boton btnGuardar Mantendra su imagen original
                //this.btnGuardar.Enabled = true;
                this.btnGuardar.Image = Properties.Resources.BV_Guardar;

                this.btnEliminar.Enabled = false;
                this.btnCancelar.Enabled = false;
                this.btnImprimir.Enabled = false;
            }
            else if (!Digitar)
            {
                ////El boton btnGuardar cambiara su imagen original de Guardar a Editar
                //this.btnGuardar.Enabled = true;
                this.btnGuardar.Image = Properties.Resources.BV_Editar;

                this.btnEliminar.Enabled = false;
                this.btnCancelar.Enabled = true;
                this.btnImprimir.Enabled = false;
            }
        }

        private void AutoCompletar_Combobox()
        {
            try
            {
                this.CBEmpaque.DataSource = fEmpaque.Lista();
                this.CBEmpaque.ValueMember = "Codigo";
                this.CBEmpaque.DisplayMember = "Empaque";

                this.CBBodega.DataSource = fBodega.Lista();
                this.CBBodega.ValueMember = "Codigo";
                this.CBBodega.DisplayMember = "Bodega";

                this.CBGrupo.DataSource = fGrupo.Lista();
                this.CBGrupo.ValueMember = "Codigo";
                this.CBGrupo.DisplayMember = "Grupo";

                this.CBMarca.DataSource = fMarca.Lista();
                this.CBMarca.ValueMember = "Codigo";
                this.CBMarca.DisplayMember = "Marca";

                this.CBTipo.DataSource = fTipoDeProducto.Lista();
                this.CBTipo.ValueMember = "Codigo";
                this.CBTipo.DisplayMember = "Tipo";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Vacio_SQL()
        {
            //Validaciones de Campos Numericos, Los cuales se deben guardar como vacio en la Base de Datos
            //Para que no se guarden con el Texto "Campo Numerico - Leal Enterprise" el cual le indica al operador
            //que dicho campo de texto solo acepta valores numericos

            if (TBValorCompraMinina.Text == Numerico)
            {
                this.TBValorCompraMinina.Text = Vacio;
            }
            else if (TBValorCompraMaxima.Text == Numerico)
            {
                this.TBValorCompraMaxima.Text = Vacio;
            }
            else if (TBValor01.Text == Numerico)
            {
                this.TBValor01.Text = Vacio;
            }
            else if (TBValor02.Text == Numerico)
            {
                this.TBValor02.Text = Vacio;
            }
            else if (TBOferta01.Text == Numerico)
            {
                this.TBOferta01.Text = Vacio;
            }
            else if (TBOferta02.Text == Numerico)
            {
                this.TBOferta02.Text = Vacio;
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

                else if (this.CBGrupo.SelectedIndex == 0)
                {
                    MensajeError("Seleccione el Grupo al cual pertenece el Producto");
                }

                // <<<<<<------ Panel Ubicaciones ------>>>>>

                else if (this.CBBodega.SelectedIndex == 0)
                {
                    MensajeError("Seleccione la Bodega donde se Ubicara el Producto");
                }

                // <<<<<<------ Panel Valores ------>>>>>

                else if (this.CBProductosOfertable.Checked == false)
                {
                    MensajeError("Por favor Seleccione si el Producto contine valores de Oferta al Publico");
                    this.TCPrincipal.SelectedIndex = 1;
                }

                else if (this.CBVentaPublico.SelectedIndex == 0)
                {
                    MensajeError("Por favor Seleccione el valor de Venta Final al Publico");
                    this.TCPrincipal.SelectedIndex = 1;
                }

                else
                {
                    //Parametros para poder guardar la imagen del producto

                    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                    this.PB_Imagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    //this.PB_Imagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);

                    byte[] Imagen_Producto = ms.GetBuffer();


                    this.Vacio_SQL();

                    if (this.Digitar)
                    {
                        //rptaDatosBasicos = fProductos.Guardar_DatosBasicos

                        //    (
                        //         //Datos Auxiliares
                        //         Convert.ToInt32(this.CBMarca.SelectedValue), Convert.ToInt32(this.CBBodega.SelectedValue), Convert.ToInt32(this.CBProveedor.SelectedValue),
                        //         Convert.ToInt32(this.CBImpuesto.SelectedValue),

                        //         //Panel Datos Basicos
                        //         this.TBCodigo.Text, this.TBNombre.Text, this.TBReferencia.Text, this.TBDescripcion01.Text, this.TBLotedeingreso.Text, this.TBPresentacion.Text,
                        //         this.CBOfertable.Text, Valores, this.TBValorCompraMinina.Text, this.TBValorCompraMaxima.Text,
                        //         this.TBValor01.Text, this.TBValor02.Text, this.TBValor03.Text, this.TBOferta01.Text, this.TBOferta02.Text, this.TBOferta03.Text,
                        //         //
                        //         this.TBUbicacion.Text, this.TBEstante.Text, this.TBNivel.Text, Imagen_Producto, this.TBCantidadMinima.Text, this.TBCantidadMaxima.Text, this.TBCantidadMininaCliente.Text,
                        //         this.TBCantidadMaximaCliente.Text, this.CBVence.Text, this.DTFechadevencimiento.Value, this.CBUnidad.Text, this.CBPesoUnidad.Text, this.TBPeso.Text,
                        //         Convert.ToInt32(this.CBOrigen.SelectedValue), Convert.ToInt32(this.CBGrupo.SelectedValue), Convert.ToInt32(CBTipo.SelectedValue), Convert.ToInt32(this.CBEmpaque.SelectedValue),

                        //         //
                        //         1
                        //    );
                    }

                    else
                    {
                        //rptaDatosBasicos = fProductos.Editar_DatosBasicos

                        //    (
                        //         ////Datos Auxiliares
                        //         //Convert.ToInt32(this.TBIdproducto.Text), Convert.ToInt32(this.CBMarca.SelectedValue), Convert.ToInt32(this.CBBodega.SelectedValue), Convert.ToInt32(this.CBProveedor.SelectedValue),
                        //         //Convert.ToInt32(this.CBImpuesto.SelectedValue),

                        //         ////Panel Datos Basicos
                        //         //this.TBCodigo.Text, this.TBNombre.Text, this.TBReferencia.Text, this.TBDescripcion01.Text, this.TBLotedeingreso.Text, this.TBPresentacion.Text,
                        //         //this.CBOfertable.Text, Valores, this.TBValorCompraMinina.Text, this.TBValorCompraMaxima.Text,
                        //         //this.TBValor01.Text, this.TBValor02.Text, this.TBValor03.Text, this.TBOferta01.Text, this.TBOferta02.Text, this.TBOferta03.Text,

                        //         ////
                        //         //this.TBUbicacion.Text, this.TBEstante.Text, this.TBNivel.Text, Imagen_Producto, this.TBCantidadMinima.Text, this.TBCantidadMaxima.Text, this.TBCantidadMininaCliente.Text,
                        //         //this.TBCantidadMaximaCliente.Text, this.CBVence.Text, this.DTFechadevencimiento.Value, this.CBUnidad.Text, this.CBPesoUnidad.Text, this.TBPeso.Text,
                        //         //Convert.ToInt32(this.CBOrigen.SelectedValue), Convert.ToInt32(this.CBGrupo.SelectedValue), Convert.ToInt32(CBTipo.SelectedValue), Convert.ToInt32(this.CBEmpaque.SelectedValue),

                        //         ////
                        //         //2
                        //    );
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
            try
            {
                if (Digitar)
                {
                    if (Guardar == "1")
                    {
                        //Metodo Guardar y editar
                        this.Guardar_SQL();
                    }

                    else
                    {
                        MessageBox.Show("El Usuario Iniciado Actualmente no Contiene Permisos Para Guardar Datos", "Leal Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        //Llamada de Clase
                        this.Digitar = false;
                        this.Limpiar_Datos();
                    }
                }

                else
                {
                    if (Editar == "1")
                    {
                        //Metodo Guardar y editar
                        this.Guardar_SQL();
                    }
                    else
                    {
                        MessageBox.Show("El Usuario Iniciado Actualmente no Contiene Permisos Para Editar Datos", "Leal Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        //Llamada de Clase
                        this.Digitar = false;
                        this.Limpiar_Datos();
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Digitar = false;
                this.Limpiar_Datos();
                this.TBBuscar.Clear();

                //Se Limpian las Filas y Columnas de la tabla
                this.DGResultados.DataSource = null;
                this.DGResultados.Enabled = false;
                this.lblTotal.Text = "Datos Registrados: 0";

                //Se restablece la imagen predeterminada del boton
                //this.btnGuardar.Image = Properties.Resources.BV_Guardar;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void CBVentaPublico_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBVentaPublico.SelectedIndex == 1)
            {
                Valores = this.TBValor01.Text;
            }
            else if (CBVentaPublico.SelectedIndex == 2)
            {
                Valores = this.TBValor02.Text;
            }
            else if (CBVentaPublico.SelectedIndex == 3)
            {
                Valores = this.TBOferta01.Text;
            }
            else if (CBVentaPublico.SelectedIndex == 4)
            {
                Valores = this.TBOferta02.Text;
            }
        }

        private void TBCodigo_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar la tecla Enter se realiza Focus al Texboxt Siguiente

                    this.TBNombre.Select();
                }

                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Tab))
                {
                    //Al precionar la tecla Control+TAB Se cambia al campo de Texto TBBuscar
                    //Para realizar consultas en el sistema Y se realiza Focus al primer Texboxt

                    this.TCPrincipal.SelectedIndex = 1;
                    this.TBValorCompraMinina.Select();
                }
                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar las teclas Control+Enter se realizara el registro en la base de datos
                    //Y se realizara las validaciones en el sistema

                    if (Digitar)
                    {
                        DialogResult result = MessageBox.Show("¿Desea registrar los campos digitados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            if (Guardar == "1")
                            {
                                //Llamada de Clase
                                this.Guardar_SQL();
                            }
                            else
                            {
                                MessageBox.Show("El usuario iniciado no contiene permisos para Guardar datos en el sistema", "Leal Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                //Al realizar la validacion en la base de datos y encontrar que no hay acceso a al operacion solicitada
                                //se procede limpiar los campos de texto y habilitaciond de los botones a su estado por DEFECTO.
                                this.Digitar = false;
                                this.Limpiar_Datos();
                            }
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBCodigo.Select();
                        }
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("¿Desea Actualizar los campos consultados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            //Llamada de Clase
                            this.Digitar = false;
                            this.Guardar_SQL();
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBCodigo.Select();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void TBNombre_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar la tecla Enter se realiza Focus al Texboxt Siguiente

                    this.TBReferencia.Select();
                }

                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Tab))
                {
                    //Al precionar la tecla Control+TAB Se cambia al campo de Texto TBBuscar
                    //Para realizar consultas en el sistema Y se realiza Focus al primer Texboxt

                    this.TCPrincipal.SelectedIndex = 1;
                    this.TBValorCompraMinina.Select();
                }
                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar las teclas Control+Enter se realizara el registro en la base de datos
                    //Y se realizara las validaciones en el sistema

                    if (Digitar)
                    {
                        DialogResult result = MessageBox.Show("¿Desea registrar los campos digitados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            if (Guardar == "1")
                            {
                                //Llamada de Clase
                                this.Guardar_SQL();
                            }
                            else
                            {
                                MessageBox.Show("El usuario iniciado no contiene permisos para Guardar datos en el sistema", "Leal Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                //Al realizar la validacion en la base de datos y encontrar que no hay acceso a al operacion solicitada
                                //se procede limpiar los campos de texto y habilitaciond de los botones a su estado por DEFECTO.
                                this.Digitar = false;
                                this.Limpiar_Datos();
                            }
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBNombre.Select();
                        }
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("¿Desea Actualizar los campos consultados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            //Llamada de Clase
                            this.Digitar = false;
                            this.Guardar_SQL();
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBNombre.Select();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void TBReferencia_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar la tecla Enter se realiza Focus al Texboxt Siguiente

                    this.TBDescripcion01.Select();
                }

                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Tab))
                {
                    //Al precionar la tecla Control+TAB Se cambia al campo de Texto TBBuscar
                    //Para realizar consultas en el sistema Y se realiza Focus al primer Texboxt

                    this.TCPrincipal.SelectedIndex = 1;
                    this.TBValorCompraMinina.Select();
                }
                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar las teclas Control+Enter se realizara el registro en la base de datos
                    //Y se realizara las validaciones en el sistema

                    if (Digitar)
                    {
                        DialogResult result = MessageBox.Show("¿Desea registrar los campos digitados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            if (Guardar == "1")
                            {
                                //Llamada de Clase
                                this.Guardar_SQL();
                            }
                            else
                            {
                                MessageBox.Show("El usuario iniciado no contiene permisos para Guardar datos en el sistema", "Leal Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                //Al realizar la validacion en la base de datos y encontrar que no hay acceso a al operacion solicitada
                                //se procede limpiar los campos de texto y habilitaciond de los botones a su estado por DEFECTO.
                                this.Digitar = false;
                                this.Limpiar_Datos();
                            }
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBReferencia.Select();
                        }
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("¿Desea Actualizar los campos consultados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            //Llamada de Clase
                            this.Digitar = false;
                            this.Guardar_SQL();
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBReferencia.Select();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void TBDescripcion01_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar la tecla Enter se realiza Focus al Texboxt Siguiente

                    this.TBLotedeingreso.Select();
                }

                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Tab))
                {
                    //Al precionar la tecla Control+TAB Se cambia al campo de Texto TBBuscar
                    //Para realizar consultas en el sistema Y se realiza Focus al primer Texboxt

                    this.TCPrincipal.SelectedIndex = 1;
                    this.TBValorCompraMinina.Select();
                }
                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar las teclas Control+Enter se realizara el registro en la base de datos
                    //Y se realizara las validaciones en el sistema

                    if (Digitar)
                    {
                        DialogResult result = MessageBox.Show("¿Desea registrar los campos digitados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            if (Guardar == "1")
                            {
                                //Llamada de Clase
                                this.Guardar_SQL();
                            }
                            else
                            {
                                MessageBox.Show("El usuario iniciado no contiene permisos para Guardar datos en el sistema", "Leal Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                //Al realizar la validacion en la base de datos y encontrar que no hay acceso a al operacion solicitada
                                //se procede limpiar los campos de texto y habilitaciond de los botones a su estado por DEFECTO.
                                this.Digitar = false;
                                this.Limpiar_Datos();
                            }
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBDescripcion01.Select();
                        }
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("¿Desea Actualizar los campos consultados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            //Llamada de Clase
                            this.Digitar = false;
                            this.Guardar_SQL();
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBDescripcion01.Select();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void TBLotedeingreso_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar la tecla Enter se realiza Focus al Texboxt Siguiente

                    this.TBPresentacion.Select();
                }

                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Tab))
                {
                    //Al precionar la tecla Control+TAB Se cambia al campo de Texto TBBuscar
                    //Para realizar consultas en el sistema Y se realiza Focus al primer Texboxt

                    this.TCPrincipal.SelectedIndex = 1;
                    this.TBValorCompraMinina.Select();
                }
                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar las teclas Control+Enter se realizara el registro en la base de datos
                    //Y se realizara las validaciones en el sistema

                    if (Digitar)
                    {
                        DialogResult result = MessageBox.Show("¿Desea registrar los campos digitados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            if (Guardar == "1")
                            {
                                //Llamada de Clase
                                this.Guardar_SQL();
                            }
                            else
                            {
                                MessageBox.Show("El usuario iniciado no contiene permisos para Guardar datos en el sistema", "Leal Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                //Al realizar la validacion en la base de datos y encontrar que no hay acceso a al operacion solicitada
                                //se procede limpiar los campos de texto y habilitaciond de los botones a su estado por DEFECTO.
                                this.Digitar = false;
                                this.Limpiar_Datos();
                            }
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBLotedeingreso.Select();
                        }
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("¿Desea Actualizar los campos consultados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            //Llamada de Clase
                            this.Digitar = false;
                            this.Guardar_SQL();
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBLotedeingreso.Select();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void TBPresentacion_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar la tecla Enter se realiza Focus al Texboxt Siguiente

                    this.TBNombre.Select();
                }

                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Tab))
                {
                    //Al precionar la tecla Control+TAB Se cambia al campo de Texto TBBuscar
                    //Para realizar consultas en el sistema Y se realiza Focus al primer Texboxt

                    this.TCPrincipal.SelectedIndex = 1;
                    this.TBValorCompraMinina.Select();
                }
                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar las teclas Control+Enter se realizara el registro en la base de datos
                    //Y se realizara las validaciones en el sistema

                    if (Digitar)
                    {
                        DialogResult result = MessageBox.Show("¿Desea registrar los campos digitados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            if (Guardar == "1")
                            {
                                //Llamada de Clase
                                this.Guardar_SQL();
                            }
                            else
                            {
                                MessageBox.Show("El usuario iniciado no contiene permisos para Guardar datos en el sistema", "Leal Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                //Al realizar la validacion en la base de datos y encontrar que no hay acceso a al operacion solicitada
                                //se procede limpiar los campos de texto y habilitaciond de los botones a su estado por DEFECTO.
                                this.Digitar = false;
                                this.Limpiar_Datos();
                            }
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBPresentacion.Select();
                        }
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("¿Desea Actualizar los campos consultados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            //Llamada de Clase
                            this.Digitar = false;
                            this.Guardar_SQL();
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBPresentacion.Select();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void TBValorCompraMinina_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar la tecla Enter se realiza Focus al Texboxt Siguiente

                    this.TBValorCompraMaxima.Select();
                }

                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Tab))
                {
                    //Al precionar la tecla Control+TAB Se cambia al campo de Texto TBBuscar
                    //Para realizar consultas en el sistema Y se realiza Focus al primer Texboxt

                    this.TCPrincipal.SelectedIndex = 2;
                    this.TBUbicacion.Select();
                }
                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar las teclas Control+Enter se realizara el registro en la base de datos
                    //Y se realizara las validaciones en el sistema

                    if (Digitar)
                    {
                        DialogResult result = MessageBox.Show("¿Desea registrar los campos digitados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            if (Guardar == "1")
                            {
                                //Llamada de Clase
                                this.Guardar_SQL();
                            }
                            else
                            {
                                MessageBox.Show("El usuario iniciado no contiene permisos para Guardar datos en el sistema", "Leal Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                //Al realizar la validacion en la base de datos y encontrar que no hay acceso a al operacion solicitada
                                //se procede limpiar los campos de texto y habilitaciond de los botones a su estado por DEFECTO.
                                this.Digitar = false;
                                this.Limpiar_Datos();
                            }
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBValorCompraMinina.Select();
                        }
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("¿Desea Actualizar los campos consultados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            //Llamada de Clase
                            this.Digitar = false;
                            this.Guardar_SQL();
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBValorCompraMinina.Select();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void TBValorCompraMaxima_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar la tecla Enter se realiza Focus al Texboxt Siguiente

                    this.TBValor01.Select();
                }

                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Tab))
                {
                    //Al precionar la tecla Control+TAB Se cambia al campo de Texto TBBuscar
                    //Para realizar consultas en el sistema Y se realiza Focus al primer Texboxt

                    this.TCPrincipal.SelectedIndex = 2;
                    this.TBUbicacion.Select();
                }
                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar las teclas Control+Enter se realizara el registro en la base de datos
                    //Y se realizara las validaciones en el sistema

                    if (Digitar)
                    {
                        DialogResult result = MessageBox.Show("¿Desea registrar los campos digitados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            if (Guardar == "1")
                            {
                                //Llamada de Clase
                                this.Guardar_SQL();
                            }
                            else
                            {
                                MessageBox.Show("El usuario iniciado no contiene permisos para Guardar datos en el sistema", "Leal Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                //Al realizar la validacion en la base de datos y encontrar que no hay acceso a al operacion solicitada
                                //se procede limpiar los campos de texto y habilitaciond de los botones a su estado por DEFECTO.
                                this.Digitar = false;
                                this.Limpiar_Datos();
                            }
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBValorCompraMaxima.Select();
                        }
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("¿Desea Actualizar los campos consultados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            //Llamada de Clase
                            this.Digitar = false;
                            this.Guardar_SQL();
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBValorCompraMaxima.Select();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void TBValor01_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar la tecla Enter se realiza Focus al Texboxt Siguiente

                    this.TBValor02.Select();
                }

                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Tab))
                {
                    //Al precionar la tecla Control+TAB Se cambia al campo de Texto TBBuscar
                    //Para realizar consultas en el sistema Y se realiza Focus al primer Texboxt

                    this.TCPrincipal.SelectedIndex = 2;
                    this.TBUbicacion.Select();
                }
                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar las teclas Control+Enter se realizara el registro en la base de datos
                    //Y se realizara las validaciones en el sistema

                    if (Digitar)
                    {
                        DialogResult result = MessageBox.Show("¿Desea registrar los campos digitados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            if (Guardar == "1")
                            {
                                //Llamada de Clase
                                this.Guardar_SQL();
                            }
                            else
                            {
                                MessageBox.Show("El usuario iniciado no contiene permisos para Guardar datos en el sistema", "Leal Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                //Al realizar la validacion en la base de datos y encontrar que no hay acceso a al operacion solicitada
                                //se procede limpiar los campos de texto y habilitaciond de los botones a su estado por DEFECTO.
                                this.Digitar = false;
                                this.Limpiar_Datos();
                            }
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBValor01.Select();
                        }
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("¿Desea Actualizar los campos consultados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            //Llamada de Clase
                            this.Digitar = false;
                            this.Guardar_SQL();
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBValor01.Select();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void TBValor02_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar la tecla Enter se realiza Focus al Texboxt Siguiente

                    //this.TBValor03.Select();
                }

                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Tab))
                {
                    //Al precionar la tecla Control+TAB Se cambia al campo de Texto TBBuscar
                    //Para realizar consultas en el sistema Y se realiza Focus al primer Texboxt

                    this.TCPrincipal.SelectedIndex = 2;
                    this.TBUbicacion.Select();
                }
                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar las teclas Control+Enter se realizara el registro en la base de datos
                    //Y se realizara las validaciones en el sistema

                    if (Digitar)
                    {
                        DialogResult result = MessageBox.Show("¿Desea registrar los campos digitados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            if (Guardar == "1")
                            {
                                //Llamada de Clase
                                this.Guardar_SQL();
                            }
                            else
                            {
                                MessageBox.Show("El usuario iniciado no contiene permisos para Guardar datos en el sistema", "Leal Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                //Al realizar la validacion en la base de datos y encontrar que no hay acceso a al operacion solicitada
                                //se procede limpiar los campos de texto y habilitaciond de los botones a su estado por DEFECTO.
                                this.Digitar = false;
                                this.Limpiar_Datos();
                            }
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBValor02.Select();
                        }
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("¿Desea Actualizar los campos consultados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            //Llamada de Clase
                            this.Digitar = false;
                            this.Guardar_SQL();
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBValor02.Select();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void TBValor03_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar la tecla Enter se realiza Focus al Texboxt Siguiente

                    this.TBOferta01.Select();
                }

                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Tab))
                {
                    //Al precionar la tecla Control+TAB Se cambia al campo de Texto TBBuscar
                    //Para realizar consultas en el sistema Y se realiza Focus al primer Texboxt

                    this.TCPrincipal.SelectedIndex = 2;
                    this.TBUbicacion.Select();
                }
                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar las teclas Control+Enter se realizara el registro en la base de datos
                    //Y se realizara las validaciones en el sistema

                    if (Digitar)
                    {
                        DialogResult result = MessageBox.Show("¿Desea registrar los campos digitados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            if (Guardar == "1")
                            {
                                //Llamada de Clase
                                this.Guardar_SQL();
                            }
                            else
                            {
                                MessageBox.Show("El usuario iniciado no contiene permisos para Guardar datos en el sistema", "Leal Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                //Al realizar la validacion en la base de datos y encontrar que no hay acceso a al operacion solicitada
                                //se procede limpiar los campos de texto y habilitaciond de los botones a su estado por DEFECTO.
                                this.Digitar = false;
                                this.Limpiar_Datos();
                            }
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            //this.TBValor03.Select();
                        }
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("¿Desea Actualizar los campos consultados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            //Llamada de Clase
                            this.Digitar = false;
                            this.Guardar_SQL();
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            //this.TBValor03.Select();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void TBOferta01_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar la tecla Enter se realiza Focus al Texboxt Siguiente

                    this.TBOferta02.Select();
                }

                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Tab))
                {
                    //Al precionar la tecla Control+TAB Se cambia al campo de Texto TBBuscar
                    //Para realizar consultas en el sistema Y se realiza Focus al primer Texboxt

                    this.TCPrincipal.SelectedIndex = 2;
                    this.TBUbicacion.Select();
                }
                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar las teclas Control+Enter se realizara el registro en la base de datos
                    //Y se realizara las validaciones en el sistema

                    if (Digitar)
                    {
                        DialogResult result = MessageBox.Show("¿Desea registrar los campos digitados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            if (Guardar == "1")
                            {
                                //Llamada de Clase
                                this.Guardar_SQL();
                            }
                            else
                            {
                                MessageBox.Show("El usuario iniciado no contiene permisos para Guardar datos en el sistema", "Leal Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                //Al realizar la validacion en la base de datos y encontrar que no hay acceso a al operacion solicitada
                                //se procede limpiar los campos de texto y habilitaciond de los botones a su estado por DEFECTO.
                                this.Digitar = false;
                                this.Limpiar_Datos();
                            }
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBOferta01.Select();
                        }
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("¿Desea Actualizar los campos consultados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            //Llamada de Clase
                            this.Digitar = false;
                            this.Guardar_SQL();
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBOferta01.Select();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void TBOferta02_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar la tecla Enter se realiza Focus al Texboxt Siguiente

                    //this.TBOferta03.Select();
                }

                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Tab))
                {
                    //Al precionar la tecla Control+TAB Se cambia al campo de Texto TBBuscar
                    //Para realizar consultas en el sistema Y se realiza Focus al primer Texboxt

                    this.TCPrincipal.SelectedIndex = 2;
                    this.TBUbicacion.Select();
                }
                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar las teclas Control+Enter se realizara el registro en la base de datos
                    //Y se realizara las validaciones en el sistema

                    if (Digitar)
                    {
                        DialogResult result = MessageBox.Show("¿Desea registrar los campos digitados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            if (Guardar == "1")
                            {
                                //Llamada de Clase
                                this.Guardar_SQL();
                            }
                            else
                            {
                                MessageBox.Show("El usuario iniciado no contiene permisos para Guardar datos en el sistema", "Leal Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                //Al realizar la validacion en la base de datos y encontrar que no hay acceso a al operacion solicitada
                                //se procede limpiar los campos de texto y habilitaciond de los botones a su estado por DEFECTO.
                                this.Digitar = false;
                                this.Limpiar_Datos();
                            }
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBOferta02.Select();
                        }
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("¿Desea Actualizar los campos consultados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            //Llamada de Clase
                            this.Digitar = false;
                            this.Guardar_SQL();
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBOferta02.Select();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void TBOferta03_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar la tecla Enter se realiza Focus al Texboxt Siguiente

                    this.TBValorCompraMinina.Select();
                }

                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Tab))
                {
                    //Al precionar la tecla Control+TAB Se cambia al campo de Texto TBBuscar
                    //Para realizar consultas en el sistema Y se realiza Focus al primer Texboxt

                    this.TCPrincipal.SelectedIndex = 2;
                    this.TBUbicacion.Select();
                }
                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar las teclas Control+Enter se realizara el registro en la base de datos
                    //Y se realizara las validaciones en el sistema

                    if (Digitar)
                    {
                        DialogResult result = MessageBox.Show("¿Desea registrar los campos digitados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            if (Guardar == "1")
                            {
                                //Llamada de Clase
                                this.Guardar_SQL();
                            }
                            else
                            {
                                MessageBox.Show("El usuario iniciado no contiene permisos para Guardar datos en el sistema", "Leal Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                //Al realizar la validacion en la base de datos y encontrar que no hay acceso a al operacion solicitada
                                //se procede limpiar los campos de texto y habilitaciond de los botones a su estado por DEFECTO.
                                this.Digitar = false;
                                this.Limpiar_Datos();
                            }
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            //this.TBOferta03.Select();
                        }
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("¿Desea Actualizar los campos consultados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            //Llamada de Clase
                            this.Digitar = false;
                            this.Guardar_SQL();
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            //this.TBOferta03.Select();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void TBUbicacion_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar la tecla Enter se realiza Focus al Texboxt Siguiente

                    this.TBEstante.Select();
                }

                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Tab))
                {
                    //Al precionar la tecla Control+TAB Se cambia al campo de Texto TBBuscar
                    //Para realizar consultas en el sistema Y se realiza Focus al primer Texboxt

                    this.TCPrincipal.SelectedIndex = 3;
                    this.TBCantidadCompraMinima.Select();
                }
                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar las teclas Control+Enter se realizara el registro en la base de datos
                    //Y se realizara las validaciones en el sistema

                    if (Digitar)
                    {
                        DialogResult result = MessageBox.Show("¿Desea registrar los campos digitados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            if (Guardar == "1")
                            {
                                //Llamada de Clase
                                this.Guardar_SQL();
                            }
                            else
                            {
                                MessageBox.Show("El usuario iniciado no contiene permisos para Guardar datos en el sistema", "Leal Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                //Al realizar la validacion en la base de datos y encontrar que no hay acceso a al operacion solicitada
                                //se procede limpiar los campos de texto y habilitaciond de los botones a su estado por DEFECTO.
                                this.Digitar = false;
                                this.Limpiar_Datos();
                            }
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBUbicacion.Select();
                        }
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("¿Desea Actualizar los campos consultados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            //Llamada de Clase
                            this.Digitar = false;
                            this.Guardar_SQL();
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBUbicacion.Select();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void TBEstante_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar la tecla Enter se realiza Focus al Texboxt Siguiente

                    this.TBNivel.Select();
                }

                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Tab))
                {
                    //Al precionar la tecla Control+TAB Se cambia al campo de Texto TBBuscar
                    //Para realizar consultas en el sistema Y se realiza Focus al primer Texboxt

                    this.TCPrincipal.SelectedIndex = 3;
                    this.TBCantidadCompraMinima.Select();
                }
                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar las teclas Control+Enter se realizara el registro en la base de datos
                    //Y se realizara las validaciones en el sistema

                    if (Digitar)
                    {
                        DialogResult result = MessageBox.Show("¿Desea registrar los campos digitados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            if (Guardar == "1")
                            {
                                //Llamada de Clase
                                this.Guardar_SQL();
                            }
                            else
                            {
                                MessageBox.Show("El usuario iniciado no contiene permisos para Guardar datos en el sistema", "Leal Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                //Al realizar la validacion en la base de datos y encontrar que no hay acceso a al operacion solicitada
                                //se procede limpiar los campos de texto y habilitaciond de los botones a su estado por DEFECTO.
                                this.Digitar = false;
                                this.Limpiar_Datos();
                            }
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBEstante.Select();
                        }
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("¿Desea Actualizar los campos consultados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            //Llamada de Clase
                            this.Digitar = false;
                            this.Guardar_SQL();
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBEstante.Select();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void TBNivel_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar la tecla Enter se realiza Focus al Texboxt Siguiente

                    this.TBUbicacion.Select();
                }

                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Tab))
                {
                    //Al precionar la tecla Control+TAB Se cambia al campo de Texto TBBuscar
                    //Para realizar consultas en el sistema Y se realiza Focus al primer Texboxt

                    this.TCPrincipal.SelectedIndex = 3;
                    this.TBCantidadCompraMinima.Select();
                }
                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar las teclas Control+Enter se realizara el registro en la base de datos
                    //Y se realizara las validaciones en el sistema

                    if (Digitar)
                    {
                        DialogResult result = MessageBox.Show("¿Desea registrar los campos digitados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            if (Guardar == "1")
                            {
                                //Llamada de Clase
                                this.Guardar_SQL();
                            }
                            else
                            {
                                MessageBox.Show("El usuario iniciado no contiene permisos para Guardar datos en el sistema", "Leal Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                //Al realizar la validacion en la base de datos y encontrar que no hay acceso a al operacion solicitada
                                //se procede limpiar los campos de texto y habilitaciond de los botones a su estado por DEFECTO.
                                this.Digitar = false;
                                this.Limpiar_Datos();
                            }
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBNivel.Select();
                        }
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("¿Desea Actualizar los campos consultados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            //Llamada de Clase
                            this.Digitar = false;
                            this.Guardar_SQL();
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBNivel.Select();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void TBCantidadMinima_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar la tecla Enter se realiza Focus al Texboxt Siguiente

                    this.TBCantidadCompraMaxima.Select();
                }

                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Tab))
                {
                    //Al precionar la tecla Control+TAB Se cambia al campo de Texto TBBuscar
                    //Para realizar consultas en el sistema Y se realiza Focus al primer Texboxt

                    this.TCPrincipal.SelectedIndex = 0;
                    this.TBNombre.Select();
                }
                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar las teclas Control+Enter se realizara el registro en la base de datos
                    //Y se realizara las validaciones en el sistema

                    if (Digitar)
                    {
                        DialogResult result = MessageBox.Show("¿Desea registrar los campos digitados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            if (Guardar == "1")
                            {
                                //Llamada de Clase
                                this.Guardar_SQL();
                            }
                            else
                            {
                                MessageBox.Show("El usuario iniciado no contiene permisos para Guardar datos en el sistema", "Leal Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                //Al realizar la validacion en la base de datos y encontrar que no hay acceso a al operacion solicitada
                                //se procede limpiar los campos de texto y habilitaciond de los botones a su estado por DEFECTO.
                                this.Digitar = false;
                                this.Limpiar_Datos();
                            }
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBCantidadCompraMinima.Select();
                        }
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("¿Desea Actualizar los campos consultados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            //Llamada de Clase
                            this.Digitar = false;
                            this.Guardar_SQL();
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBCantidadCompraMinima.Select();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void TBCantidadMaxima_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar la tecla Enter se realiza Focus al Texboxt Siguiente

                    this.TBCantidadMininaCliente.Select();
                }

                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Tab))
                {
                    //Al precionar la tecla Control+TAB Se cambia al campo de Texto TBBuscar
                    //Para realizar consultas en el sistema Y se realiza Focus al primer Texboxt

                    this.TCPrincipal.SelectedIndex = 0;
                    this.TBNombre.Select();
                }
                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar las teclas Control+Enter se realizara el registro en la base de datos
                    //Y se realizara las validaciones en el sistema

                    if (Digitar)
                    {
                        DialogResult result = MessageBox.Show("¿Desea registrar los campos digitados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            if (Guardar == "1")
                            {
                                //Llamada de Clase
                                this.Guardar_SQL();
                            }
                            else
                            {
                                MessageBox.Show("El usuario iniciado no contiene permisos para Guardar datos en el sistema", "Leal Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                //Al realizar la validacion en la base de datos y encontrar que no hay acceso a al operacion solicitada
                                //se procede limpiar los campos de texto y habilitaciond de los botones a su estado por DEFECTO.
                                this.Digitar = false;
                                this.Limpiar_Datos();
                            }
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBCantidadCompraMaxima.Select();
                        }
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("¿Desea Actualizar los campos consultados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            //Llamada de Clase
                            this.Digitar = false;
                            this.Guardar_SQL();
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBCantidadCompraMaxima.Select();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void TBCantidadMininaCliente_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar la tecla Enter se realiza Focus al Texboxt Siguiente

                    this.TBCantidadMaximaCliente.Select();
                }

                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Tab))
                {
                    //Al precionar la tecla Control+TAB Se cambia al campo de Texto TBBuscar
                    //Para realizar consultas en el sistema Y se realiza Focus al primer Texboxt

                    this.TCPrincipal.SelectedIndex = 0;
                    this.TBNombre.Select();
                }
                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar las teclas Control+Enter se realizara el registro en la base de datos
                    //Y se realizara las validaciones en el sistema

                    if (Digitar)
                    {
                        DialogResult result = MessageBox.Show("¿Desea registrar los campos digitados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            if (Guardar == "1")
                            {
                                //Llamada de Clase
                                this.Guardar_SQL();
                            }
                            else
                            {
                                MessageBox.Show("El usuario iniciado no contiene permisos para Guardar datos en el sistema", "Leal Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                //Al realizar la validacion en la base de datos y encontrar que no hay acceso a al operacion solicitada
                                //se procede limpiar los campos de texto y habilitaciond de los botones a su estado por DEFECTO.
                                this.Digitar = false;
                                this.Limpiar_Datos();
                            }
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBCantidadMininaCliente.Select();
                        }
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("¿Desea Actualizar los campos consultados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            //Llamada de Clase
                            this.Digitar = false;
                            this.Guardar_SQL();
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBCantidadMininaCliente.Select();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void TBCantidadMaximaCliente_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar la tecla Enter se realiza Focus al Texboxt Siguiente

                    this.TBCantidadCompraMinima.Select();
                }

                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Tab))
                {
                    //Al precionar la tecla Control+TAB Se cambia al campo de Texto TBBuscar
                    //Para realizar consultas en el sistema Y se realiza Focus al primer Texboxt

                    this.TCPrincipal.SelectedIndex = 0;
                    this.TBNombre.Select();
                }
                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar las teclas Control+Enter se realizara el registro en la base de datos
                    //Y se realizara las validaciones en el sistema

                    if (Digitar)
                    {
                        DialogResult result = MessageBox.Show("¿Desea registrar los campos digitados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            if (Guardar == "1")
                            {
                                //Llamada de Clase
                                this.Guardar_SQL();
                            }
                            else
                            {
                                MessageBox.Show("El usuario iniciado no contiene permisos para Guardar datos en el sistema", "Leal Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                //Al realizar la validacion en la base de datos y encontrar que no hay acceso a al operacion solicitada
                                //se procede limpiar los campos de texto y habilitaciond de los botones a su estado por DEFECTO.
                                this.Digitar = false;
                                this.Limpiar_Datos();
                            }
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBCantidadMaximaCliente.Select();
                        }
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("¿Desea Actualizar los campos consultados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            //Llamada de Clase
                            this.Digitar = false;
                            this.Guardar_SQL();
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBCantidadMaximaCliente.Select();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        //******************** FOCUS ENTER  DATOS BASICOS ********************

        private void TBCodigo_Enter(object sender, EventArgs e)
        {
            //Se evalua si el campo de texto esta vacio y se espeicifca que es obligatorio en la base de datos
            if (TBCodigo.Text == Campo)
            {
                this.TBCodigo.BackColor = Color.Azure;
                this.TBCodigo.ForeColor = Color.FromArgb(0, 0, 0);
                this.TBCodigo.Clear();
            }
            else
            {
                //Color de fondo del Texboxt cuando este tiene el FOCUS Activado
                this.TBCodigo.BackColor = Color.Azure;
                this.TBCodigo.ForeColor = Color.FromArgb(0, 0, 0);
            }
        }

        private void TBNombre_Enter(object sender, EventArgs e)
        {
            //Se evalua si el campo de texto esta vacio y se espeicifca que es obligatorio en la base de datos
            if (TBNombre.Text == Campo)
            {
                this.TBNombre.BackColor = Color.Azure;
                this.TBNombre.ForeColor = Color.FromArgb(0, 0, 0);
                this.TBNombre.Clear();
            }
            else
            {
                //Color de fondo del Texboxt cuando este tiene el FOCUS Activado
                this.TBNombre.BackColor = Color.Azure;
                this.TBNombre.ForeColor = Color.FromArgb(0, 0, 0);
            }
        }

        private void TBReferencia_Enter(object sender, EventArgs e)
        {
            this.TBReferencia.BackColor = Color.Azure;
        }

        private void TBDescripcion01_Enter(object sender, EventArgs e)
        {
            //Se evalua si el campo de texto esta vacio y se espeicifca que es obligatorio en la base de datos
            if (TBDescripcion01.Text == Campo)
            {
                this.TBDescripcion01.BackColor = Color.Azure;
                this.TBDescripcion01.ForeColor = Color.FromArgb(0, 0, 0);
                this.TBDescripcion01.Clear();
            }
            else
            {
                //Color de fondo del Texboxt cuando este tiene el FOCUS Activado
                this.TBDescripcion01.BackColor = Color.Azure;
                this.TBDescripcion01.ForeColor = Color.FromArgb(0, 0, 0);
            }
        }

        private void TBLotedeingreso_Enter(object sender, EventArgs e)
        {
            this.TBLotedeingreso.BackColor = Color.Azure;
        }

        private void TBPresentacion_Enter(object sender, EventArgs e)
        {
            //Se evalua si el campo de texto esta vacio y se espeicifca que es obligatorio en la base de datos
            if (TBPresentacion.Text == Campo)
            {
                this.TBPresentacion.BackColor = Color.Azure;
                this.TBPresentacion.ForeColor = Color.FromArgb(0, 0, 0);
                this.TBPresentacion.Clear();
            }
            else
            {
                //Color de fondo del Texboxt cuando este tiene el FOCUS Activado
                this.TBPresentacion.BackColor = Color.Azure;
                this.TBPresentacion.ForeColor = Color.FromArgb(0, 0, 0);
            }
        }

        private void TBProveedor_Enter(object sender, EventArgs e)
        {

        }

        private void TBImpuesto_Enter(object sender, EventArgs e)
        {

        }


        //******************** FOCUS ENTER Valores ********************

        private void TBValorCompraMinina_Enter(object sender, EventArgs e)
        {
            //Se evalua si el campo de texto esta vacio y se espeicifca que es obligatorio en la base de datos
            if (TBValorCompraMinina.Text == Numerico)
            {
                this.TBValorCompraMinina.BackColor = Color.Azure;
                this.TBValorCompraMinina.ForeColor = Color.FromArgb(0, 0, 0);
                this.TBValorCompraMinina.Clear();
            }
            else
            {
                //Color de fondo del Texboxt cuando este tiene el FOCUS Activado
                this.TBValorCompraMinina.BackColor = Color.Azure;
                this.TBValorCompraMinina.ForeColor = Color.FromArgb(0, 0, 0);
            }
        }

        private void TBValorCompraMaxima_Enter(object sender, EventArgs e)
        {
            //Se evalua si el campo de texto esta vacio y se espeicifca que es obligatorio en la base de datos
            if (TBValorCompraMaxima.Text == Numerico)
            {
                this.TBValorCompraMaxima.BackColor = Color.Azure;
                this.TBValorCompraMaxima.ForeColor = Color.FromArgb(0, 0, 0);
                this.TBValorCompraMaxima.Clear();
            }
            else
            {
                //Color de fondo del Texboxt cuando este tiene el FOCUS Activado
                this.TBValorCompraMaxima.BackColor = Color.Azure;
                this.TBValorCompraMaxima.ForeColor = Color.FromArgb(0, 0, 0);
            }
        }

        private void TBValor01_Enter(object sender, EventArgs e)
        {
            //Se evalua si el campo de texto esta vacio y se espeicifca que es obligatorio en la base de datos
            if (TBValor01.Text == Numerico)
            {
                this.TBValor01.BackColor = Color.Azure;
                this.TBValor01.ForeColor = Color.FromArgb(0, 0, 0);
                this.TBValor01.Clear();
            }
            else
            {
                //Color de fondo del Texboxt cuando este tiene el FOCUS Activado
                this.TBValor01.BackColor = Color.Azure;
                this.TBValor01.ForeColor = Color.FromArgb(0, 0, 0);
            }
        }

        private void TBValor02_Enter(object sender, EventArgs e)
        {
            //Se evalua si el campo de texto esta vacio y se espeicifca que es obligatorio en la base de datos
            if (TBValor02.Text == Numerico)
            {
                this.TBValor02.BackColor = Color.Azure;
                this.TBValor02.ForeColor = Color.FromArgb(0, 0, 0);
                this.TBValor02.Clear();
            }
            else
            {
                //Color de fondo del Texboxt cuando este tiene el FOCUS Activado
                this.TBValor02.BackColor = Color.Azure;
                this.TBValor02.ForeColor = Color.FromArgb(0, 0, 0);
            }
        }

        private void TBOferta01_Enter(object sender, EventArgs e)
        {
            //Se evalua si el campo de texto esta vacio y se espeicifca que es obligatorio en la base de datos
            if (TBOferta01.Text == Numerico)
            {
                this.TBOferta01.BackColor = Color.Azure;
                this.TBOferta01.ForeColor = Color.FromArgb(0, 0, 0);
                this.TBOferta01.Clear();
            }
            else
            {
                //Color de fondo del Texboxt cuando este tiene el FOCUS Activado
                this.TBOferta01.BackColor = Color.Azure;
                this.TBOferta01.ForeColor = Color.FromArgb(0, 0, 0);
            }
        }

        private void TBOferta02_Enter(object sender, EventArgs e)
        {
            //Se evalua si el campo de texto esta vacio y se espeicifca que es obligatorio en la base de datos
            if (TBOferta02.Text == Numerico)
            {
                this.TBOferta02.BackColor = Color.Azure;
                this.TBOferta02.ForeColor = Color.FromArgb(0, 0, 0);
                this.TBOferta02.Clear();
            }
            else
            {
                //Color de fondo del Texboxt cuando este tiene el FOCUS Activado
                this.TBOferta02.BackColor = Color.Azure;
                this.TBOferta02.ForeColor = Color.FromArgb(0, 0, 0);
            }
        }

        private void TBImpuesto_ValorInicial_Enter(object sender, EventArgs e)
        {
            this.TBImpuesto_ValorInicial.BackColor = Color.Azure;
        }

        private void TBImpuesto_ValorAuxiliar_Enter(object sender, EventArgs e)
        {
            this.TBImpuesto_ValorAuxiliar.BackColor = Color.Azure;
        }

        private void TBImpuesto_OfertaInicial_Enter(object sender, EventArgs e)
        {
            this.TBImpuesto_OfertaInicial.BackColor = Color.Azure;
        }

        private void TBImpuesto_OfertaAuxiliar_Enter(object sender, EventArgs e)
        {
            this.TBImpuesto_OfertaAuxiliar.BackColor = Color.Azure;
        }

        private void TBCantidadCompraMinima_Enter(object sender, EventArgs e)
        {
            this.TBCantidadCompraMinima.BackColor = Color.Azure;
        }

        private void TBCantidadCompraMaxima_Enter(object sender, EventArgs e)
        {
            this.TBCantidadCompraMaxima.BackColor = Color.Azure;
        }

        private void TBCantidadMininaCliente_Enter_1(object sender, EventArgs e)
        {
            this.TBCantidadMininaCliente.BackColor = Color.Azure;
        }

        private void TBCantidadMaximaCliente_Enter_1(object sender, EventArgs e)
        {
            this.TBCantidadMaximaCliente.BackColor = Color.Azure;
        }

        private void TBUnidadDeVenta_Enter(object sender, EventArgs e)
        {
            this.TBUnidadDeVenta.BackColor = Color.Azure;
        }

        //******************** FOCUS ENTER UBICACION ********************
        private void TBUbicacion_Enter(object sender, EventArgs e)
        {
            this.TBUbicacion.BackColor = Color.Azure;
        }

        private void TBEstante_Enter(object sender, EventArgs e)
        {
            this.TBEstante.BackColor = Color.Azure;
        }

        private void TBNivel_Enter(object sender, EventArgs e)
        {
            this.TBNivel.BackColor = Color.Azure;
        }

        //******************** FOCUS ENTER CANTIDADES ********************

        private void TBCantidadMinima_Enter(object sender, EventArgs e)
        {
            //Se evalua si el campo de texto esta vacio y se espeicifca que es obligatorio en la base de datos
            if (TBCantidadCompraMinima.Text == Numerico)
            {
                this.TBCantidadCompraMinima.BackColor = Color.Azure;
                this.TBCantidadCompraMinima.ForeColor = Color.FromArgb(0, 0, 0);
                this.TBCantidadCompraMinima.Clear();
            }
            else
            {
                //Color de fondo del Texboxt cuando este tiene el FOCUS Activado
                this.TBCantidadCompraMinima.BackColor = Color.Azure;
                this.TBCantidadCompraMinima.ForeColor = Color.FromArgb(0, 0, 0);
            }
        }

        private void TBCantidadMaxima_Enter(object sender, EventArgs e)
        {
            //Se evalua si el campo de texto esta vacio y se espeicifca que es obligatorio en la base de datos
            if (TBCantidadCompraMaxima.Text == Numerico)
            {
                this.TBCantidadCompraMaxima.BackColor = Color.Azure;
                this.TBCantidadCompraMaxima.ForeColor = Color.FromArgb(0, 0, 0);
                this.TBCantidadCompraMaxima.Clear();
            }
            else
            {
                //Color de fondo del Texboxt cuando este tiene el FOCUS Activado
                this.TBCantidadCompraMaxima.BackColor = Color.Azure;
                this.TBCantidadCompraMaxima.ForeColor = Color.FromArgb(0, 0, 0);
            }
        }

        private void TBCantidadMininaCliente_Enter(object sender, EventArgs e)
        {
            //Se evalua si el campo de texto esta vacio y se espeicifca que es obligatorio en la base de datos
            if (TBCantidadMininaCliente.Text == Numerico)
            {
                this.TBCantidadMininaCliente.BackColor = Color.Azure;
                this.TBCantidadMininaCliente.ForeColor = Color.FromArgb(0, 0, 0);
                this.TBCantidadMininaCliente.Clear();
            }
            else
            {
                //Color de fondo del Texboxt cuando este tiene el FOCUS Activado
                this.TBCantidadMininaCliente.BackColor = Color.Azure;
                this.TBCantidadMininaCliente.ForeColor = Color.FromArgb(0, 0, 0);
            }
        }

        private void TBCantidadMaximaCliente_Enter(object sender, EventArgs e)
        {
            //Se evalua si el campo de texto esta vacio y se espeicifca que es obligatorio en la base de datos
            if (TBCantidadMaximaCliente.Text == Numerico)
            {
                this.TBCantidadMaximaCliente.BackColor = Color.Azure;
                this.TBCantidadMaximaCliente.ForeColor = Color.FromArgb(0, 0, 0);
                this.TBCantidadMaximaCliente.Clear();
            }
            else
            {
                //Color de fondo del Texboxt cuando este tiene el FOCUS Activado
                this.TBCantidadMaximaCliente.BackColor = Color.Azure;
                this.TBCantidadMaximaCliente.ForeColor = Color.FromArgb(0, 0, 0);
            }
        }

        //******************** FOCUS LEAVE DATOS BASICOS ********************
        private void TBCodigo_Leave(object sender, EventArgs e)
        {
            if (TBCodigo.Text == string.Empty)
            {
                //Color de texboxt cuando este posee el FOCUS Activado
                this.TBCodigo.BackColor = Color.FromArgb(3, 155, 229);
                this.TBCodigo.Text = Campo;
                this.TBCodigo.ForeColor = Color.FromArgb(255, 255, 255);
            }
            else
            {
                TBCodigo.BackColor = Color.FromArgb(3, 155, 229);
            }
        }

        private void TBNombre_Leave(object sender, EventArgs e)
        {
            if (TBNombre.Text == string.Empty)
            {
                //Color de texboxt cuando este posee el FOCUS Activado
                this.TBNombre.BackColor = Color.FromArgb(3, 155, 229);
                this.TBNombre.Text = Campo;
                this.TBNombre.ForeColor = Color.FromArgb(255, 255, 255);
            }
            else
            {
                TBNombre.BackColor = Color.FromArgb(3, 155, 229);
            }
        }

        private void TBReferencia_Leave(object sender, EventArgs e)
        {
            this.TBReferencia.BackColor = Color.FromArgb(3, 155, 229);
        }

        private void TBDescripcion01_Leave(object sender, EventArgs e)
        {
            if (TBDescripcion01.Text == string.Empty)
            {
                //Color de texboxt cuando este posee el FOCUS Activado
                this.TBDescripcion01.BackColor = Color.FromArgb(3, 155, 229);
                this.TBDescripcion01.Text = Campo;
                this.TBDescripcion01.ForeColor = Color.FromArgb(255, 255, 255);
            }
            else
            {
                TBDescripcion01.BackColor = Color.FromArgb(3, 155, 229);
            }
        }

        private void TBLotedeingreso_Leave(object sender, EventArgs e)
        {
            this.TBLotedeingreso.BackColor = Color.FromArgb(3, 155, 229);
        }

        private void TBPresentacion_Leave(object sender, EventArgs e)
        {
            if (TBPresentacion.Text == string.Empty)
            {
                //Color de texboxt cuando este posee el FOCUS Activado
                this.TBPresentacion.BackColor = Color.FromArgb(3, 155, 229);
                this.TBPresentacion.Text = Campo;
                this.TBPresentacion.ForeColor = Color.FromArgb(255, 255, 255);
            }
            else
            {
                TBPresentacion.BackColor = Color.FromArgb(3, 155, 229);
            }
        }

        private void TBProveedor_Leave(object sender, EventArgs e)
        {
            this.TBProveedor.BackColor = Color.FromArgb(3, 155, 229);
        }

        private void TBImpuesto_Leave(object sender, EventArgs e)
        {
            this.TBImpuesto.BackColor = Color.FromArgb(3, 155, 229);
        }

        private void CBImportado_CheckedChanged(object sender, EventArgs e)
        {
            //if (CBImportado.Checked == true)
            //{
            //    this.TBValorImportacion.Enabled = true;
            //    this.TBValorImportacion.BackColor = Color.FromArgb(3, 155, 229);
            //}
            //else if (CBImportado.Checked == false)
            //{
            //    this.TBValorImportacion.Enabled = false;
            //    this.TBValorImportacion.BackColor = Color.FromArgb(72, 209, 204);
            //}
        }

        private void CBExportado_CheckedChanged(object sender, EventArgs e)
        {
            //if (CBExportado.Checked == true)
            //{
            //    this.TBValorExportacion.Enabled = true;
            //    this.TBValorExportacion.BackColor = Color.FromArgb(3, 155, 229);
            //}
            //else if (CBExportado.Checked == false)
            //{
            //    this.TBValorExportacion.Enabled = false;
            //    this.TBValorExportacion.BackColor = Color.FromArgb(72, 209, 204);
            //}
        }

        private void btnExaminar_Proveedor_Click(object sender, EventArgs e)
        {

        }

        private void btnExaminar_Impuesto_Click(object sender, EventArgs e)
        {

        }

        private void CBProductosOfertable_CheckedChanged(object sender, EventArgs e)
        {
            if (CBProductosOfertable.Checked == true)
            {
                this.TBOferta01.Enabled = true;
                this.TBOferta01.BackColor = Color.FromArgb(3, 155, 229);
                this.TBOferta02.Enabled = true;
                this.TBOferta02.BackColor = Color.FromArgb(3, 155, 229);

                this.TBOferta01.Clear();
                this.TBOferta02.Clear();
            }
            else
            {
                this.TBOferta01.Enabled = false;
                this.TBOferta02.Enabled = false;
            }
        }

        //******************** FOCUS LEAVE VALORES ********************

        private void TBValorCompraMinina_Leave(object sender, EventArgs e)
        {
            if (TBValorCompraMinina.Text == string.Empty)
            {
                //Color de texboxt cuando este posee el FOCUS Activado
                this.TBValorCompraMinina.BackColor = Color.FromArgb(3, 155, 229);
                this.TBValorCompraMinina.Text = Numerico;
                this.TBValorCompraMinina.ForeColor = Color.FromArgb(255, 255, 255);
            }
            else
            {
                //Formato del Campo de Texto
                double Formato = Convert.ToDouble(this.TBValorCompraMinina.Text);
                this.TBValorCompraMinina.Text = Formato.ToString("##,##0.00");

                this.TBValorCompraMinina.BackColor = Color.FromArgb(3, 155, 229);
            }
        }

        private void TBValorCompraMaxima_Leave(object sender, EventArgs e)
        {
            if (TBValorCompraMaxima.Text == string.Empty)
            {
                //Color de texboxt cuando este posee el FOCUS Activado
                this.TBValorCompraMaxima.BackColor = Color.FromArgb(3, 155, 229);
                this.TBValorCompraMaxima.Text = Numerico;
                this.TBValorCompraMaxima.ForeColor = Color.FromArgb(255, 255, 255);
            }
            else
            {
                //Formato del Campo de Texto
                double Formato = Convert.ToDouble(this.TBValorCompraMaxima.Text);
                this.TBValorCompraMaxima.Text = Formato.ToString("##,##0.00");

                this.TBValorCompraMaxima.BackColor = Color.FromArgb(3, 155, 229);
            }
        }

        private void TBValor01_Leave(object sender, EventArgs e)
        {
            if (TBValor01.Text == string.Empty)
            {
                //Color de texboxt cuando este posee el FOCUS Activado
                this.TBValor01.BackColor = Color.FromArgb(3, 155, 229);
                this.TBValor01.Text = Numerico;
                this.TBValor01.ForeColor = Color.FromArgb(255, 255, 255);
            }

            else
            {
                //Formato del Campo de Texto
                double Formato = Convert.ToDouble(this.TBValor01.Text);
                this.TBValor01.Text = Formato.ToString("##,##0.00");

                this.TBValor01.BackColor = Color.FromArgb(3, 155, 229);
            }
        }

        private void TBCantidadCompraMinima_Leave(object sender, EventArgs e)
        {
            //Color de texboxt cuando este posee el FOCUS Activado
            this.TBCantidadCompraMinima.BackColor = Color.FromArgb(3, 155, 229);
        }

        private void TBCantidadCompraMaxima_Leave(object sender, EventArgs e)
        {
            //Color de texboxt cuando este posee el FOCUS Activado
            this.TBCantidadCompraMaxima.BackColor = Color.FromArgb(3, 155, 229);
        }

        private void TBCantidadMininaCliente_Leave_1(object sender, EventArgs e)
        {
            //Color de texboxt cuando este posee el FOCUS Activado
            this.TBCantidadMininaCliente.BackColor = Color.FromArgb(3, 155, 229);
        }

        private void TBCantidadMaximaCliente_Leave_1(object sender, EventArgs e)
        {
            //Color de texboxt cuando este posee el FOCUS Activado
            this.TBCantidadMaximaCliente.BackColor = Color.FromArgb(3, 155, 229);
        }

        private void TBUnidadDeVenta_Leave(object sender, EventArgs e)
        {
            //Color de texboxt cuando este posee el FOCUS Activado
            this.TBUnidadDeVenta.BackColor = Color.FromArgb(3, 155, 229);
        }
        
        private void TBValor02_Leave(object sender, EventArgs e)
        {
            if (TBValor02.Text == string.Empty)
            {
                //Color de texboxt cuando este posee el FOCUS Activado
                this.TBValor02.BackColor = Color.FromArgb(3, 155, 229);
                this.TBValor02.Text = Numerico;
                this.TBValor02.ForeColor = Color.FromArgb(255, 255, 255);
            }

            else
            {
                //Formato del Campo de Texto
                double Formato = Convert.ToDouble(this.TBValor02.Text);
                this.TBValor02.Text = Formato.ToString("##,##0.00");

                this.TBValor02.BackColor = Color.FromArgb(3, 155, 229);
            }
        }

        private void TBOferta01_Leave(object sender, EventArgs e)
        {
            if (TBOferta01.Text == string.Empty)
            {
                //Color de texboxt cuando este posee el FOCUS Activado
                this.TBOferta01.BackColor = Color.FromArgb(3, 155, 229);
                this.TBOferta01.Text = Numerico;
                this.TBOferta01.ForeColor = Color.FromArgb(255, 255, 255);
            }

            else
            {
                //Formato del Campo de Texto
                double Formato = Convert.ToDouble(this.TBOferta01.Text);
                this.TBOferta01.Text = Formato.ToString("##,##0.00");

                this.TBOferta01.BackColor = Color.FromArgb(3, 155, 229);
            }
        }

        private void TBOferta02_Leave(object sender, EventArgs e)
        {
            if (TBOferta02.Text == string.Empty)
            {
                //Color de texboxt cuando este posee el FOCUS Activado
                this.TBOferta02.BackColor = Color.FromArgb(3, 155, 229);
                this.TBOferta02.Text = Numerico;
                this.TBOferta02.ForeColor = Color.FromArgb(255, 255, 255);
            }

            else
            {
                //Formato del Campo de Texto
                double Formato = Convert.ToDouble(this.TBOferta02.Text);
                this.TBOferta02.Text = Formato.ToString("##,##0.00");

                this.TBOferta02.BackColor = Color.FromArgb(3, 155, 229);
            }
        }

        private void TBImpuesto_ValorInicial_Leave(object sender, EventArgs e)
        {
            if (TBImpuesto_ValorInicial.Text == string.Empty)
            {
                //Color de texboxt cuando este posee el FOCUS Activado
                this.TBImpuesto_ValorInicial.BackColor = Color.FromArgb(3, 155, 229);
                this.TBImpuesto_ValorInicial.Text = Numerico;
                this.TBImpuesto_ValorInicial.ForeColor = Color.FromArgb(255, 255, 255);
            }

            else
            {
                //Formato del Campo de Texto
                double Formato = Convert.ToDouble(this.TBImpuesto_ValorInicial.Text);
                this.TBImpuesto_ValorInicial.Text = Formato.ToString("##,##0.00");

                this.TBImpuesto_ValorInicial.BackColor = Color.FromArgb(3, 155, 229);
            }
        }

        private void TBImpuesto_ValorAuxiliar_Leave(object sender, EventArgs e)
        {
            if (TBImpuesto_ValorAuxiliar.Text == string.Empty)
            {
                //Color de texboxt cuando este posee el FOCUS Activado
                this.TBImpuesto_ValorAuxiliar.BackColor = Color.FromArgb(3, 155, 229);
                this.TBImpuesto_ValorAuxiliar.Text = Numerico;
                this.TBImpuesto_ValorAuxiliar.ForeColor = Color.FromArgb(255, 255, 255);
            }

            else
            {
                //Formato del Campo de Texto
                double Formato = Convert.ToDouble(this.TBImpuesto_ValorAuxiliar.Text);
                this.TBImpuesto_ValorAuxiliar.Text = Formato.ToString("##,##0.00");

                this.TBImpuesto_ValorAuxiliar.BackColor = Color.FromArgb(3, 155, 229);
            }
        }

        private void TBImpuesto_OfertaInicial_Leave(object sender, EventArgs e)
        {
            if (TBImpuesto_OfertaInicial.Text == string.Empty)
            {
                //Color de texboxt cuando este posee el FOCUS Activado
                this.TBImpuesto_OfertaInicial.BackColor = Color.FromArgb(3, 155, 229);
                this.TBImpuesto_OfertaInicial.Text = Numerico;
                this.TBImpuesto_OfertaInicial.ForeColor = Color.FromArgb(255, 255, 255);
            }

            else
            {
                //Formato del Campo de Texto
                double Formato = Convert.ToDouble(this.TBImpuesto_OfertaInicial.Text);
                this.TBImpuesto_OfertaInicial.Text = Formato.ToString("##,##0.00");

                this.TBImpuesto_OfertaInicial.BackColor = Color.FromArgb(3, 155, 229);
            }
        }

        private void TBImpuesto_OfertaAuxiliar_Leave(object sender, EventArgs e)
        {
            if (TBImpuesto_OfertaAuxiliar.Text == string.Empty)
            {
                //Color de texboxt cuando este posee el FOCUS Activado
                this.TBImpuesto_OfertaAuxiliar.BackColor = Color.FromArgb(3, 155, 229);
                this.TBImpuesto_OfertaAuxiliar.Text = Numerico;
                this.TBImpuesto_OfertaAuxiliar.ForeColor = Color.FromArgb(255, 255, 255);
            }

            else
            {
                //Formato del Campo de Texto
                double Formato = Convert.ToDouble(this.TBImpuesto_OfertaAuxiliar.Text);
                this.TBImpuesto_OfertaAuxiliar.Text = Formato.ToString("##,##0.00");

                this.TBImpuesto_OfertaAuxiliar.BackColor = Color.FromArgb(3, 155, 229);
            }
        }

        //******************** FOCUS LEAVE UBICACION ********************
        private void TBUbicacion_Leave(object sender, EventArgs e)
        {
            this.TBUbicacion.BackColor = Color.FromArgb(3, 155, 229);
        }

        private void TBEstante_Leave(object sender, EventArgs e)
        {
            this.TBEstante.BackColor = Color.FromArgb(3, 155, 229);
        }

        private void TBNivel_Leave(object sender, EventArgs e)
        {
            this.TBNivel.BackColor = Color.FromArgb(3, 155, 229);
        }

        //******************** FOCUS LEAVE CANTIDADES ********************
        private void TBCantidadMinima_Leave(object sender, EventArgs e)
        {
            if (TBCantidadCompraMinima.Text == string.Empty)
            {
                //Color de texboxt cuando este posee el FOCUS Activado
                this.TBCantidadCompraMinima.BackColor = Color.FromArgb(3, 155, 229);
                this.TBCantidadCompraMinima.Text = Numerico;
                this.TBCantidadCompraMinima.ForeColor = Color.FromArgb(255, 255, 255);
            }

            else
            {
                this.TBCantidadCompraMinima.BackColor = Color.FromArgb(3, 155, 229);
            }
        }

        private void TBCantidadMaxima_Leave(object sender, EventArgs e)
        {
            if (TBCantidadCompraMaxima.Text == string.Empty)
            {
                //Color de texboxt cuando este posee el FOCUS Activado
                this.TBCantidadCompraMaxima.BackColor = Color.FromArgb(3, 155, 229);
                this.TBCantidadCompraMaxima.Text = Numerico;
                this.TBCantidadCompraMaxima.ForeColor = Color.FromArgb(255, 255, 255);
            }

            else
            {
                this.TBCantidadCompraMaxima.BackColor = Color.FromArgb(3, 155, 229);
            }
        }

        private void TBCantidadMininaCliente_Leave(object sender, EventArgs e)
        {
            if (TBCantidadMininaCliente.Text == string.Empty)
            {
                //Color de texboxt cuando este posee el FOCUS Activado
                this.TBCantidadMininaCliente.BackColor = Color.FromArgb(3, 155, 229);
                this.TBCantidadMininaCliente.Text = Numerico;
                this.TBCantidadMininaCliente.ForeColor = Color.FromArgb(255, 255, 255);
            }

            else
            {
                this.TBCantidadMininaCliente.BackColor = Color.FromArgb(3, 155, 229);
            }
        }

        private void TBCantidadMaximaCliente_Leave(object sender, EventArgs e)
        {
            if (TBCantidadMaximaCliente.Text == string.Empty)
            {
                //Color de texboxt cuando este posee el FOCUS Activado
                this.TBCantidadMaximaCliente.BackColor = Color.FromArgb(3, 155, 229);
                this.TBCantidadMaximaCliente.Text = Numerico;
                this.TBCantidadMaximaCliente.ForeColor = Color.FromArgb(255, 255, 255);
            }

            else
            {
                this.TBCantidadMaximaCliente.BackColor = Color.FromArgb(3, 155, 229);
            }
        }

        private void TBBuscar_Enter(object sender, EventArgs e)
        {
            this.TBBuscar.BackColor = Color.Azure;
        }

        private void TBBuscar_Leave(object sender, EventArgs e)
        {
            this.TBBuscar.BackColor = Color.FromArgb(3, 155, 229);
        }

        private void CBUnidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBUnidad.SelectedIndex != 0)
            {
                this.TBCantidadCompraMinima.Select();
            }
        }

        private void CBBodega_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBBodega.SelectedIndex != 0)
            {
                this.TBUbicacion.Select();
            }
        }

        private void TBBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Consultar == "1")
                {
                    if (TBBuscar.Text != "")
                    {
                        this.DGResultados.DataSource = fProductos.Buscar(this.TBBuscar.Text, 1);
                        //this.DGResultadoss.Columns[1].Visible = false;

                        lblTotal.Text = "Datos Registrados: " + Convert.ToString(DGResultados.Rows.Count);

                        this.btnEliminar.Enabled = true;
                        this.btnImprimir.Enabled = true;
                        this.DGResultados.Enabled = true;
                    }
                    else
                    {
                        this.Limpiar_Datos();

                        //Se Limpian las Filas y Columnas de la tabla
                        this.DGResultados.DataSource = null;
                        this.DGResultados.Enabled = false;
                        this.lblTotal.Text = "Datos Registrados: 0";

                        this.btnEliminar.Enabled = false;
                        this.btnImprimir.Enabled = false;
                    }
                }

                else
                {
                    MessageBox.Show(" El Usuario Iniciado no Contiene Permisos Para Realizar Consultas", "Leal Enterprise - 'Acceso Denegado' ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }


        private void TBIdproducto_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable Datos = Negocio.fProductos.Buscar(this.TBIdproducto.Text, 2);
                //Evaluamos si  existen los Datos
                if (Datos.Rows.Count == 0)
                {
                    MessageBox.Show("Actualmente no se encuentran registros en la Base de Datos", "Leal Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //Captura de Valores en la Base de Datos

                    //Panel Datos Basicos - Llaves Primarias
                    Idmarca = Datos.Rows[0][0].ToString();
                    //Idorigen = Datos.Rows[0][1].ToString();
                    Idgrupo = Datos.Rows[0][2].ToString();
                    Idtipo = Datos.Rows[0][3].ToString();
                    Idempaque = Datos.Rows[0][4].ToString();
                    Idbodega = Datos.Rows[0][5].ToString();
                    Idproveedor = Datos.Rows[0][6].ToString();
                    Idimpuesto = Datos.Rows[0][7].ToString();

                    //Panel Datos Basicos
                    Codigo = Datos.Rows[0][8].ToString();
                    Barra = Datos.Rows[0][9].ToString();
                    Nombre = Datos.Rows[0][10].ToString();
                    Referencia = Datos.Rows[0][11].ToString();
                    Descripcion = Datos.Rows[0][12].ToString();
                    Lote = Datos.Rows[0][13].ToString();
                    Presentacion = Datos.Rows[0][14].ToString();

                    //Panel - Valores
                    Ofertable = Datos.Rows[0][15].ToString();
                    VentaFinal = Datos.Rows[0][16].ToString();
                    CompraMinima = Datos.Rows[0][17].ToString();
                    CompraMaxima = Datos.Rows[0][18].ToString();
                    ValorVenta01 = Datos.Rows[0][19].ToString();
                    ValorVenta02 = Datos.Rows[0][20].ToString();
                    Oferta01 = Datos.Rows[0][22].ToString();
                    Oferta02 = Datos.Rows[0][23].ToString();
                    Ubicacion = Datos.Rows[0][25].ToString();
                    Estante = Datos.Rows[0][26].ToString();
                    Nivel = Datos.Rows[0][27].ToString();
                    Imagen = Datos.Rows[0][28].ToString();

                    UnidadDeVenta = Datos.Rows[0][28].ToString();
                    CantidadCompraMinima = Datos.Rows[0][29].ToString();
                    CantidadCompraMaxima = Datos.Rows[0][30].ToString();
                    CantidadMinimaCliente = Datos.Rows[0][31].ToString();
                    CantidadMaximaCliente = Datos.Rows[0][32].ToString();
                    Vence = Datos.Rows[0][33].ToString();
                    //Fecha = Datos.Rows[0][34].date();
                    UnidadDePeso = Datos.Rows[0][35].ToString();
                    //Peso = Datos.Rows[0][36].ToString();

                    //Se procede a completar los campos de texto segun las consulta
                    //Realizada anteriormente en la base de datos

                    this.Marca_SQL = Idmarca;
                    this.CBMarca.SelectedValue = Marca_SQL;

                    this.Origen_SQL = Idorigen;

                    this.Grupo_SQL = Idgrupo;
                    this.CBGrupo.SelectedValue = Grupo_SQL;

                    this.Tipo_SQL = Idtipo;
                    this.CBTipo.SelectedValue = Tipo_SQL;

                    this.Empaque_SQL = Idempaque;
                    this.CBEmpaque.SelectedValue = Empaque_SQL;

                    this.Bodega_SQL = Idbodega;
                    this.CBBodega.SelectedValue = Bodega_SQL;

                    this.Proveedor_SQL = Idproveedor;
                    //this.CBProveedor.SelectedValue = Proveedor_SQL;

                    this.Impuesto_SQL = Idimpuesto;
                    //this.CBImpuesto.SelectedValue = Impuesto_SQL;

                    //Panel Datos Basicos
                    this.TBCodigo.Text = Codigo;
                    //this.TBCodigoDeBarra.Text = Barra;
                    this.TBNombre.Text = Nombre;
                    this.TBReferencia.Text = Referencia;
                    this.TBDescripcion01.Text = Descripcion;
                    this.TBLotedeingreso.Text = Lote;
                    this.TBPresentacion.Text = Presentacion;

                    //Panel - Valores
                    //this.CBOfertable.Text = Ofertable;
                    this.CBVentaPublico.Text = VentaFinal;
                    this.TBValorCompraMinina.Text = CompraMinima;
                    this.TBValorCompraMaxima.Text = CompraMaxima;
                    this.TBValor01.Text = ValorVenta01;
                    this.TBValor02.Text = ValorVenta02;
                    this.TBOferta01.Text = Oferta01;
                    this.TBOferta02.Text = Oferta02;
                    this.TBUbicacion.Text = Ubicacion;
                    this.TBEstante.Text = Estante;
                    this.TBNivel.Text = Nivel;
                    //this.PB_Imagen.ToString = Imagen;

                    this.CBUnidad.Text = UnidadDeVenta;
                    this.TBCantidadCompraMinima.Text = CantidadCompraMinima;
                    this.TBCantidadCompraMaxima.Text = CantidadCompraMaxima;
                    this.TBCantidadMininaCliente.Text = CantidadMinimaCliente;
                    this.TBCantidadMaximaCliente.Text = CantidadMaximaCliente;
                    //this.CBVence.Text = Vence;
                    //this.DTFechadevencimiento.MaxDate = Fecha;
                    this.CBUnidad.Text = UnidadDePeso;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void DGResultados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.Digitar = false;

                if (Editar == "1")
                {
                    //
                    this.TBIdproducto.Text = Convert.ToString(this.DGResultados.CurrentRow.Cells["ID"].Value);
                    this.TBNombre.Select();

                    this.Botones();

                }
                else
                {
                    MessageBox.Show("El Usuario Iniciado Actualmente no Contiene Permisos Para Actualizar Datos en el Sistema", "Leal Enterprise - 'Acceso Denegado' ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void DGResultados_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    this.Digitar = false;

                    if (Editar == "1")
                    {
                        //
                        this.TBIdproducto.Text = Convert.ToString(this.DGResultados.CurrentRow.Cells["ID"].Value);
                        this.TBNombre.Select();

                        //Se procede Habilitar los campos de Textos y Botones
                        //cuando se le realice el evento Clip del Boton Ediatar/Guardar

                        this.Habilitar();
                        this.btnGuardar.Enabled = true;
                        this.btnCancelar.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("El Usuario Iniciado Actualmente no Contiene Permisos Para Actualizar Datos", "Leal Enterprise - 'Acceso Denegado' ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void PB_Imagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.PB_Imagen.SizeMode = PictureBoxSizeMode.StretchImage;
                this.PB_Imagen.Image = Image.FromFile(dialog.FileName);
            }
        }

        private void btnGuardar_MouseDown(object sender, MouseEventArgs e)
        {
            if (Digitar)
            {
                this.btnGuardar.Image = Properties.Resources.BV_Guardar;
            }
            else
            {
                this.btnGuardar.Image = Properties.Resources.BV_Editar;
            }
        }

        private void btnGuardar_MouseLeave(object sender, EventArgs e)
        {
            if (Digitar)
            {
                this.btnGuardar.Image = Properties.Resources.BV_Guardar;
            }
            else
            {
                this.btnGuardar.Image = Properties.Resources.BV_Editar;
            }
        }

        private void btnGuardar_MouseMove(object sender, MouseEventArgs e)
        {
            if (Digitar)
            {
                this.btnGuardar.Image = Properties.Resources.BR_Guardar;
            }
            else
            {
                this.btnGuardar.Image = Properties.Resources.BR_Editar;
            }
        }

        private void btnCancelar_MouseDown(object sender, MouseEventArgs e)
        {
            this.btnCancelar.Image = Properties.Resources.BV_Cancelar;
        }

        private void btnCancelar_MouseLeave(object sender, EventArgs e)
        {
            this.btnCancelar.Image = Properties.Resources.BV_Cancelar;
        }

        private void btnCancelar_MouseMove(object sender, MouseEventArgs e)
        {
            this.btnCancelar.Image = Properties.Resources.BR_Cancelar;
        }

        private void btnEliminar_MouseDown(object sender, MouseEventArgs e)
        {
            this.btnEliminar.Image = Properties.Resources.BV_Eliminar;
        }

        private void btnEliminar_MouseLeave(object sender, EventArgs e)
        {
            this.btnEliminar.Image = Properties.Resources.BV_Eliminar;
        }

        private void btnEliminar_MouseMove(object sender, MouseEventArgs e)
        {
            this.btnEliminar.Image = Properties.Resources.BR_Eliminar;
        }

        private void btnImprimir_MouseDown(object sender, MouseEventArgs e)
        {
            this.btnImprimir.Image = Properties.Resources.BV_Imprimir;
        }

        private void btnImprimir_MouseLeave(object sender, EventArgs e)
        {
            this.btnImprimir.Image = Properties.Resources.BV_Imprimir;
        }

        private void btnImprimir_MouseMove(object sender, MouseEventArgs e)
        {
            this.btnImprimir.Image = Properties.Resources.BR_Imprimir;
        }

    }
}
