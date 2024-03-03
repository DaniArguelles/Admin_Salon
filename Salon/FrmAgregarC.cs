using Salon.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salon
{
    public partial class FrmAgregarC : Form
    {
        public int? id;
        Clientes nuevo = null;
        public FrmAgregarC(int? id = null)
        {
            InitializeComponent();

            this.id = id;
            if (id != null)
            {
                CargarDatos();
            }
        }

        private void CargarDatos()
        {
            using (SalonEntities db = new SalonEntities())
            {

                nuevo = db.Clientes.Find(id);
                txtNombre.Text = nuevo.Nombre;
                txtApellidos.Text = nuevo.Apellido;
                txtCorreo.Text = nuevo.Correo;
                txtTelefono.Text = nuevo.Telefono;
            }
        }

        private void btnGuardarC_Click(object sender, EventArgs e)
        {
            using(SalonEntities db = new SalonEntities())
            {
                if (id == null)
                    nuevo = new Clientes();

                nuevo.Nombre = txtNombre.Text;
                nuevo.Apellido = txtApellidos.Text;
                nuevo.Correo = txtCorreo.Text;
                nuevo.Telefono = txtTelefono.Text;


                if (id == null)
                    db.Clientes.Add(nuevo);
                else
                {
                    db.Entry(nuevo).State = System.Data.Entity.EntityState.Modified;
                }

                db.SaveChanges();

                this.Close();
            }
        }
    }
}
