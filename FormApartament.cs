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
    public partial class FormApartament : FormPrincipal
    {
        string connectionString = @"Server=.\SQLEXPRESS;Database=CondominioDB;Trusted_Connection=True;";
        bool nuevo;
        public FormApartament()
        {
            InitializeComponent();
            CargarDatos();
        }


        public void CargarDatos()
        {
            string sql = "SELECT * FROM Apartamento order by id desc";

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
        private void FormApartament_Load(object sender, EventArgs e)
        {
            txtnumero.Focus();
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            toogle(true);
            nuevo = true;
        }
        public void toogle(bool estado)
        {
            //Cambiar el status enable
            txtnumero.Enabled = estado;
            txtpiso.Enabled = estado;
            txtarea.Enabled = estado;
            btnGuardar.Enabled = estado;
            nuevo = estado;

            //Limpiar los campos
            txtnumero.Enabled = estado;
            txtpiso.Enabled = estado;
            txtarea.Enabled = estado;
            btnGuardar.Enabled = estado;

        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (nuevo)
            {

                string sql = "INSERT INTO Apartamento (numero, piso, area_m2)"
                + "VALUES ('" + txtnumero.Text + "', " + txtpiso.Text + ", " + txtarea.Text + ")";

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
