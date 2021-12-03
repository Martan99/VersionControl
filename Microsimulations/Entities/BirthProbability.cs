using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsimulations.Entities
{
    public class BirthProbability
    {
        public int Age { get; set; }
        public int KidsCount { get; set; }
        public double P { get; set; }

    }
}
