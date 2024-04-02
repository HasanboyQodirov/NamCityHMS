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
    public partial class frmNurse : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\NamCityDatabase.mdf;Integrated Security=True;Connect Timeout=30";

        public frmNurse()
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

        private void btnPatients_Click(object sender, EventArgs e)
        {
            pnlDoc.BringToFront();
            pnlPatient.BringToFront();
            pnlDoc.SendToBack();
            pnlStaf.SendToBack();
            this.btnNurses.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoctors.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatients.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ShowPatients();

            lblRedInfo.Show();
        }

        private void btnNurses_Click(object sender, EventArgs e)
        {
            lblRedInfo.Hide();
            pnlStaf.BringToFront();
            pnlDoc.SendToBack();
            pnlPatient.SendToBack();
            ShowStaff();
            this.btnNurses.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoctors.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatients.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void btnDoctors_Click(object sender, EventArgs e)
        {
            pnlDoc.BringToFront();

            pnlStaf.SendToBack();
            pnlPatient.SendToBack();
            this.btnNurses.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoctors.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatients.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ShowDoctors();
            lblRedInfo.Hide();
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

        private void btnShowStaff_Click(object sender, EventArgs e)
        {
            ShowStaff();
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

        private void btnShaw_Click(object sender, EventArgs e)
        {
            ShowDoctors();
        }

        private void frmNurse_Load(object sender, EventArgs e)
        {

            btnPatients.Text = Properties.Settings.Default.Patients;
            btnDoctors.Text = Properties.Settings.Default.Doctors;
            btnNurses.Text = Properties.Settings.Default.Nurses;
            button1.Text = Properties.Settings.Default.MyAccount;
            btnAbout.Text = Properties.Settings.Default.About;
            btnUpdatePatient.Text = Properties.Settings.Default.UpdatePatientInfo;
            btnAddPatient.Text = Properties.Settings.Default.AddPatient;
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

        private void frmNurse_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (frmStaffNurseProfile profile = new frmStaffNurseProfile())
            {
                profile.ShowDialog();
            }
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
            frmNurse openNurse = new frmNurse();
            openNurse.ShowDialog();
            this.Close();
        }
    }
}
