namespace WinGrafSinLine
{
    public partial class Form1 : Form
    {
        public string DataA
        {
            get
            {
                return textBox1.Text;
            }
            set
            {
                textBox1.Text = value;
            }



        }
        public string DataB
        {
            get
            {
                return textBox2.Text;
            }
            set
            {
                textBox2.Text = value;
            }
        }

        public double a, b;

        public Form1()
        {
            InitializeComponent();
            a = 0.1;
            b = 0.04;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            double t = 0;
            Point p1, p2;
            int w = (int)panel1.Width;
            int h = (int)panel1.Height;
            int y = h / 2;

            for (int x = 0; x < w; x++)
            {
                p1 = new Point(x, y);

                t = Operation.SummSin(x, a, b);

                y = (int)(t * h / 5);
                y = y + h / 2;

                p2 = new Point(x, y);

                Graphics dc = e.Graphics;
                Pen p = new Pen(Color.Red, 1);

                dc.DrawLine(p, p1, p2);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                a = double.Parse(DataA);
                b = double.Parse(DataB);
                panel1.Refresh();
            }
            catch (Exception er)
            {
                MessageBox.Show("��� ���������� ����� �������� ������ �������� ������: \n" + er.Message, "������", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            edit editF = new edit();
            editF.Show(this);
        }
    }
}