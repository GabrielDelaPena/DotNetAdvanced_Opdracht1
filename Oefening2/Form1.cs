namespace Oefening2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            int answer1 = Int32.Parse(label1.Text) * Int32.Parse(label3.Text);
            int answer2 = Int32.Parse(label10.Text) * Int32.Parse(label8.Text);

            label5.Text = answer1.ToString();
            label6.Text = answer2.ToString();

            if (answer1 > answer2)
            {
                label19.Text = "True";
            } else
            {
                label19.Text = "False";
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}