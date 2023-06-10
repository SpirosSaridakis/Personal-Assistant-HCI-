using EmailClient;
using Forms_Appointments;
using SettingsForm;
using Shopping;
using MusicPlayer;

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

        private void button11_Click(object sender, EventArgs e)
        {
            var newform = new ShoppingList();
            newform.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            var newform = new MusicPlayer.MusicPlayerWin();
            newform.Show();
        }
    }
}