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
    public partial class frmMenuPrincipal : Form
    {
        //Parametros Basicos
        public string Idempleado = "";
        public string Empleado = "";
        public string UsuarioLogueado = "";
        public string Idusuario = "";

        //Menu Principal
        public string Menu_Almacen = "";
        public string Menu_GestionHumana = "";
        public string Menu_Productos = "";
        public string Menu_Reportes = "";
        public string Menu_Sistema = "";
        public string Menu_Ventas = "";

        //Permisos de Operacion Que Vienen de la Base de Datos

        public string SQL_Guardar = "";
        public string SQL_Editar = "";
        public string SQL_Eliminar = "";
        public string SQL_Consultar = "";
        public string SQL_Imprimir = "";

        //
        public string Cede = "";

        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            this.TSEmpleado.Text = Empleado;
            this.TSUsuario.Text = UsuarioLogueado;
        }
       
        private void datosBasicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmpleados frmEmpleados = new frmEmpleados();
            frmEmpleados.MdiParent = this;
            frmEmpleados.Show();

            frmEmpleados.Guardar = Convert.ToString(this.SQL_Guardar);
            frmEmpleados.Editar = Convert.ToString(this.SQL_Editar);
            frmEmpleados.Eliminar = Convert.ToString(this.SQL_Eliminar);
            frmEmpleados.Consultar = Convert.ToString(this.SQL_Consultar);
            frmEmpleados.Imprimir = Convert.ToString(this.SQL_Imprimir);
        }

        private void departamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDepartamento frmDepartamento = new frmDepartamento();
            frmDepartamento.MdiParent = this;
            frmDepartamento.Show();

            frmDepartamento.Guardar = Convert.ToString(this.SQL_Guardar);
            frmDepartamento.Editar = Convert.ToString(this.SQL_Editar);
            frmDepartamento.Eliminar = Convert.ToString(this.SQL_Eliminar);
            frmDepartamento.Consultar = Convert.ToString(this.SQL_Consultar);
            frmDepartamento.Imprimir = Convert.ToString(this.SQL_Imprimir);
        }

        private void datosBasicosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmProductos frmProductos = new frmProductos();
            frmProductos.MdiParent = this;
            frmProductos.Show();

            frmProductos.Guardar = Convert.ToString(this.SQL_Guardar);
            frmProductos.Editar = Convert.ToString(this.SQL_Editar);
            frmProductos.Eliminar = Convert.ToString(this.SQL_Eliminar);
            frmProductos.Consultar = Convert.ToString(this.SQL_Consultar);
            frmProductos.Imprimir = Convert.ToString(this.SQL_Imprimir);
        }

        private void impuestosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmImpuesto frmImpuesto = new frmImpuesto();
            frmImpuesto.MdiParent = this;
            frmImpuesto.Show();

            frmImpuesto.Guardar = Convert.ToString(this.SQL_Guardar);
            frmImpuesto.Editar = Convert.ToString(this.SQL_Editar);
            frmImpuesto.Eliminar = Convert.ToString(this.SQL_Eliminar);
            frmImpuesto.Consultar = Convert.ToString(this.SQL_Consultar);
            frmImpuesto.Imprimir = Convert.ToString(this.SQL_Imprimir);
        }

        private void serviciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmServicio frmServicio = new frmServicio();
            frmServicio.MdiParent = this;
            frmServicio.Show();

            frmServicio.Guardar = Convert.ToString(this.SQL_Guardar);
            frmServicio.Editar = Convert.ToString(this.SQL_Editar);
            frmServicio.Eliminar = Convert.ToString(this.SQL_Eliminar);
            frmServicio.Consultar = Convert.ToString(this.SQL_Consultar);
            frmServicio.Imprimir = Convert.ToString(this.SQL_Imprimir);
        }

        private void frmMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void frmMenuPrincipal_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Escape))
                {
                    DialogResult result = MessageBox.Show("¿Desea Salir del Sistema?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (result == DialogResult.Yes)
                    {
                        this.Close();

                    }
                    else
                    {
                        this.Refresh();
                    }

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void bodegaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBodega frmBodega = new frmBodega();
            frmBodega.MdiParent = this;
            frmBodega.Show();

            frmBodega.Guardar = Convert.ToString(this.SQL_Guardar);
            frmBodega.Editar = Convert.ToString(this.SQL_Editar);
            frmBodega.Eliminar = Convert.ToString(this.SQL_Eliminar);
            frmBodega.Consultar = Convert.ToString(this.SQL_Consultar);
            frmBodega.Imprimir = Convert.ToString(this.SQL_Imprimir);
        }

        private void sucurzalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSucurzal frmSucurzal = new frmSucurzal();
            frmSucurzal.MdiParent = this;
            frmSucurzal.Show();

            frmSucurzal.Guardar = Convert.ToString(this.SQL_Guardar);
            frmSucurzal.Editar = Convert.ToString(this.SQL_Editar);
            frmSucurzal.Eliminar = Convert.ToString(this.SQL_Eliminar);
            frmSucurzal.Consultar = Convert.ToString(this.SQL_Consultar);
            frmSucurzal.Imprimir = Convert.ToString(this.SQL_Imprimir);
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente frmCliente = new frmCliente();
            frmCliente.MdiParent = this;
            frmCliente.Show();

            frmCliente.Guardar = Convert.ToString(this.SQL_Guardar);
            frmCliente.Editar = Convert.ToString(this.SQL_Editar);
            frmCliente.Eliminar = Convert.ToString(this.SQL_Eliminar);
            frmCliente.Consultar = Convert.ToString(this.SQL_Consultar);
            frmCliente.Imprimir = Convert.ToString(this.SQL_Imprimir);
        }
        
        private void tipoDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTipoDeCliente frmTipoDeCliente = new frmTipoDeCliente();
            frmTipoDeCliente.MdiParent = this;
            frmTipoDeCliente.Show();

            frmTipoDeCliente.Guardar = Convert.ToString(this.SQL_Guardar);
            frmTipoDeCliente.Editar = Convert.ToString(this.SQL_Editar);
            frmTipoDeCliente.Eliminar = Convert.ToString(this.SQL_Eliminar);
            frmTipoDeCliente.Consultar = Convert.ToString(this.SQL_Consultar);
            frmTipoDeCliente.Imprimir = Convert.ToString(this.SQL_Imprimir);
        }

        private void equiposToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void proveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProveedor frmProveedor = new frmProveedor();
            frmProveedor.MdiParent = this;
            frmProveedor.Show();

            frmProveedor.Guardar = Convert.ToString(this.SQL_Guardar);
            frmProveedor.Editar = Convert.ToString(this.SQL_Editar);
            frmProveedor.Eliminar = Convert.ToString(this.SQL_Eliminar);
            frmProveedor.Consultar = Convert.ToString(this.SQL_Consultar);
            frmProveedor.Imprimir = Convert.ToString(this.SQL_Imprimir);
        }

        private void tipoDeClienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmTipoDeCliente frmTipoDeCliente = new frmTipoDeCliente();
            frmTipoDeCliente.MdiParent = this;
            frmTipoDeCliente.Show();

            frmTipoDeCliente.Guardar = Convert.ToString(this.SQL_Guardar);
            frmTipoDeCliente.Editar = Convert.ToString(this.SQL_Editar);
            frmTipoDeCliente.Eliminar = Convert.ToString(this.SQL_Eliminar);
            frmTipoDeCliente.Consultar = Convert.ToString(this.SQL_Consultar);
            frmTipoDeCliente.Imprimir = Convert.ToString(this.SQL_Imprimir);
        }

        private void marcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMarca frmMarca = new frmMarca();
            frmMarca.MdiParent = this;
            frmMarca.Show();

            frmMarca.Guardar = Convert.ToString(this.SQL_Guardar);
            frmMarca.Editar = Convert.ToString(this.SQL_Editar);
            frmMarca.Eliminar = Convert.ToString(this.SQL_Eliminar);
            frmMarca.Consultar = Convert.ToString(this.SQL_Consultar);
            frmMarca.Imprimir = Convert.ToString(this.SQL_Imprimir);
        }

        private void origenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOrigenes frmAuxiliares = new frmOrigenes();
            frmAuxiliares.MdiParent = this;
            frmAuxiliares.Show();

            frmAuxiliares.Guardar = Convert.ToString(this.SQL_Guardar);
            frmAuxiliares.Editar = Convert.ToString(this.SQL_Editar);
            frmAuxiliares.Eliminar = Convert.ToString(this.SQL_Eliminar);
            frmAuxiliares.Consultar = Convert.ToString(this.SQL_Consultar);
            frmAuxiliares.Imprimir = Convert.ToString(this.SQL_Imprimir);
        }

        private void grupoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGrupo frmGrupo = new frmGrupo();
            frmGrupo.MdiParent = this;
            frmGrupo.Show();

            frmGrupo.Guardar = Convert.ToString(this.SQL_Guardar);
            frmGrupo.Editar = Convert.ToString(this.SQL_Editar);
            frmGrupo.Eliminar = Convert.ToString(this.SQL_Eliminar);
            frmGrupo.Consultar = Convert.ToString(this.SQL_Consultar);
            frmGrupo.Imprimir = Convert.ToString(this.SQL_Imprimir);
        }

        private void tipoDeProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTipoDeProducto frmTipoDeProducto = new frmTipoDeProducto();
            frmTipoDeProducto.MdiParent = this;
            frmTipoDeProducto.Show();

            frmTipoDeProducto.Guardar = Convert.ToString(this.SQL_Guardar);
            frmTipoDeProducto.Editar = Convert.ToString(this.SQL_Editar);
            frmTipoDeProducto.Eliminar = Convert.ToString(this.SQL_Eliminar);
            frmTipoDeProducto.Consultar = Convert.ToString(this.SQL_Consultar);
            frmTipoDeProducto.Imprimir = Convert.ToString(this.SQL_Imprimir);
        }

        private void empaquesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmpaque frmEmpaque = new frmEmpaque();
            frmEmpaque.MdiParent = this;
            frmEmpaque.Show();

            frmEmpaque.Guardar = Convert.ToString(this.SQL_Guardar);
            frmEmpaque.Editar = Convert.ToString(this.SQL_Editar);
            frmEmpaque.Eliminar = Convert.ToString(this.SQL_Eliminar);
            frmEmpaque.Consultar = Convert.ToString(this.SQL_Consultar);
            frmEmpaque.Imprimir = Convert.ToString(this.SQL_Imprimir);
        }
    }
}
