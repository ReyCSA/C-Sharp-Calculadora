using System;
using System.Drawing;
using System.Windows.Forms;

namespace RACSAcalculadora
{
    public partial class Form1 : Form
    {
        bool click = true;
        string accion;
        double x, y, total;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txb.Text == "0")
            {
                return;
            }
            else
            {
                txb.Text = txb.Text + "0";
            }
        }

        private void btn0_MouseEnter(object sender, EventArgs e)
        {
            this.btn0.BackColor = Color.Gold;
        }

        private void btn0_MouseLeave(object sender, EventArgs e)
        {
            this.btn0.BackColor = SystemColors.Control;
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            if (click)
            {
                txb.Text = "";
                txb.Text = "1";
                click = false;
            }
            else
            {
                txb.Text = txb.Text + "1";
            }
        }
        private void btn1_MouseEnter(object sender, EventArgs e)
        {
            this.btn1.BackColor = Color.Gold;
        }

        private void btn1_MouseLeave(object sender, EventArgs e)
        {
            this.btn1.BackColor = SystemColors.Control;
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            if (click)
            {
                txb.Text = "";
                txb.Text = "2";
                click = false;
            }
            else
            {
                txb.Text = txb.Text + "2";
            }
        }
        private void btn2_MouseEnter(object sender, EventArgs e)
        {
            this.btn2.BackColor = Color.Gold;
        }

        private void btn2_MouseLeave(object sender, EventArgs e)
        {
            this.btn2.BackColor = SystemColors.Control;
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            if (click)
            {
                txb.Text = "";
                txb.Text = "3";
                click = false;
            }
            else
            {
                txb.Text = txb.Text + "3";
            }
        }
        private void btn3_MouseEnter(object sender, EventArgs e)
        {
            this.btn3.BackColor = Color.Gold;
        }

        private void btn3_MouseLeave(object sender, EventArgs e)
        {
            this.btn3.BackColor = SystemColors.Control;
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            if (click)
            {
                txb.Text = "";
                txb.Text = "4";
                click = false;
            }
            else
            {
                txb.Text = txb.Text + "4";
            }
        }
        private void btn4_MouseEnter(object sender, EventArgs e)
        {
            this.btn4.BackColor = Color.Gold;
        }

        private void btn4_MouseLeave(object sender, EventArgs e)
        {
            this.btn4.BackColor = SystemColors.Control;
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            if (click)
            {
                txb.Text = "";
                txb.Text = "5";
                click = false;
            }
            else
            {
                txb.Text = txb.Text + "5";
            }
        }
        private void btn5_MouseEnter(object sender, EventArgs e)
        {
            this.btn5.BackColor = Color.Gold;
        }

        private void btn5_MouseLeave(object sender, EventArgs e)
        {
            this.btn5.BackColor = SystemColors.Control;
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            if (click)
            {
                txb.Text = "";
                txb.Text = "6";
                click = false;
            }
            else
            {
                txb.Text = txb.Text + "6";
            }
        }
        private void btn6_MouseEnter(object sender, EventArgs e)
        {
            this.btn6.BackColor = Color.Gold;
        }

        private void btn6_MouseLeave(object sender, EventArgs e)
        {
            this.btn6.BackColor = SystemColors.Control;
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            if (click)
            {
                txb.Text = "";
                txb.Text = "7";
                click = false;
            }
            else
            {
                txb.Text = txb.Text + "7";
            }
        }
        private void btn7_MouseEnter(object sender, EventArgs e)
        {
            this.btn7.BackColor = Color.Gold;
        }

        private void btn7_MouseLeave(object sender, EventArgs e)
        {
            this.btn7.BackColor = SystemColors.Control;
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            if (click)
            {
                txb.Text = "";
                txb.Text = "8";
                click = false;
            }
            else
            {
                txb.Text = txb.Text + "8";
            }
        }
        private void btn8_MouseEnter(object sender, EventArgs e)
        {
            this.btn8.BackColor = Color.Gold;
        }

        private void btn8_MouseLeave(object sender, EventArgs e)
        {
            this.btn8.BackColor = SystemColors.Control;
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            if (click)
            {
                txb.Text = "";
                txb.Text = "9";
                click = false;
            }
            else
            {
                txb.Text = txb.Text + "9";
            }
        }
        private void btn9_MouseEnter(object sender, EventArgs e)
        {
            this.btn9.BackColor = Color.Gold;
        }

        private void btn9_MouseLeave(object sender, EventArgs e)
        {
            this.btn9.BackColor = SystemColors.Control;
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            txb.Clear();
        }
        private void btnDel_MouseEnter(object sender, EventArgs e)
        {
            this.btnDel.BackColor = Color.Gold;
        }

        private void btnDel_MouseLeave(object sender, EventArgs e)
        {
            this.btnDel.BackColor = SystemColors.Control;
        }
        private void btnMas_Click(object sender, EventArgs e)
        {
            accion = "+";
            click = true;

            x = double.Parse(txb.Text);
        }
        private void btnMas_MouseEnter(object sender, EventArgs e)
        {
            this.btnMas.BackColor = Color.Gold;
        }

        private void btnMas_MouseLeave(object sender, EventArgs e)
        {
            this.btnMas.BackColor = SystemColors.Control;
        }
        private void btnMenos_Click(object sender, EventArgs e)
        {
            accion = "-";
            click = true;

            x = double.Parse(txb.Text);
        }
        private void btnMenos_MouseEnter(object sender, EventArgs e)
        {
            this.btnMenos.BackColor = Color.Gold;
        }

        private void btnMenos_MouseLeave(object sender, EventArgs e)
        {
            this.btnMenos.BackColor = SystemColors.Control;
        }
        private void btnMtp_Click(object sender, EventArgs e)
        {
            accion = "*";
            click = true;

            x = double.Parse(txb.Text);
        }
        private void btnMtp_MouseEnter(object sender, EventArgs e)
        {
            this.btnMtp.BackColor = Color.Gold;
        }

        private void btnMtp_MouseLeave(object sender, EventArgs e)
        {
            this.btnMtp.BackColor = SystemColors.Control;
        }
        private void btnDiv_Click(object sender, EventArgs e)
        {
            accion = "/";
            click = true;

            x = double.Parse(txb.Text);
        }
        private void btnDiv_MouseEnter(object sender, EventArgs e)
        {
            this.btnDiv.BackColor = Color.Gold;
        }

        private void btnDiv_MouseLeave(object sender, EventArgs e)
        {
            this.btnDiv.BackColor = SystemColors.Control;
        }
        private void btnIgual_Click(object sender, EventArgs e)
        {
            y = double.Parse(txb.Text);

            click = true;

            if (accion == "+")
            {
                total = x + y;
                txb.Text = total.ToString();
                click = true;
            }

            if (accion == "-")
            {
                total = x - y;
                txb.Text = total.ToString();
                click = true;
            }

            if (accion == "*")
            {
                total = x * y;
                txb.Text = total.ToString();
                click = true;
            }

            if (accion == "/")
            {
                total = x / y;
                txb.Text = total.ToString();
                click = true;
            }     
                   
        }
        private void btnIgual_MouseEnter(object sender, EventArgs e)
        {
            this.btnIgual.BackColor = Color.Gold;
        }


        private void btnIgual_MouseLeave(object sender, EventArgs e)
        {
            this.btnIgual.BackColor = SystemColors.Control;
        }
        private void txb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)))
            {
                e.Handled = true;
            }

            char tecla = e.KeyChar;

            switch (tecla)
            {
                case '+':
                    btnMas.PerformClick();
                    txb.Text = "";
                    this.btnMas.BackColor = Color.Gold;
                    break;
                case '-':
                    btnMenos.PerformClick();
                    txb.Text = "";
                    this.btnMas.BackColor = Color.Gold;
                    break;
                case '*':
                    btnMtp.PerformClick();
                    txb.Text = "";
                    this.btnMas.BackColor = Color.Gold;
                    break;
                case '/':
                    btnDiv.PerformClick();
                    txb.Text = "";
                    this.btnMas.BackColor = Color.Gold;
                    break;
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = false;
                btnIgual.PerformClick();
            }                
        }
    }
}
