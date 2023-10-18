using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppleShop
{
    public partial class AdminUserControl : UserControl
    {
        public AdminUserControl()
        {
            InitializeComponent();
            AdminDataUserControl userControl = new AdminDataUserControl();
            AddUserControl(userControl);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void AddUserControl(UserControl userControl)
        {
            MenuPanel.Controls.Clear();
            MenuPanel.Controls.Add(userControl);
        }
        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            AdminCreateUserControl userControl = new AdminCreateUserControl();
            AddUserControl(userControl);
        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            AdminEditUserControl userControl = new AdminEditUserControl();
            AddUserControl(userControl);
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            AdminRemoveUserControl userControl = new AdminRemoveUserControl();
            AddUserControl(userControl);
        }
    }
}
