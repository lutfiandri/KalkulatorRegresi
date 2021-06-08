
namespace KalkulatorRegresi
{
    partial class History
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
            this.listBox_Histories = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Select = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox_Histories
            // 
            this.listBox_Histories.FormattingEnabled = true;
            this.listBox_Histories.Location = new System.Drawing.Point(44, 61);
            this.listBox_Histories.Name = "listBox_Histories";
            this.listBox_Histories.Size = new System.Drawing.Size(763, 329);
            this.listBox_Histories.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(40, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Riwayat Input";
            // 
            // btn_Select
            // 
            this.btn_Select.Location = new System.Drawing.Point(44, 397);
            this.btn_Select.Name = "btn_Select";
            this.btn_Select.Size = new System.Drawing.Size(165, 36);
            this.btn_Select.TabIndex = 2;
            this.btn_Select.Text = "Pilih";
            this.btn_Select.UseVisualStyleBackColor = true;
            this.btn_Select.Click += new System.EventHandler(this.btn_Select_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(642, 396);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(165, 36);
            this.btn_Delete.TabIndex = 4;
            this.btn_Delete.Text = "Hapus";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 478);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Select);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox_Histories);
            this.Name = "History";
            this.Text = "Riwayat";
            this.Load += new System.EventHandler(this.History_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Histories;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Select;
        private System.Windows.Forms.Button btn_Delete;
    }
}