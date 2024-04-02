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
    public partial class frmDoctor : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\NamCityDatabase.mdf;Integrated Security=True;Connect Timeout=30";

        public frmDoctor()
        {
            InitializeComponent();
        }

        private void ShowDoctors()
        {
            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                sqlcon.Open();

                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT username, firstname, phone, lastname, department, email FROM Doctors", sqlcon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                doctordataGridView.DataSource = dtbl;
                sqlcon.Close();
            }
        }

        private void ShowStaff()
        {
            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                sqlcon.Open();

                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT username, firstname, phone, lastname, gender, email FROM Staff", sqlcon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                Staffdata.DataSource = dtbl;
                sqlcon.Close();
            }
        }

        private void ShowPatients()
        {
            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                sqlcon.Open();

                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT firstname, lastname, ssn, gender, complaint, phone FROM Patients", sqlcon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                patientdata.DataSource = dtbl;
                sqlcon.Close();
            }
        }

        private void btnNurses_Click(object sender, EventArgs e)
        {
            lblRedInfo.Hide();
            pnlStaf.BringToFront();
            pnlDoc.SendToBack();
            pnlPatients.SendToBack();
            ShowStaff();
            this.btnNurses.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoctors.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatients.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void btnPatients_Click(object sender, EventArgs e)
        {
            pnlPatients.BringToFront();
            pnlDoc.SendToBack();
            pnlStaf.SendToBack();
            this.btnNurses.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoctors.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatients.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ShowPatients();
            lblRedInfo.Show();
        }

        private void btnDoctors_Click(object sender, EventArgs e)
        {
            lblRedInfo.Hide();
            pnlDoc.BringToFront();
            
            pnlStaf.SendToBack();
            pnlPatients.SendToBack();
            this.btnNurses.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoctors.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatients.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ShowDoctors();
        }

        private void btnAddDoctor_Click(object sender, EventArgs e)
        {

        }

        private void btnInspectPatient_Click(object sender, EventArgs e)
        {
            using (frmInspectPatient inspect = new frmInspectPatient())
            {
                inspect.ShowDialog();
            }
        }

        private void btnUpdatePatient_Click(object sender, EventArgs e)
        {
            using (frmUpdatePatient inspect = new frmUpdatePatient())
            {
                inspect.ShowDialog();
            }
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            using (frmAddPatient inspect = new frmAddPatient())
            {
                inspect.ShowDialog();
            }
        }

        private void btnSearchStaff_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                sqlcon.Open();

                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT username, firstname, phone, lastname, gender, email FROM Staff WHERE (firstname='" + StafFirstnametxt.Text + "' AND lastname='" + StaffLastnametxt.Text + "')", sqlcon);

                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                Staffdata.DataSource = dtbl;
                sqlcon.Close();
            }
        }

        private void btnSearchDoctor_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                sqlcon.Open();

                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT username, firstname, phone, lastname, department, email FROM Doctors WHERE (firstname='" + doctorFirstname.Text + "' AND lastname='" + doctorLastname.Text + "')", sqlcon);

                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                doctordataGridView.DataSource = dtbl;
                sqlcon.Close();
            }
        }

        private void btnShowStaff_Click(object sender, EventArgs e)
        {
            ShowStaff();
        }

        private void btnShaw_Click(object sender, EventArgs e)
        {
            ShowDoctors();
        }

        private void frmDoctor_Load(object sender, EventArgs e)
        {
            btnPatients.Text = Properties.Settings.Default.Patients;
            btnDoctors.Text = Properties.Settings.Default.Doctors;
            btnNurses.Text = Properties.Settings.Default.Nurses;
            button1.Text = Properties.Settings.Default.MyAccount;
            btnAbout.Text = Properties.Settings.Default.About;
            btnInspectPatient.Text = Properties.Settings.Default.InspectPatient;
            btnUpdatePatient.Text = Properties.Settings.Default.UpdatePatientInfo;
            btnAddPatient.Text = Properties.Settings.Default.AddPatient;
            btnMyPatients.Text = Properties.Settings.Default.MyPatients;
            lblRedInfo.Text = Properties.Settings.Default.PatientSSNClick;


            ShowPatients();
        }

        private void patientsearch_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                sqlcon.Open();

                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT firstname, lastname, ssn, gender, complaint, phone FROM Patients WHERE (firstname='" + patientfirstname.Text + "' AND lastname='" + patientlastname.Text + "')", sqlcon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                patientdata.DataSource = dtbl;
                sqlcon.Close();
            }
        }

        private void btnShowpatients_Click(object sender, EventArgs e)
        {
            ShowPatients();
        }

        private void btnMyPatients_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                sqlcon.Open();

                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT firstname, lastname, ssn, gender, complaint, phone FROM Patients where doctor='"+Properties.Settings.Default.Username+"'", sqlcon);
               
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                patientdata.DataSource = dtbl;
                sqlcon.Close();
            }
        }

        private void patientdata_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (patientdata.CurrentCell != null && patientdata.CurrentCell.Value != null)
            {
                String patient_ssn = patientdata.CurrentCell.Value.ToString();
               
                Properties.Settings.Default.PatientSSN = patient_ssn;
                using (frmUpdatePatient uppatient = new frmUpdatePatient())
                {
                    uppatient.ShowDialog();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (frmDoctorProfile profile = new frmDoctorProfile())
            {
                profile.ShowDialog();
            }
        }

        private void frmDoctor_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            using (AboutBox about = new AboutBox())
            {
                about.ShowDialog();
            }
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            frmDoctor openDoc = new frmDoctor();
            openDoc.ShowDialog();
            this.Close();
        }
    }
}
