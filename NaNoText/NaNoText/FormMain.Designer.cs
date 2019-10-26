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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.label1 = new System.Windows.Forms.Label();
            this.OpenFileDlg = new System.Windows.Forms.OpenFileDialog();
            this.rtbNovelText = new System.Windows.Forms.RichTextBox();
            this.cmdCopy = new System.Windows.Forms.Button();
            this.cmdConvert = new System.Windows.Forms.Button();
            this.cmdOpen = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
            this.SaveFileDlg = new System.Windows.Forms.SaveFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
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
            this.rtbNovelText.Location = new System.Drawing.Point(14, 80);
            this.rtbNovelText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtbNovelText.Name = "rtbNovelText";
            this.rtbNovelText.Size = new System.Drawing.Size(598, 348);
            this.rtbNovelText.TabIndex = 4;
            this.rtbNovelText.Text = "";
            // 
            // cmdCopy
            // 
            this.cmdCopy.Location = new System.Drawing.Point(472, 15);
            this.cmdCopy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmdCopy.Name = "cmdCopy";
            this.cmdCopy.Size = new System.Drawing.Size(129, 28);
            this.cmdCopy.TabIndex = 6;
            this.cmdCopy.Text = "Copy to Clipboard";
            this.cmdCopy.UseVisualStyleBackColor = true;
            this.cmdCopy.Click += new System.EventHandler(this.cmdCopy_Click);
            // 
            // cmdConvert
            // 
            this.cmdConvert.Location = new System.Drawing.Point(214, 15);
            this.cmdConvert.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmdConvert.Name = "cmdConvert";
            this.cmdConvert.Size = new System.Drawing.Size(129, 28);
            this.cmdConvert.TabIndex = 5;
            this.cmdConvert.Text = "Convert";
            this.cmdConvert.UseVisualStyleBackColor = true;
            this.cmdConvert.Click += new System.EventHandler(this.cmdConvert_Click);
            // 
            // cmdOpen
            // 
            this.cmdOpen.Location = new System.Drawing.Point(85, 15);
            this.cmdOpen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmdOpen.Name = "cmdOpen";
            this.cmdOpen.Size = new System.Drawing.Size(129, 28);
            this.cmdOpen.TabIndex = 8;
            this.cmdOpen.Text = "Open File";
            this.cmdOpen.UseVisualStyleBackColor = true;
            this.cmdOpen.Click += new System.EventHandler(this.cmdOpen_Click);
            // 
            // cmdSave
            // 
            this.cmdSave.Location = new System.Drawing.Point(343, 15);
            this.cmdSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(129, 28);
            this.cmdSave.TabIndex = 9;
            this.cmdSave.Text = "Save as Text";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // SaveFileDlg
            // 
            this.SaveFileDlg.Filter = "\"Text files|*.txt\"";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(601, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 22);
            this.label2.TabIndex = 10;
            this.label2.Text = "?";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.cmdOpen);
            this.Controls.Add(this.cmdCopy);
            this.Controls.Add(this.cmdConvert);
            this.Controls.Add(this.rtbNovelText);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.SaveFileDialog SaveFileDlg;
        private System.Windows.Forms.Label label2;
    }
}

