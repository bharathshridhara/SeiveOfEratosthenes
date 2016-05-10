using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindPrimes.Services
{
    interface IPrimesFinderService
    {
        List<int> FindPrimes(int from, int to);
    }
}
