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
    public partial class FormAgregarEditarPersonal : Form
    {
        public FormAgregarEditarPersonal()
        {
            InitializeComponent();
        }

        public bool panelVisible = false;

        public bool PanelVisible { get { return this.panelVisible; } set { this.panelEditarEMp.Visible = value; } }

        private void FormAgregarEditarPersonal_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
