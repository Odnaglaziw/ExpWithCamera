using System.Drawing.Drawing2D;
using System.Drawing;
using System;

namespace ExpWithCamera
{
    struct Fov
    {
        public int Width;
        public int Height;
    }
    public class Camera
    {
        Fov fov;
        public Point Position { get; set; }
        public Camera(int screenWidth, int screenHeight)
        {
            fov = new Fov();
            fov.Width = screenWidth;
            fov.Height = screenHeight;
            Position = Point.Empty;
        }
        public void Update(Point target)
        {
            Position = new Point(target.X - fov.Width / 2, target.Y - fov.Height / 2);
            Position = new Point(Math.Min(Math.Max(0, Position.X), 200), Math.Min(Math.Max(0, Position.Y), 550));
        }
        public void ApplyTransformation(Graphics g)
        {
            g.TranslateTransform(-Position.X, -Position.Y);
        }
    }

}
