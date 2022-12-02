// Program 3
// CIS 199-50
// Due: 4/2/2020
// By: Jacob Puentes

// This application calculates the marginal tax rate
// for various candidates' tex plans.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog3
{
    public partial class Prog3Form : Form
    {
        public Prog3Form()
        {
            InitializeComponent();
        }

        // Precondition:  User has clicked the Calculate Tax button
        // Postcondition: Will calculate and display user's marginal tax rate
        private void calcTaxBtn_Click(object sender, EventArgs e)
        {
            // The marginal tax rates
            // Baseline
            const decimal BASE_RATE1 = .10m; 
            const decimal BASE_RATE2 = .12m; 
            const decimal BASE_RATE3 = .22m; 
            const decimal BASE_RATE4 = .24m; 
            const decimal BASE_RATE5 = .32m; 
            const decimal BASE_RATE6 = .35m; 
            const decimal BASE_RATE7 = .37m; 

            // Candidate 2
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
            
            // Taxable income thresholds for each candidate
            const int BASE_THRESH1 = 9_700;   
            const int BASE_THRESH2 = 39_475;  
            const int BASE_THRESH3 = 84_200;  
            const int BASE_THRESH4 = 160_725; 
            const int BASE_THRESH5 = 204_100; 
            const int BASE_THRESH6 = 510_300; 

            // Candidate 2
            const int C2_THRESH1 = 9_525;    
            const int C2_THRESH2 = 38_700;   
            const int C2_THRESH3 = 82_500;    
            const int C2_THRESH4 = 157_500;   
            const int C2_THRESH5 = 200_000;  
            const int C2_THRESH6 = 250_000;  
            const int C2_THRESH7 = 500_000;   
            const int C2_THRESH8 = 2_000_000;  
            const int C2_THRESH9 = 10_000_000;

            int income; // Filer's taxable income (input)

            // Array of Baseline income threshold lower limits
            int[] baseThresholds = { 0, BASE_THRESH1+1, BASE_THRESH2+1, BASE_THRESH3+1,
                BASE_THRESH4+1, BASE_THRESH5+1, BASE_THRESH6+1 };
            // Array of Baseline marginal rates
            decimal[] baseRates = { BASE_RATE1, BASE_RATE2, BASE_RATE3, BASE_RATE4,
                BASE_RATE5, BASE_RATE6, BASE_RATE7 };
            // Array of Candidate 2 income threshold lower limits
            int[] c2Thresholds = { 0, C2_THRESH1+1, C2_THRESH2+1, C2_THRESH3+1, C2_THRESH4+1,
                C2_THRESH5+1, C2_THRESH6+1, C2_THRESH7+1, C2_THRESH8+1, C2_THRESH9+1 };
            // Array of Candidate 2 marginal rates
            decimal[] c2Rates = { C2_RATE1, C2_RATE2, C2_RATE3, C2_RATE4, C2_RATE5, C2_RATE6,
                C2_RATE7, C2_RATE8, C2_RATE9, C2_RATE10 };

            int[] thresholds; 
            decimal[] rates;  

            int index;  
            bool found; 

            decimal marginalRate = 0; 
            
            if (int.TryParse(incomeTxt.Text, out income) && income >= 0)
            {
                
                if (baselineRdoBtn.Checked) 
                {
                    thresholds = baseThresholds;
                    rates = baseRates;
                }
                else // 
                {
                    thresholds = c2Thresholds;
                    rates = c2Rates;
                }

                // Calculate income tax due and find their marginal rate
                index = thresholds.Length - 1; 
                found = false;

                while (index >= 0 && !found)
                {
                    if (income >= thresholds[index])
                        found = true;
                    else
                        --index;
                }

                if (found)
                    marginalRate = rates[index];    

                // Output results
                marginalRateOutLbl.Text = $"{marginalRate:P1}";
            }
            else // Invalid input
                MessageBox.Show("Enter valid income!");
        }
    }
}
