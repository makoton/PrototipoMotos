using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrototipoMotos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            this.txtTips.Text = "Aqui va una descripcion muy larga de las opciones que " +
                "se pueden realizar en la opcion de recepcion en general y deberia mostrarse" +
                "al pasar el mouse por encima; :3";
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            this.txtTips.Text = "";
        }

        private void btnRecepcion_Click(object sender, EventArgs e)
        {
            this.panelRecepcion.Visible = true;
            this.panelClientes.Visible = false;
            this.panelRepuestos.Visible = false;
            this.panelServTecnico.Visible = false;
        }

        private void tabPage1_MouseEnter(object sender, EventArgs e)
        {
            this.txtTips.Text = "Esta es la descripcion del tab de ingreso de vehiculos, " +
                "aqui se pueden ingresar vehiculos para servicio tecnico =)";
        }

        private void tabPage1_MouseLeave(object sender, EventArgs e)
        {
            this.txtTips.Text = "";
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            this.panelClientes.Visible = true;
            this.panelRecepcion.Visible = false;
            this.panelRepuestos.Visible = false;
            this.panelServTecnico.Visible = false;
        }

        private void btnRepuestos_Click(object sender, EventArgs e)
        {
            this.panelRepuestos.Visible = true;
            this.panelRecepcion.Visible = false; 
            this.panelClientes.Visible = false;
            this.panelServTecnico.Visible = false;
        }

        private void btnServTec_Click(object sender, EventArgs e)
        {
            this.panelServTecnico.Visible = true;
            this.panelRecepcion.Visible = false;
            this.panelClientes.Visible = false;
            this.panelRepuestos.Visible = false;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            FormEditCliente editar = new FormEditCliente();
            editar.Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            FormAgregarEditarPersonal agregar = new FormAgregarEditarPersonal();
            agregar.PanelVisible = false;
            agregar.Show();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            FormAgregarEditarPersonal editar = new FormAgregarEditarPersonal();
            editar.PanelVisible = true;
            editar.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            FormAgregarEditarTrabajos agregarT = new FormAgregarEditarTrabajos();
            agregarT.PanelVisibleE = false;
            agregarT.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            FormAgregarEditarTrabajos editarT = new FormAgregarEditarTrabajos();
            editarT.PanelVisibleE = true;
            editarT.Show();
        }

    }
}
