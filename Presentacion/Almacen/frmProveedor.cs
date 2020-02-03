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
    public partial class frmProveedor : Form
    {
        // Variable con la cual se define si el procecimiento 
        // A realizar es Editar, Guardar, Buscar,Eliminar
        private bool Digitar = true;

        //Variable para Metodo SQL Guardar, Eliminar, Editar, Consultar
        public string Guardar = "";
        public string Editar = "";
        public string Consultar = "";
        public string Eliminar = "";
        public string Imprimir = "";

        //Parametros para AutoCompletar los Texboxt

        private string Campo = "Campo Obligatorio - Leal Enterprise";

        //Panel Datos Basicos
        public string Idproveedor = "";
        public string Proveedor = "";
        public string Documento = "";
        public string Representante = "";
        public string Telefono = "";
        public string Movil = "";
        public string Correo = "";
        public string Pais = "";
        public string Ciudad = "";
        public string Nacionalidad = "";
        public string FechaDeInicio = "";

        //Panel Datos de Envio
        public string Pais_DE = "";
        public string Ciudad_DE = "";
        public string DireccionPrincipal = "";
        public string Direccion01 = "";
        public string Direccion02 = "";
        public string Receptor = "";
        public string Observacion = "";

        //Panel Datos Financiero
        public string Retencion = "";
        public string Valor_Retencion = "";
        public string Moneda = "";
        public string BancoPrincipal = "";
        public string BancoAuxiliar = "";
        public string Cuenta01 = "";
        public string Cuenta02 = "";
        public string CreditoMinimo = "";
        public string CreditoMaximo = "";
        public string UltimoCredito = "";
        public string Mora = "";
        public string TotalCredito = "";
        public string Prorroga = "";
        public frmProveedor()
        {
            InitializeComponent();
        }

        private void frmProveedor_Load(object sender, EventArgs e)
        {
            //Inicio de Clase y Botones
            this.Botones();
            this.Habilitar();
            this.CBTipo.SelectedIndex = 0;
            this.CBMoneda.SelectedIndex = 0;
            this.CBRetencion.SelectedIndex = 0;
            
            //Focus a Texboxt
            this.TBNombre.Select();

            //Ocultacion de Texboxt
            this.TBIdproveedor.Visible = false;
            this.DGResultados.Enabled = false;

            //Color para Texboxt Buscar
            this.TBBuscar.BackColor = Color.FromArgb(3, 155, 229);
        }

        private void Habilitar()
        {
            //Panel - Datos Basicos  
            //this.TBCodigo.Enabled = false;

            this.TBNombre.ReadOnly = false;
            this.TBNombre.BackColor = Color.FromArgb(3, 155, 229);
            this.TBDocumento.ReadOnly = false;
            this.TBDocumento.BackColor = Color.FromArgb(3, 155, 229);
            this.TBRepresentante.ReadOnly = false;
            this.TBRepresentante.BackColor = Color.FromArgb(3, 155, 229);
            this.TBPais.ReadOnly = false;
            this.TBPais.BackColor = Color.FromArgb(3, 155, 229);
            this.TBCiudad.ReadOnly = false;
            this.TBCiudad.BackColor = Color.FromArgb(3, 155, 229);
            this.TBNacionalidad.ReadOnly = false;
            this.TBNacionalidad.BackColor = Color.FromArgb(3, 155, 229);
            this.TBTelefono.ReadOnly = false;
            this.TBTelefono.BackColor = Color.FromArgb(3, 155, 229);
            this.TBMovil.ReadOnly = false;
            this.TBMovil.BackColor = Color.FromArgb(3, 155, 229);
            this.TBCorreo.ReadOnly = false;
            this.TBCorreo.BackColor = Color.FromArgb(3, 155, 229);

            //Panel - Otros Datos
            this.TBPais_01.ReadOnly = false;
            this.TBPais_01.BackColor = Color.FromArgb(3, 155, 229);
            this.TBCiudad_01.ReadOnly = false;
            this.TBCiudad_01.BackColor = Color.FromArgb(3, 155, 229);
            this.TBDireccionPrincipal.ReadOnly = false;
            this.TBDireccionPrincipal.BackColor = Color.FromArgb(3, 155, 229);
            this.TBDireccion01.ReadOnly = false;
            this.TBDireccion01.BackColor = Color.FromArgb(3, 155, 229);
            this.TBDireccion02.ReadOnly = false;
            this.TBDireccion02.BackColor = Color.FromArgb(3, 155, 229);
            this.TBReceptor.ReadOnly = false;
            this.TBReceptor.BackColor = Color.FromArgb(3, 155, 229);
            this.TBObservacion.ReadOnly = false;
            this.TBObservacion.BackColor = Color.FromArgb(3, 155, 229);

            //
            this.TBValorRetencion.ReadOnly = false;
            this.TBValorRetencion.BackColor = Color.FromArgb(3, 155, 229);
            this.TBBancoPrincipal.ReadOnly = false;
            this.TBBancoPrincipal.BackColor = Color.FromArgb(3, 155, 229);
            this.TBCuenta01.ReadOnly = false;
            this.TBCuenta01.BackColor = Color.FromArgb(3, 155, 229);
            this.TBCuenta02.ReadOnly = false;
            this.TBCuenta02.BackColor = Color.FromArgb(3, 155, 229);
            this.TBBancoAuxiliar.ReadOnly = false;
            this.TBBancoAuxiliar.BackColor = Color.FromArgb(3, 155, 229);
            this.TBCreditoMinimo.ReadOnly = false;
            this.TBCreditoMinimo.BackColor = Color.FromArgb(3, 155, 229);
            this.TBCreditoMaximo.ReadOnly = false;
            this.TBCreditoMaximo.BackColor = Color.FromArgb(3, 155, 229);
            this.TBUltimoCredito.ReadOnly = false;
            this.TBUltimoCredito.BackColor = Color.FromArgb(3, 155, 229);
            this.TBCreditoMora.ReadOnly = false;
            this.TBCreditoMora.BackColor = Color.FromArgb(3, 155, 229);
            this.TBCreditoTotal.ReadOnly = false;
            this.TBCreditoTotal.BackColor = Color.FromArgb(3, 155, 229);
            this.TBDiasProrroga.ReadOnly = false;
            this.TBDiasProrroga.BackColor = Color.FromArgb(3, 155, 229);
        }

        private void Limpiar_Datos()
        {
            //Panel - Datos Basicos
            this.TBIdproveedor.Clear();
            this.CBTipo.SelectedIndex = 0;
            this.TBNombre.Clear();
            this.TBDocumento.Clear();
            this.TBRepresentante.Clear();
            this.TBCiudad.Clear();
            this.TBTelefono.Clear();
            this.TBMovil.Clear();
            this.TBPais.Clear();
            this.TBNacionalidad.Clear();
            this.TBCorreo.Clear();

            //Panel - Datos de Envio
            this.TBPais_01.Clear();
            this.TBCiudad_01.Clear();
            this.TBDireccionPrincipal.Clear();
            this.TBDireccion02.Clear();
            this.TBDireccion01.Clear();
            this.TBReceptor.Clear();
            this.TBObservacion.Clear();


            //Datos Financieros
            this.CBMoneda.SelectedIndex = 0;
            this.CBRetencion.SelectedIndex = 0;
            this.TBValorRetencion.Clear();
            this.TBBancoPrincipal.Clear();
            this.TBCuenta01.Clear();
            this.TBCuenta02.Clear();
            this.TBBancoAuxiliar.Clear();
            this.TBCreditoMinimo.Clear();
            this.TBCreditoMaximo.Clear();
            this.TBCreditoMaximo.Clear();
            this.TBUltimoCredito.Clear();
            this.TBCreditoMora.Clear();
            this.TBCreditoTotal.Clear();
            this.TBDiasProrroga.Clear();
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

        //private void Combobox_Sucurzal()
        //{
        //    try
        //    {
        //        this.TBRepresentante.DataSource = fSistema_Sucurzal.Mostrar();
        //        this.TBRepresentante.ValueMember = "Cliente";
        //        this.TBRepresentante.DisplayMember = "Nombre";
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message + ex.StackTrace);
        //    }
        //}

        private void Guardar_SQL()
        {
            try
            {
                string rptaDatosBasicos = "";

                // <<<<<<------ Panel Datos Basicos ------>>>>>

                if (this.TBNombre.Text == Campo)
                {
                    MensajeError("Ingrese el nombre del Cliente a registrar");
                }
                else if (this.TBDocumento.Text == Campo)
                {
                    MensajeError("Ingrese el numero del Documento del Cliente");
                }
                else if (this.TBCodigo.Text == Campo)
                {
                    MensajeError("Ingrese el Codigo del Cliente");
                }
                else if (this.CBTipo.SelectedIndex == 0)
                {
                    MensajeError("Seleccione el Tipo de Cliente");
                }

                else
                {
                    if (this.Digitar)
                    {
                        rptaDatosBasicos = fProveedor.Guardar_DatosBasicos

                            (
                                
                                //Datos Auxiliares y llave primaria
                                1,

                                //Panel Datos Basicos
                                this.CBTipo.Text, this.TBNombre.Text, this.TBDocumento.Text, this.TBRepresentante.Text, this.TBPais.Text,
                                this.TBCiudad.Text, this.TBNacionalidad.Text, this.TBTelefono.Text, this.TBMovil.Text, this.TBCorreo.Text, this.DTFechadeinicio.Value,

                                //Panel Datos De Envio
                                this.TBPais_01.Text, this.TBCiudad_01.Text, this.TBDireccionPrincipal.Text, this.TBDireccion01.Text,
                                this.TBDireccion02.Text, this.TBReceptor.Text, this.TBObservacion.Text,

                                //Panel Datos Financieros
                                this.CBRetencion.Text, this.TBValorRetencion.Text, this.TBBancoPrincipal.Text, this.TBBancoAuxiliar.Text, this.TBCuenta01.Text, this.TBCuenta02.Text,
                                this.TBCreditoMinimo.Text, this.TBCreditoMaximo.Text, this.TBUltimoCredito.Text, this.TBCreditoMora.Text,
                                this.TBCreditoTotal.Text, 1
                            );
                    }

                    else
                    {
                        rptaDatosBasicos = fProveedor.Editar_DatosBasicos

                            (
                                 //Datos Auxiliares y llave primaria
                                 2, Convert.ToInt32(this.TBIdproveedor.Text),

                                 //Panel Datos Basicos
                                 this.CBTipo.Text, this.TBNombre.Text, this.TBDocumento.Text, this.TBRepresentante.Text, this.TBPais.Text,
                                 this.TBCiudad.Text, this.TBNacionalidad.Text, this.TBTelefono.Text, this.TBMovil.Text, this.TBCorreo.Text, this.DTFechadeinicio.Value,

                                 //Panel Datos De Envio
                                 this.TBPais_01.Text, this.TBCiudad_01.Text, this.TBDireccionPrincipal.Text, this.TBDireccion01.Text,
                                 this.TBDireccion02.Text, this.TBReceptor.Text, this.TBObservacion.Text,

                                //Panel Datos Financieros
                                this.CBRetencion.Text, this.TBValorRetencion.Text, this.TBBancoPrincipal.Text, this.TBBancoAuxiliar.Text, this.TBCuenta01.Text, this.TBCuenta02.Text,
                                this.TBCreditoMinimo.Text, this.TBCreditoMaximo.Text, this.TBUltimoCredito.Text, this.TBCreditoMora.Text,
                                this.TBCreditoTotal.Text, 1
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
                        MessageBox.Show("El Usuario Iniciado Actualmente no Contiene Permisos Para Guardar", "Leal Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                        MessageBox.Show("Acceso Denegado Para Editar los Registros", "Leal Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }

                //Se restablece la imagen predeterminada del boton
                this.btnGuardar.Image = Properties.Resources.BV_Guardar;
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
                this.Digitar = true;
                this.Botones();

                this.Limpiar();
                this.TBBuscar.Clear();

                //Se Limpian las Filas y Columnas de la tabla
                DGResultados.DataSource = null;
                this.DGResultados.Enabled = false;
                this.lblTotal.Text = "Datos Registrados: 0";

                //Se restablece la imagen predeterminada del boton
                this.btnGuardar.Image = Properties.Resources.BV_Guardar;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Eliminar == "1")
                {

                    DialogResult Opcion;
                    string Respuesta = "";
                    int Eliminacion;

                    Opcion = MessageBox.Show("Desea Eliminar el Registro Seleccionado", "Leal Enterprise", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (Opcion == DialogResult.OK)
                    {
                        if (DGResultados.SelectedRows.Count > 0)
                        {
                            Eliminacion = Convert.ToInt32(DGResultados.CurrentRow.Cells["Codigo"].Value.ToString());
                            Respuesta = Negocio.fProveedor.Eliminar(Eliminacion, 0);
                        }

                        if (Respuesta.Equals("OK"))
                        {
                            this.MensajeOk("Registro Eliminado Correctamente");
                        }
                        else
                        {
                            this.MensajeError(Respuesta);
                        }

                        //Botones Comunes
                        this.Digitar = true;
                        this.TBBuscar.Clear();
                        this.Botones();

                        //Se regresa el focus al campo principal
                        this.TCPrincipal.SelectedIndex = 0;
                        this.TBNombre.Select();
                    }
                }
                else
                {
                    MessageBox.Show("Acceso Denegado Para Realizar Eliminaciones en el Sistema", "Leal Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void TBBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Consultar == "1")
                {
                    if (TBBuscar.Text != "")
                    {
                        this.DGResultados.DataSource = fProveedor.Buscar(this.TBBuscar.Text, 1);
                        //this.DGResultados.Columns[1].Visible = false;

                        lblTotal.Text = "Datos Registrados: " + Convert.ToString(DGResultados.Rows.Count);

                        this.btnEliminar.Enabled = true;
                        this.btnImprimir.Enabled = true;
                        this.DGResultados.Enabled = true;
                    }
                    else
                    {
                        this.Limpiar();

                        //Se Limpian las Filas y Columnas de la tabla
                        DGResultados.DataSource = null;
                        this.DGResultados.Enabled = false;
                        this.lblTotal.Text = "Datos Registrados: 0";

                        this.btnEliminar.Enabled = false;
                        this.btnImprimir.Enabled = false;
                    }
                }

                else
                {
                    MessageBox.Show("El usuario iniciado no tiene permisos para realizar consultas en el sistema", "Leal Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }


        private void TBIdproveedor_TextChanged(object sender, EventArgs e)
        {
            try
            //SE REALIZA LA CONSULTA A LA BASE DE DATOS POR MEDIO DEL Idcliente
            //Y ASI AUTOCOMPLETAR LOS CAMPOS DE TEXTOS NECESARIOS O CONSULTADOS
            {

                // ENVIAN LOS DATOS A LA BASE DE DATOS Y SE EVALUAN QUE EXISTEN O ESTEN REGISTRADOS

                DataTable Datos = CapaNegocio.fAlmacen_Proveedor.Buscar_Proveedor(2, this.TBIdproveedor.Text);
                //Evaluamos si  existen los Datos
                if (Datos.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron registros en la base de datos", "Leal Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    //Panel Datos Basicos
                    Proveedor = Datos.Rows[0][0].ToString();
                    Documento = Datos.Rows[0][0].ToString();
                    Telefono = Datos.Rows[0][0].ToString();
                    Movil = Datos.Rows[0][0].ToString();
                    Correo = Datos.Rows[0][0].ToString();
                    Pais = Datos.Rows[0][0].ToString();
                    Ciudad = Datos.Rows[0][0].ToString();
                    Nacionalidad = Datos.Rows[0][0].ToString();

                    //Panel Datos de Envio
                    Pais_DE = Datos.Rows[0][0].ToString();
                    Ciudad_DE = Datos.Rows[0][0].ToString();
                    DireccionPrincipal = Datos.Rows[0][0].ToString();
                    Direccion01 = Datos.Rows[0][0].ToString();
                    Direccion02 = Datos.Rows[0][0].ToString();
                    Receptor = Datos.Rows[0][0].ToString();
                    Observacion = Datos.Rows[0][0].ToString();

                    //Panel Datos Financiero
                    BancoPrincipal = Datos.Rows[0][0].ToString();
                    BancoAuxiliar = Datos.Rows[0][0].ToString();
                    Cuenta01 = Datos.Rows[0][0].ToString();
                    Cuenta02 = Datos.Rows[0][0].ToString();
                    CreditoMinimo = Datos.Rows[0][0].ToString();
                    CreditoMaximo = Datos.Rows[0][0].ToString();
                    UltimoCredito = Datos.Rows[0][0].ToString();
                    Mora = Datos.Rows[0][0].ToString();
                    TotalCredito = Datos.Rows[0][0].ToString();


                    //SE PROCEDE A LLENAR LOS CAMPOS DE TEXTO SEGUN LA CONSULTA REALIZADA

                    this.TBNombre.Text = Proveedor;
                    this.TBDocumento.Text = Documento;
                    this.TBTelefono.Text = Telefono;
                    this.TBMovil.Text = Movil;
                    this.TBCorreo.Text = Correo;
                    this.TBPais.Text = Pais;
                    this.TBCiudad.Text = Ciudad;
                    this.TBRepresentante.Text = Representante;

                    //
                    this.TBPais_01.Text = Pais_DE;
                    this.TBCiudad_01.Text = Ciudad_DE;
                    this.TBDireccion01.Text = Direccion01;
                    this.TBDireccion02.Text = Direccion02;
                    this.TBReceptor.Text = Receptor;
                    this.TBObservacion.Text = Observacion;

                    //
                    this.TBBancoPrincipal.Text = BancoPrincipal;
                    this.TBBancoAuxiliar.Text = BancoAuxiliar;
                    this.TBCuenta01.Text = Cuenta01;
                    this.TBCuenta02.Text = Cuenta02;
                    this.TBCreditoMinimo.Text = CreditoMinimo;
                    this.TBCreditoMaximo.Text = CreditoMaximo;
                    this.TBUltimoCredito.Text = UltimoCredito;
                    this.TBCreditoMora.Text = Mora;
                    this.TBCreditoTotal.Text = TotalCredito;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void CBTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DGResultados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.Digitar = false;

                if (Editar == "1")
                {
                    //
                    this.TBIdproveedor.Text = Convert.ToString(this.DGResultados.CurrentRow.Cells["Codigo"].Value);
                    this.TBNombre.Select();

                    //Se procede Habilitar los campos de Textos y Botones
                    //cuando se le realice el evento Clip del Boton Ediatar/Guardar

                    this.Habilitar();
                    this.btnGuardar.Enabled = true;
                    this.btnCancelar.Enabled = true;

                    //Se cambia la imagen del Boton la cual inicialmente es Guardar
                    //Y se cambiar por la imagen Editar
                    this.btnGuardar.Image = Properties.Resources.BV_Editar;
                }
                else
                {
                    MessageBox.Show("Acceso denegado para actualizar registros", "Leal Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void DGResultados_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
                {
                    this.Digitar = false;

                    if (Editar == "1")
                    {
                        //
                        this.TBIdproveedor.Text = Convert.ToString(this.DGResultados.CurrentRow.Cells["Codigo"].Value);
                        this.TBNombre.Select();

                        //Se procede Habilitar los campos de Textos y Botones
                        //cuando se le realice el evento Clip del Boton Ediatar/Guardar

                        this.Habilitar();
                        this.btnGuardar.Enabled = true;
                        this.btnCancelar.Enabled = true;

                        //Se cambia la imagen del Boton la cual inicialmente es Guardar
                        //Y se cambiar por la imagen Editar
                        this.btnGuardar.Image = Properties.Resources.BV_Editar;
                    }
                    else
                    {
                        MessageBox.Show("Acceso denegado para actualizar registros", "Leal Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        //******************** PANEL DATOS BASICOS ********************

        private void TBNombre_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void TBDocumento_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void TBRepresentante_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void TBPais_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void TBCiudad_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void TBNacionalidad_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void TBTelefono_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void TBMovil_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void TBCorreo_KeyUp(object sender, KeyEventArgs e)
        {

        }

        //******************** PANEL DATOS DE ENVIO ********************

        private void TBReceptor_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void TBPais_01_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void TBCiudad_01_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void TBDireccionPrincipal_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void TBDireccion01_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void TBDireccion02_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void TBTelefono_01_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void TBMovil_01_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void TBObservacion_KeyUp(object sender, KeyEventArgs e)
        {

        }

        //
        private void TBValorRetencion_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void TBBancoPrincipal_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void TBCuenta01_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void TBBancoAuxiliar_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void TBCuenta02_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void TBCreditoMinimo_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void TBCreditoMaximo_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void TBUltimoCredito_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void TBCreditoMora_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void TBCreditoTotal_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void TBDiasProrroga_KeyUp(object sender, KeyEventArgs e)
        {

        }

        //******************** FOCUS ENTER  DATOS BASICOS ********************

        private void TBNombre_Enter(object sender, EventArgs e)
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
            }
        }

        private void TBDocumento_Enter(object sender, EventArgs e)
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
            }
        }

        private void TBRepresentante_Enter(object sender, EventArgs e)
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
            }
        }

        private void TBPais_Enter(object sender, EventArgs e)
        {

        }

        private void TBCiudad_Enter(object sender, EventArgs e)
        {

        }

        private void TBNacionalidad_Enter(object sender, EventArgs e)
        {

        }

        private void TBTelefono_Enter(object sender, EventArgs e)
        {

        }

        private void TBMovil_Enter(object sender, EventArgs e)
        {

        }

        private void TBCorreo_Enter(object sender, EventArgs e)
        {

        }

        //******************** FOCUS ENTER  DATOS DE ENVIO ********************

        private void TBReceptor_Enter(object sender, EventArgs e)
        {

        }

        private void TBPais_01_Enter(object sender, EventArgs e)
        {

        }

        private void TBCiudad_01_Enter(object sender, EventArgs e)
        {

        }

        private void TBDireccionPrincipal_Enter(object sender, EventArgs e)
        {

        }

        private void TBDireccion01_Enter(object sender, EventArgs e)
        {

        }

        private void TBDireccion02_Enter(object sender, EventArgs e)
        {

        }

        private void TBTelefono_01_Enter(object sender, EventArgs e)
        {

        }

        private void TBMovil_01_Enter(object sender, EventArgs e)
        {

        }

        private void TBObservacion_Enter(object sender, EventArgs e)
        {

        }
    }
}
