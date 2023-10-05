using System.Text;

namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputAlphabets = textBox1.Text;
            string inputNumbers =  textBox2.Text;

            StringBuilder alphanumericBuilder = new StringBuilder();

            foreach (char c in inputAlphabets)
            {
                if (char.IsLetter(c))
                    alphanumericBuilder.Append(c);
            }

            foreach (char c in inputNumbers)
            {
                if (char.IsDigit(c))
                    alphanumericBuilder.Append(c);
            }

            textBox3.Text = alphanumericBuilder.ToString();
        }
    }
    
}