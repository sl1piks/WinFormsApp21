namespace WinFormsApp21
{
    public partial class Form1 : Form
    {

        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        int count = 0;
        private void pictureBox9_Click(object sender, EventArgs e)
        {

            count++;
            label1.Text = "Count: " + count;
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            count = 0;
            label1.Text = "Count: " + count;
            pictureBox9.Location = new Point(336, 209);
            timer1.Stop();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Point[] positions = {
            new Point(pictureBox1.Location.X,pictureBox1.Location.Y),
            new Point(pictureBox2.Location.X,pictureBox2.Location.Y),
            new Point(pictureBox3.Location.X,pictureBox3.Location.Y),
            new Point(pictureBox4.Location.X,pictureBox4.Location.Y),
            new Point(pictureBox5.Location.X,pictureBox5.Location.Y),
            new Point(pictureBox6.Location.X,pictureBox6.Location.Y),
            new Point(pictureBox7.Location.X,pictureBox7.Location.Y),
            new Point(pictureBox8.Location.X,pictureBox8.Location.Y)};
            int index = random.Next(positions.Length);
            pictureBox9.Location = positions[index];
            
            
        }
    }
}
