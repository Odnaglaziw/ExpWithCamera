using ExpWithCamera.Characters;
using ExpWithCamera.Environment;
using ExpWithCamera.logic;
using System;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpWithCamera.logic
{
    internal class Game
    {
        private Form drawingPanel;
        GameObject[,] gameObjects;
        public Player player { get; private set; }
        private Camera camera;
        Timer timer;
        public Game(Form form)
        {
            drawingPanel = form;
            drawingPanel.KeyDown += Panel_KeyDown;
            drawingPanel.Paint += Panel_Paint;
            Init();
        }
        private void Init()
        {
            camera = new Camera(drawingPanel.Width, drawingPanel.Height);
            gameObjects = new GameObject[100, 100];
            player = new Player(new Point(drawingPanel.Width / 2, drawingPanel.Height / 2));
            for (int y = 0; y < gameObjects.GetLength(1); y++)
            {
                for (int x = 0; x < gameObjects.GetLength(0); x++)
                {
                    gameObjects[x,y] = new Grass(new Point(x, y));
                }
            }
            timer = new Timer();
            timer.Interval = 16;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            drawingPanel.Invalidate();
        }
        private void Panel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            camera.ApplyTransformation(g);
                foreach (var obj in gameObjects)
                {
                    obj.Draw(g);
                }
                player.Draw(g);
        }
        private void Panel_KeyDown(object sender, KeyEventArgs e)
        {
            player.HandleInput(e);
            camera.Update(player.Position);
        }
    }
}
