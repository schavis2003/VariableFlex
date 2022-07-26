using System;

namespace VariableFlex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaring and intializing a variable
            //cameCase for the variable name
            //explicit typing

            string dogName = "Prince";
            int dogAge = 7;
            char nickName = "R";
            bool lovesFishing = true;
            double beachBalls = 17;
            decimal weight = 90.5;

            //string interpolation with the $ and {} around variables

            Console.WriteLine($"My dog's name is {dogName}. He is {dogAge} years old and has
                {beachBalls} beachBalls and it is {lovesFishing} that he love to fish, which keeps his 
                weight of {weight}");

            // PLASE HELP WITH WHY IM GETTING AN ERROR AT LINE  23.

                if (lovesFishing == true)
            {
                Console.WriteLine($" {dogName} loves to fishing!");
            }

            else
            {
                Console.WriteLine($"{dogName} hates fishing!")
            }
            
                 
        }
    }
}