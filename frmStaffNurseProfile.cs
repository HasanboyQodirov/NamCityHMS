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
    public partial class frmStaffNurseProfile : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\NamCityDatabase.mdf;Integrated Security=True;Connect Timeout=30";

        public frmStaffNurseProfile()
        {
            InitializeComponent();
        }

        private void searchusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            DialogResult choice = MessageBox.Show("Are you sure you want to delete your profile?\nYou cannot restore it after it has been deleted from database.", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (choice == DialogResult.Yes)
            {
                using (SqlConnection sqlcon = new SqlConnection(connectionString))
                {
                    sqlcon.Open();

                    SqlCommand cmd = new SqlCommand("delete from Staff  where username=@user", sqlcon);
                    cmd.Parameters.AddWithValue("@user", Properties.Settings.Default.Username);
                    cmd.ExecuteNonQuery();


                    sqlcon.Close();
                    MessageBox.Show("Successfully removed from database");

                    Properties.Settings.Default.Username = null;
                    Properties.Settings.Default.Password = null;
                    Properties.Settings.Default.AccounType = null;
                    Properties.Settings.Default.Save();

                    Application.Exit();
                }
            }
            if (choice == DialogResult.No)
            {

            }
        }

        private void frmStaffNurseProfile_Load(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                sqlcon.Open();

                SqlCommand cmd = new SqlCommand("select * from Staff where username=@user", sqlcon);
                cmd.Parameters.AddWithValue("@user", Properties.Settings.Default.Username);
                SqlDataReader da = cmd.ExecuteReader();
                while (da.Read())
                {
                    nameTextBox.Text = da.GetValue(1).ToString();
                    surnameTextBox.Text = da.GetValue(2).ToString();
                    gendercombo.Text = da.GetValue(3).ToString();
                    emailTextBox.Text = da.GetValue(4).ToString();
                    phoneTextBox.Text = da.GetValue(5).ToString();
                    addressTextBox.Text = da.GetValue(6).ToString();
                    ssnTxtBox.Text = da.GetValue(7).ToString();
                    passwordTextBox.Text = da.GetValue(8).ToString();
                }
                sqlcon.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult choice = MessageBox.Show("Are you sure you want to log out?\n", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (choice == DialogResult.Yes)
            {
                Properties.Settings.Default.Username = null;
                Properties.Settings.Default.Password = null;
                Properties.Settings.Default.AccounType = null;
                Properties.Settings.Default.Save();

                Application.Exit();
            }
            if (choice == DialogResult.No)
            {

            }
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                sqlcon.Open();

                SqlCommand cmd = new SqlCommand("update Staff set firstname=@firstname, lastname=@lastname, address=@address, phone=@phone, email=@email, password=@password, ssn=@ssn, gender=@gender  where username=@user", sqlcon);
                cmd.Parameters.AddWithValue("@user", Properties.Settings.Default.Username);
                cmd.Parameters.AddWithValue("@firstname", nameTextBox.Text);
                cmd.Parameters.AddWithValue("@lastname", surnameTextBox.Text);
                cmd.Parameters.AddWithValue("@address", addressTextBox.Text);
                cmd.Parameters.AddWithValue("@phone", phoneTextBox.Text);
                cmd.Parameters.AddWithValue("@email", emailTextBox.Text);
                cmd.Parameters.AddWithValue("@password", passwordTextBox.Text);
                cmd.Parameters.AddWithValue("@ssn", ssnTxtBox.Text);
                cmd.Parameters.AddWithValue("@gender", gendercombo.Text);
                cmd.ExecuteNonQuery();

                sqlcon.Close();
                MessageBox.Show("Successfully saved");
            }
        }
    }
}
