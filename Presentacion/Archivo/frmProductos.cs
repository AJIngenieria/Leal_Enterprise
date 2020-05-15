using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Globalization;

using Negocio;

namespace Presentacion
{
    public partial class frmProductos : Form
    {
        //Instancia para el filtro de los productos 
        private static frmProductos _Instancia;

        public static frmProductos GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new frmProductos();
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
        private string Campo = "Campo Obligatorio - Leal Enterprise";
        private string Campo_Obligatorio = "Campo Obligatorio";

        //********** Variables para la Validacion de los checkbox en el Pane Datos Basicos

        private string Checkbox_Vencimiento, Checkbox_Ofertable, Checkbox_Impuesto, Checkbox_Importado = "";
        private string Checkbox_Comision, Checkbox_VentaImpuesto, Checkbox_Exportado = "";

        //********** Variables para AutoComplementar Combobox y Chexboxt segun la Consulta en SQL **********

        //Panel Datos Basicos
        private string Bodega_SQL, Empaque_SQL, Grupo_SQL, Marca_SQL, Tipo_SQL = "";
        private string Vencimiento_SQL, Impuesto_SQL, Importado_SQL, Exportado_SQL, Ofertable_SQL, VentaImpuesto_SQL, Comision_SQL = "";

        //********** Variable para Metodo SQL Guardar, Eliminar, Editar, Consultar *************************

        public string Guardar, Editar, Consultar, Eliminar, Imprimir = "";

        //********** Parametros para AutoCompletar los Texboxt **********************************

        //Panel Datos Basicos - Llaves Primarias
        private string Idmarca, Idgrupo, Idtipo, Idempaque, Idbodega, Idproveedor, Idimpuesto = "";

        //Panel Datos Basicos
        private string Codigo, Nombre, Referencia, Descripcion, Presentacion = "";
        private string ManejaVencimiento, Importado, Exportado, ManjenaImpuesto = "";
        private string Ofertable, UnidadDeVenta, ValorUnidad, VentaImpuesto, ComisionEmpleado = "";

        //Panel - Valores
        private string Valor_Promedio, Valor_Final, Valor_Excento, Valor_NoExcento, Valor_Mayorista, GastoDeEnvio, Comision, Valor_Comision, Minimo_Cliente, Maximo_Cliente, Minimo_Mayorista, Maximo_Mayorista = "";

        //Panel - Ubicacion
        private string Ubicacion, Estante, Nivel, Stock_Disponible, Imagen = "";

        //Panel - Lote
        private string Lote, Valor_Lote, Stock_Lote, Fecha_Vencimiento = "";

        //Panel - Codigo de Barra y Datos Auxiliares de Llaves Primarias
        private string CodigoDeBarra, Proveedor, Impuesto, Impuesto_Valor = "";

        //********** Parametros para Formatos de Tipo Moneda ***********************************

        private string Mon_Promedio, Mon_Final, Mon_Excento, Mon_NoExcento, Mon_Mayorista, Mon_Envio, Mon_Comision = "";

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
            this.TBIdimpuesto.Visible = false;
            this.TBIdproveedor.Visible = false;

            //Panel - Cantidades - Otros Datos
            this.CBUnidad.SelectedIndex = 0;
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
            this.TBReferencia.ReadOnly = false;
            this.TBReferencia.BackColor = Color.FromArgb(3, 155, 229);
            this.TBPresentacion.ReadOnly = false;
            this.TBPresentacion.BackColor = Color.FromArgb(3, 155, 229);

            this.TBProveedor.Enabled = false;
            this.TBProveedor.BackColor = Color.FromArgb(72, 209, 204);
            this.TBProveedor.ForeColor = Color.FromArgb(255, 255, 255);
            this.TBProveedor.Text = Campo;
            this.TBImpuesto.Enabled = false;
            this.TBImpuesto.BackColor = Color.FromArgb(72, 209, 204);
            this.TBImpuesto.ForeColor = Color.FromArgb(255, 255, 255);
            this.TBImpuesto.Text = Campo_Obligatorio;
            this.TBImpuesto_Valor.Enabled = false;
            this.TBImpuesto_Valor.BackColor = Color.FromArgb(72, 209, 204);

            this.TBUnidadDeVenta.Enabled = false;
            this.TBUnidadDeVenta.BackColor = Color.FromArgb(3, 155, 229);

            //Panel - Valores

            this.TBCompraPromedio.ReadOnly = false;
            this.TBCompraPromedio.BackColor = Color.FromArgb(3, 155, 229);
            this.TBValorFinal.ReadOnly = false;
            this.TBValorFinal.BackColor = Color.FromArgb(3, 155, 229);
            this.TBValorVenta.Enabled = false;
            this.TBValorVenta.BackColor = Color.FromArgb(72, 209, 204);
            this.TBValorVenta_SinImpuesto.ReadOnly = false;
            this.TBValorVenta_SinImpuesto.BackColor = Color.FromArgb(3, 155, 229);
            
            this.TBComision.Enabled = false;
            this.TBComision.BackColor = Color.FromArgb(72, 209, 204);
            this.TBValorParaComision.Enabled = false;
            this.TBValorParaComision.BackColor = Color.FromArgb(72, 209, 204);

            this.TBVentaMayorista.ReadOnly = false;
            this.TBVentaMayorista.BackColor = Color.FromArgb(3, 155, 229);
            this.TBMaximoMayorista.ReadOnly = false;
            this.TBMaximoMayorista.BackColor = Color.FromArgb(3, 155, 229);
            this.TBMinimoMayorista.ReadOnly = false;
            this.TBMinimoMayorista.BackColor = Color.FromArgb(3, 155, 229);

            this.TBCantidadMininaCliente.ReadOnly = false;
            this.TBCantidadMininaCliente.BackColor = Color.FromArgb(3, 155, 229);
            this.TBCantidadMaximaCliente.ReadOnly = false;
            this.TBCantidadMaximaCliente.BackColor = Color.FromArgb(3, 155, 229);
            this.TBGastodeEnvio.ReadOnly = false;
            this.TBGastodeEnvio.BackColor = Color.FromArgb(3, 155, 229);

            //Panel - Ubicacion
            this.TBUbicacion.ReadOnly = false;
            this.TBUbicacion.BackColor = Color.FromArgb(3, 155, 229);
            this.TBEstante.ReadOnly = false;
            this.TBEstante.BackColor = Color.FromArgb(3, 155, 229);
            this.TBNivel.ReadOnly = false;
            this.TBNivel.BackColor = Color.FromArgb(3, 155, 229);
            this.TBStock.Enabled = false;
            this.TBStock.BackColor = Color.FromArgb(72, 209, 204);

            //Panel - Lote
            this.TBLotedeingreso.ReadOnly = false;
            this.TBLotedeingreso.BackColor = Color.FromArgb(3, 155, 229);
            this.TBValor_Lote.ReadOnly = false;
            this.TBValor_Lote.BackColor = Color.FromArgb(3, 155, 229);
            this.TBStockLote.Enabled = false;
            this.TBStockLote.BackColor = Color.FromArgb(72, 209, 204);
            this.DTFechaDeVencimiento.Enabled = true;
            this.DTFechaDeVencimiento.BackColor = Color.FromArgb(3, 155, 229);

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
                this.TBReferencia.Clear();
                this.TBPresentacion.Clear();
                this.TBProveedor.Clear();
                this.TBProveedor.Text = Campo;
                this.TBImpuesto.Clear();
                this.TBImpuesto.Text = Campo_Obligatorio;
                this.TBImpuesto_Valor.Clear();
                this.TBUnidadDeVenta.Clear();

                this.CBMarca.SelectedItem = 0;
                this.CBGrupo.SelectedItem = 0;
                this.CBEmpaque.SelectedItem = 0;
                this.CBTipo.SelectedItem = 0;
                this.CBUnidad.SelectedItem = 0;

                this.CBVencimiento.Checked = false;
                this.CBImpuesto.Checked = false;
                this.CBOfertable.Checked = false;
                this.CBImportado.Checked = false;
                this.CBExportado.Checked = false;
                this.CBManejaComision.Checked = false;
                this.CBVentaImpuesto.Checked = false;

                //Panel - Valores
                this.TBCompraPromedio.Clear();
                this.TBValorFinal.Clear();
                this.TBValorVenta.Clear();
                this.TBValorVenta_SinImpuesto.Clear();

                this.TBComision.Clear();
                this.TBValorParaComision.Clear();

                this.TBVentaMayorista.Clear();
                this.TBMaximoMayorista.Clear();
                this.TBMinimoMayorista.Clear();

                this.TBCantidadMininaCliente.Clear();
                this.TBCantidadMaximaCliente.Clear();
                this.TBGastodeEnvio.Clear();

                //Panel Ubicacion - Imagen
                this.CBBodega.SelectedIndex = 0;
                this.TBUbicacion.Clear();
                this.TBEstante.Clear();
                this.TBNivel.Clear();

                //Panel - Lote
                this.TBLotedeingreso.Clear();
                this.TBValor_Lote.Clear();
                this.TBStockLote.Clear();
                this.DGDetalles_Lotes.DataSource = null;

                //Panel - Codigo de Barra
                this.TBCodigodeBarra.Clear();
                this.DGResultados_Codigos.DataSource = null;

                //Se habilitan los botones a su estado por DEFAULT
                this.Digitar = true;
                this.Botones();
                this.Habilitar();
                this.PB_Imagen.Image = Properties.Resources.Logo_Leal_Enterprise;

                //Se realiza el FOCUS al panel y campo de texto iniciales
                this.TBPresentacion.Select();
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

        public void setProveedor(string idproveedor, string proveedor)
        {
            this.TBIdproveedor.Text = idproveedor;
            this.TBProveedor.Text = proveedor;
        }

        public void setImpuesto(string idimpuesto, string impuesto, string valor)
        {
            this.TBIdimpuesto.Text = idimpuesto;
            this.TBImpuesto.Text = impuesto;
            this.TBImpuesto_Valor.Text = valor;
        }
                
        private void Validaciones_SQL()
        {
            //Se valida el valor de los checbox que se encuentran en el panel de datos basicos
            //En el cual si este esta seleccionado su valor sera 1 y si no esta seleccionado este seria 0

            if (CBVencimiento.Checked)
            {
                this.Checkbox_Vencimiento = "1";
            }
            else
            {
                this.Checkbox_Vencimiento = "0";
            }

            if (CBImpuesto.Checked)
            {
                this.Checkbox_Impuesto = "1";
            }
            else
            {
                this.Checkbox_Impuesto = "0";
            }

            if (CBImportado.Checked)
            {
                this.Checkbox_Importado = "1";
            }
            else
            {
                this.Checkbox_Importado = "0";
            }

            if (CBExportado.Checked)
            {
                this.Checkbox_Exportado = "1";
            }
            else
            {
                this.Checkbox_Exportado = "0";
            }

            if (CBOfertable.Checked)
            {
                this.Checkbox_Ofertable = "1";
            }
            else
            {
                this.Checkbox_Ofertable = "0";
            }

            if (CBVentaImpuesto.Checked)
            {
                this.Checkbox_VentaImpuesto = "1";
            }
            else
            {
                this.Checkbox_VentaImpuesto = "0";
            }

            if (CBManejaComision.Checked)
            {
                this.Checkbox_Comision = "1";
            }
            else
            {
                this.Checkbox_Comision = "0";
            }

            //
            this.Mon_Promedio = TBCompraPromedio.Text;
            this.Mon_Final = TBValorFinal.Text;
            this.Mon_Excento = TBValorVenta_SinImpuesto.Text;
            this.Mon_NoExcento = TBValorVenta.Text;
            this.Mon_Mayorista = TBVentaMayorista.Text;
            this.Mon_Envio = TBGastodeEnvio.Text;
            this.Mon_Comision = TBValorParaComision.Text;
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

                else if (this.TBIdimpuesto.Text == string.Empty)
                {
                    MensajeError("Por Favor Cargue el Impuesto del Producto a Registrar");
                }
                else if (this.TBIdproveedor.Text == string.Empty)
                {
                    MensajeError("Por Favor Cargue el Proveedor que Distribuye el Producto a Registrar");
                }

                else if (this.CBGrupo.SelectedIndex == 0)
                {
                    MensajeError("Seleccione el Grupo al cual pertenece el Producto");
                }

                // <<<<<<------ Panel Ubicaciones ------>>>>>

                else if (this.CBBodega.SelectedIndex == 0)
                {
                    MensajeError("Seleccione la Bodega donde se Ubicara el Producto");
                    this.TCPrincipal.SelectedIndex = 2;
                    this.TBUbicacion.Select();
                }

                //else if (this.CBVentaPublico.SelectedIndex == 0)
                //{
                //    MensajeError("Por favor Seleccione el valor de Venta Final al Publico");
                //    this.TCPrincipal.SelectedIndex = 1;
                //}

                else
                {
                    //Parametros para poder guardar la imagen del producto

                    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                    this.PB_Imagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    //this.PB_Imagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);

                    byte[] Imagen_Producto = ms.GetBuffer();


                    this.Validaciones_SQL();

                    if (this.Digitar)
                    {
                        rptaDatosBasicos = fProductos.Guardar_DatosBasicos

                            (
                                 //Datos Auxiliares
                                 Convert.ToInt32(this.CBMarca.SelectedValue), Convert.ToInt32(this.CBBodega.SelectedValue), Convert.ToInt32(this.TBIdproveedor.Text),
                                 Convert.ToInt32(this.TBIdimpuesto.Text), Convert.ToInt32(CBEmpaque.SelectedValue), Convert.ToInt32(this.CBGrupo.SelectedValue),
                                 Convert.ToInt32(this.CBTipo.SelectedValue),

                                 //Panel Datos Basicos
                                 this.TBCodigo.Text, this.TBNombre.Text, this.TBReferencia.Text, this.TBDescripcion01.Text, this.TBPresentacion.Text,
                                 this.CBUnidad.Text, this.TBUnidadDeVenta.Text,

                                 Convert.ToInt32(Checkbox_Vencimiento), Convert.ToInt32(Checkbox_Impuesto), Convert.ToInt32(Checkbox_Importado),
                                 Convert.ToInt32(Checkbox_Exportado), Convert.ToInt32(Checkbox_Ofertable), Convert.ToInt32(Checkbox_VentaImpuesto),
                                 Convert.ToInt32(Checkbox_Comision),

                                 //Panel de Valores
                                 this.Mon_Promedio, this.Mon_Final, this.Mon_Excento, this.Mon_NoExcento, this.Mon_Mayorista,
                                 this.TBGastodeEnvio.Text, this.TBComision.Text, this.TBValorParaComision.Text, this.TBCantidadMininaCliente.Text, this.TBCantidadMaximaCliente.Text,
                                 this.TBMinimoMayorista.Text, this.TBMaximoMayorista.Text,
                                 //Panel Ubicaciones
                                 this.TBUbicacion.Text, this.TBEstante.Text, this.TBNivel.Text, Imagen_Producto,

                                 //Panel de Lotes
                                 this.TBLotedeingreso.Text, this.TBValor_Lote.Text, this.DTFechaDeVencimiento.Value,

                                 //Panel Codigo de Barra
                                 this.TBCodigodeBarra.Text,

                                 //Si es igual a 1 se registraran los datos en la base de datos
                                 1
                            );
                    }

                    else
                    {
                        rptaDatosBasicos = fProductos.Editar_DatosBasicos

                            (
                                 //Llave Primaria
                                 Convert.ToInt32(this.TBIdproducto.Text),

                                 //Datos Auxiliares
                                 Convert.ToInt32(this.CBMarca.SelectedValue), Convert.ToInt32(this.CBBodega.SelectedValue), Convert.ToInt32(this.TBIdproveedor.Text),
                                 Convert.ToInt32(this.TBIdimpuesto.Text), Convert.ToInt32(CBEmpaque.SelectedValue), Convert.ToInt32(this.CBGrupo.SelectedValue),
                                 Convert.ToInt32(this.CBTipo.SelectedValue),

                                 //Panel Datos Basicos
                                 this.TBCodigo.Text, this.TBNombre.Text, this.TBReferencia.Text, this.TBDescripcion01.Text, this.TBPresentacion.Text,
                                 this.CBUnidad.Text, this.TBUnidadDeVenta.Text,

                                 Convert.ToInt32(Checkbox_Vencimiento), Convert.ToInt32(Checkbox_Impuesto), Convert.ToInt32(Checkbox_Importado),
                                 Convert.ToInt32(Checkbox_Exportado), Convert.ToInt32(Checkbox_Ofertable), Convert.ToInt32(Checkbox_VentaImpuesto),
                                 Convert.ToInt32(Checkbox_Comision),

                                 //Panel de Valores
                                 this.TBCompraPromedio.Text, this.TBValorFinal.Text, this.TBValorVenta_SinImpuesto.Text, this.TBValorVenta.Text, this.TBVentaMayorista.Text,
                                 this.TBGastodeEnvio.Text, this.TBComision.Text, this.TBValorParaComision.Text, this.TBCantidadMininaCliente.Text, this.TBCantidadMaximaCliente.Text,
                                 this.TBMinimoMayorista.Text, this.TBMaximoMayorista.Text,
                                 //Panel Ubicaciones
                                 this.TBUbicacion.Text, this.TBEstante.Text, this.TBNivel.Text, Imagen_Producto,

                                 //Panel de Lotes
                                 this.TBLotedeingreso.Text, this.TBValor_Lote.Text, this.DTFechaDeVencimiento.Value,

                                 //Panel Codigo de Barra
                                 this.TBCodigodeBarra.Text,

                                 //Si es igual a 1 se registraran los datos en la base de datos
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

        private void btnAgregar_Ubicacion_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Ubicacion_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_CodigoDeBarra_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_CodigosDeBarra_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Lote_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Lotes_Click(object sender, EventArgs e)
        {

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

        //******************** FOCUS ENTER Valores ********************
        
        private void TBValor01_Enter(object sender, EventArgs e)
        {
            //Color de fondo del Texboxt cuando este tiene el FOCUS Activado
            this.TBValorVenta.BackColor = Color.Azure;
        }

        private void TBCantidadMininaCliente_Enter(object sender, EventArgs e)
        {
            //Color de fondo del Texboxt cuando este tiene el FOCUS Activado
            this.TBCantidadMininaCliente.BackColor = Color.Azure;
        }

        private void TBCantidadMaximaCliente_Enter(object sender, EventArgs e)
        {
            //Color de fondo del Texboxt cuando este tiene el FOCUS Activado
            this.TBCantidadMaximaCliente.BackColor = Color.Azure;
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

        //******************** FOCUS ENTER PRECIOS ********************

        private void TBCompraPromedio_Enter(object sender, EventArgs e)
        {
            //Se evalua si el campo de texto esta vacio y se espeicifca que es obligatorio en la base de datos
            if (TBCompraPromedio.Text == string.Empty)
            {
                this.TBCompraPromedio.BackColor = Color.Azure;
                this.TBCompraPromedio.ForeColor = Color.FromArgb(0, 0, 0);
            }
            else 
            {
                //Color de fondo del Texboxt cuando este tiene el FOCUS Activado
                this.TBCompraPromedio.BackColor = Color.Azure;
                this.TBCompraPromedio.ForeColor = Color.FromArgb(0, 0, 0);
            }
        }

        private void TBValorParaComision_Enter(object sender, EventArgs e)
        {
            //Color de fondo del Texboxt cuando este tiene el FOCUS Activado
            this.TBValorParaComision.BackColor = Color.Azure;
        }

        private void TBValordecompra_Enter(object sender, EventArgs e)
        {
            //Color de fondo del Texboxt cuando este tiene el FOCUS Activado
            this.TBValorFinal.BackColor = Color.Azure;
        }
        
        private void TBVentaMayorista_Enter(object sender, EventArgs e)
        {
            //Color de fondo del Texboxt cuando este tiene el FOCUS Activado
            this.TBVentaMayorista.BackColor = Color.Azure;
        }

        private void TBMinimoMayorista_Enter(object sender, EventArgs e)
        {
            //Color de fondo del Texboxt cuando este tiene el FOCUS Activado
            this.TBMinimoMayorista.BackColor = Color.Azure;
        }

        private void TBMaximoMayorista_Enter(object sender, EventArgs e)
        {
            //Color de fondo del Texboxt cuando este tiene el FOCUS Activado
            this.TBMaximoMayorista.BackColor = Color.Azure;
        }


        private void TBGastodeEnvio_Enter(object sender, EventArgs e)
        {
            //Color de fondo del Texboxt cuando este tiene el FOCUS Activado
            this.TBGastodeEnvio.BackColor = Color.Azure;
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

        private void TBUnidadDeVenta_Leave(object sender, EventArgs e)
        {
            this.TBUnidadDeVenta.BackColor = Color.FromArgb(3, 155, 229);
        }

        //************************ SALTO DE LINEAS - PANEL DATOS BASICOS ************************

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
                    this.TBValorFinal.Select();
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
                    this.TBCompraPromedio.Select();
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
                    this.TBCompraPromedio.Select();
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

        private void TBDescripcion01_KeyUp(object sender, KeyEventArgs e)
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
                    this.TBCompraPromedio.Select();
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
                    this.TBCompraPromedio.Select();
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

        //************************ SALTO DE LINEAS - PANEL VALORES ************************

        private void TBCompraPromedio_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar la tecla Enter se realiza Focus al Texboxt Siguiente
                    this.TBValorFinal.Select();
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
                            this.TBCompraPromedio.Select();
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
                            this.TBCompraPromedio.Select();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }


        private void TBValorVenta_SinImpuesto_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
                {
                    if (CBVentaImpuesto.Checked)
                    {
                        //Al precionar la tecla Enter se realiza Focus al Texboxt Siguiente
                        this.TBValorVenta.Select();
                    }
                    else
                    {
                        this.TBVentaMayorista.Select();
                    }
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
                            this.TBValorVenta_SinImpuesto.Select();
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
                            this.TBValorVenta_SinImpuesto.Select();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void TBValorFinal_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar la tecla Enter se realiza Focus al Texboxt Siguiente

                    this.TBValorVenta_SinImpuesto.Select();
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
                            this.TBValorFinal.Select();
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
                            this.TBValorFinal.Select();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        
        private void TBValorVenta_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar la tecla Enter se realiza Focus al Texboxt Siguiente

                    this.TBVentaMayorista.Select();
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
                            this.TBValorVenta.Select();
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
                            this.TBValorVenta.Select();
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

                    this.TBMinimoMayorista.Select();
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

        private void TBOtrosGastos_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar la tecla Enter se realiza Focus al Texboxt Siguiente

                    this.TBValorFinal.Select();
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
                            //this.TBOtrosGastos.Select();
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
                            //this.TBOtrosGastos.Select();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        //************************ SALTO DE LINEAS - PANEL UBICACIONES ************************

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

                    this.TCPrincipal.SelectedIndex = 4;
                    this.TBLotedeingreso.Select();
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

                    this.TCPrincipal.SelectedIndex = 4;
                    this.TBLotedeingreso.Select();
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

                    this.TCPrincipal.SelectedIndex = 4;
                    this.TBLotedeingreso.Select();
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

        //************************ SALTO DE LINEAS - PANEL LOTES ************************

        private void TBLotedeingreso_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar la tecla Enter se realiza Focus al Texboxt Siguiente

                    this.TBValor_Lote.Select();
                }

                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Tab))
                {
                    //Al precionar la tecla Control+TAB Se cambia al campo de Texto TBBuscar
                    //Para realizar consultas en el sistema Y se realiza Focus al primer Texboxt

                    this.TCPrincipal.SelectedIndex = 5;
                    this.TBCodigodeBarra.Select();
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

        private void TBValor_Lote_KeyUp(object sender, KeyEventArgs e)
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

                    this.TCPrincipal.SelectedIndex = 5;
                    this.TBCodigodeBarra.Select();
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
                            this.TBValor_Lote.Select();
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
                            this.TBValor_Lote.Select();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void CBVencimiento_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CBImpuesto_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TBValorFinal_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }

            //permitir teclas de control como retroceso
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void TBValorVenta_SinImpuesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }

            //permitir teclas de control como retroceso
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void TBValorVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }

            //permitir teclas de control como retroceso
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void TBVentaMayorista_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }

            //permitir teclas de control como retroceso
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void TBGastodeEnvio_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }

            //permitir teclas de control como retroceso
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void TBComision_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }

            //permitir teclas de control como retroceso
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void TBValorParaComision_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }

            //permitir teclas de control como retroceso
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void TBCantidadMininaCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }

            //permitir teclas de control como retroceso
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void TBCantidadMaximaCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }

            //permitir teclas de control como retroceso
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void TBMinimoMayorista_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }

            //permitir teclas de control como retroceso
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void TBMaximoMayorista_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }

            //permitir teclas de control como retroceso
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void TBValorComisionar_Leave(object sender, EventArgs e)
        {
            // El control TextBox ha perdido el foco. Referenciamos el control TextBox que ha desencadenado el evento.
            TextBox tb = (TextBox)sender;

            // Primero verificamos si el valor se puede convertir a Decimal.
            double numero = default(double);
            bool bln = double.TryParse(tb.Text, out numero);

            if ((!(bln)))
            {
                // No es un valor decimal válido; limpiamos el control.
                //tb.Clear();
                return;
            }

            // En la propiedad Tag guardamos el valor con todos los decimales.
            //
            tb.Tag = numero;

            // Y acto seguido formateamos el valor
            // a monetario con dos decimales.
            //
            tb.Text = string.Format("{0:N2}", numero);
        }

        private void TBCompraPromedio_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }

            //permitir teclas de control como retroceso
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void CBProductosOfertable_CheckedChanged(object sender, EventArgs e)
        {

        }
        
        private void CBImportado_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CBExportado_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CBVentaImpuesto_CheckedChanged(object sender, EventArgs e)
        {
            if (CBVentaImpuesto.Checked)
            {
                this.TBValorVenta.Enabled = true;
                this.TBValorVenta.BackColor = Color.FromArgb(3, 155, 229);
            }
            else
            {
                this.TBValorVenta.Enabled = false;
                this.TBValorVenta.BackColor = Color.FromArgb(72, 209, 204);
            }
        }

        private void CBManejaComision_CheckedChanged(object sender, EventArgs e)
        {
            if (CBManejaComision.Checked)
            {
                this.TBComision.Enabled = true;
                this.TBComision.BackColor = Color.FromArgb(3, 155, 229);
                
                this.TBValorParaComision.Enabled = true;
                this.TBValorParaComision.BackColor = Color.FromArgb(3, 155, 229);
            }
            else
            {
                this.TBComision.Enabled = false;
                this.TBComision.BackColor = Color.FromArgb(72, 209, 204);

                this.TBValorParaComision.Enabled = false;
                this.TBValorParaComision.BackColor = Color.FromArgb(72, 209, 204);
            }
        }

        private void TBValorGeneral_Lote_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void TBMinimoMayorista_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBCompraPromedio_Leave(object sender, EventArgs e)
        {
            if (TBCompraPromedio.Text == string.Empty)
            {
                //Color de texboxt cuando este posee el FOCUS Activado
                this.TBCompraPromedio.BackColor = Color.FromArgb(3, 155, 229);
            }
            else
            {
                this.TBCompraPromedio.BackColor = Color.FromArgb(3, 155, 229);
                               
                // El control TextBox ha perdido el foco. Referenciamos el control TextBox que ha desencadenado el evento.
                TextBox tb = (TextBox)sender;

                // Primero verificamos si el valor se puede convertir a Decimal.
                double numero = default(double);
                bool bln = double.TryParse(tb.Text, out numero);

                if ((!(bln)))
                {
                    // No es un valor decimal válido; limpiamos el control.
                    //tb.Clear();
                    return;
                }

                // En la propiedad Tag guardamos el valor con todos los decimales.
                //
                tb.Tag = numero;

                // Y acto seguido formateamos el valor
                // a monetario con dos decimales.
                //
                tb.Text = string.Format("{0:N2}", numero);
            }
           
        }

        private void TBVentaMayorista_Leave(object sender, EventArgs e)
        {
            //Color de texboxt cuando este posee el FOCUS Activado
            this.TBVentaMayorista.BackColor = Color.FromArgb(3, 155, 229);

            // El control TextBox ha perdido el foco. Referenciamos el control TextBox que ha desencadenado el evento.
            TextBox tb = (TextBox)sender;

            // Primero verificamos si el valor se puede convertir a Decimal.
            double numero = default(double);
            bool bln = double.TryParse(tb.Text, out numero);

            if ((!(bln)))
            {
                // No es un valor decimal válido; limpiamos el control.
                //tb.Clear();
                return;
            }

            // En la propiedad Tag guardamos el valor con todos los decimales.
            //
            tb.Tag = numero;

            // Y acto seguido formateamos el valor
            // a monetario con dos decimales.
            //
            tb.Text = string.Format("{0:N2}", numero);
        }

        private void TBComision_Enter(object sender, EventArgs e)
        {
            //Color de fondo del Texboxt cuando este tiene el FOCUS Activado
            this.TBComision.BackColor = Color.Azure;
        }

        private void TBComision_Leave(object sender, EventArgs e)
        {
            //Color de texboxt cuando este posee el FOCUS Activado
            this.TBComision.BackColor = Color.FromArgb(3, 155, 229);
        }

        private void TBVentaMayorista_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar la tecla Enter se realiza Focus al Texboxt Siguiente

                    this.TBGastodeEnvio.Select();
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
                            this.TBVentaMayorista.Select();
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
                            this.TBVentaMayorista.Select();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void TBGastodeEnvio_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
                {
                    if (CBManejaComision.Checked)
                    {
                        //Al precionar la tecla Enter se realiza Focus al Texboxt Siguiente
                        this.TBComision.Select();
                    }
                    else if (CBManejaComision.Checked == false)
                    {
                        this.TBCantidadMininaCliente.Select();
                    }
                    
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
                            this.TBGastodeEnvio.Select();
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
                            this.TBGastodeEnvio.Select();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void TBComision_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
                {
                    if (CBManejaComision.Checked)
                    {
                        //Al precionar la tecla Enter se realiza Focus al Texboxt Siguiente
                        this.TBValorParaComision.Select();
                    }
                    else
                    {
                        this.TBCantidadMininaCliente.Select();
                    }
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
                            this.TBComision.Select();
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
                            this.TBComision.Select();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void TBValorParaComision_KeyUp(object sender, KeyEventArgs e)
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
                            this.TBValorParaComision.Select();
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
                            this.TBValorParaComision.Select();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void TBMinimoMayorista_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar la tecla Enter se realiza Focus al Texboxt Siguiente

                    this.TBMaximoMayorista.Select();
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
                            this.TBMinimoMayorista.Select();
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
                            this.TBMinimoMayorista.Select();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void TBMaximoMayorista_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar la tecla Enter se realiza Focus al Texboxt Siguiente

                    this.TBCompraPromedio.Select();
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
                            this.TBMaximoMayorista.Select();
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
                            this.TBMaximoMayorista.Select();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void TBValorParaComision_Leave(object sender, EventArgs e)
        {
            //Color de texboxt cuando este posee el FOCUS Activado
            this.TBValorParaComision.BackColor = Color.FromArgb(3, 155, 229);

            // El control TextBox ha perdido el foco. Referenciamos el control TextBox que ha desencadenado el evento.
            TextBox tb = (TextBox)sender;

            // Primero verificamos si el valor se puede convertir a Decimal.
            double numero = default(double);
            bool bln = double.TryParse(tb.Text, out numero);

            if ((!(bln)))
            {
                // No es un valor decimal válido; limpiamos el control.
                //tb.Clear();
                return;
            }

            // En la propiedad Tag guardamos el valor con todos los decimales.
            //
            tb.Tag = numero;

            // Y acto seguido formateamos el valor
            // a monetario con dos decimales.
            //
            tb.Text = string.Format("{0:N2}", numero);
        }

        private void TBCantidadMininaCliente_Leave(object sender, EventArgs e)
        {
            //Color de texboxt cuando este posee el FOCUS Activado
            this.TBCantidadMininaCliente.BackColor = Color.FromArgb(3, 155, 229);
        }

        private void TBCantidadMaximaCliente_Leave(object sender, EventArgs e)
        {
            //Color de texboxt cuando este posee el FOCUS Activado
            this.TBCantidadMaximaCliente.BackColor = Color.FromArgb(3, 155, 229);
        }

        private void TBMinimoMayorista_Leave(object sender, EventArgs e)
        {
            //Color de texboxt cuando este posee el FOCUS Activado
            this.TBMinimoMayorista.BackColor = Color.FromArgb(3, 155, 229);
        }

        private void TBMaximoMayorista_Leave(object sender, EventArgs e)
        {
            //Color de texboxt cuando este posee el FOCUS Activado
            this.TBMaximoMayorista.BackColor = Color.FromArgb(3, 155, 229);
        }

        private void TBCodigodeBarra_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Tab))
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

        private void btnExaminar_Proveedor_Click(object sender, EventArgs e)
        {
            frmFiltro_Proveedor frmFiltro_Proveedor = new frmFiltro_Proveedor();
            frmFiltro_Proveedor.ShowDialog();
        }

        private void btnExaminar_Impuesto_Click(object sender, EventArgs e)
        {
            frmFiltro_Impuestos frmFiltro_Impuestos = new frmFiltro_Impuestos();
            frmFiltro_Impuestos.ShowDialog();
        }

        //******************** FOCUS LEAVE VALORES ********************

        private void TBValordecompra_Leave(object sender, EventArgs e)
        {
            //Color de texboxt cuando este posee el FOCUS Activado
            this.TBValorFinal.BackColor = Color.FromArgb(3, 155, 229);

            // El control TextBox ha perdido el foco. Referenciamos el control TextBox que ha desencadenado el evento.
            TextBox tb = (TextBox)sender;

            // Primero verificamos si el valor se puede convertir a Decimal.
            double numero = default(double);
            bool bln = double.TryParse(tb.Text, out numero);

            if ((!(bln)))
            {
                // No es un valor decimal válido; limpiamos el control.
                //tb.Clear();
                return;
            }

            // En la propiedad Tag guardamos el valor con todos los decimales.
            //
            tb.Tag = numero;

            // Y acto seguido formateamos el valor
            // a monetario con dos decimales.
            //
            tb.Text = string.Format("{0:N2}", numero);
        }

        private void TBValorVenta_Leave(object sender, EventArgs e)
        {
            //Color de texboxt cuando este posee el FOCUS Activado
            this.TBValorVenta.BackColor = Color.FromArgb(3, 155, 229);

            // El control TextBox ha perdido el foco. Referenciamos el control TextBox que ha desencadenado el evento.
            TextBox tb = (TextBox)sender;

            // Primero verificamos si el valor se puede convertir a Decimal.
            double numero = default(double);
            bool bln = double.TryParse(tb.Text, out numero);

            if ((!(bln)))
            {
                // No es un valor decimal válido; limpiamos el control.
                //tb.Clear();
                return;
            }

            // En la propiedad Tag guardamos el valor con todos los decimales.
            //
            tb.Tag = numero;

            // Y acto seguido formateamos el valor
            // a monetario con dos decimales.
            //
            tb.Text = string.Format("{0:N2}", numero);
        }

        private void TBLotedeingreso_Enter(object sender, EventArgs e)
        {
            this.TBLotedeingreso.BackColor = Color.Azure;
        }

        private void TBValor_Lote_Enter(object sender, EventArgs e)
        {
            this.TBValor_Lote.BackColor = Color.Azure;
        }

        private void TBLotedeingreso_Leave(object sender, EventArgs e)
        {
            this.TBLotedeingreso.BackColor = Color.FromArgb(3, 155, 229);
        }

        private void TBValor_Lote_Leave(object sender, EventArgs e)
        {
            this.TBValor_Lote.BackColor = Color.FromArgb(3, 155, 229);
        }

        private void TBCodigodeBarra_Enter(object sender, EventArgs e)
        {
            this.TBCodigodeBarra.BackColor = Color.Azure;
        }

        private void TBCodigodeBarra_Leave(object sender, EventArgs e)
        {
            this.TBCodigodeBarra.BackColor = Color.FromArgb(3, 155, 229);
        }

        private void frmProductos_FormClosing(object sender, FormClosingEventArgs e)
        {
            _Instancia = null;
        }

        private void CBUnidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBUnidad.SelectedIndex == 0)
            {
                this.TBUnidadDeVenta.Enabled = false;
                this.TBUnidadDeVenta.BackColor = Color.FromArgb(72, 209, 204);
            }
            else
            {
                this.TBUnidadDeVenta.Enabled = true;
                this.TBUnidadDeVenta.BackColor = Color.FromArgb(3, 155, 229);
            }
        }

        private void TBValorVenta_SinImpuesto_Enter(object sender, EventArgs e)
        {
            //Color de fondo del Texboxt cuando este tiene el FOCUS Activado
            this.TBValorVenta_SinImpuesto.BackColor = Color.Azure;
        }

        private void TBValorVenta_SinImpuesto_Leave(object sender, EventArgs e)
        {
            //Color de texboxt cuando este posee el FOCUS Activado
            this.TBValorVenta_SinImpuesto.BackColor = Color.FromArgb(3, 155, 229);

            // El control TextBox ha perdido el foco. Referenciamos el control TextBox que ha desencadenado el evento.
            TextBox tb = (TextBox)sender;

            // Primero verificamos si el valor se puede convertir a Decimal.
            double numero = default(double);
            bool bln = double.TryParse(tb.Text, out numero);

            if ((!(bln)))
            {
                // No es un valor decimal válido; limpiamos el control.
                //tb.Clear();
                return;
            }

            // En la propiedad Tag guardamos el valor con todos los decimales.
            //
            tb.Tag = numero;

            // Y acto seguido formateamos el valor
            // a monetario con dos decimales.
            //
            tb.Text = string.Format("{0:N2}", numero);
        }


        private void TBGastodeEnvio_Leave(object sender, EventArgs e)
        {
            //Color de texboxt cuando este posee el FOCUS Activado
            this.TBGastodeEnvio.BackColor = Color.FromArgb(3, 155, 229);

            // El control TextBox ha perdido el foco. Referenciamos el control TextBox que ha desencadenado el evento.
            TextBox tb = (TextBox)sender;

            // Primero verificamos si el valor se puede convertir a Decimal.
            double numero = default(double);
            bool bln = double.TryParse(tb.Text, out numero);

            if ((!(bln)))
            {
                // No es un valor decimal válido; limpiamos el control.
                //tb.Clear();
                return;
            }

            // En la propiedad Tag guardamos el valor con todos los decimales.
            //
            tb.Tag = numero;

            // Y acto seguido formateamos el valor
            // a monetario con dos decimales.
            //
            tb.Text = string.Format("{0:N2}", numero);
        }

        private void TBUnidadDeVenta_Enter(object sender, EventArgs e)
        {
            //Color de texboxt cuando este posee el FOCUS Activado
            this.TBUnidadDeVenta.BackColor = Color.Azure;
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

        private void TBBuscar_Enter(object sender, EventArgs e)
        {
            this.TBBuscar.BackColor = Color.Azure;
        }

        private void TBBuscar_Leave(object sender, EventArgs e)
        {
            this.TBBuscar.BackColor = Color.FromArgb(3, 155, 229);
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
                        this.DGResultados.Columns[0].Visible = false;

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
                    Idgrupo = Datos.Rows[0][1].ToString();
                    Idtipo = Datos.Rows[0][2].ToString();
                    Idempaque = Datos.Rows[0][3].ToString();
                    Idbodega = Datos.Rows[0][4].ToString();
                    Idproveedor = Datos.Rows[0][5].ToString();
                    Idimpuesto = Datos.Rows[0][6].ToString();

                    //Panel Datos Basicos
                    Codigo = Datos.Rows[0][7].ToString();
                    Nombre = Datos.Rows[0][8].ToString();
                    Referencia = Datos.Rows[0][9].ToString();
                    Descripcion = Datos.Rows[0][10].ToString();
                    Presentacion = Datos.Rows[0][11].ToString();
                    Proveedor = Datos.Rows[0][12].ToString();
                    Impuesto = Datos.Rows[0][13].ToString();
                    Impuesto_Valor = Datos.Rows[0][14].ToString();
                    UnidadDeVenta = Datos.Rows[0][15].ToString();
                    ValorUnidad = Datos.Rows[0][16].ToString();
                    ManejaVencimiento = Datos.Rows[0][17].ToString();
                    ManjenaImpuesto = Datos.Rows[0][18].ToString();
                    Importado = Datos.Rows[0][19].ToString();
                    Exportado = Datos.Rows[0][20].ToString();
                    Ofertable = Datos.Rows[0][21].ToString();
                    VentaImpuesto = Datos.Rows[0][22].ToString();
                    ComisionEmpleado = Datos.Rows[0][23].ToString();

                    //Panel - Valores
                    Valor_Promedio = Datos.Rows[0][24].ToString();
                    Valor_Final = Datos.Rows[0][25].ToString();
                    Valor_Excento = Datos.Rows[0][26].ToString();
                    Valor_NoExcento = Datos.Rows[0][27].ToString();
                    Valor_Mayorista = Datos.Rows[0][28].ToString();
                    GastoDeEnvio = Datos.Rows[0][29].ToString();
                    Comision = Datos.Rows[0][30].ToString();
                    Valor_Comision = Datos.Rows[0][31].ToString();
                    Minimo_Cliente = Datos.Rows[0][32].ToString();
                    Maximo_Cliente = Datos.Rows[0][33].ToString();
                    Minimo_Mayorista = Datos.Rows[0][34].ToString();
                    Maximo_Mayorista = Datos.Rows[0][35].ToString();

                    //
                    Ubicacion = Datos.Rows[0][36].ToString();
                    Estante = Datos.Rows[0][37].ToString();
                    Nivel = Datos.Rows[0][38].ToString();
                    Imagen = Datos.Rows[0][39].ToString();

                    //
                    Lote = Datos.Rows[0][40].ToString();
                    Valor_Lote = Datos.Rows[0][41].ToString();
                    Fecha_Vencimiento = Datos.Rows[0][42].ToString();
                    
                    //
                    CodigoDeBarra = Datos.Rows[0][43].ToString();
                    

                    //Se procede a completar los campos de texto segun las consulta
                    //Realizada anteriormente en la base de datos

                    this.Marca_SQL = Idmarca;
                    this.CBMarca.SelectedValue = Marca_SQL;
                    
                    this.Grupo_SQL = Idgrupo;
                    this.CBGrupo.SelectedValue = Grupo_SQL;

                    this.Tipo_SQL = Idtipo;
                    this.CBTipo.SelectedValue = Tipo_SQL;

                    this.Empaque_SQL = Idempaque;
                    this.CBEmpaque.SelectedValue = Empaque_SQL;

                    this.Bodega_SQL = Idbodega;
                    this.CBBodega.SelectedValue = Bodega_SQL;

                    //Panel Datos Basicos
                    this.TBCodigo.Text = Codigo;
                    this.TBIdproveedor.Text = Idproveedor;
                    this.TBIdimpuesto.Text = Idimpuesto;

                    //Panel Datos Basicos
                    this.TBCodigo.Text = Codigo;
                    this.TBNombre.Text = Nombre;
                    this.TBReferencia.Text = Referencia;
                    this.TBDescripcion01.Text = Descripcion;
                    this.TBPresentacion.Text = Presentacion;
                    this.CBUnidad.Text = UnidadDeVenta;
                    this.TBUnidadDeVenta.Text = ValorUnidad;
                    
                    //Panel - Valores
                    this.TBCompraPromedio.Text = Valor_Promedio;
                    this.TBValorFinal.Text = Valor_Final;
                    this.TBValorVenta_SinImpuesto.Text = Valor_Excento;
                    this.TBValorVenta.Text = Valor_NoExcento;
                    this.TBVentaMayorista.Text = Valor_Mayorista;
                    this.TBGastodeEnvio.Text = GastoDeEnvio;
                    this.TBComision.Text = Comision;
                    this.TBValorParaComision.Text = Valor_Comision;
                    this.TBCantidadMininaCliente.Text = Minimo_Cliente;
                    this.TBCantidadMaximaCliente.Text = Maximo_Cliente;
                    this.TBMinimoMayorista.Text = Minimo_Mayorista;
                    this.TBMaximoMayorista.Text = Maximo_Mayorista;

                    //
                    this.TBUbicacion.Text = Ubicacion;
                    this.TBEstante.Text = Estante;
                    this.TBNivel.Text = Nivel;
                    //this.PB_Imagen.Image = Imagen;

                    //
                    this.TBLotedeingreso.Text = Lote;
                    this.TBValor_Lote.Text = Valor_Lote;
                    this.DTFechaDeVencimiento.Text = Fecha_Vencimiento;

                    //
                    this.TBCodigodeBarra.Text = CodigoDeBarra;
                    this.TBProveedor.Text = Proveedor;
                    this.TBImpuesto.Text = Impuesto;
                    this.TBImpuesto_Valor.Text = Impuesto_Valor;

                    //Se proceden a Validar los Chexboxt si estan activos o no

                    if (ManejaVencimiento == "0")
                    {
                        this.CBVencimiento.Checked = false;
                    }
                    else
                    {
                        this.CBVencimiento.Checked = true;
                    }

                    if (Importado == "0")
                    {
                        this.CBImportado.Checked = false;
                    }
                    else
                    {
                        this.CBImportado.Checked = true;
                    }

                    if (Exportado == "0")
                    {
                        this.CBExportado.Checked = false;
                    }
                    else
                    {
                        this.CBExportado.Checked = true;
                    }

                    if (ManjenaImpuesto == "0")
                    {
                        this.CBImpuesto.Checked = false;
                    }
                    else
                    {
                        this.CBImpuesto.Checked = true;
                    }

                    if (Ofertable == "0")
                    {
                        this.CBOfertable.Checked = false;
                    }
                    else
                    {
                        this.CBOfertable.Checked = true;
                    }

                    if (VentaImpuesto == "0")
                    {
                        this.CBVentaImpuesto.Checked = false;
                    }
                    else
                    {
                        this.CBVentaImpuesto.Checked = true;
                    }

                    if (ComisionEmpleado == "0")
                    {
                        this.CBManejaComision.Checked = false;
                    }
                    else
                    {
                        this.CBManejaComision.Checked = true;
                    }

                    //Se realizan las consultas para llenar los DataGriview donde se mostrarian las ubicaciones, codigos de barra.

                    //this.DGResultados.DataSource = fProductos.Buscar(this.TBBuscar.Text, 1);
                    //this.DGResultados.Columns[0].Visible = false;

                    //lblTotal.Text = "Datos Registrados: " + Convert.ToString(DGResultados.Rows.Count);

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
                    this.TBIdproducto.Text = Convert.ToString(this.DGResultados.CurrentRow.Cells["ID"].Value);
                    this.TBNombre.Select();

                    //
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
