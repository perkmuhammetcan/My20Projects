using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3_EntityFrameworkStatistics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Db3Project20Entities db = new Db3Project20Entities();
        private void Form1_Load(object sender, EventArgs e)
        {
            //Toplam Kategori Sayısı
            int categoryCount = db.TblCategory.Count();
            lblCategoryCount.Text = categoryCount.ToString();

            //Toplam Ürün sayısı
            int productCount = db.TblProduct.Count();
            lblProductCount.Text = productCount.ToString();

            //Toplam Müşteri Sayısı
            int customerCount = db.TblCustomer.Count();
            lblCustomerCount.Text = customerCount.ToString();

            // Toplam Sipariş Sayısı
            int orderCount = db.TblOrder.Count();
            lblOrderCount.Text = orderCount.ToString();

            //Toplam Stok Sayısı
            var totalProductStock = db.TblProduct.Sum(x=>x.ProductStok);
            lblProductTotalStock.Text = totalProductStock.ToString();

            //Ortalam Ürün Fiyatı
            var avarageProductPrice = db.TblProduct.Average(x => x.ProductPrice);
            lblProductAvargePrice.Text = avarageProductPrice.ToString() + " ₺";

            //Toplam Meyve Stok Sayısı
            var totalProductCountByCategoryIsFruit = db.TblProduct.Where(x => x.CategoryId ==1).Sum(y => y.ProductStok);
            lblProductCountByCategoryIsFruit.Text = totalProductCountByCategoryIsFruit.ToString();   

            //Gazoz isimli ürünün toplam işlem hacmi
            var totalPriceByProductNameIsGazozGetStock= db.TblProduct.Where(x=>x.ProductName =="Gazoz").Select(y=>y.ProductStok).FirstOrDefault();
            var totalPricedByProductNameIsGazozGetUnitPrice = db.TblProduct.Where(x=>x.ProductName=="Gazoz").Select(y =>y.ProductPrice).FirstOrDefault();
            var totalPriceByProductNameIsGazoz = totalPriceByProductNameIsGazozGetStock * totalPricedByProductNameIsGazozGetUnitPrice;
            lblTotalPriceByProductNameGazoz.Text = totalPriceByProductNameIsGazoz.ToString() + " ₺";

            //Stok Sayısıs 100'den Az olan Ürün Sayısı
            var productCountByStockCountSmallerThen100 = db.TblProduct.Where(x => x.ProductStok < 100).Count();
            lblProductStockSmallerThen100.Text = productCountByStockCountSmallerThen100.ToString();

            //Kategorisi sebze ve durumu aktif(true) olan ürün stok toplamı
            int id = db.TblCategory.Where(x =>x.CategoryName == "Sebze").Select(y=>y.CategoryId).FirstOrDefault();
            var productStockCountByCategoryNameIsSebzeAndStatusIsTrue = db.TblProduct.Where(x => x.CategoryId ==(db.TblCategory.Where(w => w.CategoryName == "Sebze").Select(y => y.CategoryId).FirstOrDefault() ) && x.ProductStatus == true).Sum(y=>y.ProductStok);
            lblProductCountByCategorySebzeAndStatusTrue.Text = productStockCountByCategoryNameIsSebzeAndStatusIsTrue.ToString();

            //Türkiye'den Yapılan Siparişler Sql Query
            var orderCountFromTurkiye = db.Database.SqlQuery<int>("Select count(*) from TblOrder where CustomerId In (Select CustomerId from TblCustomer where CustomerCountry='Türkiye')").FirstOrDefault();
            lblOrderCountFromTurkeyBySql.Text= orderCountFromTurkiye.ToString(); 

            //Türkiye'den Yapılan Siparişle Ef Metodu
            var turkishCustomerIds = db.TblCustomer.Where(x=>x.CustomerCountry=="Türkiye").Select(y=>y.CustomerId).ToList();
            var orderCountFromTurkiyeWithEf = db.TblOrder.Count(z => turkishCustomerIds.Contains(z.CustomerId.Value));
            lblOrderCountFromTurkeyByEf.Text = orderCountFromTurkiyeWithEf.ToString();

            
            //Siparişler İçinde Kategorisi Meyve Olan Ürünlerin Toplam Satış Fiyatı Sql
            var orderTotalPriceByCategoryIsMeyve = db.Database.SqlQuery<decimal>("Select Sum(o.TotoalPrice) from TblOrder o Join TblProduct p On o.ProductId=p.ProductId Join TblCategory c On p.CategoryId=c.CategoryId where c.CategoryName='Meyve'").FirstOrDefault();
            lblOrderToyalPriceByCategoryIsMeyve.Text = orderTotalPriceByCategoryIsMeyve.ToString() + "₺";


            ////Siparişler İçinde Kategorisi Meyve Olan Ürünlerin Toplam Satış Fiyatı EF Metodu
            var orderTotalPriceByCategoryIsMeyveWithEf = (from o in db.TblOrder join p in db.TblProduct on o.ProductId equals p.ProductId join c in db.TblCategory on p.CategoryId equals c.CategoryId where c.CategoryName == "Meyve" select o.TotoalPrice).Sum();
            lblOrderToyalPriceByCategoryIsMeyveByEf.Text = orderTotalPriceByCategoryIsMeyveWithEf.ToString() + "₺";

            //  Son Eklenen Ürünün Adı
            var lastProductName = db.TblProduct.OrderByDescending(x => x.ProductId).Select(y=>y.ProductName).FirstOrDefault();
            lblLastProductName.Text = lastProductName.ToString();

            //  Son Eklenen Ürünün Kategori Adı
            var lastProductCategoryId = db.TblProduct.OrderByDescending(x => x.ProductId).Select(y => y.CategoryId).FirstOrDefault();
            var lastProductCategoryName = db.TblCategory.Where(x=>x.CategoryId==lastProductCategoryId).Select(y =>y.CategoryName).FirstOrDefault();
            lblLastProductByLastCategoryName.Text = lastProductCategoryName.ToString();

            //Aktif Ürün Sayısı
            var activeProductCount = db.TblProduct.Where(x => x.ProductStatus == true).Count();
            lblProductActiveCount.Text = activeProductCount.ToString();

            //Toplam Kola Stok Satışlarından Kazanılan Para
            var colaStock = db.TblProduct.Where(x => x.ProductName == "Kola").Select(y=>y.ProductStok).FirstOrDefault();
            var colaPrice = db.TblProduct.Where(x=>x.ProductName=="Kola").Select(y =>y.ProductPrice).FirstOrDefault();
            var totalColaStockPRİCE = colaStock * colaPrice;
            lblTotalPriceStockByCola.Text = totalColaStockPRİCE.ToString() + "₺";

            //Sisteme Son Eklenen Müşteri Adı
            var lastCustomerId = db.TblOrder.OrderByDescending(x => x.OrderId).Select(y => y.CustomerId).FirstOrDefault();
            var lastCustomerName = db.TblCustomer.Where(x=>x.CustomerId == lastCustomerId).Select(y =>y.CustomerName).FirstOrDefault();
            lblLastCustomerName.Text = lastCustomerName.ToString();

            //lblCountryDifferentCount
            //Ülke Çeşitliliği Sayısı
            var countryDifferentCount  = db.TblCustomer.Select(x=> x.CustomerCountry).Distinct().Count();
            lblCountryDifferentCount.Text = countryDifferentCount.ToString();
        }
    }
}
