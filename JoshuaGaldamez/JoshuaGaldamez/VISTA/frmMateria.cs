using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JoshuaGaldamez.Model;

namespace JoshuaGaldamez.VISTA
{
    public partial class frmMateria : Form
    {
        public frmMateria()
        {
            InitializeComponent();
        }
        void cargardatos()
        {
            using (notasEstudiantesEntities db = new notasEstudiantesEntities())

            {

                dtvMateria.DataSource = db.materia.ToList();
            }

        }
        void limpiardatos()
        {
            txtMateria.Text = "";

        }
        private void frmMateria_Load(object sender, EventArgs e)
        {
            cargardatos();
        }
    }
}
