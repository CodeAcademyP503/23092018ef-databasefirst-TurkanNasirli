using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_databasefirst.Forms
{
    public partial class CreditForm : Form
    {
        private readonly Person Person;
        private readonly Credit credit;
        public CreditForm()
        {
            InitializeComponent();
        }

        public CreditForm(object _person):this()
        {
            Person = _person as Person;
           
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            var text = Convert.ToDecimal(txt_amount.Text);
            try
            {
                using (BankCreditEntities bankCredit = new BankCreditEntities())
                {
                    bankCredit.Credits.Add(new Credit()
                    {
                        Person=Person.ID,
                        Amount = text,
                        Disburs = dateTimePicker1.Value.Date
                    });

                    bankCredit.SaveChanges();
                }
            }
            catch (Exception)
            {
                Type t = text.GetType();
                if (t != typeof(decimal))
                {
                    MessageBox.Show("Mebleg yalnis qeyd olub.Yeniden cehd edin");
                }
            }          
        }

        private void CreditForm_Load(object sender, EventArgs e)
        {
            txt_cname.Text = Person.Name;
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            AllData allData = new AllData();
            using (BankCreditEntities bank = new BankCreditEntities())
            {
                for (int i = 0; i < bank.People.ToList().Count; i++)
                {
                    allData.dataGridView1.Rows.Add();

                    allData.dataGridView1.Rows[i].Cells[0].Value = bank.People.ToList()[i].ID;
                    allData.dataGridView1.Rows[i].Cells[1].Value = bank.People.ToList()[i].Name;
                    allData.dataGridView1.Rows[i].Cells[2].Value = bank.Credits.ToList()[i].Amount;
                }             

            }
            allData.ShowDialog();
        }
    }
}
