namespace WinFormsApp1
{
    partial class UpdateDonorDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateDonorDetails));
            label1 = new Label();
            label2 = new Label();
            txtDonnorID = new TextBox();
            button1 = new Button();
            textBox2 = new TextBox();
            btnClose = new Button();
            btnReset = new Button();
            btnUpdate = new Button();
            txtAddress = new RichTextBox();
            txtDOB = new DateTimePicker();
            txtBG = new ComboBox();
            txtGender = new ComboBox();
            txtMobile = new TextBox();
            txtEmail = new TextBox();
            txtMother = new TextBox();
            txtName = new TextBox();
            txtFather = new TextBox();
            txtCity = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label9 = new Label();
            label4 = new Label();
            label12 = new Label();
            label13 = new Label();
            label11 = new Label();
            label10 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(382, 44);
            label1.Name = "label1";
            label1.Size = new Size(393, 31);
            label1.TabIndex = 0;
            label1.Text = "UPDATE DPNNOR DETAILS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(322, 131);
            label2.Name = "label2";
            label2.Size = new Size(81, 17);
            label2.TabIndex = 1;
            label2.Text = "Donnor ID :";
            // 
            // txtDonnorID
            // 
            txtDonnorID.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDonnorID.Location = new Point(408, 126);
            txtDonnorID.Name = "txtDonnorID";
            txtDonnorID.Size = new Size(127, 25);
            txtDonnorID.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(561, 126);
            button1.Name = "button1";
            button1.Size = new Size(91, 26);
            button1.TabIndex = 3;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.InfoText;
            textBox2.Cursor = Cursors.No;
            textBox2.ForeColor = SystemColors.Menu;
            textBox2.Location = new Point(766, 580);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 35;
            textBox2.Text = "BLOOD";
            // 
            // btnClose
            // 
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(596, 574);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(77, 33);
            btnClose.TabIndex = 34;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnReset
            // 
            btnReset.Image = (Image)resources.GetObject("btnReset.Image");
            btnReset.ImageAlign = ContentAlignment.MiddleLeft;
            btnReset.Location = new Point(465, 574);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(82, 33);
            btnReset.TabIndex = 33;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Image = (Image)resources.GetObject("btnUpdate.Image");
            btnUpdate.ImageAlign = ContentAlignment.MiddleLeft;
            btnUpdate.Location = new Point(319, 574);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(81, 33);
            btnUpdate.TabIndex = 32;
            btnUpdate.Text = "Update";
            btnUpdate.TextAlign = ContentAlignment.MiddleRight;
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnsave_Click;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(726, 417);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(165, 131);
            txtAddress.TabIndex = 31;
            txtAddress.Text = "";
            // 
            // txtDOB
            // 
            txtDOB.Location = new Point(267, 374);
            txtDOB.Margin = new Padding(4, 3, 4, 3);
            txtDOB.Name = "txtDOB";
            txtDOB.Size = new Size(163, 23);
            txtDOB.TabIndex = 30;
            // 
            // txtBG
            // 
            txtBG.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBG.FormattingEnabled = true;
            txtBG.Items.AddRange(new object[] { "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-" });
            txtBG.Location = new Point(723, 281);
            txtBG.Margin = new Padding(4, 3, 4, 3);
            txtBG.Name = "txtBG";
            txtBG.Size = new Size(163, 24);
            txtBG.TabIndex = 29;
            // 
            // txtGender
            // 
            txtGender.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGender.FormattingEnabled = true;
            txtGender.Items.AddRange(new object[] { "Male", "Female" });
            txtGender.Location = new Point(267, 473);
            txtGender.Margin = new Padding(4, 3, 4, 3);
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(163, 24);
            txtGender.TabIndex = 28;
            // 
            // txtMobile
            // 
            txtMobile.Location = new Point(267, 429);
            txtMobile.Margin = new Padding(4, 3, 4, 3);
            txtMobile.Name = "txtMobile";
            txtMobile.Size = new Size(163, 23);
            txtMobile.TabIndex = 26;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(723, 221);
            txtEmail.Margin = new Padding(4, 3, 4, 3);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(163, 23);
            txtEmail.TabIndex = 25;
            // 
            // txtMother
            // 
            txtMother.Location = new Point(267, 335);
            txtMother.Margin = new Padding(4, 3, 4, 3);
            txtMother.Name = "txtMother";
            txtMother.Size = new Size(163, 23);
            txtMother.TabIndex = 24;
            // 
            // txtName
            // 
            txtName.Location = new Point(267, 226);
            txtName.Margin = new Padding(4, 3, 4, 3);
            txtName.Name = "txtName";
            txtName.Size = new Size(163, 23);
            txtName.TabIndex = 23;
            // 
            // txtFather
            // 
            txtFather.Location = new Point(267, 280);
            txtFather.Margin = new Padding(4, 3, 4, 3);
            txtFather.Name = "txtFather";
            txtFather.Size = new Size(163, 23);
            txtFather.TabIndex = 27;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(723, 346);
            txtCity.Margin = new Padding(4, 3, 4, 3);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(163, 23);
            txtCity.TabIndex = 22;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label8.Location = new Point(141, 226);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(48, 16);
            label8.TabIndex = 20;
            label8.Text = "Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label7.Location = new Point(141, 280);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(96, 16);
            label7.TabIndex = 19;
            label7.Text = "Father Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label6.Location = new Point(142, 341);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(99, 16);
            label6.TabIndex = 18;
            label6.Text = "Mother Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label5.Location = new Point(141, 380);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(94, 16);
            label5.TabIndex = 17;
            label5.Text = "Date Of Birth";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label9.Location = new Point(142, 481);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(58, 16);
            label9.TabIndex = 16;
            label9.Text = "Gender";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label4.Location = new Point(141, 432);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(78, 16);
            label4.TabIndex = 15;
            label4.Text = "Mobile No";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label12.Location = new Point(562, 405);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(65, 16);
            label12.TabIndex = 13;
            label12.Text = "Address";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label13.Location = new Point(562, 349);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(33, 16);
            label13.TabIndex = 12;
            label13.Text = "City";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label11.Location = new Point(562, 290);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(94, 16);
            label11.TabIndex = 11;
            label11.Text = "Blood Group";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label10.Location = new Point(562, 225);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(46, 16);
            label10.TabIndex = 10;
            label10.Text = "Email";
            // 
            // UpdateDonorDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1261, 717);
            Controls.Add(textBox2);
            Controls.Add(btnClose);
            Controls.Add(btnReset);
            Controls.Add(btnUpdate);
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
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(button1);
            Controls.Add(txtDonnorID);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UpdateDonorDetails";
            StartPosition = FormStartPosition.CenterParent;
            Text = "UpdateDonorDetails";
            Load += UpdateDonorDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtDonnorID;
        private Button button1;
        private TextBox textBox2;
        private Button btnClose;
        private Button btnReset;
        private Button btnUpdate;
        private RichTextBox txtAddress;
        private DateTimePicker txtDOB;
        private ComboBox txtBG;
        private ComboBox txtGender;
        private TextBox txtMobile;
        private TextBox txtEmail;
        private TextBox txtMother;
        private TextBox txtName;
        private TextBox txtFather;
        private TextBox txtCity;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label9;
        private Label label4;
        private Label label12;
        private Label label13;
        private Label label11;
        private Label label10;
    }
}