using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CRUDAmurao
{
    public partial class Form1 : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='|DataDirectory|\sampledb.mdf';Integrated Security=True;Connect Timeout=30");
        SqlCommand command;
        SqlDataAdapter adapter;
        SqlDataReader reader;
        String query = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadData();
        }


        //Load Data function
        public void loadData()
        {
            try
            {
                connection.Open();
                query = "select * from Students";
                command = new SqlCommand(query, connection);
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {

                    DataTable dt = new DataTable();

                    dt.Load(reader);

                    dataGridView1.DataSource = dt;

                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }

        //Add Data function
        public void AddData(String name, int age)
        {
            try
            {
                connection.Open();
                query = "insert into Students ([StudentName], [StudentAge]) values (@name, @age);";
                command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@age", age);
                command.ExecuteNonQuery();
                MessageBox.Show("Student has been added!");
                connection.Close();
                loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }

        //Delete data function
        public void DeleteData(String name)
        {
            try
            {
                connection.Open();
                query = "Delete from Students where [StudentName] = @name;";
                command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@name", name);
                command.ExecuteNonQuery();
                MessageBox.Show($"Student {name} has been deleted!");
                connection.Close();
                loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }

        //Update Data function
        public void UpdateData(String name, int age)
        {
            try
            {
                connection.Open();
                query = "update Students set [StudentAge] = @age where [StudentName] = @name;";
                command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@age", age);
                command.ExecuteNonQuery();
                MessageBox.Show($"Student {name} has been updated!");
                connection.Close();
                loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtAge.Text == "")
            {
                MessageBox.Show("You cannot have this thing empty!");
            }
            else
            {
                AddData(txtName.Text, int.Parse(txtAge.Text));
                txtName.Clear();
                txtAge.Clear();
            }
        }

        private void btnDELETE_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("You cannot have this name empty!");
            }
            else
            {
                DeleteData(txtName.Text);
                txtName.Clear();
                txtAge.Clear();
            }
        }

        private void btnUPDATE_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("You cannot have this name empty!");
            }
            else
            {
                UpdateData(txtName.Text, int.Parse(txtAge.Text));
                txtName.Clear();
                txtAge.Clear();
            }
        }
    }
}
