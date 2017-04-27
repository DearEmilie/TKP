using SmallBasicFun;

namespace SimpleSquare
{
	public class SimpleSquare
	{
		public static void Main()
		{
            Tortoise.Show();
            Tortoise.SetSpeed(10);

		    var random = new System.Random();


		    for (int i = 0; i < 100; i++)
		    {
                Tortoise.Turn(random.NextDouble() * 360);
                Tortoise.Move(20);
            }
            
            //var sides = 42;

            //for (int spins = 1; spins < sides; spins++)
            //{
            //    for (int i = 0; i < sides; i++)
            //    {
            //        Tortoise.SetPenColor(Colors.GetRandomColor());
            //        Tortoise.Move(100);
            //        Tortoise.Turn((360.0 * spins)/sides);
            //    }

            //          System.Threading.Thread.Sleep(1000);
            //          ProgramWindow.Clear();
            //          Tortoise.Show();
            //      }
        }
	}
}