using System.Drawing;
using System.IO;

namespace COMP123.Lab18
{
    /// <summary>
    /// A Bezier curve
    /// </summary>
    public class DrawableBezier : IDrawable, IWriteable
    {
        /// <summary>
        /// Color of the curve
        /// </summary>
        private Color color;

        /// <summary>
        /// Start point of the curve
        /// </summary>
        private Point start;

        /// <summary>
        /// First control point of the curve
        /// </summary>
        private Point first;

        /// <summary>
        /// Second control point of the curve
        /// </summary>
        private Point second;

        /// <summary>
        /// End point of the curve
        /// </summary>
        private Point end;

        public DrawableBezier(Color color, Point start, Point first, Point second, Point end)
        {
            this.color = color;
            this.start = start;
            this.first = first;
            this.second = second;
            this.end = end;
        }

        public void Draw(Graphics g)
        {
            Pen pen = new Pen(color);
            g.DrawBezier(pen, start, first, second, end);
        }

        public void Write(TextWriter writer)
        {
            writer.WriteLine(
                $"Bezier(Color: {color.ToKnownColor()}, Start: {start}, First: {first}, Second: {second}, End: {end})");
        }
    }
}
