
/*
 * ͬһ����������¼���ӵ����Ҳ���¼��Ķ�����
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

    class MyForm:Form       //�̳�
    {
        internal void FormClicked(object sender, EventArgs e)
        {
            this.Text = DateTime.Now.ToString();
        }
    }
}