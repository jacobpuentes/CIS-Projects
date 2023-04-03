using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UPVApp
{
    public partial class LetterForm : Form
    {
        public const int MIN_ADDRESSES = 2; 

        private List<Address> addressList;  

        public LetterForm(List<Address> addresses)
        {
            InitializeComponent();

            addressList = addresses;
        }

        internal int OriginAddressIndex
        {
            get
            {
                return originAddCbo.SelectedIndex;
            }

            set
            {
                if ((value >= -1) && (value < addressList.Count))
                    originAddCbo.SelectedIndex = value;
                else
                    throw new ArgumentOutOfRangeException("OriginAddressIndex", value,
                        "Index must be valid");
            }
        }

        internal int DestinationAddressIndex
        {
            get
            {
                return destAddCbo.SelectedIndex;
            }

            set
            {
                if ((value >= -1) && (value < addressList.Count))
                    destAddCbo.SelectedIndex = value;
                else
                    throw new ArgumentOutOfRangeException("DestinationAddressIndex", value,
                        "Index must be valid");
            }
        }

        internal string FixedCostText
        {
            get
            {
                return fixedCostTxt.Text;
            }
            set
            {
                fixedCostTxt.Text = value;
            }
        }

        private void LetterForm_Load(object sender, EventArgs e)
        {
            if (addressList.Count < MIN_ADDRESSES) 
            {
                MessageBox.Show("Need " + MIN_ADDRESSES + " addresses to create letter!",
                    "Addresses Error");
                this.DialogResult = DialogResult.Abort; 
            }
            else
            {
                foreach (Address a in addressList)
                {
                    originAddCbo.Items.Add(a.Name);
                    destAddCbo.Items.Add(a.Name);
                }
            }
        }

        private void fixedCostTxt_Validating(object sender, CancelEventArgs e)
        {
            decimal fixedCost; 
            bool valid = true; 

            if (!decimal.TryParse(fixedCostTxt.Text, out fixedCost)) 
                valid = false;
            else if (fixedCost < 0)
                valid = false;

            if (!valid) 
            {
                e.Cancel = true;
                fixedCostTxt.SelectAll();
                errorProvider.SetError(fixedCostTxt, "Invalid cost! Enter an amount.");
            }
        }

        private void addressCbo_Validating(object sender, CancelEventArgs e)
        {
            
            ComboBox cbo = sender as ComboBox;

            if (cbo.SelectedIndex == -1) 
            {
                e.Cancel = true;
                errorProvider.SetError(cbo, "Must select an address");
            }
            else if (originAddCbo.SelectedIndex != -1 && destAddCbo.SelectedIndex == originAddCbo.SelectedIndex)
            {
                e.Cancel = true;
                errorProvider.SetError(cbo, "Must select different addresses");
            }
        }

        private void AllFields_Validated(object sender, EventArgs e)
        {
            Control control = sender as Control; 
                                                
            errorProvider.SetError(control, "");
        }


        private void cancelBtn_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left) 
                this.DialogResult = DialogResult.Cancel;
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
                this.DialogResult = DialogResult.OK;
        }
    }
}
