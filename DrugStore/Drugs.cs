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

    


    public partial class Drugs : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        ConnectionDB db = new ConnectionDB();

        public Drugs()
        {
            InitializeComponent();
            con = new SqlConnection(db.GetConnection());
            LoadRecords();
        }

        public void LoadRecords()
        {
            datagw_drugs.Rows.Clear();
            int i = 0;
            con.Open();
            cmd = new SqlCommand("Select * FROM Drugs", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                datagw_drugs.Rows.Add(i, dr["DrugID"].ToString(), dr["DrugName"].ToString(), dr["Destination"].ToString(), dr["Value"].ToString());

            }
            dr.Close();

            con.Close();
        }

        private void btn_addDrug_Click(object sender, EventArgs e)
        {
            
            AddDrug ad = new AddDrug();
            ad.Show();
            ad.btn_update.Enabled = false;
        }

        private void datagw_drugs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = datagw_drugs.Columns[e.ColumnIndex].Name;

            if(colName == "columnedit")
            {
                AddDrug ad = new AddDrug();
                ad.tb_drugID.Text = datagw_drugs.Rows[e.RowIndex].Cells[1].Value.ToString();
                ad.tb_drugName.Text = datagw_drugs.Rows[e.RowIndex].Cells[2].Value.ToString();
                ad.tb_value.Text = datagw_drugs.Rows[e.RowIndex].Cells[4].Value.ToString();
                ad.tb_destination.Text = datagw_drugs.Rows[e.RowIndex].Cells[3].Value.ToString();
                ad.btn_clearD.Enabled = false;
                ad.btn_saveD.Enabled = false;
                ad.btn_update.Enabled = true;
                ad.tb_drugID.Enabled = false;
                ad.ShowDialog();


            }
            else if(colName == "columndelete")
            {
                if(MessageBox.Show("WANT TO DELETE THIS INFORMATION?", "MESSAGE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cmd = new SqlCommand("DELETE FROM Drugs WHERE DrugID = '" + datagw_drugs.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("INFORMATION HAS BEEN SUCCESSFULLY DELETED.", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadRecords();
                }
            }
        }
    }
    /*private void btn_addDrug_Click(object sender, EventArgs e)
        {
            AddDrug ad = new AddDrug();
            ad.Show();
        }*/
    }

