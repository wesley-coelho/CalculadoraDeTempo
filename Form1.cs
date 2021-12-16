using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calcTime
{
    public partial class FrmCalcTime : Form
    {
        TimeSpan time = new TimeSpan(0,0,0);
        TimeSpan t1 = new TimeSpan(0,0,0);
        TimeSpan t2 = new TimeSpan(0,0,0);
        string valorDisplay = "";
        string operacao = "";
        

        int[] timeInt = { 0, 0, 0, 0, 0, 0 };


        public FrmCalcTime()
        {
            InitializeComponent();
            tbDisplay.Focus();

        }

        private void button19_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (tbDisplay.Text.Length == 8) tbDisplay.ResetText();
            if (tbDisplay.Text.Length < 8)
            {
                tbDisplay.AppendText(btn0.Text);
                tbDisplay.SelectionStart = tbDisplay.Text.Length;
            }
            
            if (tbDisplay.Text.Length == 2 || tbDisplay.Text.Length == 5)
            {
                tbDisplay.Text += ":";
                tbDisplay.SelectionStart = tbDisplay.Text.Length;
            }          
                
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (tbDisplay.Text.Length == 8) tbDisplay.ResetText();
            if (tbDisplay.Text.Length < 8)
            {
                tbDisplay.AppendText(btn1.Text);
                tbDisplay.SelectionStart = tbDisplay.Text.Length;
            }

            if (tbDisplay.Text.Length == 2 || tbDisplay.Text.Length == 5)
            {
                tbDisplay.Text += ":";
                tbDisplay.SelectionStart = tbDisplay.Text.Length;
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (tbDisplay.Text.Length == 8) tbDisplay.ResetText();
            if (tbDisplay.Text.Length < 8)
            {
                tbDisplay.AppendText(btn2.Text);
                tbDisplay.SelectionStart = tbDisplay.Text.Length;
            }

            if (tbDisplay.Text.Length == 2 || tbDisplay.Text.Length == 5)
            {
                tbDisplay.Text += ":";
                tbDisplay.SelectionStart = tbDisplay.Text.Length;
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (tbDisplay.Text.Length == 8) tbDisplay.ResetText();
            if (tbDisplay.Text.Length < 8)
            {
                tbDisplay.AppendText(btn3.Text);
                tbDisplay.SelectionStart = tbDisplay.Text.Length;
            }

            if (tbDisplay.Text.Length == 2 || tbDisplay.Text.Length == 5)
            {
                tbDisplay.Text += ":";
                tbDisplay.SelectionStart = tbDisplay.Text.Length;
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (tbDisplay.Text.Length == 8) tbDisplay.ResetText();
            if (tbDisplay.Text.Length < 8)
            {
                tbDisplay.AppendText(btn4.Text);
                tbDisplay.SelectionStart = tbDisplay.Text.Length;
            }

            if (tbDisplay.Text.Length == 2 || tbDisplay.Text.Length == 5)
            {
                tbDisplay.Text += ":";
                tbDisplay.SelectionStart = tbDisplay.Text.Length;
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (tbDisplay.Text.Length == 8) tbDisplay.ResetText();
            if (tbDisplay.Text.Length < 8)
            {
                tbDisplay.AppendText(btn5.Text);
                tbDisplay.SelectionStart = tbDisplay.Text.Length;
            }

            if (tbDisplay.Text.Length == 2 || tbDisplay.Text.Length == 5)
            {
                tbDisplay.Text += ":";
                tbDisplay.SelectionStart = tbDisplay.Text.Length;
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (tbDisplay.Text.Length == 8) tbDisplay.ResetText();
            if (tbDisplay.Text.Length < 8)
            {
                tbDisplay.AppendText(btn6.Text);
                tbDisplay.SelectionStart = tbDisplay.Text.Length;
            }

            if (tbDisplay.Text.Length == 2 || tbDisplay.Text.Length == 5)
            {
                tbDisplay.Text += ":";
                tbDisplay.SelectionStart = tbDisplay.Text.Length;
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (tbDisplay.Text.Length == 8) tbDisplay.ResetText();
            if (tbDisplay.Text.Length < 8)
            {
                tbDisplay.AppendText(btn7.Text);
                tbDisplay.SelectionStart = tbDisplay.Text.Length;
            }

            if (tbDisplay.Text.Length == 2 || tbDisplay.Text.Length == 5)
            {
                tbDisplay.Text += ":";
                tbDisplay.SelectionStart = tbDisplay.Text.Length;
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (tbDisplay.Text.Length == 8) tbDisplay.ResetText();
            if (tbDisplay.Text.Length < 8)
            {
                tbDisplay.AppendText(btn8.Text);
                tbDisplay.SelectionStart = tbDisplay.Text.Length;
            }

            if (tbDisplay.Text.Length == 2 || tbDisplay.Text.Length == 5)
            {
                tbDisplay.Text += ":";
                tbDisplay.SelectionStart = tbDisplay.Text.Length;
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (tbDisplay.Text.Length == 8) tbDisplay.ResetText();
            if (tbDisplay.Text.Length < 8)
            {
                tbDisplay.AppendText(btn9.Text);
                tbDisplay.SelectionStart = tbDisplay.Text.Length;
            }

            if (tbDisplay.Text.Length == 2 || tbDisplay.Text.Length == 5)
            {
                tbDisplay.Text += ":";
                tbDisplay.SelectionStart = tbDisplay.Text.Length;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            time = time.Subtract(time);
            t1 = t1.Subtract(t1);
            t2 = t2.Subtract(t2);
            lblMemory.ResetText();
            tbDisplay.Clear();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbDisplay.Text.Length > 0 && tbDisplay.Text != "ERROR")
            {
                tbDisplay.Text = tbDisplay.Text.Remove(tbDisplay.Text.Length - 1);
                tbDisplay.SelectionStart = tbDisplay.Text.Length;
            }
            
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            char[] parcela = new char[6];

            if (operacao == "igual")
            {
                parcela = this.tbDisplay.Text.Replace(":", "").ToCharArray();
                for (int i = 0; i < parcela.Length; i++)
                    timeInt[i] = int.Parse(parcela[i].ToString());
                TimeSpan auxTime =
                new TimeSpan(
                int.Parse(string.Concat(timeInt[0].ToString(), timeInt[1].ToString())),
                int.Parse(string.Concat(timeInt[2].ToString(), timeInt[3].ToString())),
                int.Parse(string.Concat(timeInt[4].ToString(), timeInt[5].ToString()))
                );

                t1 = auxTime;
                t2 = t2.Subtract(t2);
                lblMemory.Text = auxTime.ToString() + " + ";
                operacao = "soma";
                return;
            }


            if (tbDisplay.Text.Replace(":","").Length == 6 && valorDisplay != "" )
            { 
                    parcela = this.valorDisplay.Replace(":", "").ToCharArray();
                    for (int i = 0; i < parcela.Length; i++)
                       timeInt[i] = int.Parse(parcela[i].ToString());
                TimeSpan auxTime = 
                new TimeSpan(
                int.Parse(string.Concat(timeInt[0].ToString(), timeInt[1].ToString())),
                int.Parse(string.Concat(timeInt[2].ToString(), timeInt[3].ToString())),
                int.Parse(string.Concat(timeInt[4].ToString(), timeInt[5].ToString()))
                );
                
                
                if (t1.ToString() != "00:00:00")
                {
                     if(t2.ToString() == "00:00:00")
                     {
                         t2 = auxTime;
                         time = t1 + t2;
                     }
                     else
                     {

                        if(operacao == "subtracao")t1 = t1 - t2;
                        if (operacao == "soma") t1 = t1 + t2;
                        t2 = auxTime;
                        time = t1 + t2;
                     }
                }
                else 
                {                
                       t1 = auxTime;
                       time = t1;
                }
                
                 
                      if(time.Days > 0)
                      {
                          tbDisplay.Text = "ERROR";
                          lblMemory.Text = "";
                          time = time.Subtract(time);
                          return;

                      }
                lblMemory.Text = time + " +";
                tbDisplay.Text = time.ToString();
                valorDisplay = "";
                operacao = "soma";

            }
           
            lblMemory.Text = lblMemory.Text.Replace("-", "+");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            lblMemory.Text = "";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
         
            if (t1.ToString() != "00:00:00"  && lblMemory.Text.Contains("+"))
            {
                //t1 = t1 + t2;
                t2 = TimeSpan.Parse(tbDisplay.Text);
                lblMemory.Text = time.ToString() + " + " + t2.ToString() + " = " + (time + t2).ToString();
                time = time + t2;
                tbDisplay.Text = time.ToString();
                valorDisplay = "";
                operacao = "igual";
                tbDisplay.SelectionStart = tbDisplay.Text.Length;
            }
            if (t1.ToString() != "00:00:00" && lblMemory.Text.Contains("-"))
            {
                //t1 = t1 + t2;
                t2 = TimeSpan.Parse(tbDisplay.Text);
                lblMemory.Text = time.ToString() + " - " + t2.ToString() + " = " + (time - t2).ToString();
                time = time - t2;
                tbDisplay.Text = time.ToString();
                valorDisplay = "";
                operacao = "igual";
                tbDisplay.SelectionStart = tbDisplay.Text.Length;
            }


        }

        private void tbDisplay_TextChanged(object sender, EventArgs e)
        {
            this.valorDisplay = tbDisplay.Text;
          
        }

        private void lblMemory_TextChanged(object sender, EventArgs e)
        {
            lblMemory.SelectionStart = lblMemory.Text.Length;
        }

        private void btnSub_Click(object sender, EventArgs e)
        {

            char[] parcela = new char[6];

            if (operacao == "igual")
            {
                parcela = this.tbDisplay.Text.Replace(":", "").ToCharArray();
                for (int i = 0; i < parcela.Length; i++)
                    timeInt[i] = int.Parse(parcela[i].ToString());
                TimeSpan auxTime =
                new TimeSpan(
                int.Parse(string.Concat(timeInt[0].ToString(), timeInt[1].ToString())),
                int.Parse(string.Concat(timeInt[2].ToString(), timeInt[3].ToString())),
                int.Parse(string.Concat(timeInt[4].ToString(), timeInt[5].ToString()))
                );

                t1 = auxTime;
                t2 = t2.Subtract(t2);
                lblMemory.Text = auxTime.ToString() + " - ";
                operacao = "subtracao";
                return;
            }

            if (tbDisplay.Text.Replace(":", "").Length == 6 && this.valorDisplay != "")
            {
                parcela = this.valorDisplay.Replace(":", "").ToCharArray();
                for (int i = 0; i < parcela.Length; i++)
                    timeInt[i] = int.Parse(parcela[i].ToString());
                TimeSpan auxTime =
                new TimeSpan(
                int.Parse(string.Concat(timeInt[0].ToString(), timeInt[1].ToString())),
                int.Parse(string.Concat(timeInt[2].ToString(), timeInt[3].ToString())),
                int.Parse(string.Concat(timeInt[4].ToString(), timeInt[5].ToString()))
                );


                if (t1.ToString() != "00:00:00")
                {
                    if (t2.ToString() == "00:00:00")
                    {
                        t2 = auxTime;
                        time = t1 - t2;
                    }
                    else
                    {
                        if (operacao == "subtracao") t1 = t1 - t2;
                        if (operacao == "soma") t1 = t1 + t2;
                        t2 = auxTime;
                        time = t1 - t2;
                    }
                }
                else
                {
                    t1 = auxTime;
                    time = t1;
                }


                if (time.Days > 0)
                {
                    tbDisplay.Text = "ERROR";
                    lblMemory.Text = "";
                    time = time.Subtract(time);
                    return;

                }
                lblMemory.Text = time + " -";
                tbDisplay.Text = time.ToString();
                valorDisplay = "";
                operacao = "subtracao";

            }

           
            lblMemory.Text = lblMemory.Text.Replace("+", "-");


        }

        private void tbDisplay_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.NumPad0)
                btn0.PerformClick();
            if (e.KeyData == Keys.NumPad1)
                btn1.PerformClick();
            if (e.KeyData == Keys.NumPad2)
                btn2.PerformClick();
            if (e.KeyData == Keys.NumPad3)
                btn3.PerformClick();
            if (e.KeyData == Keys.NumPad4)
                btn4.PerformClick();
            if (e.KeyData == Keys.NumPad5)
                btn5.PerformClick();
            if (e.KeyData == Keys.NumPad6)
                btn6.PerformClick();
            if (e.KeyData == Keys.NumPad7)
                btn7.PerformClick();
            if (e.KeyData == Keys.NumPad8)
                btn8.PerformClick();
            if (e.KeyData == Keys.NumPad9)
                btn9.PerformClick();
            if (e.KeyData == Keys.Enter)
                btnIgual.PerformClick();
            if (e.KeyData == Keys.Add)
                btnSoma.PerformClick();
            if (e.KeyData == Keys.Subtract)
                btnSub.PerformClick();
            if (e.KeyData == Keys.Back)
                button1.PerformClick();
            if (e.KeyData == Keys.Delete)
                button2.PerformClick();
        }

        private void FrmCalcTime_Load(object sender, EventArgs e)
        {
            tbDisplay.Enabled = true;
            tbDisplay.SelectAll();
            tbDisplay.Focus();

        }

        private void FrmCalcTime_Activated(object sender, EventArgs e)
        {
            tbDisplay.SelectionStart = 0;
            tbDisplay.Focus();
        }
    }
}
