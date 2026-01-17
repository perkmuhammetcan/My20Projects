namespace Project16_MailRegister
{
    partial class FrmMailConfirm
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
            this.txtEmailAdress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSixDigitCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCompleteActivation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEmailAdress
            // 
            this.txtEmailAdress.Location = new System.Drawing.Point(209, 63);
            this.txtEmailAdress.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtEmailAdress.Name = "txtEmailAdress";
            this.txtEmailAdress.Size = new System.Drawing.Size(273, 30);
            this.txtEmailAdress.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Email Adresi:";
            // 
            // txtSixDigitCode
            // 
            this.txtSixDigitCode.Location = new System.Drawing.Point(209, 112);
            this.txtSixDigitCode.Margin = new System.Windows.Forms.Padding(5);
            this.txtSixDigitCode.Name = "txtSixDigitCode";
            this.txtSixDigitCode.Size = new System.Drawing.Size(273, 30);
            this.txtSixDigitCode.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "6 Haneli Kod:";
            // 
            // btnCompleteActivation
            // 
            this.btnCompleteActivation.BackColor = System.Drawing.Color.Green;
            this.btnCompleteActivation.ForeColor = System.Drawing.Color.White;
            this.btnCompleteActivation.Location = new System.Drawing.Point(224, 162);
            this.btnCompleteActivation.Name = "btnCompleteActivation";
            this.btnCompleteActivation.Size = new System.Drawing.Size(243, 43);
            this.btnCompleteActivation.TabIndex = 6;
            this.btnCompleteActivation.Text = "Aktivasyonu Tamamla";
            this.btnCompleteActivation.UseVisualStyleBackColor = false;
            this.btnCompleteActivation.Click += new System.EventHandler(this.btnCompleteActivation_Click);
            // 
            // FrmMailConfirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(583, 265);
            this.Controls.Add(this.btnCompleteActivation);
            this.Controls.Add(this.txtSixDigitCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEmailAdress);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FrmMailConfirm";
            this.Text = "Mail Aktivasyon Formu";
            this.Load += new System.EventHandler(this.FrmMailConfirm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmailAdress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSixDigitCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCompleteActivation;
    }
}