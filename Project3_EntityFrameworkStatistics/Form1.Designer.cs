namespace Project3_EntityFrameworkStatistics
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCategoryCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblProductCount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblCustomerCount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblOrderCount = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblProductTotalStock = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblProductCountByCategorySebzeAndStatusTrue = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblProductStockSmallerThen100 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lblTotalPriceByProductNameGazoz = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.lblProductCountByCategoryIsFruit = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.lblProductAvargePrice = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.lblLastProductName = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.lblOrderToyalPriceByCategoryIsMeyveByEf = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.lblOrderToyalPriceByCategoryIsMeyve = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.lblOrderCountFromTurkeyByEf = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.panel15 = new System.Windows.Forms.Panel();
            this.lblOrderCountFromTurkeyBySql = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.panel16 = new System.Windows.Forms.Panel();
            this.lblCountryDifferentCount = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.panel17 = new System.Windows.Forms.Panel();
            this.lblLastCustomerName = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.panel18 = new System.Windows.Forms.Panel();
            this.lblTotalPriceStockByCola = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.panel19 = new System.Windows.Forms.Panel();
            this.lblProductActiveCount = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.panel20 = new System.Windows.Forms.Panel();
            this.lblLastProductByLastCategoryName = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panel17.SuspendLayout();
            this.panel18.SuspendLayout();
            this.panel19.SuspendLayout();
            this.panel20.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(206)))), ((int)(((byte)(201)))));
            this.panel1.Controls.Add(this.lblCategoryCount);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(31, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(318, 111);
            this.panel1.TabIndex = 0;
            // 
            // lblCategoryCount
            // 
            this.lblCategoryCount.AutoSize = true;
            this.lblCategoryCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCategoryCount.Location = new System.Drawing.Point(73, 51);
            this.lblCategoryCount.Name = "lblCategoryCount";
            this.lblCategoryCount.Size = new System.Drawing.Size(70, 25);
            this.lblCategoryCount.TabIndex = 1;
            this.lblCategoryCount.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(34, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategori Sayısı";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(155)))), ((int)(((byte)(254)))));
            this.panel2.Controls.Add(this.lblProductCount);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(365, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(309, 111);
            this.panel2.TabIndex = 1;
            // 
            // lblProductCount
            // 
            this.lblProductCount.AutoSize = true;
            this.lblProductCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProductCount.Location = new System.Drawing.Point(73, 51);
            this.lblProductCount.Name = "lblProductCount";
            this.lblProductCount.Size = new System.Drawing.Size(70, 25);
            this.lblProductCount.TabIndex = 1;
            this.lblProductCount.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(54, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ürün Sayısı";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.panel3.Controls.Add(this.lblCustomerCount);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(699, 22);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(306, 111);
            this.panel3.TabIndex = 2;
            // 
            // lblCustomerCount
            // 
            this.lblCustomerCount.AutoSize = true;
            this.lblCustomerCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCustomerCount.Location = new System.Drawing.Point(91, 51);
            this.lblCustomerCount.Name = "lblCustomerCount";
            this.lblCustomerCount.Size = new System.Drawing.Size(70, 25);
            this.lblCustomerCount.TabIndex = 1;
            this.lblCustomerCount.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(91, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Müşteri Sayısı";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.panel4.Controls.Add(this.lblOrderCount);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Location = new System.Drawing.Point(1025, 22);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(288, 111);
            this.panel4.TabIndex = 3;
            // 
            // lblOrderCount
            // 
            this.lblOrderCount.AutoSize = true;
            this.lblOrderCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOrderCount.Location = new System.Drawing.Point(73, 51);
            this.lblOrderCount.Name = "lblOrderCount";
            this.lblOrderCount.Size = new System.Drawing.Size(70, 25);
            this.lblOrderCount.TabIndex = 1;
            this.lblOrderCount.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(73, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Sipariş Sayısı";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panel5.Controls.Add(this.lblProductTotalStock);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Location = new System.Drawing.Point(1336, 22);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(279, 111);
            this.panel5.TabIndex = 4;
            // 
            // lblProductTotalStock
            // 
            this.lblProductTotalStock.AutoSize = true;
            this.lblProductTotalStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProductTotalStock.ForeColor = System.Drawing.Color.White;
            this.lblProductTotalStock.Location = new System.Drawing.Point(85, 51);
            this.lblProductTotalStock.Name = "lblProductTotalStock";
            this.lblProductTotalStock.Size = new System.Drawing.Size(70, 25);
            this.lblProductTotalStock.TabIndex = 1;
            this.lblProductTotalStock.Text = "label9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(64, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(181, 25);
            this.label10.TabIndex = 0;
            this.label10.Text = "Toplam Stok Sayısı";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(220)))), ((int)(((byte)(88)))));
            this.panel6.Controls.Add(this.lblProductCountByCategorySebzeAndStatusTrue);
            this.panel6.Controls.Add(this.label12);
            this.panel6.Location = new System.Drawing.Point(1336, 149);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(279, 111);
            this.panel6.TabIndex = 9;
            // 
            // lblProductCountByCategorySebzeAndStatusTrue
            // 
            this.lblProductCountByCategorySebzeAndStatusTrue.AutoSize = true;
            this.lblProductCountByCategorySebzeAndStatusTrue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProductCountByCategorySebzeAndStatusTrue.Location = new System.Drawing.Point(73, 51);
            this.lblProductCountByCategorySebzeAndStatusTrue.Name = "lblProductCountByCategorySebzeAndStatusTrue";
            this.lblProductCountByCategorySebzeAndStatusTrue.Size = new System.Drawing.Size(82, 25);
            this.lblProductCountByCategorySebzeAndStatusTrue.TabIndex = 1;
            this.lblProductCountByCategorySebzeAndStatusTrue.Text = "label11";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(64, 11);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(169, 25);
            this.label12.TabIndex = 0;
            this.label12.Text = "Aktif Sebze Stoğu";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(52)))), ((int)(((byte)(212)))));
            this.panel7.Controls.Add(this.lblProductStockSmallerThen100);
            this.panel7.Controls.Add(this.label14);
            this.panel7.Location = new System.Drawing.Point(1025, 149);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(288, 111);
            this.panel7.TabIndex = 8;
            // 
            // lblProductStockSmallerThen100
            // 
            this.lblProductStockSmallerThen100.AutoSize = true;
            this.lblProductStockSmallerThen100.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProductStockSmallerThen100.ForeColor = System.Drawing.Color.White;
            this.lblProductStockSmallerThen100.Location = new System.Drawing.Point(73, 51);
            this.lblProductStockSmallerThen100.Name = "lblProductStockSmallerThen100";
            this.lblProductStockSmallerThen100.Size = new System.Drawing.Size(82, 25);
            this.lblProductStockSmallerThen100.TabIndex = 1;
            this.lblProductStockSmallerThen100.Text = "label13";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(17, 11);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(240, 20);
            this.label14.TabIndex = 0;
            this.label14.Text = "Stok Sayısı 100\'den Az Ürünler";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.panel8.Controls.Add(this.lblTotalPriceByProductNameGazoz);
            this.panel8.Controls.Add(this.label16);
            this.panel8.Location = new System.Drawing.Point(699, 149);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(308, 111);
            this.panel8.TabIndex = 7;
            // 
            // lblTotalPriceByProductNameGazoz
            // 
            this.lblTotalPriceByProductNameGazoz.AutoSize = true;
            this.lblTotalPriceByProductNameGazoz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalPriceByProductNameGazoz.Location = new System.Drawing.Point(73, 51);
            this.lblTotalPriceByProductNameGazoz.Name = "lblTotalPriceByProductNameGazoz";
            this.lblTotalPriceByProductNameGazoz.Size = new System.Drawing.Size(82, 25);
            this.lblTotalPriceByProductNameGazoz.TabIndex = 1;
            this.lblTotalPriceByProductNameGazoz.Text = "label15";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(33, 11);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(226, 22);
            this.label16.TabIndex = 0;
            this.label16.Text = "Gazoz Toplam İşlem Hacmi";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.panel9.Controls.Add(this.lblProductCountByCategoryIsFruit);
            this.panel9.Controls.Add(this.label18);
            this.panel9.Location = new System.Drawing.Point(365, 149);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(309, 111);
            this.panel9.TabIndex = 6;
            // 
            // lblProductCountByCategoryIsFruit
            // 
            this.lblProductCountByCategoryIsFruit.AutoSize = true;
            this.lblProductCountByCategoryIsFruit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProductCountByCategoryIsFruit.Location = new System.Drawing.Point(73, 51);
            this.lblProductCountByCategoryIsFruit.Name = "lblProductCountByCategoryIsFruit";
            this.lblProductCountByCategoryIsFruit.Size = new System.Drawing.Size(82, 25);
            this.lblProductCountByCategoryIsFruit.TabIndex = 1;
            this.lblProductCountByCategoryIsFruit.Text = "label17";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.Location = new System.Drawing.Point(14, 11);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(249, 31);
            this.label18.TabIndex = 0;
            this.label18.Text = "Toplam Meyve Stoğu";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.panel10.Controls.Add(this.lblProductAvargePrice);
            this.panel10.Controls.Add(this.label20);
            this.panel10.Location = new System.Drawing.Point(31, 149);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(318, 111);
            this.panel10.TabIndex = 5;
            // 
            // lblProductAvargePrice
            // 
            this.lblProductAvargePrice.AutoSize = true;
            this.lblProductAvargePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProductAvargePrice.Location = new System.Drawing.Point(51, 51);
            this.lblProductAvargePrice.Name = "lblProductAvargePrice";
            this.lblProductAvargePrice.Size = new System.Drawing.Size(82, 25);
            this.lblProductAvargePrice.TabIndex = 1;
            this.lblProductAvargePrice.Text = "label19";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label20.Location = new System.Drawing.Point(20, 11);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(190, 25);
            this.label20.TabIndex = 0;
            this.label20.Text = "Ortalama Ürün Fiyatı";
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.panel11.Controls.Add(this.lblLastProductName);
            this.panel11.Controls.Add(this.label22);
            this.panel11.Location = new System.Drawing.Point(1338, 276);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(279, 111);
            this.panel11.TabIndex = 14;
            // 
            // lblLastProductName
            // 
            this.lblLastProductName.AutoSize = true;
            this.lblLastProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLastProductName.Location = new System.Drawing.Point(73, 51);
            this.lblLastProductName.Name = "lblLastProductName";
            this.lblLastProductName.Size = new System.Drawing.Size(82, 25);
            this.lblLastProductName.TabIndex = 1;
            this.lblLastProductName.Text = "label21";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label22.Location = new System.Drawing.Point(62, 11);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(250, 31);
            this.label22.TabIndex = 0;
            this.label22.Text = "En Son Eklenen Ürün";
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.panel12.Controls.Add(this.lblOrderToyalPriceByCategoryIsMeyveByEf);
            this.panel12.Controls.Add(this.label24);
            this.panel12.Location = new System.Drawing.Point(1027, 276);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(288, 111);
            this.panel12.TabIndex = 13;
            // 
            // lblOrderToyalPriceByCategoryIsMeyveByEf
            // 
            this.lblOrderToyalPriceByCategoryIsMeyveByEf.AutoSize = true;
            this.lblOrderToyalPriceByCategoryIsMeyveByEf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOrderToyalPriceByCategoryIsMeyveByEf.Location = new System.Drawing.Point(73, 51);
            this.lblOrderToyalPriceByCategoryIsMeyveByEf.Name = "lblOrderToyalPriceByCategoryIsMeyveByEf";
            this.lblOrderToyalPriceByCategoryIsMeyveByEf.Size = new System.Drawing.Size(82, 25);
            this.lblOrderToyalPriceByCategoryIsMeyveByEf.TabIndex = 1;
            this.lblOrderToyalPriceByCategoryIsMeyveByEf.Text = "label23";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label24.Location = new System.Drawing.Point(14, 6);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(265, 25);
            this.label24.TabIndex = 0;
            this.label24.Text = "Meyve Satışları Kazancı (EF)";
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.panel13.Controls.Add(this.lblOrderToyalPriceByCategoryIsMeyve);
            this.panel13.Controls.Add(this.label26);
            this.panel13.Location = new System.Drawing.Point(701, 276);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(306, 111);
            this.panel13.TabIndex = 12;
            // 
            // lblOrderToyalPriceByCategoryIsMeyve
            // 
            this.lblOrderToyalPriceByCategoryIsMeyve.AutoSize = true;
            this.lblOrderToyalPriceByCategoryIsMeyve.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOrderToyalPriceByCategoryIsMeyve.Location = new System.Drawing.Point(73, 51);
            this.lblOrderToyalPriceByCategoryIsMeyve.Name = "lblOrderToyalPriceByCategoryIsMeyve";
            this.lblOrderToyalPriceByCategoryIsMeyve.Size = new System.Drawing.Size(82, 25);
            this.lblOrderToyalPriceByCategoryIsMeyve.TabIndex = 1;
            this.lblOrderToyalPriceByCategoryIsMeyve.Text = "label25";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label26.Location = new System.Drawing.Point(28, 6);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(221, 25);
            this.label26.TabIndex = 0;
            this.label26.Text = "Meyve Satışları Kazancı";
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.panel14.Controls.Add(this.lblOrderCountFromTurkeyByEf);
            this.panel14.Controls.Add(this.label28);
            this.panel14.Location = new System.Drawing.Point(367, 276);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(309, 111);
            this.panel14.TabIndex = 11;
            // 
            // lblOrderCountFromTurkeyByEf
            // 
            this.lblOrderCountFromTurkeyByEf.AutoSize = true;
            this.lblOrderCountFromTurkeyByEf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOrderCountFromTurkeyByEf.Location = new System.Drawing.Point(73, 51);
            this.lblOrderCountFromTurkeyByEf.Name = "lblOrderCountFromTurkeyByEf";
            this.lblOrderCountFromTurkeyByEf.Size = new System.Drawing.Size(82, 25);
            this.lblOrderCountFromTurkeyByEf.TabIndex = 1;
            this.lblOrderCountFromTurkeyByEf.Text = "label27";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label28.Location = new System.Drawing.Point(13, 4);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(263, 20);
            this.label28.TabIndex = 0;
            this.label28.Text = "Türkiyeden Yapılan Siparişler (EF)";
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(33)))), ((int)(((byte)(79)))));
            this.panel15.Controls.Add(this.lblOrderCountFromTurkeyBySql);
            this.panel15.Controls.Add(this.label30);
            this.panel15.Location = new System.Drawing.Point(33, 276);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(318, 111);
            this.panel15.TabIndex = 10;
            // 
            // lblOrderCountFromTurkeyBySql
            // 
            this.lblOrderCountFromTurkeyBySql.AutoSize = true;
            this.lblOrderCountFromTurkeyBySql.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOrderCountFromTurkeyBySql.ForeColor = System.Drawing.Color.White;
            this.lblOrderCountFromTurkeyBySql.Location = new System.Drawing.Point(73, 51);
            this.lblOrderCountFromTurkeyBySql.Name = "lblOrderCountFromTurkeyBySql";
            this.lblOrderCountFromTurkeyBySql.Size = new System.Drawing.Size(82, 25);
            this.lblOrderCountFromTurkeyBySql.TabIndex = 1;
            this.lblOrderCountFromTurkeyBySql.Text = "label29";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label30.ForeColor = System.Drawing.Color.White;
            this.label30.Location = new System.Drawing.Point(34, 11);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(240, 18);
            this.label30.TabIndex = 0;
            this.label30.Text = "Türkiyeden Yapılan Siparişler (SQL)";
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.panel16.Controls.Add(this.lblCountryDifferentCount);
            this.panel16.Controls.Add(this.label50);
            this.panel16.Location = new System.Drawing.Point(1338, 402);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(279, 111);
            this.panel16.TabIndex = 19;
            // 
            // lblCountryDifferentCount
            // 
            this.lblCountryDifferentCount.AutoSize = true;
            this.lblCountryDifferentCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCountryDifferentCount.Location = new System.Drawing.Point(73, 51);
            this.lblCountryDifferentCount.Name = "lblCountryDifferentCount";
            this.lblCountryDifferentCount.Size = new System.Drawing.Size(82, 25);
            this.lblCountryDifferentCount.TabIndex = 1;
            this.lblCountryDifferentCount.Text = "label31";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label50.Location = new System.Drawing.Point(62, 11);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(245, 31);
            this.label50.TabIndex = 0;
            this.label50.Text = "Ülke Çeşitliliği Sayısı:";
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(126)))));
            this.panel17.Controls.Add(this.lblLastCustomerName);
            this.panel17.Controls.Add(this.label34);
            this.panel17.Location = new System.Drawing.Point(1027, 402);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(288, 111);
            this.panel17.TabIndex = 18;
            // 
            // lblLastCustomerName
            // 
            this.lblLastCustomerName.AutoSize = true;
            this.lblLastCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLastCustomerName.Location = new System.Drawing.Point(73, 51);
            this.lblLastCustomerName.Name = "lblLastCustomerName";
            this.lblLastCustomerName.Size = new System.Drawing.Size(82, 25);
            this.lblLastCustomerName.TabIndex = 1;
            this.lblLastCustomerName.Text = "label33";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label34.Location = new System.Drawing.Point(23, 11);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(240, 25);
            this.label34.TabIndex = 0;
            this.label34.Text = "Son Sipariş Veren Müşteri";
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(0)))));
            this.panel18.Controls.Add(this.lblTotalPriceStockByCola);
            this.panel18.Controls.Add(this.label36);
            this.panel18.Location = new System.Drawing.Point(701, 402);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(306, 111);
            this.panel18.TabIndex = 17;
            // 
            // lblTotalPriceStockByCola
            // 
            this.lblTotalPriceStockByCola.AutoSize = true;
            this.lblTotalPriceStockByCola.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalPriceStockByCola.Location = new System.Drawing.Point(73, 51);
            this.lblTotalPriceStockByCola.Name = "lblTotalPriceStockByCola";
            this.lblTotalPriceStockByCola.Size = new System.Drawing.Size(82, 25);
            this.lblTotalPriceStockByCola.TabIndex = 1;
            this.lblTotalPriceStockByCola.Text = "label35";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label36.Location = new System.Drawing.Point(28, 11);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(250, 25);
            this.label36.TabIndex = 0;
            this.label36.Text = "Toplam Kola Kazanç Tutarı";
            // 
            // panel19
            // 
            this.panel19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(152)))), ((int)(((byte)(58)))));
            this.panel19.Controls.Add(this.lblProductActiveCount);
            this.panel19.Controls.Add(this.label38);
            this.panel19.Location = new System.Drawing.Point(367, 402);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(309, 111);
            this.panel19.TabIndex = 16;
            // 
            // lblProductActiveCount
            // 
            this.lblProductActiveCount.AutoSize = true;
            this.lblProductActiveCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProductActiveCount.Location = new System.Drawing.Point(73, 51);
            this.lblProductActiveCount.Name = "lblProductActiveCount";
            this.lblProductActiveCount.Size = new System.Drawing.Size(82, 25);
            this.lblProductActiveCount.TabIndex = 1;
            this.lblProductActiveCount.Text = "label37";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label38.Location = new System.Drawing.Point(52, 11);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(155, 25);
            this.label38.TabIndex = 0;
            this.label38.Text = "Aktif Ürün Sayısı";
            // 
            // panel20
            // 
            this.panel20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.panel20.Controls.Add(this.lblLastProductByLastCategoryName);
            this.panel20.Controls.Add(this.label40);
            this.panel20.Location = new System.Drawing.Point(33, 402);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(318, 111);
            this.panel20.TabIndex = 15;
            // 
            // lblLastProductByLastCategoryName
            // 
            this.lblLastProductByLastCategoryName.AutoSize = true;
            this.lblLastProductByLastCategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLastProductByLastCategoryName.ForeColor = System.Drawing.Color.White;
            this.lblLastProductByLastCategoryName.Location = new System.Drawing.Point(73, 51);
            this.lblLastProductByLastCategoryName.Name = "lblLastProductByLastCategoryName";
            this.lblLastProductByLastCategoryName.Size = new System.Drawing.Size(82, 25);
            this.lblLastProductByLastCategoryName.TabIndex = 1;
            this.lblLastProductByLastCategoryName.Text = "label39";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label40.ForeColor = System.Drawing.Color.White;
            this.label40.Location = new System.Drawing.Point(34, 11);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(329, 31);
            this.label40.TabIndex = 0;
            this.label40.Text = "Son Eklenen Ürün Kategorisi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1299, 419);
            this.Controls.Add(this.panel16);
            this.Controls.Add(this.panel17);
            this.Controls.Add(this.panel18);
            this.Controls.Add(this.panel19);
            this.Controls.Add(this.panel20);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.panel14);
            this.Controls.Add(this.panel15);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            this.panel18.ResumeLayout(false);
            this.panel18.PerformLayout();
            this.panel19.ResumeLayout(false);
            this.panel19.PerformLayout();
            this.panel20.ResumeLayout(false);
            this.panel20.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCategoryCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblProductCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblCustomerCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblOrderCount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblProductTotalStock;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblProductCountByCategorySebzeAndStatusTrue;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lblProductStockSmallerThen100;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lblTotalPriceByProductNameGazoz;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label lblProductCountByCategoryIsFruit;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label lblProductAvargePrice;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label lblLastProductName;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label lblOrderToyalPriceByCategoryIsMeyveByEf;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label lblOrderToyalPriceByCategoryIsMeyve;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label lblOrderCountFromTurkeyByEf;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Label lblOrderCountFromTurkeyBySql;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Label lblCountryDifferentCount;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Label lblLastCustomerName;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Label lblTotalPriceStockByCola;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Label lblProductActiveCount;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.Label lblLastProductByLastCategoryName;
        private System.Windows.Forms.Label label40;
    }
}

