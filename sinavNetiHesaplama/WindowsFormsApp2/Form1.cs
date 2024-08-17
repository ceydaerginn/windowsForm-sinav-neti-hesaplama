using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tDogru = Convert.ToInt16(textBox1.Text);
            int tYanlis = Convert.ToInt16(textBox3.Text);
            int mDogru = Convert.ToInt16(textBox2.Text);
            int mYanlis = Convert.ToInt16(textBox5.Text);
            textBox4.Text = Convert.ToString(tDogru - (tYanlis / 4));
            textBox6.Text = Convert.ToString(mDogru - (mYanlis / 4));
        }
    }
}
