namespace WinFormsApp1
{
    partial class StokIncrease
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StokIncrease));
            label2 = new Label();
            button2 = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            button3 = new Button();
            label3 = new Label();
            txtBG = new ComboBox();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(364, 89);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 19;
            label2.Text = "Units";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(600, 438);
            button2.Name = "button2";
            button2.Size = new Size(83, 35);
            button2.TabIndex = 17;
            button2.Text = "Close ";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(86, 438);
            button1.Name = "button1";
            button1.Size = new Size(75, 35);
            button1.TabIndex = 18;
            button1.Text = "Print";
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 139);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(681, 264);
            dataGridView1.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(101, 22);
            label1.Name = "label1";
            label1.Size = new Size(472, 37);
            label1.TabIndex = 15;
            label1.Text = "SEARCH BLOOD DONOR (ADDRESS)";
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(600, 78);
            button3.Name = "button3";
            button3.Size = new Size(75, 35);
            button3.TabIndex = 18;
            button3.Text = "Increase";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ImageAlign = ContentAlignment.MiddleLeft;
            label3.Location = new Point(52, 89);
            label3.Name = "label3";
            label3.Size = new Size(80, 15);
            label3.TabIndex = 19;
            label3.Text = "  Blood Group";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtBG
            // 
            txtBG.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBG.FormattingEnabled = true;
            txtBG.Items.AddRange(new object[] { "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-" });
            txtBG.Location = new Point(139, 86);
            txtBG.Margin = new Padding(4, 3, 4, 3);
            txtBG.Name = "txtBG";
            txtBG.Size = new Size(123, 24);
            txtBG.TabIndex = 21;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-" });
            comboBox1.Location = new Point(428, 85);
            comboBox1.Margin = new Padding(4, 3, 4, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(117, 24);
            comboBox1.TabIndex = 22;
            // 
            // StokIncrease
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(704, 494);
            Controls.Add(comboBox1);
            Controls.Add(txtBG);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "StokIncrease";
            Text = "StokIncrease";
            Load += StokIncrease_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Button button2;
        private Button button1;
        private DataGridView dataGridView1;
        private Label label1;
        private Button button3;
        private Label label3;
        private ComboBox txtBG;
        private ComboBox comboBox1;
    }
}