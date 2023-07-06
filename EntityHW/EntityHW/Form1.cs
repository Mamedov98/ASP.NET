using EntityHW.data.DbContexts;
using Microsoft.EntityFrameworkCore;
using EntityHW.models;
namespace EntityHW
{
   public partial class Form1 : Form
{
    private ForeCastdbContext _context;

    public Form1()
    {
        InitializeComponent();

        _context = new ForeCastdbContext();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        dataGridView1.DataSource = _context.ForecastHistories.ToList();
    }
}
}