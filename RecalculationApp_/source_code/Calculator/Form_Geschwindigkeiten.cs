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
    public partial class Form_Geschwindigkeiten : Form
    {
        double current_speed; //selected the current speed

        public Form_Geschwindigkeiten()
        {
            InitializeComponent();
        }

        private void Form_Geschwindigkeiten_Load(object sender, EventArgs e)
        {
            color_theme_change_geschwindigkeiten();
        }

        public void color_theme_change_geschwindigkeiten() //Changes the color theme
        {
            if (Form1.var_color_panel1 == "light_blue" && Form1.var_color_panel2 == "light_blue")
            {
                this.BackColor = Color.FromArgb(63, 238, 230); //backgroundcolor
                tbx_meter_second.BackColor = Color.FromArgb(63, 238, 230);
                tbx_knoten.BackColor = Color.FromArgb(63, 238, 230);
                tbx_miles_hour.BackColor = Color.FromArgb(63, 238, 230);
                tbx_kilometers_hour.BackColor = Color.FromArgb(63, 238, 230);
                cbx_which_speed_unit.BackColor = Color.FromArgb(63, 238, 230);

            }
            else if (Form1.var_color_panel1 == "gray" && Form1.var_color_panel2 == "gray")
            {
                this.BackColor = Color.DarkGray; //backgroundcolor
                tbx_meter_second.BackColor = Color.DarkGray;
                tbx_knoten.BackColor = Color.DarkGray;
                tbx_miles_hour.BackColor = Color.DarkGray;
                tbx_kilometers_hour.BackColor = Color.DarkGray;
                cbx_which_speed_unit.BackColor = Color.DarkGray;
            }
            else if (Form1.var_color_panel1 == "dark_gray_violett" && Form1.var_color_panel2 == "dark_gray_violett")
            {
                this.BackColor = Color.FromArgb(42, 42, 43); //backgroundcolor
                tbx_meter_second.BackColor = Color.FromArgb(42, 42, 43);
                tbx_knoten.BackColor = Color.FromArgb(42, 42, 43);
                tbx_miles_hour.BackColor = Color.FromArgb(42, 42, 43);
                tbx_kilometers_hour.BackColor = Color.FromArgb(42, 42, 43);
                cbx_which_speed_unit.BackColor = Color.FromArgb(42, 42, 43);
            }
        }

        private void cbx_which_speed_unit_SelectedIndexChanged(object sender, EventArgs e) //when the selected speed changes
        {
            tbx_meter_second.Text = "";
            tbx_knoten.Text = "";
            tbx_miles_hour.Text = "";
            tbx_kilometers_hour.Text = "";
        }

        private void tbx_meter_second_TextChanged(object sender, EventArgs e) //meter per second
        {
            if (cbx_which_speed_unit.SelectedIndex == 0)
            {
                bool allCharactersInStringAreDigits = tbx_meter_second.Text.All(char.IsDigit);
                if (allCharactersInStringAreDigits == true && tbx_meter_second.Text != "" || tbx_meter_second.Text.Contains(","))
                {
                    current_speed = Convert.ToDouble(tbx_meter_second.Text);
                    tbx_knoten.Text = Convert.ToString(current_speed * 1.944);
                    tbx_miles_hour.Text = Convert.ToString(current_speed * 2.237);
                    tbx_kilometers_hour.Text = Convert.ToString(current_speed * 3.6);
                }
                else
                {
                }
            }
            else
            {
            }
        }

        private void tbx_knoten_TextChanged(object sender, EventArgs e) //node (seafaring)
        {
            if (cbx_which_speed_unit.SelectedIndex == 1)
            {
                bool allCharactersInStringAreDigits = tbx_knoten.Text.All(char.IsDigit);
                if (allCharactersInStringAreDigits == true && tbx_knoten.Text != "" || tbx_knoten.Text.Contains(","))
                {
                    current_speed = Convert.ToDouble(tbx_knoten.Text);
                    tbx_meter_second.Text = Convert.ToString(current_speed / 1.944);
                    tbx_miles_hour.Text = Convert.ToString(current_speed * 1.151);
                    tbx_kilometers_hour.Text = Convert.ToString(current_speed * 1.852);
                }
                else
                {
                }
            }
            else
            {
            }
        }

        private void tbx_miles_hour_TextChanged(object sender, EventArgs e) //miles per hour
        {
            if (cbx_which_speed_unit.SelectedIndex == 2)
            {
                bool allCharactersInStringAreDigits = tbx_miles_hour.Text.All(char.IsDigit);
                if (allCharactersInStringAreDigits == true && tbx_miles_hour.Text != "" || tbx_miles_hour.Text.Contains(","))
                {
                    current_speed = Convert.ToDouble(tbx_miles_hour.Text);
                    tbx_meter_second.Text = Convert.ToString(current_speed / 2.237);
                    tbx_knoten.Text = Convert.ToString(current_speed / 1.151);
                    tbx_kilometers_hour.Text = Convert.ToString(current_speed * 1.609);
                }
                else
                {
                }
            }
            else
            {
            }
        }

        private void tbx_kilometers_hour_TextChanged(object sender, EventArgs e) //kilometer per hour
        {
            if (cbx_which_speed_unit.SelectedIndex == 3)
            {
                bool allCharactersInStringAreDigits = tbx_kilometers_hour.Text.All(char.IsDigit);
                if (allCharactersInStringAreDigits == true && tbx_kilometers_hour.Text != "" || tbx_kilometers_hour.Text.Contains(","))
                {
                    current_speed = Convert.ToDouble(tbx_kilometers_hour.Text);
                    tbx_meter_second.Text = Convert.ToString(current_speed / 3.6);
                    tbx_knoten.Text = Convert.ToString(current_speed / 1.852);
                    tbx_miles_hour.Text = Convert.ToString(current_speed / 1.609);
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
