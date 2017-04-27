using SmallBasicFun;

namespace SimpleSquare
{
	public class SimpleSquare
	{
		public static void Main()
		{
            Tortoise.Show();
            Tortoise.SetSpeed(10);

            var sides = MessageBox.AskForInput("How many sides?");
            
            for (int spins = 1; spins < sides; spins++)
            {
                for (int i = 0; i < sides; i++)
                {
                    Tortoise.SetPenColor(Colors.GetRandomColor());
                    Tortoise.Move(100);
                    Tortoise.Turn((360.0 * spins) / sides);
                }

                System.Threading.Thread.Sleep(100);
                //ProgramWindow.Clear();
                Tortoise.Show();
            }
        }
	}
}