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

    public partial class Form_Volumen : Form
    {
        double length_a, length_b, length_r, length_h, value_result; //values to calculate the result

        public Form_Volumen()
        {
            InitializeComponent();
        }

        private void Form_Volumen_Load(object sender, EventArgs e)
        {
            color_theme_change_volumen();
        }

        public void color_theme_change_volumen() //Changes the colortheme
        {
            if (Form1.var_color_panel1 == "light_blue" && Form1.var_color_panel2 == "light_blue")
            {
                this.BackColor = Color.FromArgb(63, 238, 230); //backgroundcolor
                tbx_length_a.BackColor = Color.FromArgb(63, 238, 230);
                tbx_length_b.BackColor = Color.FromArgb(63, 238, 230);
                tbx_length_r.BackColor = Color.FromArgb(63, 238, 230);
                tbx_length_h.BackColor = Color.FromArgb(63, 238, 230);
                cbx_wanted_volumen.BackColor = Color.FromArgb(63, 238, 230);

            }
            else if (Form1.var_color_panel1 == "gray" && Form1.var_color_panel2 == "gray")
            {
                this.BackColor = Color.DarkGray; //backgroundcolor
                tbx_length_a.BackColor = Color.DarkGray;
                tbx_length_b.BackColor = Color.DarkGray;
                tbx_length_r.BackColor = Color.DarkGray;
                tbx_length_h.BackColor = Color.DarkGray;
                cbx_wanted_volumen.BackColor = Color.DarkGray;
            }
            else if (Form1.var_color_panel1 == "dark_gray_violett" && Form1.var_color_panel2 == "dark_gray_violett")
            {
                this.BackColor = Color.FromArgb(42, 42, 43); //backgroundcolor
                tbx_length_a.BackColor = Color.FromArgb(42, 42, 43);
                tbx_length_b.BackColor = Color.FromArgb(42, 42, 43);
                tbx_length_r.BackColor = Color.FromArgb(42, 42, 43);
                tbx_length_h.BackColor = Color.FromArgb(42, 42, 43);
                cbx_wanted_volumen.BackColor = Color.FromArgb(42, 42, 43);
            }
        }

        private void tbx_length_r_TextChanged(object sender, EventArgs e)
        {
        }

        private void cbx_wanted_volumen_SelectedIndexChanged(object sender, EventArgs e) //Selected wanted volume
        {
            if (cbx_wanted_volumen.SelectedIndex == 0) //cube
            {
                tbx_length_a.Visible = true;
                tbx_length_b.Visible = false;
                tbx_length_r.Visible = false;
                tbx_length_h.Visible = false;
            }
            else if (cbx_wanted_volumen.SelectedIndex == 1) //cuboid
            {
                tbx_length_a.Visible = true;
                tbx_length_b.Visible = true;
                tbx_length_r.Visible = false;
                tbx_length_h.Visible = true;
            }
            else if (cbx_wanted_volumen.SelectedIndex == 2) //square pyramid 
            {
                tbx_length_a.Visible = true;
                tbx_length_b.Visible = false;
                tbx_length_r.Visible = false;
                tbx_length_h.Visible = true;
            }
            else if (cbx_wanted_volumen.SelectedIndex == 3) //ball
            {
                tbx_length_a.Visible = false;
                tbx_length_b.Visible = false;
                tbx_length_r.Visible = true;
                tbx_length_h.Visible = false;
            }
        }

        private void btn_Volumen_Volumen_ausrechnen_Click(object sender, EventArgs e) //Calculates the Volume
        {
            if (cbx_wanted_volumen.SelectedIndex == 0) //cube
            {
                length_a = Convert.ToDouble(tbx_length_a.Text);
                value_result = Math.Pow(length_a, 3);
                lbl_Volumen_result.Text = Convert.ToString(value_result);

            }
            else if (cbx_wanted_volumen.SelectedIndex == 1) //cuboid
            {
                length_a = Convert.ToDouble(tbx_length_a.Text);
                length_b = Convert.ToDouble(tbx_length_b.Text);
                length_h = Convert.ToDouble(tbx_length_h.Text);
                value_result = length_a * length_b * length_h;
                lbl_Volumen_result.Text = Convert.ToString(value_result); 
            }
            else if (cbx_wanted_volumen.SelectedIndex == 2) //square pyramid
            {
                length_a = Convert.ToDouble(tbx_length_a.Text);
                length_h = Convert.ToDouble(tbx_length_h.Text);
                value_result = 1 / 3.0 * Math.Pow(length_a, 2) * length_h;
                lbl_Volumen_result.Text = Convert.ToString(value_result);
            }
            else if (cbx_wanted_volumen.SelectedIndex == 3) //ball
            {
                length_r = Convert.ToDouble(tbx_length_r.Text);
                value_result = 4.0 * Math.Pow(length_r, 3) * Math.PI / 3;
                lbl_Volumen_result.Text = Convert.ToString(value_result);
            }
        }

        private void btn_Volumen_result_in_ans_Click(object sender, EventArgs e) //Puts the result in the ANS variable
        {
            MessageBox.Show("Das Ergebnis " + Convert.ToString(value_result) + " wurde in Ans gespeichert");
            Form1.var_ans = Convert.ToString(value_result);
        }
    }
}
