namespace Ships
{

        
    public partial class Form1 : Form
    {
        Random rand = new Random();
        bool[,] board = new bool[10, 10];

        Ship[] ships = new Ship[1];

        public Form1()
        {
            InitializeComponent();

            ships[0] = new Ship(3, 5, 4, 0);
        }


        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;


            for (int i = 0; i <= 10; i++)
            {
                g.DrawLine(Pens.Black, -500, 50 * i, 500, 50 * i);
            }

            for (int i = 0; i <= 10; i++)
            {
                g.DrawLine(Pens.Black, 50 * i, -500, 50 * i, 500);
            }

            
            for (int i=0; i<ships.Length; i++)
            {
                g.DrawRectangle(Pens.Red, ships[i].X*50, ships[i].Y*50 , 200, 50);
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;

            board[x / 50, y / 50] = true;

            pictureBox2.Invalidate();

        }

    }
}