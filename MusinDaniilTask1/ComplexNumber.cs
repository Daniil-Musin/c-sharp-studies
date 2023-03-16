


namespace MusinDaniilTask1
{
    public struct Complex
    {
        public readonly double Re;
        public readonly double Im;
        public readonly double Abs;

        public Complex(double re = 0, double im = 0)
        {

            Re = re;
            Im = im;
            Abs = Math.Sqrt((re * re) + (im * im));
        }
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
        public override bool Equals(object obj)
        {
            if (obj is Complex)
            {
                return Re == ((Complex)obj).Re & Im == ((Complex)obj).Im;
            }

            throw new ArgumentException("Объект для сравнения не является комплексным числом");

        }
        public static bool operator ==(Complex lhs, Complex rhs)
        {
            return lhs.Equals(rhs);
        }
        public static bool operator !=(Complex lhs, Complex rhs)
        {
            return !(lhs.Equals(rhs));
        }

        public static Complex operator +(Complex lhs, Complex rhs)
        {
            return new Complex(lhs.Re + rhs.Re, lhs.Im + rhs.Im);
        }

        public static Complex operator -(Complex lhs, Complex rhs)
        {
            return new Complex(lhs.Re - rhs.Re, lhs.Im - rhs.Im);
        }

        public override string ToString()
        {
            string a = Re == 0 ? "" : Re.ToString();
            string b = (Im == 0) | (Im == 1.0) ? ""
                : Im == -1.0 ? "-"
                    : Im.ToString();
            if (a == "" & b == "")
            {
                return "0";
            }
            string sign = Im <= 0 ? "" // если b с минусом или ноль, то отдельно отрисовывать знак не нужно
                : a == "" ? "" // если a не отрисовывается, то и плюс перед b отрисовывать не нужно
                    : "+"; // во всех остальных случаях рисуем плюс
            string i = b == "" ? "" : "i";
            return $"{a}{sign}{b}{i}";
        }
    }
}


