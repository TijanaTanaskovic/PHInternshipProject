
namespace PHInternshipProject
{
    partial class Employee
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cancelEmployee = new System.Windows.Forms.Button();
            this.deleteEmployee = new System.Windows.Forms.Button();
            this.updateEmployee = new System.Windows.Forms.Button();
            this.addEmployee = new System.Windows.Forms.Button();
            this.monthlySalary = new System.Windows.Forms.TextBox();
            this.phoneNumber = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.TextBox();
            this.firstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.employeeView = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.cancelTask = new System.Windows.Forms.Button();
            this.deleteTask = new System.Windows.Forms.Button();
            this.updateTask = new System.Windows.Forms.Button();
            this.addTask = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.assignee = new System.Windows.Forms.TextBox();
            this.description = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.TextBox();
            this.taskView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeView)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taskView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1081, 700);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.cancelEmployee);
            this.tabPage1.Controls.Add(this.deleteEmployee);
            this.tabPage1.Controls.Add(this.updateEmployee);
            this.tabPage1.Controls.Add(this.addEmployee);
            this.tabPage1.Controls.Add(this.monthlySalary);
            this.tabPage1.Controls.Add(this.phoneNumber);
            this.tabPage1.Controls.Add(this.email);
            this.tabPage1.Controls.Add(this.lastName);
            this.tabPage1.Controls.Add(this.firstName);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.employeeView);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1073, 667);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Employees";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(659, 368);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 27);
            this.dateTimePicker1.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(926, 345);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Monthly salary:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(728, 345);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Date of birth:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(505, 345);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Phone number:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(344, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(175, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Last name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(8, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "First name:";
            // 
            // cancelEmployee
            // 
            this.cancelEmployee.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cancelEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cancelEmployee.Location = new System.Drawing.Point(744, 430);
            this.cancelEmployee.Name = "cancelEmployee";
            this.cancelEmployee.Size = new System.Drawing.Size(135, 35);
            this.cancelEmployee.TabIndex = 13;
            this.cancelEmployee.Text = "Cancel ";
            this.cancelEmployee.UseVisualStyleBackColor = false;
            this.cancelEmployee.Click += new System.EventHandler(this.cancelEmployee_Click);
            // 
            // deleteEmployee
            // 
            this.deleteEmployee.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.deleteEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteEmployee.Location = new System.Drawing.Point(529, 430);
            this.deleteEmployee.Name = "deleteEmployee";
            this.deleteEmployee.Size = new System.Drawing.Size(135, 35);
            this.deleteEmployee.TabIndex = 12;
            this.deleteEmployee.Text = "Delete";
            this.deleteEmployee.UseVisualStyleBackColor = false;
            this.deleteEmployee.Click += new System.EventHandler(this.deleteEmployee_Click);
            // 
            // updateEmployee
            // 
            this.updateEmployee.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.updateEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.updateEmployee.Location = new System.Drawing.Point(315, 430);
            this.updateEmployee.Name = "updateEmployee";
            this.updateEmployee.Size = new System.Drawing.Size(135, 35);
            this.updateEmployee.TabIndex = 11;
            this.updateEmployee.Text = "Update";
            this.updateEmployee.UseVisualStyleBackColor = false;
            this.updateEmployee.Click += new System.EventHandler(this.updateEmployee_Click);
            // 
            // addEmployee
            // 
            this.addEmployee.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.addEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addEmployee.ForeColor = System.Drawing.SystemColors.ControlText;
            this.addEmployee.Location = new System.Drawing.Point(98, 430);
            this.addEmployee.Name = "addEmployee";
            this.addEmployee.Size = new System.Drawing.Size(135, 35);
            this.addEmployee.TabIndex = 10;
            this.addEmployee.Text = "Add";
            this.addEmployee.UseVisualStyleBackColor = false;
            this.addEmployee.Click += new System.EventHandler(this.addEmployee_Click);
            // 
            // monthlySalary
            // 
            this.monthlySalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.monthlySalary.Location = new System.Drawing.Point(926, 368);
            this.monthlySalary.Name = "monthlySalary";
            this.monthlySalary.Size = new System.Drawing.Size(135, 27);
            this.monthlySalary.TabIndex = 9;
            // 
            // phoneNumber
            // 
            this.phoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.phoneNumber.Location = new System.Drawing.Point(505, 368);
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.Size = new System.Drawing.Size(135, 27);
            this.phoneNumber.TabIndex = 7;
            // 
            // email
            // 
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.email.Location = new System.Drawing.Point(344, 368);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(135, 27);
            this.email.TabIndex = 6;
            // 
            // lastName
            // 
            this.lastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lastName.Location = new System.Drawing.Point(175, 368);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(135, 27);
            this.lastName.TabIndex = 5;
            // 
            // firstName
            // 
            this.firstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.firstName.Location = new System.Drawing.Point(8, 368);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(135, 27);
            this.firstName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(332, 36);
            this.label2.TabIndex = 3;
            this.label2.Text = "List of all the employees";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // employeeView
            // 
            this.employeeView.AllowUserToOrderColumns = true;
            this.employeeView.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.employeeView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeView.Location = new System.Drawing.Point(8, 39);
            this.employeeView.Name = "employeeView";
            this.employeeView.RowHeadersWidth = 51;
            this.employeeView.RowTemplate.Height = 29;
            this.employeeView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.employeeView.Size = new System.Drawing.Size(1057, 209);
            this.employeeView.TabIndex = 2;
            this.employeeView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.employeeView_CellClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dateTimePicker2);
            this.tabPage2.Controls.Add(this.cancelTask);
            this.tabPage2.Controls.Add(this.deleteTask);
            this.tabPage2.Controls.Add(this.updateTask);
            this.tabPage2.Controls.Add(this.addTask);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.assignee);
            this.tabPage2.Controls.Add(this.description);
            this.tabPage2.Controls.Add(this.title);
            this.tabPage2.Controls.Add(this.taskView);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1073, 667);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tasks";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(518, 368);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(250, 27);
            this.dateTimePicker2.TabIndex = 14;
            // 
            // cancelTask
            // 
            this.cancelTask.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cancelTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cancelTask.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cancelTask.Location = new System.Drawing.Point(744, 430);
            this.cancelTask.Name = "cancelTask";
            this.cancelTask.Size = new System.Drawing.Size(135, 35);
            this.cancelTask.TabIndex = 13;
            this.cancelTask.Text = "Cancel";
            this.cancelTask.UseVisualStyleBackColor = false;
            this.cancelTask.Click += new System.EventHandler(this.cancelTask_Click);
            // 
            // deleteTask
            // 
            this.deleteTask.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.deleteTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteTask.ForeColor = System.Drawing.SystemColors.ControlText;
            this.deleteTask.Location = new System.Drawing.Point(529, 430);
            this.deleteTask.Name = "deleteTask";
            this.deleteTask.Size = new System.Drawing.Size(135, 35);
            this.deleteTask.TabIndex = 12;
            this.deleteTask.Text = "Delete";
            this.deleteTask.UseVisualStyleBackColor = false;
            this.deleteTask.Click += new System.EventHandler(this.deleteTask_Click);
            // 
            // updateTask
            // 
            this.updateTask.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.updateTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.updateTask.ForeColor = System.Drawing.SystemColors.ControlText;
            this.updateTask.Location = new System.Drawing.Point(315, 430);
            this.updateTask.Name = "updateTask";
            this.updateTask.Size = new System.Drawing.Size(135, 35);
            this.updateTask.TabIndex = 11;
            this.updateTask.Text = "Update";
            this.updateTask.UseVisualStyleBackColor = false;
            this.updateTask.Click += new System.EventHandler(this.updateTask_Click);
            // 
            // addTask
            // 
            this.addTask.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.addTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addTask.ForeColor = System.Drawing.SystemColors.ControlText;
            this.addTask.Location = new System.Drawing.Point(98, 430);
            this.addTask.Name = "addTask";
            this.addTask.Size = new System.Drawing.Size(135, 35);
            this.addTask.TabIndex = 10;
            this.addTask.Text = "Add";
            this.addTask.UseVisualStyleBackColor = false;
            this.addTask.Click += new System.EventHandler(this.addTask_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(605, 345);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 20);
            this.label12.TabIndex = 9;
            this.label12.Text = "Due date:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(344, 345);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 20);
            this.label11.TabIndex = 8;
            this.label11.Text = "Assignee:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(175, 345);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 20);
            this.label10.TabIndex = 7;
            this.label10.Text = "Description:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(8, 345);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 20);
            this.label9.TabIndex = 6;
            this.label9.Text = "Title:";
            // 
            // assignee
            // 
            this.assignee.Location = new System.Drawing.Point(344, 368);
            this.assignee.Name = "assignee";
            this.assignee.Size = new System.Drawing.Size(135, 27);
            this.assignee.TabIndex = 4;
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(175, 368);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(135, 27);
            this.description.TabIndex = 3;
            // 
            // title
            // 
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.title.Location = new System.Drawing.Point(8, 368);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(135, 27);
            this.title.TabIndex = 2;
            // 
            // taskView
            // 
            this.taskView.AllowUserToOrderColumns = true;
            this.taskView.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.taskView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.taskView.Location = new System.Drawing.Point(8, 39);
            this.taskView.Name = "taskView";
            this.taskView.RowHeadersWidth = 51;
            this.taskView.RowTemplate.Height = 29;
            this.taskView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.taskView.Size = new System.Drawing.Size(1057, 188);
            this.taskView.TabIndex = 1;
            this.taskView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.taskView_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "List of all the tasks";
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1077, 713);
            this.Controls.Add(this.tabControl1);
            this.Name = "Employee";
            this.Text = "PHCompany";
            this.Load += new System.EventHandler(this.Employee_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taskView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView employeeView;
        private System.Windows.Forms.DataGridView taskView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cancelEmployee;
        private System.Windows.Forms.Button deleteEmployee;
        private System.Windows.Forms.Button updateEmployee;
        private System.Windows.Forms.Button addEmployee;
        private System.Windows.Forms.TextBox monthlySalary;
        private System.Windows.Forms.TextBox phoneNumber;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.TextBox assignee;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.Button cancelTask;
        private System.Windows.Forms.Button deleteTask;
        private System.Windows.Forms.Button updateTask;
        private System.Windows.Forms.Button addTask;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}

