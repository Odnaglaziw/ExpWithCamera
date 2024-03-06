using System.Drawing;
using System.Windows.Forms;

namespace ExpWithCamera.logic
{
    internal interface IUpdateable
    {
        void Update();
        void Draw(Graphics g);
        void HandleInput(KeyEventArgs e);
        Point Position { get; set; }
    }
}
