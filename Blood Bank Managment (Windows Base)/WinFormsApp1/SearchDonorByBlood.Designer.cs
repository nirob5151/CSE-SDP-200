namespace WinFormsApp1
{
    partial class SearchDonorByBlood
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchDonorByBlood));
            txtDonnorID2 = new TextBox();
            label2 = new Label();
            button2 = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtDonnorID2
            // 
            txtDonnorID2.Location = new Point(255, 65);
            txtDonnorID2.Name = "txtDonnorID2";
            txtDonnorID2.Size = new Size(127, 23);
            txtDonnorID2.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(140, 68);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 13;
            label2.Text = "  Blood Group";
            label2.TextAlign = ContentAlignment.MiddleRight;
            label2.Click += label2_Click;
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(599, 425);
            button2.Name = "button2";
            button2.Size = new Size(83, 35);
            button2.TabIndex = 11;
            button2.Text = "Close ";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(85, 425);
            button1.Name = "button1";
            button1.Size = new Size(75, 35);
            button1.TabIndex = 12;
            button1.Text = "Print";
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(11, 126);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(681, 264);
            dataGridView1.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(100, 9);
            label1.Name = "label1";
            label1.Size = new Size(472, 37);
            label1.TabIndex = 9;
            label1.Text = "SEARCH BLOOD DONOR (ADDRESS)";
            label1.Click += label1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(422, 68);
            button3.Name = "button3";
            button3.Size = new Size(71, 19);
            button3.TabIndex = 15;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // SearchDonorByBlood
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(704, 494);
            Controls.Add(button3);
            Controls.Add(txtDonnorID2);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "SearchDonorByBlood";
            Text = "SearchDonorByBlood";
            Load += SearchDonorByBlood_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDonnorID2;
        private Label label2;
        private Button button2;
        private Button button1;
        private DataGridView dataGridView1;
        private Label label1;
        private Button button3;
    }
}