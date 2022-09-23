namespace Oefening7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number = Int32.Parse(textBox1.Text);
            int[] numbers = new int[number];
            int sumTotal = 0;

            // Save all numbers between 1 - number to the array.
            for (int i = 0; i < number; i++)
            {
                numbers[i] = i + 1;
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                sumTotal = sumTotal + numbers[i];
            }

            textBox2.Text = sumTotal.ToString();
        }
    }
}