namespace BinanryNumber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox_number_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
                e.Handled = true;
        }
        private void txtInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            txtOutput.Text = string.Empty;
            int mod, rank = 1, number = Convert.ToInt32(txtInput.Text), binary = 0;
            int ss = 0;
            if (rd2.Checked) ss = 2;
            if (rd8.Checked) ss = 8;
            if (rd16.Checked) ss = 16;
            while (number > 0)
            {
                mod = number % ss;
                number /= ss;
                binary += mod * rank;
                rank *= 10;
                switch (mod)
                {
                    case 10:
                        txtOutput.Text += 'A';
                        break;
                    case 11:
                        txtOutput.Text += 'B';
                        break;
                    case 12:
                        txtOutput.Text += 'C';
                        break;
                    case 13:
                        txtOutput.Text += 'D';
                        break;
                    case 14:
                        txtOutput.Text += 'E';
                        break;
                    case 15:
                        txtOutput.Text += 'F';
                        break;
                    default:
                        txtOutput.Text += Convert.ToString(binary);
                        break;
                }
            }
        }

        private void btnRandomNumber_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int chislo = rnd.Next(0, 255);
            txtInput.Text = Convert.ToString(chislo);
        }
    }
}