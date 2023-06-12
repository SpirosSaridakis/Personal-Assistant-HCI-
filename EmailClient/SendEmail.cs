namespace EmailClient
{
    public partial class SendEmail : Form
    {
        public static SendEmail? Current { get; set; }
        public SendEmail()
        {
            InitializeComponent();
            Current = this;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            var newform = new EmailAccount();
            newform.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.textBox1.Text)
                || string.IsNullOrWhiteSpace(this.textBox3.Text)
                || string.IsNullOrWhiteSpace(this.textBox4.Text))
            {
                const string message = "To Send an Email you have to sign field 'To', 'Subject', and 'Message'. ";
                const string caption = "Unsigned Fields";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.OK);
            }
            else
            {
                const string message = "Email has been Send Succesfully";
                const string caption = "Email Send";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.OK);

                Close();
            }
        }
    }
}