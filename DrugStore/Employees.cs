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

namespace DrugStore
{
    public partial class Employees : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        ConnectionDB db = new ConnectionDB();
        AddEmployee ae; 

        public Employees()
        {
            InitializeComponent();
            con = new SqlConnection(db.GetConnection());
            LoadRecords();
        }

        public void LoadRecords()
        {
            datagw_employees.Rows.Clear();
            int  i  = 0;
            con.Open();
            cmd = new SqlCommand("Select * FROM Employees", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                datagw_employees.Rows.Add(i, dr["EmployeeID"].ToString(), dr["EmployeeName"].ToString(), dr["EmployeeSurname"].ToString(), dr["EmployeeStatus"].ToString(), dr["BirthDate"].ToString(), dr["PhoneNumber"].ToString(), dr["Adress"].ToString(), dr["BranchAdress"].ToString());

            }
            dr.Close();

            con.Close();


        }

        private void btn_addEmployee_Click(object sender, EventArgs e)
        {
            AddEmployee ae = new AddEmployee(this);
            
            ae.Show();
            ae.btn_update.Enabled = false;
        }

        private void datagw_employees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = datagw_employees.Columns[e.ColumnIndex].Name;

            if(colName == "columnedit")
            {
                
                AddEmployee ae = new AddEmployee(this);
                string date = ae.dtm_birthdate.Value.ToString();

                ae.tb_employeeID.Text = datagw_employees.Rows[e.RowIndex].Cells[1].Value.ToString();
                ae.tb_name.Text = datagw_employees.Rows[e.RowIndex].Cells[2].Value.ToString();
                ae.tb_surname.Text = datagw_employees.Rows[e.RowIndex].Cells[3].Value.ToString();
                ae.combob_status.Text = datagw_employees.Rows[e.RowIndex].Cells[4].Value.ToString();
                date = datagw_employees.Rows[e.RowIndex].Cells[5].Value.ToString();
                ae.tb_phonenumber.Text = datagw_employees.Rows[e.RowIndex].Cells[6].Value.ToString();
                ae.tb_adress.Text = datagw_employees.Rows[e.RowIndex].Cells[7].Value.ToString();
                ae.tb_branchadress.Text = datagw_employees.Rows[e.RowIndex].Cells[8].Value.ToString();
                ae.btn_saveE.Enabled = false;
                ae.btn_clearE.Enabled = false;
                ae.btn_update.Enabled = true;
                ae.tb_employeeID.Enabled = false;
                ae.ShowDialog();
               
                
            }
            else if(colName == "columndelete")
            {
                if (MessageBox.Show("WANT TO DELETE THIS INFORMATION?", "MESSAGE", MessageBoxButtons.YesNo , MessageBoxIcon.Question ) == DialogResult.Yes)
                {
                    con.Open();
                    cmd = new SqlCommand("DELETE FROM Employees WHERE EmployeeID = '" + datagw_employees.Rows[e.RowIndex].Cells[1].Value.ToString() + "'" , con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("INFORMATION HAS BEEN SUCCESSFULLY DELETED.", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadRecords();
                }

            }
        }
    }
}
