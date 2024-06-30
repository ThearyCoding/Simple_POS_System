using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Simple_POS_system
{
    public partial class LoginForm : Form
    {

        string DBconnectionString = 
            @"Data Source=DESKTOP-NV73NMK;Initial Catalog=IlluminatiDB;Integrated Security=True;TrustServerCertificate=True";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {

            SqlConnection connection = new SqlConnection(DBconnectionString);

            try
            {
                connection.Open();
                string loginQuery = $"SELECT COUNT(*) FROM tblUsers WHERE username=@username AND password=@password";
                SqlCommand sql = new SqlCommand(loginQuery, connection);
                sql.Parameters.AddWithValue("@username", usernameTxtBox.Text);
                sql.Parameters.AddWithValue("@password", PasswordTxtBox.Text);
                int count = (int)sql.ExecuteScalar();
                connection.Close();
                if (count > 0)
                {
                    MessageBox.Show("connection successful");
                    Form1 frm = new Form1();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("connection fail");
                }
            }catch (Exception exception)
            {
                MessageBox.Show("There is an error with the database connection" + exception);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
