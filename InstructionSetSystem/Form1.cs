using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstructionSetSystem
{
    public partial class instructionSet : Form
    {
        public instructionSet()
        {
            InitializeComponent();
            //rtbDisplay.ReadOnly = true;
            rtbDisplay.BackColor = System.Drawing.SystemColors.Window;
        }

        private void openTSMI_Click(object sender, EventArgs e)
        {
            try
            {
                InstructionSetComponent obj = new InstructionSetSystem.InstructionSetComponent();
                rtbDisplay.LoadFile(obj.Open(), RichTextBoxStreamType.RichText);
            }
            catch (Exception errorMsg)
            {
                MessageBox.Show(errorMsg.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (instructionTxtMenu.Checked || legalTxtMenu.Checked)
            {
              
                if (txtAdd != null)
                {
                    rtbDisplay.AppendText(txtAdd.Text);
                    txtAdd.Clear();
                 
                }
            }
            else { MessageBox.Show("Please select an instruction set from the 'Create' menu above"); }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            rtbDisplay.Clear();
        }

        private void rtbDisplay_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //if (rtbDisplay != null && rtbDisplay.ReadOnly == true)
            //{
            //    rtbDisplay.ReadOnly = false;

            //}
        }

        private void instructionTxtMenu_Click(object sender, EventArgs e)
        {
            legalTxtMenu.Checked = false;
            // Instruction Text Block (Number List and Bold Text)
            try
            {
                InstructionSetComponent obj = new InstructionSetSystem.InstructionSetComponent();
                obj.InstructionTextBlock(rtbDisplay, instructionTxtMenu);
            }
            catch (Exception errorMsg)
            {
                MessageBox.Show(errorMsg.Message);
            }
        }

        private void saveTSMI_Click(object sender, EventArgs e)
        {
            try
            {
                InstructionSetComponent obj = new InstructionSetSystem.InstructionSetComponent();
                obj.Save(rtbDisplay);
                MessageBox.Show("File Saved Sucessfully");

            }
            catch (Exception errorMsg)
            {
                MessageBox.Show(errorMsg.Message);
            }
        }

        private void legalTxtMenu_Click(object sender, EventArgs e)
        {
            instructionTxtMenu.Checked = false;
            // Italics Text
            try
            {
                InstructionSetComponent obj = new InstructionSetSystem.InstructionSetComponent();
                obj.LegalTextBlock(rtbDisplay, legalTxtMenu);
            }
            catch (Exception errorMsg)
            {
                MessageBox.Show(errorMsg.Message);
            }
        }

        private void foregroundColourTSMI_Click(object sender, EventArgs e)
        {
           
            try
            {
                ExtendedTextBlock obj = new ExtendedTextBlock(new InstructionSetComponent());
                obj.ForegroundColor(rtbDisplay, foregroundColourTSMI);
            }
            catch (Exception errorMsg)
            {
                MessageBox.Show(errorMsg.Message);
            }
        }

        private void backgroundColourTSMI_Click(object sender, EventArgs e)
        {
            try
            {
                ExtendedTextBlock obj = new ExtendedTextBlock(new InstructionSetComponent());
                obj.BackgroundColor(rtbDisplay, backgroundColourTSMI);
            }
            catch (Exception errorMsg)
            {
                MessageBox.Show(errorMsg.Message);
            }
        }

        private void underlineTSMI_Click(object sender, EventArgs e)
        {
            try
            {
                ExtendedTextBlock obj = new ExtendedTextBlock(new InstructionSetComponent());
                obj.UnderlineText(rtbDisplay, underlineTSMI);
            }
            catch (Exception errorMsg)
            {
                MessageBox.Show(errorMsg.Message);
            }
        }

        private void rtbDisplay_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void rtbDisplay_KeyDown(object sender, KeyEventArgs e)
        {
            // Handle Instruction Text Block Enter Key (Number List)

            try
            {
                #region Handle Enter Key
                int tempNum;
                if (e.KeyCode == Keys.Enter)
                    try
                    {
                        // Checking the Number list in the line 
                        if (char.IsDigit(rtbDisplay.Text[rtbDisplay.GetFirstCharIndexOfCurrentLine()]))
                        {
                            if (char.IsDigit(rtbDisplay.Text[rtbDisplay.GetFirstCharIndexOfCurrentLine() + 1]) && rtbDisplay.Text[rtbDisplay.GetFirstCharIndexOfCurrentLine() + 2] == '.')
                                tempNum = int.Parse(rtbDisplay.Text.Substring(rtbDisplay.GetFirstCharIndexOfCurrentLine(), 2));
                            else tempNum = int.Parse(rtbDisplay.Text[rtbDisplay.GetFirstCharIndexOfCurrentLine()].ToString());

                            if (rtbDisplay.Text[rtbDisplay.GetFirstCharIndexOfCurrentLine() + 1] == '.' || (char.IsDigit(rtbDisplay.Text[rtbDisplay.GetFirstCharIndexOfCurrentLine() + 1]) && rtbDisplay.Text[rtbDisplay.GetFirstCharIndexOfCurrentLine() + 2] == '.'))
                            {
                                // Incrementing Number List

                                if (rtbDisplay.Text.Substring(rtbDisplay.GetFirstCharIndexOfCurrentLine()).Length > 3)
                                {
                                    tempNum++;
                                    rtbDisplay.SelectedText = "\r\n" + tempNum.ToString() + ". ";
                                    e.SuppressKeyPress = true;
                                    if (!instructionTxtMenu.Checked)
                                        instructionTxtMenu.Checked = true;

                                }
                                else
                                {
                                    // Removing number from empty line
                                    rtbDisplay.Select(rtbDisplay.GetFirstCharIndexOfCurrentLine() - 1, 3);
                                    rtbDisplay.SelectedText = string.Empty;
                                    if (instructionTxtMenu.Checked)
                                        instructionTxtMenu.Checked = false;
                                    rtbDisplay.SelectionFont = new System.Drawing.Font(rtbDisplay.SelectionFont, System.Drawing.FontStyle.Regular);
                                }
                            }
                        }

                    }
                    catch { }
            }
            #endregion

            catch (Exception errorMsg)
            {
                MessageBox.Show(errorMsg.Message);
            }
        }
    }
}

