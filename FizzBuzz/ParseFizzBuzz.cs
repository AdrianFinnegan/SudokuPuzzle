using System.Collections.Generic;

namespace FizzBuzz
{
    public class ParseFizzBuzz
    {
        public Dictionary<int, string> Process(int listSize)
        {
            var response = new Dictionary<int, string>();

            
            for (int x = 1; x <= listSize; x++)
            {
                var fizz = (x%3==0) ? true: false;
                var buzz = (x % 5 == 0) ? true : false;
                var fizzAndBuzz = (x % 3 == 0 && x % 5 == 0) ? true : false;

                if(fizzAndBuzz) response.Add(x, "FizzBuzz");
                else if(fizz) response.Add(x, "Fizz");
                else if(buzz) response.Add(x, "Buzz");
            }

            return response;

        }
    }
}
