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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FrmClientes frm = new FrmClientes();
            frm.Show();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            FrmProductosServicios frm = new FrmProductosServicios();
            frm.Show();
        }

        private void btnCitas_Click(object sender, EventArgs e)
        {
            FrmCitas frm = new FrmCitas();
            frm.Show();
        }
    }
}
