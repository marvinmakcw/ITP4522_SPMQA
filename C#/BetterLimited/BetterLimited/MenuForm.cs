﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BetterLimited
{
    public partial class MenuForm : Form
    {
        public string setStaffID
        {
            set
            {
                lblStaffID.Text = "Staff ID: " + value;
            }
        }
        public MenuForm()
        {
            InitializeComponent();
        }
    }
}
