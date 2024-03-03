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
    public partial class FrmAgendarC : Form
    {
        public FrmAgendarC()
        {
            InitializeComponent();
        }

        private void FrmAgendarC_Load(object sender, EventArgs e)
        {

            Refrescar();
        }

        private void Refrescar()
        {
            using (SalonEntities db = new SalonEntities())
            {
                var clientes = (from d in db.Clientes
                               select d).ToList();

                cmbCliente.DataSource = clientes;
                cmbCliente.DisplayMember = "Nombre";
                
            }

            using (SalonEntities db = new SalonEntities())
            {
                var servicios = (from d in db.Servicios
                                select d).ToList();

                cmbServicio.DataSource = servicios;
                cmbServicio.DisplayMember = "Servicio";

            }

        }

    }
}
