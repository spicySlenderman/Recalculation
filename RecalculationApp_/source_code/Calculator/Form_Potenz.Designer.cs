namespace Calculator
{
    partial class Form_Potenz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Potenz));
            this.lbl_potenz_titel = new System.Windows.Forms.Label();
            this.tbx_potenz_basis = new System.Windows.Forms.TextBox();
            this.lbl_potenz_basis_titel = new System.Windows.Forms.Label();
            this.lbl_potenz_exponent_titel = new System.Windows.Forms.Label();
            this.cbx_potenz_expo = new System.Windows.Forms.ComboBox();
            this.lbl_potenz_result_titel = new System.Windows.Forms.Label();
            this.lbl_potenz_result = new System.Windows.Forms.Label();
            this.btn_Potenz_potenz_ausrechnen = new System.Windows.Forms.Button();
            this.btn_result_in_ans = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_potenz_titel
            // 
            this.lbl_potenz_titel.AutoSize = true;
            this.lbl_potenz_titel.BackColor = System.Drawing.Color.Transparent;
            this.lbl_potenz_titel.Font = new System.Drawing.Font("Microsoft Tai Le", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_potenz_titel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_potenz_titel.Location = new System.Drawing.Point(148, 9);
            this.lbl_potenz_titel.Name = "lbl_potenz_titel";
            this.lbl_potenz_titel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_potenz_titel.Size = new System.Drawing.Size(104, 37);
            this.lbl_potenz_titel.TabIndex = 1;
            this.lbl_potenz_titel.Text = "Potenz";
            // 
            // tbx_potenz_basis
            // 
            this.tbx_potenz_basis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(238)))), ((int)(((byte)(230)))));
            this.tbx_potenz_basis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_potenz_basis.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_potenz_basis.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tbx_potenz_basis.Location = new System.Drawing.Point(12, 120);
            this.tbx_potenz_basis.Multiline = true;
            this.tbx_potenz_basis.Name = "tbx_potenz_basis";
            this.tbx_potenz_basis.Size = new System.Drawing.Size(78, 29);
            this.tbx_potenz_basis.TabIndex = 23;
            this.tbx_potenz_basis.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbx_potenz_basis.TextChanged += new System.EventHandler(this.tbx_potenz_basis_TextChanged);
            // 
            // lbl_potenz_basis_titel
            // 
            this.lbl_potenz_basis_titel.AutoSize = true;
            this.lbl_potenz_basis_titel.BackColor = System.Drawing.Color.Transparent;
            this.lbl_potenz_basis_titel.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_potenz_basis_titel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_potenz_basis_titel.Location = new System.Drawing.Point(48, 98);
            this.lbl_potenz_basis_titel.Name = "lbl_potenz_basis_titel";
            this.lbl_potenz_basis_titel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_potenz_basis_titel.Size = new System.Drawing.Size(42, 19);
            this.lbl_potenz_basis_titel.TabIndex = 24;
            this.lbl_potenz_basis_titel.Text = "Basis";
            // 
            // lbl_potenz_exponent_titel
            // 
            this.lbl_potenz_exponent_titel.AutoSize = true;
            this.lbl_potenz_exponent_titel.BackColor = System.Drawing.Color.Transparent;
            this.lbl_potenz_exponent_titel.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_potenz_exponent_titel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_potenz_exponent_titel.Location = new System.Drawing.Point(135, 98);
            this.lbl_potenz_exponent_titel.Name = "lbl_potenz_exponent_titel";
            this.lbl_potenz_exponent_titel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_potenz_exponent_titel.Size = new System.Drawing.Size(71, 19);
            this.lbl_potenz_exponent_titel.TabIndex = 25;
            this.lbl_potenz_exponent_titel.Text = "Exponent";
            // 
            // cbx_potenz_expo
            // 
            this.cbx_potenz_expo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(238)))), ((int)(((byte)(230)))));
            this.cbx_potenz_expo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbx_potenz_expo.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_potenz_expo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cbx_potenz_expo.FormattingEnabled = true;
            this.cbx_potenz_expo.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.cbx_potenz_expo.Location = new System.Drawing.Point(139, 120);
            this.cbx_potenz_expo.Name = "cbx_potenz_expo";
            this.cbx_potenz_expo.Size = new System.Drawing.Size(67, 27);
            this.cbx_potenz_expo.TabIndex = 28;
            this.cbx_potenz_expo.SelectedIndexChanged += new System.EventHandler(this.cbx_potenz_expo_SelectedIndexChanged);
            // 
            // lbl_potenz_result_titel
            // 
            this.lbl_potenz_result_titel.AutoSize = true;
            this.lbl_potenz_result_titel.BackColor = System.Drawing.Color.Transparent;
            this.lbl_potenz_result_titel.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_potenz_result_titel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_potenz_result_titel.Location = new System.Drawing.Point(254, 98);
            this.lbl_potenz_result_titel.Name = "lbl_potenz_result_titel";
            this.lbl_potenz_result_titel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_potenz_result_titel.Size = new System.Drawing.Size(66, 19);
            this.lbl_potenz_result_titel.TabIndex = 29;
            this.lbl_potenz_result_titel.Text = "Ergebnis";
            // 
            // lbl_potenz_result
            // 
            this.lbl_potenz_result.AutoSize = true;
            this.lbl_potenz_result.BackColor = System.Drawing.Color.Transparent;
            this.lbl_potenz_result.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_potenz_result.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_potenz_result.Location = new System.Drawing.Point(254, 130);
            this.lbl_potenz_result.Name = "lbl_potenz_result";
            this.lbl_potenz_result.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_potenz_result.Size = new System.Drawing.Size(0, 19);
            this.lbl_potenz_result.TabIndex = 30;
            // 
            // btn_Potenz_potenz_ausrechnen
            // 
            this.btn_Potenz_potenz_ausrechnen.FlatAppearance.BorderSize = 0;
            this.btn_Potenz_potenz_ausrechnen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Potenz_potenz_ausrechnen.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Potenz_potenz_ausrechnen.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Potenz_potenz_ausrechnen.Location = new System.Drawing.Point(12, 209);
            this.btn_Potenz_potenz_ausrechnen.Name = "btn_Potenz_potenz_ausrechnen";
            this.btn_Potenz_potenz_ausrechnen.Size = new System.Drawing.Size(150, 40);
            this.btn_Potenz_potenz_ausrechnen.TabIndex = 31;
            this.btn_Potenz_potenz_ausrechnen.Text = "Potenz ausrechnen";
            this.btn_Potenz_potenz_ausrechnen.UseVisualStyleBackColor = false;
            this.btn_Potenz_potenz_ausrechnen.Click += new System.EventHandler(this.btn_Potenz_potenz_ausrechnen_Click);
            // 
            // btn_result_in_ans
            // 
            this.btn_result_in_ans.FlatAppearance.BorderSize = 0;
            this.btn_result_in_ans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_result_in_ans.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_result_in_ans.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_result_in_ans.Location = new System.Drawing.Point(168, 209);
            this.btn_result_in_ans.Name = "btn_result_in_ans";
            this.btn_result_in_ans.Size = new System.Drawing.Size(204, 40);
            this.btn_result_in_ans.TabIndex = 32;
            this.btn_result_in_ans.Text = "Ergebnis in Ans speichern";
            this.btn_result_in_ans.UseVisualStyleBackColor = true;
            this.btn_result_in_ans.Click += new System.EventHandler(this.btn_result_in_ans_Click);
            // 
            // Form_Potenz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(238)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.btn_result_in_ans);
            this.Controls.Add(this.btn_Potenz_potenz_ausrechnen);
            this.Controls.Add(this.lbl_potenz_result);
            this.Controls.Add(this.lbl_potenz_result_titel);
            this.Controls.Add(this.cbx_potenz_expo);
            this.Controls.Add(this.lbl_potenz_exponent_titel);
            this.Controls.Add(this.lbl_potenz_basis_titel);
            this.Controls.Add(this.tbx_potenz_basis);
            this.Controls.Add(this.lbl_potenz_titel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Potenz";
            this.Text = "Potenz";
            this.Load += new System.EventHandler(this.Potenz_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_potenz_titel;
        private System.Windows.Forms.TextBox tbx_potenz_basis;
        private System.Windows.Forms.Label lbl_potenz_basis_titel;
        private System.Windows.Forms.Label lbl_potenz_exponent_titel;
        private System.Windows.Forms.ComboBox cbx_potenz_expo;
        private System.Windows.Forms.Label lbl_potenz_result_titel;
        private System.Windows.Forms.Label lbl_potenz_result;
        private System.Windows.Forms.Button btn_Potenz_potenz_ausrechnen;
        private System.Windows.Forms.Button btn_result_in_ans;
    }
}