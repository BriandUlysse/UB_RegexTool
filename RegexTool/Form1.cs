using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegexTool
{
    public partial class Form1 : Form
    {
        private Regex regex;
        private MatchCollection matchCollection;
        private int countMatchs = 0;
        private bool haveBeenParsed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void parse()
        {
            try
            {
                this.regex = new Regex(rtxtBxRegex.Text, RegexOptions.Compiled);
            }
            catch (Exception ex)
            {

            }
        }

        private void rtxtBxRegex_TextChanged(object sender, EventArgs e)
        {
            if (chkBxAutoMatch.Checked)
            {
                parse();
                searchInInput();
                haveBeenParsed = true;
            }
            else
            {
                haveBeenParsed = false;
            }
        }

        private void rTxtBxInput_TextChanged(object sender, EventArgs e)
        {
            if (chkBxAutoMatch.Checked)
            {
                parse();
                searchInInput();
                haveBeenParsed = true;
            }
            else
            {
                haveBeenParsed = false;
            }
        }

        private void searchInInput()
        {
            if (this.regex!=null && this.regex.ToString().Length > 0)
            {
                this.matchCollection = this.regex.Matches(rTxtBxInput.Text);
                this.countMatchs = this.matchCollection.Count;
                refreshDisplay();
            }
        }

        private void refreshDisplay()
        {
            lblCount.Text = this.countMatchs.ToString();
            int index = rTxtBxInput.SelectionStart;
            
            rTxtBxInput.SelectionStart = 0;
            rTxtBxInput.SelectionLength = rTxtBxInput.TextLength;
            rTxtBxInput.SelectionBackColor = Color.White;
            if (this.matchCollection.Count< 5000)
            {
                for (int i = 0; i < this.matchCollection.Count; i++)
                {
                    rTxtBxInput.SelectionStart = this.matchCollection[i].Index;
                    rTxtBxInput.SelectionLength = this.matchCollection[i].Length;

                    rTxtBxInput.SelectionBackColor = Color.Yellow;

                    rTxtBxInput.SelectionLength = 0;
                }

                rTxtBxInput.SelectionStart = index;
            }
            
        }

        private void btnMatch_Click(object sender, EventArgs e)
        {
            if (!haveBeenParsed)
            {
                parse();
                haveBeenParsed = true;
                searchInInput();
            }
            String outputPattern = rTbxPattern.Text;
            String orederedRes = "";
            String replacementText = rTxtBxInput.Text;
            int decal = 0;

            if (this.matchCollection != null &&this.matchCollection.Count < 5000)
            {
                for (int i = 0; i < this.matchCollection.Count; i++)
                {
                    Match currentMatchValue = this.matchCollection[i];
                    String currentLine = rTbxPattern.Text;

                    for (int j = currentMatchValue.Groups.Count - 1; j >= 0; j--)
                    {
                        Group currentGroup = currentMatchValue.Groups[j];
                        String key = "$" + j;

                        currentLine = currentLine.Replace(key, currentGroup.Value);
                        
                    }

                    int begin = currentMatchValue.Index + decal;
                    int length = currentMatchValue.Value.Length;
                    decal += currentLine.Length - currentMatchValue.Value.Length;

                    replacementText = replacementText.Remove(begin, length);
                    replacementText = replacementText.Insert(begin, currentLine);

                    orederedRes += currentLine + "\n";
                }
            }
            rTxtBxReplace.Text = replacementText;
            rTxtBxExtract.Text = orederedRes;
        }
    }
}
