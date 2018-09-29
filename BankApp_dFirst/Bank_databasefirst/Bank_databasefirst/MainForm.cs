using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bank_databasefirst.Models;
using System.Data.Entity;
using Bank_databasefirst.Forms;

namespace Bank_databasefirst
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
         
            Person person = null;
            using (BankCreditEntities bankCredit = new BankCreditEntities())
            {
                person=bankCredit.People.Add(new Person()
                {
                    Name = txt_name.Text,
                    Surname=txt_sname.Text,
                    Passportnumber=txt_pass.Text
                });
                bankCredit.SaveChanges();
            }
            CreditForm creditForm = new CreditForm(person);            
            creditForm.ShowDialog();
        }
    }
}
