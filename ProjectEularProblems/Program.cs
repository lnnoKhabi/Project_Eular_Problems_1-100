using System;
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
using System.Text;

namespace ProjectEularProblems
{
	public class Problems
	{

		//Summary:
		//Project Eular
		static void Main( string[] args )
		{

			Stopwatch sp = new Stopwatch();
			sp.Start();

			GoldbachOtherConjecture();
			sp.Stop();

			Console.WriteLine("\nruntime: " + sp.ElapsedMilliseconds/1000.0 + "s");
			Console.ReadLine();
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
				if ( res == 0 )
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
					else if ( j == less )
					{
						c++;
					}
				}
				if ( c == 10001 )
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
		public static async void MovesInGrid( int grid )
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
			Task t = new Task(() =>
			{
				for ( int i = grid * 2; i > 1; i-- )
				{
					n = MultiplyLongNums(i.ToString(), n);
				}
			});
			t.Start();
			await t;

			string r = "1";
			string rbyr = "";

			Task t2 = new Task(() =>
			{
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

				Console.WriteLine(number + ". " + result);
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
					Console.Write(ns + "  ");
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
			Console.WriteLine(c + " sundays.");
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

			Console.WriteLine("100! = " + res);
			Console.WriteLine("sum: " + Array.ConvertAll(res.ToArray(), a => int.Parse(a.ToString())).Sum());
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
				for ( int j = 1; j <= i / 2; j++ )
				{
					if ( i % j == 0 )
					{
						sum += j;
					}
				}
				//find divisors of [sum of divisors of i] and add them together
				int new_sum = 0;
				for ( int k = 1; k <= sum / 2; k++ )
				{
					if ( sum % k == 0 )
					{
						new_sum += k;
					}
				}
				//determine if d(i) == sum && d(sum) == i && i != sum
				if ( i == new_sum && i != sum )
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
			using ( StreamReader sr = new StreamReader("./Problem22.txt") )
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
					sum += ( int ) cha - 64;
				}
				c += sum * ( i + 1 );

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
				if ( divisors_sum > i )
				{
					AbundantNumbers.Add(i);
				}
			}

			HashSet<int> NumsMadeBy_Abundant = new HashSet<int>();
			//get all nums made my 2 abundant nums
			for ( int a = 0; a < AbundantNumbers.Count; a++ )
			{
				for ( int b = a; b < AbundantNumbers.Count; b++ )
				{
					NumsMadeBy_Abundant.Add(AbundantNumbers[ a ] + AbundantNumbers[ b ]);
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

		private static int fact( int i )
		{
			if ( i <= 1 )
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
					new_P[ x + c ] = P[ i ];
					c++;
				}

				P = new_P;
				if ( j + 2 == 1000000 )
				{
					Console.Write("index: " + ( j + 2 ) + " is ");
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
			for ( int i = 3; n.Length < 1000; i++ )
			{
				n = AddLongNums(x, y);
				x = y;
				y = n;
				f = "F" + ( i + 1 );
			}
			Console.WriteLine(f + " is: " + n);
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
						if ( !betterPrime(res) )
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
			for ( int i = 3; i <= end; i += counter )
			{
				sum += i;
				checker += 1;
				counter = checker == 4 ? counter + 2 : counter;
				checker = checker == 4 ? 0 : checker;
			}
			Console.WriteLine(sum + 1);
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
				res = ( int ) sum == i ? res + i : res;
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
		private static int PairNumber( int pair_in, List<int> coins )
		{
			int res = 0;

			//for pairing each coin by itself
			if ( pair_in == 1 )
			{
				//Console.WriteLine($"1x200p");
				//for ( int i = 0; i < coins.Count; i++ )
				//            {
				//    Console.WriteLine($"{200/coins[i]}x{coins[i]}p");
				//}
				return coins.Count + 1;
			}
			//for pairing every coin by 1 other coin
			else if ( pair_in == 2 )
			{
				for ( int a = 0; a < coins.Count - 1; a++ )
				{
					for ( int b = a + 1; b < coins.Count; b++ )
					{
						int iend = 200 / coins[ a ];
						for ( int i = 1; i <= iend; i++ )
						{
							int jend = ( 200 - ( coins[ a ] * i ) ) / coins[ b ];
							for ( int j = 1; j <= jend; j++ )
							{
								int sum = ( coins[ a ] * i ) + ( coins[ b ] * j );
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

			else if ( pair_in == 3 )
			{
				for ( int a = 0; a < coins.Count - 2; a++ )
				{
					for ( int b = a + 1; b < coins.Count - 1; b++ )
					{
						for ( int c = b + 1; c < coins.Count; c++ )
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
										int sum = ( coins[ a ] * i ) + ( coins[ b ] * j ) + ( coins[ c ] * k );
										if ( sum == 200 )
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

			else if ( pair_in == 4 )
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
												int sum = ( coins[ a ] * i ) + ( coins[ b ] * j ) + ( coins[ c ] * k ) + ( coins[ d ] * l );
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

			else if ( pair_in == 5 )
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

			else if ( pair_in == 6 )
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

		//PROBLEM 32
		/* We shall say that an n-digit number is pandigital if it makes use of all the digits 1 to n exactly once; for example, the 5-digit number, 15234, is 1 through 5 pandigital.

        The product 7254 is unusual, as the identity, 39 × 186 = 7254, containing multiplicand, multiplier, and product is 1 through 9 pandigital.

        Find the sum of all products whose multiplicand/multiplier/product identity can be written as a 1 through 9 pandigital.

        HINT: Some products can be obtained in more than one way so be sure to only include it once in your sum.
        */

		public static void PandigitalProducts()
		{
			Stopwatch clock = Stopwatch.StartNew();

			HashSet<int> Identity = new HashSet<int>();
			HashSet<int> sum = new HashSet<int>();

			for ( int i = 1; i <= 99; i++ )
			{
				for ( int j = i + 1; j <= 9999; j++ )
				{
					string i_num = i.ToString();
					string j_num = j.ToString();
					int product = i * j;
					string product_num = product.ToString();
					string s = $"{i_num}{j_num}{product_num}";
					if ( s.Contains("0") || s.Length < 9 )
					{
						goto end;
					}

					//check if multiplicand is pandigital
					foreach ( char num in i_num )
					{
						int x = int.Parse(num.ToString());
						if ( !Identity.Add(x) )
						{
							goto end;
						}
					}
					//check if multiplier is pandigital
					foreach ( char num in j_num )
					{
						int x = int.Parse(num.ToString());
						if ( !Identity.Add(x) )
						{
							goto end;
						}
					}
					//check if product is pandigital
					foreach ( char num in product_num )
					{
						int x = int.Parse(num.ToString());
						if ( !Identity.Add(x) )
						{
							goto end;
						}
					}

					bool isPanDig = Identity.Contains(0) ? false : Identity.Sum() == 45 ? true : false;

					if ( isPanDig && sum.Add(product) )
					{
						Console.WriteLine($"{i} x {j} = {product}");
					}


				end:
					Identity.Clear();
				}
			}
			Console.WriteLine($"sum of all pandigital products : {sum.Sum()}");
			Console.WriteLine("Solution took {0} ms", clock.ElapsedMilliseconds);
		}

		//faster way ( NOT MY SOLUTION)
		public static void BruteForce()
		{
			Stopwatch clock = Stopwatch.StartNew();

			List<long> products = new List<long>();
			long sum = 0;
			long prod, compiled;

			for ( long m = 2; m < 100; m++ )
			{
				long nbegin = ( m > 9 ) ? 123 : 1234;
				long nend = 10000 / m + 1;

				for ( long n = nbegin; n < nend; n++ )
				{
					prod = m * n;
					compiled = concat(concat(prod, n), m);
					if ( compiled >= 1E8 && compiled < 1E9 && isPandigital(compiled) )
					{
						if ( !products.Contains(prod) )
						{
							Console.WriteLine($"{m} x {n} = {prod}");
							products.Add(prod);
						}
					}
				}
			}

			for ( int i = 0; i < products.Count; i++ )
			{
				sum += products[ i ];
			}

			Console.WriteLine("The sum of all pan digital number from 1-9 is {0}", sum);
			Console.WriteLine("Solution took {0} ms", clock.ElapsedMilliseconds);
		}
		private static long concat( long a, long b )
		{

			long c = b;
			while ( c > 0 )
			{
				a *= 10;
				c /= 10;
			}

			return a + b;
		}
		private static bool isPandigital( long n )
		{
			int digits = 0;
			int count = 0;
			int tmp;

			while ( n > 0 )
			{
				tmp = digits;
				digits = digits | 1 << ( int ) ( ( n % 10 ) - 1 ); //The minus one is there to make 1 fill the first bit and so on
				if ( tmp == digits )
				{ //Check to see if the same digit is found multiple times
					return false;
				}

				count++;
				n /= 10;
			}

			return digits == ( 1 << count ) - 1;
		}

		//PROBLEM 33
          /*The fraction 49/98 is a curious fraction, as an inexperienced mathematician in attempting to simplify it may incorrectly believe that 49/98 = 4/8, which is correct, is obtained by cancelling the 9s.

            We shall consider fractions like, 30/50 = 3/5, to be trivial examples.

            There are exactly four non-trivial examples of this type of fraction, less than one in value, and containing two digits in the numerator and denominator.

            If the product of these four fractions is given in its lowest common terms, find the value of the denominator.
         */
		public static double DigitCancellingFracts()
		{
			double res = 1.0d;
			for ( int n = 10; n < 100; n++ )//numerator
			{
				for ( int d = n + 1; d < 100; d++ )//denominator
				{
					if ( n % 10 == 0 || d % 10 == 0 )//If the numerator or denominator are mod 10, skip it
					{
						continue;
					}
					//if the numerator and denominator share a common digit
					char common = 'a';
					bool shares = false;
					string[] n_d = new string[] { n.ToString(), d.ToString() };
					foreach ( char item in n_d[ 0 ] )
					{
						if ( n_d[ 1 ].Contains(item) )
						{
							shares = true;
							common = item;
							break;
						}
					}
					if ( shares )
					{
						//divide numerator and denominator and store the result in ‘expected’
						double expected = ( double ) n / ( double ) d;
						//remove the common digit from numerator and denominator (generating num’ and denom’)
						n_d[ 0 ] = n_d[ 0 ].Remove(n_d[ 0 ].IndexOf(common), 1);
						n_d[ 1 ] = n_d[ 1 ].Remove(n_d[ 1 ].IndexOf(common), 1);

						//divide num’ and denom’ and compare the result to ‘expected
						double exp = double.Parse(n_d[ 0 ]) / double.Parse(n_d[ 1 ]);
						if ( expected == exp )//if the results match then I have found one of the four answers
						{
							Console.WriteLine($"{n}/{d}");
							res *= exp;
						}
					}
				}
			}
			//report answer
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("product of all four curious fracts is: " + res);
			return res;
		}

		//PROBLEM 34
		/*145 is a curious number, as 1! + 4! + 5! = 1 + 24 + 120 = 145.

		Find the sum of all numbers which are equal to the sum of the factorial of their digits.

		Note: As 1! = 1 and 2! = 2 are not sums they are not included.*/
		public static void DigitFactorials()
		{
			//calculate factorials of 0 - 9
			int[] facts = new int[ 10 ];
			for ( int i = 0; i < 10; i++ )
			{
				facts[ i ] = fact(i);
			}
			int res = 0;
			//find curious numbers
			for ( int i = 10; i < 100000; i++ )
			{
				string num = i.ToString();
				int sum = 0;
				//add values
				foreach ( char item in num )
				{
					sum += facts[ int.Parse(item.ToString()) ];
				}
				if ( sum == i )
				{
					res += sum;
					Console.WriteLine(i);
				}
			}
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("sum: " + res);
		}

		//PROBLEM 35
/*The number, 197, is called a circular prime because all rotations of the digits: 197, 971, and 719, are themselves prime.

		   There are thirteen such primes below 100: 2, 3, 5, 7, 11, 13, 17, 31, 37, 71, 73, 79, and 97.

		   How many circular primes are there below one million?
		*/
		public static void CircularPrimes()
		{
			int max = 1000000;
			int[] primes = new int[ max ];
			int count = 0;
			//find all primes below 1million
			for ( int i = 2; i < max; i++ )
			{
				bool isp = true;
				if ( primes[ i ] != i )
				{
					isp = betterPrime(i);
				}

				if ( isp )
				{
					//store primes
					primes[ i ] = i;
					List<char> num = i.ToString().ToList();
					for ( int j = 1; j < num.Count; j++ )
					{
						//rotate the number
						num.Add(num[ 0 ]);
						num.RemoveAt(0);

						//check if rotations are circular primes
						int rot = int.Parse(new string(num.ToArray()));

						if ( primes[ rot ] == 0 )//not in array and could be prime
						{
							if ( betterPrime(rot) )//is prime
							{
								primes[ rot ] = rot;//add to array
							}
							else//not prime 
							{
								break;//exit loop
							}
						}
						count = j == num.Count - 1 ? count + 1 : count;
					}
				}
			}
			Console.WriteLine($"there are {count + 4} circular primes below {max}.");
		}
		private static bool betterPrime( int number )
		{
			if ( number == 2 )
			{
				return true;
			}
			if ( number % 2 == 0 || number == 1 )
			{
				return false;
			}
			double sq = Math.Sqrt(number);
			for ( int i = 3; i <= sq; i += 2 )
			{
				if ( number % i == 0 )
				{
					return false;
				}
			}
			return true;
		}


		//PROBLEM 36
		/*The decimal number, 585 = 10010010012 (binary), is palindromic in both bases.

        Find the sum of all numbers, less than one million, which are palindromic in base 10 and base 2.

        (Please note that the palindromic number, in either base, may not include leading zeros.)*/
		private static void DoubleBasePalindromes()
		{
			int sum = 0;
			for ( int i = 0; i < 1000000; i++ )
			{
				string straight = i.ToString();
				string reverse = null;
				for ( int j = straight.Length - 1; j >= 0; j-- )//reverse number
				{
					reverse += straight[ j ];
				}

				if ( i == int.Parse(reverse) )//if palindromic in base 10
				{
					string bin_straight = Convert.ToString(i, 2);
					string bin_reverse = null;
					for ( int k = bin_straight.Length - 1; k >= 0; k-- )//reverse binary number
					{
						bin_reverse += bin_straight[ k ];
					}
					if ( i == Convert.ToInt32(bin_reverse, 2) )//if palindromic in base 2
					{
						Console.WriteLine($"{i} = {bin_straight}");
						sum += i;
					}
				}
			}
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine($"sum = {sum}");
		}

		//PROBLEM 37
		/*The number 3797 has an interesting property. Being prime itself, it is possible to continuously remove digits from left to right, and remain prime at each stage: 3797, 797, 97, and 7. Similarly we can work from right to left: 3797, 379, 37, and 3.

        Find the sum of the only eleven primes that are both truncatable from left to right and right to left.

        NOTE: 2, 3, 5, and 7 are not considered to be truncatable primes.*/
		public static void TrancactiblePrimes()
		{
			int max = 1000000;
			int[] primes = new int[ max ];
			int sum = 0;
			//find all primes below 1million
			for ( int i = 10; i < max; i++ )
			{
				bool isp = true;
				if ( primes[ i ] != i )
				{
					isp = betterPrime(i);
				}

				if ( isp )
				{
					primes[ i ] = i;

					//remove digits left to right
					string num = i.ToString();
					for ( int j = 0; j < num.Length - 1; j++ )
					{
						string n = null;
						for ( int k = j + 1; k < num.Length; k++ )
						{
							n += num[ k ];
						}
						int new_n = int.Parse(n);
						if ( primes[ new_n ] == 0 )
						{
							if ( betterPrime(new_n) )
							{
								primes[ new_n ] = new_n;
							}
							else goto end;
						}
					}
					//remove digits right to left
					for ( int j = 0; j < num.Length - 1; j++ )
					{
						string n = num.Remove(num.Length - 1 - j);
						if ( n != null )
						{
							int new_n = int.Parse(n);
							if ( primes[ new_n ] == 0 )//either not prime or not calculated
							{
								if ( betterPrime(new_n) )//is it prime
								{
									primes[ new_n ] = new_n;
								}
								else goto end;
							}
						}
					}

					Console.WriteLine(i);
					sum += i;
				}
			end:
				continue;
			}
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine($"sum of all trunctable primes = {sum}");
		}

		//PROBLEM 38
		/*Take the number 192 and multiply it by each of 1, 2, and 3:

		 192 × 1 = 192
		 192 × 2 = 384
		 192 × 3 = 576
		 By concatenating each product we get the 1 to 9 pandigital, 192384576. We will call 192384576 the concatenated product of 192 and(1,2,3)

		 The same can be achieved by starting with 9 and multiplying by 1, 2, 3, 4, and 5, giving the pandigital, 918273645, which is the concatenated product of 9 and(1,2,3,4,5).

		 What is the largest 1 to 9 pandigital 9-digit number that can be formed as the concatenated product of an integer with(1,2, ... , n) where n > 1?*/
		public static void PandigitalMultiples()
		{
			HashSet<int> pandigits = new HashSet<int>();
			for ( int i = 1; i < 10000; i++ )
			{
				for ( int n = 1; n < 10; n++ )
				{
					string prod = (i * n).ToString();
					for ( int item = 0; item < prod.Length;item++ )
					{
						if(prod[item] == '0') { goto next; }
						if ( pandigits.Add(int.Parse(prod[ item ].ToString())) )
						{
							if ( pandigits.Count == 9 && item == prod.Length - 1)
							{
								Console.Write($"{i} when n == {n} : ");
								foreach ( int num in pandigits )
								{
									Console.Write(num);
								}
								Console.WriteLine();
								goto next;
							}
						}
						else 
						{ 
							goto next; 
						}
					}
				}
			next:
				pandigits.Clear();
			}
		}


		//PROBLEM 39
		/*If p is the perimeter of a right angle triangle with integral length sides, {a,b,c}, there are exactly three solutions for p = 120.

		{20,48,52}, {24,45,51}, {30,40,50}

		For which value of p ≤ 1000, is the number of solutions maximised?*/
		public static void IntegerRightTriangles()
		{
			
			double res = 0;
			double count = 0;
			for ( int p = 1; p <= 1000; p++ )
			{
				int solutions_count = 0;
				for ( int a = p/6; a < p / 2; a++ )
				{
					for ( int b = a + 1; b < (p / 2) ; b++ )
					{
						double c = p - ( a + b );
						if ( ( a * a ) + ( b * b ) == c * c )
						{
							solutions_count++;
							//Console.WriteLine($"p: {p} ==> {{{a},{b},{c}}}");
						}
					}
				}
				count = solutions_count > res ? p : count;
				res = solutions_count > res ? solutions_count : res;
				
			}
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine(count + " has the most solutions.");
		}


		//PROBLEM 40
		/*An irrational decimal fraction is created by concatenating the positive integers:

		0.123456789101112131415161718192021...

		It can be seen that the 12th digit of the fractional part is 1.

		If dn represents the nth digit of the fractional part, find the value of the following expression.

		d1 × d10 × d100 × d1000 × d10000 × d100000 × d1000000*/

		public static void ChampernownesConstant()
		{
			
			StringBuilder st = new StringBuilder(1000000);

			int digits_count = 0;
			int z = 1;
			double end = 0;
			//find how far we need to iterate to have 1 million terms
			for ( int i = 9; i <= 99999; i = int.Parse($"{ i}9 ") )
			{
				int x = ( i.ToString().Length ) * ( i - z );
				digits_count += x;
				z *= 10;

				end = i == 99999 ? Math.Ceiling(((1000000.0d - digits_count) * ( double.Parse($"{ i}9 ") - z) / (( double.Parse($"{ i}9 ") - z) * 6.0d))) + z : 0;
			}

			//store sequence of terms
			for ( int i = 1;i <= end; i++ )
			{
				st.Append(i);
			}

			//get 10, 100, 1000, 10000, 1000000 term and multiply together
			int res = 1;
			for ( int i = 9; i <= 999999; i = int.Parse($"{ i}9 ") )
			{
				res *= int.Parse(st[ i ].ToString());
			}
			Console.WriteLine($"{st[0]}x{st[ 9 ]}x{st[ 99 ]}x{st[ 999 ]}x{st[ 9999 ]}x{st[ 99999 ]}x{st[ 999999 ]} ==> {res}");
		}

		//PROBLEM 41
		/*We shall say that an n-digit number is pandigital if it makes use of all the digits 1 to n exactly once. For example, 2143 is a 4-digit pandigital and is also prime.

		What is the largest n-digit pandigital prime that exists?*/
		public static void PandigitalPrime()
		{
			List<int> nums = new List<int>(1000);
			string minus = "1111111111";
			for ( int i = 123456789; i >= 10; i-=int.Parse(minus) )
			{
				stringPermutation(i.ToString(),0,i.ToString().Length-1,nums);

				minus = minus.Remove(minus.Length - 1, 1);
			}
			Console.WriteLine($"Largest pandigital prime : {nums.Max()}");

		}
		//permutation algorithm not mine (need to study it)
		private static void stringPermutation( string str, int left, int right , List<int> ls)
		{
			if ( left == right )
			{
				//Console.WriteLine(str);
				if ( betterPrime(int.Parse(str)) )
				{
					ls.Add(int.Parse(str));
					//Console.WriteLine($"Largest pandigital prime : {str}");
					return;
				}
			}
			else
			{
				for ( int i = left; i <= right; i++ )
				{
					//swap(str[ left ], str[ i ]);
					char[] lft = str.ToCharArray();
					char c = str[ i ];
					lft[ i ] = lft[ left ];
					lft[ left ] = c;
					str = new string(lft);

					stringPermutation(str, left + 1, right,ls);
					//swap(str[ left ], str[ i ]); //swap back for backtracking
					lft = str.ToCharArray();
					c = str[ i ];
					lft[ i ] = lft[ left ];
					lft[ left ] = c;
					str = new string(lft);
				}
			}
		}


		//PROBLEM 42
		/*The nth term of the sequence of triangle numbers is given by, tn = ½n(n+1); so the first ten triangle numbers are:

		1, 3, 6, 10, 15, 21, 28, 36, 45, 55, ...

		By converting each letter in a word to a number corresponding to its alphabetical position and adding these values we form a word value. For example, the word value for SKY is 19 + 11 + 25 = 55 = t10. If the word value is a triangle number then we shall call the word a triangle word.

		Using words.txt (right click and 'Save Link/Target As...'), a 16K text file containing nearly two-thousand common English words, how many are triangle words?*/
		public static void CodedTriangleNumbers()
		{
			int res = 0;
			//end at 1300 bcoz the longest word cant be bigger than 50 letters i.e 50 * 26(the largest possible value a letter can be) == 1300)
			int[] sequence = new int[ 1300 ];
			for ( int i = 1; i < 1300; i++ )
			{
				sequence[ i ] = (int)(( 1.0 / 2.0 *  i  ) * ( i + 1.0 ));
			}
			using ( StreamReader sr = new StreamReader("./p042_words.txt") )
			{
				string[] words = sr.ReadToEnd().Split(',');
				foreach ( string word in words )
				{
					int count = 0;
					foreach ( char c in word.Replace("\"", "") )
					{
						count += c - 64;//utf-8 code minus 'A' which is 64
					}
					res = sequence.Contains(count) ? res + 1 : sequence.Max() >= count ? res : -10000;
				}
			}
			Console.WriteLine($"There are {res} triangle words.");
		}

		//PROBLEM 43
		/*The number, 1406357289, is a 0 to 9 pandigital number because it is made up of each of the digits 0 to 9 in some order, but it also has a rather interesting sub-string divisibility property.

		Let d1 be the 1st digit, d2 be the 2nd digit, and so on. In this way, we note the following:

		d2d3d4=406 is divisible by 2
		d3d4d5=063 is divisible by 3
		d4d5d6=635 is divisible by 5
		d5d6d7=357 is divisible by 7
		d6d7d8=572 is divisible by 11
		d7d8d9=728 is divisible by 13
		d8d9d10=289 is divisible by 17
		Find the sum of all 0 to 9 pandigital numbers with this property.*/
		public static void Sub_stringDivisibility()
		{
			List<string> PanDigits = new List<string>(3628800);
			FindPanDig0_9("0123456789", 0, 9, PanDigits);
			int[] primes = {0, 2, 3, 5, 7, 11, 13, 17 };
			string sum = "0";
			bool passd = true ;
			for ( int i = 0; i < PanDigits.Count; i++ )
			{
				passd = true;
				for ( int j = 1; j < PanDigits[i].Length-2; j++ )
				{
					string substr = PanDigits[ i ].Substring(j, 3);
					if(int.Parse(substr) % primes[j] != 0 )
					{
						passd = false;
						break;
					}
				}
				sum = passd ? AddLongNums(sum, PanDigits[ i ]) : sum;
			}
			Console.WriteLine($"Sum of 0 - 9 pandigital numbers: {sum}");
		}

		private static void FindPanDig0_9(string str, int left, int right, List<string> ls)
		{
			if ( left == right )
			{
				ls.Add(str);
			}
			else
			{
				for ( int i = left; i <= right; i++ )
				{
					//swap(str[ left ], str[ i ]);
					char[] lft = str.ToCharArray();
					char c = str[ i ];
					lft[ i ] = lft[ left ];
					lft[ left ] = c;
					str = new string(lft);

					FindPanDig0_9(str, left + 1, right, ls);
					//swap(str[ left ], str[ i ]); //swap back for backtracking
					lft = str.ToCharArray();
					c = str[ i ];
					lft[ i ] = lft[ left ];
					lft[ left ] = c;
					str = new string(lft);
				}
			}
		}


		//PROBLEM 44
		/*Pentagonal numbers are generated by the formula, Pn=n(3n−1)/2. The first ten pentagonal numbers are:

		1, 5, 12, 22, 35, 51, 70, 92, 117, 145, ...

		It can be seen that P4 + P7 = 22 + 70 = 92 = P8. However, their difference, 70 − 22 = 48, is not pentagonal.

		Find the pair of pentagonal numbers, Pj and Pk, for which their sum and difference are pentagonal and D = |Pk − Pj| is minimised; what is the value of D?*/

		public static void PentagonNumbers()
		{
			int pJ = 0;
			int pK = 0;
			int diff = 0;
			int sum = 0;
			double p = 0;
			for ( int i = 1; i < 3000; i++ )
			{
				pJ = ( i * ( ( ( 3 * i ) - 1 ) ) ) / 2;

				for ( int j = i + 1; j < 3000 ; j++ )
				{
					pK = ( j * ( ( ( 3 * j ) - 1 ) ) ) / 2;
					diff = pK - pJ;
					sum = pJ + pK;

					if( isPent(diff,ref p) && isPent(sum, ref p) )//check if the sum and diff are pentagon nums
					{
						Console.WriteLine($"D is p{i}(pJ - Pk)p{j} |{pJ} - {pK}|  = {Math.Abs(pJ - pK)}");
						goto end;
					}
				}
			}
			end:
			return;
		}

		private static bool isPent(long sum_diff, ref double P)
		{
			//use the quadratic expression to check is sum is a pantagon num
			double a = 3.0d;
			double b = -1.0d;
			double c = -( sum_diff * 2.0 );

			double root = Math.Sqrt(( b * b ) - ( 4 * a * c ));

			//note use minus on (+ / -)
			double res = ( b - root ) / (2 * a) ;
			P = !res.ToString().Contains('.') ? res : 0;

			return !res.ToString().Contains('.');
		}

		//PROBLEM 45
		/*Triangle, pentagonal, and hexagonal numbers are generated by the following formulae:

		Triangle	 	Tn=n(n+1)/2	 	1, 3, 6, 10, 15, ...
		Pentagonal	 	Pn=n(3n−1)/2	 	1, 5, 12, 22, 35, ...
		Hexagonal	 	Hn=n(2n−1)	 	1, 6, 15, 28, 45, ...
		It can be verified that T285 = P165 = H143 = 40755.

		Find the next triangle number that is also pentagonal and hexagonal.*/
		public static void TriangularPentagonalHexagonal()
		{
			long  T = 0;
			bool P = false;
			bool H = false;
			double h = 0;
			double p = 0;
			
			for ( long n = 286; ; n++ )// Tn
			{
				T = ( n * ( n + 1 ) ) / 2;//triangular num
				P = isPent(T,ref p) ? true : false;//is it a pentagonal num too
				H = P ? isHexa(T,ref h) : false;//is it hexagonal too
				if ( H ) 
				{ 
					Console.WriteLine($"T{n} = P{Math.Abs(p)} = H{Math.Abs(h)} = {Math.Abs(T)}");
					break; 
				}
			}
		}
		private static bool isHexa( long num , ref double H )
		{
			//use the quadratic expression to check is sum is a pantagon num
			double a = 2.0d;
			double b = 1.0d;
			double c = -( num );

			double root = Math.Sqrt(( b * b ) - ( 4 * a * c ));

			//note use minus on (+ / -)
			double res = ( b + root ) / ( 2 * a );
			H = !res.ToString().Contains('.') ? res : 0; 
			return !res.ToString().Contains('.');
		}


		//PROBLEM 46
		/*It was proposed by Christian Goldbach that every odd composite number can be written as the sum of a prime and twice a square.

		9 = 7 + 2 × 1^2
		15 = 7 + 2 × 2^2
		21 = 3 + 2 × 3^2
		25 = 7 + 2 × 3^2
		27 = 19 + 2 × 2^2
		33 = 31 + 2 × 1^2

		It turns out that the conjecture was false.

		What is the smallest odd composite that cannot be written as the sum of a prime and twice a square?*/

		public static void GoldbachOtherConjecture()
		{
			int[] primes = new int[ 1000000 ];
			bool is_odd_combosite = false;
			//find odd composite numbers e.g 9 , 15 21 (divisible by numbers other than 1 and itself, and odd)
			for ( int i = 9; ; i++ )
			{
				is_odd_combosite = i % 2 != 0 ? !betterPrime(i) : false;
				if ( is_odd_combosite )
				{
					for ( int j = 2; j < i; j++ )//loop prime numbers
					{
						bool pr = primes[ j ] != 0 ? true : betterPrime(j);
						if ( pr )
						{
							primes[ j ] = j;
							int sqr = (int)Math.Sqrt(i);
							for ( int k = 1; k < sqr; k++ )//loop possible squares
							{
								if( j + ( ( k * k ) * 2 ) == i )
								{
									//Console.WriteLine($"{i} = {j} + 2 x {k}^2");
									goto nxt_i;
								}
								if (j + ((k * k) * 2) != i && j == i-1 && k == sqr - 1)
								{
									Console.ForegroundColor = ConsoleColor.Green;
									Console.WriteLine($"{i} cannot be written as the sum of a prime and twice a square.");
									Console.ForegroundColor = ConsoleColor.White;
									return;
								}
							}
						}
					}

				}
				primes[ i ] = i;
			nxt_i:
				continue;
			}
		}
	}
}

