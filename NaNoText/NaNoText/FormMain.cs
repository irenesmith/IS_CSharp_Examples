using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace NaNoText
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void cmdOpen_Click(object sender, EventArgs e)
        {
            var response = OpenFileDlg.ShowDialog();
            if (response == DialogResult.OK)
            {
                try
                {
                    var fileName = OpenFileDlg.FileName;

                    // Without the encoding parameter, left-quote, right-quote,
                    // and similar characters are replaced with a symbol indicating
                    // an unknown character.
                    var textIn = File.ReadAllText(fileName, Encoding.Default);

                    rtbNovelText.Text = textIn;
                }
                catch (IOException ex)
                {
                    MessageBox.Show("Sorry, an error occurred when reading the file: " + ex.ToString());
                }
            }
        }

        private void cmdConvert_Click(object sender, EventArgs e)
        {
            var letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZbcdefghijklmnopqrstuvwxyz";
            var novelText = rtbNovelText.Text;
            for (var i=0; i < letters.Length; i++)
            {
                novelText = novelText.Replace(letters[i], 'a');
            }

            rtbNovelText.Text = novelText;
        }

        private void cmdCopy_Click(object sender, EventArgs e)
        {
            rtbNovelText.SelectAll();
            rtbNovelText.Copy();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            var response = SaveFileDlg.ShowDialog();
            if (response == DialogResult.OK)
            {
                try
                {
                    var fileName = SaveFileDlg.FileName;

                    // Not entirely sure that the encoding parameter is required
                    // here but I'm adding it to be on the safe side.
                    File.WriteAllText(fileName, rtbNovelText.Text, Encoding.Default);
                }
                catch (IOException ex)
                {
                    MessageBox.Show("Sorry, an error occurred when writing to the file: " + ex.ToString());
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            var about = new About();
            about.ShowDialog();
        }
    }
}
