namespace WinFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            button1 = new Button();
            btnHideShow = new LinkLabel();
            btnLogin = new Button();
            checkBox = new CheckBox();
            txtPassword = new TextBox();
            txtUserName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.RosyBrown;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnHideShow);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(checkBox);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtUserName);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(112, 32);
            panel1.Name = "panel1";
            panel1.Size = new Size(478, 560);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(255, 456);
            button1.Name = "button1";
            button1.Size = new Size(97, 30);
            button1.TabIndex = 6;
            button1.Text = "SIGN Up";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnHideShow
            // 
            btnHideShow.AutoSize = true;
            btnHideShow.Location = new Point(234, 330);
            btnHideShow.Name = "btnHideShow";
            btnHideShow.Size = new Size(36, 15);
            btnHideShow.TabIndex = 5;
            btnHideShow.TabStop = true;
            btnHideShow.Text = "Show";
            btnHideShow.LinkClicked += btnHideShow_LinkClicked;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.White;
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.Location = new Point(105, 456);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(97, 30);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // checkBox
            // 
            checkBox.AutoSize = true;
            checkBox.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            checkBox.Location = new Point(115, 386);
            checkBox.Name = "checkBox";
            checkBox.Size = new Size(68, 20);
            checkBox.TabIndex = 3;
            checkBox.Text = "Accept\r\n";
            checkBox.UseVisualStyleBackColor = true;
            checkBox.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Microsoft Sans Serif", 9.75F);
            txtPassword.Location = new Point(106, 348);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(164, 22);
            txtPassword.TabIndex = 2;
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Microsoft Sans Serif", 9.75F);
            txtUserName.Location = new Point(105, 250);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(164, 22);
            txtUserName.TabIndex = 2;
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft Sans Serif", 12F);
            label2.Image = (Image)resources.GetObject("label2.Image");
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(105, 294);
            label2.Name = "label2";
            label2.Size = new Size(106, 51);
            label2.TabIndex = 1;
            label2.Text = "Password";
            label2.TextAlign = ContentAlignment.MiddleRight;
            label2.Click += label1_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 12F);
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(106, 201);
            label1.Name = "label1";
            label1.Size = new Size(114, 35);
            label1.TabIndex = 1;
            label1.Text = "User Name";
            label1.TextAlign = ContentAlignment.MiddleRight;
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(106, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(263, 99);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1070, 775);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Login";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox txtUserName;
        private Label label2;
        private CheckBox checkBox;
        private TextBox txtPassword;
        private Button btnLogin;
        private LinkLabel btnHideShow;
        private Button button1;
    }
}
