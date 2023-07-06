using Microsoft.EntityFrameworkCore;
using ShowRooms.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ShowRoom
{
    public partial class Form2 : Form
    {
        private CarContext _context;
       
        public Form2()
        { 

            InitializeComponent();
            _context = new CarContext();
            LoadData();
        }
        private void LoadData()
        {
            // _context.ShowRoom.Include(s => s.Cars).Load();
            //dataGridView1.DataSource = _context.Cars.Local.ToBindingList();

            var ShowRoomList = _context.ShowRoom
                   .Include(x => x.Cars ).ToList();

            dataGridView1.DataSource = _context.ShowRoom.Local.ToBindingList();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var ShowRoomClass = new ShowRoomClass  
            {

                Name = textBox1.Text,
               
               

            };
             if (!String.IsNullOrEmpty(textBox1.Text))

            {
                _context.ShowRoom.Add(ShowRoomClass);
                _context.SaveChanges();

                LoadData();
            }


             else
            {
                MessageBox.Show("Заполните данные полностью!");


                LoadData();
            }

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var SelectShoowRoom = dataGridView1.SelectedRows[0].DataBoundItem as ShowRoomClass;

            if (SelectShoowRoom != null)
            {
                textBox1.Text = SelectShoowRoom.Name;

            }
        }
    }
}
