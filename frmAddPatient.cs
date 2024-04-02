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

    public partial class frmAddPatient : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\NamCityDatabase.mdf;Integrated Security=True;Connect Timeout=30");

        public frmAddPatient()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string birthdate = birth_dateDateTimePicker.Text;
            string inspection = inspectionDateTimePicker.Text;
    
            Con.Open();

    

            SqlCommand cmd = new SqlCommand("insert into Patients values('" + nameTextBox.Text + "','" + lastnametxt.Text + "','" + gendercombo.Text + "','" + ssnTextBox1.Text + "','" + birthdate + "','" + birth_placeTextBox.Text + "','" + father_nameTextBox.Text + "','" + phoneTextBox.Text + "','" + addressTextBox.Text + "','" + inspection + "','" + complaintTextBox.Text + "','" + departmenttxt.Text + "','" + doctortxt.Text +"',  'N', 'N', 'N', '-', '-')", Con);
            cmd.ExecuteNonQuery();
   
            MessageBox.Show("New patient added successfully!");


            Con.Close();
            Close();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAddPatient_Load(object sender, EventArgs e)
        {
            firstname.Text = Properties.Settings.Default.FirstName;
            lastname.Text = Properties.Settings.Default.LastName;
            gender.Text = Properties.Settings.Default.Gender;        
            phone.Text = Properties.Settings.Default.Phone;
            address.Text = Properties.Settings.Default.Address;
            birthdate.Text = Properties.Settings.Default.Birthdate;
            birthplace.Text = Properties.Settings.Default.Birthplace;
            fathername.Text = Properties.Settings.Default.Fathername;
            label1.Text = Properties.Settings.Default.InspectionDate;
            label2.Text = Properties.Settings.Default.Department;
            label3.Text = Properties.Settings.Default.Doctor;
            label4.Text = Properties.Settings.Default.Illness;
            exitButton.Text = Properties.Settings.Default.Cancel;
            saveButton.Text = Properties.Settings.Default.Add;
            
        }
    }
}
