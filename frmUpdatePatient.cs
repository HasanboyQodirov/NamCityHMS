using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace HospitalManagementSystem
{
    public partial class frmUpdatePatient : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\NamCityDatabase.mdf;Integrated Security=True;Connect Timeout=30";

        public frmUpdatePatient()
        {
            InitializeComponent();
        }

        private void searchssnTextBox_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                sqlcon.Open();

                SqlCommand cmd = new SqlCommand("select * from Patients where ssn=@ssn", sqlcon);
                cmd.Parameters.AddWithValue("@ssn", searchssnTextBox.Text);
                SqlDataReader da = cmd.ExecuteReader();
                while (da.Read())
                {

                    ssnTextBox1.Text = da.GetValue(3).ToString();
                    firstnametxt.Text = da.GetValue(0).ToString();
                    lastnametxt.Text = da.GetValue(1).ToString();
                    gendercombo.Text = da.GetValue(2).ToString();
                    birth_dateDateTimePicker.Text = da.GetValue(4).ToString();
                    inspectionDateTimePicker.Text = da.GetValue(9).ToString();
                    complaintTextBox.Text = da.GetValue(10).ToString();
                    diagnosisTextBox.Text = da.GetValue(16).ToString();
                    prescriptionTextBox.Text = da.GetValue(17).ToString();

                    birth_placeTextBox.Text = da.GetValue(5).ToString();
                    father_nameTextBox.Text = da.GetValue(6).ToString();
                    phoneTextBox.Text = da.GetValue(7).ToString();
                    addressTextBox.Text = da.GetValue(8).ToString();
                    departmenttxt.Text = da.GetValue(11).ToString();
                    doctortxt.Text = da.GetValue(12).ToString();

                    bloodtxt.Text = da.GetValue(13).ToString();
                    urintxt.Text = da.GetValue(14).ToString();
                    xraytxt.Text = da.GetValue(15).ToString();

                }
                sqlcon.Close();

            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                string birthdate = birth_dateDateTimePicker.Text;
                string inspection = inspectionDateTimePicker.Text;

                sqlcon.Open();

                SqlCommand cmd = new SqlCommand("update Patients set firstname=@firstname, lastname=@lastname, ssn=@ssnnew, gender=@gender, birthdate=@birthdate, birthplace=@birthplace, fathername=@fathername, phone=@phone, address=@address, inspectiondate=@inspectiondate, department=@department, doctor=@doctor, complaint=@complaint, diagnosis=@diagnosis, prescription=@prescription, bloodanalysis=@blood, urinanalysis=@urin, xray=@xray  where ssn=@ssn", sqlcon);

                cmd.Parameters.AddWithValue("@blood", bloodtxt.Text);
                cmd.Parameters.AddWithValue("@urin", urintxt.Text);
                cmd.Parameters.AddWithValue("@xray", xraytxt.Text);

                cmd.Parameters.AddWithValue("@ssn", searchssnTextBox.Text);
                cmd.Parameters.AddWithValue("@ssnnew", ssnTextBox1.Text);

                cmd.Parameters.AddWithValue("@complaint", complaintTextBox.Text);
                cmd.Parameters.AddWithValue("@diagnosis", diagnosisTextBox.Text);
                cmd.Parameters.AddWithValue("@prescription", prescriptionTextBox.Text);
                

                cmd.Parameters.AddWithValue("@firstname", firstnametxt.Text);
                cmd.Parameters.AddWithValue("@lastname", lastnametxt.Text);
                cmd.Parameters.AddWithValue("@gender", gendercombo.Text);
                cmd.Parameters.AddWithValue("@birthdate", birthdate);
                cmd.Parameters.AddWithValue("@inspectiondate", inspection);
                cmd.Parameters.AddWithValue("@birthplace", birth_placeTextBox.Text);
                cmd.Parameters.AddWithValue("@fathername", father_nameTextBox.Text);
                cmd.Parameters.AddWithValue("@phone", phoneTextBox.Text);
                cmd.Parameters.AddWithValue("@address", addressTextBox.Text);
                cmd.Parameters.AddWithValue("@department", departmenttxt.Text);
                cmd.Parameters.AddWithValue("@doctor", doctortxt.Text);



                cmd.ExecuteNonQuery();

                sqlcon.Close();
                MessageBox.Show("Successfully saved patient information");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult choice = MessageBox.Show("Are you sure you want to delete patient information?\nYou cannot restore it after it has been deleted from database.", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (choice == DialogResult.Yes)
            {
                using (SqlConnection sqlcon = new SqlConnection(connectionString))
                {
                    sqlcon.Open();

                    SqlCommand cmd = new SqlCommand("delete from Patients where ssn=@ssn", sqlcon);
                    cmd.Parameters.AddWithValue("@ssn", searchssnTextBox.Text);
                    cmd.ExecuteNonQuery();


                    sqlcon.Close();
                    MessageBox.Show("Successfully removed from database");
                }
            }
            if (choice == DialogResult.No)
            {

            }
        }

        private void frmUpdatePatient_Load(object sender, EventArgs e)
        {
            searchssnTextBox.Text = Properties.Settings.Default.PatientSSN;
            Properties.Settings.Default.PatientSSN = null;
        }
    }
}
