using Project4_EntityFrameworkCodeFirstMovie.DAL.Context;
using Project4_EntityFrameworkCodeFirstMovie.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;

namespace Project4_EntityFrameworkCodeFirstMovie
{
    public partial class FrmMovie : Form
    {
        public FrmMovie()
        {
            InitializeComponent();
        }
        MovieContext context = new MovieContext();
        void categoryList()
        {
            var values = context.Categories.ToList();
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryId";
            cmbCategory.DataSource = values;
        }
        private void btnList_Click(object sender, EventArgs e)
        {
            var values = context.Movies.ToList();
            dataGridView1.DataSource = values;
        }

        private void FrmMovie_Load(object sender, EventArgs e)
        {
           categoryList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Movie movie = new Movie();
            movie.MovieTitle = txtMovieName.Text;
            movie.Description = txtMovieDescription.Text;
            movie.CreateDate = DateTime.Parse(mskViewsDate.Text);
            movie.CategoryId =int.Parse (cmbCategory.SelectedValue.ToString());
            movie.Duration = int.Parse(txtMovieTime.Text);
            context.Movies.Add(movie);
            context.SaveChanges();
            MessageBox.Show("İşlem başarılı!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtMovieId.Text);
            var value = context.Movies.Find(id);
            context.Movies.Remove(value);
            context.SaveChanges();
            MessageBox.Show("İşlem başarılı!");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var values = context.Movies.Where(x=>x.MovieTitle == txtMovieName.Text).ToList();
            dataGridView1.DataSource = values;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtMovieId.Text);
            var value = context.Movies.Find(id);
            value.Duration=int.Parse(txtMovieTime.Text);
            value.MovieTitle = txtMovieName.Text;
            value.Description = txtMovieDescription.Text;
            value.CreateDate = DateTime.Parse(mskViewsDate.Text);
            value.CategoryId = int.Parse(cmbCategory.SelectedValue.ToString());
            context.SaveChanges();
            MessageBox.Show("İşlem Başarılı!");
        }

        private void btnMovieWithCategory_Click(object sender, EventArgs e)
        {
            var values = context.Movies.Join(context.Categories, movie => movie.CategoryId, category => category.CategoryId, 
                (movie, category) => new
            {
                MovieId = movie.MovieId,
                MovieTitle = movie.MovieTitle,
                Description = movie.Description,
                Duration = movie.Duration,
                CategoryName = category.CategoryName,
            }).ToList();
            dataGridView1.DataSource = values;
        }
    }
}
