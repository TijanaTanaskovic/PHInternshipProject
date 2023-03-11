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
            ShowTOPEmployee();

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
            dateTimePicker1.Text = "";
            monthlySalary.Text = "";
        }

        private void ResetTaskData()
        {
            Key = 0;
            title.Text = "";
            description.Text = "";
            assignee.Text = "";
            dateTimePicker2.Text = "";
        }
      
        private void Employee_Load(object sender, EventArgs e)
        {

        }

        private void employeeView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //used because the cellcontentclick expected us to click on content in the cell and now we can click only
            //on particular cell 
            ResetЕmployeeData();
            firstName.Text = employeeView.SelectedRows[0].Cells[1].Value.ToString();
            lastName.Text = employeeView.SelectedRows[0].Cells[2].Value.ToString();
            email.Text = employeeView.SelectedRows[0].Cells[3].Value.ToString();
            phoneNumber.Text = employeeView.SelectedRows[0].Cells[4].Value.ToString();
            dateTimePicker1.Text = employeeView.SelectedRows[0].Cells[5].Value.ToString();
            monthlySalary.Text = employeeView.SelectedRows[0].Cells[6].Value.ToString();

            if (firstName.Text == "")
            {
                IDEmployee = 0;
            }
            else
            {
                IDEmployee = Convert.ToInt32(employeeView.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void taskView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ResetTaskData();
            title.Text = taskView.SelectedRows[0].Cells[1].Value.ToString();
            description.Text = taskView.SelectedRows[0].Cells[2].Value.ToString();
            assignee.Text = taskView.SelectedRows[0].Cells[3].Value.ToString();
            dateTimePicker2.Text = taskView.SelectedRows[0].Cells[4].Value.ToString();

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

        bool CheckEmployee()
        {
            if (firstName.Text == "" || lastName.Text == "" || email.Text == "" || phoneNumber.Text == ""
                || dateTimePicker1.Text == "" || monthlySalary.Text == "")
            {
                return true;
            }
            else return false;
        }

        bool CheckTask()
        {
            if (title.Text == "" || description.Text == "" || assignee.Text == "" || dateTimePicker2.Text == "")
            {
                return true;
            }
            else return false;
        }

        private void deleteEmployee_Click(object sender, EventArgs e)
        {
            if (CheckEmployee() == true)
            {
                MessageBox.Show("Please, select the employee you want to delete!", "Employee removal failed.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    if (IDEmployee == 0)
                    {
                        MessageBox.Show("Please, select the employee you want to delete!", "Employee removal failed.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        this.databaseConnection.Open();

                        string query = "DELETE FROM employee WHERE employee_ID = @IDEmployee";
                        cmd = new MySqlCommand(query, this.databaseConnection);
                        cmd.Parameters.AddWithValue("@IDEmployee", IDEmployee);

                        cmd.ExecuteNonQuery();

                        this.databaseConnection.Close();

                        ResetЕmployeeData();
                        ShowAllEmployee();
                        MessageBox.Show("Successful removal!");
                        ShowTOPEmployee();
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                    this.databaseConnection.Close();
                }
            }
        }

        private void deleteTask_Click(object sender, EventArgs e)
        {
            if (CheckTask() == true)
            {
                MessageBox.Show("Please, select the task you want to delete!", "Task removal failed.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    if (IDTask == 0)
                    {
                        MessageBox.Show("Please, select the task you want to delete!", "Task removal failed.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        this.databaseConnection.Open();

                        string query = "DELETE FROM task WHERE task_ID = @IDTask";
                        cmd = new MySqlCommand(query, this.databaseConnection);
                        cmd.Parameters.AddWithValue("@IDTask", IDTask);

                        cmd.ExecuteNonQuery();

                        this.databaseConnection.Close();

                        ResetTaskData();
                        ShowAllTasks();
                        ShowTOPEmployee();
                        MessageBox.Show("Successful removal!");

                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                    this.databaseConnection.Close();
                }
            }
        }

        private void addEmployee_Click(object sender, EventArgs e)
        {
            if (CheckEmployee() == true)
            {
                MessageBox.Show("Please, enter all necessary data!", "Failed to add an employee.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    this.databaseConnection.Open();
                    // cathching the data and inserting it into the database
                    string query = "INSERT INTO employee(first_name, last_name, email, phone_number, date_of_birth, monthly_salary) VALUES (@first_name, @last_name, @email, @phone_number, @date_of_birth, @monthly_salary)";
                    cmd = new MySqlCommand(query, this.databaseConnection);

                    cmd.Parameters.AddWithValue("@first_name", firstName.Text);
                    cmd.Parameters.AddWithValue("@last_name", lastName.Text);
                    cmd.Parameters.AddWithValue("@email", email.Text);
                    cmd.Parameters.AddWithValue("@phone_number", phoneNumber.Text);
                    cmd.Parameters.AddWithValue("@date_of_birth", dateTimePicker1.Value.Date);
                    cmd.Parameters.AddWithValue("@monthly_salary", monthlySalary.Text);

                    cmd.ExecuteNonQuery();

                    
                    this.databaseConnection.Close();

                    ResetЕmployeeData();
                    ShowAllEmployee();
                    ShowTOPEmployee();

                    MessageBox.Show("You successfully added an empoloyee!", "Successful addition.", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                    this.databaseConnection.Close();
                }
            }
        }

        private void addTask_Click(object sender, EventArgs e)
        {
            if (CheckTask() == true)
            {
                MessageBox.Show("Please, enter all necessary data!", "Failed to add task.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    this.databaseConnection.Open();
                    // cathching the data and inserting it into the database
                    string query = "INSERT INTO task(title, description, assignee, due_date) VALUES (@title, @description, @assignee, @due_date)";
                    cmd = new MySqlCommand(query, this.databaseConnection);

                    cmd.Parameters.AddWithValue("@title", title.Text);
                    cmd.Parameters.AddWithValue("@description", description.Text);
                    cmd.Parameters.AddWithValue("@assignee", assignee.Text);
                    cmd.Parameters.AddWithValue("@due_date", dateTimePicker2.Value.Date);

                    cmd.ExecuteNonQuery();


                    this.databaseConnection.Close();

                    ResetTaskData();
                    ShowAllTasks();
                    ShowTOPEmployee();

                    MessageBox.Show("You successfully added task!", "Successful addition.", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                    this.databaseConnection.Close();
                }
            }
        }

        private void updateEmployee_Click(object sender, EventArgs e)
        {
            if (CheckEmployee() == true)
            {
                MessageBox.Show("Please, select the one you want to change or enter all necessary data!", "Failed to update an employee data.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    this.databaseConnection.Open();

                    string query = "UPDATE employee SET first_name = @first_name, last_name = @last_name, email = @email, phone_number = @phone_number, date_of_birth = @date_of_birth, monthly_salary = @monthly_salary WHERE employee_ID = @IDEmployee";
                    cmd = new MySqlCommand(query, this.databaseConnection);
                    cmd.Parameters.AddWithValue("@first_name", firstName.Text);
                    cmd.Parameters.AddWithValue("@last_name", lastName.Text);
                    cmd.Parameters.AddWithValue("@email", email.Text);
                    cmd.Parameters.AddWithValue("@phone_number", phoneNumber.Text);
                    cmd.Parameters.AddWithValue("@date_of_birth", dateTimePicker1.Value.Date);
                    cmd.Parameters.AddWithValue("@monthly_salary", monthlySalary.Text);
                    cmd.Parameters.AddWithValue("@IDEmployee", IDEmployee);

                    cmd.ExecuteNonQuery();

                    
                    this.databaseConnection.Close();

                    ResetЕmployeeData();
                    ShowAllEmployee();
                    ShowTOPEmployee();

                    MessageBox.Show("You successfully updated an empoloyee data!", "Successful update.", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                    this.databaseConnection.Close();
                }
            }
        }

        private void updateTask_Click(object sender, EventArgs e)
        {
            if (CheckTask() == true)
            {
                MessageBox.Show("Please, select the one you want to change or enter all necessary data!", "Failed to update task data.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    this.databaseConnection.Open();

                    string query = "UPDATE task SET title = @title, description = @description, assignee = @assignee, due_date = @due_date WHERE task_ID = @IDTask";
                    cmd = new MySqlCommand(query, this.databaseConnection);

                    cmd.Parameters.AddWithValue("@title", title.Text);
                    cmd.Parameters.AddWithValue("@description", description.Text);
                    cmd.Parameters.AddWithValue("@assignee", assignee.Text);
                    cmd.Parameters.AddWithValue("@due_date", dateTimePicker2.Value.Date);
                    cmd.Parameters.AddWithValue("@IDTask", IDTask);

                    cmd.ExecuteNonQuery();


                    this.databaseConnection.Close();

                    ResetTaskData();
                    ShowAllTasks();
                    ShowTOPEmployee();

                    MessageBox.Show("You successfully updated task data!", "Successful update.", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                    this.databaseConnection.Close();
                }
            }
        }

        public void ShowTOPEmployee(string searchQuery = "SELECT COUNT(assignee) as sum, assignee, first_name, last_name FROM employee inner join task on assignee=employee_ID WHERE datediff(now(),due_date)<=30 AND datediff(now(),due_date)>0 GROUP BY assignee ORDER BY COUNT(assignee) DESC LIMIT 5")
        {
            this.databaseConnection.Open();
            da = new MySqlDataAdapter(searchQuery, databaseConnection);
            MySqlCommandBuilder Builder = new MySqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            emAndTaskView.DataSource = ds.Tables[0];
            emAndTaskView.AutoResizeColumns();
            emAndTaskView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            this.databaseConnection.Close();
        }

    }
}
