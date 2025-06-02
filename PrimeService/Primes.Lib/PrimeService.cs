using System;

namespace Primes.Lib
{
    /// <summary>
    /// Provides functionality to determine if a number is prime.
    /// </summary>
    public class PrimeService
    {
        /// <summary>
        /// Determines whether the specified number is a prime number.
        /// </summary>
        /// <param name="candidate">The number to test.</param>
        /// <returns>True if the number is prime; otherwise, false.</returns>
        public bool IsPrime(int candidate)
        {
            if (candidate < 2) return false;
            for (int i = 2; i <= Math.Sqrt(candidate); i++)
            {
                if (candidate % i == 0)
                    return false;
            }
            return true;
        }
    }
}
