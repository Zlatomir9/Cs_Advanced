using System;
using System.Collections.Generic;
using System.Text;

namespace Tuple
{
    public class Tuple<Tfirst, Tsecond>
    {
        public Tuple(Tfirst item1, Tsecond item2)
        {
            Item1 = item1;
            Item2 = item2;
        }

        public Tfirst Item1 { get; set; }
        public Tsecond Item2 { get; set; }

        public override string ToString()
        {
            return $"{Item1} -> {Item2}";
        }
    }
}
