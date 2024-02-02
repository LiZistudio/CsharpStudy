using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            if (sender ==Button)
            {
            this.textBox1.Text = "乘风破浪会有时，直挂云帆济沧海。";
            }else if (sender == button1)
            {
                this.textBox1.Text = DateTime.Now.ToString();
            }
            else
            {
                this.textBox1.Text = null;
            }
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    this.textBox1.Text = DateTime.Now.ToString();
        //}

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    this.textBox1.Text = null;
        //}
    }
}


/*一个事件可以挂接多个事件处理器；一个事件处理器可以被多个事件所挂接*/