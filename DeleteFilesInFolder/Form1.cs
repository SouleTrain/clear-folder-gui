namespace DeleteFilesInFolder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("This application will delete all files and folders in the selected directory. Please use with caution.");
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            if (FolderBrowser.ShowDialog() == DialogResult.OK)
            {
                PathLabel.Text = FolderBrowser.SelectedPath;
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            foreach(string file in Directory.GetFiles(PathLabel.Text))
            {
                File.Delete(file);
            }
            foreach(string folder in Directory.GetDirectories(PathLabel.Text))
            {
                Directory.Delete(folder, true);
            }
            PathLabel.Font = new Font(PathLabel.Font, FontStyle.Strikeout);
            MessageBox.Show("All files and folders in " + PathLabel.Text + " have been deleted.");

        }
    }
}
