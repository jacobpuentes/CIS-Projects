// Program 3
// CIS 200-76
// Fall 2022
// Due: 11/29/22
// By: Jacob Puentes


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
    public partial class AddressForm : Form
    {
        public const String DEFAULT_STATE = "KY"; 

        public AddressForm()
        {
            InitializeComponent();

            List<string> states = new List<string> {"CA", "IN", "KY", "MD", "ME",
                                   "NC", "OH", "SC", "TN", "TX"}; 

            
            foreach (string state in states)
                stateCbo.Items.Add(state);
            
            State = DEFAULT_STATE;
        }

        internal string AddressName
        {
            get
            {
                return nameTxt.Text;
            }
            set
            {
                nameTxt.Text = value;
            }
        }

        internal string Address1
        {
            get
            {
                return address1Txt.Text;
            }
            set
            {
                address1Txt.Text = value;
            }
        }

        internal string Address2
        {
            get
            {
                return address2Txt.Text;
            }
            set
            {
                address2Txt.Text = value;
            }
        }

        internal string City
        {
            get
            {
                return cityTxt.Text;
            }
            set
            {
                cityTxt.Text = value;
            }
        }

        internal string ZipText
        {
            get
            {
                return zipTxt.Text;
            }
            set
            {
                zipTxt.Text = value;
            }
        }

        internal string State
        {
            get
            {
                if (stateCbo.SelectedIndex != -1) 
                    return stateCbo.SelectedItem.ToString();
                else
                    return "";

            }
            set
            {
                stateCbo.SelectedItem = value;
            }
        }
        private void stateCbo_Validating(object sender, CancelEventArgs e)
        {
            if (stateCbo.SelectedIndex == -1) 
            {
                e.Cancel = true;
                errorProvider.SetError(stateCbo, "Must select a state!");
            }
        }

        private void zipTxt_Validating(object sender, CancelEventArgs e)
        {
            int zip;           

            if (!int.TryParse(zipTxt.Text, out zip)      
                || (zip < Address.MIN_ZIP) || (zip > Address.MAX_ZIP)) 
            {
                e.Cancel = true;
                zipTxt.SelectAll();
                errorProvider.SetError(zipTxt, "Invalid zip code! Enter 5 digit zip code.");
            }
        }

        private void RequiredTextFields_Validating(object sender, CancelEventArgs e)
        {
            TextBox textbox = sender as TextBox; 
                                                

            if (string.IsNullOrWhiteSpace(textbox.Text)) 
            {
                e.Cancel = true;

                const int SUFFIX = 3; 
                string name;          
                name = textbox.Name.Substring(0, textbox.Name.Length - SUFFIX); 
                errorProvider.SetError(textbox, $"Must enter a value for {name}!");

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
