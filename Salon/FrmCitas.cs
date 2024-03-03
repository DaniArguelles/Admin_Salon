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
    public partial class FrmCitas : Form
    {
        public FrmCitas()
        {
            InitializeComponent();
        }

        private void FrmCitas_Load(object sender, EventArgs e)
        {
            Refrescar();
        }

        private void Refrescar() {
            using (SalonEntities db = new SalonEntities())
            {
                var hola =db.Mostrar_Citas_Nuevo(null);
                dtgMostrarCitas.DataSource = hola.ToList();
            }
        }
    }
}
