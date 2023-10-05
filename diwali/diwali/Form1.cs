namespace diwali
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            timer3.Enabled = false;
            timer4.Enabled = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timer1.Interval <= 1000)
            {
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                timer1.Enabled = false;
                timer2.Enabled = true;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (timer2.Interval <= 1000)
            {
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                timer2.Enabled = false;
                timer3.Enabled = true;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (timer3.Interval <= 1000)
            {
                label7.Visible = true;
                label8.Visible = true;
                label9.Visible = true;
                timer3.Enabled = false;
                timer4.Enabled = true;
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (timer4.Interval <= 1000)
            {
                label10.Visible = true;
                label11.Visible = true;
                label12.Visible = true;
                timer4.Enabled = false;
                timer1.Enabled = true;
            }
        }

    }
}