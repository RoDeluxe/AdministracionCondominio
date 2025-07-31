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
    public partial class FormCuota : FormPrincipal
    {
        string connectionString = @"Server=.\SQLEXPRESS;Database=CondominioDB;Trusted_Connection=True;";
        bool nuevo;
        public FormCuota()
        {
            InitializeComponent();
            CargarDatos();
        }

        public void CargarDatos()
        {
            string sql = "SELECT * FROM Cuota order by id desc";

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
        private void FormCuota_Load(object sender, EventArgs e)
        {
            txtdescrip.Focus();
        }
        private void btnnuevo_Click(object sender, EventArgs e)
        {
            toogle(true);
            nuevo = true;
        }
        public void toogle(bool estado)
        {
            //Cambiar el status enable
            txtdescrip.Enabled = estado;
            txtmonto.Enabled = estado;
            dateTimePicker1.Enabled = estado;
            btnGuardar.Enabled = estado;
            nuevo = estado;

            //Limpiar los campos
            txtdescrip.Text = "";
            txtmonto.Text = "";
            btnGuardar.Enabled = estado;

        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (nuevo)
            {

                string sql = "INSERT INTO Cuota (descripcion, monto, fecha_vencimiento)"
                + "VALUES ('" + txtdescrip.Text + "', " + txtmonto.Text + ", '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "')";

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
