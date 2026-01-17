using Project12_JwtToken.JWT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project12_JwtToken
{
    public partial class FrmEmployee : Form
    {
        public FrmEmployee()
        {
            InitializeComponent();
        }
        public string tokenGet;
        SqlConnection connection = new SqlConnection("Data Source=Lenovo\\SQLEXPRESS02;Initial Catalog=Db12Project20;Integrated Security=True;");
        private void FrmEmployee_Load(object sender, EventArgs e)
        {
            TokenValidator tokenValidator = new TokenValidator();   
            richTextBox1.Text = tokenGet;
            var pricipal = tokenValidator.ValidateJwtToken(tokenGet);

            if (pricipal != null)
            {
                string userrname = pricipal.FindFirst(JwtRegisteredClaimNames.Sub).Value;
                MessageBox.Show("Hoş Geldiniz: " + userrname);

                connection.Open();
                SqlCommand sqlCommand = new SqlCommand("Select * from TblEmployee", connection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                dataGridView1.DataSource = dt;
                connection.Close();
            }
            else
            {
                MessageBox.Show("Geçersiz Token!");
            }
           
        }
    }
}
