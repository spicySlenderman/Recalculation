namespace Calculator
{
    partial class Form_Längen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Längen));
            this.lbl_Längen_given_Länge = new System.Windows.Forms.Label();
            this.cbx_which_length_unit = new System.Windows.Forms.ComboBox();
            this.lbl_kilometer_titel = new System.Windows.Forms.Label();
            this.tbx_kilometer = new System.Windows.Forms.TextBox();
            this.lbl_meter_titel = new System.Windows.Forms.Label();
            this.tbx_meter = new System.Windows.Forms.TextBox();
            this.lbl_dezimeter_titel = new System.Windows.Forms.Label();
            this.tbx_dezimeter = new System.Windows.Forms.TextBox();
            this.lbl_zentimeter_titel = new System.Windows.Forms.Label();
            this.tbx_zentimeter = new System.Windows.Forms.TextBox();
            this.lbl_millimeter_titel = new System.Windows.Forms.Label();
            this.tbx_millimeter = new System.Windows.Forms.TextBox();
            this.lbl_Längen_titel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Längen_given_Länge
            // 
            this.lbl_Längen_given_Länge.AutoSize = true;
            this.lbl_Längen_given_Länge.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Längen_given_Länge.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Längen_given_Länge.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_Längen_given_Länge.Location = new System.Drawing.Point(377, 120);
            this.lbl_Längen_given_Länge.Name = "lbl_Längen_given_Länge";
            this.lbl_Längen_given_Länge.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_Längen_given_Länge.Size = new System.Drawing.Size(120, 19);
            this.lbl_Längen_given_Länge.TabIndex = 89;
            this.lbl_Längen_given_Länge.Text = "gegebene Länge";
            // 
            // cbx_which_length_unit
            // 
            this.cbx_which_length_unit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(238)))), ((int)(((byte)(230)))));
            this.cbx_which_length_unit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbx_which_length_unit.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_which_length_unit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cbx_which_length_unit.FormattingEnabled = true;
            this.cbx_which_length_unit.Items.AddRange(new object[] {
            "Millimeter",
            "Zentimeter",
            "Dezimeter",
            "Meter",
            "Kilometer"});
            this.cbx_which_length_unit.Location = new System.Drawing.Point(381, 142);
            this.cbx_which_length_unit.Name = "cbx_which_length_unit";
            this.cbx_which_length_unit.Size = new System.Drawing.Size(117, 27);
            this.cbx_which_length_unit.TabIndex = 88;
            this.cbx_which_length_unit.SelectedIndexChanged += new System.EventHandler(this.cbx_which_length_unit_SelectedIndexChanged);
            // 
            // lbl_kilometer_titel
            // 
            this.lbl_kilometer_titel.AutoSize = true;
            this.lbl_kilometer_titel.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_kilometer_titel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_kilometer_titel.Location = new System.Drawing.Point(32, 270);
            this.lbl_kilometer_titel.Name = "lbl_kilometer_titel";
            this.lbl_kilometer_titel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_kilometer_titel.Size = new System.Drawing.Size(108, 19);
            this.lbl_kilometer_titel.TabIndex = 87;
            this.lbl_kilometer_titel.Text = "Kilometer (km)";
            // 
            // tbx_kilometer
            // 
            this.tbx_kilometer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(238)))), ((int)(((byte)(230)))));
            this.tbx_kilometer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_kilometer.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_kilometer.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tbx_kilometer.Location = new System.Drawing.Point(155, 260);
            this.tbx_kilometer.Multiline = true;
            this.tbx_kilometer.Name = "tbx_kilometer";
            this.tbx_kilometer.Size = new System.Drawing.Size(187, 29);
            this.tbx_kilometer.TabIndex = 86;
            this.tbx_kilometer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbx_kilometer.TextChanged += new System.EventHandler(this.tbx_kilometer_TextChanged);
            // 
            // lbl_meter_titel
            // 
            this.lbl_meter_titel.AutoSize = true;
            this.lbl_meter_titel.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_meter_titel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_meter_titel.Location = new System.Drawing.Point(32, 235);
            this.lbl_meter_titel.Name = "lbl_meter_titel";
            this.lbl_meter_titel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_meter_titel.Size = new System.Drawing.Size(75, 19);
            this.lbl_meter_titel.TabIndex = 85;
            this.lbl_meter_titel.Text = "Meter (m)";
            // 
            // tbx_meter
            // 
            this.tbx_meter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(238)))), ((int)(((byte)(230)))));
            this.tbx_meter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_meter.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_meter.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tbx_meter.Location = new System.Drawing.Point(155, 225);
            this.tbx_meter.Multiline = true;
            this.tbx_meter.Name = "tbx_meter";
            this.tbx_meter.Size = new System.Drawing.Size(187, 29);
            this.tbx_meter.TabIndex = 84;
            this.tbx_meter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbx_meter.TextChanged += new System.EventHandler(this.tbx_meter_TextChanged);
            // 
            // lbl_dezimeter_titel
            // 
            this.lbl_dezimeter_titel.AutoSize = true;
            this.lbl_dezimeter_titel.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dezimeter_titel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_dezimeter_titel.Location = new System.Drawing.Point(32, 200);
            this.lbl_dezimeter_titel.Name = "lbl_dezimeter_titel";
            this.lbl_dezimeter_titel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_dezimeter_titel.Size = new System.Drawing.Size(114, 19);
            this.lbl_dezimeter_titel.TabIndex = 83;
            this.lbl_dezimeter_titel.Text = "Dezimeter (dm)";
            // 
            // tbx_dezimeter
            // 
            this.tbx_dezimeter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(238)))), ((int)(((byte)(230)))));
            this.tbx_dezimeter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_dezimeter.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_dezimeter.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tbx_dezimeter.Location = new System.Drawing.Point(155, 190);
            this.tbx_dezimeter.Multiline = true;
            this.tbx_dezimeter.Name = "tbx_dezimeter";
            this.tbx_dezimeter.Size = new System.Drawing.Size(187, 29);
            this.tbx_dezimeter.TabIndex = 82;
            this.tbx_dezimeter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbx_dezimeter.TextChanged += new System.EventHandler(this.tbx_dezimeter_TextChanged);
            // 
            // lbl_zentimeter_titel
            // 
            this.lbl_zentimeter_titel.AutoSize = true;
            this.lbl_zentimeter_titel.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_zentimeter_titel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_zentimeter_titel.Location = new System.Drawing.Point(32, 165);
            this.lbl_zentimeter_titel.Name = "lbl_zentimeter_titel";
            this.lbl_zentimeter_titel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_zentimeter_titel.Size = new System.Drawing.Size(116, 19);
            this.lbl_zentimeter_titel.TabIndex = 81;
            this.lbl_zentimeter_titel.Text = "Zentimeter (cm)";
            // 
            // tbx_zentimeter
            // 
            this.tbx_zentimeter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(238)))), ((int)(((byte)(230)))));
            this.tbx_zentimeter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_zentimeter.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_zentimeter.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tbx_zentimeter.Location = new System.Drawing.Point(155, 155);
            this.tbx_zentimeter.Multiline = true;
            this.tbx_zentimeter.Name = "tbx_zentimeter";
            this.tbx_zentimeter.Size = new System.Drawing.Size(187, 29);
            this.tbx_zentimeter.TabIndex = 80;
            this.tbx_zentimeter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbx_zentimeter.TextChanged += new System.EventHandler(this.tbx_zentimeter_TextChanged);
            // 
            // lbl_millimeter_titel
            // 
            this.lbl_millimeter_titel.AutoSize = true;
            this.lbl_millimeter_titel.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_millimeter_titel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_millimeter_titel.Location = new System.Drawing.Point(32, 130);
            this.lbl_millimeter_titel.Name = "lbl_millimeter_titel";
            this.lbl_millimeter_titel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_millimeter_titel.Size = new System.Drawing.Size(117, 19);
            this.lbl_millimeter_titel.TabIndex = 79;
            this.lbl_millimeter_titel.Text = "Millimeter (mm)";
            // 
            // tbx_millimeter
            // 
            this.tbx_millimeter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(238)))), ((int)(((byte)(230)))));
            this.tbx_millimeter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_millimeter.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_millimeter.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tbx_millimeter.Location = new System.Drawing.Point(155, 120);
            this.tbx_millimeter.Multiline = true;
            this.tbx_millimeter.Name = "tbx_millimeter";
            this.tbx_millimeter.Size = new System.Drawing.Size(187, 29);
            this.tbx_millimeter.TabIndex = 78;
            this.tbx_millimeter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbx_millimeter.TextChanged += new System.EventHandler(this.tbx_millimeter_TextChanged);
            // 
            // lbl_Längen_titel
            // 
            this.lbl_Längen_titel.AutoSize = true;
            this.lbl_Längen_titel.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Längen_titel.Font = new System.Drawing.Font("Microsoft Tai Le", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Längen_titel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_Längen_titel.Location = new System.Drawing.Point(197, 38);
            this.lbl_Längen_titel.Name = "lbl_Längen_titel";
            this.lbl_Längen_titel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_Längen_titel.Size = new System.Drawing.Size(110, 37);
            this.lbl_Längen_titel.TabIndex = 77;
            this.lbl_Längen_titel.Text = "Längen";
            // 
            // Form_Längen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(238)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(541, 327);
            this.Controls.Add(this.lbl_Längen_given_Länge);
            this.Controls.Add(this.cbx_which_length_unit);
            this.Controls.Add(this.lbl_kilometer_titel);
            this.Controls.Add(this.tbx_kilometer);
            this.Controls.Add(this.lbl_meter_titel);
            this.Controls.Add(this.tbx_meter);
            this.Controls.Add(this.lbl_dezimeter_titel);
            this.Controls.Add(this.tbx_dezimeter);
            this.Controls.Add(this.lbl_zentimeter_titel);
            this.Controls.Add(this.tbx_zentimeter);
            this.Controls.Add(this.lbl_millimeter_titel);
            this.Controls.Add(this.tbx_millimeter);
            this.Controls.Add(this.lbl_Längen_titel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Längen";
            this.Text = "Längen";
            this.Load += new System.EventHandler(this.Form_Längen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Längen_given_Länge;
        private System.Windows.Forms.ComboBox cbx_which_length_unit;
        private System.Windows.Forms.Label lbl_kilometer_titel;
        private System.Windows.Forms.TextBox tbx_kilometer;
        private System.Windows.Forms.Label lbl_meter_titel;
        private System.Windows.Forms.TextBox tbx_meter;
        private System.Windows.Forms.Label lbl_dezimeter_titel;
        private System.Windows.Forms.TextBox tbx_dezimeter;
        private System.Windows.Forms.Label lbl_zentimeter_titel;
        private System.Windows.Forms.TextBox tbx_zentimeter;
        private System.Windows.Forms.Label lbl_millimeter_titel;
        private System.Windows.Forms.TextBox tbx_millimeter;
        private System.Windows.Forms.Label lbl_Längen_titel;
    }
}