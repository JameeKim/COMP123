using System.Drawing;

namespace COMP123.Lab18
{
    /// <summary>
    /// Interface for objects that can be drawn
    /// </summary>
    public interface IDrawable
    {
        /// <summary>
        /// Draw this object using the given surface
        /// </summary>
        /// <param name="g">The surface to use</param>
        void Draw(Graphics g);
    }
}
