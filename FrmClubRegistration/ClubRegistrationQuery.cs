using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace FrmClubRegistration
{
    public class ClubRegistrationQuery
    {
        private SqlConnection sqlConnect;
        private SqlCommand sqlCommand; 
        private SqlDataReader sqlReader;
        private SqlDataAdapter sqlAdapter;
        public DataTable dataTable;
        public BindingSource bindingSource;
        private string connectionString;
        public string _FirstName, _MiddleName, _LastName, _Gender, _Program;
        public int _Age;

        public ClubRegistrationQuery()
        {
            connectionString = "Data Source=LEG-CPU003-003\\SQLEXPRESS;Initial Catalog=ClubDB;Integrated Security=True;Trust Server Certificate=True";
            sqlConnect = new SqlConnection(connectionString);
            dataTable = new DataTable();
            bindingSource = new BindingSource();
        }

        public void DisplayList()
        {

            string ViewClubMembers = "SELECT StudentID, FirstName, MiddleName, LastName, Age, Gender, Program FROM ClubMembers";
            sqlAdapter = new SqlDataAdapter(ViewClubMembers, sqlConnect);
            dataTable.Clear();
            sqlAdapter.Fill(dataTable);
            bindingSource.DataSource = dataTable;
            
        }

        public string[] GetAllStudentID()
        {
            List<string> studID = new List<string>();
            sqlCommand = new SqlCommand("SELECT StudentID FROM ClubMembers", sqlConnect);
            sqlConnect.Open();
            using (sqlReader = sqlCommand.ExecuteReader())
            {
                while (sqlReader.Read())
                {
                    studID.Add(sqlReader[0].ToString());
                }
            }
            sqlConnect.Close();
            return studID.ToArray();
        }

        public bool RegisterStudent(int ID, long StudentID, string FirstName, string MiddleName, string LastName, int Age, string Gender, string Program)
        {
            sqlCommand = new SqlCommand("INSERT INTO ClubMembers VALUES(@ID, @StudentID, @FirstName, @MiddleName, @LastName, @Age, @Gender, @Program)", sqlConnect);
            sqlCommand.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
            sqlCommand.Parameters.Add("@RegistrationID", SqlDbType.BigInt).Value = StudentID;
            sqlCommand.Parameters.Add("@StudentID", SqlDbType.VarChar).Value = StudentID;
            sqlCommand.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = FirstName;
            sqlCommand.Parameters.Add("@MiddleName", SqlDbType.VarChar).Value = MiddleName;
            sqlCommand.Parameters.Add("@LastName", SqlDbType.VarChar).Value = LastName;
            sqlCommand.Parameters.Add("@Age", SqlDbType.Int).Value = Age;
            sqlCommand.Parameters.Add("@Gender", SqlDbType.VarChar).Value = Gender;
            sqlCommand.Parameters.Add("@Program", SqlDbType.VarChar).Value = Program;
            sqlConnect.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnect.Close();
            return true;
        }

        public bool UpdateStudent(int ID, long StudentID, string FirstName, string MiddleName, string LastName, int Age, string Gender, string Program)
        {
            sqlCommand = new SqlCommand("UPDATE ClubMembers SET FirstName = @FirstName, MiddleName = @MiddleName, LastName = @LastName, Age = @Age, Gender = @Gender, Program = @Program WHERE ID = @ID", sqlConnect);
            sqlCommand.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
            sqlCommand.Parameters.Add("@RegistrationID", SqlDbType.BigInt).Value = StudentID;
            sqlCommand.Parameters.Add("@StudentID", SqlDbType.VarChar).Value = StudentID;
            sqlCommand.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = FirstName;
            sqlCommand.Parameters.Add("@MiddleName", SqlDbType.VarChar).Value = MiddleName;
            sqlCommand.Parameters.Add("@LastName", SqlDbType.VarChar).Value = LastName;
            sqlCommand.Parameters.Add("@Age", SqlDbType.Int).Value = Age;
            sqlCommand.Parameters.Add("@Gender", SqlDbType.VarChar).Value = Gender;
            sqlCommand.Parameters.Add("@Program", SqlDbType.VarChar).Value = Program;
            sqlConnect.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnect.Close();
            return true;
        }
    }
}
