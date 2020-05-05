using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    { 
        BankAccount b = new BankAccount(Convert.ToDecimal(1362.59), 000302019);
        IList<string> strList = new List<string>();
        enum TagType
        {
            OK,
            Overdrawn,
            InsufficientFunds,
            DepositTooLarge,
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        public void check()
        {
            
            textBox2.Text = b.displaybal().ToString();
            textBox1.Text = "000"+b.displayacc().ToString();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            check();    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            if (radioButton1.Checked == true )
            {
                
                 if ((transactionnumber.TextLength == 0) && (transactionnumber.Text == "" )   )
                {
                    
                    MessageBox.Show("Cannot Deposit 0 amounts");
                }
                else if ((Convert.ToDecimal(transactionnumber.Text )) == 0 )
                {
                      MessageBox.Show("Enter amount greater than 0 ");
                }
                else if ((Convert.ToDecimal(transactionnumber.Text)) > 10000 )
                {
                    TagType value = TagType.DepositTooLarge ;
                    if (value == TagType.DepositTooLarge )
                    {
                        MessageBox.Show("DepositTooLarge..");
                    } 
                }
                else {
                     decimal depo = Convert.ToDecimal(transactionnumber.Text);
                    b.Deposit(depo);
                    textBox2.Text = b.GetAccountBalance().ToString();
                    textBox4.Text = "Transaction Successful";
                    strList.Add(b.GetAccountBalance().ToString());
                }

            }
            else if (radioButton2.Checked == true)
            {
                decimal balance1 = Convert.ToDecimal(-99);
                decimal balance = Convert.ToDecimal(textBox2.Text);
                decimal withdrawal = Convert.ToDecimal(transactionnumber.Text);
                decimal n = balance - withdrawal;
                decimal abs2 = Math.Abs(n);
                decimal abs1 = Math.Abs(-99);
                if (n < 0)
                {
                    if (abs2 < abs1)
                    {   //Negative Number
                        decimal d1 = withdrawal - 35;
                        //MessageBox.Show("Negtive number >: overdraft hapa" + d1);
                        b.Withdraw(d1);
                        textBox2.Text = b.displaybal().ToString();
                        textBox4.Text = "Transaction Successful";
                        strList.Add(b.GetAccountBalance().ToString());
                    }
                    else if (abs2 > abs1)
                    {
                        TagType value = TagType.Overdrawn;
                        if (value == TagType.Overdrawn)
                        {
                            MessageBox.Show("Your acoount is overdrawn please make a deposit!");
                        }
                    }
                }

                else if (n == 0)
                {  //MessageBox.Show("0!");
                    b.Withdraw(withdrawal);
                    textBox2.Text = b.displaybal().ToString();
                    textBox4.Text = "Transaction Successful";
                    strList.Add(b.GetAccountBalance().ToString());

                }
                else
                {  //MessageBox.Show("+ve!");
                    b.Withdraw(withdrawal);
                    textBox2.Text = b.displaybal().ToString();
                    textBox4.Text = "Transaction Successful";
                    strList.Add(b.GetAccountBalance().ToString());

                }

            }
            else {
                MessageBox.Show("Select either Withdrawal or Deposit");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
         

        }

        private void button3_Click(object sender, EventArgs e)
        {
            decimal a = b.GetAccountStatus();
             
            if (a < 0) {
                TagType value = TagType.Overdrawn;
                if (value == TagType.Overdrawn)
                {
                    MessageBox.Show("Your acoount is overdrawn please make a deposit!");
                } 
            } else  {
                TagType value = TagType.OK;
                if (value == TagType.OK)
                {
                    MessageBox.Show("Your acoount is not overdrawn");
                } 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("  ");
            for (int i = 0; i < strList.Count; i++)
                
                listBox1.Items.Add (strList[i]);
        }
    }
}
