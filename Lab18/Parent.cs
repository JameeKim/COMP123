using System.Drawing;

namespace COMP123.Lab18
{
    public abstract class Parent : IDrawable
    {
        /// <summary>
        /// The color of this object when drawn
        /// </summary>
        protected Color Color { get; }

        /// <summary>
        /// Whether this object should be filled inside when drawn
        /// </summary>
        protected bool Filled { get; }

        /// <summary>
        /// The AABB of this object when drawn
        /// </summary>
        protected Rectangle Rectangle { get; }

        /// <summary>
        /// Constructor with color, whether the shape is filled, and AABB
        /// </summary>
        /// <param name="color">Color of the drawn shape</param>
        /// <param name="filled">Whether the drawn shape is filled inside</param>
        /// <param name="rectangle">AABB of the drawn shape</param>
        public Parent(Color color, bool filled, Rectangle rectangle)
        {
            Color = color;
            Filled = filled;
            Rectangle = rectangle;
        }

        public abstract void Draw(Graphics g);
    }
}
