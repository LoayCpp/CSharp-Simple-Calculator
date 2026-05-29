using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private double firstNumber;
        private double lastNumber;
       
      enum enOperation
        {
            Sum=1,
            Minus,
            Multiply,
            Divide
        };
        enOperation operation;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtWrite.Text))
            {

                return;
            }

            if (char.IsLetter(txtWrite.Text[0]) || char.IsSymbol(txtWrite.Text[0]) || char.IsPunctuation(txtWrite.Text[0]))
            {

                txtWrite.Clear();
                MessageBox.Show("You can`t write letter or symbol ");
            }
        }
        private void DarkMode()
        {
            picDarkMode.Hide();
            picLightMode.Show();
            this.BackColor = Color.FromArgb(5, 5, 7);
            txtWrite.BackColor = btn1.BackColor = btn2.BackColor =
                btn3.BackColor = btn4.BackColor = btn4.BackColor =
                 btn5.BackColor = btn6.BackColor = btn7.BackColor =
                  btn8.BackColor = btn9.BackColor = btnDot.BackColor =
                   btn0.BackColor = btnDelete.BackColor = btnClearLastNumber.BackColor = Color.FromArgb(44, 45, 47);
            btnClear.BackColor = Color.FromArgb(49, 43, 44);
            txtWrite.ForeColor = Color.White;
            lnkX.LinkColor = lnkGithub.LinkColor = lnkLinkedln.LinkColor = Color.White;
            btnDiv.BackColor = btnMalti.BackColor = btnMinus.BackColor = btnSum.BackColor =
                Color.FromArgb(42, 46, 51);
           
        }
        private void LightMode()
        {
            picLightMode.Hide();
            picDarkMode.Show();
            this.BackColor = Color.FromArgb(238, 243, 252);
            txtWrite.BackColor = btn1.BackColor = btn2.BackColor =
                btn3.BackColor = btn4.BackColor = btn4.BackColor =
                 btn5.BackColor = btn6.BackColor = btn7.BackColor =
                  btn8.BackColor = btn9.BackColor = btnDot.BackColor =
                   btn0.BackColor = btnDelete.BackColor = btnClearLastNumber.BackColor = Color.FromArgb(248, 248, 251);

            btnResult.BackColor = Color.FromArgb(33, 100, 234);
            btnDiv.BackColor = btnMalti.BackColor = btnMinus.BackColor = btnSum.BackColor =
                Color.FromArgb(233, 237, 250);
            txtWrite.ForeColor = btn1.ForeColor = btn2.ForeColor =
               btn3.ForeColor = btn4.ForeColor = btn4.ForeColor =
                btn5.ForeColor = btn6.ForeColor = btn7.ForeColor =
                 btn8.ForeColor = btn9.ForeColor = btnDot.ForeColor =
                  btn0.ForeColor = btnDelete.ForeColor = btnClearLastNumber.ForeColor = Color.Black;
            lnkX.LinkColor = lnkGithub.LinkColor = lnkLinkedln.LinkColor = Color.Black;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            DarkMode();
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        private void Number_Click(object sender,EventArgs e)
        {
            Button btn = (Button)sender;
            txtWrite.Text += btn.Text;



        }
       

       
       private void ConvertTextToNumber()
        {

            try
            {
                firstNumber = double.Parse(txtWrite.Text);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
            finally
            {
                txtWrite.Clear();
            }
        }
        private void btnSum_Click(object sender, EventArgs e)
        {
            ConvertTextToNumber();
                operation = enOperation.Sum;
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            try
            {
                lastNumber = double.Parse(txtWrite.Text);

                switch (operation)
                {
                    case enOperation.Sum:
                        txtWrite.Text = (firstNumber + lastNumber).ToString();
                        break;

                    case enOperation.Minus:
                        txtWrite.Text = (firstNumber - lastNumber).ToString();
                        break;

                    case enOperation.Multiply:
                        txtWrite.Text = (firstNumber * lastNumber).ToString();
                        break;
                    case enOperation.Divide:
                        if (lastNumber == 0)
                        {
                            MessageBox.Show("You Cant Divide by Zero ");
                            txtWrite.Clear();
                            return;
                        }
                        
                        txtWrite.Text = (firstNumber / lastNumber).ToString();
                        break;

                }
            }catch
            {

                MessageBox.Show("You cannot press the equal sign (=) until you enter values first.");

            }
            
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            ConvertTextToNumber();
           
            operation = enOperation.Divide;
            

        }

        private void btnMalti_Click(object sender, EventArgs e)
        {
            ConvertTextToNumber();
           
            operation = enOperation.Multiply;
            

        }

        private void btnMinus_Click(object sender, EventArgs e)
        {

            ConvertTextToNumber();

            operation = enOperation.Minus;

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtWrite.Clear();
        }

        private void btnClearLastNumber_Click(object sender, EventArgs e)
        {
            txtWrite.Text = "0";
            lastNumber = double.Parse(txtWrite.Text);
          

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (! (txtWrite.Text == ""))
            {
                txtWrite.Text = txtWrite.Text.Substring(0, txtWrite.Text.Length - 1);
            }
           
        }

        private void picLightMode_Click(object sender, EventArgs e)
        {
            LightMode();
        }

        private void picDarkMode_Click(object sender, EventArgs e)
        {
            DarkMode();
        }
     private void OpenLink(string Link)
        {

            Process.Start(new ProcessStartInfo { FileName = Link, UseShellExecute = true });

        }
       
        private void picX_Click(object sender, EventArgs e)
        {
            OpenLink("https://x.com/7lo_ay");
        }

        private void lnkX_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenLink("https://x.com/7lo_ay");
        }

        private void picLinkedln_Click(object sender, EventArgs e)
        {
            OpenLink("https://www.linkedin.com/in/luai-anwar");
        }

        private void lnkLinkedln_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenLink("https://www.linkedin.com/in/luai-anwar");
        }

        private void picGithub_Click(object sender, EventArgs e)
        {
            OpenLink("https://github.com/LoayCpp");
        }

        private void lnkGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenLink("https://github.com/LoayCpp");
        }

        private void Mouse_EnterCursor(object sender,EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.Cursor = Cursors.Hand;


        }
    }
}
