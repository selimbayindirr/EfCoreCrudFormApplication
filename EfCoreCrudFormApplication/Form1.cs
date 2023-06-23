using EfCoreCrudFormApplication.DataAccess;
using EfCoreCrudFormApplication.Entity;
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
            //textBox1.Text = string.Empty;
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            //textBox2.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string lastname = textBox2.Text;

            Person person = new Person
            {
                PersonName = name,
                PersonLastName = lastname
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

        }
    }
}