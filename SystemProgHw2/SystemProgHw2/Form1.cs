using System.Threading;

namespace SystemProgHw2
{
    public partial class Form1 : Form
    {
        private CancellationTokenSource lockObjectgenerate = new CancellationTokenSource();
        private CancellationTokenSource lockObjectfibonacci = new CancellationTokenSource();

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnGenerate_Click_Click(object sender, EventArgs e)
        {
            int start = string.IsNullOrEmpty(textBox1.Text) ? 2 : int.Parse(textBox1.Text);
            int end = string.IsNullOrEmpty(textBox2.Text) ? int.MaxValue : int.Parse(textBox2.Text);
            lock (lockObjectgenerate)
            {
                Thread thread = new Thread(() => GeneratePrimes(start, end));
                thread.Start();
            }

        }

        private void GeneratePrimes(int start, int end)
        {
            for (int number = start; number <= end; number++)
            {
                if (IsPrime(number))
                {
                    // Добавляем новое простое число в список в контексте потока UI
                    listBox1.Invoke(new Action(() => listBox1.Items.Add(number)));
                }
            }
        }
        private void Fibonacci(int start, int end)
        {
            int a = 0;
            int b = 1;
            listBox1.Invoke(new Action(() => listBox1.Items.Clear()));
            listBox1.Invoke(new Action(() => listBox1.Items.Add(a)));
            listBox1.Invoke(new Action(() => listBox1.Items.Add(b)));
            for (int i = 2; i <= end; i++)
            {
                int c = a + b;
                if (c > end)
                {
                    break;
                }
                a = b;
                b = c;
                listBox1.Invoke(new Action(() => listBox1.Items.Add(c)));
            }
        }
        private bool IsPrime(int number)
        {
            if (number <= 1)
            {
                return false;
            }
            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int start = string.IsNullOrEmpty(textBox1.Text) ? 0 : int.Parse(textBox1.Text);
            int end = string.IsNullOrEmpty(textBox2.Text) ? 100 : int.Parse(textBox2.Text);
            lock (lockObjectfibonacci)
            {
                lockObjectfibonacci = new CancellationTokenSource();
                Thread thread1 = new Thread(() => Fibonacci(start, end));
                thread1.Start();
            }
        }

        private void button2_Click(object sender, EventArgs e) 
        {
            lock (lockObjectfibonacci)
            {
                lockObjectfibonacci.Cancel();
            }
        }

        private void Restart_btn_Click(object sender, EventArgs e)
        {
           listBox1.Items.Clear();
                 
        }
    }
}