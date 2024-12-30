using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Initialization if necessary
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            string userName = nameTextBox.Text;
            string userEmail = emailTextBox.Text;
            string userMessage = messageTextBox.Text;

            // Validate input fields
            if (string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(userEmail) || string.IsNullOrWhiteSpace(userMessage))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate email format
            if (!Regex.IsMatch(userEmail, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Admin email configuration
                string adminEmail = "neamulhasanbulbul@gmail.com";
                string fromMail = "neamulhasanbulbul@gmail.com";
                string fromPassword = "dskl spat lnct sbzq"; // Use your app-specific password here (better to store it securely)

                string subject = $"Message from {userName}";
                string body = $@"
                    <html>
                        <body>
                            <h2>User Contact Request</h2>
                            <p><strong>Name:</strong> {userName}</p>
                            <p><strong>Email:</strong> {userEmail}</p>
                            <p><strong>Message:</strong> {userMessage}</p>
                            <br>
                            <p>Please respond to the user at <a href='mailto:{userEmail}'>{userEmail}</a>.</p>
                        </body>
                    </html>";

                // Create a new MailMessage object
                MailMessage message = new MailMessage
                {
                    From = new MailAddress(fromMail),
                    Subject = subject,
                    Body = body,
                    IsBodyHtml = true // Set the email body as HTML
                };

                message.To.Add(new MailAddress(adminEmail)); // Set the recipient email address

                // Configure SMTP client with SSL and port 587 (or 465 if needed)
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587, // Use port 587 for TLS
                    Credentials = new NetworkCredential(fromMail, fromPassword),
                    EnableSsl = true // Enable TLS encryption
                };

                // Send the email
                smtpClient.Send(message);
                MessageBox.Show("Your message has been sent to the admin.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SmtpException smtpEx)
            {
                // Detailed SMTP error handling
                MessageBox.Show($"SMTP Error: {smtpEx.Message}\nStatusCode: {smtpEx.StatusCode}\n{smtpEx.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // General error handling
                MessageBox.Show($"Failed to send the message. Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
