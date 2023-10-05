namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        private int attempts = 0;
        private const int maxAttempts = 3;

        // Arrays to store usernames and corresponding passwords
        private string[] usernames = { "user1", "user2", "user3" };
        private string[] passwords = { "pass1", "pass2", "pass3" };

        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string enteredUsername = textBox2.Text;
            string enteredPassword = textBox1.Text;

            bool isValidLogin = false;

            for (int i = 0; i < usernames.Length; i++)
            {
                if (enteredUsername == usernames[i] && enteredPassword == passwords[i])
                {
                    isValidLogin = true;
                    break;
                }
            }

            if (isValidLogin)
            {
                MessageBox.Show("Login successful!");
                Close();
            }
            else
            {
                attempts++;
                if (attempts < maxAttempts)
                {
                    MessageBox.Show($"Invalid login attempt. You have {maxAttempts - attempts} attempts remaining.");
                }
                else
                {
                    button1.Enabled = false;
                    MessageBox.Show("Invalid input. Maximum attempts reached.");
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }

}