namespace Calculator
{
    partial class Form_Zeit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Zeit));
            this.lbl_Zeit_given_Zeit = new System.Windows.Forms.Label();
            this.cbx_which_zeit_unit = new System.Windows.Forms.ComboBox();
            this.lbl_tag_titel = new System.Windows.Forms.Label();
            this.tbx_tag = new System.Windows.Forms.TextBox();
            this.lbl_stunde_titel = new System.Windows.Forms.Label();
            this.tbx_stunde = new System.Windows.Forms.TextBox();
            this.lbl_minute_titel = new System.Windows.Forms.Label();
            this.tbx_minute = new System.Windows.Forms.TextBox();
            this.lbl_sekunde_titel = new System.Windows.Forms.Label();
            this.tbx_sekunde = new System.Windows.Forms.TextBox();
            this.lbl_millisekunde_titel = new System.Windows.Forms.Label();
            this.tbx_millisekunde = new System.Windows.Forms.TextBox();
            this.lbl_Zeit_titel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Zeit_given_Zeit
            // 
            this.lbl_Zeit_given_Zeit.AutoSize = true;
            this.lbl_Zeit_given_Zeit.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Zeit_given_Zeit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_Zeit_given_Zeit.Location = new System.Drawing.Point(382, 120);
            this.lbl_Zeit_given_Zeit.Name = "lbl_Zeit_given_Zeit";
            this.lbl_Zeit_given_Zeit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_Zeit_given_Zeit.Size = new System.Drawing.Size(106, 19);
            this.lbl_Zeit_given_Zeit.TabIndex = 102;
            this.lbl_Zeit_given_Zeit.Text = "gegebene Zeit";
            // 
            // cbx_which_zeit_unit
            // 
            this.cbx_which_zeit_unit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(238)))), ((int)(((byte)(230)))));
            this.cbx_which_zeit_unit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbx_which_zeit_unit.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_which_zeit_unit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cbx_which_zeit_unit.FormattingEnabled = true;
            this.cbx_which_zeit_unit.Items.AddRange(new object[] {
            "Milisekunde",
            "Sekunde",
            "Minute",
            "Stunde",
            "Tag"});
            this.cbx_which_zeit_unit.Location = new System.Drawing.Point(386, 142);
            this.cbx_which_zeit_unit.Name = "cbx_which_zeit_unit";
            this.cbx_which_zeit_unit.Size = new System.Drawing.Size(117, 27);
            this.cbx_which_zeit_unit.TabIndex = 101;
            this.cbx_which_zeit_unit.SelectedIndexChanged += new System.EventHandler(this.cbx_which_zeit_unit_SelectedIndexChanged);
            // 
            // lbl_tag_titel
            // 
            this.lbl_tag_titel.AutoSize = true;
            this.lbl_tag_titel.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tag_titel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_tag_titel.Location = new System.Drawing.Point(37, 270);
            this.lbl_tag_titel.Name = "lbl_tag_titel";
            this.lbl_tag_titel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_tag_titel.Size = new System.Drawing.Size(34, 19);
            this.lbl_tag_titel.TabIndex = 100;
            this.lbl_tag_titel.Text = "Tag";
            // 
            // tbx_tag
            // 
            this.tbx_tag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(238)))), ((int)(((byte)(230)))));
            this.tbx_tag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_tag.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_tag.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tbx_tag.Location = new System.Drawing.Point(160, 260);
            this.tbx_tag.Multiline = true;
            this.tbx_tag.Name = "tbx_tag";
            this.tbx_tag.Size = new System.Drawing.Size(187, 29);
            this.tbx_tag.TabIndex = 99;
            this.tbx_tag.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbx_tag.TextChanged += new System.EventHandler(this.tbx_tag_TextChanged);
            // 
            // lbl_stunde_titel
            // 
            this.lbl_stunde_titel.AutoSize = true;
            this.lbl_stunde_titel.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stunde_titel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_stunde_titel.Location = new System.Drawing.Point(37, 235);
            this.lbl_stunde_titel.Name = "lbl_stunde_titel";
            this.lbl_stunde_titel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_stunde_titel.Size = new System.Drawing.Size(55, 19);
            this.lbl_stunde_titel.TabIndex = 98;
            this.lbl_stunde_titel.Text = "Stunde";
            // 
            // tbx_stunde
            // 
            this.tbx_stunde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(238)))), ((int)(((byte)(230)))));
            this.tbx_stunde.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_stunde.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_stunde.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tbx_stunde.Location = new System.Drawing.Point(160, 225);
            this.tbx_stunde.Multiline = true;
            this.tbx_stunde.Name = "tbx_stunde";
            this.tbx_stunde.Size = new System.Drawing.Size(187, 29);
            this.tbx_stunde.TabIndex = 97;
            this.tbx_stunde.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbx_stunde.TextChanged += new System.EventHandler(this.tbx_stunde_TextChanged);
            // 
            // lbl_minute_titel
            // 
            this.lbl_minute_titel.AutoSize = true;
            this.lbl_minute_titel.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_minute_titel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_minute_titel.Location = new System.Drawing.Point(37, 200);
            this.lbl_minute_titel.Name = "lbl_minute_titel";
            this.lbl_minute_titel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_minute_titel.Size = new System.Drawing.Size(55, 19);
            this.lbl_minute_titel.TabIndex = 96;
            this.lbl_minute_titel.Text = "Minute";
            // 
            // tbx_minute
            // 
            this.tbx_minute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(238)))), ((int)(((byte)(230)))));
            this.tbx_minute.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_minute.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_minute.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tbx_minute.Location = new System.Drawing.Point(160, 190);
            this.tbx_minute.Multiline = true;
            this.tbx_minute.Name = "tbx_minute";
            this.tbx_minute.Size = new System.Drawing.Size(187, 29);
            this.tbx_minute.TabIndex = 95;
            this.tbx_minute.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbx_minute.TextChanged += new System.EventHandler(this.tbx_minute_TextChanged);
            // 
            // lbl_sekunde_titel
            // 
            this.lbl_sekunde_titel.AutoSize = true;
            this.lbl_sekunde_titel.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sekunde_titel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_sekunde_titel.Location = new System.Drawing.Point(37, 165);
            this.lbl_sekunde_titel.Name = "lbl_sekunde_titel";
            this.lbl_sekunde_titel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_sekunde_titel.Size = new System.Drawing.Size(65, 19);
            this.lbl_sekunde_titel.TabIndex = 94;
            this.lbl_sekunde_titel.Text = "Sekunde";
            // 
            // tbx_sekunde
            // 
            this.tbx_sekunde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(238)))), ((int)(((byte)(230)))));
            this.tbx_sekunde.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_sekunde.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_sekunde.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tbx_sekunde.Location = new System.Drawing.Point(160, 155);
            this.tbx_sekunde.Multiline = true;
            this.tbx_sekunde.Name = "tbx_sekunde";
            this.tbx_sekunde.Size = new System.Drawing.Size(187, 29);
            this.tbx_sekunde.TabIndex = 93;
            this.tbx_sekunde.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbx_sekunde.TextChanged += new System.EventHandler(this.tbx_sekunde_TextChanged);
            // 
            // lbl_millisekunde_titel
            // 
            this.lbl_millisekunde_titel.AutoSize = true;
            this.lbl_millisekunde_titel.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_millisekunde_titel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_millisekunde_titel.Location = new System.Drawing.Point(37, 130);
            this.lbl_millisekunde_titel.Name = "lbl_millisekunde_titel";
            this.lbl_millisekunde_titel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_millisekunde_titel.Size = new System.Drawing.Size(92, 19);
            this.lbl_millisekunde_titel.TabIndex = 92;
            this.lbl_millisekunde_titel.Text = "Millisekunde";
            // 
            // tbx_millisekunde
            // 
            this.tbx_millisekunde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(238)))), ((int)(((byte)(230)))));
            this.tbx_millisekunde.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_millisekunde.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_millisekunde.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tbx_millisekunde.Location = new System.Drawing.Point(160, 120);
            this.tbx_millisekunde.Multiline = true;
            this.tbx_millisekunde.Name = "tbx_millisekunde";
            this.tbx_millisekunde.Size = new System.Drawing.Size(187, 29);
            this.tbx_millisekunde.TabIndex = 91;
            this.tbx_millisekunde.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbx_millisekunde.TextChanged += new System.EventHandler(this.tbx_millisekunde_TextChanged);
            // 
            // lbl_Zeit_titel
            // 
            this.lbl_Zeit_titel.AutoSize = true;
            this.lbl_Zeit_titel.Font = new System.Drawing.Font("Microsoft Tai Le", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Zeit_titel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_Zeit_titel.Location = new System.Drawing.Point(202, 38);
            this.lbl_Zeit_titel.Name = "lbl_Zeit_titel";
            this.lbl_Zeit_titel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_Zeit_titel.Size = new System.Drawing.Size(66, 37);
            this.lbl_Zeit_titel.TabIndex = 90;
            this.lbl_Zeit_titel.Text = "Zeit";
            // 
            // Form_Zeit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(238)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(541, 327);
            this.Controls.Add(this.lbl_Zeit_given_Zeit);
            this.Controls.Add(this.cbx_which_zeit_unit);
            this.Controls.Add(this.lbl_tag_titel);
            this.Controls.Add(this.tbx_tag);
            this.Controls.Add(this.lbl_stunde_titel);
            this.Controls.Add(this.tbx_stunde);
            this.Controls.Add(this.lbl_minute_titel);
            this.Controls.Add(this.tbx_minute);
            this.Controls.Add(this.lbl_sekunde_titel);
            this.Controls.Add(this.tbx_sekunde);
            this.Controls.Add(this.lbl_millisekunde_titel);
            this.Controls.Add(this.tbx_millisekunde);
            this.Controls.Add(this.lbl_Zeit_titel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Zeit";
            this.Text = "Zeit";
            this.Load += new System.EventHandler(this.Form_Zeit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Zeit_given_Zeit;
        private System.Windows.Forms.ComboBox cbx_which_zeit_unit;
        private System.Windows.Forms.Label lbl_tag_titel;
        private System.Windows.Forms.TextBox tbx_tag;
        private System.Windows.Forms.Label lbl_stunde_titel;
        private System.Windows.Forms.TextBox tbx_stunde;
        private System.Windows.Forms.Label lbl_minute_titel;
        private System.Windows.Forms.TextBox tbx_minute;
        private System.Windows.Forms.Label lbl_sekunde_titel;
        private System.Windows.Forms.TextBox tbx_sekunde;
        private System.Windows.Forms.Label lbl_millisekunde_titel;
        private System.Windows.Forms.TextBox tbx_millisekunde;
        private System.Windows.Forms.Label lbl_Zeit_titel;
    }
}