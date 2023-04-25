using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace ADO_NETProject01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.
                ConnectionStrings["CS_ADO_NET"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "Insert into FORNECEDORES(nome, cnpj)" +
                " values(@nome, @cnpj)";
            command.Parameters.AddWithValue("@nome", textBoxNome.Text);
            command.Parameters.AddWithValue("@cnpj", textBoxCnpj.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Fornecedor registrado com sucesso");
        }
    }
}
