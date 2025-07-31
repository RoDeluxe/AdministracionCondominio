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
    public partial class FormPago : Form
    {
        string connectionString = @"Server=.\SQLEXPRESS;Database=CondominioDB;Trusted_Connection=True;";
        bool nuevo;
        public FormPago()
        {
            InitializeComponent();
            CargarDatos();
        }

        public void CargarDatos()
        {
            string sql = "SELECT * FROM Pago order by id desc";

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
        private void FormPago_Load(object sender, EventArgs e)
        {
            txtidresident.Enabled = false;
        }
        private void btnnuevo_Click(object sender, EventArgs e)
        {
            toogle(true);
            nuevo = true;
        }
        public void toogle(bool estado)
        {
            //Cambiar el status enable
            txtidresident.Enabled = estado;
            txtidcuota.Enabled = estado;
            dateTimePicker1.Enabled = estado;
            txtmonto.Enabled = estado;
            btnGuardar.Enabled = estado;
            nuevo = estado;

            //Limpiar los campos
            txtidresident.Enabled = estado;
            txtidcuota.Enabled = estado;
            txtmonto.Enabled = estado;
            btnGuardar.Enabled = estado;

        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (nuevo)
            {

                string sql = "INSERT INTO Pago (residente_id, cuota_id, fecha_pago, monto_pagado)"
                + "VALUES (" + txtidresident.Text + ", " + txtidcuota.Text + ", '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' , " + txtmonto.Text + ")";

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
