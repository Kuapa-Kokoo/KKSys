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
            farmersTableGrid = new DataGridView();
            btnFarmersClose = new Button();
            btnFarmersMaximize = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)farmersTableGrid).BeginInit();
            SuspendLayout();
            // 
            // farmersTableGrid
            // 
            farmersTableGrid.AllowUserToAddRows = false;
            farmersTableGrid.AllowUserToDeleteRows = false;
            farmersTableGrid.AllowUserToOrderColumns = true;
            farmersTableGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            farmersTableGrid.BackgroundColor = SystemColors.AppWorkspace;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            farmersTableGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            farmersTableGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new Padding(1);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            farmersTableGrid.DefaultCellStyle = dataGridViewCellStyle2;
            farmersTableGrid.GridColor = Color.Black;
            farmersTableGrid.Location = new Point(12, 68);
            farmersTableGrid.Name = "farmersTableGrid";
            farmersTableGrid.ReadOnly = true;
            farmersTableGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            farmersTableGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            farmersTableGrid.Size = new Size(1416, 741);
            farmersTableGrid.TabIndex = 0;
            farmersTableGrid.CellContentClick += farmersTableGrid_CellContentClick;
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
            Controls.Add(farmersTableGrid);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FarmersRecordTable";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FarmersRecordTable";
            Load += FarmersRecordTable_Load;
            ((System.ComponentModel.ISupportInitialize)farmersTableGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView farmersTableGrid;
        private Button btnFarmersClose;
        private Button btnFarmersMaximize;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}