using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;


namespace UPVApp
{
    public partial class Prog3Form : Form
    {
        private UserParcelView upv; 

       
        public Prog3Form()
        {
            InitializeComponent();

            upv = new UserParcelView();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string NL = Environment.NewLine; 

            MessageBox.Show($"Program 3{NL}By: Jacob Puentes {NL}CIS 200{NL}Fall 2022",
                "About Program 3");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      
        private void addressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddressForm addressForm = new AddressForm();    
            DialogResult result = addressForm.ShowDialog(); 
            int zip; 

            if (result == DialogResult.OK) 
            {
                if (int.TryParse(addressForm.ZipText, out zip))
                {
                    upv.AddAddress(addressForm.AddressName, addressForm.Address1,
                        addressForm.Address2, addressForm.City, addressForm.State,
                        zip); 
                }
                else 
                {
                    MessageBox.Show("Problem with Address Validation!", "Validation Error");
                }
            }

            addressForm.Dispose(); 
                                   
        }

        private void listAddressesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder result = new StringBuilder(); 
                                                        
            string NL = Environment.NewLine;            

            result.Append("Addresses:");
            result.Append(NL); 
            result.Append(NL);

            foreach (Address a in upv.AddressList)
            {
                result.Append(a.ToString());
                result.Append(NL);
                result.Append("------------------------------");
                result.Append(NL);
            }

            reportTxt.Text = result.ToString();

       
            reportTxt.Focus();
            reportTxt.SelectionStart = 0;
            reportTxt.SelectionLength = 0;
        }

        private void letterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LetterForm letterForm; 
            DialogResult result;   
            decimal fixedCost;   

            if (upv.AddressCount < LetterForm.MIN_ADDRESSES) 
            {
                MessageBox.Show("Need " + LetterForm.MIN_ADDRESSES + " addresses to create letter!",
                    "Addresses Error");
                return; 
            }

            letterForm = new LetterForm(upv.AddressList); 
            result = letterForm.ShowDialog();

            if (result == DialogResult.OK) 
            {
                if (decimal.TryParse(letterForm.FixedCostText, out fixedCost))
                {
                    
                    upv.AddLetter(upv.AddressAt(letterForm.OriginAddressIndex),
                        upv.AddressAt(letterForm.DestinationAddressIndex),
                        fixedCost); 
                }
                else 
                {
                    MessageBox.Show("Problem with Letter Validation!", "Validation Error");
                }
            }

            letterForm.Dispose(); 
                                  
        }

        private void listParcelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder result = new StringBuilder(); 
                                                        
            decimal totalCost = 0;                      
            string NL = Environment.NewLine;           

            result.Append("Parcels:");
            result.Append(NL); 
            result.Append(NL);

            foreach (Parcel p in upv.ParcelList)
            {
                result.Append(p.ToString());
                result.Append(NL);
                result.Append("------------------------------");
                result.Append(NL);
                totalCost += p.CalcCost();
            }

            result.Append(NL);
            result.Append($"Total Cost: {totalCost:C}");

            reportTxt.Text = result.ToString();

            reportTxt.Focus();
            reportTxt.SelectionStart = 0;
            reportTxt.SelectionLength = 0;
        }

       
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter(); 
            FileStream output = null;                          
            DialogResult result;                              
            string fileName;                            

            using (SaveFileDialog fileChooser = new SaveFileDialog()) 
            {
                fileChooser.CheckFileExists = false; 

               
                result = fileChooser.ShowDialog();
                fileName = fileChooser.FileName; 
            } 

            if (result == DialogResult.OK)
            {

                
                if (fileName == string.Empty)
                    MessageBox.Show("Invalid File Name", "Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    
                    try
                    {
                        
                        output = new FileStream(fileName, FileMode.Create, FileAccess.Write);

                        formatter.Serialize(output, upv);
                    } 

                    catch (IOException)
                    {
                        
                        MessageBox.Show("I/O Error Writing to File", "Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                    } 

                    catch (SerializationException)
                    {
                        MessageBox.Show("Serialization Error Writing to File", "Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        output?.Close(); 
                    }
                } 
            } 
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BinaryFormatter reader = new BinaryFormatter(); 
            FileStream input = null;                        
            DialogResult result;                            
            string fileName;                                
            UserParcelView temp;                           

            using (OpenFileDialog fileChooser = new OpenFileDialog()) 
            {
                result = fileChooser.ShowDialog();
                fileName = fileChooser.FileName;
            } 

            if (result == DialogResult.OK)
            {
                
                if (fileName == string.Empty)
                    MessageBox.Show("Invalid File Name", "Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                   
                    try
                    {

                        input = new FileStream(fileName, FileMode.Open, FileAccess.Read);

                        
                        temp = (UserParcelView)reader.Deserialize(input);

                        upv = temp; 
                    } 

                    
                    catch (IOException)
                    {
                        
                        MessageBox.Show("I/O Error Reading From File", "Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                    } 

                    catch (SerializationException)
                    {
                        MessageBox.Show("Serialization Error Reading From File", "Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                    } 
                    finally
                    {
                        input?.Close(); 
                    }
                } 
            } 
        }

       
        private void addressToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (upv.AddressList.Count > 0) 
            {
                ChooseAddressForm chooseAddForm = new ChooseAddressForm(upv.AddressList); 
                DialogResult result = chooseAddForm.ShowDialog();                         

                if (result == DialogResult.OK) 
                {
                    int editIndex; 
                    editIndex = chooseAddForm.AddressIndex;

                    if (editIndex >= 0) 
                    {
                        Address editAddress = upv.AddressAt(editIndex); 
                        AddressForm addressForm = new AddressForm();    

                        
                        addressForm.AddressName = editAddress.Name;
                        addressForm.Address1 = editAddress.Address1;
                        addressForm.Address2 = editAddress.Address2;
                        addressForm.City = editAddress.City;
                        addressForm.State = editAddress.State;
                        addressForm.ZipText = $"{editAddress.Zip:D5}";

                        result = addressForm.ShowDialog(); 

                        if (result == DialogResult.OK) 
                        {
                           
                            editAddress.Name = addressForm.AddressName;
                            editAddress.Address1 = addressForm.Address1;
                            editAddress.Address2 = addressForm.Address2;
                            editAddress.City = addressForm.City;
                            editAddress.State = addressForm.State;
                            if (int.TryParse(addressForm.ZipText, out int zip))
                            {
                                editAddress.Zip = zip;
                            }
                            else
                            {
                                MessageBox.Show("Problem with Zip Validation!", "Validation Error");
                            }
                        }
                        addressForm.Dispose(); 
                    }
                }
                chooseAddForm.Dispose(); 
            }
            else
                MessageBox.Show("No addresses to edit!", "No Addresses");
        }
    }
}