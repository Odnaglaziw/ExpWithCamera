using System.Drawing;
using System.Windows.Forms;
namespace ExpWithCamera.logic
{
    //xexe
    internal abstract class GameObject
    {
        public Point Position { get; set; }

        protected GameObject(Point position)
        {
            Position = position;
        }
        public abstract void Draw(Graphics g);
    }
}
