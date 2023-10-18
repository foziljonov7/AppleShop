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
    public partial class CreateUserControl : UserControl
    {
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
            CategoryTxt.Clear();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            TxtClear();
        }
    }
}
