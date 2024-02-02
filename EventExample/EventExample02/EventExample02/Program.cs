/*
 * 事件的拥有者和事件的订阅者是不同的对象
 */
using System.Windows.Forms;

namespace EventExample02
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Form form = new Form();
            Controller controller = new Controller(form);

            form.ShowDialog();
        }                                 
    }

    class Controller                
    {
        private Form form;
        public Controller(Form form)
        {
            if (form != null)
            {
                this.form = form;
                this.form.Click += this.FormClicked;
            }
            
        }
        private void FormClicked(object? sender, EventArgs e)
        {
            this.form.Text = DateTime.Now.ToString();
        }
    }
}
