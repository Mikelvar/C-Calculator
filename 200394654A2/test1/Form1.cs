using System;
using System.Windows.Forms;

namespace test1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Double num = 0;
        String oper = "";
        Boolean Clearclick = false;
        private void button_finder(object sender, EventArgs e)
        {
            
            if (result.Text == "0" || Clearclick)


                result.Clear();
            Clearclick = false;
            Button x = (Button)sender;
            result.Text = result.Text + x.Text;

        }
        //back 
        private void button21_Click(object sender, EventArgs e)
        {
            result.Text = result.Text.Remove(result.Text.Length - 1);
        }


        //Clear 
        private void button20_Click(object sender, EventArgs e)
        {
            result.Clear();
            num = 0;
        }
        // this will alow us are operators
        private void math_mthode(object sender, EventArgs e)
        {
            
            
            Button x = (Button)sender;
            oper = x.Text;
            num = Double.Parse(result.Text);
            Clearclick = true;
            YourCal.Text = num + " " + oper;
           
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (result.Text == "NaN")

                _ = result.Text == "you can not do that";
            YourCal.Text = "";

            switch (oper)
            {
                case "+":
                    result.Text = (num + Double.Parse(result.Text)).ToString();
                    break;
                case "-":
                    result.Text = (num - Double.Parse(result.Text)).ToString();
                    break;
                case "+/-":
                    result.Text = (num - Double.Parse(result.Text)).ToString();
                    break;
                case "*":
                    result.Text = (num * Double.Parse(result.Text)).ToString();
                    break;
                case "/":
                    result.Text = (num / Double.Parse(result.Text)).ToString();
                    break;
                   
                default:
                    break;

            }
        }

        private void button19_Click_1(object sender, EventArgs e)
        {

            double sqrtOf = Double.Parse(result.Text);
            YourCal.Text = System.Convert.ToString(result.Text);
            sqrtOf = Math.Sqrt(sqrtOf);
            result.Text = System.Convert.ToString(sqrtOf);
        }
    }
}
