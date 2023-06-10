

namespace Shopping
{
    public partial class ShoppingList : Form
    {
        public ShoppingList()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var newform = new Order();
            newform.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.textBox1.Text)) { return; }
            listBox1.Items.Add(this.textBox1.Text + ", " + this.textBox2.Text + " $");
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }
    }
}