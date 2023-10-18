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
    public partial class UpdateUserControl : UserControl
    {
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
            CategoryTxt.Clear();
        }
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            TxtClear();
        }
    }
}
