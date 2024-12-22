using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string task = taskTextBox.Text;
            if (!string.IsNullOrWhiteSpace(task))
            {
                taskListBox.Items.Add(task);
                taskTextBox.Clear(); 
            }
            else
            {
                MessageBox.Show("Введите задачу.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (taskListBox.SelectedIndex != -1)
            {
                taskListBox.Items.RemoveAt(taskListBox.SelectedIndex); 
            }
            else
            {
                MessageBox.Show("Выберите задачу для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void titleLabel_Click(object sender, EventArgs e)
        {

        }
    }
}