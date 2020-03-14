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
    App Name:
    Description:
    Version: 1.0
    Author: Julian Hofstadler
    last changes: 30.10.2019
    project created: 26.10.2019
    To Do: FARBSCHEMA BEI ALLEN FORMEN EINSTELLEN, error wenn programm fehler hat soll eine error messagebox kommen und das programm sol sich schließen, bei allen formen fertig designen
    Current Errors: kein klammern beim rechner.
    FARBSCHEMA:
    future ideas:Schlussrechnung, Prozentrechnungen
    Menu strip: Version, Farbschema eneinstellen

*/

namespace Calculator
{
    public partial class Form1 : Form
    {
        string project_calculator_version = "1.0";
        string last_operator, last_pressed_button;
        double interim_value = 0, result = 0;

        public static string var_ans = ""; //globale variable die von allen Form geändert werden kann

        public Form1()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btn_numb_0_Click(object sender, EventArgs e)
        {
            tbx_result_rechnung.Text = tbx_result_rechnung.Text + "0";
            last_pressed_button = "number";
        }

        private void btn_numb_1_Click(object sender, EventArgs e)
        {
            tbx_result_rechnung.Text = tbx_result_rechnung.Text + "1";
            last_pressed_button = "number";
        }

        private void btn_numb_2_Click(object sender, EventArgs e)
        {
            tbx_result_rechnung.Text = tbx_result_rechnung.Text + "2";
            last_pressed_button = "number";
        }

        private void btn_numb_3_Click(object sender, EventArgs e)
        {
            tbx_result_rechnung.Text = tbx_result_rechnung.Text + "3";
            last_pressed_button = "number";
        }

        private void btn_numb_4_Click(object sender, EventArgs e)
        {
            tbx_result_rechnung.Text = tbx_result_rechnung.Text + "4";
            last_pressed_button = "number";
        }

        private void btn_numb_5_Click(object sender, EventArgs e)
        {
            tbx_result_rechnung.Text = tbx_result_rechnung.Text + "5";
            last_pressed_button = "number";
        }

        private void btn_numb_6_Click(object sender, EventArgs e)
        {
            tbx_result_rechnung.Text = tbx_result_rechnung.Text + "6";
            last_pressed_button = "number";
        }

        private void btn_numb_7_Click(object sender, EventArgs e)
        {
            tbx_result_rechnung.Text = tbx_result_rechnung.Text + "7";
            last_pressed_button = "number";
        }

        private void btn_numb_8_Click(object sender, EventArgs e)
        {
            tbx_result_rechnung.Text = tbx_result_rechnung.Text + "8";
            last_pressed_button = "number";
        }

        private void btn_numb_9_Click(object sender, EventArgs e)
        {
            tbx_result_rechnung.Text = tbx_result_rechnung.Text + "9";
            last_pressed_button = "number";
        }

        private void btn_numb_point_Click(object sender, EventArgs e)
        {
            tbx_result_rechnung.Text = tbx_result_rechnung.Text + ",";
        }

        private void btn_numb_plus_Click(object sender, EventArgs e)
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

        private void btn_numb_minus_Click(object sender, EventArgs e)
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

        private void btn_numb_multiple_Click(object sender, EventArgs e)
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

        private void btn_numb_divide_Click(object sender, EventArgs e)
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

        private void btn_numb_equal_Click(object sender, EventArgs e)
        {
            if (last_pressed_button == "math_operator" || last_pressed_button == "equal" || last_pressed_button == "ce")
            {

            }
            else
            {
                switch (last_operator)
                {
                    case " + ":
                        result = interim_value + Convert.ToDouble(tbx_result_rechnung.Text);
                        tbx_interimresult.Text = Convert.ToString(interim_value) + " + " + tbx_result_rechnung.Text;
                        tbx_result_rechnung.Text = "";
                        tbx_result_rechnung.Text = Convert.ToString(result);
                        last_pressed_button = "equal";
                        break;

                    case " - ":
                        result = interim_value - Convert.ToDouble(tbx_result_rechnung.Text);
                        tbx_interimresult.Text = Convert.ToString(interim_value) + " - " + tbx_result_rechnung.Text;
                        tbx_result_rechnung.Text = "";
                        tbx_result_rechnung.Text = Convert.ToString(result);
                        last_pressed_button = "equal";
                        break;

                    case " * ":
                        result = interim_value * Convert.ToDouble(tbx_result_rechnung.Text);
                        tbx_interimresult.Text = Convert.ToString(interim_value) + " * " + tbx_result_rechnung.Text;
                        tbx_result_rechnung.Text = "";
                        tbx_result_rechnung.Text = Convert.ToString(result);
                        last_pressed_button = "equal";
                        break;

                    case " / ":
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

        private void btn_numb_ans_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(var_ans);
            tbx_result_rechnung.Text += var_ans;
        }

        private void btn_Potenz_Click(object sender, EventArgs e)
        {
            Form_Potenz potenz = new Form_Potenz();
            potenz.Show();
        }

        private void btn_form_root_Click(object sender, EventArgs e)
        {
            Form_Wurzel wurzel = new Form_Wurzel();
            wurzel.Show();
        }

        private void btn_form_pythagoras_Click(object sender, EventArgs e)
        {
            Form_Pythagoras pythagoras = new Form_Pythagoras();
            pythagoras.Show();
        }

        private void btn_Flächen_Click(object sender, EventArgs e)
        {
            Form_Flächen flächen = new Form_Flächen();
            flächen.Show();
        }

        private void btn_Form_Volumen_Click(object sender, EventArgs e)
        {
            Form_Volumen volumen = new Form_Volumen();
            volumen.Show();
        }

        private void btn_Form_Gewicht_Click(object sender, EventArgs e)
        {
            Form_Gewicht gewicht = new Form_Gewicht();
            gewicht.Show();
        }

        private void versionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Version: " + project_calculator_version);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Form_Längen_Click(object sender, EventArgs e)
        {
            Form_Längen längen = new Form_Längen();
            längen.Show();
        }

        private void btn_Form_Zeiten_Click(object sender, EventArgs e)
        {
            Form_Zeit zeiten = new Form_Zeit();
            zeiten.Show();
        }

        private void btn_Form_Geschwindigkeiten_Click(object sender, EventArgs e)
        {
            Form_Geschwindigkeiten geschwindigkeiten = new Form_Geschwindigkeiten();
            geschwindigkeiten.Show();
        }

        private void btn_numb_ce_Click(object sender, EventArgs e)
        {
            tbx_result_rechnung.Text = "";
            last_pressed_button = "ce";
        }

        private void btn_numb_c_Click(object sender, EventArgs e)
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
/*
 Memo: Farben: jetztige Farbschema: blau türkis: oben: #55BCC9 unten: #3FEEE6
                Ideen: violett schwarz: wie im diesen video: https://www.youtube.com/watch?v=cf3GFbTZO2U
*/

