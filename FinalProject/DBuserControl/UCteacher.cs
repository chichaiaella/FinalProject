using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FinalProject.DBuserControl
{
    public partial class Main: UserControl
    {
        DataTable dt = new DataTable("table");
        string remarks;
        int Index;
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // table header
            dt.Columns.Add("First Name", Type.GetType("System.String"));
            dt.Columns.Add("Last Name", Type.GetType("System.String"));
            dt.Columns.Add("Middle Name", Type.GetType("System.String"));
            dt.Columns.Add("Program", Type.GetType("System.String"));
            dt.Columns.Add("Subjects", Type.GetType("System.String"));
            dt.Columns.Add("Prelim 20%", Type.GetType("System.Single"));
            dt.Columns.Add("Midterm 30%", Type.GetType("System.Single"));
            dt.Columns.Add("Final 50%", Type.GetType("System.Single"));
            dt.Columns.Add("Average");
            dt.Columns.Add("Remarks");

            dgvStudent.DataSource = dt;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            // clear all input/textbox
            txtFirstname.Text = string.Empty;
            txtLastname.Text = string.Empty;
            txtMiddlename.Text = string.Empty;
            txtProgram.Text = string.Empty;
            cmbSubjects.Text = string.Empty;
            txtPrelim.Text = string.Empty;
            txtMidterm.Text = string.Empty;
            txtFinal.Text = string.Empty;
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            //clear all the data in datagridview
            ((DataTable)dgvStudent.DataSource).Clear();
        }

        private void dgvGradesInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Index = e.RowIndex;
            DataGridViewRow selectedRow = dgvStudent.Rows[Index];
            txtFirstname.Text = selectedRow.Cells[0].Value.ToString();
            txtLastname.Text = selectedRow.Cells[1].Value.ToString();
            txtMiddlename.Text = selectedRow.Cells[2].Value.ToString();
            txtProgram.Text = selectedRow.Cells[3].Value.ToString();
            cmbSubjects.Text = selectedRow.Cells[4].Value.ToString();
            txtPrelim.Text = selectedRow.Cells[5].Value.ToString();
            txtMidterm.Text = selectedRow.Cells[6].Value.ToString();
            txtFinal.Text = selectedRow.Cells[7].Value.ToString();
        }

            private void btnAdd_Click(object sender, EventArgs e)
            {

                if (txtFirstname.Text == "" ||
                    txtLastname.Text == "" ||
                    txtMiddlename.Text == "" ||
                    txtProgram.Text == "" ||
                    txtPrelim.Text == "" ||
                    txtMidterm.Text == "" ||
                    txtFinal.Text == ""
                    )
                {
                    MessageBox.Show("Please fill in all fields.");
                }
                //if user input all of text box 
                else
                {
                    //grades prelim midterm and final
                    float prelim = Convert.ToSingle(txtPrelim.Text);
                    float midterm = Convert.ToSingle(txtMidterm.Text);
                    float final = Convert.ToSingle(txtFinal.Text);
                    //average
                    var average = (prelim * 0.20) + (midterm * 0.30) + (final * 0.50);
                    var FinalAverage = average.ToString("F2");


                    //remarks of grades
               
                    if (average == 1)
                    {
                        remarks = "Outstanding";
                    }
                    else if (average <= 1.50)
                    {
                        remarks = "Very Good";
                    }
                    else if (average <= 2.25)
                    {
                        remarks = "Good";
                    }
                    else if (average <= 2.75)
                    {
                        remarks = "Fair";
                    }
                    else if (average == 3)
                    {
                        remarks = "Passed";
                    }
                    else
                    {
                        remarks = "Failure";
                      
                }
               
                

                dt.Rows.Add(txtFirstname.Text,
                                txtLastname.Text,
                                txtMiddlename.Text,
                                txtProgram.Text,
                                cmbSubjects.SelectedItem,
                                txtPrelim.Text,
                                txtMidterm.Text,
                                txtFinal.Text,
                                FinalAverage,
                                remarks);




                    int lastRowIndex = dgvStudent.Rows.Count - 1;
                    DataGridViewRow newdata = dgvStudent.Rows[lastRowIndex];
                // Check if the average is greater than 3.1 and color the row red
                if (average > 3.1f)
                {
                    newdata.DefaultCellStyle.ForeColor = Color.Red;
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataGridViewRow newdata = dgvStudent.Rows[Index];
            newdata.Cells[0].Value = txtFirstname.Text;
            newdata.Cells[1].Value = txtLastname.Text;
            newdata.Cells[2].Value = txtMiddlename.Text;
            newdata.Cells[3].Value = txtProgram.Text;
            newdata.Cells[4].Value = cmbSubjects.SelectedItem;
            newdata.Cells[5].Value = txtPrelim.Text;
            newdata.Cells[6].Value = txtMidterm.Text;
            newdata.Cells[7].Value = txtFinal.Text;
            //grades prelim midterm and final
            float prelim = Convert.ToSingle(txtPrelim.Text);
            float midterm = Convert.ToSingle(txtMidterm.Text);
            float final = Convert.ToSingle(txtFinal.Text);
            //average
            var average = (prelim * 0.20) + (midterm * 0.30) + (final * 0.50);
            var FinalAverage = average.ToString("F2");
            //remarks of grades
            if (average == 1)
            {
                remarks = "Outstanding";
            }
            else if (average <= 1.50)
            {
                remarks = "Very Good";
            }
            else if (average <= 2.25)
            {
                remarks = "Good";
            }
            else if (average <= 2.75)
            {
                remarks = "Fair";
            }
            else if (average == 3)
            {
                remarks = "Passed";
            }
            else
            {
                remarks = "Failure";
            }
            newdata.Cells[8].Value = FinalAverage;
            newdata.Cells[9].Value = remarks;
            //update the datagridview
            dgvStudent.Refresh();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Index = dgvStudent.CurrentCell.RowIndex;
            if (Index != -1)
            {
                dgvStudent.Rows.RemoveAt(Index);
                txtFirstname.Text = string.Empty;
                txtLastname.Text = string.Empty;
                txtMiddlename.Text = string.Empty;
                txtProgram.Text = string.Empty;
                cmbSubjects.Text = string.Empty;
                txtPrelim.Text = string.Empty;
                txtMidterm.Text = string.Empty;
                txtFinal.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }
    }
}
