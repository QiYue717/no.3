using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public static int NewPwd = 123456;
        private void button2_Click(object sender, EventArgs e)
        {
            NewPwd = Convert.ToInt32(this.textBox2.Text);
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
