using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalBookManagment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
  
public class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public string Genre { get; set; }
            public DateTime PublishDate { get; set; }

            public Book(string title, string author, string genre, DateTime publishDate)
            {
                Title = title;
                Author = author;
                Genre = genre;
                PublishDate = publishDate;
            }

            // Display book information in a string format
            public override string ToString()
            {
                return $"{Title} by {Author} ({Genre}, {PublishDate.ToShortDateString()})";
            }
        }

        private void btnRemoveBook_Click(object sender, EventArgs e)
        {

        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {

        }
    }
}

