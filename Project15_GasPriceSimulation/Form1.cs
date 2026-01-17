using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project15_GasPriceSimulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double dieselPrice = 54.69;
        double gasolinePrice = 53.83;
        double lpgPrice = 28.69;
        double gasAmount=0;
        double dieselAmount =0;
        double lpgAmount = 0;
        double progressBarValue = 0;
        double totalPrice = 0;
        int count = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            gasAmount = Convert.ToDouble(txtGasAmount.Text);
            dieselAmount = Convert.ToDouble(txtGasAmount.Text);
            timer1.Start();
            timer1.Interval = 100;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            this.Text = count.ToString();
            if (rdbGasolina.Checked)
            {
                count++;
                if(count <= gasAmount)
                {
                    totalPrice += gasolinePrice;
                    txtTotalPrice.Text = totalPrice.ToString() + " ₺";
                }
                else
                {
                    txtTotalPrice.Text = totalPrice.ToString() + " ₺";
                }
                
                progressBar1.Value += 1;
                if (progressBar1.Value == 99)
                {
                    timer1.Stop();
                }
            }
            if (rdbDiesel.Checked)
            {
                count++;
                if (count <= dieselAmount)
                {
                    totalPrice += dieselPrice;
                    txtTotalPrice.Text = totalPrice.ToString() + " ₺";
                }
                else
                {
                    txtTotalPrice.Text = totalPrice.ToString() + " ₺";
                }

                progressBar1.Value += 1;
                if (progressBar1.Value == 99)
                {
                    timer1.Stop();
                }
            }
            if (rdbLpg.Checked)
            {
                count++;
                if (count <= lpgAmount)
                {
                    totalPrice += lpgPrice;
                    txtTotalPrice.Text = totalPrice.ToString() + " ₺";
                }
                else
                {
                    txtTotalPrice.Text = totalPrice.ToString() + " ₺";
                }

                progressBar1.Value += 1;
                if (progressBar1.Value == 99)
                {
                    timer1.Stop();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

            txtDieselPrice.Text = dieselPrice.ToString() + "₺";
            txtGasolinePrice.Text = gasolinePrice.ToString() + "₺";
            txtLpg.Text = lpgPrice.ToString() + "₺";
        }
    }
}
