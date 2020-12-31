﻿using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Speech.Synthesis;
using System.Speech.Recognition;
using System.Speech.AudioFormat;
using System.Threading.Tasks;

namespace ProjectEularProblems
{
    public class Problems
    {

        //Summary:
        //Project Eular
        static void Main ( string[] args )
        {

            CoinSums();
            Console.ReadLine ();
        }

        //PROBLEM 1
        public static int FindMultiplesOf3and5below1000()
        {
            int sum = 0;
            for ( int i = 0; i < 1000; i++ )
            {
                if ( i % 3 == 0 )
                {
                    sum += i;
                }
                if ( i % 5 == 0 && i % 3 != 0 )
                {
                    sum += i;
                }
            }
            return sum;
        }

        //PROBLEM 2
        public static int FindSumOfEvenFibonacciNumbers()
        {
            List<int> Numbers = new List<int> { 1, 1 };

            for ( int i = 2; i <= 100; i++ )
            {
                if ( Numbers[ Numbers.Count - 1 ] < 4000000 )
                {
                    Numbers.Add(Numbers[ Numbers.Count - 1 ] + Numbers[ Numbers.Count - 2 ]);
                }
            }

            Numbers.RemoveAt(Numbers.Count - 1);
            int SumOfEvenNums = 0;

            foreach ( int n in Numbers )
            {
                if ( n % 2 == 0 )
                {
                    SumOfEvenNums += n;
                }
            }
            return SumOfEvenNums;
        }

        //PROBLEN 3 <find the largest prime factor of 600 851 475 143 >
        public static void FindLargestPrimeFactor()
        {
            for ( Int64 i = 10000; ; i-- )
            {
                Int64 res = 600851475143 % i;
                if ( res == 0)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }

        //PROBLEM 4
        public static int FindHighestPalindrome()
        {
            int i;
            List<int> PalindromNums = new List<int>();
            for ( int k = 999; k >= 100; k-- )
            {
                for ( int j = 999; j >= 100; j-- )
                {
                    i = k * j;
                    string s = i.ToString();
                    if ( s[ s.Length - 1 ] == s[ 0 ] && s[ s.Length - 2 ] == s[ 1 ] && s[ s.Length - 3 ] == s[ 2 ] )
                    {
                        PalindromNums.Add(i);
                    }
                }
            }

            int BiggestPalindrom = PalindromNums.Max();
            return BiggestPalindrom;
        }

        //PROBLEM 5
        public static int FindSmallestMultipleBy1_20()
        {
            int x = 10;
            while ( true )
            {

                if ( x % 1 == 0 &&
                    x % 2 == 0 &&
                    x % 3 == 0 &&
                    x % 4 == 0 &&
                    x % 5 == 0 &&
                    x % 6 == 0 &&
                    x % 7 == 0 &&
                    x % 8 == 0 &&
                    x % 9 == 0 &&
                    x % 10 == 0 &&
                    x % 11 == 0 &&
                    x % 12 == 0 &&
                    x % 13 == 0 &&
                    x % 14 == 0 &&
                    x % 15 == 0 &&
                    x % 16 == 0 &&
                    x % 17 == 0 &&
                    x % 18 == 0 &&
                    x % 19 == 0 &&
                    x % 20 == 0 )
                {
                    return ( x );
                }
                x++;
            }
        }

        //PROBLEM 6
        public static int FindSumSquareDifference()
        {
            int x = 0;
            for ( int i = 0; i <= 100; i++ )
            {
                x += i;
            }
            x *= x;

            int y = 0;
            for ( int i = 0; i <= 100; i++ )
            {
                int k = i * i;
                y += k;
            }
            return x - y;
        }

        //PROBLEM 7 <return the 1 001st prime number>
        public static void Find_10001st_Prime()
        {
            int c = 2;

            for ( int i = 5; ; i++ )
            {
                int less = i / 2;
                for ( int j = 2; j <= less; j++ )
                {
                    if ( i % j == 0 )
                    {
                        break;
                    }
                    else if(j == less )
                    {
                        c++;
                    }
                }
                if(c == 10001 )
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }

        //PROBLEM 8
        public static void FindLargestProductInASeriesOf1000Numbers()
        {

            List<Int64> AdjacentNums = new List<Int64>();
            List<Int64> Products = new List<Int64>();
            List<Int64> Series = new List<Int64>() {7,3,1,6,7,1,7,6,5,3,1,3,3,0,6,2,4,9,1,9,2,2,5,1,1,9,6,7,4,4,2,6,5,7,4,7,4,2,3,5,5,3,4,9,1,9,4,9,3,4,
                                                9,6,9,8,3,5,2,0,3,1,2,7,7,4,5,0,6,3,2,6,2,3,9,5,7,8,3,1,8,0,1,6,9,8,4,8,0,1,8,6,9,4,7,8,8,5,1,8,4,3,
                                                8,5,8,6,1,5,6,0,7,8,9,1,1,2,9,4,9,4,9,5,4,5,9,5,0,1,7,3,7,9,5,8,3,3,1,9,5,2,8,5,3,2,0,8,8,0,5,5,1,1,
                                                1,2,5,4,0,6,9,8,7,4,7,1,5,8,5,2,3,8,6,3,0,5,0,7,1,5,6,9,3,2,9,0,9,6,3,2,9,5,2,2,7,4,4,3,0,4,3,5,5,7,
                                                6,6,8,9,6,6,4,8,9,5,0,4,4,5,2,4,4,5,2,3,1,6,1,7,3,1,8,5,6,4,0,3,0,9,8,7,1,1,1,2,1,7,2,2,3,8,3,1,1,3,
                                                6,2,2,2,9,8,9,3,4,2,3,3,8,0,3,0,8,1,3,5,3,3,6,2,7,6,6,1,4,2,8,2,8,0,6,4,4,4,4,8,6,6,4,5,2,3,8,7,4,9,
                                                3,0,3,5,8,9,0,7,2,9,6,2,9,0,4,9,1,5,6,0,4,4,0,7,7,2,3,9,0,7,1,3,8,1,0,5,1,5,8,5,9,3,0,7,9,6,0,8,6,6,
                                                7,0,1,7,2,4,2,7,1,2,1,8,8,3,9,9,8,7,9,7,9,0,8,7,9,2,2,7,4,9,2,1,9,0,1,6,9,9,7,2,0,8,8,8,0,9,3,7,7,6,
                                                6,5,7,2,7,3,3,3,0,0,1,0,5,3,3,6,7,8,8,1,2,2,0,2,3,5,4,2,1,8,0,9,7,5,1,2,5,4,5,4,0,5,9,4,7,5,2,2,4,3,
                                                5,2,5,8,4,9,0,7,7,1,1,6,7,0,5,5,6,0,1,3,6,0,4,8,3,9,5,8,6,4,4,6,7,0,6,3,2,4,4,1,5,7,2,2,1,5,5,3,9,7,
                                                5,3,6,9,7,8,1,7,9,7,7,8,4,6,1,7,4,0,6,4,9,5,5,1,4,9,2,9,0,8,6,2,5,6,9,3,2,1,9,7,8,4,6,8,6,2,2,4,8,2,
                                                8,3,9,7,2,2,4,1,3,7,5,6,5,7,0,5,6,0,5,7,4,9,0,2,6,1,4,0,7,9,7,2,9,6,8,6,5,2,4,1,4,5,3,5,1,0,0,4,7,4,
                                                8,2,1,6,6,3,7,0,4,8,4,4,0,3,1,9,9,8,9,0,0,0,8,8,9,5,2,4,3,4,5,0,6,5,8,5,4,1,2,2,7,5,8,8,6,6,6,8,8,1,
                                                1,6,4,2,7,1,7,1,4,7,9,9,2,4,4,4,2,9,2,8,2,3,0,8,6,3,4,6,5,6,7,4,8,1,3,9,1,9,1,2,3,1,6,2,8,2,4,5,8,6,
                                                1,7,8,6,6,4,5,8,3,5,9,1,2,4,5,6,6,5,2,9,4,7,6,5,4,5,6,8,2,8,4,8,9,1,2,8,8,3,1,4,2,6,0,7,6,9,0,0,4,2,
                                                2,4,2,1,9,0,2,2,6,7,1,0,5,5,6,2,6,3,2,1,1,1,1,1,0,9,3,7,0,5,4,4,2,1,7,5,0,6,9,4,1,6,5,8,9,6,0,4,0,8,
                                                0,7,1,9,8,4,0,3,8,5,0,9,6,2,4,5,5,4,4,4,3,6,2,9,8,1,2,3,0,9,8,7,8,7,9,9,2,7,2,4,4,2,8,4,9,0,9,1,8,8,
                                                8,4,5,8,0,1,5,6,1,6,6,0,9,7,9,1,9,1,3,3,8,7,5,4,9,9,2,0,0,5,2,4,0,6,3,6,8,9,9,1,2,5,6,0,7,1,7,6,0,6,
                                                0,5,8,8,6,1,1,6,4,6,7,1,0,9,4,0,5,0,7,7,5,4,1,0,0,2,2,5,6,9,8,3,1,5,5,2,0,0,0,5,5,9,3,5,7,2,9,7,2,5,
                                                7,1,6,3,6,2,6,9,5,6,1,8,8,2,6,7,0,4,2,8,2,5,2,4,8,3,6,0,0,8,2,3,2,5,7,5,3,0,4,2,0,7,5,2,9,6,3,4,5,0 };

            for ( int i = 0; i < Series.Count - 12; i++ )
            {
                Int64 Product = Series[ i ] *
                              Series[ i + 1 ] *
                              Series[ i + 2 ] *
                              Series[ i + 3 ] *
                              Series[ i + 4 ] *
                              Series[ i + 5 ] *
                              Series[ i + 6 ] *
                              Series[ i + 7 ] *
                              Series[ i + 8 ] *
                              Series[ i + 9 ] *
                              Series[ i + 10 ] *
                              Series[ i + 11 ] *
                              Series[ i + 12 ];

                Products.Add(Product);
                if ( Product >= Products.Max() )
                {
                    AdjacentNums.Clear();
                    for ( int j = 0; j < 13; j++ )
                    {
                        AdjacentNums.Add(Series[ i + j ]);
                    }
                }
            }

            Console.Write("Adjacent numbers are : ");
            foreach ( Int64 k in AdjacentNums )
            {
                Console.Write(k + ", ");
            }
            Console.WriteLine();
            Console.Write("product is : " + Products.Max());
        }

        //PROBLEM 9
        public static int FindSpecialPythagoreanTriplet()
        {
            int Result = 0;
            bool exit = false;
            List<int> Squares = new List<int>();

            //loop to add items to squares list
            for ( int i = 1; i <= 450; i++ )
            {
                Squares.Add(i);
            }
            for ( int i = 0; i < Squares.Count; i++ )
            {
                if ( exit == false )
                {
                    for ( int j = 1; j < Squares.Count; j++ )
                    {
                        //int SumOfTwo = Squares[ i ] + Squares[ j ];
                        for ( int k = 0; k < Squares.Count; k++ )
                        {
                            //a^ + b^ = c^; {Pythagorean theory}
                            if ( ( Squares[ i ] * Squares[ i ] ) + ( Squares[ j ] * Squares[ j ] ) == ( Squares[ k ] * Squares[ k ] ) )
                            {
                                //check if sum == 1000
                                if ( Squares[ i ] + Squares[ j ] + Squares[ k ] == 1000 )
                                {
                                    Result = Squares[ i ] * Squares[ j ] * Squares[ k ];
                                    Console.WriteLine($"first number: {Squares[ i ]} \nsecond number: {Squares[ j ]} \nthird number: {Squares[ k ]}\n");
                                    Console.WriteLine(Result);
                                    exit = true;
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            return Result;
        }


        //PROBLEM 10 <Sum of all primes below 2 million>
        public static void FindSummationOfPrimes()
        {
            Int64 c = 5;

            for ( int i = 2; i < 2000000; i++ )
            {
                for ( int j = 2; j <= i / 2; j++ )
                {
                    if ( i % j == 0 )
                    {
                        break;
                    }
                    else if ( j == i / 2 )
                    {
                        c += i;
                        Console.WriteLine(i);
                        break;
                    }
                }
            }
            Console.WriteLine(c);
        }

        //PROBLEM 12 <triangle numbers>
        //1st triangle number with 500 factors
        static public void TriangleNumWithOver500Factors()
        {
            int c = 0;
            for ( int i = 1; ; i++ )
            {
                int d = 2;
                c += i;
                for ( int j = 2; j <= c / 2; j++ )
                {
                    if ( c % j == 0 )
                    {
                        d++;
                    }
                }
                if ( d >= 500 )
                {
                    Console.WriteLine($"{c} has {d} factors.");
                    break;
                }
            }
        }

        //PROBLEM 13 
        //find the sum of a 100 50 digit nums and return the first 10 digits of the result 
        static public void SumOfNumsinReverse()
        {
            //eular problem 13
            string a = "";
            int c = 0;
            for ( int p = 49; p >= 0; p-- )
            {
                using ( StreamReader sw = new StreamReader("./Problem13.txt") )
                {
                    int r = c;

                    for ( int i = 0; i < 100; i++ )
                    {
                        string s = sw.ReadLine();
                        int j = int.Parse(s[ p ].ToString());
                        r += j;
                    }
                    a += r.ToString()[ r.ToString().Length - 1 ];
                    c = Convert.ToInt32(r.ToString().Substring(0, r.ToString().Length - 1));
                }
            }
            a += c.ToString();
            Console.WriteLine(new String(a.ToArray().Reverse().ToArray()).Substring(0, 10));
        }


        //PROBLEM 14 <Collatz sequence {with most nums in sequence}>
        public static void FindCollatzSequence( int x )
        {
            //eular problem 14
            //Collatz Sequence
            //n → n / 2(n is even)
            //n → 3n + 1(n is odd)

            int max = 0;
            int res = 0;
            for ( int i = 13; i < 1000000; i++ )
            {
                int c = 1;
                Int64 n = i;
                while ( n > 1 )
                {
                    n = n % 2 == 0 ? n / 2 : n * 3 + 1;
                    c++;
                }
                res = c > max ? i : res;
                max = c > max ? c : max;
            }
            Console.WriteLine($"{res} has {max} nums in sequence.");
        }

        //PROBLEM 15 <by moving only right & down in a 20x20 grid. how many possible moves are there>
        public static async void MovesInGrid(int grid)
        {
            //Stopwatch sp = new Stopwatch();
            //sp.Start();

            //use the combination formula [n! / r! (n - r)!]
            /*
                 n!                       40!                              40!
            ___________    ====>   ________________      ====>         ___________

            r! (n - r)!              20! (40 - 20)!                     20! x 20!

            */

            string n = "1";
            Task t = new Task(() => { 
			for ( int i = grid * 2; i > 1; i-- )
			    {
                    n = MultiplyLongNums(i.ToString(), n);
			    }
                });
            t.Start();
            await t;

            string r = "1";
            string rbyr = "";

            Task t2 = new Task(() => { 
                for ( int i = grid; i > 1; i-- )
                {
                    r = MultiplyLongNums(i.ToString(), r);
                }
                rbyr = MultiplyLongNums(r, r);
            });
            t2.Start();
            await t2;

            if ( t.IsCompleted && t2.IsCompleted )
			{

                n = n.Insert(n.Length - ( rbyr.Length - 1 ), ".");
                rbyr = rbyr.Insert(1, ".");

                double d = double.Parse(n) / double.Parse(rbyr);

			    //Console.WriteLine(n);
                //Console.WriteLine(rbyr );
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(d);

            //sp.Stop();
            //Console.WriteLine("\n" + sp.ElapsedMilliseconds);
			}
        }

        //PROBLEM 16 < sum of digits produced by 2^100 >
        public static void FindPowerDigitSum()
        {
            string R = "2";
            for ( int i = 1; i < 1000; i++ )
            {
                R = MultiplyLongNums(R, "2");
            }
            Console.WriteLine(R);
            Console.WriteLine("--------------------------------------");
            Console.Write("Sum : ");
            Console.WriteLine(Array.ConvertAll(R.ToArray(), a => int.Parse(a.ToString())).Sum());
        }

        //Methods below were used for several problems in * & + big numbers
        //method to multiply numbers of any size [even > long.max || BigInteger]
        private static string MultiplyLongNums( string a, string b )
        {
            string num1 = a.Length == b.Length ? a : a.Length > b.Length ? a : b;
            string num2 = b.Length == a.Length ? b : b.Length < a.Length ? b : a;
            string main_res = "0";

            for ( int i = 0; i < num2.Length; i++ )
            {
                int multiplier = int.Parse(num2[ i ].ToString());
                int carry = 0;
                string _res = "";

                for ( int k = 0; k < num2.Length - ( i + 1 ); k++ )
                {
                    _res += "0";
                }

                for ( int j = num1.Length - 1; j >= 0; j-- )
                {
                    string temp_res = ( int.Parse(num1[ j ].ToString()) * multiplier + carry ).ToString();
                    carry = j == 0 ? 0 : temp_res.Length > 1 ? int.Parse(temp_res.Substring(0, temp_res.Length - 1)) : 0;
                    _res = j == 0 ? temp_res + _res : temp_res.Length > 1 ? temp_res[ temp_res.Length - 1 ].ToString() + _res : temp_res + _res;

                }
                main_res = AddLongNums(main_res, _res);
            }
            return main_res;
        }
        //method to add numbers of any size [even > long.max || BigInteger]
        private static string AddLongNums( string num1, string num2 )
        {
            //make sure bigger num is at the top
            string bger_num = num1.Length == num2.Length ? num1 : num1.Length > num2.Length ? num1 : num2;
            string smlr_num = num2.Length == num1.Length ? num2 : num2.Length < num1.Length ? num2 : num1;
            string _res = "";
            string sum = "";
            int carry = 0;
            for ( int j = 1; j <= bger_num.Length; j++ )
            {
                try
                {
                    sum = ( int.Parse(bger_num[ bger_num.Length - j ].ToString()) + int.Parse(smlr_num[ smlr_num.Length - j ].ToString()) + carry ).ToString();
                }
                catch
                {
                    sum = ( int.Parse(bger_num[ bger_num.Length - j ].ToString()) + carry ).ToString();
                }
                carry = j == 0 ? 0 : sum.Length > 1 ? int.Parse(sum.Substring(0, sum.Length - 1)) : 0;
                _res = j == bger_num.Length ? sum + _res : sum[ sum.Length - 1 ].ToString() + _res;
            }
            return _res;
        }
        
        //PROBLEM 17 <writing a number in words and counting number of letters>
        public static void LetterCount()
        {
            int output = 0;

            string result = null;

            string[] ones = { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten" };
            string[] tens = { "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            string[] hundreds = { "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

            for ( int number = 1; number <= 1000; number++ )
            {
                if ( number <= 10 )
                {
                    result = ones[ number - 1 ];
                }
                else if ( number <= 19 )
                {
                    result = tens[ number - 11 ];
                }
                else if ( number <= 99 )
                {
                    string num = number.ToString();
                    result = num[ 1 ] == '0' ? $"{hundreds[ int.Parse(num[ 0 ].ToString()) - 2 ] }" : $"{hundreds[ int.Parse(num[ 0 ].ToString()) - 2 ] } {ones[ int.Parse(num[ 1 ].ToString()) - 1 ]}";
                }
                else if ( number <= 999 )
                {
                    string num = number.ToString();
                    string first_part = ones[ int.Parse(num[ 0 ].ToString()) - 1 ] + " hundred";
                    string second_part = "";

                    if ( num.Substring(1, 2) != "00" )
                    {

                        if ( num[ 1 ] == '0' )
                        {
                            second_part = "and " + $"{ones[ int.Parse(num[ 2 ].ToString()) - 1 ]}";

                        }
                        else if ( num[ 2 ] == '0' )
                        {
                            second_part = num[ 1 ] == '1' ? $"and {ones[ 9 ]}" : "and " + $"{hundreds[ int.Parse(num[ 1 ].ToString()) - 2 ] }";
                        }

                        else
                        {
                            int n = int.Parse(num.Substring(1, 2));
                            if ( n <= 19 )
                            {
                                second_part = $"and {tens[ n - 11 ]}";
                            }
                            else if ( n <= 99 )
                            {
                                second_part = $"and {hundreds[ int.Parse(num[ 1 ].ToString()) - 2 ] } {ones[ int.Parse(num[ 2 ].ToString()) - 1 ]}";
                            }
                        }
                    }

                    result = $"{first_part} {second_part}";

                }
                else if ( number == 1000 )
                {
                    result = "one thousand";
                }

				Console.WriteLine(number +". " +result);
                output += result.Replace(" ", "").Length;
            }
            Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("\n" + output + " words.");
        }


		//PROBLEM 18 <finding a path in a tree with highest sum>
		public static void MaxPathSum_1()
        {
            //brute force <by comparing all the possible paths> 2 ^ rows - 1 
            List<int[]> lstNums = new List<int[]>();
            //store all nums in an array
            using ( StreamReader sr = new StreamReader("./Problem18.txt") )
            {
                string num = "";
                while ( ( num = sr.ReadLine() ) != null )
                {
                    lstNums.Add(Array.ConvertAll(num.Trim().Split(' '), a => int.Parse(a)));
                }
            }

                
            /*in a tree with 2 children each child is either 0 or 1
            which can be seen as a binary number.
            if a tree has a depth of 15 then ==> 0-0-0-0-0-0-0-0-0-0-0-0-0-0-0 first route ==> 0
                                                 0-0-0-0-0-0-0-0-0-0-0-0-0-0-1 sec route    ==> 1
                                                 0-0-0-0-0-0-0-0-0-0-0-0-0-1-0 third route  ==> 2

            hence just iterate all natural nums from 0 to 2^depth-1 [and covert them to a 15 digit binary num] ==> the binary equiv is the route 
            */
            int max = ( int ) Math.Pow(2, lstNums.Count - 1);
            int best_res = 0;
            string best_route = "";
            for ( int i = 0; i < max; i++ )
            {
                //prepend needed zeros so bin has 15 digits
                string pholder = "";
                for ( int l = 0; l < lstNums.Count; l++ )
                {
                    pholder += "0";
                }
                //convert i to binary
                string bin = Convert.ToString(i, 2);
                bin = pholder.Substring(0, pholder.Length - bin.Length) + bin;
                int[] route_array = Array.ConvertAll(bin.ToArray(), a => int.Parse(a.ToString()));
                int res = 0;
                string route = "";

                for ( int j = 0; j < lstNums.Count; j++ )
                {
                    int total = 0;
                    for ( int k = 0; k < j; k++ )
                    {
                        total += route_array[ k ];
                    }
                    int n = lstNums[ j ][ route_array[ j ] + total ];
                    res += n;
                    route += n.ToString() + " ";
                }
                best_route = res > best_res ? route : best_route;
                best_res = res > best_res ? res : best_res;
            }

            //print out the pyramid
            best_route = best_route.Trim();
            int[] correct_route_nums = Array.ConvertAll(best_route.Split(' ').ToArray(), a => int.Parse(a.ToString()));

            for ( int i = 0; i < lstNums.Count; i++ )
            {
                int[] nums = lstNums[ i ];
                for ( int j = 0; j < lstNums.Count - nums.Length; j++ )
                {
                    Console.Write("  ");
                }
                for ( int k = 0; k < nums.Length; k++ )
                {
                    int n = nums[ k ];
                    if ( n == correct_route_nums[ i ] )
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    string ns = n < 10 ? "0" + n : n.ToString();
                    Console.Write(ns+"  ");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.WriteLine();
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("sum: " + best_res);
            Console.ReadLine();
        
    }

        //PROBLEM 19 <first days of a month that are on a sunday>
        public static void CountingSundays()
        {
            DateTime date = new DateTime(1901, 1, 1);
            DateTime d = new DateTime(2000, 12, 31);
            int c = 0;
            while ( date <= d )
            {
                if ( date.Day == 1 && date.DayOfWeek == DayOfWeek.Sunday )
                {
                    c++;
                }
                date = date.AddMonths(1);
            }
            Console.WriteLine(c+" sundays.");
        }

        //PROBLEM 20 <the sum of the digits in the number 100!>
        public static void FactorialDigitSum()
        {
            /*using recursive function is slower*/
            /*use loop*/
            string res = "100";
            for ( int i = int.Parse(res); i > 2; i-- )
            {
                //this is a custome method for mul long nums
                res = MultiplyLongNums(res, ( i - 1 ).ToString());
            }

            Console.WriteLine("100! = "+res);
            Console.WriteLine("sum: "+Array.ConvertAll( res.ToArray(), a => int.Parse(a.ToString())).Sum());
        }


        /*Let d(n) be defined as the sum of proper divisors of n (numbers less than n which divide evenly into n).
          If d(a) = b and d(b) = a, where a ≠ b, then a and b are an amicable pair and each of a and b are called amicable numbers.

          For example, the proper divisors of 220 are 1, 2, 4, 5, 10, 11, 20, 22, 44, 55 and 110; therefore d(220) = 284. 
          The proper divisors of 284 are 1, 2, 4, 71 and 142; so d(284) = 220.*/
        //PROBLEM 21 <the sum of all the amicable numbers below 10000.>
        public static void AmicableNumbers()
        {
            int res = 0;

            for ( int i = 1; i <= 10000; i++ )
            {
                //find divisors of i and add them together
                int sum = 0;
                for ( int j = 1; j <= i/2; j++ )
                {
                    if (i % j == 0 )
                    {
                        sum += j;
                    }
                }
                //find divisors of [sum of divisors of i] and add them together
                int new_sum = 0;
                for ( int k = 1; k <= sum/2; k++ )
                {
                    if(sum % k == 0 )
                    {
                        new_sum += k;
                    }
                }
                //determine if d(i) == sum && d(sum) == i && i != sum
                if(i == new_sum && i != sum)
                {
                    res += sum + new_sum;
                    i = sum + 1;
                }
            }
            Console.WriteLine($"{res}.");
        }

        /*example, when the list is sorted into alphabetical order, COLIN, 
         * which is worth 3 + 15 + 12 + 9 + 14 = 53, is the 938th name in the list. 
         * So, COLIN would obtain a score of 938 × 53 = 49714.*/
        //PROBLEM 22 <the total of all the name scores in the file?>
        public static void NameScores()
        {
            List<string> names = new List<string>();
            using(StreamReader sr = new StreamReader("./Problem22.txt") )
            {
                string[] str = sr.ReadToEnd().Split(',');
                foreach ( string name in str )
                {
                    names.Add(name.Replace("\"", ""));
                }
            }
            names.Sort();
            long c = 0;
            for ( int i = 0; i < names.Count; i++ )
            {
                string name = names[ i ];
                int sum = 0;
                foreach ( char cha in name )
                {
                     sum += ( int ) cha - 64 ;
                }
                c += sum * (i + 1);

            }
            Console.WriteLine(c);
        }


        /*
         * A number (n) is called abundant if the sum of it's divisors exceeds the number (n).
           As 12 is the smallest abundant number, 1 + 2 + 3 + 4 + 6 = 16, the smallest number that can be written as the sum of two abundant numbers is 24. 
           
            By mathematical analysis, it can be shown that all integers greater than 28123 can be written as the sum of two abundant numbers.
            However, this upper limit cannot be reduced any further by analysis even though it is known that the greatest number that cannot be expressed as the sum of two abundant numbers is less than this limit.
            */

        //PROBLEM 23 <the sum of all the positive integers which cannot be written as the sum of two abundant numbers.>
        public static void Non_AbundantNumbers()
        {
            List<int> AbundantNumbers = new List<int>();
            //get all abundant num below limit 28123
            for ( int i = 2; i <= 28123; i++ )
            {
                int j_limit = i / 2;
                int divisors_sum = 0;
                for ( int j = 1; j <= j_limit; j++ )
                {
                    divisors_sum = i % j == 0 ? divisors_sum + j : divisors_sum;
                }
                if(divisors_sum > i )
                {
                    AbundantNumbers.Add(i);
                }
            }

            HashSet<int> NumsMadeBy_Abundant = new HashSet<int>();
            //get all nums made my 2 abundant nums
            for ( int a = 0; a < AbundantNumbers.Count; a++ )
            {
                for ( int b = a ; b < AbundantNumbers.Count; b++ )
                {
                    NumsMadeBy_Abundant.Add(AbundantNumbers[a] + AbundantNumbers[ b ]);
                }
            }

            //count non-abundant nums
            int count = 0; 
            for ( int c = 1; c <= 28123; c++ )
            {
                count = NumsMadeBy_Abundant.Contains(c) ? count : count + c;
            }
            Console.WriteLine(count);
        }

        private static int fact(int i )
        {
            if (i == 1 )
            {
                return 1;
            }
            return i * fact(i - 1);
        }

        /*the lexicographic permutations of 1,2,3 are 123 132 213 231 312 321*/
        //  PROBLEM 24 < the millionth lexicographic permutation of the digits 0, 1, 2, 3, 4, 5, 6, 7, 8 and 9 >
        public static void LexicographicPermutations()
        {
            int[] P = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int times = fact(P.Length);

            for ( int j = 0; j < times; j++ )
            {
                //STEP 1: Find the largest x such that P[x]<P[x+1].
                //( If there is no such x, P is the last permutation.)
                int x = -1;
                for ( int i = 0; i < P.Length - 1; i++ )
                {
                    x = P[ i ] < P[ i + 1 ] ? i : x;
                }
                if ( x == -1 )
                {
                    break;
                }

                //STEP 2 Find the largest y such that P[x]<P[y]
                int y = 0;
                for ( int i = 0; i < P.Length; i++ )
                {
                    if ( P[ x ] < P[ i ] )
                    {
                        y = i;
                    }
                }

                //STEP 3 Swap P[x] and P[y].
                int index_x = P[ x ];
                int index_y = P[ y ];
                P[ x ] = index_y;
                P[ y ] = index_x;

                //STEP 4 Reverse P[x+1 .. n].
                int[] new_P = new int[ P.Length ];
                for ( int i = 0; i <= x; i++ )
                {
                    new_P[ i ] = P[ i ];
                }
                int c = 1;
                for ( int i = P.Length - 1; i > x; i-- )
                {
                    new_P[ x+c ] = P[ i ];
                    c++;
                }

                P = new_P;
                if(j + 2 == 1000000 )
                {
                    Console.Write("index: "+(j+2) + " is ");
                    foreach ( int n in new_P )
                    {
                        Console.Write(n);
                    }
                    break;
                }
            }
        }

        //PROBLEM 25 < the index of the first term in the Fibonacci sequence to contain 1000 digits?>
        public static void ThousanDigitFibonacciNumber()
        {
            string n = "";
            string x = "1";
            string y = "2";
            string f = null;
            for ( int i = 3;n.Length < 1000; i++ )
            {
                n = AddLongNums( x , y);
                x = y;
                y = n;
                f = "F" + ( i + 1 );
            }
            Console.WriteLine(f+" is: "+n);
        }


        //PROBLEM 26 < the value of d < 1000 for which 1/d contains the longest recurring cycle in its decimal fraction part.>
        public static void ReciprocalCyles()
        {
            string re = "";
            int res = 0;
            for ( int i = 2; i < 1000; i++ )
            {
                int Numerator = 1;
                string result = "";
                int Denominator = i;
                int div_res = 0;
                int[] count = new int[ 10 ];
                while ( result.Length <= 1000 )
                {

                    div_res = Numerator / Denominator;

                    result += div_res;
                    count[ div_res ]++;

                    if ( Numerator % Denominator == 0 )
                    {

                        break;
                    }

                    Numerator = ( Numerator % Denominator ) * 10;
                }
                result = result.Substring(1);
                //Console.WriteLine($"1/{Denominator} = {result}");
                count[ 0 ]--;//exclude first zero (its the 0 before the coma)
                             //foreach ( int n in count )
                             //{
                             //	Console.Write(n +", ");
                             //}
                count = count.Where(x => x != 0).ToArray();
                int average = ( int ) count.Average();
                int c = count.Where(x => x >= average).Count();
                //Console.WriteLine("\n"+c);
                string l = result.Substring(0, c);
                int y = result.IndexOf(l, 1);
                //Console.WriteLine($"index of {l} = {y}");

                re = res < y ? Denominator.ToString() : re;
                res = res < y ? y : res;
            }
            Console.WriteLine($"1/{re} == {res}-digit recurring cycle ");
            //return result;
        }

        //PROBLEM 27 <Find the product of the coefficients, a and b, for the quadratic expression that produces the maximum number of primes for consecutive values of n, starting with n=0.>
        //Eulers formula n^2 + an + b == n^2 + n + 41  (a is 1, b is 41)
        //The incredible formula n^2 − an + b == n^2 − 79n + 1601 (a is -79, b is 1601)
        public static void QuadraticPrimes()
		{
            int coe_a = 0;
            int coe_b = 0;
            int val_n = 0;
            int best_primes = 0;

            for ( int a = -999; a < 1000; a++ )
            {
                for ( int b = -1000; b <= 1000; b++ )
                {
                    int primes = 0;
                    for ( int n = 0; ; n++ )
                    {
                        int res = Math.Abs(( n * n ) + ( a * n ) + b);
                        if ( !is_prime(res) )
                        {
                            bool is_big = primes > best_primes;
                            coe_a = is_big ? a : coe_a;
                            coe_b = is_big ? b : coe_b;
                            val_n = is_big ? n : val_n;
                            best_primes = is_big ? primes : best_primes;
                            break;
                        }
                        primes++;
                    }
                }
            }
            Console.WriteLine($"{val_n}^2 + ({coe_a} * {val_n}) + {coe_b} = {best_primes} primes ==> {coe_a * coe_b}");
        }
        //is a number a prime
        private static bool is_prime( int res )
        {
            int count = 0;
            for ( int i = 1; i <= res / 2; i++ )
            {
                if ( res % i == 0 )
                {
                    count++;
                }
            }
            return count >= 2 ? false : true;
        }

        //PROBLEM 28 
        /*<Starting with the number 1 and moving to the right in a clockwise direction a 5 by 5 spiral is formed as follows:
        21 22 23 24 25
        20  7  8  9 10
        19  6  1  2 11
        18  5  4  3 12
        17 16 15 14 13
        It can be verified that the sum of the numbers on the diagonals is 101.
        What is the sum of the numbers on the diagonals in a 1001 by 1001 spiral formed in the same way?>*/

        public static void NumberSpiralDiagonals()
		{
            int end = 1001 * 1001;
            int checker = 0;
            int counter = 2;
            int sum = 0;
			for ( int i = 3; i <= end; i+=counter )
			{
                sum += i;
                checker += 1;
                counter = checker == 4 ? counter+2:counter;
                checker = checker == 4 ? 0 : checker;
			}
			Console.WriteLine(sum+1);
		}


        //PROBLEM 29
        /*Consider all integer combinations of ab for 2 ≤ a ≤ 5 and 2 ≤ b ≤ 5:

        22=4, 23=8, 24=16, 25=32
        32=9, 33=27, 34=81, 35=243
        42=16, 43=64, 44=256, 45=1024
        52=25, 53=125, 54=625, 55=3125
        If they are then placed in numerical order, with any repeats removed, we get the following sequence of 15 distinct terms:

        4, 8, 9, 16, 25, 27, 32, 64, 81, 125, 243, 256, 625, 1024, 3125

        How many distinct terms are in the sequence generated by ab for 2 ≤ a ≤ 100 and 2 ≤ b ≤ 100?*/
        public static void DistinctPowers()
		{
            HashSet<double> res = new HashSet<double>();
            int start = 2;
            int end = 100;
            for ( int a = start; a <= end; a++ )
			{
				for ( int b = start; b <= end; b++ )
				{
                    res.Add(Math.Pow(a, b));
				}
			}
			Console.WriteLine(res.Count);
		}


        //PROBLEM 30
        /*Surprisingly there are only three numbers that can be written as the sum of fourth powers of their digits:

        1634 = 1^4 + 6^4 + 3^4 + 4^4
        8208 = 8^4 + 2^4 + 0^4 + 8^4
        9474 = 9^4 + 4^4 + 7^4 + 4^4

        As 1 = 1^4 is not a sum it is not included.

        The sum of these numbers is 1634 + 8208 + 9474 = 19316.

        Find the sum of all the numbers that can be written as the sum of fifth powers of their digits.*/
        public static void DigitFifthPowers()
		{
            string n = "";
            int res = 0;
            double sum = 0;
            for ( int i = 2; i <= 1000000; i++ )
			{
				n = i.ToString();
                sum = 0;
				for ( int j = 0; j < n.Length; j++ )
				{
                    sum += Math.Pow(int.Parse(n[ j ].ToString()), 5);
				}
                res = (int)sum == i ? res + i : res;
			}
			Console.WriteLine(res);
		}


        //PROBLEM 31
        /* In the United Kingdom the currency is made up of pound (£) and pence (p). There are eight coins in general circulation:

        1p, 2p, 5p, 10p, 20p, 50p, £1 (100p), and £2 (200p).
        It is possible to make £2 in the following way:

        1×£1 + 1×50p + 2×20p + 1×5p + 1×2p + 3×1p
        How many different ways can £2 be made using any number of coins? */
        public static void CoinSums()
		{
			List<int> coins = new List<int> { 100, 50, 20, 10, 5, 2, 1 };
            List<int> total = new List<int>();

			for ( int j = 1; j <= 7; j++ )
			{
                int res = PairNumber(j, coins);
                Console.WriteLine(res);
                total.Add(res);
			}
            Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine($"Total ways ==> {total.Sum()}");

        }
        private static int PairNumber(int pair_in, List<int> coins)
		{
            int res = 0;

            //for pairing each coin by itself
            if(pair_in == 1 )
            {
				//Console.WriteLine($"1x200p");
				//for ( int i = 0; i < coins.Count; i++ )
    //            {
				//    Console.WriteLine($"{200/coins[i]}x{coins[i]}p");
				//}
                return coins.Count + 1;
			}
            //for pairing every coin by 1 other coin
            else if(pair_in == 2 )
			{
                for ( int a = 0; a < coins.Count - 1; a++ )
                {
                    for ( int b = a + 1; b < coins.Count ; b++ )
                    {
                        int iend = 200 / coins[ a ];
                        for ( int i = 1; i <= iend; i++ )
                        {
                            int jend = ( 200 - ( coins[ a ] * i ) ) / coins[ b ];
                            for ( int j = 1; j <= jend; j++ )
                            {
                                int sum = ( coins[ a ] * i ) + ( coins[ b ] * j ) ;
                                if ( sum == 200 )
                                {
                                    res++;
                                    //Console.WriteLine($"{i}x{coins[ a ]}p + {j}x{coins[ b ]}p");
                                }
                            }
                        }
                    }
                }

                return res;
			}

            else if(pair_in == 3 )
			{
                    for ( int a = 0; a < coins.Count - 2; a++ )
                    {
                        for ( int b = a + 1; b < coins.Count - 1; b++ )
                        {
                            for ( int c = b + 1; c < coins.Count ; c++ )
                            {
                                int iend = 200 / coins[a];
                                for ( int i = 1; i <= iend; i++ )
                                {
                                    int jend = ( 200 - ( coins[ a ] * i ) ) / coins[ b ];  
									for ( int j = 1; j <= jend; j++ )
									{
                                        int kend = ( 200 - ( coins[ a ] * i ) - ( coins[ b ] * j ) ) / coins[ c ];
                                        for ( int k = 1; k <= kend; k++ )
									    {
                                            int sum = ( coins[ a ] * i ) + ( coins[ b ] * j ) + ( coins[ c ] * k );
                                            if(sum == 200 )
										    {
                                                res++;
											    //Console.WriteLine($"{i}x{coins[a]}p + {j}x{coins[ b ]}p + {k}x{coins[ c ]}p");
										    }
									    }
									}
                                }
                            }
                        }
                    }
                return res;
            }

            else if(pair_in == 4  )
			{
                for ( int a = 0; a < coins.Count - 3; a++ )
                {
                    for ( int b = a + 1; b < coins.Count - 2; b++ )
                    {
                        for ( int c = b + 1; c < coins.Count - 1; c++ )
                        {
							for ( int d = c + 1; d < coins.Count; d++ )
							{
                                int iend = 200 / coins[ a ];
                                for ( int i = 1; i <= iend; i++ )
                                {
                                    int jend = ( 200 - ( coins[ a ] * i ) ) / coins[ b ];
                                    for ( int j = 1; j <= jend; j++ )
                                    {
                                        int kend = ( 200 - ( coins[ a ] * i ) - ( coins[ b ] * j ) ) / coins[ c ];
                                        for ( int k = 1; k <= kend; k++ )
                                        {
                                            int lend = ( 200 - ( coins[ a ] * i ) - ( coins[ b ] * j ) - ( coins[ c ] * k ) ) / coins[ d ];
											for ( int l = 1; l <= lend; l++ )
											{
                                                int sum = ( coins[ a ] * i ) + ( coins[ b ] * j ) + ( coins[ c ] * k ) + ( coins[d] * l );
                                                if ( sum == 200 )
                                                {
                                                    res++;
                                                    //Console.WriteLine($"{i}x{coins[ a ]}p + {j}x{coins[ b ]}p + {k}x{coins[ c ]}p + {l}x{coins[ d ]}p");
                                                }
											}
                                        }
                                    }
                                }
							}
                        }
                    }
                }
                return res;
			}

            else if(pair_in == 5  )
			{
                for ( int a = 0; a < coins.Count - 4; a++ )
                {
                    for ( int b = a + 1; b < coins.Count - 3; b++ )
                    {
                        for ( int c = b + 1; c < coins.Count - 2; c++ )
                        {
                            for ( int d = c + 1; d < coins.Count - 1; d++ )
                            {
                                for ( int e = d + 1; e < coins.Count; e++ )
                                {
                                    int iend = 200 / coins[ a ];
                                    for ( int i = 1; i <= iend; i++ )
                                    {
                                        int jend = ( 200 - ( coins[ a ] * i ) ) / coins[ b ];
                                        for ( int j = 1; j <= jend; j++ )
                                        {
                                            int kend = ( 200 - ( coins[ a ] * i ) - ( coins[ b ] * j ) ) / coins[ c ];
                                            for ( int k = 1; k <= kend; k++ )
                                            {
                                                int lend = ( 200 - ( coins[ a ] * i ) - ( coins[ b ] * j ) - ( coins[ c ] * k ) ) / coins[ d ];
                                                for ( int l = 1; l <= lend; l++ )
                                                {
                                                    int mend = ( 200 - ( coins[ a ] * i ) - ( coins[ b ] * j ) - ( coins[ c ] * k ) - ( coins[ d ] * l ) ) / coins[ e ];
													for ( int m = 1; m <= mend; m++ )
													{

                                                        int sum = ( coins[ a ] * i ) + ( coins[ b ] * j ) + ( coins[ c ] * k ) + ( coins[ d ] * l ) + ( coins[ e ] * m );
                                                        if ( sum == 200 )
                                                        {
                                                            res++;
                                                            //Console.WriteLine($"{i}x{coins[ a ]}p + {j}x{coins[ b ]}p + {k}x{coins[ c ]}p + {l}x{coins[ d ]}p + {m}x{coins[ e ]}p");
                                                        }
													}
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                return res;
			}

            else if ( pair_in == 6  )
            {
                for ( int a = 0; a < coins.Count - 5; a++ )
                {
                    for ( int b = a + 1; b < coins.Count - 4; b++ )
                    {
                        for ( int c = b + 1; c < coins.Count - 3; c++ )
                        {
                            for ( int d = c + 1; d < coins.Count - 2; d++ )
                            {
                                for ( int e = d + 1; e < coins.Count - 1; e++ )
                                {
                                    for ( int f = e + 1; f < coins.Count; f++ )
                                    {

                                        int iend = 200 / coins[ a ];
                                        for ( int i = 1; i <= iend; i++ )
                                        {
                                            int jend = ( 200 - ( coins[ a ] * i ) ) / coins[ b ];
                                            for ( int j = 1; j <= jend; j++ )
                                            {
                                                int kend = ( 200 - ( coins[ a ] * i ) - ( coins[ b ] * j ) ) / coins[ c ];
                                                for ( int k = 1; k <= kend; k++ )
                                                {
                                                    int lend = ( 200 - ( coins[ a ] * i ) - ( coins[ b ] * j ) - ( coins[ c ] * k ) ) / coins[ d ];
                                                    for ( int l = 1; l <= lend; l++ )
                                                    {
                                                        int mend = ( 200 - ( coins[ a ] * i ) - ( coins[ b ] * j ) - ( coins[ c ] * k ) - ( coins[ d ] * l ) ) / coins[ e ];
                                                        for ( int m = 1; m <= mend; m++ )
                                                        {
                                                            int nend = ( 200 - ( coins[ a ] * i ) - ( coins[ b ] * j ) - ( coins[ c ] * k ) - ( coins[ d ] * l ) - ( coins[ e ] * m ) ) / coins[ f ];
                                                            for ( int n = 1; n <= nend; n++ )
                                                            {


                                                                int sum = ( coins[ a ] * i ) + ( coins[ b ] * j ) + ( coins[ c ] * k ) + ( coins[ d ] * l ) + ( coins[ e ] * m ) + ( coins[ f ] * n );
                                                                if ( sum == 200 )
                                                                {
                                                                    res++;
                                                                    //Console.WriteLine($"{i}x{coins[ a ]}p + {j}x{coins[ b ]}p + {k}x{coins[ c ]}p + {l}x{coins[ d ]}p + {m}x{coins[ e ]}p + {n}x{coins[ f ]}p");
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                return res;
            }

            else if ( pair_in == 7 )
            {
                for ( int a = 0; a < coins.Count - 6; a++ )
                {
                    for ( int b = a + 1; b < coins.Count - 5; b++ )
                    {
                        for ( int c = b + 1; c < coins.Count - 4; c++ )
                        {
                            for ( int d = c + 1; d < coins.Count - 3; d++ )
                            {
                                for ( int e = d + 1; e < coins.Count - 2; e++ )
                                {
									for ( int f = e + 1; f < coins.Count - 1; f++ )
									{
                                        for ( int g = f + 1; g < coins.Count; g++ )
                                        {



                                            int iend = 200 / coins[ a ];
                                            for ( int i = 1; i <= iend; i++ )
                                            {
                                                int jend = ( 200 - ( coins[ a ] * i ) ) / coins[ b ];
                                                for ( int j = 1; j <= jend; j++ )
                                                {
                                                    int kend = ( 200 - ( coins[ a ] * i ) - ( coins[ b ] * j ) ) / coins[ c ];
                                                    for ( int k = 1; k <= kend; k++ )
                                                    {
                                                        int lend = ( 200 - ( coins[ a ] * i ) - ( coins[ b ] * j ) - ( coins[ c ] * k ) ) / coins[ d ];
                                                        for ( int l = 1; l <= lend; l++ )
                                                        {
                                                            int mend = ( 200 - ( coins[ a ] * i ) - ( coins[ b ] * j ) - ( coins[ c ] * k ) - ( coins[ d ] * l ) ) / coins[ e ];
                                                            for ( int m = 1; m <= mend; m++ )
                                                            {
                                                                int nend = ( 200 - ( coins[ a ] * i ) - ( coins[ b ] * j ) - ( coins[ c ] * k ) - ( coins[ d ] * l ) - ( coins[ e ] * m ) ) / coins[ f ];
                                                                for ( int n = 1; n <= nend; n++ )
                                                                {

                                                                    int oend = ( 200 - ( coins[ a ] * i ) - ( coins[ b ] * j ) - ( coins[ c ] * k ) - ( coins[ d ] * l ) - ( coins[ e ] * m ) - ( coins[ f ] * n ) ) / coins[ g ];
																	for ( int o = 1; o <= oend; o++ )
																	{
                                                                        int sum = ( coins[ a ] * i ) + ( coins[ b ] * j ) + ( coins[ c ] * k ) + ( coins[ d ] * l ) + ( coins[ e ] * m ) + ( coins[ f ] * n ) + ( coins[ g ] * o );
                                                                        if ( sum == 200 )
                                                                        {
                                                                            res++;
                                                                            //Console.WriteLine($"{i}x{coins[ a ]}p + {j}x{coins[ b ]}p + {k}x{coins[ c ]}p + {l}x{coins[ d ]}p + {m}x{coins[ e ]}p + {n}x{coins[ f ]}p");

																	    }   


                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
									}
                                }
                            }
                        }
                    }
                }
                return res;
            }

            return 0;
		}
    }
}
