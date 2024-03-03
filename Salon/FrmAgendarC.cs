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

            mcAgregarC.DateChanged += mcAgregarC_DateChanged;
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

            /*using (SalonEntities db = new SalonEntities()) 
            {

                var hora = db.Hora(mcAgregarC.SelectionEnd);
                
                cmbHoraAC.DataSource = hora;
            }
            */

        }

        private void mcAgregarC_DateChanged(object sender, DateRangeEventArgs e)
        {
            // Llamas al método para actualizar las horas según la nueva fecha del MonthCalendar
            ActualizarHoras();
        }

        private void ActualizarHoras()
        {
            using (SalonEntities db = new SalonEntities())
            {
                // Obtienes la fecha seleccionada del MonthCalendar
                var fechaSeleccionada = mcAgregarC.SelectionEnd;

                // Llamas a la función en tu base de datos para obtener las horas
                var horas = db.Hora(fechaSeleccionada).ToList();

                // Asignas las horas al DataSource del ComboBox
                cmbHoraAC.DataSource = horas;
            }
        }

        private void btnGuardarAC_Click(object sender, EventArgs e)
        {
            using (SalonEntities db = new SalonEntities()) {


                var horaCita = TimeSpan.Parse(cmbHoraAC.Text);

                var fechaCita = mcAgregarC.SelectionStart; 

                var guardar = db.Agregar_Cita(cmbCliente.Text, cmbServicio.Text,fechaCita,horaCita,null,null,null);                
            }

            MessageBox.Show("Cita agendada");
            this.Close();
            
        }
    }
}
