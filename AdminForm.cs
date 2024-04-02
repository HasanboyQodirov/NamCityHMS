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
    public partial class AdminForm : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\NamCityDatabase.mdf;Integrated Security=True;Connect Timeout=30";


        public AdminForm()
        {
            InitializeComponent();
        }



        private void btnAddDoctor_Click(object sender, EventArgs e)
        {
            using (frmAddDoctor adddoctor = new frmAddDoctor())
            {
                adddoctor.ShowDialog();
            }
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            using (frmAddNurse addnurse = new frmAddNurse())
            {
                addnurse.ShowDialog();
            }
        }

        private void btnAddDoctor_Click_1(object sender, EventArgs e)
        {
            using (frmAddDoctor adddoctor = new frmAddDoctor())
            {
                adddoctor.ShowDialog();
            }
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            btnPatients.Text = Properties.Settings.Default.Patients;
            btnDoctors.Text = Properties.Settings.Default.Doctors;
            btnNurses.Text = Properties.Settings.Default.Nurses;
            btnAdmins.Text = Properties.Settings.Default.MyAccount;
            btnAbout.Text = Properties.Settings.Default.About;
            lblRedInfo.Text = Properties.Settings.Default.AdminRedlbl;
            btnAddDoctor.Text = Properties.Settings.Default.AddDoctor;
            btnAddStaff.Text = Properties.Settings.Default.AddNurse;
            btnUpdateDoctor.Text = Properties.Settings.Default.UpdateDoctorInfo;
            btnUpdateStaff.Text = Properties.Settings.Default.UpdateNurseInfo;

            pnlDoc.BringToFront();
            pnlStaf.SendToBack();
            ShowDoctors();
        }

        private void btnDoctors_Click(object sender, EventArgs e)
        {
            pnlDoc.BringToFront();
            lblRedInfo.Show();
            pnlStaf.SendToBack();
            pnlPatient.SendToBack();
            this.btnNurses.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoctors.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatients.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmins.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ShowDoctors();
        }

        private void btnUpdateDoctor_Click(object sender, EventArgs e)
        {
            using (frmDoctorInfoFull upddoctor = new frmDoctorInfoFull())
            {
                upddoctor.ShowDialog();
            }
        }

        private void btnUpdateStaff_Click(object sender, EventArgs e)
        {
            using(frmUpdateNurse upnurse = new frmUpdateNurse())
            {
                upnurse.ShowDialog();
            }
        }

        private void btnSearchDoctor_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                sqlcon.Open();

                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT username, firstname, phone, lastname, department, email FROM Doctors WHERE (firstname='"+doctorFirstname.Text+"' AND lastname='"+doctorLastname.Text+"')", sqlcon);
              
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
        // Showing DOCTORS, PATIENTS, NURSES
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

        private void btnNurses_Click(object sender, EventArgs e)
        {
            lblRedInfo.Show();
            pnlStaf.BringToFront();
            pnlDoc.SendToBack();
            pnlPatient.SendToBack();
            ShowStaff();
            this.btnNurses.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoctors.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatients.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmins.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void btnShowStaff_Click(object sender, EventArgs e)
        {
            ShowStaff();
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

        private void Staffdata_CellClick(object sender, DataGridViewCellEventArgs e)
        {
         
          


        }

        private void Staffdata_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Staffdata.CurrentCell != null && Staffdata.CurrentCell.Value != null)
            {
                String nurse_username = Staffdata.CurrentCell.Value.ToString();
                Properties.Settings.Default.NurseUsername = nurse_username;
                using (frmUpdateNurse upnurse = new frmUpdateNurse())
                {
                    upnurse.ShowDialog();
                }
            }
        }

        private void doctordataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (doctordataGridView.CurrentCell != null && doctordataGridView.CurrentCell.Value != null)
            {
                String doctor_username = doctordataGridView.CurrentCell.Value.ToString();
                Properties.Settings.Default.DoctorUsername = doctor_username;
                using (frmDoctorInfoFull upddoctor = new frmDoctorInfoFull())
                {
                    upddoctor.ShowDialog();
                }
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
            lblRedInfo.Hide();
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

        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnAdmins_Click(object sender, EventArgs e)
        {
            using (frmAdminProfile admin = new frmAdminProfile())
            {
                admin.ShowDialog();
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
            AdminForm openAdmin = new AdminForm();
            openAdmin.ShowDialog();
            this.Close();
        }
    }
}
