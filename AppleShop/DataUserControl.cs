using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Xml;

namespace AppleShop
{
    public partial class DataUserControl : UserControl
    {
        SqlConnection connection = new SqlConnection();
        SqlCommand command = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable dt = new DataTable();
        public DataUserControl()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            string readQuery = "SELECT * FROM [Product]";
            adapter = new SqlDataAdapter(readQuery, connection);
            dt = new DataTable();
            adapter.Fill(dt);
            ProductDataGridView.DataSource = dt;
        }
        private void DataUserControl_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Api projects\AppleShop\AppleShop\AppleShopData.mdf"";Integrated Security=True");
            LoadData();
        }

        private void TopPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string searchQuery = $"SELECT * FROM [Product] WHERE Category LIKE '%{CategoryCombo4.SelectedItem}%'";
            adapter = new SqlDataAdapter(searchQuery, connection);
            dt = new DataTable();
            adapter.Fill(dt);
            ProductDataGridView.DataSource = dt;
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            string searchQuery2 = $"SELECT * FROM [Product] WHERE Name LIKE '%{SearchTxt.Text}%'";
            adapter = new SqlDataAdapter(searchQuery2, connection);
            dt = new DataTable();
            adapter.Fill(dt);
            ProductDataGridView.DataSource = dt;
        }
    }
}
