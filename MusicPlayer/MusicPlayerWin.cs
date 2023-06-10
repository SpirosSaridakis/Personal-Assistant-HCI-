namespace MusicPlayer
{
    public partial class MusicPlayerWin : Form
    {
        public MusicPlayerWin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private Mp3Player mp3Player = new Mp3Player();

        private void button2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Mp3 Files| *.mp3";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    mp3Player.open(ofd.FileName);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            mp3Player.play();
        }
    }
}