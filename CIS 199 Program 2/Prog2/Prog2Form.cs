// Program 2
// CIS 199-50
// Due: 3/5/2020
// Jacob Puentes
// This program calculates tax rate as for multiple people's tax plans.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog2
{
    public partial class Prog2Form : Form
    {
        public Prog2Form()
        {
            InitializeComponent();
        }

        
        private void calcTaxBtn_Click(object sender, EventArgs e)
        {
            
            const decimal BASE_RATE1 = .10m; 
            const decimal BASE_RATE2 = .12m;
            const decimal BASE_RATE3 = .22m; 
            const decimal BASE_RATE4 = .24m; 
            const decimal BASE_RATE5 = .32m; 
            const decimal BASE_RATE6 = .35m; 
            const decimal BASE_RATE7 = .37m; 

 
            const decimal C1_3_RATE1 = .10m; 
            const decimal C1_3_RATE2 = .15m; 
            const decimal C1_3_RATE3 = .25m;  
            const decimal C1_3_RATE4 = .28m;  
            const decimal C1_3_RATE5 = .33m;  
            const decimal C1_3_RATE6 = .35m;  
            const decimal C1_3_RATE7 = .396m; 

         
            const decimal C2_RATE1 = .10m;  
            const decimal C2_RATE2 = .12m;  
            const decimal C2_RATE3 = .22m;  
            const decimal C2_RATE4 = .24m;  
            const decimal C2_RATE5 = .32m;  
            const decimal C2_RATE6 = .35m;  
            const decimal C2_RATE7 = .40m;  
            const decimal C2_RATE8 = .45m;  
            const decimal C2_RATE9 = .50m; 
            const decimal C2_RATE10 = .52m; 

           
            const int BASE_THRESH1 = 9_700;   
            const int BASE_THRESH2 = 39_475; 
            const int BASE_THRESH3 = 84_200;  
            const int BASE_THRESH4 = 160_725; 
            const int BASE_THRESH5 = 204_100; 
            const int BASE_THRESH6 = 510_300; 

           
            const int C1_3_THRESH1 = 9_525;   
            const int C1_3_THRESH2 = 38_700; 
            const int C1_3_THRESH3 = 82_500; 
            const int C1_3_THRESH4 = 157_500;
            const int C1_3_THRESH5 = 200_000; 
            const int C1_3_THRESH6 = 500_000; 

            
            const int C2_THRESH1 = 9_525;     
            const int C2_THRESH2 = 38_700;    
            const int C2_THRESH3 = 82_500;    
            const int C2_THRESH4 = 157_500;   
            const int C2_THRESH5 = 200_000;   
            const int C2_THRESH6 = 250_000;   
            const int C2_THRESH7 = 500_000;   
            const int C2_THRESH8 = 2_000_000;  
            const int C2_THRESH9 = 10_000_000; 

           
            const decimal C2_EXTRA_RATE = .04m; 
            const int C2_EXTRA_THRESH = 29000;  
            const decimal C3_REDUCTION_RATE = .10m; 

            int income; 

            
            decimal rate1 = 0;  
            decimal rate2 = 0;  
            decimal rate3 = 0;  
            decimal rate4 = 0;  
            decimal rate5 = 0;  
            decimal rate6 = 0;  
            decimal rate7 = 0;  
            decimal rate8 = 0;  
            decimal rate9 = 0;  
            decimal rate10 = 0; 

          
            int threshold1 = int.MaxValue; 
            int threshold2 = int.MaxValue; 
            int threshold3 = int.MaxValue; 
            int threshold4 = int.MaxValue; 
            int threshold5 = int.MaxValue; 
            int threshold6 = int.MaxValue; 
            int threshold7 = int.MaxValue; 
            int threshold8 = int.MaxValue; 
            int threshold9 = int.MaxValue; 

            decimal marginalRate; 
            decimal tax;          

            if (int.TryParse(incomeTxt.Text, out income) && income >= 0)
            {
                
                if (baselineRdoBtn.Checked) 
                {
                    rate1 = BASE_RATE1;
                    rate2 = BASE_RATE2;
                    rate3 = BASE_RATE3;
                    rate4 = BASE_RATE4;
                    rate5 = BASE_RATE5;
                    rate6 = BASE_RATE6;
                    rate7 = BASE_RATE7;

                    threshold1 = BASE_THRESH1;
                    threshold2 = BASE_THRESH2;
                    threshold3 = BASE_THRESH3;
                    threshold4 = BASE_THRESH4;
                    threshold5 = BASE_THRESH5;
                    threshold6 = BASE_THRESH6;
                }
                else if (candidate1RdoBtn.Checked || candidate3RdoBtn.Checked)
                {
                    rate1 = C1_3_RATE1;
                    rate2 = C1_3_RATE2;
                    rate3 = C1_3_RATE3;
                    rate4 = C1_3_RATE4;
                    rate5 = C1_3_RATE5;
                    rate6 = C1_3_RATE6;
                    rate7 = C1_3_RATE7;

                    threshold1 = C1_3_THRESH1;
                    threshold2 = C1_3_THRESH2;
                    threshold3 = C1_3_THRESH3;
                    threshold4 = C1_3_THRESH4;
                    threshold5 = C1_3_THRESH5;
                    threshold6 = C1_3_THRESH6;

                    
                    if (candidate3RdoBtn.Checked) 
                    {
                        rate1 *= (1 - C3_REDUCTION_RATE);
                        rate2 *= (1 - C3_REDUCTION_RATE);
                        rate3 *= (1 - C3_REDUCTION_RATE);
                        rate4 *= (1 - C3_REDUCTION_RATE);
                        rate5 *= (1 - C3_REDUCTION_RATE);
                    }

                }
                else 
                {
                    rate1 = C2_RATE1;
                    rate2 = C2_RATE2;
                    rate3 = C2_RATE3;
                    rate4 = C2_RATE4;
                    rate5 = C2_RATE5;
                    rate6 = C2_RATE6;
                    rate7 = C2_RATE7;
                    rate8 = C2_RATE8;
                    rate9 = C2_RATE9;
                    rate10 = C2_RATE10;

                    threshold1 = C2_THRESH1;
                    threshold2 = C2_THRESH2;
                    threshold3 = C2_THRESH3;
                    threshold4 = C2_THRESH4;
                    threshold5 = C2_THRESH5;
                    threshold6 = C2_THRESH6;
                    threshold7 = C2_THRESH7;
                    threshold8 = C2_THRESH8;
                    threshold9 = C2_THRESH9;
                }

                if (income > threshold9)
                {
                    marginalRate = rate10;
                    tax = (income - threshold9) * rate10 +
                        (threshold9 - threshold8) * rate9 + (threshold8 - threshold7) * rate8 +
                        (threshold7 - threshold6) * rate7 + (threshold6 - threshold5) * rate6 +
                        (threshold5 - threshold4) * rate5 + (threshold4 - threshold3) * rate4 +
                        (threshold3 - threshold2) * rate3 + (threshold2 - threshold1) * rate2 +
                        (threshold1 - 0) * rate1;
                }
                else if (income > threshold8)
                {
                    marginalRate = rate9;
                    tax = (income - threshold8) * rate9 + (threshold8 - threshold7) * rate8 +
                        (threshold7 - threshold6) * rate7 + (threshold6 - threshold5) * rate6 +
                        (threshold5 - threshold4) * rate5 + (threshold4 - threshold3) * rate4 +
                        (threshold3 - threshold2) * rate3 + (threshold2 - threshold1) * rate2 +
                        (threshold1 - 0) * rate1;
                }
                else if (income > threshold7)
                {
                    marginalRate = rate8;
                    tax = (income - threshold7) * rate8 +
                        (threshold7 - threshold6) * rate7 + (threshold6 - threshold5) * rate6 +
                        (threshold5 - threshold4) * rate5 + (threshold4 - threshold3) * rate4 +
                        (threshold3 - threshold2) * rate3 + (threshold2 - threshold1) * rate2 +
                        (threshold1 - 0) * rate1;
                }
                else if (income > threshold6)
                {
                    marginalRate = rate7;
                    tax = (income - threshold6) * rate7 + (threshold6 - threshold5) * rate6 +
                        (threshold5 - threshold4) * rate5 + (threshold4 - threshold3) * rate4 +
                        (threshold3 - threshold2) * rate3 + (threshold2 - threshold1) * rate2 +
                        (threshold1 - 0) * rate1;
                }
                else if (income > threshold5)
                {
                    marginalRate = rate6;
                    tax = (income - threshold5) * rate6 +
                        (threshold5 - threshold4) * rate5 + (threshold4 - threshold3) * rate4 +
                        (threshold3 - threshold2) * rate3 + (threshold2 - threshold1) * rate2 +
                        (threshold1 - 0) * rate1;
                }
                else if (income > threshold4)
                {
                    marginalRate = rate5;
                    tax = (income - threshold4) * rate5 + (threshold4 - threshold3) * rate4 +
                        (threshold3 - threshold2) * rate3 + (threshold2 - threshold1) * rate2 +
                        (threshold1 - 0) * rate1;
                }
                else if (income > threshold3)
                {
                    marginalRate = rate4;
                    tax = (income - threshold3) * rate4 +
                        (threshold3 - threshold2) * rate3 + (threshold2 - threshold1) * rate2 +
                        (threshold1 - 0) * rate1;
                }
                else if (income > threshold2)
                {
                    marginalRate = rate3;
                    tax = (income - threshold2) * rate3 + (threshold2 - threshold1) * rate2 +
                        (threshold1 - 0) * rate1;
                }
                else if (income > threshold1)
                {
                    marginalRate = rate2;
                    tax = (income - threshold1) * rate2 + (threshold1 - 0) * rate1;
                }
                else
                {
                    marginalRate = rate1;
                    tax = (income - 0) * rate1;
                }

             
                if (candidate2RdoBtn.Checked) 
                {
                    if (income > C2_EXTRA_THRESH) 
                    {
                        tax += (income - C2_EXTRA_THRESH) * C2_EXTRA_RATE;
                    }
                }

               
                marginalRateOutLbl.Text = $"{marginalRate:P1}";
                taxOutLbl.Text = $"{tax:C}";
            }
            else 
                MessageBox.Show("Enter valid income!");
        }
    }
}
