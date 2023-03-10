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

        int Key = 0;
        int IDEmployee = 0;
        int IDTask = 0;

        private void ResetЕmployeeData()
        {
            Key = 0;
            firstName.Text = "";
            lastName.Text = "";
            email.Text = "";
            phoneNumber.Text = "";
            dateOfBirth.Text = "";
            monthlySalary.Text = "";
        }

        private void ResetTaskData()
        {
            Key = 0;
            title.Text = "";
            description.Text = "";
            assignee.Text = "";
            dueDate.Text = "";
        }
      
        private void Employee_Load(object sender, EventArgs e)
        {

        }

        private void employeeView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (employeeView.SelectedRows.Count > 0) {

                ResetЕmployeeData();
                firstName.Text = employeeView.SelectedRows[0].Cells[1].Value.ToString();
                lastName.Text = employeeView.SelectedRows[0].Cells[2].Value.ToString();
                email.Text = employeeView.SelectedRows[0].Cells[3].Value.ToString();
                phoneNumber.Text = employeeView.SelectedRows[0].Cells[4].Value.ToString();
                dateOfBirth.Text = employeeView.SelectedRows[0].Cells[5].Value.ToString();
                monthlySalary.Text = employeeView.SelectedRows[0].Cells[6].Value.ToString();

                if (firstName.Text == "")
                {
                    IDEmployee = 0;
                }
                else
                {
                    IDEmployee = Convert.ToInt32(employeeView.SelectedRows[0].Cells[0].Value.ToString());
                }
                //MessageBox.Show("ovo se koristi" + IDEmployee);
            //}
            

        }

        private void taskView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ResetTaskData();
            title.Text = taskView.SelectedRows[0].Cells[1].Value.ToString();
            description.Text = taskView.SelectedRows[0].Cells[2].Value.ToString();
            assignee.Text = taskView.SelectedRows[0].Cells[3].Value.ToString();
            dueDate.Text = taskView.SelectedRows[0].Cells[4].Value.ToString();

            if (title.Text == "")
            {
                IDTask = 0;
            }
            else
            {
                IDTask = Convert.ToInt32(taskView.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void cancelEmployee_Click(object sender, EventArgs e)
        {
            ResetЕmployeeData();
        }

        private void cancelTask_Click(object sender, EventArgs e)
        {
            ResetTaskData();
        }
    }
}
