namespace Prog1
{
    partial class Prog1Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.titleLbl = new System.Windows.Forms.Label();
            this.widthLbl = new System.Windows.Forms.Label();
            this.lengthLbl = new System.Windows.Forms.Label();
            this.pricePerYdLbl = new System.Windows.Forms.Label();
            this.paddingLayersLbl = new System.Windows.Forms.Label();
            this.firstRoomLbl = new System.Windows.Forms.Label();
            this.firstRoomLegendLbl = new System.Windows.Forms.Label();
            this.widthTxt = new System.Windows.Forms.TextBox();
            this.lengthTxt = new System.Windows.Forms.TextBox();
            this.pricePerYdTxt = new System.Windows.Forms.TextBox();
            this.paddingLayersTxt = new System.Windows.Forms.TextBox();
            this.firstRoomTxt = new System.Windows.Forms.TextBox();
            this.sqYardsLbl = new System.Windows.Forms.Label();
            this.sqYardsOutputLbl = new System.Windows.Forms.Label();
            this.carpetCostOutputLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.paddingCostOutputLbl = new System.Windows.Forms.Label();
            this.paddingCostLbl = new System.Windows.Forms.Label();
            this.laborCostOutputLbl = new System.Windows.Forms.Label();
            this.laborCostLbl = new System.Windows.Forms.Label();
            this.totalCostOutputLbl = new System.Windows.Forms.Label();
            this.totalCostLbl = new System.Windows.Forms.Label();
            this.calcEstimateBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Location = new System.Drawing.Point(59, 9);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(152, 13);
            this.titleLbl.TabIndex = 1;
            this.titleLbl.Text = "Handy-Dandy Carpet Estimator";
            // 
            // widthLbl
            // 
            this.widthLbl.AutoSize = true;
            this.widthLbl.Location = new System.Drawing.Point(24, 41);
            this.widthLbl.Name = "widthLbl";
            this.widthLbl.Size = new System.Drawing.Size(119, 13);
            this.widthLbl.TabIndex = 4;
            this.widthLbl.Text = "Max Width of Room (ft):";
            // 
            // lengthLbl
            // 
            this.lengthLbl.AutoSize = true;
            this.lengthLbl.Location = new System.Drawing.Point(19, 65);
            this.lengthLbl.Name = "lengthLbl";
            this.lengthLbl.Size = new System.Drawing.Size(124, 13);
            this.lengthLbl.TabIndex = 5;
            this.lengthLbl.Text = "Max Length of Room (ft):";
            // 
            // pricePerYdLbl
            // 
            this.pricePerYdLbl.AutoSize = true;
            this.pricePerYdLbl.Location = new System.Drawing.Point(38, 89);
            this.pricePerYdLbl.Name = "pricePerYdLbl";
            this.pricePerYdLbl.Size = new System.Drawing.Size(105, 13);
            this.pricePerYdLbl.TabIndex = 6;
            this.pricePerYdLbl.Text = "Carpet Price (sq. yd):";
            // 
            // paddingLayersLbl
            // 
            this.paddingLayersLbl.AutoSize = true;
            this.paddingLayersLbl.Location = new System.Drawing.Point(12, 113);
            this.paddingLayersLbl.Name = "paddingLayersLbl";
            this.paddingLayersLbl.Size = new System.Drawing.Size(131, 13);
            this.paddingLayersLbl.TabIndex = 7;
            this.paddingLayersLbl.Text = "Layers of Padding (1 or 2):";
            // 
            // firstRoomLbl
            // 
            this.firstRoomLbl.AutoSize = true;
            this.firstRoomLbl.Location = new System.Drawing.Point(80, 136);
            this.firstRoomLbl.Name = "firstRoomLbl";
            this.firstRoomLbl.Size = new System.Drawing.Size(63, 13);
            this.firstRoomLbl.TabIndex = 8;
            this.firstRoomLbl.Text = "First Room: ";
            // 
            // firstRoomLegendLbl
            // 
            this.firstRoomLegendLbl.AutoSize = true;
            this.firstRoomLegendLbl.Location = new System.Drawing.Point(51, 149);
            this.firstRoomLegendLbl.Name = "firstRoomLegendLbl";
            this.firstRoomLegendLbl.Size = new System.Drawing.Size(92, 13);
            this.firstRoomLegendLbl.TabIndex = 9;
            this.firstRoomLegendLbl.Text = "(1 = YES, 0 = NO)";
            // 
            // widthTxt
            // 
            this.widthTxt.Location = new System.Drawing.Point(149, 38);
            this.widthTxt.Name = "widthTxt";
            this.widthTxt.Size = new System.Drawing.Size(100, 20);
            this.widthTxt.TabIndex = 10;
            // 
            // lengthTxt
            // 
            this.lengthTxt.Location = new System.Drawing.Point(149, 62);
            this.lengthTxt.Name = "lengthTxt";
            this.lengthTxt.Size = new System.Drawing.Size(100, 20);
            this.lengthTxt.TabIndex = 11;
            // 
            // pricePerYdTxt
            // 
            this.pricePerYdTxt.Location = new System.Drawing.Point(149, 86);
            this.pricePerYdTxt.Name = "pricePerYdTxt";
            this.pricePerYdTxt.Size = new System.Drawing.Size(100, 20);
            this.pricePerYdTxt.TabIndex = 12;
            // 
            // paddingLayersTxt
            // 
            this.paddingLayersTxt.Location = new System.Drawing.Point(149, 110);
            this.paddingLayersTxt.Name = "paddingLayersTxt";
            this.paddingLayersTxt.Size = new System.Drawing.Size(100, 20);
            this.paddingLayersTxt.TabIndex = 13;
            // 
            // firstRoomTxt
            // 
            this.firstRoomTxt.Location = new System.Drawing.Point(149, 133);
            this.firstRoomTxt.Name = "firstRoomTxt";
            this.firstRoomTxt.Size = new System.Drawing.Size(100, 20);
            this.firstRoomTxt.TabIndex = 14;
            // 
            // sqYardsLbl
            // 
            this.sqYardsLbl.AutoSize = true;
            this.sqYardsLbl.Location = new System.Drawing.Point(87, 197);
            this.sqYardsLbl.Name = "sqYardsLbl";
            this.sqYardsLbl.Size = new System.Drawing.Size(56, 13);
            this.sqYardsLbl.TabIndex = 15;
            this.sqYardsLbl.Text = "Sq. Yards:";
            // 
            // sqYardsOutputLbl
            // 
            this.sqYardsOutputLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sqYardsOutputLbl.Location = new System.Drawing.Point(149, 196);
            this.sqYardsOutputLbl.Name = "sqYardsOutputLbl";
            this.sqYardsOutputLbl.Size = new System.Drawing.Size(100, 20);
            this.sqYardsOutputLbl.TabIndex = 16;
            this.sqYardsOutputLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // carpetCostOutputLbl
            // 
            this.carpetCostOutputLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.carpetCostOutputLbl.Location = new System.Drawing.Point(149, 227);
            this.carpetCostOutputLbl.Name = "carpetCostOutputLbl";
            this.carpetCostOutputLbl.Size = new System.Drawing.Size(100, 20);
            this.carpetCostOutputLbl.TabIndex = 18;
            this.carpetCostOutputLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Carpet Cost:";
            // 
            // paddingCostOutputLbl
            // 
            this.paddingCostOutputLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paddingCostOutputLbl.Location = new System.Drawing.Point(149, 256);
            this.paddingCostOutputLbl.Name = "paddingCostOutputLbl";
            this.paddingCostOutputLbl.Size = new System.Drawing.Size(100, 20);
            this.paddingCostOutputLbl.TabIndex = 20;
            this.paddingCostOutputLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // paddingCostLbl
            // 
            this.paddingCostLbl.AutoSize = true;
            this.paddingCostLbl.Location = new System.Drawing.Point(70, 257);
            this.paddingCostLbl.Name = "paddingCostLbl";
            this.paddingCostLbl.Size = new System.Drawing.Size(73, 13);
            this.paddingCostLbl.TabIndex = 19;
            this.paddingCostLbl.Text = "Padding Cost:";
            // 
            // laborCostOutputLbl
            // 
            this.laborCostOutputLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.laborCostOutputLbl.Location = new System.Drawing.Point(149, 288);
            this.laborCostOutputLbl.Name = "laborCostOutputLbl";
            this.laborCostOutputLbl.Size = new System.Drawing.Size(100, 20);
            this.laborCostOutputLbl.TabIndex = 22;
            this.laborCostOutputLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // laborCostLbl
            // 
            this.laborCostLbl.AutoSize = true;
            this.laborCostLbl.Location = new System.Drawing.Point(82, 289);
            this.laborCostLbl.Name = "laborCostLbl";
            this.laborCostLbl.Size = new System.Drawing.Size(61, 13);
            this.laborCostLbl.TabIndex = 21;
            this.laborCostLbl.Text = "Labor Cost:";
            // 
            // totalCostOutputLbl
            // 
            this.totalCostOutputLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalCostOutputLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCostOutputLbl.Location = new System.Drawing.Point(149, 319);
            this.totalCostOutputLbl.Name = "totalCostOutputLbl";
            this.totalCostOutputLbl.Size = new System.Drawing.Size(100, 20);
            this.totalCostOutputLbl.TabIndex = 24;
            this.totalCostOutputLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // totalCostLbl
            // 
            this.totalCostLbl.AutoSize = true;
            this.totalCostLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCostLbl.Location = new System.Drawing.Point(74, 320);
            this.totalCostLbl.Name = "totalCostLbl";
            this.totalCostLbl.Size = new System.Drawing.Size(69, 13);
            this.totalCostLbl.TabIndex = 23;
            this.totalCostLbl.Text = "Total Cost:";
            // 
            // calcEstimateBtn
            // 
            this.calcEstimateBtn.Location = new System.Drawing.Point(79, 369);
            this.calcEstimateBtn.Name = "calcEstimateBtn";
            this.calcEstimateBtn.Size = new System.Drawing.Size(112, 23);
            this.calcEstimateBtn.TabIndex = 25;
            this.calcEstimateBtn.Text = "Calculate Estimate";
            this.calcEstimateBtn.UseVisualStyleBackColor = true;
            this.calcEstimateBtn.Click += new System.EventHandler(this.calcEstimateBtn_Click);
            // 
            // Prog1Form
            // 
            this.AcceptButton = this.calcEstimateBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 408);
            this.Controls.Add(this.calcEstimateBtn);
            this.Controls.Add(this.totalCostOutputLbl);
            this.Controls.Add(this.totalCostLbl);
            this.Controls.Add(this.laborCostOutputLbl);
            this.Controls.Add(this.laborCostLbl);
            this.Controls.Add(this.paddingCostOutputLbl);
            this.Controls.Add(this.paddingCostLbl);
            this.Controls.Add(this.carpetCostOutputLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sqYardsOutputLbl);
            this.Controls.Add(this.sqYardsLbl);
            this.Controls.Add(this.firstRoomTxt);
            this.Controls.Add(this.paddingLayersTxt);
            this.Controls.Add(this.pricePerYdTxt);
            this.Controls.Add(this.lengthTxt);
            this.Controls.Add(this.widthTxt);
            this.Controls.Add(this.firstRoomLegendLbl);
            this.Controls.Add(this.firstRoomLbl);
            this.Controls.Add(this.paddingLayersLbl);
            this.Controls.Add(this.pricePerYdLbl);
            this.Controls.Add(this.lengthLbl);
            this.Controls.Add(this.widthLbl);
            this.Controls.Add(this.titleLbl);
            this.Name = "Prog1Form";
            this.Text = "Program 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Label widthLbl;
        private System.Windows.Forms.Label lengthLbl;
        private System.Windows.Forms.Label pricePerYdLbl;
        private System.Windows.Forms.Label paddingLayersLbl;
        private System.Windows.Forms.Label firstRoomLbl;
        private System.Windows.Forms.Label firstRoomLegendLbl;
        private System.Windows.Forms.TextBox widthTxt;
        private System.Windows.Forms.TextBox lengthTxt;
        private System.Windows.Forms.TextBox pricePerYdTxt;
        private System.Windows.Forms.TextBox paddingLayersTxt;
        private System.Windows.Forms.TextBox firstRoomTxt;
        private System.Windows.Forms.Label sqYardsLbl;
        private System.Windows.Forms.Label sqYardsOutputLbl;
        private System.Windows.Forms.Label carpetCostOutputLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label paddingCostOutputLbl;
        private System.Windows.Forms.Label paddingCostLbl;
        private System.Windows.Forms.Label laborCostOutputLbl;
        private System.Windows.Forms.Label laborCostLbl;
        private System.Windows.Forms.Label totalCostOutputLbl;
        private System.Windows.Forms.Label totalCostLbl;
        private System.Windows.Forms.Button calcEstimateBtn;
    }
}

