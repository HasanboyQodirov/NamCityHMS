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
using System.Data.Sql;
using System.Data.SqlTypes;

namespace HospitalManagementSystem
{
    public partial class frmAddDoctor : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\NamCityDatabase.mdf;Integrated Security=True;Connect Timeout=30");

        public frmAddDoctor()
        {
            InitializeComponent();
        }

        private void frmAddDoctor_Load(object sender, EventArgs e)
        {
            label9.Text = Properties.Settings.Default.LoginInformation;
            usernameLabel.Text = Properties.Settings.Default.lblUsername;
            passwordLabel.Text = Properties.Settings.Default.lblPassword;
            emailLabel.Text = Properties.Settings.Default.Email;
            label8.Text = Properties.Settings.Default.DoctorInformation;
            label1.Text = Properties.Settings.Default.FirstName;
            label2.Text = Properties.Settings.Default.LastName;
            label5.Text = Properties.Settings.Default.Gender;
            label3.Text = Properties.Settings.Default.Department;
            label6.Text = Properties.Settings.Default.Phone;
            label7.Text = Properties.Settings.Default.Address;
            exitButton.Text = Properties.Settings.Default.Cancel;
            saveButton.Text = Properties.Settings.Default.Add;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Con.Open();

            SqlCommand cmd = new SqlCommand("insert into Doctors values('"+userNameTextBox.Text+"','"+nameTextBox.Text+"','" +surnameTextBox.Text + "','" +deptTtextBox.Text + "','" +addressTextBox.Text + "','" +phoneTextBox.Text + "','" +emailTextBox.Text + "','" +passwordTextBox.Text + "','" +ssnTxtBox.Text+ "','" + gendercombo.Text+ "')",Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Doctor added successfully");
          

            Con.Close();
            Close();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
