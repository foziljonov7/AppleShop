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
    public partial class AdminCreateUserControl : UserControl
    {
        SqlConnection connection = new SqlConnection();
        SqlCommand command = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable dt = new DataTable();
        public AdminCreateUserControl()
        {
            InitializeComponent();
        }

        private void MenuPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void TxtClear()
        {
            FullnameTxt.Clear();
            AgeTxt.Clear();
            RoleCombo.Items.Clear();
            PhoneTxt.Clear();
            regiontxt.Clear();
        }
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            TxtClear();
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            if (FullnameTxt.Text == ""
                || AgeTxt.Text == ""
                || PhoneTxt.Text == ""
                || regiontxt.Text == ""
                || RoleCombo.Text == "")
                MessageBox.Show("Hech qanday malumot kiritmasangiz bu funksiyadan foydalana olmaysiz!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                connection.Open();
                string createQuery = $"INSERT INTO [Admins](Fullname, Age, Role, Phone, Region) VALUES ('{FullnameTxt.Text}', '{AgeTxt.Text}', '{RoleCombo.SelectedItem}', '{PhoneTxt.Text}', '{regiontxt.Text}')";
                command = new SqlCommand(createQuery, connection);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Successfully saved!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtClear();
            }
        }
        public void LoadData()
        {
            string readQuery = "SELECT * FROM [Admins]";
            adapter = new SqlDataAdapter(readQuery, connection);
            dt = new DataTable();
            adapter.Fill(dt);
        }

        private void AdminCreateUserControl_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Api projects\AppleShop\AppleShop\AppleShopData.mdf"";Integrated Security=True");
            LoadData();
        }
    }
}
