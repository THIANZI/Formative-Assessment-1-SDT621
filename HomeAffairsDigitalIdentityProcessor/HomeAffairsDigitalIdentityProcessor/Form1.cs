namespace HomeAffairsDigitalIdentityProcessor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int GetAgeFromID(string id)
        {
            if (id.Length < 6)
                throw new Exception("Invalid ID");

            string year = id.Substring(0, 2);
            string month = id.Substring(2, 2);
            string day = id.Substring(4, 2);

            int fullYear = int.Parse(year);

            fullYear += (fullYear > DateTime.Now.Year % 100) ? 1900 : 2000;

            DateTime dob = new DateTime(fullYear, int.Parse(month), int.Parse(day));

            int age = DateTime.Now.Year - dob.Year;

            if (DateTime.Now < dob.AddYears(age))
                age--;

            return age;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbCitizen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtName.Text;
                string id = txtID.Text;
                string citizen = cmbCitizen.Text;

                int age = GetAgeFromID(id);

                lblResult.Text = $"Valid ID. Citizen is {age} years old.";

                txtSummary.Text =
                    "==== DIGITAL CITIZEN SUMMARY ====\r\n" +
                    $"Name: {name}\r\n" +
                    $"ID Number: {id}\r\n" +
                    $"Age: {age}\r\n" +
                    $"Citizenship: {citizen}\r\n" +
                    $"Validation: Valid ID. Citizen is {age} years old.\r\n" +
                    $"Processed at: Home Affairs Digital Desk\r\n" +
                    $"Timestamp: {DateTime.Now}";
            }
            catch
            {
                lblResult.Text = "Invalid ID number!";
            }
        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }

        private void txtSummary_Enter(object sender, EventArgs e)
        {

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtSummary.Text, "Citizen Profile");
        }
    }
}
