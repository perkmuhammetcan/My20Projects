using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project10_PostgreSqlToDoListApp
{
    public partial class FrmToDoListApp : Form
    {
        public FrmToDoListApp()
        {
            InitializeComponent();
        }
        string connectionString = "Server=localhost;port=5432;Database=DbProject10ToDoApp;User Id=postgres;Password=123456";
        private void FrmToDoListApp_Load(object sender, EventArgs e)
        {
            try
            {
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    // Tablo adının veritabanındakiyle birebir aynı olduğundan emin ol
                    string query = "SELECT * FROM mytable1";

                    var command = new NpgsqlCommand(query, connection);
                    var adapter = new NpgsqlDataAdapter(command);
                    DataSet dataSet = new DataSet();

                    adapter.Fill(dataSet);

                    // Verinin geldiğinden emin olmak için kontrol:
                    if (dataSet.Tables.Count > 0 && dataSet.Tables[0].Rows.Count > 0)
                    {
                        dataGridView1.DataSource = dataSet.Tables[0];
                    }
                    else
                    {
                        MessageBox.Show("Bağlantı başarılı fakat tabloda veri bulunamadı.");
                    }
                } // connection.Close() kullanmana gerek yok, 'using' otomatik kapatır.
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }

        }
    }
}
