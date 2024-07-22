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
using static Google.Protobuf.Reflection.SourceCodeInfo.Types;


namespace KKSys
{
    public partial class newFarmer : Form
    {
        public newFarmer()
        {
            InitializeComponent();
        }

        private void newFarmer_Load(object sender, EventArgs e)
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

        }

        private void newFarmerClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addFarmer(string firstName, string surName, string gender, string dob, string location, string phone_number, string membershipID, string nationalID)
        {


            if (string.IsNullOrEmpty(firstName))
            {
                MessageBox.Show("First name field is required", "New farmer dialogue", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(surName))
            {
                MessageBox.Show("Last name field is required", "New farmer dialogue", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (string.IsNullOrEmpty(gender))
            {
                MessageBox.Show("Gender field is required", "New farmer dialogue", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(dob))
            {
                MessageBox.Show("Date of Birth field is required", "New farmer dialogue", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (string.IsNullOrEmpty(location))
            {
                MessageBox.Show("Location field is required", "New farmer dialogue", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (string.IsNullOrEmpty(phone_number))
            {
                MessageBox.Show("Phone number field is required", "New farmer dialogue", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (string.IsNullOrEmpty(nationalID))
            {
                MessageBox.Show("National ID field is required", "New farmer dialogue", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {

                try
                {


                    string connectionString = "server=localhost; user name=root; password=; database=kks_database;";
                    MySqlConnection conn = new MySqlConnection(connectionString);
                    conn.Open();

                    string sqlCommand = "INSERT INTO farmer(first_name, last_name, gender, phone_number, national_id, membership_id, location, dob) VALUES(@first_name, @last_name, @gender, @phone_number, @national_id, @membership_id, @location, @dob)";

                    MySqlCommand cmd = new MySqlCommand(sqlCommand, conn);
                    cmd.Parameters.AddWithValue("first_name", firstName);
                    cmd.Parameters.AddWithValue("last_name", surName);
                    cmd.Parameters.AddWithValue("gender", gender);
                    cmd.Parameters.AddWithValue("dob", dob);
                    cmd.Parameters.AddWithValue("location", location);
                    cmd.Parameters.AddWithValue("phone_number", phone_number);
                    cmd.Parameters.AddWithValue("membership_id", membershipID);
                    cmd.Parameters.AddWithValue("national_id", nationalID);
                    cmd.ExecuteNonQuery();

                    conn.Close();

                    txtFirstname.Clear();
                    txtSurname.Clear();
                    cmbGender.SelectedIndex = 0;
                    txtLocation.Clear();
                    txtPhone.Clear();
                    txtLocation.Clear();
                    txtMemberID.Clear();
                    txtNationalID.Clear();
                    dbDOB.Value = DateTime.Now;

                    MessageBox.Show("Data saved successfully!", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);



                }
                catch (Exception ex) {

                    MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }




            }


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            string firstName = txtFirstname.Text;
            string surName = txtSurname.Text;
            string gender = cmbGender.Text;
            DateTime dob = dbDOB.Value;
            string location = txtLocation.Text;
            string phone_number = txtPhone.Text;
            string membershipID = txtMemberID.Text;
            string nationalID = txtNationalID.Text;

            addFarmer(firstName, surName, gender, dob.ToString("yyyy-MM-dd"), location, phone_number, membershipID, nationalID);

           
        }
    }
}
