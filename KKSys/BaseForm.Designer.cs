namespace KKSys
{
    partial class BaseForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
            panel1 = new Panel();
            searchButton = new Button();
            txtSearchBox = new TextBox();
            menuStrip1 = new MenuStrip();
            dashboardButton = new ToolStripMenuItem();
            farmersToolStripMenuItem = new ToolStripMenuItem();
            displayFarmersButton = new ToolStripMenuItem();
            addFarmerButton = new ToolStripMenuItem();
            farmsToolStripMenuItem = new ToolStripMenuItem();
            displayFarmButton = new ToolStripMenuItem();
            addFarmsButton = new ToolStripMenuItem();
            kKDetailsToolStripMenuItem = new ToolStripMenuItem();
            regionToolStripMenuItem = new ToolStripMenuItem();
            addRegionButton = new ToolStripMenuItem();
            dIsplayRegionsButton = new ToolStripMenuItem();
            districtToolStripMenuItem = new ToolStripMenuItem();
            addDistrictButton = new ToolStripMenuItem();
            displayDistrictButton = new ToolStripMenuItem();
            zoneToolStripMenuItem = new ToolStripMenuItem();
            addZoneButton = new ToolStripMenuItem();
            showRecordsButton = new ToolStripMenuItem();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Lavender;
            panel1.Controls.Add(searchButton);
            panel1.Controls.Add(txtSearchBox);
            panel1.Controls.Add(menuStrip1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1180, 70);
            panel1.TabIndex = 1;
            // 
            // searchButton
            // 
            searchButton.Anchor = AnchorStyles.Right;
            searchButton.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchButton.Image = (Image)resources.GetObject("searchButton.Image");
            searchButton.Location = new Point(1063, 12);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(85, 48);
            searchButton.TabIndex = 1;
            searchButton.UseVisualStyleBackColor = true;
            // 
            // txtSearchBox
            // 
            txtSearchBox.Anchor = AnchorStyles.Right;
            txtSearchBox.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearchBox.Location = new Point(625, 12);
            txtSearchBox.Multiline = true;
            txtSearchBox.Name = "txtSearchBox";
            txtSearchBox.PlaceholderText = "Search ...";
            txtSearchBox.Size = new Size(432, 48);
            txtSearchBox.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.Anchor = AnchorStyles.Left;
            menuStrip1.BackColor = Color.Transparent;
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { dashboardButton, farmersToolStripMenuItem, farmsToolStripMenuItem, kKDetailsToolStripMenuItem });
            menuStrip1.Location = new Point(22, 12);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(6, 2, 0, 10);
            menuStrip1.Size = new Size(783, 48);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // dashboardButton
            // 
            dashboardButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dashboardButton.Image = Properties.Resources.icons8_home_30;
            dashboardButton.Name = "dashboardButton";
            dashboardButton.Size = new Size(172, 36);
            dashboardButton.Text = "Dashboard";
            // 
            // farmersToolStripMenuItem
            // 
            farmersToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { displayFarmersButton, addFarmerButton });
            farmersToolStripMenuItem.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            farmersToolStripMenuItem.Image = Properties.Resources.icons8_people_30;
            farmersToolStripMenuItem.Name = "farmersToolStripMenuItem";
            farmersToolStripMenuItem.Size = new Size(140, 36);
            farmersToolStripMenuItem.Text = "Farmers";
            // 
            // displayFarmersButton
            // 
            displayFarmersButton.Name = "displayFarmersButton";
            displayFarmersButton.Size = new Size(289, 40);
            displayFarmersButton.Text = "Display Farmers";
            displayFarmersButton.Click += displayFarmersButton_Click;
            // 
            // addFarmerButton
            // 
            addFarmerButton.Name = "addFarmerButton";
            addFarmerButton.Size = new Size(289, 40);
            addFarmerButton.Text = "Add Farmer";
            addFarmerButton.Click += addFarmerButton_Click;
            // 
            // farmsToolStripMenuItem
            // 
            farmsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { displayFarmButton, addFarmsButton });
            farmsToolStripMenuItem.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            farmsToolStripMenuItem.Image = Properties.Resources.icons8_cocoa_30;
            farmsToolStripMenuItem.Name = "farmsToolStripMenuItem";
            farmsToolStripMenuItem.Size = new Size(118, 36);
            farmsToolStripMenuItem.Text = "Farms";
            // 
            // displayFarmButton
            // 
            displayFarmButton.Name = "displayFarmButton";
            displayFarmButton.Size = new Size(270, 40);
            displayFarmButton.Text = "Display Farms";
            // 
            // addFarmsButton
            // 
            addFarmsButton.Name = "addFarmsButton";
            addFarmsButton.Size = new Size(270, 40);
            addFarmsButton.Text = "Add Farms";
            // 
            // kKDetailsToolStripMenuItem
            // 
            kKDetailsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { regionToolStripMenuItem, districtToolStripMenuItem, zoneToolStripMenuItem });
            kKDetailsToolStripMenuItem.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kKDetailsToolStripMenuItem.Image = Properties.Resources.icons8_records_30;
            kKDetailsToolStripMenuItem.Name = "kKDetailsToolStripMenuItem";
            kKDetailsToolStripMenuItem.Size = new Size(165, 36);
            kKDetailsToolStripMenuItem.Text = "KK Details";
            // 
            // regionToolStripMenuItem
            // 
            regionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addRegionButton, dIsplayRegionsButton });
            regionToolStripMenuItem.Name = "regionToolStripMenuItem";
            regionToolStripMenuItem.Size = new Size(195, 40);
            regionToolStripMenuItem.Text = "Region";
            // 
            // addRegionButton
            // 
            addRegionButton.Name = "addRegionButton";
            addRegionButton.Size = new Size(269, 40);
            addRegionButton.Text = "Add Region";
            // 
            // dIsplayRegionsButton
            // 
            dIsplayRegionsButton.Name = "dIsplayRegionsButton";
            dIsplayRegionsButton.Size = new Size(269, 40);
            dIsplayRegionsButton.Text = "Show Records";
            // 
            // districtToolStripMenuItem
            // 
            districtToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addDistrictButton, displayDistrictButton });
            districtToolStripMenuItem.Name = "districtToolStripMenuItem";
            districtToolStripMenuItem.Size = new Size(195, 40);
            districtToolStripMenuItem.Text = "District";
            // 
            // addDistrictButton
            // 
            addDistrictButton.Name = "addDistrictButton";
            addDistrictButton.Size = new Size(269, 40);
            addDistrictButton.Text = "Add District";
            // 
            // displayDistrictButton
            // 
            displayDistrictButton.Name = "displayDistrictButton";
            displayDistrictButton.Size = new Size(269, 40);
            displayDistrictButton.Text = "Show Records";
            // 
            // zoneToolStripMenuItem
            // 
            zoneToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addZoneButton, showRecordsButton });
            zoneToolStripMenuItem.Name = "zoneToolStripMenuItem";
            zoneToolStripMenuItem.Size = new Size(195, 40);
            zoneToolStripMenuItem.Text = "Zone";
            // 
            // addZoneButton
            // 
            addZoneButton.Name = "addZoneButton";
            addZoneButton.Size = new Size(269, 40);
            addZoneButton.Text = "Add Zone";
            // 
            // showRecordsButton
            // 
            showRecordsButton.Name = "showRecordsButton";
            showRecordsButton.Size = new Size(269, 40);
            showRecordsButton.Text = "Show Records";
            // 
            // BaseForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1180, 831);
            Controls.Add(panel1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "BaseForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KKSys";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtSearchBox;
        private Button searchButton;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem dashboardButton;
        private ToolStripMenuItem farmersToolStripMenuItem;
        private ToolStripMenuItem farmsToolStripMenuItem;
        private ToolStripMenuItem kKDetailsToolStripMenuItem;
        private ToolStripMenuItem displayFarmersButton;
        private ToolStripMenuItem addFarmerButton;
        private ToolStripMenuItem displayFarmButton;
        private ToolStripMenuItem addFarmsButton;
        private ToolStripMenuItem regionToolStripMenuItem;
        private ToolStripMenuItem addRegionButton;
        private ToolStripMenuItem dIsplayRegionsButton;
        private ToolStripMenuItem districtToolStripMenuItem;
        private ToolStripMenuItem addDistrictButton;
        private ToolStripMenuItem displayDistrictButton;
        private ToolStripMenuItem zoneToolStripMenuItem;
        private ToolStripMenuItem addZoneButton;
        private ToolStripMenuItem showRecordsButton;
    }
}
