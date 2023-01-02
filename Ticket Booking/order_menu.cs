using System;
using System.Windows.Forms;

namespace Ticket_Booking
{
    public partial class order_menu : Form
    {
        const double Price_chips = 300;
        const double Price_cake = 200;
        const double Price_peanut =200;
        const double Price_cookies = 300;
        const double Price_water = 100;
        const double Price_coffee = 200;
        const double Price_cola = 250;
        const double Price_yoghurt = 300;
        const double Price_fries = 500;
        const double Price_salad = 500;
        const double Price_hamburger = 750;
        const double Price_sandwich = 300;
        const double Price_pancake = 800;
        const double Price_brownie = 400;
        const double Price_applePie = 700;
        const double Price_milkshake = 600;

        double Total, Change, Amount;

        public order_menu()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Food_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

            if (brownie.Checked == true)
            {
                txtBrownie.Enabled = true;
                txtBrownie.Text = "";
                txtBrownie.Focus();
            }
            else
            {
                txtBrownie.Enabled = false;
                txtBrownie.Text = "0";
            }
        }

        //================================ResetOrder=====================================================
        private void ResetOrder()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                {
                    if (control is TextBox)
                        (control as TextBox).Text = "0";
                    else
                        func(control.Controls);

                }

            };
            func(Controls);
        }

        //================================ResetCheckBoxes=====================================================
        private void ResetCheckBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                {
                    if (control is CheckBox)
                        (control as CheckBox).Checked = false;
                    else
                        func(control.Controls);
                }

            };
            func(Controls);
        }

        //================================EnableText=====================================================
        private void EnableText()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                {
                    if (control is TextBox)
                        (control as TextBox).Enabled = false;
                    else
                        func(control.Controls);
                }

            };
            func(Controls);
        }
        private void reset_Click(object sender, EventArgs e)
        {
            ResetOrder();
            ResetCheckBoxes();
        }

        private void order_menu_Load(object sender, EventArgs e)
        {
            EnableText();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chips.Checked == true)
            {
                txtChips.Enabled = true;
                txtChips.Text = "";
                txtChips.Focus();
            }
            else
            {
                txtChips.Enabled = false;
                txtChips.Text = "0";
            }
        }

        private void cake_CheckedChanged(object sender, EventArgs e)
        {
            if (cake.Checked == true)
            {
                txtCake.Enabled = true;
                txtCake.Text = "";
                txtCake.Focus();
            }
            else
            {
                txtCake.Enabled = false;
                txtCake.Text = "0";
            }

        }

        private void peanut_CheckedChanged(object sender, EventArgs e)
        {
            if (peanut.Checked == true)
            {
                txtPeanut.Enabled = true;
                txtPeanut.Text = "";
                txtPeanut.Focus();
            }
            else
            {
                txtPeanut.Enabled = false;
                txtPeanut.Text = "0";
            }


        }

        private void cookies_CheckedChanged(object sender, EventArgs e)
        {
            if (cookies.Checked == true)
            {
                txtCookies.Enabled = true;
                txtCookies.Text = "";
                txtCookies.Focus();
            }
            else
            {
                txtCookies.Enabled = false;
                txtCookies.Text = "0";
            }
        }

        private void water_CheckedChanged(object sender, EventArgs e)
        {
            if (water.Checked == true)
            {
                txtWater.Enabled = true;
                txtWater.Text = "";
                txtWater.Focus();
            }
            else
            {
                txtWater.Enabled = false;
                txtWater.Text = "0";
            }
        }

        private void coffee_CheckedChanged(object sender, EventArgs e)
        {
            if (coffee.Checked == true)
            {
                txtCoffee.Enabled = true;
                txtCoffee.Text = "";
                txtCoffee.Focus();
            }
            else
            {
                txtCoffee.Enabled = false;
                txtCoffee.Text = "0";
            }
        }

        private void cola_CheckedChanged(object sender, EventArgs e)
        {
            if (cola.Checked == true)
            {
                txtCola.Enabled = true;
                txtCola.Text = "";
                txtCola.Focus();
            }
            else
            {
                txtCola.Enabled = false;
                txtCola.Text = "0";
            }
        }

        private void yoghurt_CheckedChanged(object sender, EventArgs e)
        {
            if (yoghurt.Checked == true)
            {
                txtYoghurt.Enabled = true;
                txtYoghurt.Text = "";
                txtYoghurt.Focus();
            }
            else
            {
                txtYoghurt.Enabled = false;
                txtYoghurt.Text = "0";
            }
        }

        private void fries_CheckedChanged(object sender, EventArgs e)
        {

            if (fries.Checked == true)
            {
                txtFries.Enabled = true;
                txtFries.Text = "";
                txtFries.Focus();
            }
            else
            {
                txtFries.Enabled = false;
                txtFries.Text = "0";
            }
        }

        private void salad_CheckedChanged(object sender, EventArgs e)
        {
            if (salad.Checked == true)
            {
                txtSalad.Enabled = true;
                txtSalad.Text = "";
                txtSalad.Focus();
            }
            else
            {
                txtSalad.Enabled = false;
                txtSalad.Text = "0";
            }
        }

        private void hamburger_CheckedChanged(object sender, EventArgs e)
        {
            if (hamburger.Checked == true)
            {
                txtburger.Enabled = true;
                txtburger.Text = "";
                txtburger.Focus();
            }
            else
            {
                txtburger.Enabled = false;
                txtburger.Text = "0";
            }
        }

        private void sandwich_CheckedChanged(object sender, EventArgs e)
        {
            if (sandwich.Checked == true)
            {
                txtsandwich.Enabled = true;
                txtsandwich.Text = "";
                txtsandwich.Focus();
            }
            else
            {
                txtsandwich.Enabled = false;
                txtsandwich.Text = "0";
            }
        }

        private void Pancake_CheckedChanged(object sender, EventArgs e)
        {
            if (Pancake.Checked == true)
            {
                txtPancake.Enabled = true;
                txtPancake.Text = "";
                txtPancake.Focus();
            }
            else
            {
                txtPancake.Enabled = false;
                txtPancake.Text = "0";
            }
        }

        private void applePie_CheckedChanged(object sender, EventArgs e)
        {
            if (applePie.Checked == true)
            {
                txtApplePie.Enabled = true;
                txtApplePie.Text = "";
                txtApplePie.Focus();
               
            }   
            else
            {   
                txtApplePie.Enabled = false;
                txtApplePie.Text = "0";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Cash")
            {
                txtAmount.Enabled = true;
                txtAmount.Text = "";
                txtAmount.Focus();
            }
            else
            {
                txtAmount.Enabled = false;
                txtAmount.Text = "0.00";
                txtChange.Text = "0.00";
            }
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            double [] itemPrice  = new double[16];
            itemPrice[0] = Convert.ToDouble(txtChips.Text) * Price_chips;
            itemPrice[1] = Convert.ToDouble(txtCake.Text) * Price_cake;
            itemPrice[2] = Convert.ToDouble(txtPeanut.Text) * Price_peanut;
            itemPrice[3] = Convert.ToDouble(txtCookies.Text) * Price_cookies;
            itemPrice[4] = Convert.ToDouble(txtWater.Text) * Price_water;
            itemPrice[5] = Convert.ToDouble(txtCoffee.Text) * Price_coffee;
            itemPrice[6] = Convert.ToDouble(txtCola.Text) * Price_cola;
            itemPrice[7] = Convert.ToDouble(txtYoghurt.Text) * Price_yoghurt;
            itemPrice[8] = Convert.ToDouble(txtFries.Text) * Price_fries;
            itemPrice[9] = Convert.ToDouble(txtSalad.Text) * Price_salad;
            itemPrice[10] = Convert.ToDouble(txtburger.Text) * Price_hamburger;
            itemPrice[11] = Convert.ToDouble(txtsandwich.Text) * Price_sandwich;
            itemPrice[12] = Convert.ToDouble(txtPancake.Text) * Price_pancake;
            itemPrice[13] = Convert.ToDouble(txtBrownie.Text) * Price_brownie;
            itemPrice[14] = Convert.ToDouble(txtApplePie.Text) * Price_applePie;
            itemPrice[15] = Convert.ToDouble(txtMilkshake.Text) * Price_milkshake;

           

            if (comboBox1.Text == "Cash")
            {
                Total = itemPrice[0] + itemPrice[1] + itemPrice[2] + itemPrice[3] + itemPrice[4] + itemPrice[5] + itemPrice[6] + itemPrice[7] + itemPrice[8]
                     + itemPrice[9] + itemPrice[10] + itemPrice[11] + itemPrice[12] + itemPrice[13] + itemPrice[14] + itemPrice[15];

                txtTotal.Text = Convert.ToString(Total);

                Amount  = Convert.ToDouble(txtAmount.Text);
                Change = Amount - Total;
                txtChange.Text = Convert.ToString(Change);

                txtTotal.Text = String.Format("{0:C}", Total);
                txtAmount.Text = String.Format("{0:C}", Amount);
                txtChange.Text = String.Format("{0:C}", Change);
            }

            else
            {

                Total = itemPrice[0] + itemPrice[1] + itemPrice[2] + itemPrice[3] + itemPrice[4] + itemPrice[5] + itemPrice[6] + itemPrice[7] + itemPrice[8]
                     + itemPrice[9] + itemPrice[10] + itemPrice[11] + itemPrice[12] + itemPrice[13] + itemPrice[14] + itemPrice[15];

                txtTotal.Text = Convert.ToString(Total);

                txtTotal.Text = String.Format("{0:C}", Total);

                
                
            }
        }

        private void milkshake_CheckedChanged(object sender, EventArgs e)
        {
            if (milkshake.Checked == true)
            {
                txtMilkshake.Enabled = true;
                txtMilkshake.Text = "";
                txtMilkshake.Focus();
            }
            else
            {
                txtMilkshake.Enabled = false;
                txtMilkshake.Text = "0";
            }
        }
    }
}
