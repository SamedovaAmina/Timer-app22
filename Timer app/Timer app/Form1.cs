namespace Timer_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int saniye = 180;
        int i = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            saniye = Convert.ToInt32(textBox1.Text);
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye--;
            if (saniye < 10000)
            {
                label4.Visible = true;
                label3.Visible = true;
                label2.Visible = true;
                label4.Text = (saniye / 60).ToString();
                label3.Text = (saniye % 60).ToString();
            }
                
            
            if (saniye == 0)
            {
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label4.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            timer1.Enabled = true;
        }
    }
    }
