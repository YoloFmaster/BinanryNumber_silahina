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
            if (rd2.Checked)
            {
                int mod, rank = 1, number = Convert.ToInt32(txtInput.Text), binary = 0;
                while (number > 0)
                {
                    mod = number % 2;
                    number /= 2;
                    binary += mod * rank;
                    rank *= 10;
                }
                txtOutput.Text = Convert.ToString(binary);
            }        
            if (rd8.Checked)
            {
                int mod, rank = 1, number = Convert.ToInt32(txtInput.Text), binary = 0;
                while (number > 0)
                {
                    mod = number % 8;
                    number /= 8;
                    binary += mod * rank;
                    rank *= 10;
                }
                txtOutput.Text = Convert.ToString(binary);
            }
            if (rd16.Checked)
            {
                int mod, rank = 1, number = Convert.ToInt32(txtInput.Text), binary = 0;
                while (number > 0)
                {
                    mod = number % 2;
                    number /= 2;
                    binary += mod * rank;
                    rank *= 10;
                }
                txtOutput.Text = Convert.ToString(binary);
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