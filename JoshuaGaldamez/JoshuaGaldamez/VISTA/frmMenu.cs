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

        private void eSTUDIANTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEstudiantes ES = new FrmEstudiantes();
            ES.Show();

        }

        private void mATERIASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMateria Ma = new frmMateria();
            Ma.Show();
        }

        private void nOTASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNotas No = new frmNotas();
            No.Show();
        }
    }
}
