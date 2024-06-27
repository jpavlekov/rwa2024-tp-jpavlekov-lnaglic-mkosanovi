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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SCVZ
{
    public partial class FrmSCVZ : Form
    {
        private string _username;

        public FrmSCVZ(string username)
        {
            InitializeComponent();
            _username = username;
        }

        private void FrmSCVZ_Load(object sender, EventArgs e)
        {
            DB.SetConfiguration("RWA2324_10_DB", "RWA2324_10_User", ".{uKv:b%");
            Users user = UsersRepository.GetUser(_username);

            if (user != null && user.ID_Role == 1)
            {
                btnPopularDish.Visible = true;
                btnReport.Visible = true;
            } else
            {
                btnPopularDish.Visible = false;
                btnReport.Visible = false;
            }
            
        }

        private int VerifyUserAndGetId(string username)
        {
            int userId = -1;
            string password = "student";

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

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void dnevniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<MenuItems> menus = MenuItems.GetMenuDnevni();
            dgvMenu.DataSource = menus;
            dgvMenu.Columns["Id_item"].Visible = false;
        }

        private void tjedniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<MenuItems> menus = MenuItems.GetMenuTjedni();
            dgvMenu.DataSource = menus;
            dgvMenu.Columns["Id_item"].Visible = false;
        }

        private void mjesečniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<MenuItems> menus = MenuItems.GetMenuMjesecni();
            dgvMenu.DataSource = menus;
            dgvMenu.Columns["Id_item"].Visible = false;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            Order order = new Order(_username);
            Hide();
            order.ShowDialog();
            Close();
        }

        private void bttnRecenzije_Click(object sender, EventArgs e)
        {
            this.Hide();
            Recenziranje rec = new Recenziranje(_username);
            rec.ShowDialog();
            Close();

        }
    }
}
