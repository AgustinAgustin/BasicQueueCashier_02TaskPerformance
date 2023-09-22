using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;
namespace BasicQueueCashier
{
    public partial class ServingForm : Form
    {
        public ServingForm()
        {
            InitializeComponent();
            Timer timer = new Timer();
            timer.Interval = (1 * 1000);
            timer.Tick += new EventHandler(ServingForm_Load);
            timer.Start();
        }

        private void ServingNumber_Click(object sender, EventArgs e)
        {

        }

        private void ServingForm_Load(object sender, EventArgs e)
        {
            ServingNumber.Text = CashierClass.CashierQueue.Peek();
        }
    }
}
