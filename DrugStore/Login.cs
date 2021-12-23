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
    public partial class Login : Form
    {

        SqlConnection con;
        SqlCommand cmd ;
        ConnectionDB db = new ConnectionDB();
        //SqlDataReader dr;
        SqlDataAdapter sda;
        
        public Login()
        {
            InitializeComponent();
            con = new SqlConnection(db.GetConnection());
        }

        private void cb_password_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_password.Checked)
            {
                tb_password.UseSystemPasswordChar = true;
                var checkbox = (CheckBox)sender;
                
            }
            else
            {
                tb_password.UseSystemPasswordChar = false;
                var checkbox = (CheckBox)sender;
               
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            
                string query = "Select * From Login Where Username = '" + tb_username.Text.Trim() + "' and Password = '" + tb_password.Text.Trim() + "'";
                sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
               
          
               
            if(dt.Rows.Count == 1)
                {
                   
 
                    Loading load = new Loading();
                    
                    load.Show();
                    this.Hide();



                }
                else
                {
                    MessageBox.Show("USERNAME or PASSWORD is INCORRECT", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
            
            con.Close();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
