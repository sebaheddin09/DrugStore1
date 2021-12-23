using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrugStore
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btn_homepage_Click(object sender, EventArgs e)
        {
            openEmployeeForm(new MainPicture());
            
                   
        }

        private void btn_employees_Click(object sender, EventArgs e)
        {
            openEmployeeForm(new Employees());
           
          
        }

        private Form activeForm = null;
        private void openEmployeeForm(Form employeeForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = employeeForm;
            employeeForm.TopLevel = false;
            employeeForm.FormBorderStyle = FormBorderStyle.None;
            employeeForm.Dock = DockStyle.Fill;
            panel_main.Controls.Add(employeeForm);
            panel_main.Tag= employeeForm;
            employeeForm.BringToFront();
            employeeForm.Show();
            panel_main.Visible = true;
        }

        private void btn_branches_Click(object sender, EventArgs e)
        {
            openEmployeeForm(new Branches());
            
            panel_main.Visible = true;
        }

        private void btn_drugs_Click(object sender, EventArgs e)
        {
            openEmployeeForm(new Drugs());
            
            panel_main.Visible = true;


        }

        private void btn_information_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by Kamran Mammadov, Nihad Adigozalov, Sabahaddin Nasibli\nCEO Rasim Mahmudov\nCreated in Sumgait\nCurrent version 1.0.0.1", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_information_MouseEnter(object sender, EventArgs e)
        {
            btn_information.BackColor = Color.FromArgb(56, 148, 87);
        }
    }
}
