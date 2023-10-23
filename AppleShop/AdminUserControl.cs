using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppleShop
{
    public partial class AdminUserControl : UserControl
    {
        SqlConnection connection = new SqlConnection();
        SqlCommand command = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable dt = new DataTable();
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

        private void AdminUserControl_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Api projects\AppleShop\AppleShop\AppleShopData.mdf"";Integrated Security=True");
        }
    }
}
