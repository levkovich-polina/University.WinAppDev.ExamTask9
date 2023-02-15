using Timer = System.Threading.Timer;

namespace Task9
{
    public partial class Form1 : Form
    {
        Color[,] _squareColors = new Color[4, 4];
        Random _random = new Random();
        private Timer _timer;
        List<Color> _selectedColors = new List<Color>();

        public Form1()
        {
            InitializeComponent();
            PlayButton.Enabled = false;
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Color randomColor = Color.FromArgb(_random.Next(255), _random.Next(255), _random.Next(255), _random.Next(255));
                    _squareColors[i, j] = randomColor;
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
                    g.FillRectangle(new SolidBrush(_squareColors[i, j]), x, y, width / 4, height / 4);
                }
            }
        }
        
        private void Panel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                PlayButton.Enabled = true;
                var rowIndex = e.Location.X / (Panel.ClientSize.Width / 4);
                var columnIndex = e.Location.Y / (Panel.ClientSize.Height / 4);
                var selectedColor = _squareColors[rowIndex, columnIndex];
                _selectedColors.Add(selectedColor);
                ColorListBox.Items.Add(selectedColor);
            }
        }
    }
}

