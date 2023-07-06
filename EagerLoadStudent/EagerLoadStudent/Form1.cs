using EagerLoadStudent.Model;
using Microsoft.EntityFrameworkCore;

namespace EagerLoadStudent
{
    public partial class Form1 : Form
    {
        private StudentContext _context;
        public Form1()
        {
            InitializeComponent();
            _context = new StudentContext();
            LoadData();
        }
        private void LoadData() 
        {
            _context.Students.Load();


            using (_context)
            {
                var studentList = _context.Students
                    .Include(x => x.Groups).ToList();

                dataGridView1.DataSource = studentList;
            }
            //  dataGridView1.DataSource = _context.Students.Local.ToBindingList();



        }
    }
}