using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; // to use File.WriteAllText

namespace blocNotes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // __________________________________________________________________
        private void save_Click(object sender, EventArgs e)
        {
            var di = new SaveFileDialog(); // var to save something
            di.Filter = "Text Files|*.txt"; // type of the file
            di.FileName = "myFile"; // default FileName
            var confimSaving =di.ShowDialog();
            if (confimSaving == DialogResult.OK)
            {
                File.WriteAllText(di.FileName, richTextBox1.Text);
            }


        }

        private void upload_Click(object sender, EventArgs e)
        {
            var di = new OpenFileDialog(); // Open a txt file 
            di.Filter = "Text Files|*.txt"; // type of the file
            var confimSaving = di.ShowDialog();
            if (confimSaving == DialogResult.OK)
            {
                richTextBox1.Text=File.ReadAllText(di.FileName);
            }
        }
        // __________________________________________________________________
        private void copy_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.Clear();
                Clipboard.SetText(richTextBox1.Text);
            }
            catch
            {

            }
            
        }

        private void paste_Click(object sender, EventArgs e)
        {
            try
            {
              richTextBox1.Text= richTextBox1.Text+Clipboard.GetText();

            }
            catch
            {

            }
        }

        private void cut_Click(object sender, EventArgs e)
        {
            try
            {
                 Clipboard.Clear();
                 Clipboard.SetText(richTextBox1.Text);
                 richTextBox1.Text = "";
            }
            catch
            {

            }
            
        }
        // __________________________________________________________________
        private void print_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(richTextBox1.Text, richTextBox1.Font, Brushes.Blue, new Point(100,100) );
        }
        // __________________________________________________________________
        private void font_Click(object sender, EventArgs e)
        {
            var difont = new FontDialog();
            var confirmFont = difont.ShowDialog();
            if (confirmFont==DialogResult.OK)
            {
                richTextBox1.Font= difont.Font;
                
            }
        }

        private void bold_Click(object sender, EventArgs e)
        {
            richTextBox1.Font=new Font(richTextBox1.Font,FontStyle.Bold);
        }

        private void underline_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(richTextBox1.Font, FontStyle.Underline);

        }
        // __________________________________________________________________

        private void alignLeft_Click(object sender, EventArgs e)
        {
            richTextBox1.RightToLeft= RightToLeft.No;
        }

        private void alignRight_Click(object sender, EventArgs e)
        {
            richTextBox1.RightToLeft = RightToLeft.Yes;
        }
        // __________________________________________________________________

        private void bgColor_Click(object sender, EventArgs e)
        {
            var bgColor = new ColorDialog();
            var confirm = bgColor.ShowDialog();
            if (confirm==DialogResult.OK)
            {
                richTextBox1.BackColor = bgColor.Color;
            }
        }
        // __________________________________________________________________

        private void erase_Click(object sender, EventArgs e)
        {
            richTextBox1.Text= string.Empty;
        }
        // __________________________________________________________________

        private void bunifuSlider1_ValueChanged(object sender, EventArgs e)
        {
            // to not get error if zoom is equal to 0
            try
            {
                richTextBox1.ZoomFactor = bunifuSlider1.Value;
            }
            catch
            {

            }
        }
    }
}
