using System;

namespace parlindrome_program
{
	class strRev
	{
		static void Main(string[] args)
		{
			static void palindromestring(char[] name)
			{
				bool palindrome = true;
				int i, j, n;
				n = name.Length;
				for (i = 0, j = n - 1; i < n / 2; i++, j--)
				{
					if (name[i] != name[j])
					{
						palindrome = false;
						break;
					}
				}
				Console.WriteLine("Palindrome: " + palindrome);
			}
		}
		class program
		{
			static void main(string[] args)
			{
				char[] name = new char[10];
				Console.WriteLine("enter the word");
				name = Console.ReadLine().ToCharArray();
				new strRev().palindromestring(name);
			}
		}
