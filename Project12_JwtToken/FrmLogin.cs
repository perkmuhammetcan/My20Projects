using Project12_JwtToken.JWT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project12_JwtToken
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        
        SqlConnection connection = new SqlConnection("Data Source=Lenovo\\SQLEXPRESS02;Initial Catalog=Db12Project20;Integrated Security=True;");
        private void btnLogin_Click(object sender, EventArgs e)
        {
            TokenGenerator tokenGenarator = new TokenGenerator();
            connection.Open();
            SqlCommand command = new SqlCommand("Select * from TblUser where UserName=@username and Password=@password",connection);
            command.Parameters.AddWithValue("@username",txtUserName.Text);
            command.Parameters.AddWithValue("@password", txtPassword.Text);
            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
                string token = tokenGenarator.GenerateJwtToken2(txtUserName.Text);
                //MessageBox.Show(token);
                FrmEmployee frm = new FrmEmployee();
                frm.tokenGet = token;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Bilgileri");
                txtPassword.Clear();
                txtUserName.Clear();
                txtUserName.Focus();
            }
            connection.Close();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
