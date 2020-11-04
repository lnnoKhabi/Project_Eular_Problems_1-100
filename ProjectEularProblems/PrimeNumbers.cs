using System.Collections.Generic;
using System;

namespace ProjectEularProblems
{
    class PrimeNumbers
    {
        //Getting Prime Numbers
        public static List<int> FindPrimeNumbers ( int limit )
        {
            List<int> Numbers = new List<int> ( );
            List<int> PossiblePrimes = new List<int> ( );
            List<int> ActualPrimes = new List<int> ( );

            //add all natural numbers from 1 - *limit to Numbers array 
            for ( int i = 1; i < limit; i++ )
            {
                if(i > 10 )
                {
                    if(i % 2 == 0 || i % 3 == 0 || i % 5 == 0 || i % 5 == 0 || i % 6 == 0 || i % 7 == 0 || i % 8 == 0 || i % 9 == 0)
                    {
                    continue;

                    }
                }
                Numbers.Add ( i );
            }

            foreach ( int num in Numbers )
            {
                for ( int j = 1; j <= num; j++ )
                {
                    if ( num % j == 0 )
                    {
                        if ( PossiblePrimes.Contains ( j ) != true )
                        {
                            PossiblePrimes.Add ( j );
                        }
                    }

                }
                if ( PossiblePrimes.Count == 2 && PossiblePrimes [ 0 ] == 1 && PossiblePrimes [ 1 ] == num )
                {
                    ActualPrimes.Add ( num );
                    //Console.WriteLine( num  );
                    //Console.WriteLine (num);
                }
                PossiblePrimes.Clear ( );
            }
            return ActualPrimes;
        }
    }
}
