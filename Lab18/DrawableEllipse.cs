using System.Drawing;
using System.IO;

namespace COMP123.Lab18
{
    /// <summary>
    /// An ellipse shape
    /// </summary>
    public class DrawableEllipse : Parent, IWriteable
    {
        public DrawableEllipse(Color color, bool filled, Rectangle rectangle)
            : base(color, filled, rectangle) {}

        public override void Draw(Graphics g)
        {
            if (Filled)
            {
                SolidBrush brush = new SolidBrush(Color);
                g.FillEllipse(brush, Rectangle);
            }
            else
            {
                Pen pen = new Pen(Color);
                g.DrawEllipse(pen, Rectangle);
            }
        }

        public void Write(TextWriter writer)
        {
            writer.WriteLine(
                $"Ellipse(Color: {Color.ToKnownColor()}, Filled: {Filled}, AABB: {Rectangle})");
        }
    }
}
