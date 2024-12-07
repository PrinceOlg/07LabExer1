namespace FrmClubRegistration
{
    public partial class FrmClubRegistration : Form
    {

        private ClubRegistrationQuery clubRegistrationQuery;
        private int ID, Age, count;
        private string FirstName, MiddleName, LastName, Gender, Program;
        private long StudentId;
        public FrmClubRegistration()
        {
            InitializeComponent();
            clubRegistrationQuery = new ClubRegistrationQuery();
            cbProgram.SelectedIndex = 0;
            cbGender.SelectedIndex = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RefreshListOfClubMembers();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                StudentId = Convert.ToInt64(txtStudID.Text);
                FirstName = txtFirstName.Text;
                MiddleName = txtMiddleName.Text;
                LastName = txtLastName.Text;
                Age = Convert.ToInt32(txtAge.Text);
                Gender = cbGender.SelectedItem.ToString();
                Program = cbProgram.SelectedItem.ToString();
                clubRegistrationQuery.RegisterStudent(RegistrationID(), StudentId, FirstName, MiddleName, LastName, Age, Gender, Program);
                RefreshListOfClubMembers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Missing input.");
            }
        }

        private void RefreshListOfClubMembers()
        {
            clubRegistrationQuery.DisplayList();
            dataGridView1.DataSource = clubRegistrationQuery.bindingSource;
            count = clubRegistrationQuery.dataTable.Rows.Count;
        }

        private void FrmClubRegistration_Load(object sender, EventArgs e)
        {
            RefreshListOfClubMembers();
        }

        private int RegistrationID()
        {
            count++;
            return count;
        }

        private void txtStudID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmUpdateMember test = new FrmUpdateMember(clubRegistrationQuery);
            test.ShowDialog();
            RefreshListOfClubMembers();
        }
    }
}
