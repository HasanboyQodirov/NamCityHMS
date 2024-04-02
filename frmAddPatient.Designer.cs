namespace HospitalManagementSystem
{
    partial class frmAddPatient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label ssnLabel;
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.birth_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.birth_placeTextBox = new System.Windows.Forms.TextBox();
            this.father_nameTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.gendercombo = new System.Windows.Forms.ComboBox();
            this.ssnTextBox1 = new System.Windows.Forms.TextBox();
            this.lastnametxt = new System.Windows.Forms.TextBox();
            this.inspectionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.departmenttxt = new System.Windows.Forms.TextBox();
            this.doctortxt = new System.Windows.Forms.TextBox();
            this.complaintTextBox = new System.Windows.Forms.TextBox();
            this.firstname = new System.Windows.Forms.Label();
            this.lastname = new System.Windows.Forms.Label();
            this.gender = new System.Windows.Forms.Label();
            this.birthdate = new System.Windows.Forms.Label();
            this.birthplace = new System.Windows.Forms.Label();
            this.fathername = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ssnLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ssnLabel
            // 
            ssnLabel.AutoSize = true;
            ssnLabel.Location = new System.Drawing.Point(42, 28);
            ssnLabel.Name = "ssnLabel";
            ssnLabel.Size = new System.Drawing.Size(28, 13);
            ssnLabel.TabIndex = 97;
            ssnLabel.Text = "Ssn:";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(117, 234);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(137, 71);
            this.addressTextBox.TabIndex = 84;
            // 
            // birth_dateDateTimePicker
            // 
            this.birth_dateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birth_dateDateTimePicker.Location = new System.Drawing.Point(117, 130);
            this.birth_dateDateTimePicker.MaxDate = new System.DateTime(2029, 12, 1, 0, 0, 0, 0);
            this.birth_dateDateTimePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.birth_dateDateTimePicker.Name = "birth_dateDateTimePicker";
            this.birth_dateDateTimePicker.Size = new System.Drawing.Size(137, 20);
            this.birth_dateDateTimePicker.TabIndex = 86;
            this.birth_dateDateTimePicker.Value = new System.DateTime(2020, 6, 23, 0, 0, 0, 0);
            // 
            // birth_placeTextBox
            // 
            this.birth_placeTextBox.Location = new System.Drawing.Point(117, 156);
            this.birth_placeTextBox.Name = "birth_placeTextBox";
            this.birth_placeTextBox.Size = new System.Drawing.Size(137, 20);
            this.birth_placeTextBox.TabIndex = 88;
            // 
            // father_nameTextBox
            // 
            this.father_nameTextBox.Location = new System.Drawing.Point(117, 182);
            this.father_nameTextBox.Name = "father_nameTextBox";
            this.father_nameTextBox.Size = new System.Drawing.Size(137, 20);
            this.father_nameTextBox.TabIndex = 90;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(117, 51);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(137, 20);
            this.nameTextBox.TabIndex = 92;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(117, 208);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(137, 20);
            this.phoneTextBox.TabIndex = 94;
            // 
            // gendercombo
            // 
            this.gendercombo.FormattingEnabled = true;
            this.gendercombo.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.gendercombo.Location = new System.Drawing.Point(117, 103);
            this.gendercombo.Name = "gendercombo";
            this.gendercombo.Size = new System.Drawing.Size(137, 21);
            this.gendercombo.TabIndex = 96;
            // 
            // ssnTextBox1
            // 
            this.ssnTextBox1.Location = new System.Drawing.Point(117, 25);
            this.ssnTextBox1.Name = "ssnTextBox1";
            this.ssnTextBox1.Size = new System.Drawing.Size(137, 20);
            this.ssnTextBox1.TabIndex = 98;
            // 
            // lastnametxt
            // 
            this.lastnametxt.Location = new System.Drawing.Point(117, 77);
            this.lastnametxt.Name = "lastnametxt";
            this.lastnametxt.Size = new System.Drawing.Size(137, 20);
            this.lastnametxt.TabIndex = 100;
            // 
            // inspectionDateTimePicker
            // 
            this.inspectionDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.inspectionDateTimePicker.Location = new System.Drawing.Point(392, 22);
            this.inspectionDateTimePicker.MaxDate = new System.DateTime(2029, 12, 1, 0, 0, 0, 0);
            this.inspectionDateTimePicker.MinDate = new System.DateTime(2014, 9, 1, 0, 0, 0, 0);
            this.inspectionDateTimePicker.Name = "inspectionDateTimePicker";
            this.inspectionDateTimePicker.Size = new System.Drawing.Size(164, 20);
            this.inspectionDateTimePicker.TabIndex = 80;
            this.inspectionDateTimePicker.Value = new System.DateTime(2020, 6, 23, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(301, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 79;
            this.label3.Text = "Doctor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(301, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 78;
            this.label2.Text = "Department:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(301, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 77;
            this.label1.Text = "Inspection Date:";
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.OrangeRed;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.exitButton.Location = new System.Drawing.Point(473, 237);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 36);
            this.exitButton.TabIndex = 76;
            this.exitButton.Text = "CLOSE";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Lime;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.saveButton.ForeColor = System.Drawing.Color.Black;
            this.saveButton.Location = new System.Drawing.Point(392, 237);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 36);
            this.saveButton.TabIndex = 75;
            this.saveButton.Text = "ADD";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // departmenttxt
            // 
            this.departmenttxt.Location = new System.Drawing.Point(392, 163);
            this.departmenttxt.Name = "departmenttxt";
            this.departmenttxt.Size = new System.Drawing.Size(164, 20);
            this.departmenttxt.TabIndex = 101;
            // 
            // doctortxt
            // 
            this.doctortxt.Location = new System.Drawing.Point(392, 189);
            this.doctortxt.Name = "doctortxt";
            this.doctortxt.Size = new System.Drawing.Size(164, 20);
            this.doctortxt.TabIndex = 102;
            // 
            // complaintTextBox
            // 
            this.complaintTextBox.Location = new System.Drawing.Point(392, 54);
            this.complaintTextBox.Multiline = true;
            this.complaintTextBox.Name = "complaintTextBox";
            this.complaintTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.complaintTextBox.Size = new System.Drawing.Size(164, 89);
            this.complaintTextBox.TabIndex = 137;
            // 
            // firstname
            // 
            this.firstname.AutoSize = true;
            this.firstname.Location = new System.Drawing.Point(43, 54);
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(60, 13);
            this.firstname.TabIndex = 138;
            this.firstname.Text = "First Name:";
            // 
            // lastname
            // 
            this.lastname.AutoSize = true;
            this.lastname.Location = new System.Drawing.Point(43, 80);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(61, 13);
            this.lastname.TabIndex = 139;
            this.lastname.Text = "Last Name:";
            // 
            // gender
            // 
            this.gender.AutoSize = true;
            this.gender.Location = new System.Drawing.Point(43, 106);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(45, 13);
            this.gender.TabIndex = 140;
            this.gender.Text = "Gender:";
            // 
            // birthdate
            // 
            this.birthdate.AutoSize = true;
            this.birthdate.Location = new System.Drawing.Point(43, 136);
            this.birthdate.Name = "birthdate";
            this.birthdate.Size = new System.Drawing.Size(55, 13);
            this.birthdate.TabIndex = 141;
            this.birthdate.Text = "Birth date:";
            // 
            // birthplace
            // 
            this.birthplace.AutoSize = true;
            this.birthplace.Location = new System.Drawing.Point(42, 159);
            this.birthplace.Name = "birthplace";
            this.birthplace.Size = new System.Drawing.Size(60, 13);
            this.birthplace.TabIndex = 142;
            this.birthplace.Text = "Birth place:";
            // 
            // fathername
            // 
            this.fathername.AutoSize = true;
            this.fathername.Location = new System.Drawing.Point(35, 185);
            this.fathername.Name = "fathername";
            this.fathername.Size = new System.Drawing.Size(76, 13);
            this.fathername.TabIndex = 143;
            this.fathername.Text = "Father\'s name:";
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Location = new System.Drawing.Point(43, 211);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(41, 13);
            this.phone.TabIndex = 144;
            this.phone.Text = "Phone:";
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Location = new System.Drawing.Point(42, 234);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(48, 13);
            this.address.TabIndex = 145;
            this.address.Text = "Address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(301, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 146;
            this.label4.Text = "Illness:";
            // 
            // frmAddPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 334);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.address);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.fathername);
            this.Controls.Add(this.birthplace);
            this.Controls.Add(this.birthdate);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.lastname);
            this.Controls.Add(this.firstname);
            this.Controls.Add(this.complaintTextBox);
            this.Controls.Add(this.departmenttxt);
            this.Controls.Add(this.doctortxt);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.birth_dateDateTimePicker);
            this.Controls.Add(this.birth_placeTextBox);
            this.Controls.Add(this.father_nameTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.gendercombo);
            this.Controls.Add(ssnLabel);
            this.Controls.Add(this.ssnTextBox1);
            this.Controls.Add(this.lastnametxt);
            this.Controls.Add(this.inspectionDateTimePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.saveButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddPatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Patient Form";
            this.Load += new System.EventHandler(this.FrmAddPatient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.DateTimePicker birth_dateDateTimePicker;
        private System.Windows.Forms.TextBox birth_placeTextBox;
        private System.Windows.Forms.TextBox father_nameTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.ComboBox gendercombo;
        private System.Windows.Forms.TextBox ssnTextBox1;
        private System.Windows.Forms.TextBox lastnametxt;
        private System.Windows.Forms.DateTimePicker inspectionDateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox departmenttxt;
        private System.Windows.Forms.TextBox doctortxt;
        private System.Windows.Forms.TextBox complaintTextBox;
        private System.Windows.Forms.Label firstname;
        private System.Windows.Forms.Label lastname;
        private System.Windows.Forms.Label gender;
        private System.Windows.Forms.Label birthdate;
        private System.Windows.Forms.Label birthplace;
        private System.Windows.Forms.Label fathername;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.Label label4;
    }
}