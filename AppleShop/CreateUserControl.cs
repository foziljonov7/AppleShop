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
    public partial class CreateUserControl : UserControl
    {
        SqlConnection connection = new SqlConnection();
        SqlCommand command = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable dt = new DataTable();
        public CreateUserControl()
        {
            InitializeComponent();
        }
        private void TxtClear()
        {
            NameTxt.Clear();
            PriceTxt.Clear();
            MadeTxt.Clear();
            SizeTxt.Clear();
        }
        public void LoadData()
        {
            string readQuery = "SELECT * FROM [Product]";
            adapter = new SqlDataAdapter(readQuery, connection);
            dt = new DataTable();
            adapter.Fill(dt);
        }
        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            TxtClear();
        }

        private void CreateUserControl_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Api projects\AppleShop\AppleShop\AppleShopData.mdf"";Integrated Security=True");
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            if (NameTxt.Text == ""
                || PriceTxt.Text == ""
                || MadeTxt.Text == ""
                || SizeTxt.Text == "")
                MessageBox.Show("Hech qanday malumot kiritmasangiz bu funksiyadan foydalana olmaysiz!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                connection.Open();
                string createQuery = $"INSERT INTO [Product](Name, Price, Made, Size, Date, Category) VALUES ('{NameTxt.Text}', '{PriceTxt.Text}', '{MadeTxt.Text}', '{SizeTxt.Text}', '{DateTime.UtcNow}', '{CategoryCombo.SelectedItem}')";
                command = new SqlCommand(createQuery, connection);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Successfully saved!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtClear();
            }
        }
    }
}
