using System.Diagnostics.Eventing.Reader;

namespace okr_lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public double balance = 0;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label8.Text = "ETH";
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label8.Text = "BTC";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            label8.Text = "SOL";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Успішно");
            if (double.TryParse(textBox2.Text, out double hryvnias))
            {
                balance += hryvnias;
                label_bal.Text = balance.ToString("Баланс USDT:" + "0.00");

            }
            else
            {
                MessageBox.Show("Некоректна сума у гривнях!", "Помилка");
            }
            textBox1.Clear();
            textBox2.Clear();

        }

        private void label_bal_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (label8.Text == "BTC")
            {
                if (decimal.TryParse(textBox1.Text, out decimal dollars))
                {
                    decimal hryvnias = dollars * 110000;
                    textBox2.Text = hryvnias.ToString("0.00");
                }
                else
                {
                    textBox2.Clear();
                }
            }
            else if (label8.Text == "ETH")
            {
                if (decimal.TryParse(textBox1.Text, out decimal dollars))
                {
                    decimal hryvnias = dollars * 3800;
                    textBox2.Text = hryvnias.ToString("0.00");
                }
                else
                {
                    textBox2.Clear();
                }
            }
            else if (label8.Text == "SOL")
            {
                if (decimal.TryParse(textBox1.Text, out decimal dollars))
                {
                    decimal hryvnias = dollars * 190;
                    textBox2.Text = hryvnias.ToString("0.00");
                }
                else
                {
                    textBox2.Clear();
                }
            }
        }





        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
          
            if (this.BackColor==Color.Black) {
                this.BackColor = Color.White;
                label1.ForeColor=Color.Black;
                label2.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
                label3.ForeColor = Color.Black;
                label4.ForeColor = Color.Black;
                label5.ForeColor = Color.Black;
                label6.ForeColor = Color.Black;
                label7.ForeColor = Color.Black;
                label8.ForeColor = Color.Black;
                label9.ForeColor = Color.Black;
                label10.ForeColor = Color.Black;
                label11.ForeColor = Color.Black;
                label12.ForeColor = Color.Black;
                label13.ForeColor = Color.Black;
                label14.ForeColor = Color.Black;
                label15.ForeColor = Color.Black;
                label_bal.ForeColor = Color.Black;
                
            }
            else  
            {
             this.BackColor= Color.Black;  
                label1.ForeColor = Color.White;
                label2.ForeColor = Color.White;
                label3.ForeColor = Color.White;
                label4.ForeColor = Color.White;
                label5.ForeColor = Color.White;
                label6.ForeColor = Color.White;
                label7.ForeColor = Color.White;
                label8.ForeColor = Color.White;
                label9.ForeColor = Color.White;
                label10.ForeColor = Color.White;
                label11.ForeColor = Color.White;
                label12.ForeColor = Color.White;
                label13.ForeColor = Color.White;
                label14.ForeColor = Color.White;
                label15.ForeColor = Color.White;
                label_bal.ForeColor = Color.White;
                
                    }
            }
        //11.11.2025
        //12.11.2025
    }
}
