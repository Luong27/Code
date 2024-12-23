﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class WarehouseManagerForm : Form
    {
        int employeeId;
        string authorityLevel;
        public WarehouseManagerForm(string authorityLevel, int employeeId)
        {
            InitializeComponent();
            this.authorityLevel = authorityLevel;
            this.employeeId = employeeId;
        }

        private void WarehouseManagerForm_Load(object sender, EventArgs e)
        {

        }

        private void btnManageProduct_Click(object sender, EventArgs e)
        {
            ManageProduct_form manageProduct_Form = new ManageProduct_form(this.authorityLevel, this.employeeId);
            this.Hide();
            manageProduct_Form.Show();
        }
    }
}