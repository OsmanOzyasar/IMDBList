using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDBList
{
    public class Movies
    {
        public string Name { get; set; }

        private double _ımdbScore;
        public double ImdbScore 
        {
            get
            {
                return _ımdbScore;
            }
            set 
            {
                if (value < 0 || value > 10)
                {
                    Console.WriteLine("Puanlamayı 1 ile 10 arasında yapınız");
                }
                else
                {
                    _ımdbScore = value;
                }
            } 
        }

    }
}
