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
using System.Threading;

namespace HospitalManagementSystem
{
    public partial class frmLogin : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\NamCityDatabase.mdf;Integrated Security=True;Connect Timeout=30";
        string password;
        public frmLogin()
        {
            Thread Welcome = new Thread(new ThreadStart(StartForm));
            Welcome.Start();
            Thread.Sleep(3000);
            InitializeComponent();
            Welcome.Abort();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDe_Click(object sender, EventArgs e)
        {
            password = null;
            if (accountcombo.Text == "Admin")
            {
                using (SqlConnection sqlcon = new SqlConnection(connectionString))
                {
                    sqlcon.Open();

                    SqlCommand cmd = new SqlCommand("select password from Admin where username=@user", sqlcon);
                    cmd.Parameters.AddWithValue("@user", userNameTextBox.Text);
                    SqlDataReader da = cmd.ExecuteReader();
                    while (da.Read())
                    {
                        password = da.GetValue(0).ToString();

                    }
                    sqlcon.Close();
                }

                if (password == passwordTextBox.Text)
                {
                    Properties.Settings.Default.Username = userNameTextBox.Text;
                    Properties.Settings.Default.Password = passwordTextBox.Text;
                    Properties.Settings.Default.AccounType = "Admin";
                    Properties.Settings.Default.Save();

                    AdminForm openAdmin = new AdminForm();
                    openAdmin.ShowDialog();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Incorrect username or password!");
                }
            }
            if (accountcombo.Text == "Doctor")
            {
                using (SqlConnection sqlcon = new SqlConnection(connectionString))
                {
                    sqlcon.Open();

                    SqlCommand cmd = new SqlCommand("select password from Doctors where username=@user", sqlcon);
                    cmd.Parameters.AddWithValue("@user", userNameTextBox.Text);
                    SqlDataReader da = cmd.ExecuteReader();
                    while (da.Read())
                    {
                        password = da.GetValue(0).ToString();
                        
                    }
                    sqlcon.Close();
                }

                if (password == passwordTextBox.Text)
                {
                    Properties.Settings.Default.Username = userNameTextBox.Text;
                    Properties.Settings.Default.Password = passwordTextBox.Text;
                    Properties.Settings.Default.AccounType = "Doctor";
                    Properties.Settings.Default.Save();

                    frmDoctor openDoc = new frmDoctor();
                    openDoc.ShowDialog();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Incorrect username or password!");
                }
             
               
            }
            if (accountcombo.Text == "Nurse")
            {

                    using (SqlConnection sqlcon = new SqlConnection(connectionString))
                    {
                        sqlcon.Open();

                        SqlCommand cmd = new SqlCommand("select password from Staff where username=@user", sqlcon);
                        cmd.Parameters.AddWithValue("@user", userNameTextBox.Text);
                        SqlDataReader da = cmd.ExecuteReader();
                        while (da.Read())
                        {
                            password = da.GetValue(0).ToString();

                        }
                        sqlcon.Close();
                    }

                    if (password == passwordTextBox.Text)
                    {
                        Properties.Settings.Default.Username = userNameTextBox.Text;
                        Properties.Settings.Default.Password = passwordTextBox.Text;
                        Properties.Settings.Default.AccounType = "Nurse";
                        Properties.Settings.Default.Save();

                        frmNurse openNurse = new frmNurse();
                        openNurse.ShowDialog();
                        this.Close();

                }
                    else
                    {
                        MessageBox.Show("Incorrect username or password!");
                    }
             }
           

        }

        public void StartForm()
        {
            Application.Run(new frmSplash());
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            label1.Text = Properties.Settings.Default.LoginWelcome;
            label2.Text = Properties.Settings.Default.LoginAccountType;
            label3.Text = Properties.Settings.Default.LoginUsername;
            label4.Text = Properties.Settings.Default.LoginPassword;
            btnDe.Text = Properties.Settings.Default.Login;

            if (Properties.Settings.Default.AccounType == "Admin")
            {
               
                AdminForm openAdmin = new AdminForm();
                openAdmin.ShowDialog();
                this.Close();

            }
            if (Properties.Settings.Default.AccounType == "Doctor")
            {
                
                frmDoctor openDoc = new frmDoctor();
                
                openDoc.ShowDialog();
                this.Close();


            }
            if (Properties.Settings.Default.AccounType == "Nurse")
            {
               
                frmNurse openNurse = new frmNurse();
                openNurse.ShowDialog();
                this.Close();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
