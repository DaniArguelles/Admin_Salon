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
    public partial class FrmProductosServicios : Form
    {
        public FrmProductosServicios()
        {
            InitializeComponent();
        }

        private void FrmProductosServicios_Load(object sender, EventArgs e)
        {
            Refrescar();
        }

        private void Refrescar()
        {
            using (SalonEntities db = new SalonEntities())
            {
                var lst = from d in db.Productos
                          select d;

                dtgProductosServicios.DataSource = lst.ToList();
            }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtgProductosServicios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnAgregarP_Click(object sender, EventArgs e)
        {
            FrmAgregarP frmAgregarP = new FrmAgregarP();
            frmAgregarP.ShowDialog();

            Refrescar();
        }

        private void btnModificarP_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dtgProductosServicios.Rows[dtgProductosServicios.CurrentRow.Index].Cells[0].Value.ToString());
            
            FrmAgregarP frmAgregarP = new FrmAgregarP(id);
            
            frmAgregarP.ShowDialog();

            Refrescar();
        }

        private void btnEliminarP_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dtgProductosServicios.Rows[dtgProductosServicios.CurrentRow.Index].Cells[0].Value.ToString());

            using (SalonEntities db = new SalonEntities())
            {
                Productos eliminar = db.Productos.Find(id);
                db.Productos.Remove(eliminar);

                db.SaveChanges();
            }
            Refrescar();
        }
    }
}
