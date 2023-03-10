using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PHInternshipProject
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
            ShowAllEmployee();
            ShowAllTasks();
            //employeeView.AutoResizeColumns();
            //taskView.AutoResizeColumns();

        }

        static string MySQLConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=phinternship; SSL Mode = None";
        MySqlConnection databaseConnection = new MySqlConnection(Employee.MySQLConnectionString);
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter da = new MySqlDataAdapter();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void ShowAllEmployee(string searchQuery = "SELECT employee_ID, first_name, last_name, email, phone_number, date_of_birth, monthly_salary FROM employee WHERE 1=1")
        {
            this.databaseConnection.Open();
            da = new MySqlDataAdapter(searchQuery, databaseConnection);
            MySqlCommandBuilder Builder = new MySqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            employeeView.DataSource = ds.Tables[0];
            employeeView.AutoResizeColumns();
            employeeView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            this.databaseConnection.Close();
        }

        public void ShowAllTasks(string searchQuery = "SELECT * FROM task")
        {
            this.databaseConnection.Open();
            da = new MySqlDataAdapter(searchQuery, databaseConnection);
            MySqlCommandBuilder Builder = new MySqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            taskView.DataSource = ds.Tables[0];
            taskView.AutoResizeColumns();
            taskView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            this.databaseConnection.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Employee_Load(object sender, EventArgs e)
        {

        }
    }
}
