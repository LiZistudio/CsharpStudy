namespace ClassAndInstance
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        { 
            Form form1 = new Form();        //new一个form的实例
            form1.Text = "My TuDoList";     //设置title       
            Form form2 = form1;
            form2.Text = "TudoList";
            form2.HelpButton = true;
            form2.MaximizeBox = false;
            form2.MinimizeBox = false;
            form1.ShowDialog();             //显示form1



            CreateMyForm();
        }
        
        
        public static void CreateMyForm()
        {
            // Create a new instance of the form.
            Form form1 = new Form();
            // Create two buttons to use as the accept and cancel buttons.
            Button button1 = new Button();
            Button button2 = new Button();

            // Set the text of button1 to "OK".
            button1.Text = "OK";
            // Set the position of the button on the form.
            button1.Location = new Point(10, 10);
            // Set the text of button2 to "Cancel".
            button2.Text = "Cancel";
            // Set the position of the button based on the location of button1.
            button2.Location
               = new Point(button1.Left, button1.Height + button1.Top + 10);
            // Set the caption bar text of the form.   
            form1.Text = "My Dialog Box";
            // Display a help button on the form.
            form1.HelpButton = true;

            // Define the border style of the form to a dialog box.
            form1.FormBorderStyle = FormBorderStyle.FixedDialog;
            // Set the MaximizeBox to false to remove the maximize box.
            form1.MaximizeBox = false;
            // Set the MinimizeBox to false to remove the minimize box.
            form1.MinimizeBox = false;
            // Set the accept button of the form to button1.
            form1.AcceptButton = button1;
            // Set the cancel button of the form to button2.
            form1.CancelButton = button2;
            // Set the start position of the form to the center of the screen.
            form1.StartPosition = FormStartPosition.CenterScreen;

            // Add button1 to the form.
            form1.Controls.Add(button1);
            // Add button2 to the form.
            form1.Controls.Add(button2);

            // Display the form as a modal dialog box.
            form1.ShowDialog();
        }
    }
}