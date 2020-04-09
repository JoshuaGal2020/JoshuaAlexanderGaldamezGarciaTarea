using JoshuaGaldamez.Model;
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
    public partial class FrmEstudiantes : Form
    {
        public FrmEstudiantes()
        {
            InitializeComponent();
        }
        estudiante user = new estudiante();
        void cargardatos() 
        { using (notasEstudiantesEntities1 db = new notasEstudiantesEntities1())

            {

                dtvEstudiante.DataSource = db.estudiante.ToList();
            }
               
        }
        void limpiardatos()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtUsuario.Text = "";
            txtContrasena.Text = "";
            
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            using (notasEstudiantesEntities1 db = new notasEstudiantesEntities1())
            {
                user.nombre_estudiante = txtNombre.Text;
                user.apellido = txtApellido.Text;
                user.usuario = txtUsuario.Text;
                user.Contrasena = txtContrasena.Text;

                db.estudiante.Add(user);
                db.SaveChanges();
            }
            cargardatos();
            limpiardatos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cargardatos();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (notasEstudiantesEntities1 db = new notasEstudiantesEntities1())
            {
                String Id = dtvEstudiante.CurrentRow.Cells[0].Value.ToString();
                int idc = int.Parse(Id);
                user = db.estudiante.Where(verificarID => verificarID.id_estudiante == idc).First();
                user.nombre_estudiante = txtNombre.Text;
                user.apellido = txtApellido.Text;
                user.usuario = txtUsuario.Text;
                user.Contrasena = txtContrasena.Text;
                db.Entry(user).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

            }
            cargardatos();
            limpiardatos();

        }

        private void FrmEstudiantes_Load(object sender, EventArgs e)
        {
            cargardatos();
        }

        private void dtvEstudiante_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String Nombre = dtvEstudiante.CurrentRow.Cells[1].Value.ToString();
            String Apellido = dtvEstudiante.CurrentRow.Cells[2].Value.ToString();
            String usuario = dtvEstudiante.CurrentRow.Cells[3].Value.ToString();
            String Contra = dtvEstudiante.CurrentRow.Cells[4].Value.ToString();
            txtNombre.Text = Nombre;
            txtApellido.Text = Apellido;
            txtUsuario.Text = usuario;
            txtContrasena.Text = Contra;
            cargardatos();
        }
    }

}
