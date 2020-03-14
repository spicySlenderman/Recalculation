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
    public partial class Form_Pythagoras : Form
    {
        double length_a, length_b, length_c, value_result; //Values to calculate

        public Form_Pythagoras()
        {
            InitializeComponent();
        }

        private void Form_Pythagoras_Load(object sender, EventArgs e)
        {
            color_theme_change_pythagoras();
        }

        public void color_theme_change_pythagoras() //Changes the color theme
        {
            if (Form1.var_color_panel1 == "light_blue" && Form1.var_color_panel2 == "light_blue")
            {
                this.BackColor = Color.FromArgb(63, 238, 230); //backgroundcolor
                tbx_length_a.BackColor = Color.FromArgb(63, 238, 230);
                tbx_length_b.BackColor = Color.FromArgb(63, 238, 230);
                tbx_length_c.BackColor = Color.FromArgb(63, 238, 230);
                cbx_pythagoras_missing_length.BackColor = Color.FromArgb(63, 238, 230);

            }
            else if (Form1.var_color_panel1 == "gray" && Form1.var_color_panel2 == "gray")
            {
                this.BackColor = Color.DarkGray; //backgroundcolor
                tbx_length_a.BackColor = Color.DarkGray;
                tbx_length_b.BackColor = Color.DarkGray;
                tbx_length_c.BackColor = Color.DarkGray;
                cbx_pythagoras_missing_length.BackColor = Color.DarkGray;
            }
            else if (Form1.var_color_panel1 == "dark_gray_violett" && Form1.var_color_panel2 == "dark_gray_violett")
            {
                this.BackColor = Color.FromArgb(42, 42, 43); //backgroundcolor
                tbx_length_a.BackColor = Color.FromArgb(42, 42, 43);
                tbx_length_b.BackColor = Color.FromArgb(42, 42, 43);
                tbx_length_c.BackColor = Color.FromArgb(42, 42, 43);
                cbx_pythagoras_missing_length.BackColor = Color.FromArgb(42, 42, 43);
            }
        }

        private void tbx_length_a_TextChanged(object sender, EventArgs e) 
        {
        }

        public double square_of_a_value(double number1) //Get the square of an value method
        {
            double result;
            result = Math.Pow(number1, 2);
            return result;
        }

        private void cbx_pythagoras_missing_length_SelectedIndexChanged(object sender, EventArgs e) //Selected missing length
        {
            if (cbx_pythagoras_missing_length.SelectedIndex == 0) //length A is missing
            {
                tbx_length_a.Visible = false;
                tbx_length_b.Visible = true;
                tbx_length_c.Visible = true;
            }
            else if (cbx_pythagoras_missing_length.SelectedIndex == 1) //length B is missing
            {
                tbx_length_a.Visible = true;
                tbx_length_b.Visible = false;
                tbx_length_c.Visible = true;
            }
            else if (cbx_pythagoras_missing_length.SelectedIndex == 2) //length C is missing
            {
                tbx_length_a.Visible = true;
                tbx_length_b.Visible = true;
                tbx_length_c.Visible = false;
            }

        }

        private void lbl_Pythagoras_titel_Click(object sender, EventArgs e)
        {
        }

        private void lbl_missing_length_a_Click(object sender, EventArgs e)
        {
        }

        private void lbl_missing_length_b_Click(object sender, EventArgs e)
        {
        }

        private void tbx_length_b_TextChanged(object sender, EventArgs e)
        {
        }

        private void tbx_length_c_TextChanged(object sender, EventArgs e)
        {
        }

        private void lbl_missing_length_c_Click(object sender, EventArgs e)
        {
        }

        private void lbl_result_Click(object sender, EventArgs e)
        {
        }

        private void lbl_pythagoras_missing_length_Click(object sender, EventArgs e)
        {
        }

        private void lbl_result_titel_Click(object sender, EventArgs e)
        {
        }

        private void btn_Pythagoras_pythagoras_ausrechnen_Click(object sender, EventArgs e) //Calculates the result
        {
            if (cbx_pythagoras_missing_length.SelectedIndex == 0) //length A is missing
            {
                length_b = Convert.ToDouble(tbx_length_b.Text);
                length_c = Convert.ToDouble(tbx_length_c.Text);
                value_result = Math.Sqrt(square_of_a_value(length_c) - square_of_a_value(length_b));
                lbl_result.Text = Convert.ToString(value_result);
            }
            else if (cbx_pythagoras_missing_length.SelectedIndex == 1) //length B is missing
            {
                length_a = Convert.ToDouble(tbx_length_a.Text);
                length_c = Convert.ToDouble(tbx_length_c.Text);
                value_result = Math.Sqrt(square_of_a_value(length_c) - square_of_a_value(length_a));
                lbl_result.Text = Convert.ToString(value_result);
            }
            else if (cbx_pythagoras_missing_length.SelectedIndex == 2) //length C is missing
            {
                length_a = Convert.ToDouble(tbx_length_a.Text);
                length_b = Convert.ToDouble(tbx_length_b.Text);
                value_result = Math.Sqrt(square_of_a_value(length_a) + square_of_a_value(length_b));
                lbl_result.Text = Convert.ToString(value_result);
            }
            else
            {
                MessageBox.Show("Select a missing length!");
            }
        }

        private void btn_Pythagoras_result_in_ans_Click(object sender, EventArgs e) //Puts the result in the ANS variable
        {
            MessageBox.Show("Das Ergebnis " + Convert.ToString(value_result) + " wurde in Ans gespeichert");
            Form1.var_ans = Convert.ToString(value_result);
        }

    }
}
