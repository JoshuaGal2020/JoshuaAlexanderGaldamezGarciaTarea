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
        void limpiarfilas()
        {
            dtvNotas.Rows.Clear();
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
                                    Id = tbNotas.id_notas,
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

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (notasEstudiantesEntities1 db = new notasEstudiantesEntities1())
            {
                Not.id_estudiante = int.Parse(txtIdEstudiante.Text);
                Not.id_materia = int.Parse(txtIdMateria.Text);
                Not.nota = int.Parse(txtNotas.Text);


                db.notas.Add(Not);
                db.SaveChanges();
            }
            limpiarfilas();
            cargardatos();
            limpiarDatos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            using (notasEstudiantesEntities1 db = new notasEstudiantesEntities1())
            {
                String Id = dtvNotas.CurrentRow.Cells[0].Value.ToString();
                int Ids = int.Parse(Id);
                Not = db.notas.Where(verificarId => verificarId.id_notas == Ids).First();
                Not.id_estudiante = int.Parse(txtIdEstudiante.Text);
                Not.id_materia = int.Parse(txtIdMateria.Text);
                Not.nota = int.Parse(txtNotas.Text);
                db.Entry(Not).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

            }
            limpiarfilas();
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
            limpiarfilas();
            cargardatos();
            limpiarDatos();
        }

        private void dtvNotas_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            
        }

        private void dtvNotas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String Nombre = dtvNotas.CurrentRow.Cells[1].Value.ToString();
            String Materia = dtvNotas.CurrentRow.Cells[2].Value.ToString();
            String Nota = dtvNotas.CurrentRow.Cells[3].ToString();
          
            txtIdEstudiante.Text = Nombre;
            txtIdMateria.Text = Materia;
            txtNotas.Text = Nota;
            cargardatos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            limpiarfilas();
            cargardatos();
        }
    }
}
