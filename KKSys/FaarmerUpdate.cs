using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace KKSys
{
    public partial class FaarmerUpdate : Form
    {
        public FaarmerUpdate()
        {
            InitializeComponent();
        }

        private void FaarmerUpdate_Load(object sender, EventArgs e)
        {
            List<KeyValuePair<string, string>> items = new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair<string, string>("", ""),
                new KeyValuePair<string, string>("Male", "M"),
                new KeyValuePair<string, string>("Female", "F")
            };

            cmbGender.DataSource = items;
            cmbGender.DisplayMember = "Key";
            cmbGender.ValueMember = "Value";

            loadFarmerDetails();

        }

        private void loadFarmerDetails()
        {
            FarmersRecordTable table = new FarmersRecordTable();

            string conString = "server=localhost; user name=root; password=; database=kks_database";

            MySqlConnection connection = new MySqlConnection(conString);
            connection.Open();

            string sqlQuery = "SELECT first_name FROM farmer WHERE id=@farmer_id";

            MySqlCommand command = new MySqlCommand(sqlQuery, connection);
            command.Parameters.AddWithValue("farmer_id", table.farmerID.ToString());

            using (MySqlDataReader reader = command.ExecuteReader())
            {

                if (reader.Read())
                {

                    txtFirstname.Text = reader.GetString(0);

                }
                else
                {
                    MessageBox.Show("No rows found");
                }

            }

            connection.Close();

            MessageBox.Show(table.farmerID.ToString());

        }

    }

}
