// Program 1
// CIS 199-50
// Due: 2/11/2020
// By: Jacob Puentes

// This application calculates the cost of carpet, materials, and labor for an installation job.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog1
{
    public partial class Prog1Form : Form
    {
        public Prog1Form()
        {
            InitializeComponent();
        }

        private void calcEstimateBtn_Click(object sender, EventArgs e)
        {
            const double FIRST_RM_FEE = 75.0;      
            const double LABOR_COST_PER_YD = 4.25; 
            const double PAD_COST_PER_YD = 2.5;    
            const double SQ_FT_PER_YD = 9.0;       
            const double WASTE_RATE = 0.1;         

            double width;       
            double length;     
            double pricePerYd;  
            int paddingLayers;  
            int firstRoom;      
            double sqYards;      
            double carpetCost; 
            double paddingCost; 
            double laborCost;  
            double totalCost;   

            // Gather input
            width = double.Parse(widthTxt.Text);
            length = double.Parse(lengthTxt.Text);
            pricePerYd = double.Parse(pricePerYdTxt.Text);
            paddingLayers = int.Parse(paddingLayersTxt.Text);
            firstRoom = int.Parse(firstRoomTxt.Text);

            // Perform Calculations
            sqYards = width * length / SQ_FT_PER_YD;
            carpetCost = sqYards * (1 + WASTE_RATE) * pricePerYd;
            paddingCost = sqYards * (1 + WASTE_RATE) * paddingLayers * PAD_COST_PER_YD;
            laborCost = firstRoom * FIRST_RM_FEE + sqYards * LABOR_COST_PER_YD;
            totalCost = carpetCost + paddingCost + laborCost;

            // Output results
            sqYardsOutputLbl.Text = $"{sqYards:F1}";
            carpetCostOutputLbl.Text = $"{carpetCost:C}";
            paddingCostOutputLbl.Text = $"{paddingCost:C}";
            laborCostOutputLbl.Text = $"{laborCost:C}";
            totalCostOutputLbl.Text = $"{totalCost:C}";

        }
    }
}
