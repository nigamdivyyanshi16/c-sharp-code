namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            timer2.Enabled = false;
            timer3.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timer1.Interval <= 1000)
            {
                label1.Visible = true;
                timer2.Enabled = true;
                timer3.Enabled = false;
                timer1.Enabled = false;
                label2.Visible = false;
                label3.Visible = false;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (timer2.Interval <= 1000)
            {
                label1.Visible = false;
                timer2.Enabled = false;
                timer3.Enabled = true;
                timer1.Enabled = false;
                label2.Visible = true;
                label3.Visible = false;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (timer3.Interval <= 1000)
            {
                label1.Visible = false;
                timer2.Enabled = false;
                timer3.Enabled = false;
                timer1.Enabled = true;
                label2.Visible = false;
                label3.Visible = true;
            }
        }
    }
}
