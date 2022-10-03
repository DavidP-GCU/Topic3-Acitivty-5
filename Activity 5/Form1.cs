using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_5
{
    public partial class activity5 : Form
    {
        public activity5()
        {
            InitializeComponent();
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            //Create file object in memory
            OpenFileDialog userfile = new OpenFileDialog();

            
            // Showdialog opens file explorer and tells the code what to do with it
            if (userfile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //Open and display the file
                textFileDisplay.Text = File.ReadAllText(userfile.FileName);

            }
            else
            {
                MessageBox.Show("Goodbye");
                Close();
            }
          

        }

        private void button1_Click(object sender, EventArgs e) //This is the lastWord Event handler
            //Don't know why it stayed at "button_1Click"
        {
            //Get Last Word of textFileDisplay
            //Create string variable
            string lastword;
            lastword = textFileDisplay.Text.Substring(63);//Get substring from text inside textFileDisplay.
            resultsBox.Text = lastword;//Display results.
        }

        private void firstWord_Click(object sender, EventArgs e)
        {
            //Get First Word of textFileDisplay
            //Create string variable
            string firstword;
            firstword = textFileDisplay.Text.Substring(0, 4);//Get substring from text inside textFileDisplay.
            resultsBox.Text = firstword;//Display results. 
        }

        private void lowercaseConversion_Click(object sender, EventArgs e)
        {
            //Convert sentence to lower case
            //Create string variable
            string lowercase;
            lowercase = textFileDisplay.Text.ToLower();//Convert sentence to lower case using ToLower() method
            resultsBox.Text = lowercase;//Display results.
        }

        private void closeForm_Click(object sender, EventArgs e)
        {
            Close();//Close the application. 
        }

        private void longestWord_Click(object sender, EventArgs e) //If I delete this my code won't work at all. 
        {
           
        }

        private void createFile_Click(object sender, EventArgs e)//Create file using StreamWriter
        {
            StreamWriter outputFile;//Create streamwriter variable
            outputFile = File.CreateText("NewFile.txt"); //Creates File
            
            //Tells the computer what to output onto the file being created
            outputFile.WriteLine("The");
            outputFile.WriteLine("dreams");
            outputFile.WriteLine("the future belongs to those who believe in the beauty of their dreams");

            //Close File
            outputFile.Close();

        }

        private void displayText_Click(object sender, EventArgs e) // If I delete this my code won't work at all. 
        {

        }
    }
}
