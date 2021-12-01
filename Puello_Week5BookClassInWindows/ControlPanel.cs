using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Puello_Week5BookClassInWindows
{
    public partial class ControlPanel : Form
    {
        public ControlPanel()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form1 temp = new Form1();
            temp.Show();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchManager temp = new SearchManager();
            temp.Show();
        }
    }
}
