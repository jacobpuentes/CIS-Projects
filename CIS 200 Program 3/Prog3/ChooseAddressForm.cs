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
    public partial class ChooseAddressForm : Form
    {
        private List<Address> addressList;

        public ChooseAddressForm(List<Address> addresses)
        {
            InitializeComponent();
            addressList = addresses;
        }

        public int AddressIndex
        {
            get
            {
                return addListCbo.SelectedIndex;
            }

            set
            {
                if ((value >= -1) && (value < addressList.Count))
                    addListCbo.SelectedIndex = value;
                else
                    throw new ArgumentOutOfRangeException("AddressIndex", value,
                        "Index must be valid");
            }
        }


        private void ChooseAddressForm_Load(object sender, EventArgs e)
        {
            foreach (Address a in addressList)
            {
                addListCbo.Items.Add(a.Name);
            }

            addListCbo.SelectedIndex = 0; 
        }

        private void cancelBtn_MouseDown(object sender, MouseEventArgs e)
        {

            this.DialogResult = DialogResult.Cancel;
        }

        private void addListCbo_Validating(object sender, CancelEventArgs e)
        {
            if (addListCbo.SelectedIndex == -1) 
            {
                e.Cancel = true;
                errorProvider.SetError(addListCbo, "Must select an address");
            }
        }

        private void addListCbo_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(addListCbo, "");
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
                this.DialogResult = DialogResult.OK;
        }
    }
}
