﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBTutorial2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var classicContext = new classicmodelsEntities())
            {
                var allEmpNum = from list in classicContext.employees
                                select list.employeeNumber; //select employeeNumber from employees
                                                            //var emp = classContext.employees.Select(i => i.employeeNumber);

                // var allEmpNum = classicContext.employees.Where(i => i.email.Contains("ab") || i.employeeNumber == 1501).Select(i => i.employeeNumber);

                foreach (var empno in allEmpNum.ToList())
                {
                    lstBox1.Items.Add(empno);
                }



                /*var allFirstLastName = from list in classicContext.employees
                                       select new { list.firstName, list.lastName };
                //select firstName as a, LastName as b from employees
                foreach (var empno in allFirstLastName.ToList())
                {
                    lstBox2.Items.Add(empno.firstName + " " + empno.lastName);
                }*/

                var allFirstLastName = from list in classicContext.employees
                                       where (list.firstName.Contains("Mary") || list.firstName.Contains("Barry"))
                                       select new { list.firstName, list.lastName };
                foreach (var empno in allFirstLastName.ToList())
                {
                    lstBox2.Items.Add(empno.firstName + " " + empno.lastName);
                }


            }
        }
    }
}
