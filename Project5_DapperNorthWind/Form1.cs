using Dapper;
using Project5_DapperNorthWind.Dtos.CategoryDtos;
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

namespace Project5_DapperNorthWind
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=Lenovo\\SQLEXPRESS02;Initial Catalog=Northwind;Integrated Security=True;");

        private async void btnCategoryList_Click(object sender, EventArgs e)
        {
            string query = "Select * From Categories";
            var values = await connection.QueryAsync<ResultCategoryDtos>(query);
            dataGridView1.DataSource = values;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string query = "insert into Categories(CategoryName,Description) values (@p1,@p2)";
            var parameters = new DynamicParameters();
            parameters.Add("@p1", txtCategoryId.Text);
            parameters.Add("@p2", txtCategoryName.Text);
            await connection.ExecuteAsync(query,parameters);
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            //Kategori Sayısı
            string query = "Select Count(*) from Categories";
            var count = await connection.ExecuteScalarAsync<int>(query);
            lblCategoryCount.Text = "Toplam Kategori Sayısı: " + count;

            //Ürün Sayısı
            string query2 = "Select Count(*) from Products";
            var productCount = await connection.ExecuteScalarAsync<int>(query2);
            lblProductCount.Text = "Toplam ürün sayısı: " + productCount;

            //Ortalama Ürün Stok Sayısı
            string query3 = "Select Avg(UnitsInStock) from Products";
            var avgProductStock = await connection.ExecuteScalarAsync<int>(query3);
            lblAvgProductStock.Text = "Ortalama Ürün Sayısı: " + avgProductStock;

            //Deniz Ürünleri Toplam Fiyatı
            string query4 = "Select Sum(UnitPrice) from products where CategoryId=(Select CategoryId from Categories where CategoryName='SeaFood')";
            var totalSeaFoodPrice = await connection.ExecuteScalarAsync<decimal>(query4);
            lblSeaFootProductTotalPrice.Text= "Deniz Ürünleri Toplam Fiyatı:" + totalSeaFoodPrice;
        }

        private async void btnCategoryUpdate_Click(object sender, EventArgs e)
        {
            string query = "Update Categories Set CategoryName=@categoryName ,Description=@description where CategoryId=@categoryId";
            var parameters = new DynamicParameters();
            parameters.Add("@categoryName",txtCategoryName.Text);
            parameters.Add("@description",txtCategoryDescription.Text);
            parameters.Add("@categoryId",txtCategoryId.Text);
            await connection.ExecuteAsync(query,parameters);
        }

        private async void btnCategoryDelete_Click(object sender, EventArgs e)
        {
            string query = "Delete from Categories where CategoryId=@categoryId";
            var parameters = new DynamicParameters();
            parameters.Add("@categoryId", txtCategoryId.Text);
            await connection.ExecuteAsync(query, parameters);
        }
    } 
}
