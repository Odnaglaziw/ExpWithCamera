using ExpWithCamera.logic;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpWithCamera.Characters
{
    internal class Player : GameObject, IUpdateable
    {
        private Bitmap TextureCalm,Texture;
        int Speed = 5,animI = 0;
        bool moved;
        Bitmap[] animate = new Bitmap[2];
        public Player(Point position) : base(position)
        {
            //Timer anim = new Timer();
            //anim.Interval = 1;
            //anim.Tick += Anim_Tick;
            //anim.Start();
            TextureCalm = new Bitmap(20, 50);
            using (Graphics g = Graphics.FromImage(TextureCalm))
            {
                SolidBrush brush = new SolidBrush(Color.Blue);
                g.FillEllipse(brush, 20 / 2 - 5, 0, 10, 10);
                g.FillRectangle(brush, 20 / 2 - 3, 10, 6, 10);
                //ноги
                g.FillRectangle(brush, 20 / 2 - 3, 20, 2, 10);
                g.FillRectangle(brush, 22 / 2, 20, 2, 10);

                g.FillRectangle(brush, 20 / 2 - 8, 10, 3, 7);
                g.FillRectangle(brush, 20 / 2 + 5, 10, 3, 7);
            }
            Texture = TextureCalm;
            animate[0] = new Bitmap(20, 50);
            using (Graphics g = Graphics.FromImage(animate[0]))
            {
                SolidBrush brush = new SolidBrush(Color.Blue);
                g.FillEllipse(brush, 20 / 2 - 5, 0, 10, 10);
                g.FillRectangle(brush, 20 / 2 - 3, 10, 6, 10);
                //ноги
                g.FillRectangle(brush, 20 / 2 - 3, 20, 2, 10);
                g.FillRectangle(brush, 22 / 2, 20, 2, 5);

                g.FillRectangle(brush, 20 / 2 - 8, 10, 3, 7);
                g.FillRectangle(brush, 20 / 2 + 5, 10, 3, 7);
            }
            animate[1] = new Bitmap(20, 50);
            using (Graphics g = Graphics.FromImage(animate[1]))
            {
                SolidBrush brush = new SolidBrush(Color.Blue);
                g.FillEllipse(brush, 20 / 2 - 5, 0, 10, 10);
                g.FillRectangle(brush, 20 / 2 - 3, 10, 6, 10);
                //ноги
                g.FillRectangle(brush, 20 / 2 - 3, 20, 2, 5);
                g.FillRectangle(brush, 22 / 2, 20, 2, 10);

                g.FillRectangle(brush, 20 / 2 - 8, 10, 3, 7);
                g.FillRectangle(brush, 20 / 2 + 5, 10, 3, 7);
            }
        }

        private async void Anim_Tick()
        {
            while (moved)
            {
                if (animI%10 <= 5)
                Texture = animate[1];
                else Texture = animate[0];
                await Task.Delay(10);
            }
            Texture = TextureCalm;
        }

        public void Update()
        {
            //скины для матвея в будущем
        }

        public override void Draw(Graphics g)
        {
            g.DrawImage(Texture,Position.X-Texture.Width/2, Position.Y - Texture.Height/2);
        }

        public void HandleInput(KeyEventArgs e)
        {
            moved = true;
            animI++;
            Anim_Tick();
            if (e.KeyCode == Keys.Left)
            {
                Position = new Point(Position.X - Speed, Position.Y);
            }
            else if (e.KeyCode == Keys.Right)
            {
                Position = new Point(Position.X + Speed, Position.Y);
            }
            else if (e.KeyCode == Keys.Up)
            {
                Position = new Point(Position.X, Position.Y - Speed);
            }
            else if (e.KeyCode == Keys.Down)
            {
                Position = new Point(Position.X, Position.Y + Speed);
            }
            Position = new Point(Math.Min(Math.Max(TextureCalm.Width / 2, Position.X),1000-TextureCalm.Width/2), Math.Min(Math.Max(TextureCalm.Height / 2, Position.Y),1000 - 6));
            moved = false;
        }
    }
}
