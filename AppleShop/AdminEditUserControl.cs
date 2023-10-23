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
    public partial class AdminEditUserControl : UserControl
    {
        SqlConnection connection = new SqlConnection();
        SqlCommand command = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();  
        DataTable dt = new DataTable();
        public AdminEditUserControl()
        {
            InitializeComponent();
        }
        private void TxtClear()
        {
            IdTxt.Clear();
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
        public void LoadData()
        {
            string readQuery = "SELECT * FROM [Admins]";
            adapter = new SqlDataAdapter(readQuery, connection);
            dt = new DataTable();
            adapter.Fill(dt);
        }
        private void AdminEditUserControl_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Api projects\AppleShop\AppleShop\AppleShopData.mdf"";Integrated Security=True");
            LoadData();
        }
        private void Updated()
        {
            try
            {
                connection.Open();
                string UpdateQuery = "UPDATE[Admins] set Fullname=@Fullname, Age=@Age, Role=@Role, Phone=@Phone, Region=@Region WHERE Id=@Id";
                command = new SqlCommand(UpdateQuery, connection);
                command.Parameters.AddWithValue("@Id", IdTxt.Text);
                command.Parameters.AddWithValue("@Fullname", FullnameTxt.Text);
                command.Parameters.AddWithValue("@Age", AgeTxt.Text);
                command.Parameters.AddWithValue("@Role", RoleCombo.SelectedItem);
                command.Parameters.AddWithValue("@Phone", PhoneTxt.Text);
                command.Parameters.AddWithValue("@Region", regiontxt.Text);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show($"Succesfully Edited Id : {IdTxt.Text}!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtClear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Invalid Operation {IdTxt.Text} {ex}");
                IdTxt.ForeColor = Color.Red;
            }
        }
        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            if(IdTxt.Text == "")
            {
                MessageBox.Show("Id bosh bolsa o'zgartira olmaysiz!");
                IdTxt.Focus();
                IdTxt.ForeColor = Color.Red;
            }
            else
            {
                Updated();
            }
        }
    }
}
