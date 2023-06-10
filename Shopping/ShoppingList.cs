

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
            var newform = new Shopping.Order();
            newform.Show();
        }
    }
}