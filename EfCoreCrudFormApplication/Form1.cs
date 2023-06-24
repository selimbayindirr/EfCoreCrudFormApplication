using EfCoreCrudFormApplication.DataAccess;
using EfCoreCrudFormApplication.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Windows.Forms;
using System.Xml.Linq;

namespace EfCoreCrudFormApplication
{
    public partial class Form1 : Form
    {
        private FCContext _context;

        public Form1()
        {
            InitializeComponent();
            _context = new FCContext();
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string lastname = textBox2.Text;
            int Perid = int.Parse(textBox3.Text);

            Person person = new Person
            {
                PersonName = name,
                PersonLastName = lastname,
                Id = Perid
            };


            _context.People.Add(person);
            _context.SaveChanges();

            RefreshDataGrid();

            ClearInputs();
        }


        private void RefreshDataGrid()
        {
            dataGridView1.DataSource = _context.People.ToList();
        }
        private void ClearInputs()
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _context.People.ToList();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _context.People.Where(p => p.PersonName == textBox1.Text).ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //// Silinecek kiþinin adýný alýn
            //string personName = dataGridView1.CurrentRow.Cells["PersonName"].Value.ToString();

            //// Kiþiyi veritabanýndan bulun
            //Person personToDelete = _context.People.FirstOrDefault(p => p.PersonName == personName);

            //if (personToDelete != null)
            //{
            //    // Kiþiyi silin
            //    _context.People.Remove(personToDelete);
            //    _context.SaveChanges();

            //    // DataGridView'i güncelleyin (isteðe baðlý)
            //    dataGridView1.DataSource = _context.People.Select(p => p.PersonName).ToList();

            //    MessageBox.Show("Kiþi silindi.");
            //}

            //

            Person personToDelete = _context.People.FirstOrDefault(p => p.Id == int.Parse(textBox3.Text));
            if (personToDelete != null)
            {
                _context.People.Remove(personToDelete);
                _context.SaveChanges();
                RefreshDataGrid();
            }
            else
            {
                MessageBox.Show("Deðer Null Olamaz");
            }





        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.Text = string.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Person personToUpdate = _context.People.FirstOrDefault(p => p.Id == int.Parse(textBox3.Text));
            //string name = textBox1.Text;
            //string lastname = textBox2.Text;
            //int Perid = int.Parse(textBox3.Text);

            //Person person = new Person
            //{
            //    PersonName = name,
            //    PersonLastName = lastname,
            //    Id = Perid
            //};
            //_context.People.Update(person);
            //_context.SaveChanges(); RefreshDataGrid();


        }
    }
}