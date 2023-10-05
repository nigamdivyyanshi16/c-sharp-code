namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private bool IsPalindrome(string text)
        {
            text = text.ToLower().Replace(" ", ""); // Convert to lowercase and remove spaces
            return text.SequenceEqual(text.Reverse());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputText = textBox1.Text;
            string[] words = inputText.Split(new[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            int palindromeCount = 0;
            string palindromeWords = "";

            foreach (string word in words)
            {
                if (IsPalindrome(word))
                {
                    palindromeCount++;
                    palindromeWords += word + " ";
                }
            }

            textBox2.Text = palindromeWords.Trim();
            textBox3.Text = palindromeCount.ToString();
        }
    }
}
