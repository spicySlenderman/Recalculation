using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
    App Name: Recalculation
    Description: A simple Calculator with Additional functions. Calculate simple.
    Version: 1.1
    Author: spicySlenderman
    last changes: 10.03.2020
    project created: 26.10.2019
    Remarks: you cant write in second text box. You can only give numbers by pressing the buttons, because its in readonly mode.
    future ideas: Schlussrechnung, Prozentrechnungen, Zinsenrechnung, green theme color
*/

namespace Calculator
{
    public partial class Form1 : Form
    {
        string project_calculator_version = "1.1"; //Recalculation Version
        string last_operator, last_pressed_button; //for the calculation
        double interim_value = 0, result = 0; //for the calculation

        public static string var_ans = ""; //global variable that can be changed by all forms

        public static string var_color_panel1 = "light_blue"; //set the default theme color to blue
        public static string var_color_panel2 = "light_blue";

        public Form1()
        {
            InitializeComponent();
        }

        public void color_theme_change() //to change the color theme
        {
            if (var_color_panel1 == "light_blue" && var_color_panel2 == "light_blue")
            {
                panel1.BackColor = Color.FromArgb(85, 188, 201);
                panel2.BackColor = Color.FromArgb(63, 238, 230);
                projectToolStripMenuItem.BackColor = Color.FromArgb(85, 188, 201); //Menu strip Item
                Formm1_menustrip.BackColor = Color.FromArgb(85, 188, 201); //Menu strip color
                tbx_interimresult.BackColor = Color.FromArgb(85, 188, 201); //Interim result back color
                tbx_result_rechnung.BackColor = Color.FromArgb(85, 188, 201); //result back color
            }
            else if (var_color_panel1 == "gray" && var_color_panel2 == "gray")
            {
                panel1.BackColor = Color.Gray; //Oben
                panel2.BackColor = Color.DarkGray; //Unten
                projectToolStripMenuItem.BackColor = Color.Gray;
                Formm1_menustrip.BackColor = Color.Gray; //Menu strip color
                tbx_interimresult.BackColor = Color.Gray; //Interim result back color
                tbx_result_rechnung.BackColor = Color.Gray; //result back color
            }
            else if (var_color_panel1 == "dark_gray_violett" && var_color_panel2 == "dark_gray_violett")
            {
                panel1.BackColor = Color.FromArgb(148, 50, 255); //Oben
                panel2.BackColor = Color.FromArgb(42, 42, 43); //Unten
                projectToolStripMenuItem.BackColor = Color.FromArgb(148, 50, 255);
                Formm1_menustrip.BackColor = Color.FromArgb(148, 50, 255); //Menu strip color
                tbx_interimresult.BackColor = Color.FromArgb(148, 50, 255); //Interim result back color
                tbx_result_rechnung.BackColor = Color.FromArgb(148, 50, 255); //result back color
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btn_numb_0_Click(object sender, EventArgs e) //button 0
        {
            tbx_result_rechnung.Text = tbx_result_rechnung.Text + "0";
            last_pressed_button = "number";
        }

        private void btn_numb_1_Click(object sender, EventArgs e) //button 1
        {
            tbx_result_rechnung.Text = tbx_result_rechnung.Text + "1";
            last_pressed_button = "number";
        }

        private void btn_numb_2_Click(object sender, EventArgs e) //button 2
        {
            tbx_result_rechnung.Text = tbx_result_rechnung.Text + "2";
            last_pressed_button = "number";
        }

        private void btn_numb_3_Click(object sender, EventArgs e) //button 3
        {
            tbx_result_rechnung.Text = tbx_result_rechnung.Text + "3";
            last_pressed_button = "number";
        }

        private void btn_numb_4_Click(object sender, EventArgs e) //button 4
        {
            tbx_result_rechnung.Text = tbx_result_rechnung.Text + "4";
            last_pressed_button = "number";
        }

        private void btn_numb_5_Click(object sender, EventArgs e) //button 5
        {
            tbx_result_rechnung.Text = tbx_result_rechnung.Text + "5";
            last_pressed_button = "number";
        }

        private void btn_numb_6_Click(object sender, EventArgs e) //button 6
        {
            tbx_result_rechnung.Text = tbx_result_rechnung.Text + "6";
            last_pressed_button = "number";
        }

        private void btn_numb_7_Click(object sender, EventArgs e) //button 7 
        {
            tbx_result_rechnung.Text = tbx_result_rechnung.Text + "7";
            last_pressed_button = "number";
        }

        private void btn_numb_8_Click(object sender, EventArgs e) //button 8
        {
            tbx_result_rechnung.Text = tbx_result_rechnung.Text + "8";
            last_pressed_button = "number";
        }

        private void btn_numb_9_Click(object sender, EventArgs e) //button 9
        {
            tbx_result_rechnung.Text = tbx_result_rechnung.Text + "9";
            last_pressed_button = "number";
        }

        private void btn_numb_point_Click(object sender, EventArgs e) //button point 
        {
            tbx_result_rechnung.Text = tbx_result_rechnung.Text + ",";
        }

        private void btn_numb_plus_Click(object sender, EventArgs e) //button plus(+)
        {
            last_operator = " + ";
            if(tbx_result_rechnung.Text == "")
            {
                interim_value = 0;
            }
            else
            {
                interim_value = Convert.ToDouble(tbx_result_rechnung.Text);
            } 
            tbx_interimresult.Text = tbx_result_rechnung.Text + last_operator;
            tbx_result_rechnung.Text = "";
            last_pressed_button = "math_operator";
        }

        private void btn_numb_minus_Click(object sender, EventArgs e) //button minus(-)
        {

            last_operator = " - ";
            if (tbx_result_rechnung.Text == "")
            {
                interim_value = 0;
            }
            else
            {
                interim_value = Convert.ToDouble(tbx_result_rechnung.Text);
            }
            tbx_interimresult.Text = tbx_result_rechnung.Text + last_operator;
            tbx_result_rechnung.Text = "";
            last_pressed_button = "math_operator";
        }

        private void btn_numb_multiple_Click(object sender, EventArgs e) //button multiple(*)
        {

            last_operator = " * ";
            if (tbx_result_rechnung.Text == "")
            {
                interim_value = 0;
            }
            else
            {
                interim_value = Convert.ToDouble(tbx_result_rechnung.Text);
            }
            tbx_interimresult.Text = tbx_result_rechnung.Text + last_operator;
            tbx_result_rechnung.Text = "";
            last_pressed_button = "math_operator";
        }

        private void btn_numb_divide_Click(object sender, EventArgs e) //button divide(/)
        {

            last_operator = " / ";
            if (tbx_result_rechnung.Text == "")
            {
                interim_value = 0;
            }
            else
            {
                interim_value = Convert.ToDouble(tbx_result_rechnung.Text);
            }
            tbx_interimresult.Text = tbx_result_rechnung.Text + last_operator;
            tbx_result_rechnung.Text = "";
            last_pressed_button = "math_operator";
        }

        private void btn_numb_equal_Click(object sender, EventArgs e) //equal button 
        {
            if (last_pressed_button == "math_operator" || last_pressed_button == "equal" || last_pressed_button == "ce")
            {
            }
            else
            {
                switch (last_operator) //for the plus operator
                {
                    case " + ":
                        result = interim_value + Convert.ToDouble(tbx_result_rechnung.Text);
                        tbx_interimresult.Text = Convert.ToString(interim_value) + " + " + tbx_result_rechnung.Text;
                        tbx_result_rechnung.Text = "";
                        tbx_result_rechnung.Text = Convert.ToString(result);
                        last_pressed_button = "equal";
                        break;

                    case " - ": //for the minus operator
                        result = interim_value - Convert.ToDouble(tbx_result_rechnung.Text);
                        tbx_interimresult.Text = Convert.ToString(interim_value) + " - " + tbx_result_rechnung.Text;
                        tbx_result_rechnung.Text = "";
                        tbx_result_rechnung.Text = Convert.ToString(result);
                        last_pressed_button = "equal";
                        break;

                    case " * ": //for the multiplie operator
                        result = interim_value * Convert.ToDouble(tbx_result_rechnung.Text);
                        tbx_interimresult.Text = Convert.ToString(interim_value) + " * " + tbx_result_rechnung.Text;
                        tbx_result_rechnung.Text = "";
                        tbx_result_rechnung.Text = Convert.ToString(result);
                        last_pressed_button = "equal";
                        break;

                    case " / ": //for the divide operator
                        result = interim_value / Convert.ToDouble(tbx_result_rechnung.Text);
                        tbx_interimresult.Text = Convert.ToString(interim_value) + " / " + tbx_result_rechnung.Text;
                        tbx_result_rechnung.Text = "";
                        tbx_result_rechnung.Text = Convert.ToString(result);
                        last_pressed_button = "equal";
                        break;
                }
            }

            
        }

        private void tbx_result_rechnung_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_numb_ans_Click(object sender, EventArgs e) //set ans into the textbox
        {
            tbx_result_rechnung.Text += var_ans; 
        }

        private void btn_Potenz_Click(object sender, EventArgs e) //Potenz window
        {
            Form_Potenz potenz = new Form_Potenz();
            potenz.Show();
        }

        private void btn_form_root_Click(object sender, EventArgs e) // Root window
        {
            Form_Wurzel wurzel = new Form_Wurzel();
            wurzel.Show();
        }

        private void btn_form_pythagoras_Click(object sender, EventArgs e) //Pythagoras window
        {
            Form_Pythagoras pythagoras = new Form_Pythagoras();
            pythagoras.Show();
        }

        private void btn_Flächen_Click(object sender, EventArgs e) //Area window
        {
            Form_Flächen flächen = new Form_Flächen();
            flächen.Show();
        }

        private void btn_Form_Volumen_Click(object sender, EventArgs e) //Volume window
        {
            Form_Volumen volumen = new Form_Volumen();
            volumen.Show();
        }

        private void btn_Form_Gewicht_Click(object sender, EventArgs e) //Weight window
        {
            Form_Gewicht gewicht = new Form_Gewicht();
            gewicht.Show();
        }

        private void versionToolStripMenuItem_Click(object sender, EventArgs e) //Strip Menue
        {
            MessageBox.Show("Appname: Recalculation\nAuthor: Julian Hofstadler\nVersion: " + project_calculator_version);
        }

        private void Form1_Load(object sender, EventArgs e) //When the Form loads
        {
        }

        private void btn_Form_Längen_Click(object sender, EventArgs e) //Length window
        {
            Form_Längen längen = new Form_Längen();
            längen.Show();
        }

        private void btn_Form_Zeiten_Click(object sender, EventArgs e) //Time window
        {
            Form_Zeit zeiten = new Form_Zeit();
            zeiten.Show();
        }

        private void btn_Form_Geschwindigkeiten_Click(object sender, EventArgs e) //Speed window
        {
            Form_Geschwindigkeiten geschwindigkeiten = new Form_Geschwindigkeiten();
            geschwindigkeiten.Show();
        }

        private void hellblauToolStripMenuItem_Click(object sender, EventArgs e) //Select the light_blue theme in the strip menue
        {
            var_color_panel1 = "light_blue";
            var_color_panel2 = "light_blue";
            color_theme_change();
        }

        private void grauToolStripMenuItem_Click(object sender, EventArgs e) //Select the gray theme in the strip menue
        {
            var_color_panel1 = "gray";
            var_color_panel2 = "gray";
            color_theme_change();
        }

        private void dunkelgrauViolettToolStripMenuItem_Click(object sender, EventArgs e) //Select the violett-black theme in the strip menue
        {
            var_color_panel1 = "dark_gray_violett";
            var_color_panel2 = "dark_gray_violett";
            color_theme_change();
        }

        private void btn_numb_ce_Click(object sender, EventArgs e) //Clear the current text button
        {
            tbx_result_rechnung.Text = "";
            last_pressed_button = "ce";
        }

        private void btn_numb_c_Click(object sender, EventArgs e) //Clear all button
        {
            last_operator = "";
            last_pressed_button = "ce";
            interim_value = 0; 
            result = 0;
            tbx_result_rechnung.Text = "";
            tbx_interimresult.Text = "";
        }
    }
}
