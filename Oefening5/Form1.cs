namespace Oefening5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int celcius = int.Parse(textBox1.Text);

            double fahrenheit = (double)celcius * 9 / 5 + 32;

            textBox2.Text = String.Format("{0:0.00}", fahrenheit);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int fahrenheit = Int32.Parse(textBox2.Text);

            double celcius = ((double)fahrenheit - 32) * 5 / 9;

            textBox1.Text = String.Format("{0:0.00}", celcius);
        }
    }
}