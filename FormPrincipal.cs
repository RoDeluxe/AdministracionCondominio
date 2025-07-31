using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdministracionCondominio
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void residenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormResident formResident = new FormResident();
            formResident.Show();
        }

        private void apartamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormApartament formApartament = new FormApartament();
            formApartament.Show();
        }

        private void cuotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCuota formCuota = new FormCuota();
            formCuota.Show();
        }

        private void pagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPago formPago = new FormPago();
            formPago.Show();
        }

        private void servicioMantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormServicioMantenimiento formServicioMantenimiento = new FormServicioMantenimiento();
            formServicioMantenimiento.Show();
        }
    }
}
