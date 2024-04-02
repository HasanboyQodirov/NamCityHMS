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
    public partial class frmDoctorInfoFull : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\NamCityDatabase.mdf;Integrated Security=True;Connect Timeout=30";

        public frmDoctorInfoFull()
        {
            InitializeComponent();
        }

        private void frmDoctorInfoFull_Load(object sender, EventArgs e)
        {
            searchusername.Text = Properties.Settings.Default.DoctorUsername;
            Properties.Settings.Default.DoctorUsername = null;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void searchusername_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                sqlcon.Open();

                SqlCommand cmd = new SqlCommand("select * from Doctors where username=@user", sqlcon);
                cmd.Parameters.AddWithValue("@user", searchusername.Text);
                SqlDataReader da = cmd.ExecuteReader();
                while (da.Read())
                {
                    doctor_nameTextBox.Text = da.GetValue(1).ToString();
                    doctor_surnameTextBox.Text = da.GetValue(2).ToString();
                    DoctorDepartmentTextBox.Text = da.GetValue(3).ToString();
                    addressTextBox.Text = da.GetValue(4).ToString();
                    phoneTextBox.Text = da.GetValue(5).ToString();
                    e_mailTextBox.Text = da.GetValue(6).ToString();
                    passwordTextBox.Text = da.GetValue(7).ToString();
                    ssnTxtBox.Text = da.GetValue(8).ToString();
                    gendercombo.Text = da.GetValue(9).ToString();
                }

                sqlcon.Close();
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                sqlcon.Open();

                SqlCommand cmd = new SqlCommand("update Doctors set firstname=@firstname, lastname=@lastname, address=@address, department=@department, phone=@phone, email=@email, password=@password, ssn=@ssn, gender=@gender  where username=@user", sqlcon);
                cmd.Parameters.AddWithValue("@user", searchusername.Text);
                cmd.Parameters.AddWithValue("@firstname", doctor_nameTextBox.Text);
                cmd.Parameters.AddWithValue("@lastname", doctor_surnameTextBox.Text);
                cmd.Parameters.AddWithValue("@address", addressTextBox.Text);
                cmd.Parameters.AddWithValue("@department", DoctorDepartmentTextBox.Text);
                cmd.Parameters.AddWithValue("@phone", phoneTextBox.Text);
                cmd.Parameters.AddWithValue("@email", e_mailTextBox.Text);
                cmd.Parameters.AddWithValue("@password", passwordTextBox.Text);
                cmd.Parameters.AddWithValue("@ssn", ssnTxtBox.Text);
                cmd.Parameters.AddWithValue("@gender", gendercombo.Text);
                cmd.ExecuteNonQuery();
                

                sqlcon.Close();
                MessageBox.Show("Successfully saved");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult choice = MessageBox.Show("Are you sure you want to delete doctor information?\nYou cannot restore it after it has been deleted from database.", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (choice == DialogResult.Yes)
            {
                using (SqlConnection sqlcon = new SqlConnection(connectionString))
                {
                    sqlcon.Open();

                    SqlCommand cmd = new SqlCommand("delete from Doctors  where username=@user", sqlcon);
                    cmd.Parameters.AddWithValue("@user", searchusername.Text);
                    cmd.ExecuteNonQuery();


                    sqlcon.Close();
                    MessageBox.Show("Successfully removed from database");
                }
            }
            if (choice == DialogResult.No)
            {

            }

        }
    }
}
