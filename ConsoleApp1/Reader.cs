using System;

namespace Usr1
{
    public class Reader
    {
        public double ReadValue(string message)
        {
            string enteredValue;
            double value;

            do
            {
                Console.Clear();
                
                Console.Write(message);
                enteredValue = Console.ReadLine();
            } while (!Double.TryParse(enteredValue, out value));

            return value;
        }
    }
}
