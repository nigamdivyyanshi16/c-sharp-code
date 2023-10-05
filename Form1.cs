namespace WinFormsApp3
{
    public partial class frmLogin : Form
    {
    
        public frmLogin()
        {

            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.PeachPuff;
            //this.Text = "NPGC"+System.DateTime.Now.ToString();
            //this.Text=System.DateOnly.MaxValue.ToString();
            //this.Text=System.Single.MinValue.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a=Convert.ToInt32(textBox1.Text);
            b=Convert.ToInt32(textBox2.Text);
            c = a + b;
            MessageBox.Show(c.ToString());
        }
    }
}