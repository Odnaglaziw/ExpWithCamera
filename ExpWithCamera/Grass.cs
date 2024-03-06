using ExpWithCamera.logic;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpWithCamera.Environment
{
    internal class Grass : GameObject
    {
        private Color _color;
        public Grass(Point position) : base(position)
        {
            _color = GetColor();
        }
        public override void Draw(Graphics g)
        {
            g.FillRectangle(new SolidBrush(_color),Position.X*10,Position.Y*10,10,10);
        }
        private Color GetColor()
        {
            return Color.FromArgb(new Random().Next(0,20), MyRandom.Next(100,120), new Random().Next(0, 1));
        }
    }
}
