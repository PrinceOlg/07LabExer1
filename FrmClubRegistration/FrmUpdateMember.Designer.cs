namespace FrmClubRegistration
{
    partial class FrmUpdateMember
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
            label1 = new Label();
            txtLastName = new TextBox();
            label2 = new Label();
            txtFirstName = new TextBox();
            label3 = new Label();
            txtMiddleName = new TextBox();
            label4 = new Label();
            txtAge = new TextBox();
            label5 = new Label();
            cbStudentID = new ComboBox();
            cbGender = new ComboBox();
            label6 = new Label();
            cbProgram = new ComboBox();
            label7 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 63);
            label1.Name = "label1";
            label1.Size = new Size(85, 21);
            label1.TabIndex = 0;
            label1.Text = "Student ID:";
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 12F);
            txtLastName.Location = new Point(12, 144);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(265, 29);
            txtLastName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(12, 121);
            label2.Name = "label2";
            label2.Size = new Size(87, 21);
            label2.TabIndex = 2;
            label2.Text = "Last Name:";
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 12F);
            txtFirstName.Location = new Point(12, 203);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(265, 29);
            txtFirstName.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(12, 180);
            label3.Name = "label3";
            label3.Size = new Size(89, 21);
            label3.TabIndex = 4;
            label3.Text = "First Name:";
            label3.Click += label3_Click;
            // 
            // txtMiddleName
            // 
            txtMiddleName.Font = new Font("Segoe UI", 12F);
            txtMiddleName.Location = new Point(12, 261);
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.Size = new Size(265, 29);
            txtMiddleName.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(12, 239);
            label4.Name = "label4";
            label4.Size = new Size(107, 21);
            label4.TabIndex = 6;
            label4.Text = "Middle Name:";
            // 
            // txtAge
            // 
            txtAge.Font = new Font("Segoe UI", 12F);
            txtAge.Location = new Point(12, 320);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(265, 29);
            txtAge.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(12, 298);
            label5.Name = "label5";
            label5.Size = new Size(40, 21);
            label5.TabIndex = 8;
            label5.Text = "Age:";
            // 
            // cbStudentID
            // 
            cbStudentID.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStudentID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbStudentID.FormattingEnabled = true;
            cbStudentID.Location = new Point(12, 85);
            cbStudentID.Name = "cbStudentID";
            cbStudentID.Size = new Size(265, 29);
            cbStudentID.TabIndex = 10;
            cbStudentID.SelectedIndexChanged += cbStudentID_SelectedIndexChanged;
            // 
            // cbGender
            // 
            cbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGender.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbGender.FormattingEnabled = true;
            cbGender.Items.AddRange(new object[] { "Male", "Female" });
            cbGender.Location = new Point(12, 379);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(265, 29);
            cbGender.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(12, 357);
            label6.Name = "label6";
            label6.Size = new Size(64, 21);
            label6.TabIndex = 11;
            label6.Text = "Gender:";
            // 
            // cbProgram
            // 
            cbProgram.DropDownStyle = ComboBoxStyle.DropDownList;
            cbProgram.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbProgram.FormattingEnabled = true;
            cbProgram.Items.AddRange(new object[] { "BS in Computer Science", "BS in Information Technology", "BS in Business Accountancy" });
            cbProgram.Location = new Point(12, 438);
            cbProgram.Name = "cbProgram";
            cbProgram.Size = new Size(265, 29);
            cbProgram.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(12, 415);
            label7.Name = "label7";
            label7.Size = new Size(74, 21);
            label7.TabIndex = 13;
            label7.Text = "Program:";
            // 
            // button1
            // 
            button1.BackColor = Color.LightSteelBlue;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(80, 485);
            button1.Name = "button1";
            button1.Size = new Size(112, 36);
            button1.TabIndex = 15;
            button1.Text = "Confirm";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Coral;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.Black;
            button2.Location = new Point(12, 21);
            button2.Name = "button2";
            button2.Size = new Size(265, 23);
            button2.TabIndex = 16;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // FrmUpdateMember
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            ClientSize = new Size(289, 540);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(cbProgram);
            Controls.Add(label7);
            Controls.Add(cbGender);
            Controls.Add(label6);
            Controls.Add(cbStudentID);
            Controls.Add(txtAge);
            Controls.Add(label5);
            Controls.Add(txtMiddleName);
            Controls.Add(label4);
            Controls.Add(txtFirstName);
            Controls.Add(label3);
            Controls.Add(txtLastName);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.Navy;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmUpdateMember";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmUpdateMember";
            Load += FrmUpdateMember_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtLastName;
        private Label label2;
        private TextBox txtFirstName;
        private Label label3;
        private TextBox txtMiddleName;
        private Label label4;
        private TextBox txtAge;
        private Label label5;
        private ComboBox cbStudentID;
        private ComboBox cbGender;
        private Label label6;
        private ComboBox cbProgram;
        private Label label7;
        private Button button1;
        private Button button2;
    }
}