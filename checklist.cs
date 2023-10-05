namespace WinFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkedListBox1.Items.Add("Red");
            checkedListBox1.Items.Add("Green");
            checkedListBox1.Items.Add("Blue");
            checkedListBox1.Items.Add("Black");
            label1.Visible = true;



        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkedListBox1.SelectedItems.ToString()=="Red")
            {
                label1.BackColor = Color.Red;
            }
            if (checkedListBox1.SelectedItems.ToString() == "Green")
            {
                label1.BackColor = Color.Green;
            }
            if (checkedListBox1.SelectedItems.ToString() == "Blue")
            {
                label1.BackColor = Color.Blue;
            }
            if (checkedListBox1.SelectedItems.ToString() == "Black")
            {
                label1.BackColor = Color.Black;
            }
        }
    }
}