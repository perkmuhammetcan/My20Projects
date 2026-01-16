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
using System.Xml.Linq;

namespace Project10_PostgreSqlToDoListApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string connectionString = "Server=localhost;port=5432;Database=DbProject10ToDoApp;User Id=postgres;Password=123456";

        void todolist()
        {
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            // Tablo adının veritabanındakiyle birebir aynı olduğundan emin ol
            string query = "SELECT * FROM todolists";
            var command = new NpgsqlCommand(query, connection);
            var adapter = new NpgsqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            connection.Close();
        }
        void categorylist()
        {
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            // Tablo adının veritabanındakiyle birebir aynı olduğundan emin ol
            string query = "SELECT * FROM categories";
            var command = new NpgsqlCommand(query, connection);
            var adapter = new NpgsqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            cmbCategory.DisplayMember= "CategoryName";
            cmbCategory.ValueMember = "CategoryId";
            cmbCategory.DataSource = dataTable;
            connection.Close();
        }
        private void btnCategoryList_Click(object sender, EventArgs e)
        {
            FrmCategory fr = new FrmCategory();
            fr.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            todolist();
            categorylist();
        }

        private void btnAllList_Click(object sender, EventArgs e)
        {
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            // Tablo adının veritabanındakiyle birebir aynı olduğundan emin ol
            string query = " Select todolistid,title,description,status,priority,categoryname from todolists\r\ninner join categories\r\non todolists.categoryid=categories.categoryid;";
            var command = new NpgsqlCommand(query, connection);
            var adapter = new NpgsqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            connection.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            int categoryId = int.Parse(cmbCategory.SelectedValue.ToString());
            string title = txtTitle.Text;
            string priority = txtPriority.Text;
            string description = txtDescription.Text;
            //bool status= false;
            //if (rdbCompleted.Checked)
            //{
            //    status = true;
            //}
            //if (rdbCompleted.Checked)
            //{
            //    status = false;
            //}
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "insert into todolists (title,description,status,priority,categoryid) values (@title,@description,B'1',@priority,@categoryId)";
            using (var command = new NpgsqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@title", title);
                command.Parameters.AddWithValue("@description", description);
                //command.Parameters.AddWithValue("@status", status);
                command.Parameters.AddWithValue("@priority", priority);
                command.Parameters.AddWithValue("@categoryId", categoryId);
                command.ExecuteNonQuery();
                MessageBox.Show("Yapılcak işlem Eklendi!");
                todolist();

            }
            connection.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "Delete from todolists where todolistId =@todolistId";
            using (var command = new NpgsqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@todolistId", id);
                command.ExecuteNonQuery ();
                MessageBox.Show("Veri başarıyla silindi!");
                categorylist();
            }
            connection.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            int categoryId = int.Parse(cmbCategory.SelectedValue.ToString());
            string title = txtTitle.Text;
            string priority = txtPriority.Text;
            string description = txtDescription.Text;
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "update todolists set title=@title,priority=@priority,descripton=@description,categoryid=@categoryid where todolists=@todolistid";
            using (var command = new NpgsqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("todolistid", id);
                command.Parameters.AddWithValue("@title", title);
                command.Parameters.AddWithValue("@description", description);
                command.Parameters.AddWithValue("@priority", priority);
                command.Parameters.AddWithValue("@categoryId", categoryId);
                command.ExecuteNonQuery();
                MessageBox.Show("Yapılcak işlem Eklendi!");
                todolist();

            }
            connection.Close();
        }

        private void btnCheckedList_Click(object sender, EventArgs e)
        {
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            // Tablo adının veritabanındakiyle birebir aynı olduğundan emin ol
            string query = "SELECT * FROM todolists where status = '1'";
            var command = new NpgsqlCommand(query, connection);
            var adapter = new NpgsqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            connection.Close();
        }

        private void btnContinueList_Click(object sender, EventArgs e)
        {
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            // Tablo adının veritabanındakiyle birebir aynı olduğundan emin ol
            string query = "SELECT * FROM todolists where status = '0'";
            var command = new NpgsqlCommand(query, connection);
            var adapter = new NpgsqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            connection.Close();
        }
    }
}
