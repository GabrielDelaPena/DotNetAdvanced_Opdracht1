namespace Oefening6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double belasting = 0.07;
            double shipping = 0.0;

            double price1 = Double.Parse(textBox5.Text);
            double price2 = Double.Parse(textBox6.Text);
            double price3 = Double.Parse(textBox7.Text);
            double price4 = Double.Parse(textBox8.Text);

            int qty1 = Int32.Parse(textBox9.Text);
            int qty2 = Int32.Parse(textBox10.Text);
            int qty3 = Int32.Parse(textBox11.Text);
            int qty4 = Int32.Parse(textBox12.Text);

            double total1 = price1 * qty1;
            double total2 = price2 * qty2;
            double total3 = price3 * qty3;
            double total4 = price4 * qty4;


            double subTotal = total1 + total2 + total3 + total4;
            double salesTax = subTotal * belasting;

            if (subTotal < 20)
            {
                shipping = 5.00;
            }
            else if (subTotal >= 20 && subTotal < 50)
            {
                shipping = 7.5;
            }
            else if (subTotal >= 50 && subTotal < 75)
            {
                shipping = 10.00;
            }
            else if (subTotal >= 75)
            {
                shipping = 0;
            }

            double grandTotal = subTotal + shipping + salesTax;

            textBox13.Text = "€ " + String.Format("{0:0.00}", total1);
            textBox14.Text = "€ " + String.Format("{0:0.00}", total2);
            textBox15.Text = "€ " + String.Format("{0:0.00}", total3);
            textBox16.Text = "€ " + String.Format("{0:0.00}", total4);

            textBox17.Text = "€ " + String.Format("{0:0.00}", subTotal);

            textBox18.Text = "€ " + String.Format("{0:0.00}", salesTax);

            textBox19.Text = "€ " + String.Format("{0:0.00}", shipping);

            textBox20.Text = "€ " + String.Format("{0:0.00}", grandTotal);

        }
    }
}