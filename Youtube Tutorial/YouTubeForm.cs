using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Youtube_Tutorial
{
    public partial class YouTubeForm : Form
    {
        public YouTubeForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Menu File Option Clicked!";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // this closes the application with all subforms open
            Application.Exit();
            //this would only close subform if multiple are loaded
            //this.close();
        }

        private void printTextButton_Click(object sender, EventArgs e)
        {
            if (printTextButton.Text == "Reset")
            {
                if (outputTextField.Text != "")
                {
                    outputTextField.Text = "";
                    printedText.Text = "";
                    printedText.Visible = false;
                    printTextButton.Text = "Print Text";
                }
            }

            if (printTextButton.Text == "Print Text")
            {
                if (outputTextField.Text == "")
                {
                    printedText.Text = "";
                    printedText.Visible = false;
                }
                else
                {
                    printedText.Text = outputTextField.Text.ToString();
                    printedText.Visible = true;
                    printTextButton.Text = "Reset";
                }
            }

        }

        private void printMessageButton_Click(object sender, EventArgs e)
        {
            if (outputTextField.Text == "")
            {
                // Do nothing
            }
            else
            {
                MessageBox.Show("You typed: " + outputTextField.Text.ToString() );
            }
        }

        private void checkMyCheckboxButton_Click(object sender, EventArgs e)
        {
            if (basicCheckbox.Checked == true)
            {
                toolStripStatusLabel1.Text = "The checkbox is checked!";
            }
            else
            {
                toolStripStatusLabel1.Text = "The checkbox is not checked!";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void submitComboBoxButton_Click(object sender, EventArgs e)
        {
            if (favoriteIPhoneCombo.Text == "")
            {
                MessageBox.Show("Please select your favorite iPhone from the dropdownlist above.Thanks!");
            }
            else
            {
                if (favoriteIPhoneCombo.Text == "What is your favorite iPhone?")
                {
                    MessageBox.Show("Please select your favorite iPhone from the dropdownlist above.Thanks!");
                }
                else
                {
                    MessageBox.Show("Your favorite iPhone is: " + favoriteIPhoneCombo.Text + "!");
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void amIHappyRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(amIHappyRadioButton1.Checked == true)
            {
                MessageBox.Show("Great, I am glad we had fun together!");
            }
            else
            {
                MessageBox.Show("Oh no! Try again and don't give up into; you are happpy!");
            }
        }
    }
}
