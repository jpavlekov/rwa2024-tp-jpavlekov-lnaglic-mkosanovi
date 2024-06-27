using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SCVZ
{
    public class MenuItems
    {
        public int Id_item { get; set; }

        public string Name { get; set; }

        public string Juha { get; set; }

        public string Glavno_Jelo { get; set; }

        public string Prilog { get; set; }

        public string Desert { get; set; }

        public string Vrsta { get; set; }

        public MenuItems() { }

        public MenuItems(int id_item, string name, string juha, string glavno_jelo, string prilog, string desert, string vrsta)
        {
            Id_item = id_item;
            Name = name;
            Juha = juha;
            Glavno_Jelo = glavno_jelo;
            Prilog = prilog;
            Desert = desert;
            Vrsta = vrsta;
        }
        public static List<MenuItems> GetMenuDnevni()
        {
            List<MenuItems> menus = new List<MenuItems>();
            using (SqlConnection conn = new SqlConnection(@"Data Source=31.147.206.65;Initial Catalog=RWA2324_10_DB;Persist Security Info=True;User ID=RWA2324_10_User;Password=.{uKv:b%;TrustServerCertificate=True"))
            {
                string querry = "SELECT * FROM MenuItems WHERE vrsta = 'dnevni'" ;
                SqlCommand cmd = new SqlCommand(querry, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        MenuItems menu = new MenuItems
                        {
                            
                            Name= reader["Name"].ToString(),
                            Juha = reader["Juha"].ToString(),
                            Glavno_Jelo = reader["Glavno_Jelo"].ToString(),
                            Prilog = reader["Prilog"].ToString(),
                            Desert = reader["Desert"].ToString(),
                            Vrsta = reader["Vrsta"].ToString(),

                        };
                        menus.Add(menu);
                    }
                }
                conn.Close();
            }
            return menus;
        }
        public static List<MenuItems> GetMenuTjedni()
        {
            List<MenuItems> menus = new List<MenuItems>();
            using (SqlConnection conn = new SqlConnection(@"Data Source=31.147.206.65;Initial Catalog=RWA2324_10_DB;Persist Security Info=True;User ID=RWA2324_10_User;Password=.{uKv:b%;TrustServerCertificate=True"))
            {
                string querry = "SELECT * FROM MenuItems WHERE vrsta = 'tjedni'";
                SqlCommand cmd = new SqlCommand(querry, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        MenuItems menu = new MenuItems
                        {

                            Name = reader["Name"].ToString(),
                            Juha = reader["Juha"].ToString(),
                            Glavno_Jelo = reader["Glavno_Jelo"].ToString(),
                            Prilog = reader["Prilog"].ToString(),
                            Desert = reader["Desert"].ToString(),
                            Vrsta = reader["Vrsta"].ToString(),

                        };
                        menus.Add(menu);
                    }
                }
                conn.Close();
            }
            return menus;
        }
        public static List<MenuItems> GetMenuMjesecni()
        {
            List<MenuItems> menus = new List<MenuItems>();
            using (SqlConnection conn = new SqlConnection(@"Data Source=31.147.206.65;Initial Catalog=RWA2324_10_DB;Persist Security Info=True;User ID=RWA2324_10_User;Password=.{uKv:b%;TrustServerCertificate=True"))
            {
                string querry = "SELECT * FROM MenuItems WHERE vrsta = 'mjesecni'";
                SqlCommand cmd = new SqlCommand(querry, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        MenuItems menu = new MenuItems
                        {

                            Name = reader["Name"].ToString(),
                            Juha = reader["Juha"].ToString(),
                            Glavno_Jelo = reader["Glavno_Jelo"].ToString(),
                            Prilog = reader["Prilog"].ToString(),
                            Desert = reader["Desert"].ToString(),
                            Vrsta = reader["Vrsta"].ToString(),

                        };
                        menus.Add(menu);
                    }
                }
                conn.Close();
            }
            return menus;
        }
        public static List<MenuItems> GetMenu()
        {
            List<MenuItems> menus = new List<MenuItems>();
            using (SqlConnection conn = new SqlConnection(@"Data Source=31.147.206.65;Initial Catalog=RWA2324_10_DB;Persist Security Info=True;User ID=RWA2324_10_User;Password=.{uKv:b%;TrustServerCertificate=True"))
            {
                string querry = "SELECT * FROM MenuItems";
                SqlCommand cmd = new SqlCommand(querry, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        MenuItems menu = new MenuItems
                        { 
                            Id_item = (int)reader["Id_item"],
                            Name = reader["Name"].ToString(),
                            Juha = reader["Juha"].ToString(),
                            Glavno_Jelo = reader["Glavno_Jelo"].ToString(),
                            Prilog = reader["Prilog"].ToString(),
                            Desert = reader["Desert"].ToString(),
                            Vrsta = reader["Vrsta"].ToString(),

                        };
                        menus.Add(menu);
                    }
                }
                conn.Close();
            }
            return menus;
        }

      
    }

}
