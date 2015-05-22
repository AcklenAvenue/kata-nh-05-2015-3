using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Machine.Specifications;

namespace kata.specs
{
    public class when_single_number
    {
        static StringCalculator calculator;
        static int result;
        Establish context = () =>
        {
            calculator = new StringCalculator();
            
        };

        Because of = () =>
        {
            result = calculator.add("1");
        };

        It should_return_same_number = () => { result.ShouldEqual(1); };
    }

}
