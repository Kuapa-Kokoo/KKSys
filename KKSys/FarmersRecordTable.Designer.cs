namespace KKSys
{
    partial class FarmersRecordTable
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            btnFarmersClose = new Button();
            btnFarmersMaximize = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            id = new DataGridViewTextBoxColumn();
            firstName = new DataGridViewTextBoxColumn();
            surName = new DataGridViewTextBoxColumn();
            gender = new DataGridViewTextBoxColumn();
            DoB = new DataGridViewTextBoxColumn();
            farmerID = new DataGridViewTextBoxColumn();
            nationalID = new DataGridViewTextBoxColumn();
            phoneNumber = new DataGridViewTextBoxColumn();
            location = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, firstName, surName, gender, DoB, farmerID, nationalID, phoneNumber, location });
            dataGridView1.Location = new Point(12, 68);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1416, 741);
            dataGridView1.TabIndex = 0;
            // 
            // btnFarmersClose
            // 
            btnFarmersClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnFarmersClose.FlatAppearance.BorderSize = 0;
            btnFarmersClose.FlatStyle = FlatStyle.Flat;
            btnFarmersClose.Image = Properties.Resources.icons8_close_30;
            btnFarmersClose.Location = new Point(1345, 2);
            btnFarmersClose.Name = "btnFarmersClose";
            btnFarmersClose.Size = new Size(94, 60);
            btnFarmersClose.TabIndex = 1;
            btnFarmersClose.UseVisualStyleBackColor = true;
            btnFarmersClose.Click += btnFarmersClose_Click;
            // 
            // btnFarmersMaximize
            // 
            btnFarmersMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnFarmersMaximize.FlatAppearance.BorderSize = 0;
            btnFarmersMaximize.FlatStyle = FlatStyle.Flat;
            btnFarmersMaximize.Image = Properties.Resources.icons8_maximize_30;
            btnFarmersMaximize.Location = new Point(1245, 2);
            btnFarmersMaximize.Name = "btnFarmersMaximize";
            btnFarmersMaximize.Size = new Size(94, 60);
            btnFarmersMaximize.TabIndex = 2;
            btnFarmersMaximize.UseVisualStyleBackColor = true;
            btnFarmersMaximize.Click += btnFarmersMaximize_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button1.Image = Properties.Resources.icons8_delete_30;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(60, 816);
            button1.Name = "button1";
            button1.Padding = new Padding(10, 0, 0, 0);
            button1.Size = new Size(134, 53);
            button1.TabIndex = 3;
            button1.Text = "DELETE";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button2.Image = Properties.Resources.icons8_update_30;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(219, 816);
            button2.Name = "button2";
            button2.Padding = new Padding(10, 0, 0, 0);
            button2.Size = new Size(151, 53);
            button2.TabIndex = 4;
            button2.Text = "UPDATE";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button3.Image = Properties.Resources.icons8_plus_301;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(396, 816);
            button3.Name = "button3";
            button3.Padding = new Padding(10, 0, 0, 0);
            button3.Size = new Size(151, 53);
            button3.TabIndex = 5;
            button3.Text = "ADD";
            button3.UseVisualStyleBackColor = true;
            // 
            // id
            // 
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            id.DefaultCellStyle = dataGridViewCellStyle1;
            id.HeaderText = "ID";
            id.MinimumWidth = 8;
            id.Name = "id";
            id.Width = 150;
            // 
            // firstName
            // 
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            firstName.DefaultCellStyle = dataGridViewCellStyle2;
            firstName.HeaderText = "First Name";
            firstName.MinimumWidth = 8;
            firstName.Name = "firstName";
            firstName.Width = 150;
            // 
            // surName
            // 
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            surName.DefaultCellStyle = dataGridViewCellStyle3;
            surName.HeaderText = "Surname";
            surName.MinimumWidth = 8;
            surName.Name = "surName";
            surName.Width = 150;
            // 
            // gender
            // 
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gender.DefaultCellStyle = dataGridViewCellStyle4;
            gender.HeaderText = "Gender";
            gender.MinimumWidth = 8;
            gender.Name = "gender";
            gender.Width = 150;
            // 
            // DoB
            // 
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DoB.DefaultCellStyle = dataGridViewCellStyle5;
            DoB.HeaderText = "Date of Birth";
            DoB.MinimumWidth = 8;
            DoB.Name = "DoB";
            DoB.Width = 150;
            // 
            // farmerID
            // 
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            farmerID.DefaultCellStyle = dataGridViewCellStyle6;
            farmerID.HeaderText = "Farmer ID";
            farmerID.MinimumWidth = 8;
            farmerID.Name = "farmerID";
            farmerID.Width = 150;
            // 
            // nationalID
            // 
            dataGridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nationalID.DefaultCellStyle = dataGridViewCellStyle7;
            nationalID.HeaderText = "National ID";
            nationalID.MinimumWidth = 8;
            nationalID.Name = "nationalID";
            nationalID.Width = 150;
            // 
            // phoneNumber
            // 
            dataGridViewCellStyle8.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            phoneNumber.DefaultCellStyle = dataGridViewCellStyle8;
            phoneNumber.HeaderText = "Phone Number";
            phoneNumber.MinimumWidth = 8;
            phoneNumber.Name = "phoneNumber";
            phoneNumber.Width = 150;
            // 
            // location
            // 
            dataGridViewCellStyle9.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            location.DefaultCellStyle = dataGridViewCellStyle9;
            location.HeaderText = "Location";
            location.MinimumWidth = 8;
            location.Name = "location";
            location.Width = 150;
            // 
            // FarmersRecordTable
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1440, 874);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnFarmersMaximize);
            Controls.Add(btnFarmersClose);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FarmersRecordTable";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FarmersRecordTable";
            Load += FarmersRecordTable_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnFarmersClose;
        private Button btnFarmersMaximize;
        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn firstName;
        private DataGridViewTextBoxColumn surName;
        private DataGridViewTextBoxColumn gender;
        private DataGridViewTextBoxColumn DoB;
        private DataGridViewTextBoxColumn farmerID;
        private DataGridViewTextBoxColumn nationalID;
        private DataGridViewTextBoxColumn phoneNumber;
        private DataGridViewTextBoxColumn location;
    }
}