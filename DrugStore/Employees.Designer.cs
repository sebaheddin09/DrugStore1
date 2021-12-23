﻿
namespace DrugStore
{
    partial class Employees
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employees));
            this.datagw_employees = new System.Windows.Forms.DataGridView();
            this.btn_addEmployee = new System.Windows.Forms.Button();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Employee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeSurName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BranchAdress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnedit = new System.Windows.Forms.DataGridViewImageColumn();
            this.columndelete = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.datagw_employees)).BeginInit();
            this.SuspendLayout();
            // 
            // datagw_employees
            // 
            this.datagw_employees.AllowUserToAddRows = false;
            this.datagw_employees.AllowUserToDeleteRows = false;
            this.datagw_employees.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagw_employees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagw_employees.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.datagw_employees.ColumnHeadersHeight = 29;
            this.datagw_employees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.datagw_employees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number,
            this.Employee,
            this.EmployeeName,
            this.EmployeeSurName,
            this.EmployeeStatus,
            this.BirthDate,
            this.PhoneNumber,
            this.Adress,
            this.BranchAdress,
            this.columnedit,
            this.columndelete});
            this.datagw_employees.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.datagw_employees.Location = new System.Drawing.Point(12, 3);
            this.datagw_employees.Name = "datagw_employees";
            this.datagw_employees.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.datagw_employees.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.datagw_employees.RowHeadersWidth = 51;
            this.datagw_employees.RowTemplate.Height = 24;
            this.datagw_employees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagw_employees.Size = new System.Drawing.Size(921, 392);
            this.datagw_employees.TabIndex = 0;
            this.datagw_employees.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagw_employees_CellContentClick);
            // 
            // btn_addEmployee
            // 
            this.btn_addEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_addEmployee.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_addEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_addEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_addEmployee.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_addEmployee.Location = new System.Drawing.Point(763, 415);
            this.btn_addEmployee.Name = "btn_addEmployee";
            this.btn_addEmployee.Size = new System.Drawing.Size(116, 57);
            this.btn_addEmployee.TabIndex = 1;
            this.btn_addEmployee.Text = "Add";
            this.btn_addEmployee.UseVisualStyleBackColor = false;
            this.btn_addEmployee.Click += new System.EventHandler(this.btn_addEmployee_Click);
            // 
            // number
            // 
            this.number.FillWeight = 50F;
            this.number.HeaderText = "*";
            this.number.MinimumWidth = 6;
            this.number.Name = "number";
            // 
            // Employee
            // 
            this.Employee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Employee.HeaderText = "EmployeeID";
            this.Employee.MinimumWidth = 6;
            this.Employee.Name = "Employee";
            this.Employee.Width = 92;
            // 
            // EmployeeName
            // 
            this.EmployeeName.HeaderText = "EmployeeName";
            this.EmployeeName.MinimumWidth = 6;
            this.EmployeeName.Name = "EmployeeName";
            // 
            // EmployeeSurName
            // 
            this.EmployeeSurName.HeaderText = "EmployeeSurname";
            this.EmployeeSurName.MinimumWidth = 6;
            this.EmployeeSurName.Name = "EmployeeSurName";
            // 
            // EmployeeStatus
            // 
            this.EmployeeStatus.HeaderText = "EmployeeStatus";
            this.EmployeeStatus.MinimumWidth = 6;
            this.EmployeeStatus.Name = "EmployeeStatus";
            // 
            // BirthDate
            // 
            this.BirthDate.HeaderText = "BirthDate";
            this.BirthDate.MinimumWidth = 6;
            this.BirthDate.Name = "BirthDate";
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.HeaderText = "PhoneNumber";
            this.PhoneNumber.MinimumWidth = 6;
            this.PhoneNumber.Name = "PhoneNumber";
            // 
            // Adress
            // 
            this.Adress.HeaderText = "Adress";
            this.Adress.MinimumWidth = 6;
            this.Adress.Name = "Adress";
            // 
            // BranchAdress
            // 
            this.BranchAdress.HeaderText = "BranchAdress";
            this.BranchAdress.MinimumWidth = 6;
            this.BranchAdress.Name = "BranchAdress";
            // 
            // columnedit
            // 
            this.columnedit.FillWeight = 20F;
            this.columnedit.HeaderText = "";
            this.columnedit.Image = ((System.Drawing.Image)(resources.GetObject("columnedit.Image")));
            this.columnedit.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.columnedit.MinimumWidth = 6;
            this.columnedit.Name = "columnedit";
            // 
            // columndelete
            // 
            this.columndelete.FillWeight = 20F;
            this.columndelete.HeaderText = "";
            this.columndelete.Image = ((System.Drawing.Image)(resources.GetObject("columndelete.Image")));
            this.columndelete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.columndelete.MinimumWidth = 6;
            this.columndelete.Name = "columndelete";
            // 
            // Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 497);
            this.Controls.Add(this.btn_addEmployee);
            this.Controls.Add(this.datagw_employees);
            this.MinimumSize = new System.Drawing.Size(956, 544);
            this.Name = "Employees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employees";
            ((System.ComponentModel.ISupportInitialize)(this.datagw_employees)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_addEmployee;
        public System.Windows.Forms.DataGridView datagw_employees;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Employee;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeSurName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adress;
        private System.Windows.Forms.DataGridViewTextBoxColumn BranchAdress;
        private System.Windows.Forms.DataGridViewImageColumn columnedit;
        private System.Windows.Forms.DataGridViewImageColumn columndelete;
    }
}