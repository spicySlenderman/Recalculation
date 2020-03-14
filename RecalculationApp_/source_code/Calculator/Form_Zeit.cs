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
    public partial class Form_Zeit : Form
    {
        double current_zeit; //Selected current time

        public Form_Zeit()
        {
            InitializeComponent();
        }

        private void Form_Zeit_Load(object sender, EventArgs e)
        {
            color_theme_change_zeit();
        }

        public void color_theme_change_zeit() //Changes the color theme
        {
            if (Form1.var_color_panel1 == "light_blue" && Form1.var_color_panel2 == "light_blue")
            {
                this.BackColor = Color.FromArgb(63, 238, 230); //backgroundcolor
                tbx_millisekunde.BackColor = Color.FromArgb(63, 238, 230);
                tbx_sekunde.BackColor = Color.FromArgb(63, 238, 230);
                tbx_minute.BackColor = Color.FromArgb(63, 238, 230);
                tbx_stunde.BackColor = Color.FromArgb(63, 238, 230);
                tbx_tag.BackColor = Color.FromArgb(63, 238, 230);
                cbx_which_zeit_unit.BackColor = Color.FromArgb(63, 238, 230);

            }
            else if (Form1.var_color_panel1 == "gray" && Form1.var_color_panel2 == "gray")
            {
                this.BackColor = Color.DarkGray; //backgroundcolor
                tbx_millisekunde.BackColor = Color.DarkGray;
                tbx_sekunde.BackColor = Color.DarkGray;
                tbx_minute.BackColor = Color.DarkGray;
                tbx_stunde.BackColor = Color.DarkGray;
                tbx_tag.BackColor = Color.DarkGray;
                cbx_which_zeit_unit.BackColor = Color.DarkGray;
            }
            else if (Form1.var_color_panel1 == "dark_gray_violett" && Form1.var_color_panel2 == "dark_gray_violett")
            {
                this.BackColor = Color.FromArgb(42, 42, 43); //backgroundcolor
                tbx_millisekunde.BackColor = Color.FromArgb(42, 42, 43);
                tbx_sekunde.BackColor = Color.FromArgb(42, 42, 43);
                tbx_minute.BackColor = Color.FromArgb(42, 42, 43);
                tbx_stunde.BackColor = Color.FromArgb(42, 42, 43);
                tbx_tag.BackColor = Color.FromArgb(42, 42, 43);
                cbx_which_zeit_unit.BackColor = Color.FromArgb(42, 42, 43);
            }
        }

        private void cbx_which_zeit_unit_SelectedIndexChanged(object sender, EventArgs e) //When the selected time changes
        {
            tbx_millisekunde.Text = "";
            tbx_sekunde.Text = "";
            tbx_minute.Text = "";
            tbx_stunde.Text = "";
            tbx_tag.Text = "";
        }

        private void tbx_millisekunde_TextChanged(object sender, EventArgs e) //millisecond
        {
            if (cbx_which_zeit_unit.SelectedIndex == 0)
            {
                bool allCharactersInStringAreDigits = tbx_millisekunde.Text.All(char.IsDigit);
                if (allCharactersInStringAreDigits == true && tbx_millisekunde.Text != "" || tbx_millisekunde.Text.Contains(","))
                {
                    current_zeit = Convert.ToDouble(tbx_millisekunde.Text);
                    tbx_sekunde.Text = Convert.ToString((decimal)current_zeit / 1000);
                    tbx_minute.Text = Convert.ToString((decimal)current_zeit / 60000);
                    tbx_stunde.Text = Convert.ToString((decimal)current_zeit / 3600000); 
                    tbx_tag.Text = Convert.ToString((decimal)current_zeit / 86400000);
                }
                else
                {
                }
            }
            else
            {
            }
        }

        private void tbx_sekunde_TextChanged(object sender, EventArgs e) //second
        {
            if (cbx_which_zeit_unit.SelectedIndex == 1)
            {
                bool allCharactersInStringAreDigits = tbx_sekunde.Text.All(char.IsDigit);
                if (allCharactersInStringAreDigits == true && tbx_sekunde.Text != "" || tbx_sekunde.Text.Contains(","))
                {
                    current_zeit = Convert.ToDouble(tbx_sekunde.Text);
                    tbx_millisekunde.Text = Convert.ToString((decimal)current_zeit * 1000);
                    tbx_minute.Text = Convert.ToString((decimal)current_zeit / 60);
                    tbx_stunde.Text = Convert.ToString((decimal)current_zeit / 3600);
                    tbx_tag.Text = Convert.ToString((decimal)current_zeit / 86400);
                }
                else
                {
                }
            }
            else
            {
            }
        }

        private void tbx_minute_TextChanged(object sender, EventArgs e) //minute
        {

            if (cbx_which_zeit_unit.SelectedIndex == 2)
            {
                bool allCharactersInStringAreDigits = tbx_minute.Text.All(char.IsDigit);
                if (allCharactersInStringAreDigits == true && tbx_minute.Text != "" || tbx_minute.Text.Contains(","))
                {
                    current_zeit = Convert.ToDouble(tbx_minute.Text);
                    tbx_millisekunde.Text = Convert.ToString((decimal)current_zeit * 60000);
                    tbx_sekunde.Text = Convert.ToString((decimal)current_zeit * 60);
                    tbx_stunde.Text = Convert.ToString((decimal)current_zeit / 60);
                    tbx_tag.Text = Convert.ToString((decimal)current_zeit / 1440);
                }
                else
                {
                }
            }
            else
            {
            }
        }

        private void tbx_stunde_TextChanged(object sender, EventArgs e) //hour
        {
            if (cbx_which_zeit_unit.SelectedIndex == 3)
            {
                bool allCharactersInStringAreDigits = tbx_stunde.Text.All(char.IsDigit);
                if (allCharactersInStringAreDigits == true && tbx_stunde.Text != "" || tbx_stunde.Text.Contains(","))
                {
                    current_zeit = Convert.ToDouble(tbx_stunde.Text);
                    tbx_millisekunde.Text = Convert.ToString((decimal)current_zeit * 3600000);
                    tbx_sekunde.Text = Convert.ToString((decimal)current_zeit * 3600);
                    tbx_minute.Text = Convert.ToString((decimal)current_zeit * 60);
                    tbx_tag.Text = Convert.ToString((decimal)current_zeit / 24);
                }
                else
                {
                }
            }
            else
            {
            }
        }

        private void tbx_tag_TextChanged(object sender, EventArgs e) //day
        {
            if (cbx_which_zeit_unit.SelectedIndex == 4)
            {
                bool allCharactersInStringAreDigits = tbx_tag.Text.All(char.IsDigit);
                if (allCharactersInStringAreDigits == true && tbx_tag.Text != "" || tbx_tag.Text.Contains(","))
                {
                    current_zeit = Convert.ToDouble(tbx_tag.Text);
                    tbx_millisekunde.Text = Convert.ToString((decimal)current_zeit * 86400000);
                    tbx_sekunde.Text = Convert.ToString((decimal)current_zeit * 86400);
                    tbx_minute.Text = Convert.ToString((decimal)current_zeit * 1440);
                    tbx_stunde.Text = Convert.ToString((decimal)current_zeit * 24);
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
