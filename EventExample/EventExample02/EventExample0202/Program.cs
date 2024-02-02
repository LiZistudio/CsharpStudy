
/*
 * 同一个对象既是事件的拥有者也是事件的订阅者
 */

using System.Windows.Forms;

namespace EventExample0202
{
    class Program
    {
        static void Main(string[] args)
        {
            MyForm form = new MyForm();
            form.Click += form.FormClicked;

            form.ShowDialog();
        }
    }

    class MyForm:Form       //继承
    {
        internal void FormClicked(object sender, EventArgs e)
        {
            this.Text = DateTime.Now.ToString();
        }
    }
}