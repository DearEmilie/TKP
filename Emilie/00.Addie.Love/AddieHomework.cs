using SmallBasicFun;

namespace Emilie._00.Addie.Love
{
    public class AddieHomework
    {
        public static void Main()
        {
            AskAQuestion("What is the fifth letter in the alphabet?", "e");
            AskAQuestion("What is 5+5+1=?", "11");
            AskAQuestion("What does red and blue make?", "purple");
            AskAQuestion("What month is your birthday in?", "april");
            AskAQuestion("What is your last name?", "Deardorff");

            MessageBox.ShowMessage("All done!");
        }

        private static void AskAQuestion(string question, string answer)
        {
            while (true)
            {
                var guess = MessageBox.AskForInput(question);

                if (guess.ToString().ToLower() == answer.ToLower())
                    break;

                MessageBox.ShowMessage("That was incorrect.");
            }
        }
    }
}