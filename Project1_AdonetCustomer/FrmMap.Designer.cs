namespace Project1_AdonetCustomer
{
    partial class FrmMap
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
            this.btnOpenCityDorm = new System.Windows.Forms.Button();
            this.btnOpenCustomerForm = new System.Windows.Forms.Button();
            this.btnApllication = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenCityDorm
            // 
            this.btnOpenCityDorm.Location = new System.Drawing.Point(55, 16);
            this.btnOpenCityDorm.Name = "btnOpenCityDorm";
            this.btnOpenCityDorm.Size = new System.Drawing.Size(169, 82);
            this.btnOpenCityDorm.TabIndex = 0;
            this.btnOpenCityDorm.Text = "Şehir İşlemleri";
            this.btnOpenCityDorm.UseVisualStyleBackColor = true;
            this.btnOpenCityDorm.Click += new System.EventHandler(this.l_Click);
            // 
            // btnOpenCustomerForm
            // 
            this.btnOpenCustomerForm.Location = new System.Drawing.Point(55, 116);
            this.btnOpenCustomerForm.Name = "btnOpenCustomerForm";
            this.btnOpenCustomerForm.Size = new System.Drawing.Size(169, 82);
            this.btnOpenCustomerForm.TabIndex = 1;
            this.btnOpenCustomerForm.Text = "Müşteri  İşlemleri";
            this.btnOpenCustomerForm.UseVisualStyleBackColor = true;
            this.btnOpenCustomerForm.Click += new System.EventHandler(this.btnOpenCustomerForm_Click);
            // 
            // btnApllication
            // 
            this.btnApllication.Location = new System.Drawing.Point(55, 216);
            this.btnApllication.Name = "btnApllication";
            this.btnApllication.Size = new System.Drawing.Size(169, 82);
            this.btnApllication.TabIndex = 2;
            this.btnApllication.Text = "Çıkış";
            this.btnApllication.UseVisualStyleBackColor = true;
            // 
            // FrmMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 317);
            this.Controls.Add(this.btnApllication);
            this.Controls.Add(this.btnOpenCustomerForm);
            this.Controls.Add(this.btnOpenCityDorm);
            this.Name = "FrmMap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formlar";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenCityDorm;
        private System.Windows.Forms.Button btnOpenCustomerForm;
        private System.Windows.Forms.Button btnApllication;
    }
}