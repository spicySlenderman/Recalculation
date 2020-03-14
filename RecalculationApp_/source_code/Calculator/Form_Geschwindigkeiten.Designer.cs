namespace Calculator
{
    partial class Form_Geschwindigkeiten
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Geschwindigkeiten));
            this.lbl_Geschwinidgkeit_given_speed = new System.Windows.Forms.Label();
            this.cbx_which_speed_unit = new System.Windows.Forms.ComboBox();
            this.lbl_kilometer_stunde_titel = new System.Windows.Forms.Label();
            this.tbx_kilometers_hour = new System.Windows.Forms.TextBox();
            this.lbl_meile_sekunde_titel = new System.Windows.Forms.Label();
            this.tbx_miles_hour = new System.Windows.Forms.TextBox();
            this.lbl_knoten_titel = new System.Windows.Forms.Label();
            this.tbx_knoten = new System.Windows.Forms.TextBox();
            this.lbl_m_s__titel = new System.Windows.Forms.Label();
            this.tbx_meter_second = new System.Windows.Forms.TextBox();
            this.lbl_geschindigkeit_titel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Geschwinidgkeit_given_speed
            // 
            this.lbl_Geschwinidgkeit_given_speed.AutoSize = true;
            this.lbl_Geschwinidgkeit_given_speed.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Geschwinidgkeit_given_speed.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_Geschwinidgkeit_given_speed.Location = new System.Drawing.Point(438, 130);
            this.lbl_Geschwinidgkeit_given_speed.Name = "lbl_Geschwinidgkeit_given_speed";
            this.lbl_Geschwinidgkeit_given_speed.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_Geschwinidgkeit_given_speed.Size = new System.Drawing.Size(106, 19);
            this.lbl_Geschwinidgkeit_given_speed.TabIndex = 115;
            this.lbl_Geschwinidgkeit_given_speed.Text = "gegebene Zeit";
            // 
            // cbx_which_speed_unit
            // 
            this.cbx_which_speed_unit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(238)))), ((int)(((byte)(230)))));
            this.cbx_which_speed_unit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbx_which_speed_unit.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_which_speed_unit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cbx_which_speed_unit.FormattingEnabled = true;
            this.cbx_which_speed_unit.Items.AddRange(new object[] {
            "Meter pro Sekunde",
            "Knoten",
            "Meilen pro Stunde",
            "Kilometer pro Stunde"});
            this.cbx_which_speed_unit.Location = new System.Drawing.Point(442, 152);
            this.cbx_which_speed_unit.Name = "cbx_which_speed_unit";
            this.cbx_which_speed_unit.Size = new System.Drawing.Size(151, 27);
            this.cbx_which_speed_unit.TabIndex = 114;
            this.cbx_which_speed_unit.SelectedIndexChanged += new System.EventHandler(this.cbx_which_speed_unit_SelectedIndexChanged);
            // 
            // lbl_kilometer_stunde_titel
            // 
            this.lbl_kilometer_stunde_titel.AutoSize = true;
            this.lbl_kilometer_stunde_titel.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_kilometer_stunde_titel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_kilometer_stunde_titel.Location = new System.Drawing.Point(37, 235);
            this.lbl_kilometer_stunde_titel.Name = "lbl_kilometer_stunde_titel";
            this.lbl_kilometer_stunde_titel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_kilometer_stunde_titel.Size = new System.Drawing.Size(174, 19);
            this.lbl_kilometer_stunde_titel.TabIndex = 111;
            this.lbl_kilometer_stunde_titel.Text = "Kilometer/Stunde (km/h)";
            // 
            // tbx_kilometers_hour
            // 
            this.tbx_kilometers_hour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(238)))), ((int)(((byte)(230)))));
            this.tbx_kilometers_hour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_kilometers_hour.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_kilometers_hour.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tbx_kilometers_hour.Location = new System.Drawing.Point(217, 225);
            this.tbx_kilometers_hour.Multiline = true;
            this.tbx_kilometers_hour.Name = "tbx_kilometers_hour";
            this.tbx_kilometers_hour.Size = new System.Drawing.Size(187, 29);
            this.tbx_kilometers_hour.TabIndex = 110;
            this.tbx_kilometers_hour.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbx_kilometers_hour.TextChanged += new System.EventHandler(this.tbx_kilometers_hour_TextChanged);
            // 
            // lbl_meile_sekunde_titel
            // 
            this.lbl_meile_sekunde_titel.AutoSize = true;
            this.lbl_meile_sekunde_titel.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_meile_sekunde_titel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_meile_sekunde_titel.Location = new System.Drawing.Point(37, 200);
            this.lbl_meile_sekunde_titel.Name = "lbl_meile_sekunde_titel";
            this.lbl_meile_sekunde_titel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_meile_sekunde_titel.Size = new System.Drawing.Size(150, 19);
            this.lbl_meile_sekunde_titel.TabIndex = 109;
            this.lbl_meile_sekunde_titel.Text = "Meilen/Stunde (mph)";
            // 
            // tbx_miles_hour
            // 
            this.tbx_miles_hour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(238)))), ((int)(((byte)(230)))));
            this.tbx_miles_hour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_miles_hour.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_miles_hour.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tbx_miles_hour.Location = new System.Drawing.Point(217, 190);
            this.tbx_miles_hour.Multiline = true;
            this.tbx_miles_hour.Name = "tbx_miles_hour";
            this.tbx_miles_hour.Size = new System.Drawing.Size(187, 29);
            this.tbx_miles_hour.TabIndex = 108;
            this.tbx_miles_hour.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbx_miles_hour.TextChanged += new System.EventHandler(this.tbx_miles_hour_TextChanged);
            // 
            // lbl_knoten_titel
            // 
            this.lbl_knoten_titel.AutoSize = true;
            this.lbl_knoten_titel.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_knoten_titel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_knoten_titel.Location = new System.Drawing.Point(37, 165);
            this.lbl_knoten_titel.Name = "lbl_knoten_titel";
            this.lbl_knoten_titel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_knoten_titel.Size = new System.Drawing.Size(125, 19);
            this.lbl_knoten_titel.TabIndex = 107;
            this.lbl_knoten_titel.Text = "Knoten (Seefahrt)";
            // 
            // tbx_knoten
            // 
            this.tbx_knoten.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(238)))), ((int)(((byte)(230)))));
            this.tbx_knoten.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_knoten.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_knoten.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tbx_knoten.Location = new System.Drawing.Point(217, 155);
            this.tbx_knoten.Multiline = true;
            this.tbx_knoten.Name = "tbx_knoten";
            this.tbx_knoten.Size = new System.Drawing.Size(187, 29);
            this.tbx_knoten.TabIndex = 106;
            this.tbx_knoten.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbx_knoten.TextChanged += new System.EventHandler(this.tbx_knoten_TextChanged);
            // 
            // lbl_m_s__titel
            // 
            this.lbl_m_s__titel.AutoSize = true;
            this.lbl_m_s__titel.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_m_s__titel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_m_s__titel.Location = new System.Drawing.Point(37, 130);
            this.lbl_m_s__titel.Name = "lbl_m_s__titel";
            this.lbl_m_s__titel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_m_s__titel.Size = new System.Drawing.Size(149, 19);
            this.lbl_m_s__titel.TabIndex = 105;
            this.lbl_m_s__titel.Text = "Meter/Sekunde (m/s)";
            // 
            // tbx_meter_second
            // 
            this.tbx_meter_second.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(238)))), ((int)(((byte)(230)))));
            this.tbx_meter_second.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_meter_second.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_meter_second.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tbx_meter_second.Location = new System.Drawing.Point(217, 120);
            this.tbx_meter_second.Multiline = true;
            this.tbx_meter_second.Name = "tbx_meter_second";
            this.tbx_meter_second.Size = new System.Drawing.Size(187, 29);
            this.tbx_meter_second.TabIndex = 104;
            this.tbx_meter_second.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbx_meter_second.TextChanged += new System.EventHandler(this.tbx_meter_second_TextChanged);
            // 
            // lbl_geschindigkeit_titel
            // 
            this.lbl_geschindigkeit_titel.AutoSize = true;
            this.lbl_geschindigkeit_titel.Font = new System.Drawing.Font("Microsoft Tai Le", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_geschindigkeit_titel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_geschindigkeit_titel.Location = new System.Drawing.Point(136, 9);
            this.lbl_geschindigkeit_titel.Name = "lbl_geschindigkeit_titel";
            this.lbl_geschindigkeit_titel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_geschindigkeit_titel.Size = new System.Drawing.Size(255, 37);
            this.lbl_geschindigkeit_titel.TabIndex = 103;
            this.lbl_geschindigkeit_titel.Text = "Geschwindigkeiten";
            // 
            // Form_Geschwindigkeiten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(238)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(605, 327);
            this.Controls.Add(this.lbl_Geschwinidgkeit_given_speed);
            this.Controls.Add(this.cbx_which_speed_unit);
            this.Controls.Add(this.lbl_kilometer_stunde_titel);
            this.Controls.Add(this.tbx_kilometers_hour);
            this.Controls.Add(this.lbl_meile_sekunde_titel);
            this.Controls.Add(this.tbx_miles_hour);
            this.Controls.Add(this.lbl_knoten_titel);
            this.Controls.Add(this.tbx_knoten);
            this.Controls.Add(this.lbl_m_s__titel);
            this.Controls.Add(this.tbx_meter_second);
            this.Controls.Add(this.lbl_geschindigkeit_titel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Geschwindigkeiten";
            this.Text = "Geschwindigkeiten";
            this.Load += new System.EventHandler(this.Form_Geschwindigkeiten_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Geschwinidgkeit_given_speed;
        private System.Windows.Forms.ComboBox cbx_which_speed_unit;
        private System.Windows.Forms.Label lbl_kilometer_stunde_titel;
        private System.Windows.Forms.TextBox tbx_kilometers_hour;
        private System.Windows.Forms.Label lbl_meile_sekunde_titel;
        private System.Windows.Forms.TextBox tbx_miles_hour;
        private System.Windows.Forms.Label lbl_knoten_titel;
        private System.Windows.Forms.TextBox tbx_knoten;
        private System.Windows.Forms.Label lbl_m_s__titel;
        private System.Windows.Forms.TextBox tbx_meter_second;
        private System.Windows.Forms.Label lbl_geschindigkeit_titel;
    }
}