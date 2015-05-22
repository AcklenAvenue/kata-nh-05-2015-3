﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Machine.Specifications;

namespace kata.specs
{
    public class when_unknown_numbers
    {
        static StringCalculator calculator;
        static int result;
        Establish context = () =>
        {
            calculator = new StringCalculator();
            
        };

        Because of = () =>
        {
            result = calculator.add("1,2,3");
        };

        It should_return_sum = () => { result.ShouldEqual(6); };
    }

}
