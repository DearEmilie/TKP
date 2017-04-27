using System;
using Microsoft.SmallBasic.Library;
using SmallBasicFun;

namespace SimpleSquare
{
	public class SimpleSquareHomework
	{
		// How to do homework:
		// Step 1: Press the Run Button (Ctrl+F5)
		// Step 2: Read the name of the Method that Failed
		// Step 3: Fill in the blank (___) to make it pass
		// Step 4: Repeat Until Enlightment
		// Do not change anything except the blank (___)

		private static void numbersdonotneedquotes()
		{
			Homework.CheckAnswer(21+21, equals, 42);
		}

		private static void defaultwidthforthetortoise()
		{
			Homework.CheckAnswer(2, equals, Tortoise.GetPenWidth());
		}

		private static void stringsneedquotes()
		{
			Homework.CheckAnswer("Green", equals, "Green");
		}

		private static void stringscanincludespaces()
		{
			Homework.CheckAnswer("This is a string" , equals, "This is a string");
		}

		private static void defaultcolorforthetortoise()
		{
			Homework.CheckAnswer("Black", equals, Tortoise.GetPenColor());
		}

		private static void changingthepenwidthto5()
		{
			Tortoise.SetPenWidth(5);
			Homework.CheckAnswer(5, equals, Tortoise.GetPenWidth());
		}

		private static void changingthepencolortogreen()
		{
			Tortoise.SetPenColor("Green");
			Homework.CheckAnswer(Tortoise.GetPenColor(), equals, "Green");
		}

		private static void movingthetortoise100pixels()
		{
			var start = Tortoise.GetY();
			Tortoise.Move(100);
			Homework.CheckAnswer(Tortoise.GetY(), equals, start - 100);
		}

		private static void thetortoiseturns21()
		{
			Tortoise.Turn(21);
			Homework.CheckAnswer(Tortoise.GetAngle(), equals, 21);
		}

		private static void thetortoiseturns15twice()
		{
			var ans = 15;
			Tortoise.Turn(ans);
			Tortoise.Turn(ans);
			Homework.CheckAnswer(Tortoise.GetAngle(), equals, 30);
		}

		private static void howfastcanthetortoisego()
		{
			Tortoise.SetSpeed(10);
			Homework.CheckAnswer(Tortoise.GetSpeed(), equals, topSpeed);
			//Hint: Right Click SetSpeed then select 'Go to Declaration' 
		}

		private static void assigningvariables()
		{
			Primitive numberOfToes = 10;
			Homework.CheckAnswer(10, equals, numberOfToes);
		}

		private static void combiningnumbers()
		{
			Primitive age = 3 + 4;
			Homework.CheckAnswer(7, equals, age);
		}

		private static void combiningtext()
		{
			Primitive name = "Peter" + " " + "Pan";
			Homework.CheckAnswer("Peter Pan", equals, name);
		}

		private static void combiningtextandnumbers()
		{
			Primitive name = "Henry The " + 8;
			Homework.CheckAnswer(___, equals, name);
		}

		private static void combiningtextinaloop()
		{
			Primitive sound = "A";
			for (int i = 1; i <= 3; i++)
			{
				sound = sound + "H";
			}
			Homework.CheckAnswer(___, equals, sound);
		}

		private static void forloopsendattheend()
		{
			Primitive numbers = "@";
			for (int i = 1; i <= ___; i++)
			{
				numbers = numbers + i;
			}
			Homework.CheckAnswer(numbers, equals, "@12345");
		}

		private static void forloopscanstartanywhere()
		{
			Primitive answer = "Because ";
			for (int i = ___; i <= 9; i++)
			{
				answer = answer + i;
			}
			//Question: Why is 7 the most feared number ?
			Homework.CheckAnswer(answer, equals, "Because 789");
		}

		private static void forloopscanskip()
		{
			Primitive numbers = "@";
			for (int i = 1; i <= 20; i += ___)
			{
				PreventInfiniteLoop();
				numbers = numbers + i + ",";
			}
			Homework.CheckAnswer(numbers, equals, "@1,3,5,7,9,11,13,15,17,19,");
		}

		private static void forloopscangobackwards()
		{
			Primitive numbers = "Countdown: ";
			for (int i = 5; i >= 1; i += ___)
			{
				PreventInfiniteLoop();
				numbers = numbers + i;
			}
			Homework.CheckAnswer(numbers, equals, "Countdown: 54321");
		}

		#region Ignore

		public static void Main()
		{
			Homework.StartSimpleSquareHomeworkAt += numbersdonotneedquotes;
		}
		private static void PreventInfiniteLoop()
		{
			if (infiniteLoopCount++ > 4000)
			{
				throw new Exception("You have created an infinite loop.");
			}
		}

		private static readonly Primitive ___ = "Fill in the blank ___";
		private static readonly Primitive ____ = 1;

		private static readonly Primitive topSpeed = 10;
		private static readonly Primitive equals = "=";
		private static int infiniteLoopCount = 0;

		#endregion
	}
}