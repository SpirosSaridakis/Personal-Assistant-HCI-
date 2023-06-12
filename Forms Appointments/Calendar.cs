namespace Forms_Appointments
{
    public partial class Calendar : Form
    {
        public Calendar()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            else
            {
                const string message = "There is no Event to Delete";
                const string caption = "Delete";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK);

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.textBox1.Text) || string.IsNullOrWhiteSpace(this.comboBox1.Text))
            {
                const string message = "To Create an Event you have to type the Event Title and to Choose the Time";
                const string caption = "Create";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.OK);
            }
            else
            {
                listBox1.Items.Add(this.textBox1.Text + ", " + this.dateTimePicker1.Text + ", " + this.comboBox1.Text);
                textBox1.Clear();
                textBox1.Focus();

            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}