using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmClubRegistration
{
    public partial class FrmUpdateMember : Form
    {
        private ClubRegistrationQuery query;
        private List<DataRowCollection> members;
        private int idTable;
        public FrmUpdateMember(ClubRegistrationQuery q)
        {
            InitializeComponent();
            query = q;
            cbProgram.SelectedIndex = 0;
            cbGender.SelectedIndex = 0;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            query.UpdateStudent(idTable, Convert.ToInt64(cbStudentID.SelectedItem), txtFirstName.Text, txtMiddleName.Text, txtLastName.Text, Convert.ToInt32(txtAge.Text), cbGender.SelectedItem.ToString(), cbProgram.SelectedItem.ToString());
            Close();
        }

        private void FrmUpdateMember_Load(object sender, EventArgs e)
        {
            List<string> studentIds = new List<string>();
            for (int i = 0; i < query.dataTable.Rows.Count; i++)
            {
                studentIds.Add(query.dataTable.Rows[i][0].ToString());
            }
            cbStudentID.Items.AddRange(studentIds.ToArray());
            cbStudentID.SelectedIndex = 0;
            idTable = Convert.ToInt32(query.dataTable.Rows[0][0]);
            txtFirstName.Text = query.dataTable.Rows[0][1].ToString();
            txtMiddleName.Text = query.dataTable.Rows[0][2].ToString();
            txtLastName.Text = query.dataTable.Rows[0][3].ToString();
            txtAge.Text = query.dataTable.Rows[0][4].ToString();
            cbGender.SelectedItem = query.dataTable.Rows[0][5].ToString();
            cbProgram.SelectedItem = query.dataTable.Rows[0][6].ToString();
        }

        private void cbStudentID_SelectedIndexChanged(object sender, EventArgs e)
        {
            int test = cbStudentID.SelectedIndex;
            idTable = Convert.ToInt32(query.dataTable.Rows[test][0]);
            txtFirstName.Text = query.dataTable.Rows[test][1].ToString();
            txtMiddleName.Text = query.dataTable.Rows[test][2].ToString();
            txtLastName.Text = query.dataTable.Rows[test][3].ToString();
            txtAge.Text = query.dataTable.Rows[test][4].ToString();
            cbGender.SelectedItem = query.dataTable.Rows[test][5].ToString();
            cbProgram.SelectedItem = query.dataTable.Rows[test][6].ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
