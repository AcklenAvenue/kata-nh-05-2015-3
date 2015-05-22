using System;

namespace kata
{
    public class StringCalculator
    {
        public int add(string empty)
        {
            char[] delimeter = {','};
            
            if (empty.Equals(""))
                return 0;
            else if (empty.Length==1)
                return Convert.ToInt32(empty); 

            string[] numbers = empty.Split(delimeter);

            return Convert.ToInt32(numbers[0]) + Convert.ToInt32(numbers[1]);

        }
    }
}