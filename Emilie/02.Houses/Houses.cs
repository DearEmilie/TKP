using SmallBasicFun;

namespace Houses
{
	public class Houses
	{
		public static void main(string[] args)
		{
		    Tortoise.Show();
            Tortoise.SetSpeed(10);
            Tortoise.SetX(200);
		    drawHouse(40);
            drawHouse(120);
            drawHouse(90);
            drawHouse(20);
		}

	    private static void drawHouse(int height)
	    {
	        Tortoise.SetPenColor(Colors.GetRandomColor());
	        Tortoise.Move(height);
	        Tortoise.Turn(90);
	        Tortoise.Move(30);
	        Tortoise.Turn(90);
	        Tortoise.Move(height);
	        Tortoise.Turn(-90);
	        Tortoise.Move(20);
	        Tortoise.Turn(-90);
	    }
	}
}