using EmailClient;
using Forms_Appointments;
using SettingsForm;

namespace PersonalAssistant
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var newform = new WebMail();
            newform.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var newform = new Settings();
            newform.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            var newform = new Calendar();
            newform.Show();
        }
    }
}