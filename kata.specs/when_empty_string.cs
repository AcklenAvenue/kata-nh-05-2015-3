using Machine.Specifications;

namespace kata.specs
{
    public class when_empty_string
    {
        static StringCalculator calculator;
        static int result;
        Establish context = () =>
        {
            calculator = new StringCalculator();
        };

        Because of = () =>
        {
            result = calculator.add("");
        };

        It should_return_zero = () => { result.ShouldEqual(0); };
    }
}