namespace NaNoText
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.OpenFileDlg = new System.Windows.Forms.OpenFileDialog();
            this.rtbNovelText = new System.Windows.Forms.RichTextBox();
            this.cmdCopy = new System.Windows.Forms.Button();
            this.cmdConvert = new System.Windows.Forms.Button();
            this.cmdOpen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Novel Text:";
            // 
            // OpenFileDlg
            // 
            this.OpenFileDlg.DefaultExt = "txt";
            this.OpenFileDlg.FileName = "NaNo2015";
            this.OpenFileDlg.Filter = "Text files|*.txt|All files|*.*";
            this.OpenFileDlg.Title = "Open NaNoWriMo Text";
            // 
            // rtbNovelText
            // 
            this.rtbNovelText.Location = new System.Drawing.Point(12, 65);
            this.rtbNovelText.Name = "rtbNovelText";
            this.rtbNovelText.Size = new System.Drawing.Size(599, 364);
            this.rtbNovelText.TabIndex = 4;
            this.rtbNovelText.Text = "";
            // 
            // cmdCopy
            // 
            this.cmdCopy.Location = new System.Drawing.Point(500, 12);
            this.cmdCopy.Name = "cmdCopy";
            this.cmdCopy.Size = new System.Drawing.Size(111, 23);
            this.cmdCopy.TabIndex = 6;
            this.cmdCopy.Text = "Copy to Clipboard";
            this.cmdCopy.UseVisualStyleBackColor = true;
            this.cmdCopy.Click += new System.EventHandler(this.cmdCopy_Click);
            // 
            // cmdConvert
            // 
            this.cmdConvert.Location = new System.Drawing.Point(383, 12);
            this.cmdConvert.Name = "cmdConvert";
            this.cmdConvert.Size = new System.Drawing.Size(111, 23);
            this.cmdConvert.TabIndex = 5;
            this.cmdConvert.Text = "Convert";
            this.cmdConvert.UseVisualStyleBackColor = true;
            this.cmdConvert.Click += new System.EventHandler(this.cmdConvert_Click);
            // 
            // cmdOpen
            // 
            this.cmdOpen.Location = new System.Drawing.Point(266, 12);
            this.cmdOpen.Name = "cmdOpen";
            this.cmdOpen.Size = new System.Drawing.Size(111, 23);
            this.cmdOpen.TabIndex = 8;
            this.cmdOpen.Text = "Open File";
            this.cmdOpen.UseVisualStyleBackColor = true;
            this.cmdOpen.Click += new System.EventHandler(this.cmdOpen_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.cmdOpen);
            this.Controls.Add(this.cmdCopy);
            this.Controls.Add(this.cmdConvert);
            this.Controls.Add(this.rtbNovelText);
            this.Controls.Add(this.label1);
            this.Name = "FormMain";
            this.Text = "NaNo My Text";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog OpenFileDlg;
        private System.Windows.Forms.RichTextBox rtbNovelText;
        private System.Windows.Forms.Button cmdCopy;
        private System.Windows.Forms.Button cmdConvert;
        private System.Windows.Forms.Button cmdOpen;
    }
}

