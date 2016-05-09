using NUnit.Framework;
using SieveOfEratosthenes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace SieveOfEratosthenes.Tests
{
    [TestFixture()]
    public class SieveOfEratosthenesTests
    {
        [Test()]
        public void Throw_exception_when_Constructor_is_given_range_as_begin_value_equal_or_greater_than_end_value()
        {
            
            Assert.That(() => (new SieveOfEratosthenes()).PopulateList(5, 4), Throws.TypeOf<Exceptions.RangeInvalidException>());
            
        }

        [Test()]
        public void PopulateList_should_populate_a_list_of_integers()
        {
            Assert.That((new SieveOfEratosthenes().PopulateList(5, 10)), Is.EqualTo(6));

        }

        [Test()]
        public void FindPrimes_should_return_list_of_primes()
        {
            List<int> PrimeListBetween1And10 = new List<int> { 1, 2, 3, 5, 7 };
            SieveOfEratosthenes sieve = new SieveOfEratosthenes();
            sieve.PopulateList(1, 10);
            Assert.That(sieve.FindPrimes(), Is.EquivalentTo(PrimeListBetween1And10));
        }
    }
}