using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmailClient
{
    public partial class WebMail : Form
    {
        public WebMail()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newform = new SendEmail();
            newform.Show();
        }

        private void accountPropertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newform = new EmailAccount();
            newform.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newMailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newform = new SendEmail();
            newform.Show();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void propertyGrid1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.textBox1.Text) ||
                string.IsNullOrWhiteSpace(this.textBox2.Text) ||
                string.IsNullOrWhiteSpace(this.textBox3.Text) ||
                string.IsNullOrWhiteSpace(this.textBox4.Text))
            {
                const string message = "You have to select an Email first to Reply on it.";
                const string caption = "Reply";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.OK);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.textBox1.Text) ||
                string.IsNullOrWhiteSpace(this.textBox2.Text) ||
                string.IsNullOrWhiteSpace(this.textBox3.Text) ||
                string.IsNullOrWhiteSpace(this.textBox4.Text))
            {
                const string message = "You have to select an Email first to Forward it.";
                const string caption = "Forward";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.OK);
            }
        }
    }
}
