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
    public partial class frmInspectPatient : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\NamCityDatabase.mdf;Integrated Security=True;Connect Timeout=30";

        public frmInspectPatient()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {

        }

        private void saveButton_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {       
                sqlcon.Open();

                SqlCommand cmd = new SqlCommand("update Patients set complaint=@complaint, diagnosis=@diagnosis, prescription=@prescription, bloodanalysis=@blood, urinanalysis=@urin, xray=@xray  where ssn=@ssn", sqlcon);

                cmd.Parameters.AddWithValue("@blood", bloodtxt.Text);
                cmd.Parameters.AddWithValue("@urin", urintxt.Text);
                cmd.Parameters.AddWithValue("@xray", xraytxt.Text);

                cmd.Parameters.AddWithValue("@complaint", complaintTextBox.Text);
                cmd.Parameters.AddWithValue("@diagnosis", diagnosisTextBox.Text);
                cmd.Parameters.AddWithValue("@prescription", prescriptionTextBox.Text);
                cmd.Parameters.AddWithValue("@ssn", ssnTextBox.Text);


                cmd.ExecuteNonQuery();

                sqlcon.Close();
                MessageBox.Show("Successfully saved");
            }
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
                    
                    ssnTextBox.Text = da.GetValue(3).ToString();
                    firstnametxt.Text = da.GetValue(0).ToString();
                    lastnametxt.Text = da.GetValue(1).ToString();
                    gendercombo.Text = da.GetValue(2).ToString();
                    birthdate.Text = da.GetValue(4).ToString();
                    datein.Text = da.GetValue(9).ToString();
                    complaintTextBox.Text = da.GetValue(10).ToString();
                    diagnosisTextBox.Text = da.GetValue(16).ToString();
                    prescriptionTextBox.Text = da.GetValue(17).ToString();
                   
                    bloodtxt.Text = da.GetValue(13).ToString();
                    urintxt.Text = da.GetValue(14).ToString();
                    xraytxt.Text = da.GetValue(15).ToString();           
              
                }
                sqlcon.Close();
               
            }
        }

        private void frmInspectPatient_Load(object sender, EventArgs e)
        {
        
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
