namespace KKSys
{
    public partial class BaseForm : Form
    {
        public Form currentChildForm;
        public BaseForm()
        {
            InitializeComponent();
        }

        public void openChildForm(Form childForm)
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

        private void addRegionButton_Click(object sender, EventArgs e)
        {
            newRegion region = new newRegion();

            openChildForm(region);

            /*newRegion region = new newRegion();
            region.MdiParent = this;
            region.Show();*/
        }

        private void addDistrictButton_Click(object sender, EventArgs e)
        {
            newDistrict district = new newDistrict();

            openChildForm(district);

            /*newDistrict district = new newDistrict();
            district.MdiParent = this;
            district.Show();*/
        }

        private void addZoneButton_Click(object sender, EventArgs e)
        {
            newZone zone = new newZone();

            openChildForm(zone);

            /*newZone zone = new newZone();
            zone.MdiParent = this;
            zone.Show();*/
        }
    }
}
