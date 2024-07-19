namespace KKSys
{
    partial class newFarmer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            newFarmerClose = new Button();
            label1 = new Label();
            txtFirstname = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtSurname = new TextBox();
            label4 = new Label();
            cmbGender = new ComboBox();
            label5 = new Label();
            dbDOB = new DateTimePicker();
            label6 = new Label();
            txtLocation = new TextBox();
            label7 = new Label();
            txtPhone = new TextBox();
            label8 = new Label();
            txtMemberID = new TextBox();
            label9 = new Label();
            txtNationalID = new TextBox();
            btnAdd = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Lavender;
            panel1.Controls.Add(newFarmerClose);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1329, 49);
            panel1.TabIndex = 0;
            // 
            // newFarmerClose
            // 
            newFarmerClose.Anchor = AnchorStyles.Right;
            newFarmerClose.FlatAppearance.BorderSize = 0;
            newFarmerClose.FlatStyle = FlatStyle.Flat;
            newFarmerClose.Image = Properties.Resources.icons8_close_30;
            newFarmerClose.Location = new Point(1246, 0);
            newFarmerClose.Name = "newFarmerClose";
            newFarmerClose.Size = new Size(83, 49);
            newFarmerClose.TabIndex = 0;
            newFarmerClose.UseVisualStyleBackColor = true;
            newFarmerClose.Click += newFarmerClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(483, 100);
            label1.Name = "label1";
            label1.Size = new Size(312, 48);
            label1.TabIndex = 1;
            label1.Text = "New Farmer Data";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtFirstname
            // 
            txtFirstname.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFirstname.Location = new Point(199, 191);
            txtFirstname.Multiline = true;
            txtFirstname.Name = "txtFirstname";
            txtFirstname.PlaceholderText = "Eg. Esther";
            txtFirstname.Size = new Size(432, 46);
            txtFirstname.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(53, 194);
            label2.Name = "label2";
            label2.Size = new Size(151, 36);
            label2.TabIndex = 3;
            label2.Text = "First Name: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(685, 196);
            label3.Name = "label3";
            label3.Size = new Size(123, 36);
            label3.TabIndex = 5;
            label3.Text = "Surname:";
            // 
            // txtSurname
            // 
            txtSurname.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSurname.Location = new Point(857, 191);
            txtSurname.Multiline = true;
            txtSurname.Name = "txtSurname";
            txtSurname.PlaceholderText = "Eg. Alhassan";
            txtSurname.Size = new Size(432, 46);
            txtSurname.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(53, 280);
            label4.Name = "label4";
            label4.Size = new Size(113, 36);
            label4.TabIndex = 6;
            label4.Text = "Gender: ";
            // 
            // cmbGender
            // 
            cmbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGender.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbGender.FormattingEnabled = true;
            cmbGender.Location = new Point(199, 283);
            cmbGender.MaximumSize = new Size(432, 0);
            cmbGender.MinimumSize = new Size(432, 0);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(432, 44);
            cmbGender.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(685, 280);
            label5.Name = "label5";
            label5.Size = new Size(166, 36);
            label5.TabIndex = 8;
            label5.Text = "Date of Birth:";
            // 
            // dbDOB
            // 
            dbDOB.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dbDOB.Location = new Point(857, 280);
            dbDOB.Name = "dbDOB";
            dbDOB.Size = new Size(432, 42);
            dbDOB.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(53, 379);
            label6.Name = "label6";
            label6.Size = new Size(125, 36);
            label6.TabIndex = 11;
            label6.Text = "Location: ";
            // 
            // txtLocation
            // 
            txtLocation.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLocation.Location = new Point(199, 376);
            txtLocation.Multiline = true;
            txtLocation.Name = "txtLocation";
            txtLocation.PlaceholderText = "Eg. Asokwa";
            txtLocation.Size = new Size(432, 46);
            txtLocation.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(685, 386);
            label7.Name = "label7";
            label7.Size = new Size(110, 36);
            label7.TabIndex = 13;
            label7.Text = "Contact:";
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhone.Location = new Point(857, 379);
            txtPhone.Multiline = true;
            txtPhone.Name = "txtPhone";
            txtPhone.PlaceholderText = "Eg. 0245127151";
            txtPhone.Size = new Size(432, 46);
            txtPhone.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(53, 473);
            label8.Name = "label8";
            label8.Size = new Size(150, 36);
            label8.TabIndex = 15;
            label8.Text = "Member ID:";
            // 
            // txtMemberID
            // 
            txtMemberID.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMemberID.Location = new Point(199, 470);
            txtMemberID.Multiline = true;
            txtMemberID.Name = "txtMemberID";
            txtMemberID.Size = new Size(432, 46);
            txtMemberID.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(685, 470);
            label9.Name = "label9";
            label9.Size = new Size(149, 36);
            label9.TabIndex = 17;
            label9.Text = "National ID:";
            // 
            // txtNationalID
            // 
            txtNationalID.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNationalID.Location = new Point(857, 467);
            txtNationalID.Multiline = true;
            txtNationalID.Name = "txtNationalID";
            txtNationalID.PlaceholderText = "Eg. GHA-141423412-2";
            txtNationalID.Size = new Size(432, 46);
            txtNationalID.TabIndex = 16;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Lavender;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatAppearance.MouseOverBackColor = Color.Azure;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Image = Properties.Resources.icons8_add_40;
            btnAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdd.Location = new Point(55, 595);
            btnAdd.Margin = new Padding(0, 3, 3, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Padding = new Padding(10);
            btnAdd.Size = new Size(204, 60);
            btnAdd.TabIndex = 18;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // newFarmer
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1329, 687);
            Controls.Add(label9);
            Controls.Add(txtNationalID);
            Controls.Add(label8);
            Controls.Add(txtMemberID);
            Controls.Add(label7);
            Controls.Add(txtPhone);
            Controls.Add(label6);
            Controls.Add(txtLocation);
            Controls.Add(dbDOB);
            Controls.Add(label5);
            Controls.Add(cmbGender);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtSurname);
            Controls.Add(label2);
            Controls.Add(txtFirstname);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(btnAdd);
            FormBorderStyle = FormBorderStyle.None;
            Name = "newFarmer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "newFarmer";
            Load += newFarmer_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button newFarmerClose;
        private Label label1;
        private TextBox txtFirstname;
        private Label label2;
        private Label label3;
        private TextBox txtSurname;
        private Label label4;
        private ComboBox cmbGender;
        private Label label5;
        private DateTimePicker dbDOB;
        private Label label6;
        private TextBox txtLocation;
        private Label label7;
        private TextBox txtPhone;
        private Label label8;
        private TextBox txtMemberID;
        private Label label9;
        private TextBox txtNationalID;
        private Button btnAdd;
    }
}