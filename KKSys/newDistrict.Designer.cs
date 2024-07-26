namespace KKSys
{
    partial class newDistrict
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
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(551, 58);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Control;
            button1.Image = Properties.Resources.icons8_close_30;
            button1.Location = new Point(462, 13);
            button1.Name = "button1";
            button1.Size = new Size(75, 35);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Image = Properties.Resources.icons8_add_30;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(29, 279);
            button2.Name = "button2";
            button2.Size = new Size(124, 46);
            button2.TabIndex = 2;
            button2.Text = "Add";
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(165, 106);
            label1.Name = "label1";
            label1.Size = new Size(234, 25);
            label1.TabIndex = 3;
            label1.Text = "NEW DISTRICT RECORDS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(99, 201);
            label2.Name = "label2";
            label2.Size = new Size(59, 21);
            label2.TabIndex = 4;
            label2.Text = "District";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(203, 203);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(196, 21);
            textBox1.TabIndex = 5;
            // 
            // newDistrict
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(575, 337);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "newDistrict";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "newDistrict";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
    }
}