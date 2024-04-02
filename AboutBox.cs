using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    partial class AboutBox : Form
    {
        public AboutBox()
        {
            InitializeComponent();
            this.Text = String.Format("About {0}", AssemblyTitle);
           
        }

        #region Assembly Attribute Accessors

        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
        #endregion

        private void Button1_Click(object sender, EventArgs e)
        {
            if (combo.SelectedItem == "English") {

            }
            if (combo.SelectedItem == "한국어")
            {
                Properties.Settings.Default.Lan = "한국어";
                Properties.Settings.Default.LoginWelcome = "병원 경영 시스템에 오신 것을 환영합니다!\n계속하려면 로그인하십시오.";
                Properties.Settings.Default.LoginAccountType = "계정 유형";
                Properties.Settings.Default.LoginUsername = "사용자 이름";
                Properties.Settings.Default.LoginPassword = "비밀번호";
                Properties.Settings.Default.Login = "로그인";

                Properties.Settings.Default.Doctors = "의사";
                Properties.Settings.Default.Patients = "환자";
                Properties.Settings.Default.Nurses = "간호사";
                Properties.Settings.Default.MyAccount = "내 계정";
                Properties.Settings.Default.About = "앱 정보";
                Properties.Settings.Default.PatientSSNClick = "정보를 보고 업데이트하려면 환자 SSN을 두 번 클릭하십시오.";

                Properties.Settings.Default.InspectPatient = "환자를 검사";
                Properties.Settings.Default.UpdatePatientInfo = "환자 정보 업데이트";
                Properties.Settings.Default.AddPatient = "새로운 환자";
                Properties.Settings.Default.MyPatients = "내 환자";

                Properties.Settings.Default.AdminRedlbl = "정보를 보거나 업데이트하려는 행의 사용자 이름 셀을 두 번 클릭하십시오.";
                Properties.Settings.Default.AddDoctor = "새로운 의사";
                Properties.Settings.Default.AddNurse = "새로운 간호사";
                Properties.Settings.Default.UpdateDoctorInfo = "의사 정보 업데이트";
                Properties.Settings.Default.UpdateNurseInfo = "간호사 정보 업데이트";
                Properties.Settings.Default.AdminPanel = "관리자 패널";

                Properties.Settings.Default.LoginInformation = "로그인 정보";
                Properties.Settings.Default.lblUsername = "사용자 이름";
                Properties.Settings.Default.lblPassword = "비밀번호";
                Properties.Settings.Default.Email = "이메일";
                Properties.Settings.Default.DoctorInformation = "의사 정보";
                Properties.Settings.Default.FirstName = "이름";
                Properties.Settings.Default.LastName = "성";
                Properties.Settings.Default.Gender = "성별";
                Properties.Settings.Default.Department = "부서";
                Properties.Settings.Default.Phone = "핸드폰";
                Properties.Settings.Default.Address = "주소";
                Properties.Settings.Default.Cancel = "취소";
                Properties.Settings.Default.Add = "추가";

                Properties.Settings.Default.NurseInformation = "간호사 정보";

                Properties.Settings.Default.Birthdate = "생일";
                Properties.Settings.Default.Birthplace = "출생지";
                Properties.Settings.Default.Fathername = "아버지의 이름";
                Properties.Settings.Default.InspectionDate = "검사일";
                Properties.Settings.Default.Illness = "병";
                Properties.Settings.Default.Doctor = "의사";

                Properties.Settings.Default.AdminPanelText = "관리자 패널입니다. 여기에서 계정 세부 정보를 변경할 수 있습니다.";
                Properties.Settings.Default.Logout = "로그 아웃";
                Properties.Settings.Default.Save = "저장";
                Properties.Settings.Default.Close = "닫기";

                Properties.Settings.Default.Save();
                this.Close();
            }
            if (combo.SelectedItem == "English")
            {
                Properties.Settings.Default.Lan = "English";
                Properties.Settings.Default.LoginWelcome = "WELCOME TO HOSPITAL MANAGEMENT SYSTEM\nPLEASE LOGIN TO CONTINUE";
                Properties.Settings.Default.LoginAccountType = "ACCOUNT TYPE";
                Properties.Settings.Default.LoginUsername = "USERNAME";
                Properties.Settings.Default.LoginPassword = "PASSWORD";
                Properties.Settings.Default.Login = "LOGIN";

                Properties.Settings.Default.Doctors = "Doctors";
                Properties.Settings.Default.Patients = "Patients";
                Properties.Settings.Default.Nurses = "Nurses";
                Properties.Settings.Default.MyAccount = "My Account";
                Properties.Settings.Default.About = "About";
                Properties.Settings.Default.PatientSSNClick = "Please double click patient SSN to see and update information.";

                Properties.Settings.Default.InspectPatient = "Inspect Patient";
                Properties.Settings.Default.UpdatePatientInfo = "Update Patient Info";
                Properties.Settings.Default.AddPatient = "Add Patient";
                Properties.Settings.Default.MyPatients = "My Patients";

                Properties.Settings.Default.AdminRedlbl = "Please double click username cell of row that you would like to see and update information.";
                Properties.Settings.Default.AddDoctor = "Add Doctor";
                Properties.Settings.Default.AddNurse = "Add Nurse";
                Properties.Settings.Default.UpdateDoctorInfo = "Update Doctor Info";
                Properties.Settings.Default.UpdateNurseInfo = "Update Nurse Info";
                Properties.Settings.Default.AdminPanel = "Admin Panel";

                Properties.Settings.Default.LoginInformation = "LOGIN INFORMATION";
                Properties.Settings.Default.lblUsername = "Username";
                Properties.Settings.Default.lblPassword = "Password";
                Properties.Settings.Default.Email = "E-mail";
                Properties.Settings.Default.DoctorInformation = "DOCTOR INFORMATION";
                Properties.Settings.Default.FirstName = "First Name";
                Properties.Settings.Default.LastName = "Last Name";
                Properties.Settings.Default.Gender = "Gender";
                Properties.Settings.Default.Department = "Department";
                Properties.Settings.Default.Phone = "Phone";
                Properties.Settings.Default.Address = "Address";
                Properties.Settings.Default.Cancel = "CANCEL";
                Properties.Settings.Default.Add = "ADD";

                Properties.Settings.Default.NurseInformation = "NURSE INFORMATION";

                Properties.Settings.Default.Birthdate = "Birth date";
                Properties.Settings.Default.Birthplace = "Birth place";
                Properties.Settings.Default.Fathername = "Father's name";
                Properties.Settings.Default.InspectionDate = "Inspection Date";
                Properties.Settings.Default.Illness = "Illness";
                Properties.Settings.Default.Doctor = "Doctor";

                Properties.Settings.Default.AdminPanelText = "THIS IS YOUR ADMIN PANEL. YOU CAN CHANGE YOUR ACCOUNT DETAILS HERE.";
                Properties.Settings.Default.Logout = "LOG OUT";
                Properties.Settings.Default.Save = "SAVE";
                Properties.Settings.Default.Close = "CLOSE";

                Properties.Settings.Default.Save();
                this.Close();
            }
        }

        private void AboutBox_Load(object sender, EventArgs e)
        {
            combo.Text = Properties.Settings.Default.Lan;
        }
    }
}
