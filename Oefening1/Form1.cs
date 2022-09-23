namespace Oefening1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello " + Environment.UserName + ". Het is " + DateTime.Now.ToShortTimeString() + " op " + DateTime.Now.ToShortDateString() + ".");
        }
    }
}