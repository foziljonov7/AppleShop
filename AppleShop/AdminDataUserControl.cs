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
using TheArtOfDevHtmlRenderer.Adapters;

namespace AppleShop
{
    public partial class AdminDataUserControl : UserControl
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        SqlDataAdapter adp = new SqlDataAdapter();
        DataTable dt = new DataTable();
        public AdminDataUserControl()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            string readQuery = "SELECT * FROM [Admins]";
            adp = new SqlDataAdapter(readQuery, con);
            dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void AdminDataUserControl_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Api projects\AppleShop\AppleShop\AppleShopData.mdf"";Integrated Security=True");
            LoadData();
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
