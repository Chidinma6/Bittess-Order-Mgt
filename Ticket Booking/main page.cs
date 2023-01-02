using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticket_Booking
{
    public partial class main_page : Form
    {
        public main_page()
        {
            InitializeComponent();
        }

        private void BookingIcon_Click(object sender, EventArgs e)
        {
            order_menu newForm = new order_menu();    //Create the New Form Object
            this.Hide();    //Hide the Old Form
            newForm.ShowDialog();    //Show the New Form
            this.Close();    //Close the Old Form
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login newForm = new Login();    //Create the New Form Object
            this.Hide();    //Hide the Old Form
            newForm.ShowDialog();    //Show the New Form
            this.Close();    //Close the Old Form
        }

        private void HistoryIcon_Click(object sender, EventArgs e)
        {
            order_history newForm = new order_history();    //Create the New Form Object
            this.Hide();    //Hide the Old Form
            newForm.ShowDialog();    //Show the New Form
            this.Close();    //Close the Old Form

        }
    }
}
