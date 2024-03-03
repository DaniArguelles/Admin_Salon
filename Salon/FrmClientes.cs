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
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            Refrescar();
        }

        private void Refrescar()
        {
            using (SalonEntities db = new SalonEntities())
            {
                var lst = db.Clientes.Select(c => new 
                { c.id_Cliente, c.Nombre,c.Apellido,c.Correo,c.Telefono }).ToList();
                dtgClientes.DataSource = lst;

            }
        }

        private void btnNuevoC_Click(object sender, EventArgs e)
        {
            FrmAgregarC frm = new FrmAgregarC();
            frm.ShowDialog();

            Refrescar();
        }

        private void btnModificarC_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dtgClientes.Rows[dtgClientes.CurrentRow.Index].Cells[0].Value.ToString());

            FrmAgregarC frmAgregarC = new FrmAgregarC(id);

            frmAgregarC.ShowDialog();

            Refrescar();
        }

        private void btnEliminarC_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dtgClientes.Rows[dtgClientes.CurrentRow.Index].Cells[0].Value.ToString());

            using (SalonEntities db = new SalonEntities())
            {
                Clientes eliminar = db.Clientes.Find(id);
                db.Clientes.Remove(eliminar);

                db.SaveChanges();
            }
            Refrescar();
        }

        private void dtgClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCitaC_Click(object sender, EventArgs e)
        {
            FrmAgendarC frm = new FrmAgendarC();
            frm.ShowDialog();

        }
    }
}
