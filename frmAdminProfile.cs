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
    public partial class frmAdminProfile : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\NamCityDatabase.mdf;Integrated Security=True;Connect Timeout=30";

        public frmAdminProfile()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                sqlcon.Open();

                SqlCommand cmd = new SqlCommand("update Admin set firstname=@firstname, lastname=@lastname, phone=@phone, email=@email, password=@password, username=@usernamenew  where username=@user", sqlcon);
                cmd.Parameters.AddWithValue("@user", Properties.Settings.Default.Username);
                cmd.Parameters.AddWithValue("@firstname", firstnametxt.Text);
                cmd.Parameters.AddWithValue("@lastname", secondnametxt.Text);
           
                cmd.Parameters.AddWithValue("@phone", phonetxt.Text);
                cmd.Parameters.AddWithValue("@email", emailtxt.Text);
                cmd.Parameters.AddWithValue("@password", passwordtxt.Text);
                cmd.Parameters.AddWithValue("@usernamenew", usernametxt.Text);
         
                cmd.ExecuteNonQuery();
                Properties.Settings.Default.Username = usernametxt.Text;
                Properties.Settings.Default.Password = passwordtxt.Text;

                sqlcon.Close();
                MessageBox.Show("Successfully saved");
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

        private void frmAdminProfile_Load(object sender, EventArgs e)
        {
            label1.Text = Properties.Settings.Default.AdminPanelText;
            label2.Text = Properties.Settings.Default.FirstName;
            label3.Text = Properties.Settings.Default.LastName;
            label4.Text = Properties.Settings.Default.lblUsername;
            label5.Text = Properties.Settings.Default.Email;
            label6.Text = Properties.Settings.Default.Phone;
            label7.Text = Properties.Settings.Default.lblPassword;
            btnLogout.Text = Properties.Settings.Default.Logout;
            btnSave.Text = Properties.Settings.Default.Save;
            button3.Text = Properties.Settings.Default.Close;

            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                sqlcon.Open();

                SqlCommand cmd = new SqlCommand("select * from Admin where username=@user", sqlcon);
                cmd.Parameters.AddWithValue("@user", Properties.Settings.Default.Username);
                SqlDataReader da = cmd.ExecuteReader();
                while (da.Read())
                {
                    firstnametxt.Text = da.GetValue(1).ToString();
                    secondnametxt.Text = da.GetValue(2).ToString();
                    usernametxt.Text = da.GetValue(0).ToString();
                    phonetxt.Text = da.GetValue(5).ToString();
                    emailtxt.Text = da.GetValue(4).ToString();
                    passwordtxt.Text = da.GetValue(3).ToString();
                   
                }
                sqlcon.Close();
            }
        }
    }
}
