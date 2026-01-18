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

namespace Projecr18_DashBoardSuperStoreDataSet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection = new SqlConnection("Data Source=Lenovo\\SQLEXPRESS02;Initial Catalog=Db17Project20;Integrated Security=True;");
        private void Form1_Load(object sender, EventArgs e)
        {
            #region widgets
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("Select count(*) From superstore",sqlConnection);
            SqlDataReader dr  = command.ExecuteReader();
            while (dr.Read())
            {
                lblProductCount.Text = dr[0].ToString();
            }
            sqlConnection.Close();

            sqlConnection.Open();
            SqlCommand command2 = new SqlCommand("Select count(distinct (state)) From superstore", sqlConnection);
            SqlDataReader dr2 = command2.ExecuteReader();
            while (dr2.Read())
            {
                lblCityCount.Text = dr2[0].ToString();
            }
            sqlConnection.Close();

            sqlConnection.Open();
            SqlCommand command3 = new SqlCommand("Select Count(*) From superstore where Country='Turkey'", sqlConnection);
            SqlDataReader dr3 = command3.ExecuteReader();
            while (dr3.Read())
            {
                lblOrderCountByTurkey.Text = dr3[0].ToString();
            }
            sqlConnection.Close();

            sqlConnection.Open();
            SqlCommand command4 = new SqlCommand("Select Sum(Quantity) From superstore", sqlConnection);
            SqlDataReader dr4 = command4.ExecuteReader();
            while (dr4.Read())
            {
                lblOrderCount.Text = dr4[0].ToString();
            }
            sqlConnection.Close();
            #endregion

            #region charts
            sqlConnection.Open();
            SqlCommand command5 = new SqlCommand("Select top(7) Country , COUNT(*) fROM superstore Group by Country order by Count(*) desc", sqlConnection);
            SqlDataReader dr5 = command5.ExecuteReader();
            while (dr5.Read())
            {
                chart1.Series["Series1"].Points.AddXY(dr5[0], dr5[1]);
            }
            sqlConnection.Close();

            sqlConnection.Open();
            SqlCommand command6 = new SqlCommand("Select top(3) Country , sum(Quantity) fROM superstore Group by Country order by sum(Quantity) desc", sqlConnection);
            SqlDataReader dr6 = command6.ExecuteReader();
            while (dr6.Read())
            {
                chart2.Series["Series1"].Points.AddXY(dr6[0], dr6[1]);
            }
            sqlConnection.Close();

            sqlConnection.Open();
            SqlCommand command7 = new SqlCommand("Select Order_Priority, Count(*) fROM superstore Group by Order_Priority order by  Order_Priority desc", sqlConnection);
            SqlDataReader dr7 = command7.ExecuteReader();
            while (dr7.Read())
            {
                chart3.Series["Series1"].Points.AddXY(dr7[0], dr7[1]);
            }
            sqlConnection.Close();


            #endregion
        }
    }
}
