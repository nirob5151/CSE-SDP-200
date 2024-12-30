
namespace WinFormsApp1
{
    partial class FirstPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstPage));
            panel1 = new Panel();
            txtE = new Button();
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
            panel1.Controls.Add(txtE);
            panel1.Controls.Add(btnUser);
            panel1.Controls.Add(btnadmin);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(50, 40);
            panel1.Name = "panel1";
            panel1.Size = new Size(409, 536);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // txtE
            // 
            txtE.BackColor = Color.IndianRed;
            txtE.FlatStyle = FlatStyle.Popup;
            txtE.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtE.ForeColor = Color.MistyRose;
            txtE.Location = new Point(125, 382);
            txtE.Name = "txtE";
            txtE.Size = new Size(160, 33);
            txtE.TabIndex = 3;
            txtE.Text = "Emergency Contact";
            txtE.UseVisualStyleBackColor = false;
            txtE.Click += txtE_Click_1;
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
            btnUser.Text = "User Panel";
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
            btnadmin.Text = "Admin Panel";
            btnadmin.UseVisualStyleBackColor = false;
            btnadmin.Click += btnAdmin_Click;
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
            pictureBox1.Click += pictureBox1_Click;
            // 
            // FirstPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(538, 650);
            Controls.Add(panel1);
            Name = "FirstPage";
            Text = "FirstPage";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void panel1_Paint(object sender, PaintEventArgs e) => panel1.Paint += this.panel1_Paint;

        #endregion

        private Panel panel1;
        private Button btnUser;
        private Button btnadmin;
        private PictureBox pictureBox1;
        private Button txtE;
    }
}