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
    public partial class RemoveForm : Form
    {
        SqlConnection connection = new SqlConnection();
        SqlCommand command = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public RemoveForm()
        {
            InitializeComponent();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            DashboardWindow form = new DashboardWindow();
            this.Hide();
            form.Visible = true;
        }
        public void LoadData()
        {
            string readQuery = "SELECT * FROM [Product]";
            adapter = new SqlDataAdapter(readQuery, connection);
            table = new DataTable();
            adapter.Fill(table);
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            Deleted();
        }
        private void Deleted()
        {
            try
            {
                connection.Open();
                string deleteQuery = "DELETE [Product] WHERE Id=@Id";
                command = new SqlCommand(deleteQuery, connection);
                command.Parameters.AddWithValue("@Id", int.Parse(IdTxt.Text));
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show($"Succesfully deleted Id: {IdTxt.Text}!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                IdTxt.Clear();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Invalid operation : {IdTxt.Text} {ex}");
                IdTxt.Focus();
                IdTxt.ForeColor = Color.Red;
            }
        }
        private void RemoveForm_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Api projects\AppleShop\AppleShop\AppleShopData.mdf"";Integrated Security=True");
        }
    }
}
