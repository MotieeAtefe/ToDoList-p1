using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList
{
    public partial class AddToTask : Form
    {
        DataGridView dataGridView1 = new DataGridView();
        public AddToTask()
        {
            InitializeComponent();
            dataGridView1.Columns.Add("TaskNameColumn", "Task Name");
            dataGridView1.Columns.Add("DueDateColumn", "Due Date");
            dataGridView1.Columns.Add("DurationColumn", "Duration");
            // setting size DataGridView
            dataGridView1.Size = new Size(400, 200); 

            // setting Location DataGridView
            dataGridView1.Location = new Point((this.ClientSize.Width - dataGridView1.Width) - 20, (this.ClientSize.Height - dataGridView1.Height) / 2); 

            // setting show DataGridView
            dataGridView1.Anchor = AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom; 

            // Add DataGridView to form controls
            this.Controls.Add(dataGridView1);
        }

        private void txtTaskName_TextChanged(object sender, EventArgs e)
        {
            string taskName = textBoxTaskName.Text;
            
        }

        private void dtpDueDate_ValueChanged(object sender, EventArgs e)
        {
            //Time and date of the task
            DateTime dueDate = dateTimePickerDueDate.Value;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Task time
            string duration = textBoxDuration.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Getting values ​​from the user
            string taskName = textBoxTaskName.Text;
            DateTime dueDate = dateTimePickerDueDate.Value;
            string duration = textBoxDuration.Text;

            // Add a new row here
            int rowIndex = dataGridView1.Rows.Add();
            DataGridViewRow row = dataGridView1.Rows[rowIndex];

            row.Cells["TaskNameColumn"].Value = taskName;
            row.Cells["DueDateColumn"].Value = dueDate;
            row.Cells["DurationColumn"].Value = duration;

            // cleaning values ​​from the user
            textBoxTaskName.Clear();
            textBoxDuration.Clear();
            dateTimePickerDueDate.Value = DateTime.Now;
        }

        private void AddToTask_Load(object sender, EventArgs e)
        {

        }
    }
}

