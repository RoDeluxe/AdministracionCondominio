using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdministracionCondominio
{
    public partial class FormServicioMantenimiento : Form
    {
        string connectionString = @"Server=.\SQLEXPRESS;Database=CondominioDB;Trusted_Connection=True;";
        bool nuevo;
        public FormServicioMantenimiento()
        {
            InitializeComponent();
            CargarDatos();
        }


        public void CargarDatos()
        {
            string sql = "SELECT * FROM ServicioMantenimiento order by id desc";

            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                    MessageBox.Show("Registro ingresado correctamente !");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
            }
            finally
            {
                con.Close();
            }
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dgvClientes.DataSource = dataTable;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FormServicioMantenimiento_Load(object sender, EventArgs e)
        {
            txtservicio.Focus();
        }
        private void btnnuevo_Click(object sender, EventArgs e)
        {
            toogle(true);
            nuevo = true;
        }
        public void toogle(bool estado)
        {
            //Cambiar el status enable
            txtservicio.Enabled = estado;
            dateTimePicker1.Enabled = estado;
            txtcosto.Enabled = estado;
            btnGuardar.Enabled = estado;
            nuevo = estado;

            //Limpiar los campos
            txtservicio.Text = "";
            txtcosto.Text = "";
            btnGuardar.Enabled = estado;

        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (nuevo)
            {

                string sql = "INSERT INTO ServicioMantenimiento (descripcion, fecha, costo)"
                + "VALUES ('" + txtservicio.Text + "', '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "', '" + txtcosto.Text + "')";

                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                        MessageBox.Show("Registro ingresado correctamente !");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.ToString());
                }
                finally
                {
                    con.Close();
                }
            }

            CargarDatos();
            dgvClientes.Update();
            dgvClientes.Refresh();


            toogle(false);
        }
 
    }
}
