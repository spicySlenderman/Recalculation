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
    public partial class Form_Längen : Form
    {
        double current_length; //Current selected length

        public Form_Längen()
        {
            InitializeComponent();
        }

        private void Form_Längen_Load(object sender, EventArgs e)
        {
            color_theme_change_längen();
        }

        public void color_theme_change_längen() //Changes the color
        {
            if (Form1.var_color_panel1 == "light_blue" && Form1.var_color_panel2 == "light_blue")
            {
                this.BackColor = Color.FromArgb(63, 238, 230); //backgroundcolor
                tbx_millimeter.BackColor = Color.FromArgb(63, 238, 230);
                tbx_zentimeter.BackColor = Color.FromArgb(63, 238, 230);
                tbx_dezimeter.BackColor = Color.FromArgb(63, 238, 230);
                tbx_meter.BackColor = Color.FromArgb(63, 238, 230);
                tbx_kilometer.BackColor = Color.FromArgb(63, 238, 230);
                cbx_which_length_unit.BackColor = Color.FromArgb(63, 238, 230);

            }
            else if (Form1.var_color_panel1 == "gray" && Form1.var_color_panel2 == "gray")
            {
                this.BackColor = Color.DarkGray; //backgroundcolor
                tbx_millimeter.BackColor = Color.DarkGray;
                tbx_zentimeter.BackColor = Color.DarkGray;
                tbx_dezimeter.BackColor = Color.DarkGray;
                tbx_meter.BackColor = Color.DarkGray;
                tbx_kilometer.BackColor = Color.DarkGray;
                cbx_which_length_unit.BackColor = Color.DarkGray;
            }
            else if (Form1.var_color_panel1 == "dark_gray_violett" && Form1.var_color_panel2 == "dark_gray_violett")
            {
                this.BackColor = Color.FromArgb(42, 42, 43); //backgroundcolor
                tbx_millimeter.BackColor = Color.FromArgb(42, 42, 43);
                tbx_zentimeter.BackColor = Color.FromArgb(42, 42, 43);
                tbx_dezimeter.BackColor = Color.FromArgb(42, 42, 43);
                tbx_meter.BackColor = Color.FromArgb(42, 42, 43);
                tbx_kilometer.BackColor = Color.FromArgb(42, 42, 43);
                cbx_which_length_unit.BackColor = Color.FromArgb(42, 42, 43);
            }
        }//42 42 43

        private void cbx_which_length_unit_SelectedIndexChanged(object sender, EventArgs e) //When the selected length changes
        {
            tbx_millimeter.Text = "";
            tbx_zentimeter.Text = "";
            tbx_dezimeter.Text = "";
            tbx_meter.Text = "";
            tbx_kilometer.Text = "";

        }

        private void tbx_millimeter_TextChanged(object sender, EventArgs e) //millimeter
        {
            if (cbx_which_length_unit.SelectedIndex == 0)
            {
                bool allCharactersInStringAreDigits = tbx_millimeter.Text.All(char.IsDigit);
                if (allCharactersInStringAreDigits == true && tbx_millimeter.Text != "" || tbx_millimeter.Text.Contains(","))
                {
                    current_length = Convert.ToDouble(tbx_millimeter.Text);
                    tbx_zentimeter.Text = Convert.ToString((decimal)current_length / 10);
                    tbx_dezimeter.Text = Convert.ToString((decimal)current_length / 100);
                    tbx_meter.Text = Convert.ToString((decimal)current_length / 1000);
                    tbx_kilometer.Text = Convert.ToString((decimal)current_length / 1000000);
                }
                else
                {
                }
            }
            else
            {
            }
        }

        private void tbx_zentimeter_TextChanged(object sender, EventArgs e) //centimeter
        {
            if (cbx_which_length_unit.SelectedIndex == 1)
            {
                bool allCharactersInStringAreDigits = tbx_zentimeter.Text.All(char.IsDigit);
                if (allCharactersInStringAreDigits == true && tbx_zentimeter.Text != "" || tbx_zentimeter.Text.Contains(","))
                {
                    current_length = Convert.ToDouble(tbx_zentimeter.Text);
                    tbx_millimeter.Text = Convert.ToString((decimal)current_length * 10);
                    tbx_dezimeter.Text = Convert.ToString((decimal)current_length / 10);
                    tbx_meter.Text = Convert.ToString((decimal)current_length / 100);
                    tbx_kilometer.Text = Convert.ToString((decimal)current_length / 100000);
                }
                else
                {
                }
            }
            else
            {
            }
        }

        private void tbx_dezimeter_TextChanged(object sender, EventArgs e) //decimeter
        {
            if (cbx_which_length_unit.SelectedIndex == 2)
            {
                bool allCharactersInStringAreDigits = tbx_dezimeter.Text.All(char.IsDigit);
                if (allCharactersInStringAreDigits == true && tbx_dezimeter.Text != "" || tbx_dezimeter.Text.Contains(","))
                {
                    current_length = Convert.ToDouble(tbx_dezimeter.Text);
                    tbx_millimeter.Text = Convert.ToString((decimal)current_length * 100);
                    tbx_zentimeter.Text = Convert.ToString((decimal)current_length * 10);
                    tbx_meter.Text = Convert.ToString((decimal)current_length / 10);
                    tbx_kilometer.Text = Convert.ToString((decimal)current_length / 10000);
                }
                else
                {
                }
            }
            else
            {
            }
        }

        private void tbx_meter_TextChanged(object sender, EventArgs e) //meter
        {
            if (cbx_which_length_unit.SelectedIndex == 3)
            {
                bool allCharactersInStringAreDigits = tbx_meter.Text.All(char.IsDigit);
                if (allCharactersInStringAreDigits == true && tbx_meter.Text != "" || tbx_meter.Text.Contains(","))
                {
                    current_length = Convert.ToDouble(tbx_meter.Text);
                    tbx_millimeter.Text = Convert.ToString((decimal)current_length * 1000);
                    tbx_zentimeter.Text = Convert.ToString((decimal)current_length * 100);
                    tbx_dezimeter.Text = Convert.ToString((decimal)current_length * 10);
                    tbx_kilometer.Text = Convert.ToString((decimal)current_length / 1000);
                }
                else
                {
                }
            }
            else
            {
            }
        }

        private void tbx_kilometer_TextChanged(object sender, EventArgs e) //kilometre
        {
            if (cbx_which_length_unit.SelectedIndex == 4)
            {
                bool allCharactersInStringAreDigits = tbx_kilometer.Text.All(char.IsDigit);
                if (allCharactersInStringAreDigits == true && tbx_kilometer.Text != "" || tbx_kilometer.Text.Contains(","))
                {
                    current_length = Convert.ToDouble(tbx_kilometer.Text);
                    tbx_millimeter.Text = Convert.ToString((decimal)current_length * 1000000);
                    tbx_zentimeter.Text = Convert.ToString((decimal)current_length * 100000);
                    tbx_dezimeter.Text = Convert.ToString((decimal)current_length * 10000);
                    tbx_meter.Text = Convert.ToString((decimal)current_length * 1000);
                }
                else
                {
                }
            }
            else
            {
            }
        }
    }
}
