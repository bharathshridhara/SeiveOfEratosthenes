using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SieveOfEratosthenes.Interface
{
    public interface IFindPrimesInList
    {
        void PopulateList(int from, int to);
        List<int> FindPrimes();
    }
}
