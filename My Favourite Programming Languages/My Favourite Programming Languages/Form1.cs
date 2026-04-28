namespace My_Favourite_Programming_Languages
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string language = txtLanguage.Text.Trim();

            if (string.IsNullOrWhiteSpace(language))
            {
                MessageBox.Show("Please enter a programming language.");
                return;
            }

            if (lstLanguages.Items.Contains(language))
            {
                MessageBox.Show("Language already exists in the list.");
                return;
            }

            lstLanguages.Items.Add(language);

            lblStatus.Text = $"Added {language} at {DateTime.Now:dd MMM yyyy HH:mm:ss}";

            txtLanguage.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstLanguages.Items.Add("C#");
            lstLanguages.Items.Add("Python");
            lstLanguages.Items.Add("Java");
            lstLanguages.Items.Add("JavaScript");
            lstLanguages.Items.Add("Go");
        }

        private void lstLanguages_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

            if (lstLanguages.SelectedItem == null)
            {
                MessageBox.Show("Please select a language to remove.");
                return;
            }

            string removedLanguage = lstLanguages.SelectedItem.ToString();

            lstLanguages.Items.Remove(removedLanguage);

            lblStatus.Text = $"Removed {removedLanguage} at {DateTime.Now:dd MMM yyyy HH:mm:ss}";
        }
    }
}
