using SCVZ.Models;
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
    public partial class Order : Form
    {
        private string _username;

        private int idItema;
        private int idUsera;
        public Order(string username)
        {
            InitializeComponent();
            _username = username;

        }

        private void Order_Load(object sender, EventArgs e)
        {
            List<MenuItems> menus = MenuItems.GetMenu();
            dgvOrder.DataSource = menus;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmSCVZ frm = new FrmSCVZ(_username);
            frm.ShowDialog();
            Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvOrder.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a menu item.");
                return;
            }

            int menuItemId = (int)dgvOrder.SelectedRows[0].Cells["id_item"].Value; 
            string idItem = GetMenuItem(menuItemId);

            if (idItem != null)
            {
                InsertOrder(idItem, CurrentUser.Id_User);
            }
            else
            {
                MessageBox.Show("Selected menu item could not be found.");
            }


        }
        private string GetMenuItem(int menuItemId)
        {
            string idItem = null;

            using (SqlConnection conn = new SqlConnection(@"Data Source=31.147.206.65;Initial Catalog=RWA2324_10_DB;Persist Security Info=True;User ID=RWA2324_10_User;Password=.{uKv:b%;TrustServerCertificate=True"))
            {
                string query = "SELECT Id_item FROM MenuItems WHERE Id_item = @Id_item";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id_item", menuItemId);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        idItem = reader["Id_item"].ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }

            return idItem;
        }
        private void InsertOrder(string idItem, int id_User)
        {


            using (SqlConnection conn = new SqlConnection(@"Data Source=31.147.206.65;Initial Catalog=RWA2324_10_DB;Persist Security Info=True;User ID=RWA2324_10_User;Password=.{uKv:b%;TrustServerCertificate=True"))
            {
                string query = "INSERT INTO Orders (Id_item, Id_user) VALUES (@Id_Item, @Id_user)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id_Item", idItem);
                cmd.Parameters.AddWithValue("@Id_user", id_User);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Order placed successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

    }
}
