using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//To Do: sollte alles fertig sein;

namespace Calculator
{
    public partial class Form_Wurzel : Form
    {
        int wurzel_selected_wurzel_exponent; //Selected Root exponent
        double wurzel_value_radikand, wurzel_value_result; //values to calculate

        public Form_Wurzel()
        {
            InitializeComponent();
        }

        private void Form_Wurzel_Load(object sender, EventArgs e)
        {
            color_theme_change_wurzel();
        }

        public void color_theme_change_wurzel() //Change the color theme
        {
            if (Form1.var_color_panel1 == "light_blue" && Form1.var_color_panel2 == "light_blue")
            {
                this.BackColor = Color.FromArgb(63, 238, 230); //backgroundcolor
                tbx_wurzel_radikand.BackColor = Color.FromArgb(63, 238, 230);
                cbx_wurzel_wurzel_expo.BackColor = Color.FromArgb(63, 238, 230);

            }
            else if (Form1.var_color_panel1 == "gray" && Form1.var_color_panel2 == "gray")
            {
                this.BackColor = Color.DarkGray; //backgroundcolor
                tbx_wurzel_radikand.BackColor = Color.DarkGray;
                cbx_wurzel_wurzel_expo.BackColor = Color.DarkGray;
            }
            else if (Form1.var_color_panel1 == "dark_gray_violett" && Form1.var_color_panel2 == "dark_gray_violett")
            {
                this.BackColor = Color.FromArgb(42, 42, 43); //backgroundcolor
                tbx_wurzel_radikand.BackColor = Color.FromArgb(42, 42, 43);
                cbx_wurzel_wurzel_expo.BackColor = Color.FromArgb(42, 42, 43);
            }
        }

        private void cbx_wurzel_wurzel_expo_SelectedIndexChanged(object sender, EventArgs e) //Selected Root Exponent
        {
            wurzel_selected_wurzel_exponent = cbx_wurzel_wurzel_expo.SelectedIndex;
        }

        private void btn_Wurzel_result_in_ans_Click(object sender, EventArgs e) //Puts the Result in the ANS variable
        {
            MessageBox.Show("Das Ergebnis " + Convert.ToString(wurzel_value_result) + " wurde in Ans gespeichert");
            Form1.var_ans = Convert.ToString(wurzel_value_result);
        }

        private void btn_Wurzel_wurzel_ausrechnen_Click(object sender, EventArgs e) //Calculates the result
        {
            wurzel_value_radikand = Convert.ToDouble(tbx_wurzel_radikand.Text);
            wurzel_value_result = Math.Pow(wurzel_value_radikand, 1.0 / wurzel_selected_wurzel_exponent);
            lbl_wurzel_result.Text = Convert.ToString(wurzel_value_result);
        }

    }
}
