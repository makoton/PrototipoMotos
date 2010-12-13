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
    public partial class FormAgregarEditarTrabajos : Form
    {
        public FormAgregarEditarTrabajos()
        {
            InitializeComponent();
        }

        public bool panelVisibleE = false;

        public bool PanelVisibleE { get { return this.panelVisibleE; } set { this.panelEditarTrab.Visible = value; } }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAgregarEditarTrabajos_Load(object sender, EventArgs e)
        {

        }
    }
}
