namespace WinFormsApp1
{
    partial class AddNewDonor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewDonor));
            label1 = new Label();
            label2 = new Label();
            txtGender = new ComboBox();
            txtDOB = new DateTimePicker();
            labelNewID = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtName = new TextBox();
            txtMother = new TextBox();
            txtEmail = new TextBox();
            txtMobile = new TextBox();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            txtBG = new ComboBox();
            txtCity = new TextBox();
            txtFather = new TextBox();
            txtAddress = new RichTextBox();
            btnsave = new Button();
            btnReset = new Button();
            btnClose = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Comic Sans MS", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(269, 10);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(268, 38);
            label1.TabIndex = 0;
            label1.Text = "ADD NEW DONOR";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label2.Location = new Point(95, 98);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(102, 16);
            label2.TabIndex = 1;
            label2.Text = "New Donor ID";
            // 
            // txtGender
            // 
            txtGender.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGender.FormattingEnabled = true;
            txtGender.Items.AddRange(new object[] { "Male", "Female" });
            txtGender.Location = new Point(221, 383);
            txtGender.Margin = new Padding(4, 3, 4, 3);
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(163, 24);
            txtGender.TabIndex = 3;
            txtGender.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // txtDOB
            // 
            txtDOB.Location = new Point(221, 302);
            txtDOB.Margin = new Padding(4, 3, 4, 3);
            txtDOB.Name = "txtDOB";
            txtDOB.Size = new Size(163, 22);
            txtDOB.TabIndex = 4;
            // 
            // labelNewID
            // 
            labelNewID.AutoSize = true;
            labelNewID.BackColor = Color.Transparent;
            labelNewID.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNewID.ForeColor = Color.RosyBrown;
            labelNewID.Location = new Point(221, 98);
            labelNewID.Margin = new Padding(4, 0, 4, 0);
            labelNewID.Name = "labelNewID";
            labelNewID.Size = new Size(21, 24);
            labelNewID.TabIndex = 1;
            labelNewID.Text = "1";
            labelNewID.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label4.Location = new Point(95, 342);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(78, 16);
            label4.TabIndex = 1;
            label4.Text = "Mobile No";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label5.Location = new Point(95, 308);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(94, 16);
            label5.TabIndex = 1;
            label5.Text = "Date Of Birth";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label6.Location = new Point(96, 269);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(99, 16);
            label6.TabIndex = 1;
            label6.Text = "Mother Name";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label7.Location = new Point(95, 211);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(96, 16);
            label7.TabIndex = 1;
            label7.Text = "Father Name";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label8.Location = new Point(95, 157);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(48, 16);
            label8.TabIndex = 1;
            label8.Text = "Name";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label9.Location = new Point(96, 391);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(58, 16);
            label9.TabIndex = 1;
            label9.Text = "Gender";
            // 
            // txtName
            // 
            txtName.Location = new Point(221, 157);
            txtName.Margin = new Padding(4, 3, 4, 3);
            txtName.Name = "txtName";
            txtName.Size = new Size(163, 22);
            txtName.TabIndex = 2;
            txtName.TextChanged += textBox2_TextChanged;
            // 
            // txtMother
            // 
            txtMother.Location = new Point(221, 263);
            txtMother.Margin = new Padding(4, 3, 4, 3);
            txtMother.Name = "txtMother";
            txtMother.Size = new Size(163, 22);
            txtMother.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(670, 118);
            txtEmail.Margin = new Padding(4, 3, 4, 3);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(163, 22);
            txtEmail.TabIndex = 2;
            // 
            // txtMobile
            // 
            txtMobile.Location = new Point(221, 339);
            txtMobile.Margin = new Padding(4, 3, 4, 3);
            txtMobile.Name = "txtMobile";
            txtMobile.Size = new Size(163, 22);
            txtMobile.TabIndex = 2;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label10.Location = new Point(509, 122);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(46, 16);
            label10.TabIndex = 1;
            label10.Text = "Email";
            label10.Click += label10_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label11.Location = new Point(509, 187);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(94, 16);
            label11.TabIndex = 1;
            label11.Text = "Blood Group";
            label11.Click += label11_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label12.Location = new Point(509, 302);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(65, 16);
            label12.TabIndex = 1;
            label12.Text = "Address";
            label12.Click += label12_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label13.Location = new Point(509, 246);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(33, 16);
            label13.TabIndex = 1;
            label13.Text = "City";
            label13.Click += label11_Click;
            // 
            // txtBG
            // 
            txtBG.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBG.FormattingEnabled = true;
            txtBG.Items.AddRange(new object[] { "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-" });
            txtBG.Location = new Point(670, 178);
            txtBG.Margin = new Padding(4, 3, 4, 3);
            txtBG.Name = "txtBG";
            txtBG.Size = new Size(163, 24);
            txtBG.TabIndex = 3;
            txtBG.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(670, 243);
            txtCity.Margin = new Padding(4, 3, 4, 3);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(163, 22);
            txtCity.TabIndex = 2;
            // 
            // txtFather
            // 
            txtFather.Location = new Point(221, 211);
            txtFather.Margin = new Padding(4, 3, 4, 3);
            txtFather.Name = "txtFather";
            txtFather.Size = new Size(163, 22);
            txtFather.TabIndex = 2;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(673, 314);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(165, 131);
            txtAddress.TabIndex = 5;
            txtAddress.Text = "";
            // 
            // btnsave
            // 
            btnsave.Image = (Image)resources.GetObject("btnsave.Image");
            btnsave.ImageAlign = ContentAlignment.MiddleLeft;
            btnsave.Location = new Point(262, 466);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(71, 33);
            btnsave.TabIndex = 7;
            btnsave.Text = "Save";
            btnsave.TextAlign = ContentAlignment.MiddleRight;
            btnsave.UseVisualStyleBackColor = true;
            btnsave.Click += btnsave_Click;
            // 
            // btnReset
            // 
            btnReset.Image = (Image)resources.GetObject("btnReset.Image");
            btnReset.ImageAlign = ContentAlignment.MiddleLeft;
            btnReset.Location = new Point(394, 466);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(74, 33);
            btnReset.TabIndex = 7;
            btnReset.Text = "Reset";
            btnReset.TextAlign = ContentAlignment.MiddleRight;
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnClose
            // 
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(535, 466);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(71, 33);
            btnClose.TabIndex = 7;
            btnClose.Text = "Close";
            btnClose.TextAlign = ContentAlignment.MiddleRight;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.InfoText;
            textBox1.Cursor = Cursors.No;
            textBox1.ForeColor = SystemColors.Menu;
            textBox1.Location = new Point(713, 477);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 22);
            textBox1.TabIndex = 8;
            textBox1.Text = "BLOOD";
            // 
            // AddNewDonor
            // 
            AutoScaleDimensions = new SizeF(9F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(905, 527);
            Controls.Add(textBox1);
            Controls.Add(btnClose);
            Controls.Add(btnReset);
            Controls.Add(btnsave);
            Controls.Add(txtAddress);
            Controls.Add(txtDOB);
            Controls.Add(txtBG);
            Controls.Add(txtGender);
            Controls.Add(txtMobile);
            Controls.Add(txtEmail);
            Controls.Add(txtMother);
            Controls.Add(txtName);
            Controls.Add(txtFather);
            Controls.Add(txtCity);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label9);
            Controls.Add(label4);
            Controls.Add(labelNewID);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            Margin = new Padding(4, 3, 4, 3);
            Name = "AddNewDonor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddNewDonor";
            Load += AddNewDonor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox txtGender;
        private DateTimePicker txtDOB;
        private Label labelNewID;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txtName;
        private TextBox txtMother;
        private TextBox txtEmail;
        private TextBox txtMobile;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private ComboBox txtBG;
        private TextBox txtCity;
        private TextBox txtFather;
        private RichTextBox txtAddress;
        private Button btnsave;
        private Button btnReset;
        private Button btnClose;
        private TextBox textBox1;
    }
}