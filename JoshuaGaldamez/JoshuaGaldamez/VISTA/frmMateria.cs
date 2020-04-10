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
        materia mat = new materia();
        void cargardatos()
        {
            using (notasEstudiantesEntities1 db = new notasEstudiantesEntities1())

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

        private void button1_Click(object sender, EventArgs e)
        {
            cargardatos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (notasEstudiantesEntities1 db = new notasEstudiantesEntities1())
            {
                mat.nombre_materia = txtMateria.Text;


                db.materia.Add(mat);
                db.SaveChanges();
            }
            cargardatos();
            limpiardatos();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (notasEstudiantesEntities1 db = new notasEstudiantesEntities1())
            {
                String Id = dtvMateria.CurrentRow.Cells[0].Value.ToString();
                int idc = int.Parse(Id);
                mat = db.materia.Where(verificarID => verificarID.id_materia == idc).First();
                mat.nombre_materia = txtMateria.Text;
               
                db.Entry(mat).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

            }
            cargardatos();
            limpiardatos();
        }

        private void dtvMateria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dtvMateria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String Nombre = dtvMateria.CurrentRow.Cells[1].Value.ToString();

            txtMateria.Text = Nombre;

            cargardatos();
        }
    }

}

