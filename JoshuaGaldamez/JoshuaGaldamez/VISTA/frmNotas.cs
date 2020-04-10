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
    public partial class frmNotas : Form
    {
        public frmNotas()
        {
            InitializeComponent();
        }

        notas Not = new notas();
        void cargardatos()
        {
            using (notasEstudiantesEntities1 bd = new notasEstudiantesEntities1())
            {
                var joinTablas = from tbNotas in bd.notas
                                 from tbEstudiante in bd.estudiante
                                 from tbMateria in bd.materia
                                 where tbNotas.id_estudiante == tbEstudiante.id_estudiante
                                 && tbNotas.id_materia == tbMateria.id_materia

                                 select new
                                 {
                                    Id = tbNotas.id_materia,
                                    Nombre = tbEstudiante.nombre_estudiante,
                                    Materia = tbMateria.nombre_materia,
                                    Nota = tbNotas.nota
                                 };

                foreach (var iterarDatos in joinTablas)
                {
                    dtvNotas.Rows.Add(iterarDatos.Id, iterarDatos.Nombre, iterarDatos.Materia, iterarDatos.Nota);
                }
            
            }

        }
        void limpiarDatos()
        {
            txtIdEstudiante.Text = "";
            txtIdMateria.Text = "";
            txtNotas.Text = "";
        }
        private void frmNotas_Load(object sender, EventArgs e)
        {
            cargardatos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (notasEstudiantesEntities1 db = new notasEstudiantesEntities1())
            {
                //Not.id_estudiante = txtIdEstudiante.Text;
                //Not.id_materia = txtIdMateria.Text;
                //Not.nota = txtNotas.Text;


                db.notas.Add(Not);
                db.SaveChanges();
            }
            cargardatos();
            limpiarDatos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            using (notasEstudiantesEntities1 db = new notasEstudiantesEntities1())
            {
                String Id = dtvNotas.CurrentRow.Cells[0].Value.ToString();
                int idc = int.Parse(Id);
                Not = db.notas.Where(verificarID => verificarID.id_notas == idc).First();

                //Not.id_estudiante = txtIdEstudiante.Text;
                //Not.id_materia = txtIdMateria.Text;
                //Not.nota = txtNotas.Text;
                db.Entry(Not).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

            }
            cargardatos();
            limpiarDatos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            using (notasEstudiantesEntities1 db = new notasEstudiantesEntities1())
            {
                String Id = dtvNotas.CurrentRow.Cells[0].Value.ToString();

                Not = db.notas.Find(int.Parse(Id));
                db.notas.Remove(Not);
                db.SaveChanges();
            }
            cargardatos();
            limpiarDatos();
        }
    }
}
