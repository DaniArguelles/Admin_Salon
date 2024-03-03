using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Salon.Models;

namespace Salon
{
    public partial class FrmAgregarP : Form
    {
        public int? id;
        Productos nuevo = null;
        public FrmAgregarP(int? id = null)
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

                nuevo = db.Productos.Find(id);
                txtNombreP.Text = nuevo.Producto;
                cmbUnidadP.Text = nuevo.Unidad;
                txtCantidadP.Text = nuevo.Cantidad.ToString();
                txtPrecioP.Text = nuevo.Precio.ToString();
            }
        }



        private void btnGuardarP_Click(object sender, EventArgs e)
        {
            using (SalonEntities db = new SalonEntities()) 
            {
                if (id == null)
                    nuevo = new Productos();

                nuevo.Producto = txtNombreP.Text;
                nuevo.Unidad = cmbUnidadP.Text;
                nuevo.Cantidad = Convert.ToInt32(txtCantidadP.Text);
                nuevo.Precio = Convert.ToDecimal(txtPrecioP.Text);


                if (id == null)
                    db.Productos.Add(nuevo);
                else 
                {
                    db.Entry(nuevo).State = System.Data.Entity.EntityState.Modified;
                }

                db.SaveChanges();

                this.Close();
            }
        }

        private void FrmAgregarP_Load(object sender, EventArgs e)
        {

        }
    }
}
