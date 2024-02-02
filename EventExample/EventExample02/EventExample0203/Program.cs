/*
 * �¼���ӵ�������¼���Ӧ�ߵ�һ���ֶγ�Ա���¼���Ӧ�����Լ��ķ����������Լ��ֶγ�Ա��ĳ���¼���
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
            this.textBox.Text = "�˷����˻���ʱ��ֱ���Ʒ��ò׺���"+DateTime.Now.ToString();
        }
    }
}
