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
    public partial class DashboardWindow : Form
    {
        public DashboardWindow()
        {
            InitializeComponent();
            DataUserControl userControl = new DataUserControl();
            AddUserControl(userControl);
        }
        private void AddUserControl(UserControl userControl)
        {
            MenuPanel.Controls.Clear();
            MenuPanel.Controls.Add(userControl);
        }
        private void CloseBtn_Click(object sender, EventArgs e) => Close();

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            CreateUserControl userControl = new CreateUserControl();
            AddUserControl(userControl);
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            UpdateUserControl userControl = new UpdateUserControl();
            AddUserControl(userControl);
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            RemoveForm form = new RemoveForm();
            this.Visible = false;
            form.ShowDialog();
        }

        private void AdminBtn_Click(object sender, EventArgs e)
        {
            AdminUserControl userControl = new AdminUserControl();
            AddUserControl(userControl);
        }

        private void TopRigthPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AllBrandBtn_Click(object sender, EventArgs e)
        {
            DataUserControl userControl = new DataUserControl();
            AddUserControl(userControl);
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            DataUserControl userControl = new DataUserControl();
            AddUserControl(userControl);
        }
    }
}
