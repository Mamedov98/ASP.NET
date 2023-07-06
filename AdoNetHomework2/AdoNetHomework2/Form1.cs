using AdoNetHomework2.Service;
using System.Data.SqlClient;

namespace AdoNetHomework2
{
    public partial class Form1 : Form
    {
        private readonly DbConfigService _dbConfigService;
        private string _connectionString;
        public Form1()
        {
            InitializeComponent();
            _dbConfigService = new("STOCKINCLASS");
        }

        private void Form1_Load(object sender, EventArgs e)
        { 
            DbConfigService configService = new("STOCKINCLASS");
                using SqlConnection conn = new(_dbConfigService.GetConnectionString());

                conn.Open();
            if (conn.State == System.Data.ConnectionState.Open)
            {

                using SqlCommand command = new("select name,Type,Quantity,DATA,PRICE,SupplierName from NAME inner join COSTPRICE C on NAME.Id = C.NameId inner join DATADELIVERY D on NAME.Id = D.NameId inner join PRODUCTQUALITY P on NAME.Id = P.NameId inner join SUPPLIER S on NAME.Id = S.NameId inner join TYPE T on NAME.Id = T.NameId", conn);

                var reader = command.ExecuteReader();

                var cols = reader.GetColumnSchema();

                var tables = reader.GetSchemaTable();

                comboBox1.Items.Add(tables);

                foreach (var item in cols)
                {
                    dataGridView1.Columns.Add(item.ColumnName, item.ColumnName);
                }

                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4], reader[5]);
                }
            }
            else 
            { 
                dataGridView1.Columns.Clear();
                MessageBox.Show("ERROR CONNECTED");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    {

                        dataGridView1.Rows.Clear();
                        dataGridView1.Columns.Clear();
                        using SqlConnection conn = new(_dbConfigService.GetConnectionString());
                        conn.Open();


                        using SqlCommand command = new(" SELECT Name FROM NAME;", conn);
                        SqlDataReader reader = command.ExecuteReader();
                        var cols = reader.GetColumnSchema();
                        foreach (var item in cols)
                        {
                            dataGridView1.Columns.Add(item.ColumnName, item.ColumnName);
                        }

                        while (reader.Read())
                        {
                            dataGridView1.Rows.Add(reader[0]);
                        }
                        break;
                    }
                case 1:
                    {

                        dataGridView1.Rows.Clear();
                        dataGridView1.Columns.Clear();
                        using SqlConnection conn = new(_dbConfigService.GetConnectionString());
                        conn.Open();


                        using SqlCommand command = new(" SELECT Id,Type FROM TYPE;", conn);
                        SqlDataReader reader = command.ExecuteReader();
                        var cols = reader.GetColumnSchema();
                        foreach (var item in cols)
                        {
                            dataGridView1.Columns.Add(item.ColumnName, item.ColumnName);
                        }

                        while (reader.Read())
                        {
                            dataGridView1.Rows.Add(reader[0], reader[1]);
                        }
                        break;
                    }
                case 2:
                    {

                        dataGridView1.Rows.Clear();
                        dataGridView1.Columns.Clear();
                        using SqlConnection conn = new(_dbConfigService.GetConnectionString());
                        conn.Open();


                        using SqlCommand command = new(" SELECT id,SupplierName FROM SUPPLIER;", conn);
                        SqlDataReader reader = command.ExecuteReader();
                        var cols = reader.GetColumnSchema();
                        foreach (var item in cols)
                        {
                            dataGridView1.Columns.Add(item.ColumnName, item.ColumnName);
                        }

                        while (reader.Read())
                        {
                            dataGridView1.Rows.Add(reader[0], reader[1]);
                        }
                        break;
                    }
                case 3:
                    {

                        dataGridView1.Rows.Clear();
                        dataGridView1.Columns.Clear();
                        using SqlConnection conn = new(_dbConfigService.GetConnectionString());
                        conn.Open();


                        using SqlCommand command = new("  select name,Type,Quantity,DATA,PRICE,SupplierName from NAME inner join COSTPRICE C on NAME.Id = C.NameId inner join DATADELIVERY D on NAME.Id = D.NameId inner join PRODUCTQUALITY P on NAME.Id = P.NameId inner join SUPPLIER S on NAME.Id = S.NameId inner join TYPE T on NAME.Id = T.NameId WHERE Quantity = (SELECT Max(Quantity) FROM PRODUCTQUALITY);", conn);
                        SqlDataReader reader = command.ExecuteReader();
                        var cols = reader.GetColumnSchema();
                        foreach (var item in cols)
                        {
                            dataGridView1.Columns.Add(item.ColumnName, item.ColumnName);
                        }

                        while (reader.Read())
                        {

                            dataGridView1.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4], reader[5]);
                        }
                        break;
                    }
                case 4:
                    {

                        dataGridView1.Rows.Clear();
                        dataGridView1.Columns.Clear();
                        using SqlConnection conn = new(_dbConfigService.GetConnectionString());
                        conn.Open();


                        using SqlCommand command = new(" select name,Type,Quantity,DATA,PRICE,SupplierName from NAME inner join COSTPRICE C on NAME.Id = C.NameId inner join DATADELIVERY D on NAME.Id = D.NameId inner join PRODUCTQUALITY P on NAME.Id = P.NameId inner join SUPPLIER S on NAME.Id = S.NameId inner join TYPE T on NAME.Id = T.NameId WHERE Quantity = (SELECT Min(Quantity) FROM PRODUCTQUALITY);", conn);
                        SqlDataReader reader = command.ExecuteReader();
                        var cols = reader.GetColumnSchema();
                        foreach (var item in cols)
                        {
                            dataGridView1.Columns.Add(item.ColumnName, item.ColumnName);
                        }

                        while (reader.Read())
                        {

                            dataGridView1.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4], reader[5]);
                        }
                        break;
                    }
                case 5:
                    {

                        dataGridView1.Rows.Clear();
                        dataGridView1.Columns.Clear();
                        using SqlConnection conn = new(_dbConfigService.GetConnectionString());
                        conn.Open();


                        using SqlCommand command = new(" select name,Type,Quantity,DATA,PRICE,SupplierName from NAME inner join COSTPRICE C on NAME.Id = C.NameId inner join DATADELIVERY D on NAME.Id = D.NameId inner join PRODUCTQUALITY P on NAME.Id = P.NameId inner join SUPPLIER S on NAME.Id = S.NameId inner join TYPE T on NAME.Id = T.NameId WHERE PRICE = (SELECT Max(PRICE) FROM COSTPRICE);", conn);
                        SqlDataReader reader = command.ExecuteReader();
                        var cols = reader.GetColumnSchema();
                        foreach (var item in cols)
                        {
                            dataGridView1.Columns.Add(item.ColumnName, item.ColumnName);
                        }

                        while (reader.Read())
                        {

                            dataGridView1.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4], reader[5]);
                        }
                        break;
                    }
                case 6:
                    {

                        dataGridView1.Rows.Clear();
                        dataGridView1.Columns.Clear();
                        using SqlConnection conn = new(_dbConfigService.GetConnectionString());
                        conn.Open();


                        using SqlCommand command = new(" select name,Type,Quantity,DATA,PRICE,SupplierName from NAME inner join COSTPRICE C on NAME.Id = C.NameId inner join DATADELIVERY D on NAME.Id = D.NameId inner join PRODUCTQUALITY P on NAME.Id = P.NameId inner join SUPPLIER S on NAME.Id = S.NameId inner join TYPE T on NAME.Id = T.NameId WHERE PRICE = (SELECT Min(PRICE) FROM COSTPRICE);", conn);
                        SqlDataReader reader = command.ExecuteReader();
                        var cols = reader.GetColumnSchema();
                        foreach (var item in cols)
                        {
                            dataGridView1.Columns.Add(item.ColumnName, item.ColumnName);
                        }

                        while (reader.Read())
                        {

                            dataGridView1.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4], reader[5]);
                        }
                        break;
                    }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox2.SelectedIndex)
            {

                case 0:
                    {
                        dataGridView1.Rows.Clear();
                        dataGridView1.Columns.Clear();
                        using SqlConnection conn = new(_dbConfigService.GetConnectionString());
                        conn.Open();


                        using SqlCommand command = new(" select name,Type,Quantity,DATA,PRICE,SupplierName from NAME inner join COSTPRICE C on NAME.Id = C.NameId inner join DATADELIVERY D on NAME.Id = D.NameId inner join PRODUCTQUALITY P on NAME.Id = P.NameId inner join SUPPLIER S on NAME.Id = S.NameId inner join TYPE T on NAME.Id = T.NameId WHERE Type like N'Dairy';", conn);
                        SqlDataReader reader = command.ExecuteReader();
                        var cols = reader.GetColumnSchema();
                        foreach (var item in cols)
                        {
                            dataGridView1.Columns.Add(item.ColumnName, item.ColumnName);
                        }

                        while (reader.Read())
                        {

                            dataGridView1.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4], reader[5]);
                        }
                        break;
                    }
                case 1:
                    {
                        dataGridView1.Rows.Clear();
                        dataGridView1.Columns.Clear();
                        using SqlConnection conn = new(_dbConfigService.GetConnectionString());
                        conn.Open();


                        using SqlCommand command = new(" select name,Type,Quantity,DATA,PRICE,SupplierName from NAME inner join COSTPRICE C on NAME.Id = C.NameId inner join DATADELIVERY D on NAME.Id = D.NameId inner join PRODUCTQUALITY P on NAME.Id = P.NameId inner join SUPPLIER S on NAME.Id = S.NameId inner join TYPE T on NAME.Id = T.NameId WHERE Type like N'Meat Product';", conn);
                        SqlDataReader reader = command.ExecuteReader();
                        var cols = reader.GetColumnSchema();
                        foreach (var item in cols)
                        {
                            dataGridView1.Columns.Add(item.ColumnName, item.ColumnName);
                        }

                        while (reader.Read())
                        {

                            dataGridView1.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4], reader[5]);
                        }
                        break;
                    }
                case 2:
                    {
                        dataGridView1.Rows.Clear();
                        dataGridView1.Columns.Clear();
                        using SqlConnection conn = new(_dbConfigService.GetConnectionString());
                        conn.Open();


                        using SqlCommand command = new(" select name,Type,Quantity,DATA,PRICE,SupplierName from NAME inner join COSTPRICE C on NAME.Id = C.NameId inner join DATADELIVERY D on NAME.Id = D.NameId inner join PRODUCTQUALITY P on NAME.Id = P.NameId inner join SUPPLIER S on NAME.Id = S.NameId inner join TYPE T on NAME.Id = T.NameId WHERE Type like N'Flour Product';", conn);
                        SqlDataReader reader = command.ExecuteReader();
                        var cols = reader.GetColumnSchema();
                        foreach (var item in cols)
                        {
                            dataGridView1.Columns.Add(item.ColumnName, item.ColumnName);
                        }

                        while (reader.Read())
                        {

                            dataGridView1.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4], reader[5]);
                        }
                        break;
                    }
                case 3:
                    {
                        dataGridView1.Rows.Clear();
                        dataGridView1.Columns.Clear();
                        using SqlConnection conn = new(_dbConfigService.GetConnectionString());
                        conn.Open();


                        using SqlCommand command = new(" select name,Type,Quantity,DATA,PRICE,SupplierName from NAME inner join COSTPRICE C on NAME.Id = C.NameId inner join DATADELIVERY D on NAME.Id = D.NameId inner join PRODUCTQUALITY P on NAME.Id = P.NameId inner join SUPPLIER S on NAME.Id = S.NameId inner join TYPE T on NAME.Id = T.NameId WHERE Type like N'Vegetables';", conn);
                        SqlDataReader reader = command.ExecuteReader();
                        var cols = reader.GetColumnSchema();
                        foreach (var item in cols)
                        {
                            dataGridView1.Columns.Add(item.ColumnName, item.ColumnName);
                        }

                        while (reader.Read())
                        {

                            dataGridView1.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4], reader[5]);
                        }
                        break;
                    }
                case 4:
                    {
                        dataGridView1.Rows.Clear();
                        dataGridView1.Columns.Clear();
                        using SqlConnection conn = new(_dbConfigService.GetConnectionString());
                        conn.Open();


                        using SqlCommand command = new(" select name,Type,Quantity,DATA,PRICE,SupplierName from NAME inner join COSTPRICE C on NAME.Id = C.NameId inner join DATADELIVERY D on NAME.Id = D.NameId inner join PRODUCTQUALITY P on NAME.Id = P.NameId inner join SUPPLIER S on NAME.Id = S.NameId inner join TYPE T on NAME.Id = T.NameId WHERE Type like N'Fruits';", conn);
                        SqlDataReader reader = command.ExecuteReader();
                        var cols = reader.GetColumnSchema();
                        foreach (var item in cols)
                        {
                            dataGridView1.Columns.Add(item.ColumnName, item.ColumnName);
                        }

                        while (reader.Read())
                        {

                            dataGridView1.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4], reader[5]);
                        }
                        MessageBox.Show("THE PRODUCT IS OUT OF STOCK");
                        break;
                    }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            DbConfigService configService = new("STOCKINCLASS");
            using SqlConnection conn = new(_dbConfigService.GetConnectionString());

            conn.Open();



            using SqlCommand command = new("select name,Type,Quantity,DATA,PRICE,SupplierName from NAME inner join COSTPRICE C on NAME.Id = C.NameId inner join DATADELIVERY D on NAME.Id = D.NameId inner join PRODUCTQUALITY P on NAME.Id = P.NameId inner join SUPPLIER S on NAME.Id = S.NameId inner join TYPE T on NAME.Id = T.NameId", conn);

            var reader = command.ExecuteReader();

            var cols = reader.GetColumnSchema();

            var tables = reader.GetSchemaTable();

            comboBox1.Items.Add(tables);

            foreach (var item in cols)
            {
                dataGridView1.Columns.Add(item.ColumnName, item.ColumnName);
            }

            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4], reader[5]);
            }
        }
    }
}