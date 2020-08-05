using System.Drawing;
using System.IO;

namespace COMP123.Lab18
{
    /// <summary>
    /// A solid line
    /// </summary>
    public class DrawableLine : IDrawable, IWriteable
    {
        /// <summary>
        /// The color of this line
        /// </summary>
        private Color color;

        /// <summary>
        /// Where the line should start
        /// </summary>
        private Point start;

        /// <summary>
        /// Where the line should end
        /// </summary>
        private Point end;

        public DrawableLine(Color color, Point start, Point end)
        {
            this.color = color;
            this.start = start;
            this.end = end;
        }

        public void Draw(Graphics g)
        {
            Pen pen = new Pen(color);
            g.DrawLine(pen, start, end);
        }

        public void Write(TextWriter writer)
        {
            writer.WriteLine($"Line(Color: {color.ToKnownColor()}, Start: {start}, End: {end})");
        }
    }
}
