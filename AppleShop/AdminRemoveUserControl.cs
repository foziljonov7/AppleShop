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
    public partial class AdminRemoveUserControl : UserControl
    {
        SqlConnection connection = new SqlConnection();
        SqlCommand command = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable dt = new DataTable();
        public AdminRemoveUserControl()
        {
            InitializeComponent();
        }
        private void Deleted()
        {
            try
            {
                connection.Open();
                string deleteQuery = "DELETE [Admins] WHERE Id=@Id";
                command = new SqlCommand(deleteQuery, connection);
                command.Parameters.AddWithValue("@Id", int.Parse(IdTxt.Text));
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show($"Succesfully deleted Id: {IdTxt.Text}!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                IdTxt.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Invalid operation : {IdTxt.Text} {ex}");
                IdTxt.Focus();
                IdTxt.ForeColor = Color.Red;
            }
        }
        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            IdTxt.Clear();
        }
        public void LoadData()
        {
            string readQuery = "SELECT * FROM [Admins]";
            adapter = new SqlDataAdapter(readQuery, connection);
            dt = new DataTable();
            adapter.Fill(dt);
        }
        private void AdminRemoveUserControl_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Api projects\AppleShop\AppleShop\AppleShopData.mdf"";Integrated Security=True");
            LoadData();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            Deleted();
        }
    }
}
