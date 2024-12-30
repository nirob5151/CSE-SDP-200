namespace WinFormsApp1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            nameLabel = new Label();
            nameTextBox = new TextBox();
            emailLabel = new Label();
            emailTextBox = new TextBox();
            messageLabel = new Label();
            messageTextBox = new RichTextBox();
            sendButton = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(225, 172);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(42, 15);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(328, 172);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(200, 23);
            nameTextBox.TabIndex = 1;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(225, 248);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(39, 15);
            emailLabel.TabIndex = 2;
            emailLabel.Text = "Email:";
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(328, 248);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(200, 23);
            emailTextBox.TabIndex = 3;
            // 
            // messageLabel
            // 
            messageLabel.AutoSize = true;
            messageLabel.Location = new Point(225, 343);
            messageLabel.Name = "messageLabel";
            messageLabel.Size = new Size(56, 15);
            messageLabel.TabIndex = 4;
            messageLabel.Text = "Message:";
            // 
            // messageTextBox
            // 
            messageTextBox.Location = new Point(328, 343);
            messageTextBox.Name = "messageTextBox";
            messageTextBox.Size = new Size(200, 150);
            messageTextBox.TabIndex = 5;
            messageTextBox.Text = "";
            // 
            // sendButton
            // 
            sendButton.Location = new Point(359, 515);
            sendButton.Name = "sendButton";
            sendButton.Size = new Size(135, 31);
            sendButton.TabIndex = 6;
            sendButton.Text = "Send Message";
            sendButton.UseVisualStyleBackColor = true;
            sendButton.Click += sendButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(290, 39);
            label1.Name = "label1";
            label1.Size = new Size(204, 32);
            label1.TabIndex = 7;
            label1.Text = "Emergency Contact";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(792, 654);
            Controls.Add(label1);
            Controls.Add(sendButton);
            Controls.Add(messageTextBox);
            Controls.Add(emailTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(messageLabel);
            Controls.Add(emailLabel);
            Controls.Add(nameLabel);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameLabel;
        private TextBox nameTextBox;
        private Label emailLabel;
        private TextBox emailTextBox;
        private Label messageLabel;
        private RichTextBox messageTextBox;
        private Button sendButton;
        private Label label1;
    }
}
