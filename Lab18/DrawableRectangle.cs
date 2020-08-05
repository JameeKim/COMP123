using System.Drawing;
using System.IO;

namespace COMP123.Lab18
{
    /// <summary>
    /// A rectangle shape
    /// </summary>
    public class DrawableRectangle : Parent, IWriteable
    {
        public DrawableRectangle(Color color, bool filled, Rectangle rectangle)
            : base(color, filled, rectangle) {}

        public override void Draw(Graphics g)
        {
            if (Filled)
            {
                SolidBrush brush = new SolidBrush(Color);
                g.FillRectangle(brush, Rectangle);
            }
            else
            {
                Pen pen = new Pen(Color);
                g.DrawRectangle(pen, Rectangle);
            }
        }

        public void Write(TextWriter writer)
        {
            writer.WriteLine(
                $"Rectangle(Color: {Color.ToKnownColor()}, Filled: {Filled}, AABB: {Rectangle})");
        }
    }
}
