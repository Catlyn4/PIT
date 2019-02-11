using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Student
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void studentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.appStudentDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.studentTableAdapter.Fill(this.appStudentDataSet.Student);
            studentBindingSource.DataSource = this.appStudentDataSet.Student;
            panel1.Enabled = false;

        }

        private void studentBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.studentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.appStudentDataSet);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                panel1.Enabled = true;
                student_IDTextBox.Focus();
                this.appStudentDataSet.Student.AddStudentRow(this.appStudentDataSet.Student.NewStudentRow());
                studentBindingSource.MoveLast();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                studentBindingSource.ResetBindings(false);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                studentBindingSource.EndEdit();
                studentTableAdapter.Update(this.appStudentDataSet.Student);
                panel1.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                studentBindingSource.ResetBindings(false);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            student_IDTextBox.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this record? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                studentBindingSource.RemoveCurrent();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textSearch.Text))
            {
                studentDataGridView.DataSource = studentBindingSource;

            }
            else
            {
                var query = from o in this.appStudentDataSet.Student
                            where o.Last_Name.Contains(textSearch.Text) || o.First_Name.Contains(textSearch.Text)
                            select o;
                studentDataGridView.DataSource = query.ToList();
            }
        }

        private void textSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void student_IDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void studentDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void last_NameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ageTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cityTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void parents_NameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void streetTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void statusTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void parents_Phone_NumberTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void sexTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void religionTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void birthPlaceLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
