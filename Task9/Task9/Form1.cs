using Timer = System.Threading.Timer;

namespace Task9
{
    public partial class Form1 : Form
    {
        Brush[,] _colorOfTheSquare = new Brush[4, 4];
        Random _random = new Random();
        private Timer _timer;
        Brush _randomColor;
        List<Point> _selectedSquares = new List<Point>;
        public Form1()
        {
            InitializeComponent();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    _randomColor = new SolidBrush(Color.FromArgb(_random.Next(255), _random.Next(255), _random.Next(255), _random.Next(255)));
                    _colorOfTheSquare[i, j] = _randomColor;
                }
            }
            Draw();
        }
        private void Draw()
        {
            Graphics g = Panel.CreateGraphics();
            int width = Panel.ClientSize.Width;
            int height = Panel.ClientSize.Height;
            int x = 0;
            int y = 0;
            for (int i = 0; i < 4; i++)
            {
                x = width / 4 * i;
                for (int j = 0; j < 4; j++)
                {
                    y = height / 4 * j;
                    g.FillRectangle(_colorOfTheSquare[i, j], x, y, width / 4, height / 4);
                }
                y = 0;
            }
        }
    }
}

