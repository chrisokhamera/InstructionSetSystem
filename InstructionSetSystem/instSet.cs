using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstructionSetSystem
{
    public interface IInstructionModel
    {
        void Save(RichTextBox rtb);
        string Open();
        //void Add(TextBox txtBox);
        void LegalTextBlock(RichTextBox rtb, ToolStripMenuItem mnuItem);
        void InstructionTextBlock(RichTextBox rtb, ToolStripMenuItem mnuItem);
    }

    public class InstructionSetComponent : IInstructionModel
    {
        #region Save
        public void Save(RichTextBox rtb)
        {
            try
            {
             
                SaveFileDialog SaveFile = new SaveFileDialog();
                SaveFile.DefaultExt = "*.rtf";
                SaveFile.Filter = "RTF Files|*.rtf";
                if (SaveFile.ShowDialog() == DialogResult.OK && SaveFile.FileName.Length > 0)
                {
                    rtb.SaveFile(SaveFile.FileName, RichTextBoxStreamType.RichText);
                }
            }
            catch
            {
                throw;
            }
        }
        #endregion

        #region Open
        public string Open()
        {
            try
            {
                OpenFileDialog OpenFile = new OpenFileDialog();
                OpenFile.DefaultExt = "*.rtf";
                OpenFile.Filter = "RTF Files|*.rtf";
                if (OpenFile.ShowDialog() == DialogResult.OK && OpenFile.FileName.Length > 0)
                {
                    return OpenFile.FileName;
                }
                else
                {
                    throw new Exception("File Not Found");
                }
            }
            catch (Exception errorMsg)
            {
                return errorMsg.ToString();
            }
        }
        #endregion

        #region LegalTextBlock
        public void LegalTextBlock(RichTextBox rtb, ToolStripMenuItem mnuItem)
        {
            try
            {
                if (mnuItem.Checked)
                {
                    rtb.SelectionFont = new System.Drawing.Font(rtb.SelectionFont, System.Drawing.FontStyle.Italic);
                    int SelectionStart = rtb.SelectionStart;
                    int SelectionLength = rtb.SelectionLength;
                    rtb.SelectionStart = rtb.GetFirstCharIndexOfCurrentLine();
                    rtb.SelectionLength = 0;
                    int j = 2;
                    for (int i = SelectionStart; i < SelectionStart + SelectionLength; i++)
                        if (rtb.Text[i] == '\n')
                        {
                            rtb.SelectionStart = i + 1;
                            rtb.SelectionLength = 0;
                            rtb.SelectedText = j.ToString() + ". ";
                            j++;
                            SelectionLength += 3;
                        }
                }
                else
                {
                    rtb.SelectionFont = new System.Drawing.Font(rtb.SelectionFont, System.Drawing.FontStyle.Italic);
                }
            }
            catch
            {
                throw;
            }
        }
        #endregion

        #region InstructionTextBlock
        public void InstructionTextBlock(RichTextBox rtb, ToolStripMenuItem mnuItem)
        {
            try
            {
                if (mnuItem.Checked)
                {
                    rtb.SelectionFont = new System.Drawing.Font(rtb.SelectionFont, System.Drawing.FontStyle.Bold);

                    // Inserting number 1 at the beginging of the line
                    int SelectionStart = rtb.SelectionStart;
                    int SelectionLength = rtb.SelectionLength;

                    rtb.SelectionStart = rtb.GetFirstCharIndexOfCurrentLine();
                    rtb.SelectionLength = 0;
                    rtb.SelectedText = "1. ";

                    int j = 2;
                    for (int i = SelectionStart; i < SelectionStart + SelectionLength; i++)
                        if (rtb.Text[i] == '\n')
                        {
                            rtb.SelectionStart = i + 1;
                            rtb.SelectionLength = 0;
                            rtb.SelectedText = j.ToString() + ". ";
                            j++;
                            SelectionLength += 3;
                        }
                }
                else
                {
                    rtb.SelectionFont = new System.Drawing.Font(rtb.SelectionFont, System.Drawing.FontStyle.Regular);
                }
            }
            catch
            {
                throw;
            }
        }
        #endregion
    }

    public abstract class TextBlockDecorator : IInstructionModel
    {
        private IInstructionModel _iComponentModel;

        public TextBlockDecorator(IInstructionModel ComponentModel)
        {
            _iComponentModel = ComponentModel;
        }
        public void Save(RichTextBox rtb)
        {
            this._iComponentModel.Save(rtb);
        }

        public string Open()
        {
            return this._iComponentModel.Open();
        }

        public void LegalTextBlock(RichTextBox rtb, ToolStripMenuItem mnuItem)
        {
            this._iComponentModel.LegalTextBlock(rtb, mnuItem);
        }

        public void InstructionTextBlock(RichTextBox rtb, ToolStripMenuItem mnuItem)
        {
            this._iComponentModel.InstructionTextBlock(rtb, mnuItem);
        }
    }

    public class ExtendedTextBlock : TextBlockDecorator
    {
        public ExtendedTextBlock(IInstructionModel _iComponentModel) : base(_iComponentModel) { }

        public void ForegroundColor(RichTextBox rtb, ToolStripMenuItem mnuItem)
        {
            rtb.SelectionColor = mnuItem.Checked ? System.Drawing.Color.Blue : System.Drawing.Color.Black;
        }

        public void BackgroundColor(RichTextBox rtb, ToolStripMenuItem mnuItem)
        {
            rtb.SelectionBackColor = mnuItem.Checked ? System.Drawing.Color.DarkOrange : System.Drawing.Color.White;
        }

        public void UnderlineText(RichTextBox rtb, ToolStripMenuItem mnuItem)
        {
            rtb.SelectionFont = mnuItem.Checked ? new System.Drawing.Font(rtb.SelectionFont, System.Drawing.FontStyle.Underline) : new System.Drawing.Font(rtb.SelectionFont, System.Drawing.FontStyle.Regular);
        }
        public void DoubleUnderlineText(RichTextBox rtb, ToolStripMenuItem mnuItem)
        {
            rtb.SelectionFont = mnuItem.Checked ? new System.Drawing.Font(rtb.SelectionFont, System.Drawing.FontStyle.Underline) : new System.Drawing.Font(rtb.SelectionFont, System.Drawing.FontStyle.Underline);
        }
    }
}
