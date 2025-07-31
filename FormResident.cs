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

    public partial class FormResident : FormPrincipal
    {
        string connectionString = @"Server=.\SQLEXPRESS;Database=CondominioDB;Trusted_Connection=True;";
        bool nuevo;
        public FormResident()
        {
            InitializeComponent();
            CargarDatos();
        }

        public void CargarDatos()
        {
            string sql = "SELECT * FROM Residente order by id desc";

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
        private void FormResident_Load(object sender, EventArgs e)
        {
            txtnombre.Focus();
        }
        private void btnnuevo_Click(object sender, EventArgs e)
        {
            toogle(true);
            nuevo = true;
        }

        public void toogle(bool estado)
        {
            //Cambiar el status enable
            txtnombre.Enabled = estado;
            txtapellido.Enabled = estado;
            txtcorreo.Enabled = estado;
            txttelefono.Enabled = estado;
            txtidapartamento.Enabled = estado;
            btnGuardar.Enabled = estado;
            nuevo = estado;

            //Limpiar los campos
            txtnombre.Text = "";
            txtapellido.Text = "";
            txtcorreo.Text = "";
            txttelefono.Text = "";
            txtidapartamento.Text = "";
            btnGuardar.Enabled = estado;


        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (nuevo)
            {

                string sql = "INSERT INTO Residente (nombre, apellido, telefono, email, apartamento_id)"
                + "VALUES ( '" + txtnombre.Text + "', '" + txtapellido.Text + "', '" + txttelefono.Text + "' , '" + txtcorreo.Text + "', " + txtidapartamento.Text + ")";



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

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
