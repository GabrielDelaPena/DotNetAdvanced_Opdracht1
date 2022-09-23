namespace Oefening4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double taxRate = 0.10;
            double shipping = 5.00;

            int qty1 = Convert.ToInt32(numericUpDown1.Value);
            int qty2 = Convert.ToInt32(numericUpDown2.Value);
            int qty3 = Convert.ToInt32(numericUpDown3.Value);
            int qty4 = Convert.ToInt32(numericUpDown4.Value);

            double price1 = Double.Parse(textBox5.Text);
            double price2 = Double.Parse(textBox6.Text);
            double price3 = Double.Parse(textBox7.Text);
            double price4 = Double.Parse(textBox8.Text);

            double total1 = qty1 * price1;
            double total2 = qty2 * price2;
            double total3 = qty3 * price3;
            double total4 = qty4 * price4;

            textBox9.Text = "€ " + String.Format("{0:0.00}", total1);
            textBox10.Text = "€ " + String.Format("{0:0.00}", total2);
            textBox11.Text = "€ " + String.Format("{0:0.00}", total3);
            textBox12.Text = "€ " + String.Format("{0:0.00}", total4);

            double subTotal = total1 + total2 + total3 + total4;
            double salesTax = subTotal * taxRate;
            double grandTotal = subTotal + shipping + salesTax;

            textBox13.Text = "€ " + String.Format("{0:0.00}", subTotal);
            textBox14.Text = taxRate.ToString();
            textBox15.Text = "€ " + String.Format("{0:0.00}", salesTax); 
            textBox17.Text = "€ " + String.Format("{0:0.00}", shipping); 
            textBox16.Text = "€ " + String.Format("{0:0.00}", grandTotal); 


        }
    }
}