using System;


namespace EivindsConsoleAppCore
{
	class Program
	{
		static void Main(string[] args)
		{
			// WriteStory();
			// StringMethods();
			// NumberMethods();
			// Interaction();
			// Calculator();
			// MadLibGame();
			// Arrays();
			// SayHi("Eivind", 28);
			// Console.WriteLine(Cube(5));
			// IfStatementsIntro();
			// Console.WriteLine(GetMax(10, 20, 8));
			// BetterCalculator();
			// Console.WriteLine(GetDay(3));
			// WhileLoops();
			// GuessingGame();
			// ForLoops();
			// Console.WriteLine(GetPow(3, 2));
			// TwoDimensionalArrays();
			// Comments();
			// ExceptionHandling();
			ClassesAndObjects();

			// https://www.youtube.com/watch?v=GhQdlIFylQ8
		}

		private static void ClassesAndObjects()
		{
			Book book1 = new Book();
			book1.title = "Harry Potter";
			book1.author = "JK Rowling";
			book1.pages = 400;

			Console.WriteLine(book1.title);

		}

	private static void ExceptionHandling()
		{
			try
			{
				Console.Write("Enter a number: ");
				int num1 = Convert.ToInt32(Console.ReadLine());
				Console.Write("Enter another number: ");
				int num2 = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine(num1 / num2);
			}
			catch (DivideByZeroException e)
			{
				PrintFullErrorMessage(e);
			}
			catch (FormatException e)
			{
				PrintFullErrorMessage(e);
			}
			finally
			{
				// Things that should always be executed
			}
		}

		private static void PrintFullErrorMessage(Exception e)
		{
			Console.WriteLine("Message: " + e.Message +
							  "\n\nData: " + e.Data +
							  "\n\nHResult: " + e.HResult +
							  "\n\nHelpLink: " + e.HelpLink +
							  "\n\nInner Exception: " + e.InnerException +
							  "\n\nSource: " + e.Source +
							  "\n\nStack Trace: " + e.StackTrace +
							  "\n\nTarget Site: " + e.TargetSite);
		}

		private static void Comments()
		{
			
			// This is a single line comment

			/* This is a multi line comment
			 * Continuation
			 */

			Console.WriteLine("Comments are fun");
		}

		private static void TwoDimensionalArrays()
		{
			int[,] numberGrid =
			{
				{1, 2},
				{3, 4},
				{5, 6}
			};

			// Gir en 2D-array med 2 RADER og 3 KOLONNER (altsaa foerst rader og saa kolonner)
			int[,] myArray = new int[2,3];

			Console.WriteLine(numberGrid[1, 1]);
		}

		private static int GetPow(int baseNum, int powNum)
		{
			int result = 1;

			for (int i = 0; i < powNum; i++)
			{
				result = result * baseNum;
			}

			return result;
		}

		private static void ForLoops()
		{
			int[] luckyNumbers = {4, 8, 15, 16, 23, 42};
			for (int i = 0; i < luckyNumbers.Length; i++)
			{
				Console.WriteLine(luckyNumbers[i]);
			}
		}

		private static void GuessingGame()
		{
			string secretWord = "giraffe";
			string guess = "";
			int guessCount = 0;
			int guessLimit = 3;
			bool outOfGuesses = false;

			while (guess != secretWord && !outOfGuesses)
			{
				if (guessCount < guessLimit)
				{
					Console.Write("Enter guess: ");
					guess = Console.ReadLine();
					guessCount++;
				}
				else
				{
					outOfGuesses = true;
				}
			}

			if (outOfGuesses)
			{
				Console.WriteLine("You lose!");
			}
			else
			{
				Console.Write("You Win!");
			}
		}

		private static void WhileLoops()
		{
			int index = 1;
			while (index <= 5)
			{
				Console.WriteLine(index);
				index++;
			}

			index = 6;
			do
			{
				Console.WriteLine(index);
				index++;
			} while (index <= 5);
		}

		private static string GetDay(int dayNum)
		{
			string dayName;

			switch (dayNum)
			{
				case 0: 
					dayName = "Sunday";
					break;
				case 1: 
					dayName = "Monday";
					break;
				case 2: 
					dayName = "Tuesday";
					break;
				case 3:
					dayName = "Wednesday";
					break;
				case 4:
					dayName = "Thursday";
					break;
				case 5:
					dayName = "Friday";
					break;
				case 6:
					dayName = "Saturday";
					break;
				default:
					dayName = "Invalid Number";
					break;
			}


			return dayName;
		}

		private static void BetterCalculator()
		{
			Console.Write("Enter a number: ");
			double num1 = Convert.ToDouble(Console.ReadLine());

			Console.Write("Enter Operator: ");
			string op = Console.ReadLine();

			Console.Write("Enter another number: ");
			double num2 = Convert.ToDouble(Console.ReadLine());

			if (op == "+")
			{
				Console.WriteLine(num1 + num2);
			} else if (op == "-")
			{
				Console.WriteLine(num1 - num2);
			} else if (op == "*")
			{
				Console.WriteLine(num1 * num2);
			} else if (op == "/")
			{
				Console.WriteLine(num1 / num2);
			}
			else
			{
				Console.WriteLine("Can't recognize operator. Allowed values are +, -, * and /.");
			}
		}

		private static int GetMax(int num1, int num2, int num3)
		{
			int result;

			if (num1 >= num2 && num1 >= num3)
			{
				result = num1;
			} else if (num2 >= num1 && num2 >= num3)
			{
				result = num2;
			}
			else
			{
				result = num3;
			}

			return result;
		}

		static void IfStatementsIntro()
		{
			bool isMale = true;
			bool isTall = true;

			if (isMale && isTall)
			{
				Console.WriteLine("You are a tall male");
			} else if (isMale && !isTall)
			{
				Console.WriteLine("You are male, but you are not tall");

			} else if (!isMale && isTall)
			{
				Console.WriteLine("You are not a male, but you are tall");
			} else
			{
				Console.WriteLine("You are not male and not tall");
			}

			if (isMale || isTall)
			{
				Console.WriteLine("You are either tall or male or both");
			} else
			{
				Console.WriteLine("You are neither male, nor are you tall");
			}
		}

		static int Cube(int num)
		{
			return (int) Math.Pow(num, 3);
		}

		private static void SayHi(string name, int age)
		{
			Console.WriteLine("Hello, " + name + ", you are " + age + " years old. ");
		}

		private static void Arrays()
		{
			int[] luckyNumbers = {4, 8, 15, 16, 23, 42};
			Console.WriteLine(luckyNumbers[0]);

			luckyNumbers[1] = 900;
			Console.WriteLine(luckyNumbers[1]);

			string[] friends = new string[5];
			friends[0] = "Jim";
			friends[1] = "Kelly";
		}

		private static void MadLibGame()
		{
			string color, pluralNoun, celebrityName;

			Console.Write("Enter a color: ");
			color = Console.ReadLine();

			Console.Write("Enter a plural noun: ");
			pluralNoun = Console.ReadLine();

			Console.Write("Enter the name of a celebrity: ");
			celebrityName = Console.ReadLine();

			Console.WriteLine("Roses are " + color);
			Console.WriteLine(pluralNoun + " are blue");
			Console.WriteLine("I Love " + celebrityName);
			
		}

		private static void Calculator()
		{
			Console.Write("Enter the first number (decimals allowed): ");
			string firstNumberAsString = Console.ReadLine();
			double firstNumberAsDouble = Convert.ToDouble(firstNumberAsString);

			Console.Write("Enter the second number (decimals allowd): ");
			string secondNumberAsString = Console.ReadLine();
			double secondNumberAsDouble = Convert.ToDouble(secondNumberAsString);

			double result = firstNumberAsDouble + secondNumberAsDouble;

			Console.WriteLine("The first and second number added are " + result + ".");
		}

		private static void Interaction()
		{
			Console.Write("Enter your name: ");
			string nameInput = Console.ReadLine();
			Console.Write("Enter your age: ");
			string ageInput = Console.ReadLine();

			Console.WriteLine("Hello, " + nameInput + "!. You are " + ageInput + " years old.");
		}

		private static void NumberMethods()
		{
			Console.WriteLine();
			Console.WriteLine(-5.783);
			Console.WriteLine(5 % 2);

			Console.WriteLine((4 + 2) * 3);

			int num = 6;
			Console.WriteLine("Skriver ut tallet 6 og inkrementerer: " + num++);
			Console.WriteLine("Skriver ut tallet 7: " + num);

			Console.WriteLine(Math.Abs(-40));
			Console.WriteLine(Math.Pow(3, 2));
			Console.WriteLine(Math.Pow(3.8, 2));


			float resultWithFloat = (float)Math.Sqrt(99);
			double resultWithDouble = Math.Sqrt(99);
			decimal resultWithDecimal = (decimal)Math.Sqrt(99);

			Console.WriteLine("Float: " + resultWithFloat + "\nDouble: " + resultWithDouble + "\nDecimal: " + resultWithDecimal);

			Console.WriteLine(Math.Max(4, 90));
			Console.WriteLine(Math.Min(4, 90));
			Console.WriteLine(Math.Round(4.3));
		}

		private static void StringMethods()
		{
			string phrase = "Giraffe Academy";
			char grade = 'A';
			int age = 30;
			double gpa = 3.2;
			bool isMale = true;

			Console.WriteLine(false);
			Console.WriteLine(phrase);
			Console.WriteLine("Length of phrase: " + phrase.Length);
			Console.WriteLine("Inneholder phrase Adademy? " + phrase.Contains("Academy"));

			Console.WriteLine("Første bokstaven i phrase: " + phrase[0]);
			Console.WriteLine("Posisjonen til Academy: " + phrase.IndexOf("Academy"));
			Console.WriteLine("Substring med tre chars fra [8]: " + phrase.Substring(phrase.IndexOf("Academy"), 3));
		}

		private static void WriteStory()
		{
			string name = "Geir";
			int age = 70;

			Console.WriteLine("There once was a man named " + name);
			Console.WriteLine("He was " + age + " years old");

			name = "Mike";
			Console.WriteLine("He really liked the name " + name);
			Console.WriteLine("But didn't like being " + age);
		}
	}
}
