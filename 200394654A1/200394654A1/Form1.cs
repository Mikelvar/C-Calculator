using System;
using System.Windows.Forms;

namespace _200394654A1
{
    public partial class Form1 : Form
    {
         


        public Form1()
        {
            InitializeComponent();
        }
       
        ///theas methodes alow the user to clear and calculate the change due 
        ///********************************************************************
        ///clear info
        private void Clear_button_Click(object sender, EventArgs e)
        {
            ///this alows us to clear all the info from are previose calculation
            
            ///this will clear the Quarters textbox
            this.Quarters.Text = string.Empty;

            ///this will clear the Dimes textbox
            this.Dimes.Text = string.Empty;

            ///this will clear the Loonies textbox
            this.Loonies.Text = string.Empty;

            ///this will clear the Toonies textbox
            this.Toonies.Text = string.Empty;

            ///this will clear the Nickels textbox
            this.Nickels.Text = string.Empty;

            ///this will clear the Paide textbox
            this.Paide.Text = string.Empty;

            ///this will clear the Total textbox
            this.Total.Text = string.Empty;

            ///this will clear the Change textbox
            this.Change.Text = string.Empty;

        }
        /// Calculate Change due
        private void Calculate_Click(object sender, EventArgs e)
        {
            ///this calculate the amount of coings needed to make the change

            ///this calculates the change for the amount of coings needed 
            double change;
            change = Double.Parse(Paide.Text) - Double.Parse(Total.Text);

            ///this calculate the amount of toonies needed
            double toonies = change / 2;
            change %= 2;

            ///this calculate the amount of loonies needed
            double loonies = change / 1;
            change %= 1;

            ///this calculate the amount of quarters needed
            double quarters = change / 0.25;
            change %= 0.25;

            ///this calculate the amount of dimes needed
            double dimes = change / 0.10;
            change %= 0.10;

            ///this calculate the amount of nickels needed
            double nickels = change / 0.05;

            ///checks if the text box is empty 
            if (String.IsNullOrEmpty(Paide.Text) || String.IsNullOrEmpty(Total.Text))
            {///this will dispaly hte message if necessary
                MessageBox.Show("you must fill in the info");
            }
            else
            {   ///Calculate Change due                
                Change.Text = (Double.Parse(Paide.Text) - Double.Parse(Total.Text)).ToString();
                this.Change.Text = this.Change.Text.Insert(0, "$");
                
                ///prints out the correct number of coins to give the user
               
                ///this prinst the amount of toonies
                Toonies.Text += + Math.Floor(toonies);
                
                ///this prinst the amount of toonies
                Loonies.Text += + Math.Floor(loonies);
                
                ///this prinst the amount of toonies
                Quarters.Text += + Math.Floor(quarters);
               
                ///this prinst the amount of toonies
                Dimes.Text +=  + Math.Floor(dimes);
               
                ///this prinst the amount of toonies
                Nickels.Text += + Math.Round(nickels);
                
                ///this checks if the amout paide was sufficient
                if (Double.Parse(Paide.Text) - Double.Parse(Total.Text) < 0)
                {///this will dispaly hte message if necessary
                    MessageBox.Show("Please give the total that is due!!!!!");
                }

               
            }



          

        }
        ///this is theere the user enter the total
        private void Total_TextChanged(object sender, EventArgs e)
        {
            ///checks if the user input a value other then a number 
            if (System.Text.RegularExpressions.Regex.IsMatch(Total.Text, "[^0.-9]"))
                {///this will dispaly hte message if necessary
                MessageBox.Show("you can only enter numbers.");
                Total.Text = Total.Text.Remove(Total.Text.Length - 1);
                }

          

        }
         ///this is where the user enters the amout that is paide 
        private void Paide_TextChanged(object sender, EventArgs e)
        {///checks if the user input a value other then a number 
            if (System.Text.RegularExpressions.Regex.IsMatch(Paide.Text, "[^0.-9]"))
            {///this will dispaly hte message if necessary
                MessageBox.Show("you can only enter numbers.");
                Paide.Text = Paide.Text.Remove(Paide.Text.Length - 1);
            }

           
        }
        
        private void Toonies_TextChanged(object sender, EventArgs e)
        {
           
           


        }
        private void Loonies_TextChanged(object sender, EventArgs e)
        {
            

        }
        private void Quarters_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void Dimes_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Nickels_TextChanged(object sender, EventArgs e)
        {
           
        }




        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Change_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
