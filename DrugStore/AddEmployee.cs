﻿using System;
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
    public partial class AddEmployee : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        ConnectionDB db = new ConnectionDB();
        Employees e;
        SqlDataReader dr;

        public AddEmployee(Employees e)
        {
            InitializeComponent();
            con = new SqlConnection(db.GetConnection());
            this.e = e;

        }

        public void LoadRecords()
        {
            e.datagw_employees.Rows.Clear();
            int i = 0;
            con.Open();
            cmd = new SqlCommand("Select * FROM Employees", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                e.datagw_employees.Rows.Add(i, dr["EmployeeID"].ToString(), dr["EmployeeName"].ToString(), dr["EmployeeSurname"].ToString(), dr["EmployeeStatus"].ToString(), dr["BirthDate"].ToString(), dr["PhoneNumber"].ToString(), dr["Adress"].ToString(), dr["BranchAdress"].ToString());

            }
            dr.Close();

            con.Close();


        }
        private void Clear()
        {
            tb_adress.Clear();
            tb_branchadress.Clear();
            tb_employeeID.Clear();
            tb_name.Clear();
            tb_phonenumber.Clear();
            
            tb_surname.Clear();
            
            tb_employeeID.Focus();
        }


        private void btn_clearE_Click(object sender, EventArgs e)
        {
            /*tb_employeeID.Clear();
            tb_name.Clear();
            
            tb_surname.Clear();
            tb_branchadress.Clear();
            tb_adress.Clear();
            tb_phonenumber.Clear();
            tb_birthdate.Clear();
            tb_employeeID.Focus();*/
            Clear();
          
        }

        private void btn_saveE_Click(object sender, EventArgs e)
        {

            try
            {
                
                if(/*tb_employeeID.Text = "" */combob_status.Text == "" && tb_name.Text == "" && tb_surname.Text == "" && tb_phonenumber.Text == "" || tb_adress.Text == ""  &&  tb_branchadress.Text == "")
                {
                    MessageBox.Show("REQUIRED MISSING FILE!", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }


                
                


                    con.Open();
                    cmd = new SqlCommand("INSERT INTO Employees (EmployeeID, EmployeeName, EmployeeSurname, EmployeeStatus, BirthDate, PhoneNumber, Adress, BranchAdress) VALUES (@EmployeeID, @EmployeeName, @EmployeeSurname, @EmployeeStatus, @BirthDate, @PhoneNumber, @Adress, @BranchAdress) ", con);
                    cmd.Parameters.AddWithValue("@EmployeeID", tb_employeeID.Text);
                    cmd.Parameters.AddWithValue("@EmployeeName", tb_name.Text);
                    cmd.Parameters.AddWithValue("@EmployeeSurname", tb_surname.Text);
                    cmd.Parameters.AddWithValue("@EmployeeStatus", combob_status.Text);
                    cmd.Parameters.AddWithValue("@BirthDate", dtm_birthdate.Value);
                    cmd.Parameters.AddWithValue("@PhoneNumber", tb_phonenumber.Text);
                    cmd.Parameters.AddWithValue("@Adress", tb_adress.Text);
                    cmd.Parameters.AddWithValue("@BranchAdress", tb_branchadress.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("NEW EMPLOYEE HAS BEEN SUCCESSFULLY SAVED.", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadRecords();
                    Clear();
                    this.Hide();
               




                
            }
            catch(Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message, "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
           
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            
           
            try
            {

                if (/*tb_employeeID.Text = "" */ combob_status.Text == "" && tb_name.Text == "" && tb_surname.Text == "" && tb_phonenumber.Text == ""   || tb_adress.Text == "" && tb_branchadress.Text == "")
                {
                    MessageBox.Show("REQUIRED MISSING FILE!", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (MessageBox.Show("WANT TO UPDATE THIS INFORMATION?", "MESSAGE", MessageBoxButtons.YesNo , MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    
                    con.Open();

                    cmd = new SqlCommand("UPDATE Employees SET EmployeeName = @EmployeeName, EmployeeSurname = @EmployeeSurname, EmployeeStatus = @EmployeeStatus, BirthDate = @BirthDate, PhoneNumber = @PhoneNumber, Adress = @Adress, BranchAdress = @BranchAdress WHERE EmployeeID = @EmployeeID", con);
                    cmd.Parameters.AddWithValue("@EmployeeID", tb_employeeID.Text);
                    cmd.Parameters.AddWithValue("@EmployeeName", tb_name.Text);
                    cmd.Parameters.AddWithValue("@EmployeeSurname", tb_surname.Text);
                    cmd.Parameters.AddWithValue("@EmployeeStatus", combob_status.Text);
                    cmd.Parameters.AddWithValue("@BirthDate", dtm_birthdate.Value);
                    cmd.Parameters.AddWithValue("@PhoneNumber", tb_phonenumber.Text);
                    cmd.Parameters.AddWithValue("@Adress", tb_adress.Text);
                    cmd.Parameters.AddWithValue("@BranchAdress", tb_branchadress.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("EMPLOYEE HAS BEEN SUCCESSFULLY UPDATED.", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadRecords();
                    this.Hide();
                    
                }



            }
            catch(Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message, "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }


    }
}
