using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FindPrimes.Services;
using SieveOfEratosthenes;
using SieveOfEratosthenes.Interface;

namespace FindPrimes.Models
{
    class PrimeNumberModel : IPrimesFinderService
    {
        public List<int> FindPrimes(int from, int to)
        {
            IFindPrimesInList PrimeList = new SieveOfEratosthenes.SieveOfEratosthenes();
            PrimeList.PopulateList(from, to);
            return  PrimeList.FindPrimes();
        }
    }
}
