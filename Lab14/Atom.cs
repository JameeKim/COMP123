using System;

namespace COMP123.Lab14
{
    public class Atom
    {
        public string name;
        public string symbol;
        public int proton;
        public int neutron;
        public double weight;

        public Atom() { }

        public Atom(string name, int proton, int neutron, double weight, string symbol)
        {
            this.name = name;
            this.proton = proton;
            this.neutron = neutron;
            this.weight = weight;
            this.symbol = symbol;
        }

        public static Atom Parse(string objectData)
        {
            string[] data = objectData.Split(' ');
            if (data.Length != 5)
            {
                throw new RankException($"Expected a string of 5 fields, separated by a single space for each, but got {data.Length} fields instead");
            }
            int proton = Convert.ToInt32(data[1]);
            int neutron = Convert.ToInt32(data[2]);
            double weight = Convert.ToDouble(data[3]);
            return new Atom(data[0], proton, neutron, weight, data[4]);
        }

        public override string ToString()
        {
            return $"{proton} {symbol} ^({weight:F4}) _({neutron}) ({name})";
        }
    }
}
