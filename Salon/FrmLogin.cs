using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Salon.Models;

namespace Salon
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            using (SalonEntities db = new SalonEntities())
            {
                var lst = from d in db.Usuarios
                          where d.usuario == txtUsuario.Text
                          && d.contra == txtContrasena.Text
                          select d;

                if (lst.Count() > 0)
                {
                    FrmMain frm = new FrmMain();
                    frm.Show();

                }
                else 
                {
                    MessageBox.Show("Usuario o contraseña erroneos");
                }

            }

            
             
        }
    }
}
