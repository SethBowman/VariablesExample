namespace VariablesExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables

            //Number Types
            //Declaring a variable (creation)
            int wholeNumber;
            //Initialize a variable (give it value)
            wholeNumber = 100;

            //Or do both
            int otherNumber = 100;

            double avg;
            avg = 98.5;

            decimal money = 500.00m;

            //Word types
            string myName = "Seth Bowman";

            char key = '1';

            //True/False
            bool isCoding = false;


            //String Interpolation
            Console.WriteLine($"My name is {myName}. The number {wholeNumber} is a whole number and {avg} is not.");


        }
    }
}