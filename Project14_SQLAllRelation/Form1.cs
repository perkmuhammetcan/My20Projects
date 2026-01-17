using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project14_SQLAllRelation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'db14Project20DataSet3.Sponsors' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.sponsorsTableAdapter.Fill(this.db14Project20DataSet3.Sponsors);
            // TODO: Bu kod satırı 'db14Project20DataSet2.TblPlayers' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tblPlayersTableAdapter.Fill(this.db14Project20DataSet2.TblPlayers);
            // TODO: Bu kod satırı 'db14Project20DataSet1.TblDetails' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tblDetailsTableAdapter.Fill(this.db14Project20DataSet1.TblDetails);
            // TODO: Bu kod satırı 'db14Project20DataSet.TblTeams' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tblTeamsTableAdapter.Fill(this.db14Project20DataSet.TblTeams);

        }
    }
}
