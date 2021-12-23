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
    public partial class AddDrug : Form
    { 
        
        SqlConnection con;
        SqlCommand cmd;
        ConnectionDB db = new ConnectionDB();
        Drugs d = new Drugs();
        SqlDataReader dr;


        public AddDrug()
        {
            InitializeComponent();
            con = new SqlConnection(db.GetConnection());
        }


        public void LoadRecords()
        {
            d.datagw_drugs.Rows.Clear();

            int i = 0;
            con.Open();
            cmd = new SqlCommand("Select * FROM Drugs", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                d.datagw_drugs.Rows.Add(i, dr["DrugID"].ToString(), dr["DrugName"].ToString(), dr["Value"].ToString(), dr["Destination"].ToString());

            }
            dr.Close();

            con.Close();


        }

        private void Clear()
        {
            tb_destination.Clear();
            tb_drugID.Clear();
            tb_drugName.Clear();
            tb_value.Clear();
            tb_drugID.Focus();
        }

        private void btn_clearD_Click(object sender, EventArgs e)
        {
            /*tb_drugID.Clear();
            tb_drugName.Clear();
            tb_destination.Clear();
            numeric_value.Value = 0;*/
            Clear();
        }

        private void btn_saveD_Click(object sender, EventArgs e)
        {
            try
            {

                if (tb_drugID.Text == "" || tb_drugName.Text == "" || tb_destination.Text == "" || tb_value.Text == "")
                {
                    MessageBox.Show("REQUIRED MISSING FILE!", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                con.Open();
                cmd = new SqlCommand("INSERT INTO Drugs (DrugID, DrugName, Destination, Value) VALUES (@DrugID, @DrugName, @Destination, @Value)", con);
                cmd.Parameters.AddWithValue("@DrugID", tb_drugID.Text);
                cmd.Parameters.AddWithValue("@DrugName", tb_drugName.Text);
                cmd.Parameters.AddWithValue("@Destination", tb_destination.Text);
                cmd.Parameters.AddWithValue("@Value", tb_value.Text);
                cmd.ExecuteNonQuery();
                con.Close();
               
                MessageBox.Show("NEW DRUG HAS BEEN SUCCESSFULLY SAVED.", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear();
                this.Hide();




            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message, "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_drugID.Text == "" || tb_drugName.Text == "" || tb_destination.Text == "" || tb_value.Text == "")
                {
                    MessageBox.Show("REQUIRED MISSING FILE!", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (MessageBox.Show("WANT TO UPDATE THIS INFORMATION?", "MESSAGE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();

                    cmd = new SqlCommand("UPDATE Drugs SET DrugName = @DrugName, Destination = @Destination, Value = @Value WHERE DrugID = @DrugID", con);
                    cmd.Parameters.AddWithValue("@DrugID", tb_drugID.Text);
                    cmd.Parameters.AddWithValue("@DrugName", tb_drugName.Text);
                    cmd.Parameters.AddWithValue("@Value", tb_value.Text);
                    cmd.Parameters.AddWithValue("@Destination", tb_destination.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("DRUG HAS BEEN SUCCESSFULLY UPDATED.", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
