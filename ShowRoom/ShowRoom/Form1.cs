using Microsoft.EntityFrameworkCore;
using ShowRoom;
using ShowRooms.Model;

namespace ShowRooms
{



    public partial class Form1 : Form
    {
        private CarContext _context;
        public Form1()
        {
            InitializeComponent();
            _context = new CarContext();
            LoadData();
        }
        private void LoadData()
        {
            // _context.ShowRoom.Include(s => s.Cars).Load();
            //dataGridView1.DataSource = _context.Cars.Local.ToBindingList();

            var CartList = _context.Cars
                   .Include(x => x.ShowRoom).ToList();

            dataGridView1.DataSource = _context.Cars.Local.ToBindingList();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            var Car = new Car
            {

                Name = textBox1.Text,
                Model = textBox2.Text,
                Year = Convert.ToInt32(textBox3.Text),
                Price = Convert.ToInt32(textBox4.Text),
                ShowRoomId = Convert.ToInt32(textBox5.Text),

            };
             if (!String.IsNullOrEmpty(textBox1.Text) &&    !String.IsNullOrEmpty(textBox3.Text) && Int32.TryParse(textBox4.Text, out int value4) && Int32.TryParse(textBox5.Text, out int value5))

            {
                _context.Cars.Add(Car);
                _context.SaveChanges();

                LoadData();
            }


            else
            {
                MessageBox.Show("Заполните данные полностью!");


                LoadData();
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var SelectCar = dataGridView1.SelectedRows[0].DataBoundItem as Car;
            var SelectShoowRoom = dataGridView1.SelectedRows[0].DataBoundItem as ShowRoomClass;   

            if (SelectCar != null)
            {
                textBox1.Text = SelectCar.Name;
                textBox2.Text = SelectCar.Model;
                textBox3.Text = SelectCar.Year.ToString();
                textBox4.Text = SelectCar.Price.ToString();
                textBox5.Text = SelectCar.ShowRoomId.ToString();
            }
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_context != null)
            {
                _context.Dispose();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int CarId = (int)dataGridView1.SelectedRows[0].Cells["Id"].Value;

                var car = _context.Cars.Find(CarId);

                if (car == null)
                {
                    MessageBox.Show("Автомобиль не найден!");
                    return;
                }




                // student.Id = textBox1.Text;
                car.Name = textBox1.Text;
                car.Model = textBox2.Text;
                car.Year = Convert.ToInt32(textBox3.Text);
                car.Price = Convert.ToInt32(textBox4.Text);


                LoadData();
                _context.SaveChanges();

                _context = new CarContext();
                LoadData();
                MessageBox.Show("Автомобиль успешно отредактирован!");

            }
            else
            {
                MessageBox.Show("Выберите Автомобиль для редактирования!");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var SelectedCar = dataGridView1.SelectedRows[0].DataBoundItem as Car;

            if (SelectedCar != null)
            {
                _context.Cars.Remove(SelectedCar);
                _context.SaveChanges();

                LoadData();
            }
        }
        Form2 f2;
        private void button4_Click(object sender, EventArgs e)
        {
           f2 = new Form2();
            f2.Show();
        }
    }
}
