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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AppleShop
{
    public partial class UpdateUserControl : UserControl
    {
        SqlConnection connection = new SqlConnection();
        SqlCommand command = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable dt = new DataTable();
        public UpdateUserControl()
        {
            InitializeComponent();
        }
        private void TxtClear()
        {
            IdTxt.Clear();
            NameTxt.Clear();
            PriceTxt.Clear();
            MadeTxt.Clear();
            SizeTxt.Clear();
        }
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            TxtClear();
        }
        private void Updated()
        {
            try
            {
                connection.Open();
                string UpdateQuery = "UPDATE[Product] set Name=@Name, Price=@Price, Made=@Made, Size=@Size, Date=@Date, Category=@Category WHERE Id=@Id";
                command = new SqlCommand(UpdateQuery, connection);
                command.Parameters.AddWithValue("@Id", IdTxt.Text);
                command.Parameters.AddWithValue("@Name", NameTxt.Text);
                command.Parameters.AddWithValue("@Price", PriceTxt.Text);
                command.Parameters.AddWithValue("@Made", MadeTxt.Text);
                command.Parameters.AddWithValue("@Size", SizeTxt.Text);
                command.Parameters.AddWithValue("@Date", DateTime.UtcNow);
                command.Parameters.AddWithValue("@Category", CategoryCombo.SelectedItem);
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
            Updated();
        }
        public void LoadData()
        {
            string readQuery = "SELECT * FROM [Product]";
            adapter = new SqlDataAdapter(readQuery, connection);
            dt = new DataTable();
            adapter.Fill(dt);
        }
        private void UpdateUserControl_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Api projects\AppleShop\AppleShop\AppleShopData.mdf"";Integrated Security=True");
            LoadData();
        }
    }
}
