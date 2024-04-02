using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlTypes;
using System.Data.SqlClient;

namespace HospitalManagementSystem
{
    public partial class frmAddNurse : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\NamCityDatabase.mdf;Integrated Security=True;Connect Timeout=30";

        public frmAddNurse()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                sqlcon.Open();

                SqlCommand cmd = new SqlCommand("insert into Staff values('" + userNameTextBox.Text + "','" + nameTextBox.Text + "','" + surnameTextBox.Text + "','" + gendercombo.Text + "','" + emailTextBox.Text + "','" + phoneTextBox.Text + "','" + addressTextBox.Text + "','" + ssnTxtBox.Text + "','" + passwordTextBox.Text +"')", sqlcon);
             
                cmd.ExecuteNonQuery();

                sqlcon.Close();
                MessageBox.Show("Successfully added new staff nurse!");
                Close();
            }
        }

        private void frmAddNurse_Load(object sender, EventArgs e)
        {
            label9.Text = Properties.Settings.Default.LoginInformation;
            usernameLabel.Text = Properties.Settings.Default.lblUsername;
            passwordLabel.Text = Properties.Settings.Default.lblPassword;
            emailLabel.Text = Properties.Settings.Default.Email;
            label8.Text = Properties.Settings.Default.NurseInformation;
            label1.Text = Properties.Settings.Default.FirstName;
            label2.Text = Properties.Settings.Default.LastName;
            label5.Text = Properties.Settings.Default.Gender;        
            label6.Text = Properties.Settings.Default.Phone;
            label7.Text = Properties.Settings.Default.Address;
            exitButton.Text = Properties.Settings.Default.Cancel;
            saveButton.Text = Properties.Settings.Default.Add;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
