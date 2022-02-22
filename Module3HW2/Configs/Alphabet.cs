using System.Collections.Generic;

namespace Module3HW2.Models
{
    public class Alphabet
    {
        public Alphabet()
        {
            Alphabets = new Dictionary<string, string>();
        }

        public Dictionary<string, string> Alphabets { get; set; }
    }
}
