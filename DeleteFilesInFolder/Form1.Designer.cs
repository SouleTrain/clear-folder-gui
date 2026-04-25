namespace DeleteFilesInFolder
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            FolderBrowser = new FolderBrowserDialog();
            browseButton = new Button();
            DeleteButton = new Button();
            PathLabel = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // FolderBrowser
            // 
            FolderBrowser.Multiselect = true;
            FolderBrowser.SelectedPath = "C:\\";
            FolderBrowser.ShowHiddenFiles = true;
            FolderBrowser.UseDescriptionForTitle = true;
            // 
            // browseButton
            // 
            browseButton.Location = new Point(21, 308);
            browseButton.Name = "browseButton";
            browseButton.Size = new Size(200, 40);
            browseButton.TabIndex = 0;
            browseButton.Text = "Browse";
            browseButton.UseVisualStyleBackColor = true;
            browseButton.Click += browseButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(239, 308);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(200, 40);
            DeleteButton.TabIndex = 1;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // PathLabel
            // 
            PathLabel.Location = new Point(21, 149);
            PathLabel.Name = "PathLabel";
            PathLabel.Size = new Size(420, 133);
            PathLabel.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 41);
            label1.Name = "label1";
            label1.Size = new Size(318, 90);
            label1.TabIndex = 3;
            label1.Text = "Click \"Browse\" to choose a folder\r\n\r\n                  Folder :\r\n";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 370);
            Controls.Add(label1);
            Controls.Add(PathLabel);
            Controls.Add(DeleteButton);
            Controls.Add(browseButton);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clear Folder";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FolderBrowserDialog FolderBrowser;
        private Button browseButton;
        private Button DeleteButton;
        private Label PathLabel;
        private Label label1;
    }
}
