namespace Activity_5
{
    partial class activity5
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
            this.openFileButton = new System.Windows.Forms.Button();
            this.textFileDisplay = new System.Windows.Forms.TextBox();
            this.resultsBox = new System.Windows.Forms.Label();
            this.firstWord = new System.Windows.Forms.Button();
            this.lastWord = new System.Windows.Forms.Button();
            this.lowercaseConversion = new System.Windows.Forms.Button();
            this.closeForm = new System.Windows.Forms.Button();
            this.createFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileButton
            // 
            this.openFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openFileButton.Location = new System.Drawing.Point(352, 318);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(123, 78);
            this.openFileButton.TabIndex = 0;
            this.openFileButton.Text = "Open File";
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // textFileDisplay
            // 
            this.textFileDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textFileDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFileDisplay.Location = new System.Drawing.Point(31, 26);
            this.textFileDisplay.Name = "textFileDisplay";
            this.textFileDisplay.Size = new System.Drawing.Size(653, 26);
            this.textFileDisplay.TabIndex = 1;
            // 
            // resultsBox
            // 
            this.resultsBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.resultsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultsBox.Location = new System.Drawing.Point(28, 62);
            this.resultsBox.Name = "resultsBox";
            this.resultsBox.Size = new System.Drawing.Size(288, 334);
            this.resultsBox.TabIndex = 2;
            // 
            // firstWord
            // 
            this.firstWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstWord.Location = new System.Drawing.Point(352, 62);
            this.firstWord.Name = "firstWord";
            this.firstWord.Size = new System.Drawing.Size(123, 78);
            this.firstWord.TabIndex = 3;
            this.firstWord.Text = "First Word";
            this.firstWord.UseVisualStyleBackColor = true;
            this.firstWord.Click += new System.EventHandler(this.firstWord_Click);
            // 
            // lastWord
            // 
            this.lastWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastWord.Location = new System.Drawing.Point(500, 62);
            this.lastWord.Name = "lastWord";
            this.lastWord.Size = new System.Drawing.Size(123, 78);
            this.lastWord.TabIndex = 4;
            this.lastWord.Text = "Last Word";
            this.lastWord.UseVisualStyleBackColor = true;
            this.lastWord.Click += new System.EventHandler(this.button1_Click);
            // 
            // lowercaseConversion
            // 
            this.lowercaseConversion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lowercaseConversion.Location = new System.Drawing.Point(352, 165);
            this.lowercaseConversion.Name = "lowercaseConversion";
            this.lowercaseConversion.Size = new System.Drawing.Size(123, 78);
            this.lowercaseConversion.TabIndex = 5;
            this.lowercaseConversion.Text = "Lower Case";
            this.lowercaseConversion.UseVisualStyleBackColor = true;
            this.lowercaseConversion.Click += new System.EventHandler(this.lowercaseConversion_Click);
            // 
            // closeForm
            // 
            this.closeForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeForm.Location = new System.Drawing.Point(500, 318);
            this.closeForm.Name = "closeForm";
            this.closeForm.Size = new System.Drawing.Size(123, 78);
            this.closeForm.TabIndex = 6;
            this.closeForm.Text = "Close";
            this.closeForm.UseVisualStyleBackColor = true;
            this.closeForm.Click += new System.EventHandler(this.closeForm_Click);
            // 
            // createFile
            // 
            this.createFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createFile.Location = new System.Drawing.Point(500, 165);
            this.createFile.Name = "createFile";
            this.createFile.Size = new System.Drawing.Size(123, 78);
            this.createFile.TabIndex = 8;
            this.createFile.Text = "Create a File";
            this.createFile.UseVisualStyleBackColor = true;
            this.createFile.Click += new System.EventHandler(this.createFile_Click);
            // 
            // activity5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(711, 420);
            this.Controls.Add(this.createFile);
            this.Controls.Add(this.closeForm);
            this.Controls.Add(this.lowercaseConversion);
            this.Controls.Add(this.lastWord);
            this.Controls.Add(this.firstWord);
            this.Controls.Add(this.resultsBox);
            this.Controls.Add(this.textFileDisplay);
            this.Controls.Add(this.openFileButton);
            this.Name = "activity5";
            this.Text = "Activity 6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.TextBox textFileDisplay;
        private System.Windows.Forms.Label resultsBox;
        private System.Windows.Forms.Button firstWord;
        private System.Windows.Forms.Button lastWord;
        private System.Windows.Forms.Button lowercaseConversion;
        private System.Windows.Forms.Button closeForm;
        private System.Windows.Forms.Button createFile;
    }
}

