using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void registroYBúsquedaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistro_Busqueda regBus = new frmRegistro_Busqueda();
            regBus.MdiParent = this;
            regBus.Show();
        }

        private void listadoDeEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListar listar = new frmListar();
            listar.MdiParent = this;
            listar.Show();
        }

        private void calcularSalarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCalcularSalario calSal = new frmCalcularSalario();
            calSal.MdiParent = this;
            calSal.Show();
        }

        private void gestiónDeNóminaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGestionNomina gesNom = new frmGestionNomina();
            gesNom.MdiParent = this;
            gesNom.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            frmInicio inic = new frmInicio();
            inic.Show();
            timer1.Enabled = false;

            timer1.Stop();
        }
    }
}
