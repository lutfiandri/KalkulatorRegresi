
namespace KalkulatorRegresi
{
    partial class Home
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_X = new System.Windows.Forms.TextBox();
            this.tb_Y = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.radio_Linear = new System.Windows.Forms.RadioButton();
            this.radio_Power = new System.Windows.Forms.RadioButton();
            this.radio_Exp = new System.Windows.Forms.RadioButton();
            this.radio_Poly1 = new System.Windows.Forms.RadioButton();
            this.radio_Poly2 = new System.Windows.Forms.RadioButton();
            this.radio_Poly3 = new System.Windows.Forms.RadioButton();
            this.btn_Hitung = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_Persamaan = new System.Windows.Forms.Label();
            this.label_Koef = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.label_LoggedInAs = new System.Windows.Forms.Label();
            this.btn_History = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(17, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kalkulator Regresi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Masukkan X:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Masukkan Y:";
            // 
            // tb_X
            // 
            this.tb_X.Location = new System.Drawing.Point(21, 77);
            this.tb_X.Multiline = true;
            this.tb_X.Name = "tb_X";
            this.tb_X.Size = new System.Drawing.Size(79, 258);
            this.tb_X.TabIndex = 3;
            // 
            // tb_Y
            // 
            this.tb_Y.Location = new System.Drawing.Point(114, 77);
            this.tb_Y.Multiline = true;
            this.tb_Y.Name = "tb_Y";
            this.tb_Y.Size = new System.Drawing.Size(79, 258);
            this.tb_Y.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(216, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Pilih Method:";
            // 
            // radio_Linear
            // 
            this.radio_Linear.AutoSize = true;
            this.radio_Linear.Checked = true;
            this.radio_Linear.Location = new System.Drawing.Point(219, 87);
            this.radio_Linear.Name = "radio_Linear";
            this.radio_Linear.Size = new System.Drawing.Size(171, 19);
            this.radio_Linear.TabIndex = 6;
            this.radio_Linear.TabStop = true;
            this.radio_Linear.Text = "Regresi Linier --- y = a + bx";
            this.radio_Linear.UseVisualStyleBackColor = true;
            // 
            // radio_Power
            // 
            this.radio_Power.AutoSize = true;
            this.radio_Power.Location = new System.Drawing.Point(219, 113);
            this.radio_Power.Name = "radio_Power";
            this.radio_Power.Size = new System.Drawing.Size(196, 19);
            this.radio_Power.TabIndex = 7;
            this.radio_Power.Text = "Regresi Berpangkat --- y = ax^b";
            this.radio_Power.UseVisualStyleBackColor = true;
            // 
            // radio_Exp
            // 
            this.radio_Exp.AutoSize = true;
            this.radio_Exp.Location = new System.Drawing.Point(219, 139);
            this.radio_Exp.Name = "radio_Exp";
            this.radio_Exp.Size = new System.Drawing.Size(222, 19);
            this.radio_Exp.TabIndex = 8;
            this.radio_Exp.Text = "Regresi Eksponensial --- y = ae^(bx)";
            this.radio_Exp.UseVisualStyleBackColor = true;
            // 
            // radio_Poly1
            // 
            this.radio_Poly1.AutoSize = true;
            this.radio_Poly1.Location = new System.Drawing.Point(219, 165);
            this.radio_Poly1.Name = "radio_Poly1";
            this.radio_Poly1.Size = new System.Drawing.Size(253, 19);
            this.radio_Poly1.TabIndex = 9;
            this.radio_Poly1.Text = "Regresi Polinomial Orde 1 --- y = a0 + a1x";
            this.radio_Poly1.UseVisualStyleBackColor = true;
            // 
            // radio_Poly2
            // 
            this.radio_Poly2.AutoSize = true;
            this.radio_Poly2.Location = new System.Drawing.Point(219, 191);
            this.radio_Poly2.Name = "radio_Poly2";
            this.radio_Poly2.Size = new System.Drawing.Size(299, 19);
            this.radio_Poly2.TabIndex = 10;
            this.radio_Poly2.Text = "Regresi Polinomial Orde 2 --- y = a0 + a1x + a2x^2";
            this.radio_Poly2.UseVisualStyleBackColor = true;
            // 
            // radio_Poly3
            // 
            this.radio_Poly3.AutoSize = true;
            this.radio_Poly3.Location = new System.Drawing.Point(219, 217);
            this.radio_Poly3.Name = "radio_Poly3";
            this.radio_Poly3.Size = new System.Drawing.Size(345, 19);
            this.radio_Poly3.TabIndex = 11;
            this.radio_Poly3.Text = "Regresi Polinomial Orde 3 --- y = a0 + a1x + a2x^2 + a3x^3";
            this.radio_Poly3.UseVisualStyleBackColor = true;
            // 
            // btn_Hitung
            // 
            this.btn_Hitung.Location = new System.Drawing.Point(219, 246);
            this.btn_Hitung.Name = "btn_Hitung";
            this.btn_Hitung.Size = new System.Drawing.Size(171, 33);
            this.btn_Hitung.TabIndex = 12;
            this.btn_Hitung.Text = "HITUNG";
            this.btn_Hitung.UseVisualStyleBackColor = true;
            this.btn_Hitung.Click += new System.EventHandler(this.btn_Hitung_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(216, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Persamaan Regresi    :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(216, 317);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Koefisien Determinasi :";
            // 
            // label_Persamaan
            // 
            this.label_Persamaan.AutoSize = true;
            this.label_Persamaan.Location = new System.Drawing.Point(359, 293);
            this.label_Persamaan.Name = "label_Persamaan";
            this.label_Persamaan.Size = new System.Drawing.Size(11, 15);
            this.label_Persamaan.TabIndex = 15;
            this.label_Persamaan.Text = "-";
            // 
            // label_Koef
            // 
            this.label_Koef.AutoSize = true;
            this.label_Koef.Location = new System.Drawing.Point(359, 317);
            this.label_Koef.Name = "label_Koef";
            this.label_Koef.Size = new System.Drawing.Size(11, 15);
            this.label_Koef.TabIndex = 16;
            this.label_Koef.Text = "-";
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(21, 341);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(172, 24);
            this.btn_Save.TabIndex = 17;
            this.btn_Save.Text = "Simpan Input X dan Y";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // label_LoggedInAs
            // 
            this.label_LoggedInAs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_LoggedInAs.Location = new System.Drawing.Point(442, 24);
            this.label_LoggedInAs.Name = "label_LoggedInAs";
            this.label_LoggedInAs.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_LoggedInAs.Size = new System.Drawing.Size(198, 15);
            this.label_LoggedInAs.TabIndex = 18;
            this.label_LoggedInAs.Text = "---";
            this.label_LoggedInAs.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btn_History
            // 
            this.btn_History.Location = new System.Drawing.Point(21, 371);
            this.btn_History.Name = "btn_History";
            this.btn_History.Size = new System.Drawing.Size(172, 23);
            this.btn_History.TabIndex = 19;
            this.btn_History.Text = "Riwayat Input";
            this.btn_History.UseVisualStyleBackColor = true;
            this.btn_History.Click += new System.EventHandler(this.btn_History_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 424);
            this.Controls.Add(this.btn_History);
            this.Controls.Add(this.label_LoggedInAs);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.label_Koef);
            this.Controls.Add(this.label_Persamaan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_Hitung);
            this.Controls.Add(this.radio_Poly3);
            this.Controls.Add(this.radio_Poly2);
            this.Controls.Add(this.radio_Poly1);
            this.Controls.Add(this.radio_Exp);
            this.Controls.Add(this.radio_Power);
            this.Controls.Add(this.radio_Linear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_Y);
            this.Controls.Add(this.tb_X);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.Name = "Home";
            this.Text = "Kalkulator Regresi";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_X;
        private System.Windows.Forms.TextBox tb_Y;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radio_Linear;
        private System.Windows.Forms.RadioButton radio_Power;
        private System.Windows.Forms.RadioButton radio_Exp;
        private System.Windows.Forms.RadioButton radio_Poly1;
        private System.Windows.Forms.RadioButton radio_Poly2;
        private System.Windows.Forms.RadioButton radio_Poly3;
        private System.Windows.Forms.Button btn_Hitung;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_Persamaan;
        private System.Windows.Forms.Label label_Koef;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label label_LoggedInAs;
        private System.Windows.Forms.Button btn_History;
    }
}

