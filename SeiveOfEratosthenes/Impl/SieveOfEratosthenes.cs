using SieveOfEratosthenes.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SieveOfEratosthenes
{
    public class SieveOfEratosthenes : Interface.IFindPrimesInList
    {
        public List<int> _numbersList;

        public SieveOfEratosthenes()
        {

        }

        /// <summary>
        /// Populates the values in the range to the list
        /// </summary>
        /// <param name="from">Starting value</param>
        /// <param name="to">Ending value</param>
        public virtual int PopulateList(int from, int to)
        {
            if (from >= to)
                throw new RangeInvalidException("Begin value is equal to or more than End value");

            _numbersList = new List<int>();
            for (int i = from; i <= to; i++)
            {
                _numbersList.Add(i);
            }
            return _numbersList.Count;
        }
        
        /// <summary>
        /// Find the prime numbers in the list.
        /// </summary>
        /// <returns>A @List<int> containing prime numbers within the specified range</returns>
        public List<int> FindPrimes()
        {
            if (_numbersList.Count == 0)
                throw new ListEmptyException("List is empty");

            for (int i = 2; i < _numbersList.Count; i++)
            {
                _numbersList.RemoveAll(x => (x != i) && (x % i == 0));
            }
            return _numbersList;
        }
    }
}
