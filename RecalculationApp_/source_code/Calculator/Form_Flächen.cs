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
    public partial class Form_Flächen : Form
    {
        double length_a, length_b, length_r, value_result; //Values to calculate the result

        public Form_Flächen()
        {
            InitializeComponent();
        }

        private void Form_Flächen_Load(object sender, EventArgs e)
        {
            color_theme_change_flächen();
        }

        public void color_theme_change_flächen() //Changes the color theme
        {
            if (Form1.var_color_panel1 == "light_blue" && Form1.var_color_panel2 == "light_blue")
            {
                this.BackColor = Color.FromArgb(63, 238, 230); //backgroundcolor
                tbx_length_a.BackColor = Color.FromArgb(63, 238, 230);
                tbx_length_b.BackColor = Color.FromArgb(63, 238, 230);
                tbx_length_r.BackColor = Color.FromArgb(63, 238, 230);
                cbx_wanted_area.BackColor = Color.FromArgb(63, 238, 230);

            }
            else if (Form1.var_color_panel1 == "gray" && Form1.var_color_panel2 == "gray")
            {
                this.BackColor = Color.DarkGray; //backgroundcolor
                tbx_length_a.BackColor = Color.DarkGray;
                tbx_length_b.BackColor = Color.DarkGray;
                tbx_length_r.BackColor = Color.DarkGray;
                cbx_wanted_area.BackColor = Color.DarkGray;
            }
            else if (Form1.var_color_panel1 == "dark_gray_violett" && Form1.var_color_panel2 == "dark_gray_violett")
            {
                this.BackColor = Color.FromArgb(42, 42, 43); //backgroundcolor
                tbx_length_a.BackColor = Color.FromArgb(42, 42, 43);
                tbx_length_b.BackColor = Color.FromArgb(42, 42, 43);
                tbx_length_r.BackColor = Color.FromArgb(42, 42, 43);
                cbx_wanted_area.BackColor = Color.FromArgb(42, 42, 43);
            }
        }

        private void btn_Area_Area_ausrechnen_Click(object sender, EventArgs e)
        {
            if (cbx_wanted_area.SelectedIndex == 0) //Square
            {
                length_a = Convert.ToDouble(tbx_length_a.Text);
                value_result = Math.Pow(length_a, 2);
                lbl_area_result.Text = Convert.ToString(value_result);

            }
            else if (cbx_wanted_area.SelectedIndex == 1) //rectangle
            {
                length_a = Convert.ToDouble(tbx_length_a.Text);
                length_b = Convert.ToDouble(tbx_length_b.Text);
                value_result = length_a * length_b;
                lbl_area_result.Text = Convert.ToString(value_result);
            }
            else if (cbx_wanted_area.SelectedIndex == 2) //triangle
            {
                length_a = Convert.ToDouble(tbx_length_a.Text);
                length_b = Convert.ToDouble(tbx_length_b.Text);
                value_result = length_a * length_b / 2.0;
                lbl_area_result.Text = Convert.ToString(value_result);
            }
            else if (cbx_wanted_area.SelectedIndex == 3) //circle
            {
                length_r = Convert.ToDouble(tbx_length_r.Text);
                value_result = Math.Pow(length_r, 2) * Math.PI;
                lbl_area_result.Text = Convert.ToString(value_result);
            }
        }

        private void btn_Flächen_result_in_ans_Click(object sender, EventArgs e) //Puts the result in the ANS variable
        {
            MessageBox.Show("Das Ergebnis " + Convert.ToString(value_result) + " wurde in Ans gespeichert");
            Form1.var_ans = Convert.ToString(value_result);
        }

        private void cbx_wanted_area_SelectedIndexChanged(object sender, EventArgs e) //Select wanted area
        {
            if (cbx_wanted_area.SelectedIndex == 0) //Square
            {
                tbx_length_a.Visible = true;
                tbx_length_b.Visible = false;
                tbx_length_r.Visible = false;
            }
            else if (cbx_wanted_area.SelectedIndex == 1) //Rectangle
            {
                tbx_length_a.Visible = true;
                tbx_length_b.Visible = true;
                tbx_length_r.Visible = false;
            }
            else if (cbx_wanted_area.SelectedIndex == 2) //Triangle
            {
                tbx_length_a.Visible = true;
                tbx_length_b.Visible = true;
                tbx_length_r.Visible = false;
            }
            else if (cbx_wanted_area.SelectedIndex == 3) //Kreis
            {
                tbx_length_a.Visible = false;
                tbx_length_b.Visible = false;
                tbx_length_r.Visible = true;
            }
        }
    }
}
