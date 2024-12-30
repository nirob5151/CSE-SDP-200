namespace WinFormsApp1
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            panel1 = new Panel();
            btnUser = new Button();
            btnadmin = new Button();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.RosyBrown;
            panel1.Controls.Add(btnUser);
            panel1.Controls.Add(btnadmin);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(27, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(409, 536);
            panel1.TabIndex = 2;
            // 
            // btnUser
            // 
            btnUser.BackColor = Color.IndianRed;
            btnUser.FlatStyle = FlatStyle.Popup;
            btnUser.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUser.ForeColor = Color.MistyRose;
            btnUser.Location = new Point(123, 310);
            btnUser.Name = "btnUser";
            btnUser.Size = new Size(160, 33);
            btnUser.TabIndex = 1;
            btnUser.Text = "SHOW ALL DONOR";
            btnUser.UseVisualStyleBackColor = false;
            btnUser.Click += btnUser_Click;
            // 
            // btnadmin
            // 
            btnadmin.BackColor = Color.IndianRed;
            btnadmin.FlatStyle = FlatStyle.Popup;
            btnadmin.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnadmin.ForeColor = Color.MistyRose;
            btnadmin.Location = new Point(123, 233);
            btnadmin.Name = "btnadmin";
            btnadmin.Size = new Size(160, 33);
            btnadmin.TabIndex = 1;
            btnadmin.Text = "User REG";
            btnadmin.UseVisualStyleBackColor = false;
            btnadmin.Click += btnadmin_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(76, 35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(263, 99);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(455, 574);
            Controls.Add(panel1);
            Name = "Form3";
            Text = "Form3";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnUser;
        private Button btnadmin;
        private PictureBox pictureBox1;
    }
}