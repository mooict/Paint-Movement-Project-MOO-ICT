namespace Paint_Movement_Project_MOO_ICT
{
    // Made by MOO ICT
    // For educational purpose only
    public partial class Form1 : Form
    {

        int positionX = 0;
        int positionY = 0;
        int speedY = 5;
        int speedX = 5;
        int height = 150;
        int width = 150;

        Image square;

        public Form1()
        {
            InitializeComponent();

            square = Properties.Resources.transparentSquare;
        }

        private void MovementTimerEvent(object sender, EventArgs e)
        {
            positionX += speedX;
            positionY += speedY;

            if (positionX + width > this.ClientSize.Width || positionX < 1)
            {
                speedX = -speedX;
            }
            else if (positionY + height > this.ClientSize.Height || positionY < 1)
            {
                speedY = -speedY;
            }


            this.Invalidate();
        }

        private void FormPaintEvent(object sender, PaintEventArgs e)
        {
            Graphics Canvas = e.Graphics;
            Canvas.DrawImage(square, positionX, positionY, width, height);
        }
    }
}