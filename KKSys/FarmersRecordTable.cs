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
    public partial class FarmersRecordTable : Form
    {
        public FarmersRecordTable()
        {
            InitializeComponent();
        }

        private void FarmersRecordTable_SizeChanged(object sender, EventArgs e)
        {



        }

        private void FarmersRecordTable_Load(object sender, EventArgs e)
        {

            injectFarmerData();


        }

        private void btnFarmersMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }

        }

        private void btnFarmersClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void injectFarmerData()
        {
            try
            {
                DataTable myDataTable = new DataTable();

                string connectionString = "server=localhost; user name=root; password=; database=kks_database;";
                MySqlConnection conn = new MySqlConnection(connectionString);
                conn.Open();

                string sqlCommand = "SELECT id AS ID, first_name AS FirstName, last_name AS LastName, gender AS Gender, phone_number AS PhoneNumber, national_id AS NationalID, membership_id AS MembershipID, location AS Location, dob AS DoB FROM farmer ORDER by id";

                MySqlCommand command = new MySqlCommand(sqlCommand, conn);
                using (MySqlDataReader dataReader = command.ExecuteReader())
                {
                    myDataTable.Load(dataReader);
                }

                farmersTableGrid.DataSource = myDataTable;

                conn.Close();   
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void farmersTableGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            
            
        }
    }
}
