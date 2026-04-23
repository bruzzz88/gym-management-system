using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITE5_Finals
{
    public partial class NewAcc : Form
    {
        public NewAcc()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();

            LogInPage login = new LogInPage();
            login.Show();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string name = txtNAuser.Text.Trim();
            string pass = txtNApass.Text.Trim();

            if (name == "" || pass == "")
            {
                MessageBox.Show("Please fill in all fields");
                return;
            }

            try
            {
                MySqlConnection conn = new MySqlConnection(DBConnection.connString);
                conn.Open();

                string query = "INSERT INTO users (NAME, PASSWORD) VALUES (@name, @pass)";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@pass", pass);

                cmd.ExecuteNonQuery();

                conn.Close();

                MessageBox.Show("Account created successfully!");

                txtNAuser.Clear();
                txtNApass.Clear();
                txtNAuser.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void txtNAuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNApass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
