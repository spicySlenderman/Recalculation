namespace Calculator
{
    partial class Form_Pythagoras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Pythagoras));
            this.lbl_pythagoras_missing_length = new System.Windows.Forms.Label();
            this.lbl_Pythagoras_titel = new System.Windows.Forms.Label();
            this.cbx_pythagoras_missing_length = new System.Windows.Forms.ComboBox();
            this.tbx_length_a = new System.Windows.Forms.TextBox();
            this.lbl_missing_length_a = new System.Windows.Forms.Label();
            this.lbl_missing_length_b = new System.Windows.Forms.Label();
            this.tbx_length_b = new System.Windows.Forms.TextBox();
            this.tbx_length_c = new System.Windows.Forms.TextBox();
            this.lbl_missing_length_c = new System.Windows.Forms.Label();
            this.lbl_result_titel = new System.Windows.Forms.Label();
            this.lbl_result = new System.Windows.Forms.Label();
            this.btn_Pythagoras_pythagoras_ausrechnen = new System.Windows.Forms.Button();
            this.btn_Pythagoras_result_in_ans = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_pythagoras_missing_length
            // 
            this.lbl_pythagoras_missing_length.AutoSize = true;
            this.lbl_pythagoras_missing_length.BackColor = System.Drawing.Color.Transparent;
            this.lbl_pythagoras_missing_length.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pythagoras_missing_length.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_pythagoras_missing_length.Location = new System.Drawing.Point(12, 98);
            this.lbl_pythagoras_missing_length.Name = "lbl_pythagoras_missing_length";
            this.lbl_pythagoras_missing_length.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_pythagoras_missing_length.Size = new System.Drawing.Size(111, 19);
            this.lbl_pythagoras_missing_length.TabIndex = 31;
            this.lbl_pythagoras_missing_length.Text = "fehlende Länge";
            this.lbl_pythagoras_missing_length.Click += new System.EventHandler(this.lbl_pythagoras_missing_length_Click);
            // 
            // lbl_Pythagoras_titel
            // 
            this.lbl_Pythagoras_titel.AutoSize = true;
            this.lbl_Pythagoras_titel.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Pythagoras_titel.Font = new System.Drawing.Font("Microsoft Tai Le", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Pythagoras_titel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_Pythagoras_titel.Location = new System.Drawing.Point(195, 9);
            this.lbl_Pythagoras_titel.Name = "lbl_Pythagoras_titel";
            this.lbl_Pythagoras_titel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_Pythagoras_titel.Size = new System.Drawing.Size(159, 37);
            this.lbl_Pythagoras_titel.TabIndex = 32;
            this.lbl_Pythagoras_titel.Text = "Pythagoras";
            this.lbl_Pythagoras_titel.Click += new System.EventHandler(this.lbl_Pythagoras_titel_Click);
            // 
            // cbx_pythagoras_missing_length
            // 
            this.cbx_pythagoras_missing_length.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(238)))), ((int)(((byte)(230)))));
            this.cbx_pythagoras_missing_length.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbx_pythagoras_missing_length.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_pythagoras_missing_length.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cbx_pythagoras_missing_length.FormattingEnabled = true;
            this.cbx_pythagoras_missing_length.Items.AddRange(new object[] {
            "a",
            "b",
            "c"});
            this.cbx_pythagoras_missing_length.Location = new System.Drawing.Point(37, 120);
            this.cbx_pythagoras_missing_length.Name = "cbx_pythagoras_missing_length";
            this.cbx_pythagoras_missing_length.Size = new System.Drawing.Size(67, 27);
            this.cbx_pythagoras_missing_length.TabIndex = 36;
            this.cbx_pythagoras_missing_length.SelectedIndexChanged += new System.EventHandler(this.cbx_pythagoras_missing_length_SelectedIndexChanged);
            // 
            // tbx_length_a
            // 
            this.tbx_length_a.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(238)))), ((int)(((byte)(230)))));
            this.tbx_length_a.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_length_a.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_length_a.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tbx_length_a.Location = new System.Drawing.Point(247, 98);
            this.tbx_length_a.Multiline = true;
            this.tbx_length_a.Name = "tbx_length_a";
            this.tbx_length_a.Size = new System.Drawing.Size(78, 29);
            this.tbx_length_a.TabIndex = 37;
            this.tbx_length_a.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbx_length_a.TextChanged += new System.EventHandler(this.tbx_length_a_TextChanged);
            // 
            // lbl_missing_length_a
            // 
            this.lbl_missing_length_a.AutoSize = true;
            this.lbl_missing_length_a.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_missing_length_a.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_missing_length_a.Location = new System.Drawing.Point(180, 108);
            this.lbl_missing_length_a.Name = "lbl_missing_length_a";
            this.lbl_missing_length_a.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_missing_length_a.Size = new System.Drawing.Size(63, 19);
            this.lbl_missing_length_a.TabIndex = 38;
            this.lbl_missing_length_a.Text = "Länge A";
            this.lbl_missing_length_a.Click += new System.EventHandler(this.lbl_missing_length_a_Click);
            // 
            // lbl_missing_length_b
            // 
            this.lbl_missing_length_b.AutoSize = true;
            this.lbl_missing_length_b.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_missing_length_b.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_missing_length_b.Location = new System.Drawing.Point(180, 143);
            this.lbl_missing_length_b.Name = "lbl_missing_length_b";
            this.lbl_missing_length_b.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_missing_length_b.Size = new System.Drawing.Size(62, 19);
            this.lbl_missing_length_b.TabIndex = 39;
            this.lbl_missing_length_b.Text = "Länge B";
            this.lbl_missing_length_b.Click += new System.EventHandler(this.lbl_missing_length_b_Click);
            // 
            // tbx_length_b
            // 
            this.tbx_length_b.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(238)))), ((int)(((byte)(230)))));
            this.tbx_length_b.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_length_b.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_length_b.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tbx_length_b.Location = new System.Drawing.Point(248, 133);
            this.tbx_length_b.Multiline = true;
            this.tbx_length_b.Name = "tbx_length_b";
            this.tbx_length_b.Size = new System.Drawing.Size(78, 29);
            this.tbx_length_b.TabIndex = 40;
            this.tbx_length_b.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbx_length_b.TextChanged += new System.EventHandler(this.tbx_length_b_TextChanged);
            // 
            // tbx_length_c
            // 
            this.tbx_length_c.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(238)))), ((int)(((byte)(230)))));
            this.tbx_length_c.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_length_c.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_length_c.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tbx_length_c.Location = new System.Drawing.Point(248, 168);
            this.tbx_length_c.Multiline = true;
            this.tbx_length_c.Name = "tbx_length_c";
            this.tbx_length_c.Size = new System.Drawing.Size(78, 29);
            this.tbx_length_c.TabIndex = 41;
            this.tbx_length_c.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbx_length_c.TextChanged += new System.EventHandler(this.tbx_length_c_TextChanged);
            // 
            // lbl_missing_length_c
            // 
            this.lbl_missing_length_c.AutoSize = true;
            this.lbl_missing_length_c.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_missing_length_c.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_missing_length_c.Location = new System.Drawing.Point(180, 178);
            this.lbl_missing_length_c.Name = "lbl_missing_length_c";
            this.lbl_missing_length_c.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_missing_length_c.Size = new System.Drawing.Size(62, 19);
            this.lbl_missing_length_c.TabIndex = 42;
            this.lbl_missing_length_c.Text = "Länge C";
            this.lbl_missing_length_c.Click += new System.EventHandler(this.lbl_missing_length_c_Click);
            // 
            // lbl_result_titel
            // 
            this.lbl_result_titel.AutoSize = true;
            this.lbl_result_titel.BackColor = System.Drawing.Color.Transparent;
            this.lbl_result_titel.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_result_titel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_result_titel.Location = new System.Drawing.Point(377, 98);
            this.lbl_result_titel.Name = "lbl_result_titel";
            this.lbl_result_titel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_result_titel.Size = new System.Drawing.Size(111, 19);
            this.lbl_result_titel.TabIndex = 43;
            this.lbl_result_titel.Text = "fehlende Länge";
            this.lbl_result_titel.Click += new System.EventHandler(this.lbl_result_titel_Click);
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_result.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_result.Location = new System.Drawing.Point(377, 120);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_result.Size = new System.Drawing.Size(0, 19);
            this.lbl_result.TabIndex = 44;
            this.lbl_result.Click += new System.EventHandler(this.lbl_result_Click);
            // 
            // btn_Pythagoras_pythagoras_ausrechnen
            // 
            this.btn_Pythagoras_pythagoras_ausrechnen.FlatAppearance.BorderSize = 0;
            this.btn_Pythagoras_pythagoras_ausrechnen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Pythagoras_pythagoras_ausrechnen.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Pythagoras_pythagoras_ausrechnen.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Pythagoras_pythagoras_ausrechnen.Location = new System.Drawing.Point(12, 259);
            this.btn_Pythagoras_pythagoras_ausrechnen.Name = "btn_Pythagoras_pythagoras_ausrechnen";
            this.btn_Pythagoras_pythagoras_ausrechnen.Size = new System.Drawing.Size(182, 40);
            this.btn_Pythagoras_pythagoras_ausrechnen.TabIndex = 45;
            this.btn_Pythagoras_pythagoras_ausrechnen.Text = "Pythagoras ausrechnen";
            this.btn_Pythagoras_pythagoras_ausrechnen.UseVisualStyleBackColor = true;
            this.btn_Pythagoras_pythagoras_ausrechnen.Click += new System.EventHandler(this.btn_Pythagoras_pythagoras_ausrechnen_Click);
            // 
            // btn_Pythagoras_result_in_ans
            // 
            this.btn_Pythagoras_result_in_ans.FlatAppearance.BorderSize = 0;
            this.btn_Pythagoras_result_in_ans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Pythagoras_result_in_ans.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Pythagoras_result_in_ans.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Pythagoras_result_in_ans.Location = new System.Drawing.Point(318, 259);
            this.btn_Pythagoras_result_in_ans.Name = "btn_Pythagoras_result_in_ans";
            this.btn_Pythagoras_result_in_ans.Size = new System.Drawing.Size(204, 40);
            this.btn_Pythagoras_result_in_ans.TabIndex = 46;
            this.btn_Pythagoras_result_in_ans.Text = "Ergebnis in Ans speichern";
            this.btn_Pythagoras_result_in_ans.UseVisualStyleBackColor = true;
            this.btn_Pythagoras_result_in_ans.Click += new System.EventHandler(this.btn_Pythagoras_result_in_ans_Click);
            // 
            // Form_Pythagoras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(238)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(534, 311);
            this.Controls.Add(this.btn_Pythagoras_result_in_ans);
            this.Controls.Add(this.btn_Pythagoras_pythagoras_ausrechnen);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.lbl_result_titel);
            this.Controls.Add(this.lbl_missing_length_c);
            this.Controls.Add(this.tbx_length_c);
            this.Controls.Add(this.tbx_length_b);
            this.Controls.Add(this.lbl_missing_length_b);
            this.Controls.Add(this.lbl_missing_length_a);
            this.Controls.Add(this.tbx_length_a);
            this.Controls.Add(this.cbx_pythagoras_missing_length);
            this.Controls.Add(this.lbl_Pythagoras_titel);
            this.Controls.Add(this.lbl_pythagoras_missing_length);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Pythagoras";
            this.Text = "Pythagoras";
            this.Load += new System.EventHandler(this.Form_Pythagoras_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_pythagoras_missing_length;
        private System.Windows.Forms.Label lbl_Pythagoras_titel;
        private System.Windows.Forms.ComboBox cbx_pythagoras_missing_length;
        private System.Windows.Forms.TextBox tbx_length_a;
        private System.Windows.Forms.Label lbl_missing_length_a;
        private System.Windows.Forms.Label lbl_missing_length_b;
        private System.Windows.Forms.TextBox tbx_length_b;
        private System.Windows.Forms.TextBox tbx_length_c;
        private System.Windows.Forms.Label lbl_missing_length_c;
        private System.Windows.Forms.Label lbl_result_titel;
        private System.Windows.Forms.Label lbl_result;
        private System.Windows.Forms.Button btn_Pythagoras_pythagoras_ausrechnen;
        private System.Windows.Forms.Button btn_Pythagoras_result_in_ans;
    }
}