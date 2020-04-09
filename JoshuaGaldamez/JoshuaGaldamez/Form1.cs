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
using JoshuaGaldamez.VISTA;

namespace JoshuaGaldamez
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            using (notasEstudiantesEntities1 db = new notasEstudiantesEntities1())
            {

                var lista = from usuario in db.estudiante
                            where usuario.usuario == txtUsuario.Text
                            && usuario.Contrasena == txtContra.Text
                            select usuario;

                if (lista.Count() > 0)
                {
                    frmMenu menu = new frmMenu();
                    menu.Show();

                }
                else
                {
                    MessageBox.Show("El usuario no existe");
                }

            }
        }
    }
}
