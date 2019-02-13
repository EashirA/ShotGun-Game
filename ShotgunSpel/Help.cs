using System;
using System.Windows.Forms;

namespace ShotgunSpel
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
