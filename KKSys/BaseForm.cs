namespace KKSys
{
    public partial class BaseForm : Form
    {
        private Form currentChildForm;
        public BaseForm()
        {
            InitializeComponent();
        }

        private void openChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addFarmerButton_Click(object sender, EventArgs e)
        {
            newFarmer farmer = new newFarmer();

            openChildForm(farmer);

            /*newFarmer farmer = new newFarmer();
            farmer.MdiParent = this;
            farmer.Show();*/
        }

        private void displayFarmersButton_Click(object sender, EventArgs e)
        {
            FarmersRecordTable farmersRecord = new FarmersRecordTable();
            openChildForm(farmersRecord);
        }
    }
}
