using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JoshuaGaldamez.VISTA
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }
        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void datosEstudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEstudiantes ES = new FrmEstudiantes();
            ES.MdiParent = this;
            ES.Show();
        }

        private void agregarMateriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMateria Ma = new frmMateria();
            Ma.MdiParent = this;
            Ma.Show();
        }

        private void ingresarNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNotas No = new frmNotas();
            No.MdiParent = this;
            No.Show();
        }
    }
}
