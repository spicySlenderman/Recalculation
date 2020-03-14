using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form_Gewicht : Form
    {
        double current_weight; //The current selected weight

        public Form_Gewicht()
        {
            InitializeComponent();
        }

        private void Form_Gewicht_Load(object sender, EventArgs e)
        {
            color_theme_change_gewicht();
        }

        public void color_theme_change_gewicht() //Changes the color
        {
            if (Form1.var_color_panel1 == "light_blue" && Form1.var_color_panel2 == "light_blue")
            {
                this.BackColor = Color.FromArgb(63, 238, 230); //backgroundcolor
                tbx_tonnen.BackColor = Color.FromArgb(63, 238, 230);
                tbx_kilogramm.BackColor = Color.FromArgb(63, 238, 230);
                tbx_dekagramm.BackColor = Color.FromArgb(63, 238, 230);
                tbx_gramm.BackColor = Color.FromArgb(63, 238, 230);
                tbx_milligramm.BackColor = Color.FromArgb(63, 238, 230);
                cbx_which_weight_unit.BackColor = Color.FromArgb(63, 238, 230);

            }
            else if (Form1.var_color_panel1 == "gray" && Form1.var_color_panel2 == "gray")
            {
                this.BackColor = Color.DarkGray; ; //backgroundcolor
                tbx_tonnen.BackColor = Color.DarkGray;
                tbx_kilogramm.BackColor = Color.DarkGray;
                tbx_dekagramm.BackColor = Color.DarkGray;
                tbx_gramm.BackColor = Color.DarkGray;
                tbx_milligramm.BackColor = Color.DarkGray;
                cbx_which_weight_unit.BackColor = Color.DarkGray;
            }
            else if (Form1.var_color_panel1 == "dark_gray_violett" && Form1.var_color_panel2 == "dark_gray_violett")
            {
                this.BackColor = Color.FromArgb(42, 42, 43); //backgroundcolor
                tbx_tonnen.BackColor = Color.FromArgb(42, 42, 43);
                tbx_kilogramm.BackColor = Color.FromArgb(42, 42, 43);
                tbx_dekagramm.BackColor = Color.FromArgb(42, 42, 43);
                tbx_gramm.BackColor = Color.FromArgb(42, 42, 43);
                tbx_milligramm.BackColor = Color.FromArgb(42, 42, 43);
                cbx_which_weight_unit.BackColor = Color.FromArgb(42, 42, 43);
            }
        } 

        private void tbx_tonnen_TextChanged(object sender, EventArgs e) //tonne
        {
            if (cbx_which_weight_unit.SelectedIndex == 4) //tonne
            {
                convert_in_all_weights("tonnen");
            }
            else
            {

            }
        }

        private void tbx_kilogramm_TextChanged(object sender, EventArgs e) //kilogram
        {
            if (cbx_which_weight_unit.SelectedIndex == 3) //kilogram
            {
                convert_in_all_weights("kilogramm");
            }
            else
            {

            }
        }

        private void tbx_dekagramm_TextChanged(object sender, EventArgs e) //decagram
        {
            if (cbx_which_weight_unit.SelectedIndex == 2) //decagram
            {
                convert_in_all_weights("dekagramm");
            }
            else
            {

            }
        }

        private void tbx_gramm_TextChanged(object sender, EventArgs e) //Gramm
        {
            if (cbx_which_weight_unit.SelectedIndex == 1) //Gramm
            {
                convert_in_all_weights("gramm");
            }
            else
            {

            }
        }

        private void tbx_milligramm_TextChanged(object sender, EventArgs e) // milligram
        {
            if (cbx_which_weight_unit.SelectedIndex == 0) //milligram
            {
                convert_in_all_weights("milligramm");
            }
            else
            {

            }
        }

        public void convert_in_all_weights(string wanted_weight) //Convets all in a weight
        {
            if (wanted_weight == "tonnen") //tonne
            {
                bool allCharactersInStringAreDigits = tbx_tonnen.Text.All(char.IsDigit);
                if (allCharactersInStringAreDigits == true && tbx_tonnen.Text != "" || tbx_tonnen.Text.Contains(","))
                {
                    current_weight = Convert.ToDouble(tbx_tonnen.Text);
                    tbx_milligramm.Text = Convert.ToString((decimal)current_weight * 1000000000); //(decimal) ist needed to get a decimal number
                    tbx_gramm.Text = Convert.ToString((decimal)current_weight * 1000000);
                    tbx_dekagramm.Text = Convert.ToString((decimal)current_weight * 100000);
                    tbx_kilogramm.Text = Convert.ToString((decimal)current_weight * 1000);
                }
                else
                {

                }
            }
            else if (wanted_weight == "kilogramm") //kilogram
            {
                bool allCharactersInStringAreDigits = tbx_kilogramm.Text.All(char.IsDigit);
                if (allCharactersInStringAreDigits == true && tbx_kilogramm.Text != "" || tbx_kilogramm.Text.Contains(","))
                {
                    current_weight = Convert.ToDouble(tbx_kilogramm.Text);
                    tbx_milligramm.Text = Convert.ToString((decimal)current_weight * 1000000);
                    tbx_gramm.Text = Convert.ToString((decimal)current_weight * 1000);
                    tbx_dekagramm.Text = Convert.ToString((decimal)current_weight * 100);
                    tbx_tonnen.Text = Convert.ToString((decimal)current_weight / 1000);
                }
                else
                {

                }
            }
            else if (wanted_weight == "dekagramm") //decagram
            {
                bool allCharactersInStringAreDigits = tbx_dekagramm.Text.All(char.IsDigit);
                if (allCharactersInStringAreDigits == true && tbx_dekagramm.Text != "" || tbx_dekagramm.Text.Contains(","))
                {
                    current_weight = Convert.ToDouble(tbx_dekagramm.Text);
                    tbx_milligramm.Text = Convert.ToString((decimal)current_weight * 10000);
                    tbx_gramm.Text = Convert.ToString((decimal)current_weight * 10);
                    tbx_kilogramm.Text = Convert.ToString((decimal)current_weight / 100);
                    tbx_tonnen.Text = Convert.ToString((decimal)current_weight / 100000);
                }
                else
                {

                }
            }
            else if (wanted_weight == "gramm") //gram
            {
                bool allCharactersInStringAreDigits = tbx_gramm.Text.All(char.IsDigit);
                if (allCharactersInStringAreDigits == true && tbx_gramm.Text != "" || tbx_gramm.Text.Contains(","))
                {
                    current_weight = Convert.ToDouble(tbx_gramm.Text);
                    tbx_milligramm.Text = Convert.ToString((decimal)current_weight * 1000);
                    tbx_dekagramm.Text = Convert.ToString((decimal)current_weight / 10);
                    tbx_kilogramm.Text = Convert.ToString((decimal)current_weight / 1000);
                    tbx_tonnen.Text = Convert.ToString((decimal)current_weight / 1000000);
                }
                else
                {

                }
            }
            else if (wanted_weight == "milligramm") //milligram
            {
                bool allCharactersInStringAreDigits = tbx_milligramm.Text.All(char.IsDigit);
                if (allCharactersInStringAreDigits == true && tbx_milligramm.Text != "" || tbx_milligramm.Text.Contains(","))
                {
                    current_weight = Convert.ToDouble(tbx_milligramm.Text);
                    tbx_gramm.Text = Convert.ToString((decimal)current_weight / 1000);
                    tbx_dekagramm.Text = Convert.ToString((decimal)current_weight / 10000);
                    tbx_kilogramm.Text = Convert.ToString((decimal)current_weight / 1000000);
                    tbx_tonnen.Text = Convert.ToString((decimal)current_weight / 1000000000);
                }
                else
                {

                }
            }
        }

        private void cbx_which_weight_unit_SelectedIndexChanged(object sender, EventArgs e) //When the selected weight changes
        {
            tbx_milligramm.Text = "";
            tbx_gramm.Text = "";
            tbx_dekagramm.Text = "";
            tbx_kilogramm.Text = "";
            tbx_tonnen.Text = "";
        }
    }
}
