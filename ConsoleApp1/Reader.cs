using System;

namespace Usr1
{
    public class Reader
    {
        public double ReadValue(string message)
        {
            string enteredValue;
            double value;
            bool isValidInput = true;

            do
            {
                Console.Clear();

                if (!isValidInput)
                {
                    Console.WriteLine("Invalid Input, Please Try Again...");
                }
                
                Console.Write(message);
                enteredValue = Console.ReadLine();
                isValidInput = Double.TryParse(enteredValue, out value);
            } while (!isValidInput);

            return value;
        }
    }
}
