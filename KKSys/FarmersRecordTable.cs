using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            

        }

        private void btnFarmersMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized) {
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
    }
}
