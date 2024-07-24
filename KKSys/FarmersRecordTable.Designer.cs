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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            farmersTableGrid = new DataGridView();
            btnFarmersClose = new Button();
            btnFarmersMaximize = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
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
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            farmersTableGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            farmersTableGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.Padding = new Padding(1);
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            farmersTableGrid.DefaultCellStyle = dataGridViewCellStyle4;
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
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDelete.Image = Properties.Resources.icons8_delete_30;
            btnDelete.ImageAlign = ContentAlignment.MiddleLeft;
            btnDelete.Location = new Point(60, 816);
            btnDelete.Name = "btnDelete";
            btnDelete.Padding = new Padding(10, 0, 0, 0);
            btnDelete.Size = new Size(134, 53);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnUpdate.Image = Properties.Resources.icons8_update_30;
            btnUpdate.ImageAlign = ContentAlignment.MiddleLeft;
            btnUpdate.Location = new Point(219, 816);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Padding = new Padding(10, 0, 0, 0);
            btnUpdate.Size = new Size(151, 53);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAdd.Image = Properties.Resources.icons8_plus_301;
            btnAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdd.Location = new Point(396, 816);
            btnAdd.Name = "btnAdd";
            btnAdd.Padding = new Padding(10, 0, 0, 0);
            btnAdd.Size = new Size(151, 53);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // FarmersRecordTable
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1440, 874);
            Controls.Add(btnAdd);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
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
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
    }
}