using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XmlForm
{
    public partial class Search : Form
    {
        private string value1;
        public string val
        {
            get { return value1; }
            set { value1 = value; }
        }
        public Search()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            val = textBoxVal.Text;
        }
    }
}
