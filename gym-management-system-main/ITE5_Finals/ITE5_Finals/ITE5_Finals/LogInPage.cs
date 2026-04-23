using MySql.Data.MySqlClient;

namespace ITE5_Finals
{
    public partial class LogInPage : Form
    {

        string connString = "Server=127.0.0.1;Database=mydb;Uid=root;Pwd=XRaey@sz04r;";
        public LogInPage()
        {
            InitializeComponent();

            txtPassword.Text = "";
            txtPassword.PasswordChar = '•';
            txtPassword.UseSystemPasswordChar = false;
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private int attempts = 0;
        private void btnEnter_Click(object sender, EventArgs e)
        {
            // ? STEP 1: Get input + trim spaces
            string name = txtUserName.Text.Trim();
            string pass = txtPassword.Text.Trim();

         
            if (name == "" || pass == "")
            {
                MessageBox.Show("Please fill in all fields");
                return;
            }

            try
            {
            
                MySqlConnection conn = new MySqlConnection(connString);
                conn.Open();

      
                string query = "SELECT COUNT(*) FROM users WHERE NAME=@name AND PASSWORD=@pass";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@pass", pass);

                int result = Convert.ToInt32(cmd.ExecuteScalar());

                conn.Close();

                if (result > 0)
                {
                    MessageBox.Show("Login successful!");

                    MainPage main = new MainPage();
                    main.Show();
                    this.Hide();
                }
                else
                {
                    attempts++;

                    MessageBox.Show("Incorrect Username or Password");


                    txtUserName.Clear();
                    txtPassword.Clear();
                    txtUserName.Focus();

                    if (attempts >= 3)
                    {
                        MessageBox.Show("Too many failed attempts. Application will close.");
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnCreateAcc_Click(object sender, EventArgs e)
        {
            NewAcc newAcc = new NewAcc();
            newAcc.Show();
            this.Hide();
        }

        private void LogInPage_Load(object sender, EventArgs e)
        {
           
        }
    }
}
