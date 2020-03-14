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
    public partial class Form_Potenz : Form
    {
        int potenz_selected_exponent; //Selected Expnent
        double potenz_value_basis, potenz_value_result; //Values to calculate

        public Form_Potenz()
        {
            InitializeComponent();
        }

        private void Potenz_Load(object sender, EventArgs e) //When the Form loads
        {
            color_theme_change_potenz(); 
        }

        public void color_theme_change_potenz() //Change the  color theme
        {
            if (Form1.var_color_panel1 == "light_blue" && Form1.var_color_panel2 == "light_blue")
            { 
                this.BackColor = Color.FromArgb(63, 238, 230); //backgroundcolor
                tbx_potenz_basis.BackColor = Color.FromArgb(63, 238, 230);
                cbx_potenz_expo.BackColor = Color.FromArgb(63, 238, 230);

            }
            else if (Form1.var_color_panel1 == "gray" && Form1.var_color_panel2 == "gray")
            {
                this.BackColor = Color.DarkGray; //backgroundcolor
                tbx_potenz_basis.BackColor = Color.DarkGray;
                cbx_potenz_expo.BackColor = Color.DarkGray;
            }
            else if (Form1.var_color_panel1 == "dark_gray_violett" && Form1.var_color_panel2 == "dark_gray_violett")
            {
                this.BackColor = Color.FromArgb(42, 42, 43); //backgroundcolor
                tbx_potenz_basis.BackColor = Color.FromArgb(42, 42, 43);
                cbx_potenz_expo.BackColor = Color.FromArgb(42, 42, 43);
            }
        }

        private void cbx_potenz_expo_SelectedIndexChanged(object sender, EventArgs e) //Selected Exponent
        {
            potenz_selected_exponent = cbx_potenz_expo.SelectedIndex;
        }

        private void btn_result_in_ans_Click(object sender, EventArgs e) //Put the result in the ans variable
        {
            MessageBox.Show("Das Ergebnis " + Convert.ToString(potenz_value_result) + " wurde in Ans gespeichert");
            Form1.var_ans = Convert.ToString(potenz_value_result);
        }

        private void tbx_potenz_basis_TextChanged(object sender, EventArgs e)
        {
        }

        private void btn_Potenz_potenz_ausrechnen_Click(object sender, EventArgs e) //Calculate the result 
        {
            potenz_value_basis = Convert.ToDouble(tbx_potenz_basis.Text);
            potenz_value_result = Math.Pow(potenz_value_basis, potenz_selected_exponent);
            lbl_potenz_result.Text = Convert.ToString(potenz_value_result);
        }
    }
}
