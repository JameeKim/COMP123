namespace COMP123.Lab15.Library
{
    public class Fraction
    {
        public int Top { get; }
        public int Bottom { get; }

        public Fraction(int top = 0, int bottom = 1)
        {
            Top = top;
            Bottom = bottom;
        }

        public override string ToString()
        {
            return $"{Top} / {Bottom}";
        }

        public static Fraction operator +(Fraction lhs, Fraction rhs)
        {
            int top = lhs.Top * rhs.Bottom + lhs.Bottom * rhs.Top;
            int bottom = lhs.Bottom * rhs.Bottom;
            return new Fraction(top, bottom);
        }

        public static Fraction operator -(Fraction lhs, Fraction rhs)
        {
            int top = lhs.Top * rhs.Bottom - lhs.Bottom * rhs.Top;
            int bottom = lhs.Bottom * rhs.Bottom;
            return new Fraction(top, bottom);
        }
    }
}
