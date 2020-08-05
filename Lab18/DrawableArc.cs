using System.Drawing;
using System.IO;

namespace COMP123.Lab18
{
    /// <summary>
    /// An arc shape
    /// </summary>
    public class DrawableArc : Parent, IWriteable
    {
        /// <summary>
        /// Angle at the starting point
        /// </summary>
        private float start;

        /// <summary>
        /// Angle at the ending point
        /// </summary>
        private float end;

        public DrawableArc(Color color, bool filled, Rectangle rectangle, float start, float end)
            : base(color, filled, rectangle)
        {
            this.start = start;
            this.end = end;
        }

        public override void Draw(Graphics g)
        {
            if (Filled)
            {
                SolidBrush brush = new SolidBrush(Color);
                g.FillPie(brush, Rectangle, start, end);
            }
            else
            {
                Pen pen = new Pen(Color);
                g.DrawArc(pen, Rectangle, start, end);
            }
        }

        public void Write(TextWriter writer)
        {
            writer.WriteLine(
                $"Arc(Color: {Color.ToKnownColor()}, Filled: {Filled}, AABB: {Rectangle}, StartAngle: {start}, EndAngle: {end})");
        }
    }
}
