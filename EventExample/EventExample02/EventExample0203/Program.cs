/*
 * 事件的拥有者是事件响应者的一个字段成员，事件响应者用自己的方法订阅着自己字段成员的某个事件。
 */

using System.Windows.Forms;

namespace EventExample0203
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            MyForm form = new MyForm();



            form.ShowDialog();
        }
    }

    class MyForm : Form
    {
        private TextBox textBox;
        private Button button;

        public MyForm()
        {
            this.textBox = new TextBox();

            this.button = new Button();
            this.button.Text = "CLICK ME";
            this.button.Top = 100;
            
            this.Controls.Add(button);
            this.Controls.Add(textBox);
            this.button.Click += this.Button_Click;
        }

        private void Button_Click(object? sender, EventArgs e)
        {
            this.textBox.Text = "乘风破浪会有时，直挂云帆济沧海。"+DateTime.Now.ToString();
        }
    }
}
