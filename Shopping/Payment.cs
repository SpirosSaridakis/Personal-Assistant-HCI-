using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shopping
{
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const string message = "Your Order has took place! Thank you!";
            const string caption = "Succesfull Order";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.OK);

        }
    }
}
