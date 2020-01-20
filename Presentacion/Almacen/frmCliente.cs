﻿using System;
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
    public partial class frmCliente : Form
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
        public frmCliente()
        {
            InitializeComponent();
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            //Inicio de Clase y Botones
            this.Botones();
            this.Habilitar();

            //Focus a Texboxt y Combobox
            this.TBNombre.Select();

            //Ocultacion de Texboxt
            this.TBIdcliente.Visible = false;
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
            this.TBDocumento.ReadOnly = false;
            this.TBDocumento.BackColor = Color.FromArgb(3, 155, 229);
            this.TBDocumento.ForeColor = Color.FromArgb(255, 255, 255);
            this.TBDocumento.Text = Campo;

            this.TBTelefono.ReadOnly = false;
            this.TBTelefono.BackColor = Color.FromArgb(3, 155, 229);
            this.TBMovil.ReadOnly = false;
            this.TBMovil.BackColor = Color.FromArgb(3, 155, 229);
            this.TBCorreo.ReadOnly = false;
            this.TBCorreo.BackColor = Color.FromArgb(3, 155, 229);
            this.TBPais.ReadOnly = false;
            this.TBPais.BackColor = Color.FromArgb(3, 155, 229);
            this.TBCiudad.ReadOnly = false;
            this.TBCiudad.BackColor = Color.FromArgb(3, 155, 229);
            this.TBDepartamento.ReadOnly = false;
            this.TBDepartamento.BackColor = Color.FromArgb(3, 155, 229);

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
                this.TBDocumento.Clear();
                this.TBDocumento.Text = Campo;

                this.TBTelefono.Clear();
                this.TBMovil.Clear();
                this.TBCorreo.Clear();
                this.TBPais.Clear();
                this.TBCiudad.Clear();
                this.TBDepartamento.Clear();

                //Se habilitan los botones a su estado por DEFAULT
                this.Digitar = true;
                this.Botones();
                this.Habilitar();

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

                else
                {
                    if (this.Digitar)
                    {
                        rptaDatosBasicos = fCliente.Guardar_DatosBasicos

                            (
                                 //Datos Auxiliares
                                 1,

                                 //Panel Datos Basicos
                                 this.TBCodigo.Text, this.TBNombre.Text, this.TBDocumento.Text, this.TBTelefono.Text, this.TBMovil.Text, this.TBCorreo.Text,
                                 this.TBPais.Text, this.TBCiudad.Text, this.TBDepartamento.Text,

                                 //
                                 this.TBPais_01.Text, this.TBCiudad_01.Text, this.TBDireccionPrincipal.Text, this.TBDireccion01.Text, this.TBDireccion02.Text,

                                 //
                                 this.TBBancoPrincipal.Text, this.TBBancoAuxiliar.Text, this.TBCuenta01.Text, this.TBCuenta02.Text, this.TBCreditoMinimo.Text, this.TBCreditoMaximo.Text,

                                 1
                            );
                    }

                    else
                    {
                        rptaDatosBasicos = fCliente.Editar_DatosBasicos

                            (
                                 //Datos Auxiliares
                                 1, Convert.ToInt32(this.TBIdcliente.Text),

                                 //Panel Datos Basicos
                                 this.TBCodigo.Text, this.TBNombre.Text, this.TBDocumento.Text, this.TBTelefono.Text, this.TBMovil.Text, this.TBCorreo.Text,
                                 this.TBPais.Text, this.TBCiudad.Text, this.TBDepartamento.Text,

                                 //
                                 this.TBPais_01.Text, this.TBCiudad_01.Text, this.TBDireccionPrincipal.Text, this.TBDireccion01.Text, this.TBDireccion02.Text,

                                 //
                                 this.TBBancoPrincipal.Text, this.TBBancoAuxiliar.Text, this.TBCuenta01.Text, this.TBCuenta02.Text, this.TBCreditoMinimo.Text, this.TBCreditoMaximo.Text,

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
                this.Digitar = true;
                this.Limpiar_Datos();
                this.TBBuscar.Clear();

                //Se Limpian las Filas y Columnas de la tabla
                DGResultados.DataSource = null;
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

        private void TBBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Consultar == "1")
                {
                    if (TBBuscar.Text != "")
                    {
                        this.DGResultados.DataSource = fCliente.Buscar(this.TBBuscar.Text, 1);
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

        private void DGResultados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.Digitar = false;

                if (Editar == "1")
                {
                    //
                    this.TBIdcliente.Text = Convert.ToString(this.DGResultados.CurrentRow.Cells["Codigo"].Value);
                    this.TBNombre.Select();

                    //
                    this.Limpiar_Datos();

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
                        this.TBIdcliente.Text = Convert.ToString(this.DGResultados.CurrentRow.Cells["Codigo"].Value);
                        this.TBNombre.Select();

                        //Se procede Habilitar los campos de Textos y Botones
                        //cuando se le realice el evento Clip del Boton Ediatar/Guardar

                        this.Habilitar();
                        this.btnGuardar.Enabled = true;
                        this.btnCancelar.Enabled = true;

                        //
                        this.Limpiar_Datos();
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
    }
}
