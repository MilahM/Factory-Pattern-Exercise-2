

namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What database would you like to use?");

            var userAnswer = Console.ReadLine();

            IDataAccess userInput = DataAccessFactory.GetDataAccessType(userAnswer);

            
            userInput.LoadData();

            userInput.SaveData();

            

        }
    }
}
