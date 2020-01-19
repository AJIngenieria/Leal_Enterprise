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
    public partial class frmImpuesto : Form
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
        public frmImpuesto()
        {
            InitializeComponent();
        }

        private void frmImpuesto_Load(object sender, EventArgs e)
        {
            //Inicio de Clase y Botones
            this.Botones();
            this.Habilitar();

            //Focus a Texboxt y Combobox
            this.TBImpuesto.Select();

            //Ocultacion de Texboxt
            this.TBIdimpuesto.Visible = false;
        }

        private void Habilitar()
        {
            //Panel - Datos Basicos
            
            this.TBImpuesto.ReadOnly = false;
            this.TBImpuesto.BackColor = Color.FromArgb(3, 155, 229);
            this.TBImpuesto.ForeColor = Color.FromArgb(255, 255, 255);
            this.TBImpuesto.Text = Campo;
            this.TBValor.ReadOnly = false;
            this.TBValor.BackColor = Color.FromArgb(3, 155, 229);
            this.TBValor.ForeColor = Color.FromArgb(255, 255, 255);
            this.TBValor.Text = Campo;
            this.TBDescripcion.ReadOnly = false;
            this.TBDescripcion.BackColor = Color.FromArgb(3, 155, 229);
            this.TBDescripcion.ForeColor = Color.FromArgb(0, 0, 0);

            //Texboxt de Consulta
            this.TBBuscar.BackColor = Color.FromArgb(3, 155, 229);
        }

        private void Limpiar_Datos()
        {
            if (!Digitar)
            {
                //Panel - Datos Basicos

                this.TBValor.Clear();
                this.TBValor.Text = Campo;
                this.TBImpuesto.Clear();
                this.TBImpuesto.Text = Campo;
                this.TBDescripcion.Clear();

                //Se habilitan los botones a su estado por DEFAULT
                this.Digitar = true;
                this.Botones();
                this.Habilitar();

                //Se realiza el FOCUS al panel y campo de texto iniciales
                this.TBImpuesto.Select();
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

                if (this.TBValor.Text == Campo)
                {
                    MensajeError("Ingrese el porcentaje '%' del Impuesto a registrar");
                }
                else if (this.TBImpuesto.Text == Campo)
                {
                    MensajeError("Ingrese el nombre del Impuesto a registrar");
                }

                else
                {
                    if (this.Digitar)
                    {
                        rptaDatosBasicos = fImpuesto.Guardar_DatosBasicos

                            (
                                 //Datos Auxiliares
                                 1,

                                 //Panel Datos Basicos
                                 this.TBImpuesto.Text, this.TBValor.Text, TBDescripcion.Text, 1
                            );
                    }

                    else
                    {
                        rptaDatosBasicos = fImpuesto.Editar_DatosBasicos

                            (
                                 //Datos Auxiliares
                                 2,

                                 //Panel Datos Basicos
                                 Convert.ToInt32(this.TBIdimpuesto.Text), this.TBImpuesto.Text, this.TBValor.Text, TBDescripcion.Text, 1
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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Consultar == "1")
                {
                    if (TBBuscar.Text != "")
                    {
                        this.DGResultados.DataSource = fGestion_Empleados.Buscar(this.TBBuscar.Text, 1);
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
                    this.TBIdimpuesto.Text = Convert.ToString(this.DGResultados.CurrentRow.Cells["Codigo"].Value);
                    this.TBImpuesto.Select();

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
                        this.TBIdimpuesto.Text = Convert.ToString(this.DGResultados.CurrentRow.Cells["Codigo"].Value);
                        this.TBImpuesto.Select();

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

        private void TBImpuesto_Enter(object sender, EventArgs e)
        {
            //Se evalua si el campo de texto esta vacio y se espeicifca que es obligatorio en la base de datos
            if (TBImpuesto.Text == Campo)
            {
                this.TBImpuesto.BackColor = Color.Azure;
                this.TBImpuesto.ForeColor = Color.FromArgb(0, 0, 0);
                this.TBImpuesto.Clear();
            }
            else
            {
                //Color de fondo del Texboxt cuando este tiene el FOCUS Activado
                this.TBImpuesto.BackColor = Color.Azure;
            }
        }

        private void TBValor_Enter(object sender, EventArgs e)
        {
            //Se evalua si el campo de texto esta vacio y se espeicifca que es obligatorio en la base de datos
            if (TBValor.Text == Campo)
            {
                this.TBValor.BackColor = Color.Azure;
                this.TBValor.ForeColor = Color.FromArgb(0, 0, 0);
                this.TBValor.Clear();
            }
            else
            {
                //Color de fondo del Texboxt cuando este tiene el FOCUS Activado
                this.TBValor.BackColor = Color.Azure;
            }
        }

        private void TBDescripcion_Enter(object sender, EventArgs e)
        {
            this.TBDescripcion.BackColor = Color.Azure;
        }

        private void TBImpuesto_Leave(object sender, EventArgs e)
        {
            if (TBImpuesto.Text == string.Empty)
            {
                //Color de texboxt cuando este posee el FOCUS Activado
                this.TBImpuesto.BackColor = Color.FromArgb(3, 155, 229);
                this.TBImpuesto.Text = Campo;
                this.TBImpuesto.ForeColor = Color.FromArgb(255, 255, 255);
            }

            else
            {
                TBImpuesto.BackColor = Color.FromArgb(3, 155, 229);
            }
        }

        private void TBValor_Leave(object sender, EventArgs e)
        {
            if (TBValor.Text == string.Empty)
            {
                //Color de texboxt cuando este posee el FOCUS Activado
                this.TBValor.BackColor = Color.FromArgb(3, 155, 229);
                this.TBValor.Text = Campo;
                this.TBValor.ForeColor = Color.FromArgb(255, 255, 255);
            }

            else
            {
                this.TBValor.BackColor = Color.FromArgb(3, 155, 229);
            }
        }

        private void TBDescripcion_Leave(object sender, EventArgs e)
        {
            this.TBDescripcion.BackColor = Color.FromArgb(3, 155, 229);
        }


        private void TBImpuesto_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar la tecla Enter se realiza Focus al Texboxt Siguiente

                    this.TBValor.Select();
                }

                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Tab))
                {
                    //Al precionar la tecla Control+TAB Se cambia las pestaña del TapControl
                    //Y se realiza Focus al primer Texboxt de la segunda pestaña del TapControl

                    this.TCPrincipal.SelectedIndex = 1;
                    this.TBBuscar.Select();
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
                            this.TBImpuesto.Select();
                        }
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("¿Desea Actualizar los campos consultados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            //Llamada de Clase
                            this.Digitar = false;
                            this.Limpiar_Datos();
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBImpuesto.Select();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void TBValor_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar la tecla Enter se realiza Focus al Texboxt Siguiente

                    this.TBDescripcion.Select();
                }

                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Tab))
                {
                    //Al precionar la tecla Control+TAB Se cambia las pestaña del TapControl
                    //Y se realiza Focus al primer Texboxt de la segunda pestaña del TapControl

                    this.TCPrincipal.SelectedIndex = 1;
                    this.TBBuscar.Select();
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
                            this.TBValor.Select();
                        }
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("¿Desea Actualizar los campos consultados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            //Llamada de Clase
                            this.Digitar = false;
                            this.Limpiar_Datos();
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBValor.Select();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void TBDescripcion_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar la tecla Enter se realiza Focus al Texboxt Siguiente

                    this.TBImpuesto.Select();
                }

                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Tab))
                {
                    //Al precionar la tecla Control+TAB Se cambia las pestaña del TapControl
                    //Y se realiza Focus al primer Texboxt de la segunda pestaña del TapControl

                    this.TCPrincipal.SelectedIndex = 1;
                    this.TBBuscar.Select();
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
                            this.TBDescripcion.Select();
                        }
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("¿Desea Actualizar los campos consultados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            //Llamada de Clase
                            this.Guardar_SQL();
                        }
                        else
                        {
                            //Se el usuario presiona NO en el mensaje el FOCUS regresara al campo de texto
                            //Donde se realizo la operacion o combinacion de teclas
                            this.TBDescripcion.Select();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnGuardar_MouseDown(object sender, MouseEventArgs e)
        {
            //Si se estan registrando los datos su imagen por defecto seria Guardar
            //De lo contrario seria Editar
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
            //Si se estan registrando los datos su imagen por defecto seria Guardar
            //De lo contrario seria Editar
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
            //Si se estan registrando los datos su imagen por defecto seria Guardar
            //De lo contrario seria Editar
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
