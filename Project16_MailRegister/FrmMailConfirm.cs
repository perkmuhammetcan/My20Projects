using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project16_MailRegister
{
    public partial class FrmMailConfirm : Form
    {
        public FrmMailConfirm()
        {
            InitializeComponent();
        }
        Db16Project20Entities context = new Db16Project20Entities();
        public string email;
        private void btnCompleteActivation_Click(object sender, EventArgs e)
        {
            
            var value = context.TblUser.Where(x=>x.Email == txtEmailAdress.Text ).Select(y =>y.ConfrimCode).FirstOrDefault();
            if(txtSixDigitCode.Text == value.ToString())
            {
                
                var value2 = context.TblUser.Where(x=>x.Email==txtEmailAdress.Text).FirstOrDefault();
                value2.IsConfrim = true;
                context.SaveChanges();
                MessageBox.Show("Hesabınız Aktif Edildi");

            }
            else
            {
                MessageBox.Show("Hatalı Kod");
            }
        }

        private void FrmMailConfirm_Load(object sender, EventArgs e)
        {
            txtEmailAdress.Text = email;
        }
    }
}
