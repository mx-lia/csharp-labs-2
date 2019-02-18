using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR_1_
{
    public partial class Form2 : Form
    {
        public Form2(Form1 form1)
        {
            InitializeComponent();
            this.Text = form1.Title;
            label1.Text = form1.TextInfo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
