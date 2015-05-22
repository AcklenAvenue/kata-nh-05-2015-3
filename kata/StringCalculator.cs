using System;

namespace kata
{
    public class StringCalculator
    {
        public int add(string empty)
        {
            if (empty.Equals(""))
                return 0;
            
            return Convert.ToInt32(empty); 
        }
    }
}