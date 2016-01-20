///made by Maya Stuart
///January 22
/// Tiny Town Pet Store
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tiny_Town
{
    public partial class petShop : Form
    {

        //create arrays for prices and items 
        double[] prices = { 25.00, 40.00, 200.00, 5.00, 20.00, 3.00, 15.00, 25.00, 30.00 };
        int[] basket = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        //create global constants
        double HST = 0.13;

        //create global variables
        double subtotal;
        double taxAmount;
        double totalCost;
        double amountGiven;
        double change;

        public petShop()
        {
            InitializeComponent();
           

        }


        public void basketValues()
        {
            //Clear basket after each change to update
            basketLabel.Text = "";

            if (basket[0] > 0)
            {   
                basketLabel.Text += "No. Bunnies: " + Convert.ToString(basket[0]) + "      @ $25.00";
            }

            if (basket[1] > 0)
            {
                basketLabel.Text += "\nNo. Kittens: " + Convert.ToString(basket[1]) + "      @ $40.00";
            }

            if (basket[2] > 0)
            {
                basketLabel.Text += "\nNo. Puppies: " + Convert.ToString(basket[2]) + "      @ $200.00";
            }

            if (basket[3] > 0)
            {
                basketLabel.Text += "\nNo. Carrots: " + Convert.ToString(basket[3]) + "      @ $5.00";
            }

            if (basket[4] > 0)
            {
                basketLabel.Text += "\nNo. Pet Food: " + Convert.ToString(basket[4]) + "     @ $20.00";
            }

            if (basket[5] > 0)
            {
                basketLabel.Text += "\nNo. Dog Treats: " + Convert.ToString(basket[5]) + "   @ $3.00";
            }

            if (basket[6] > 0)
            {
                basketLabel.Text += "\nNo. Pet Brushs: " + Convert.ToString(basket[6]) + "   @ $15.00";
            }

            if (basket[7] > 0)
            {
                basketLabel.Text += "\nNo. Pet Leashs: " + Convert.ToString(basket[7]) + "   @ $25.00";
            }

            if (basket[8] > 0)
            {
                basketLabel.Text += "\nNo. Pet Beds: " + Convert.ToString(basket[8]) + "     @ $30.00";
            }

            subtotal = (basket[0] * prices[0] + basket[1] * prices[1] + basket[2] * prices[2] + basket[3] * prices[3] + basket[4] * prices[4] + basket[5] * prices[5] + basket[6] * prices[6] + basket[7] * prices[7] + basket[8] * prices[8]) * (1 + HST);
            totalsLabel.Text = "Total: " + subtotal.ToString("C");
        }

        private void bunnyNumeric_ValueChanged(object sender, EventArgs e)
        {
            basket[0] = Convert.ToInt16(bunnyNumeric.Value);
            basketValues();
        }

        private void catNumeric_ValueChanged(object sender, EventArgs e)
        {
            basket[1] = Convert.ToInt16(catNumeric.Value);
            basketValues();
        }

        private void dogNumeric_ValueChanged(object sender, EventArgs e)
        {
            basket[2] = Convert.ToInt16(dogNumeric.Value);
            basketValues();
        }

        private void carrotNumeric_ValueChanged(object sender, EventArgs e)
        {
            basket[3] = Convert.ToInt16(carrotNumeric.Value);
            basketValues();
        }

        private void petFoodNumeric_ValueChanged(object sender, EventArgs e)
        {
            basket[4] = Convert.ToInt16(petFoodNumeric.Value);
            basketValues();
        }

        private void dogTreatsNumeric_ValueChanged(object sender, EventArgs e)
        {
            basket[5] = Convert.ToInt16(dogTreatsNumeric.Value);
            basketValues();
        }

        private void petBrushNumeric_ValueChanged(object sender, EventArgs e)
        {
            basket[6] = Convert.ToInt16(petBrushNumeric.Value);
            basketValues();
        }

        private void petLeashNumeric_ValueChanged(object sender, EventArgs e)
        {
            basket[7] = Convert.ToInt16(petLeashNumeric.Value);
            basketValues();
        }

        private void petBedNumeric_ValueChanged(object sender, EventArgs e)
        {
            basket[8] = Convert.ToInt16(petBedNumeric.Value);
            basketValues();
        }

        private void completeOrderButton_Click(object sender, EventArgs e)
        {
            completeOrderButton.Visible = false;
            amountGivenInput.Visible = true;
            recieptButton.Visible = true;
            inputMoneyLabel.Visible = true;
        }

        private void recieptButton_Click(object sender, EventArgs e)
        {

            amountGiven = Convert.ToDouble(amountGivenInput.Text);

            if (amountGiven > totalCost)
            {
                recieptLabel.Visible = true;
                shopAgainButton.Visible = true;
                inputMoneyLabel.Visible = false;
                amountGivenInput.Visible = false;
                recieptButton.Visible = false;

                recieptLabel.Text += "Tiny Paws Pet Shop";

                if (basket[0] > 0)
                {
                    recieptLabel.Text += "\n\n\nNo. Bunnies: " + Convert.ToString(basket[0]) + "          @ $25.00";
                }

                if (basket[1] > 0)
                {
                    recieptLabel.Text += "\n\nNo. Kittens: " + Convert.ToString(basket[1]) + "          @ $40.00";
                }

                if (basket[2] > 0)
                {
                    recieptLabel.Text += "\n\nNo. Puppies: " + Convert.ToString(basket[2]) + "          @ $200.00";
                }

                if (basket[3] > 0)
                {
                    recieptLabel.Text += "\n\nNo. Carrots: " + Convert.ToString(basket[3]) + "          @ $5.00";
                }

                if (basket[4] > 0)
                {
                    recieptLabel.Text += "\n\nNo. Pet Food: " + Convert.ToString(basket[4]) + "         @ $20.00";
                }

                if (basket[5] > 0)
                {
                    recieptLabel.Text += "\n\nNo. Dog Treats: " + Convert.ToString(basket[5]) + "       @ $3.00";
                }

                if (basket[6] > 0)
                {
                    recieptLabel.Text += "\n\nNo. Pet Brushs: " + Convert.ToString(basket[6]) + "       @ $15.00";
                }

                if (basket[7] > 0)
                {
                    recieptLabel.Text += "\n\nNo. Pet Leashs: " + Convert.ToString(basket[7]) + "       @ $25.00";
                }

                if (basket[8] > 0)
                {
                    recieptLabel.Text += "\n\nNo. Pet Beds: " + Convert.ToString(basket[8]) + "         @ $30.00";
                }

                taxAmount = subtotal * HST;
                totalCost = subtotal;

                change = amountGiven - totalCost;

                recieptLabel.Text += "\n\n\nSubtotal        " + (subtotal / (1 + HST)).ToString("C");
                recieptLabel.Text += "\n\nTax Amount      " + taxAmount.ToString("C");
                recieptLabel.Text += "\n\nTotal Cost      " + totalCost.ToString("C");
                recieptLabel.Text += "\n\nAmount Given    " + amountGiven.ToString("C");
                recieptLabel.Text += "\n\nChange          " + change.ToString("C");
            }
            else
            {
                inputMoneyLabel.Text = "Please give more money.";
                inputMoneyLabel.ForeColor = Color.Red;
            }
        }

        private void shopAgainButton_Click(object sender, EventArgs e)
        {
            recieptLabel.Visible = false;
            shopAgainButton.Visible = false;

            completeOrderButton.Visible = true;
               
            basketLabel.Text = "";
            totalsLabel.Text = "";

            subtotal = 0;
            taxAmount = 0;
            totalCost = 0;
            amountGiven = 0;
            change = 0;

            bunnyNumeric.Value = 0;
            catNumeric.Value = 0;
            dogNumeric.Value = 0;
            carrotNumeric.Value = 0;
            petFoodNumeric.Value = 0;
            dogTreatsNumeric.Value = 0;
            petLeashNumeric.Value = 0;
            petBrushNumeric.Value = 0;
            petBedNumeric.Value = 0;

            for (int i = 0; i < basket.Length; i++)
            {
                basket[i] = 0;
            }
        }

    
    }
    }

   

    
   


    
    


