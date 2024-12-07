namespace FrmClubRegistration
{
    partial class FrmClubRegistration
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            cbProgram = new ComboBox();
            cbGender = new ComboBox();
            txtAge = new TextBox();
            label7 = new Label();
            label6 = new Label();
            txtMiddleName = new TextBox();
            label5 = new Label();
            txtFirstName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            txtLastName = new TextBox();
            label1 = new Label();
            txtStudID = new TextBox();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            groupBox1 = new GroupBox();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(cbProgram);
            panel1.Controls.Add(cbGender);
            panel1.Controls.Add(txtAge);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtMiddleName);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtFirstName);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtLastName);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtStudID);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(849, 223);
            panel1.TabIndex = 0;
            // 
            // cbProgram
            // 
            cbProgram.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbProgram.DropDownStyle = ComboBoxStyle.DropDownList;
            cbProgram.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbProgram.FormattingEnabled = true;
            cbProgram.Items.AddRange(new object[] { "BS in Computer Science", "BS in Information Technology", "BS in Business Accountancy" });
            cbProgram.Location = new Point(576, 35);
            cbProgram.Name = "cbProgram";
            cbProgram.Size = new Size(267, 29);
            cbProgram.TabIndex = 19;
            // 
            // cbGender
            // 
            cbGender.Anchor = AnchorStyles.Top;
            cbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGender.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbGender.FormattingEnabled = true;
            cbGender.Items.AddRange(new object[] { "Male", "Female", "Others" });
            cbGender.Location = new Point(261, 161);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(269, 29);
            cbGender.TabIndex = 18;
            // 
            // txtAge
            // 
            txtAge.Font = new Font("Segoe UI", 12F);
            txtAge.Location = new Point(6, 161);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(249, 29);
            txtAge.TabIndex = 17;
            txtAge.KeyPress += txtStudID_KeyPress;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(261, 137);
            label7.Name = "label7";
            label7.Size = new Size(64, 21);
            label7.TabIndex = 16;
            label7.Text = "Gender:";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(576, 11);
            label6.Name = "label6";
            label6.Size = new Size(74, 21);
            label6.TabIndex = 14;
            label6.Text = "Program:";
            // 
            // txtMiddleName
            // 
            txtMiddleName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtMiddleName.Font = new Font("Segoe UI", 12F);
            txtMiddleName.Location = new Point(576, 94);
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.Size = new Size(267, 29);
            txtMiddleName.TabIndex = 13;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(576, 70);
            label5.Name = "label5";
            label5.Size = new Size(107, 21);
            label5.TabIndex = 12;
            label5.Text = "Middle Name:";
            // 
            // txtFirstName
            // 
            txtFirstName.Anchor = AnchorStyles.Top;
            txtFirstName.Font = new Font("Segoe UI", 12F);
            txtFirstName.Location = new Point(261, 94);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(309, 29);
            txtFirstName.TabIndex = 11;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(261, 71);
            label4.Name = "label4";
            label4.Size = new Size(89, 21);
            label4.TabIndex = 10;
            label4.Text = "First Name:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(6, 137);
            label3.Name = "label3";
            label3.Size = new Size(40, 21);
            label3.TabIndex = 8;
            label3.Text = "Age:";
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 12F);
            txtLastName.Location = new Point(6, 94);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(249, 29);
            txtLastName.TabIndex = 7;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(6, 70);
            label1.Name = "label1";
            label1.Size = new Size(87, 21);
            label1.TabIndex = 6;
            label1.Text = "Last Name:";
            // 
            // txtStudID
            // 
            txtStudID.Font = new Font("Segoe UI", 12F);
            txtStudID.Location = new Point(6, 35);
            txtStudID.Name = "txtStudID";
            txtStudID.Size = new Size(249, 29);
            txtStudID.TabIndex = 5;
            txtStudID.KeyPress += txtStudID_KeyPress;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(6, 11);
            label2.Name = "label2";
            label2.Size = new Size(85, 21);
            label2.TabIndex = 4;
            label2.Text = "Student ID:";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(867, 12);
            button1.Name = "button1";
            button1.Size = new Size(107, 43);
            button1.TabIndex = 1;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.Font = new Font("Segoe UI", 12F);
            button2.Location = new Point(867, 61);
            button2.Name = "button2";
            button2.Size = new Size(107, 43);
            button2.TabIndex = 2;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Font = new Font("Segoe UI", 12F);
            groupBox1.Location = new Point(12, 241);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(962, 197);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "List Of Club Members";
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button3.Font = new Font("Segoe UI", 12F);
            button3.Location = new Point(849, 28);
            button3.Name = "button3";
            button3.Size = new Size(107, 43);
            button3.TabIndex = 4;
            button3.Text = "Refresh";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 28);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(837, 163);
            dataGridView1.TabIndex = 0;
            // 
            // FrmClubRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(986, 450);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel1);
            Name = "FrmClubRegistration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += FrmClubRegistration_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Button button2;
        private GroupBox groupBox1;
        private Button button3;
        private DataGridView dataGridView1;
        private TextBox txtAge;
        private Label label7;
        private Label label6;
        private TextBox txtMiddleName;
        private Label label5;
        private TextBox txtFirstName;
        private Label label4;
        private Label label3;
        private TextBox txtLastName;
        private Label label1;
        private TextBox txtStudID;
        private Label label2;
        private ComboBox cbProgram;
        private ComboBox cbGender;
    }
}
