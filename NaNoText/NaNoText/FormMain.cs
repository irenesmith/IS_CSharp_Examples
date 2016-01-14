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
                    rtbNovelText.Text = File.ReadAllText(fileName);
                }
                catch(IOException ex)
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
    }
}
