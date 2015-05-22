using System;

namespace kata
{
    public class StringCalculator
    {
        public int add(string empty)
        {
            char[] delimeter = {','};
            int addition=0;
            if (empty.Equals(""))
                return 0;
            else if (empty.Length==1)
                return Convert.ToInt32(empty); 

            string[] numbers = empty.Split(delimeter);

            foreach (string number in numbers)
                addition = addition + Convert.ToInt32(numbers.ToString());

            return addition;

        }
    }
}