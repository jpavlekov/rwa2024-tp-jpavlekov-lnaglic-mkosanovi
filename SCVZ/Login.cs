using DBLayer;
using SCVZ.Models;
using SCVZ.Repositories;
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

namespace SCVZ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static Users LoggedUser { get; set; }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String username, password;
            int userId = VerifyUserAndGetId(txtUsername.Text, txtPassword.Text);
            username = txtUsername.Text;
            password = txtPassword.Text;
            if (txtUsername.Text == "")
            {
                MessageBox.Show("Username not inserted! Try again.");
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show($"Login failed: {txtUsername.Text}");
            } else
            {
                LoggedUser = UsersRepository.GetUser(txtUsername.Text);
                if (LoggedUser != null && LoggedUser.PasswordCorrect(txtPassword.Text))
                {
                    CurrentUser.Id_User = userId;
                    FrmSCVZ frm = new FrmSCVZ(txtUsername.Text);
                    Hide();
                    frm.ShowDialog();
                    Close();
                } else
                {
                    MessageBox.Show("Please try again.");
                }
            }
        }
        private int VerifyUserAndGetId(string username, string password)
        {
            int userId = -1;


            using (SqlConnection conn = new SqlConnection(@"Data Source=31.147.206.65;Initial Catalog=RWA2324_10_DB;Persist Security Info=True;User ID=RWA2324_10_User;Password=.{uKv:b%;TrustServerCertificate=True"))

            {
                string query = "SELECT id_user FROM Users WHERE username = @username AND password = @password";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        userId = reader.GetInt32(0);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }

            return userId;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DB.SetConfiguration("RWA2324_10_DB", "RWA2324_10_User", ".{uKv:b%");
        }
    }
}
