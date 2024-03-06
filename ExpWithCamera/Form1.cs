using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExpWithCamera.logic;
namespace ExpWithCamera
{
    public partial class Form1 : Form
    {
        bool moved;
        bool opened;
        Game game;
        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            settings_panel.MouseEnter += async (s, e) =>
            {
                int end = 0;
                while (!opened && settings_panel.Location.Y < end)
                {
                    moved = true;
                    await Task.Delay(1);
                    int deltaY = Math.Abs(settings_panel.Location.Y - end) / 8;
                    if (deltaY < 1) deltaY = 1;
                    settings_panel.Location = new Point(settings_panel.Location.X, settings_panel.Location.Y + deltaY);
                    moved = false;
                }
                opened = true;
            };
            settings_panel.MouseLeave += async (s, e) =>
            {
                int start = -80;
                while (opened && settings_panel.Location.Y > start)
                {
                    moved = true;
                    await Task.Delay(1);
                    int deltaY = Math.Abs(settings_panel.Location.Y - start) / 8;
                    if (deltaY < 1) deltaY = 1;
                    settings_panel.Location = new Point(settings_panel.Location.X, settings_panel.Location.Y - deltaY);
                    moved = false;
                }
                opened = false;
            };
            Invalidated += Form1_Invalidated;
            game = new Game(this);
        }

        private void Form1_Invalidated(object sender, InvalidateEventArgs e)
        {
            position_label.Text = $"X = {game.player.Position.X/10}" +
                $"\nY = {game.player.Position.Y/10}";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        
        private void базовоеToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
