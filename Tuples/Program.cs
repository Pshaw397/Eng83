using System;

namespace Tuples
{
    public class Calculator
    {
        public static int Add(int x, int y)
        {
            return x + y;
        }
    }
    public class Program
    {
        //public static (int xsquared, bool y_gt_10) DoThat(int x, string y) // making a function where the return is a tuple that contains multiple variables
        //{
        //    Console.WriteLine(y);
        //    var z = (x > 10);
        //    return (x * x, z); // returns xsquared, y_gt_10
        //}

        public static int DoThat(int x, string y) 
        {
            Console.WriteLine(y);
            return (x * x); 
        }

        //public static int DoThis(int x, string y, out bool z)
        //{
        //    Console.WriteLine(y);
        //    z = (x > 10);
        //    return x * x;
        //}

        //public static void DoThat(int x, string y, out int xSquared, out bool y_gt_10) // x + y are the values being sent in, xSquared and y_gt_10 are the values that are going to be sent out
        //{
        //    Console.WriteLine(y);
        //    y_gt_10 = (x > 10);
        //    xSquared = x * x;
        //    // When we call on this function it stores the out variables that we can reference in the call statment)
        //}

        //public static void TripleCalc(int a, int b, int c, out int sum)
        //{
        //    sum = a + b + c;
        //    // This is the first version of an overloaded method, here we are returning the sum as an out parameter
        //}

        //public static (int sum, int product) TripleCalc(int a, int b, int c)
        //{
        //    var s = a + b + c;
        //    var p = a * b * c;
        //    return (s, p);
        //    // Here is a the second version of an overloaded method, here we are returning the sum and product as a tuple
        //}

        // Martins Example of above overload examples (below)

        public static int TripleCalc(int a, int b, int c, out int sum)
        {
            sum = a + b + c;
            return a * b * c;
        }
        public static (int sum, int product) TripleCalc(int a, int b, int c)
        {
            return (a + b + c, a * b * c);
        }

        static void Main(string[] args)
        {
            //var aTuple = ("My", "Name", 25); // assign multiple values to a variable in a short list
            //Console.WriteLine(aTuple);
            //Console.WriteLine(aTuple.Item3);

            //var aNamedTuple = (fname : "Eric", lName: "The Half Bee", age: 123); // assign a sub variable name to each value in the tuple
            //Console.WriteLine(aNamedTuple);
            //Console.WriteLine(aNamedTuple.lName);

            //var result = DoThat(10, "This is a string");
            //Console.WriteLine(result);
            //Console.WriteLine(result.xsquared);
            //var (square, greaterThan10) = DoThat(5, "What?????"); // This is creating another tuple (greaterThan10) and assigning it with the specified values after they are put through the DoThat method
            ////Console.WriteLine(greaterThan10);

            //var result = DoThis(10, "out test string", out bool isLarge); // This is setting "Result" to a tuple, that contained the returned values from the DoThis function
            //Console.WriteLine(isLarge);

            //DoThat(5, "string!", out int xs, out bool ygt10); // This allows us to return multiple values, without having the function have a return type
            //Console.WriteLine(xs);
            //Console.WriteLine(ygt10);
            // first two values are sent in, , the second two are the out variables that are returned

            //TripleCalc(1, 2, 3, out int sumResult);
            //Console.WriteLine(sumResult);

            //var tupleResult = TripleCalc(1, 4, 9); // We set tupleResult as a tuple that contained the values after the have been put through the tuple overload function
            //Console.WriteLine(tupleResult.sum);
            //Console.WriteLine(tupleResult.product);
            // We retrive the values by returning the variable sub names we delcared in the method

            // Martin's results example of overload function example
            
            //var product = TripleCalc(2, 3, 4, out int sum);
            //Console.WriteLine(product + " : " + sum);

            //var tuple = TripleCalc(4, 5, 6);
            //Console.WriteLine(tuple.product + ":" + tuple.sum
            
            // In Martin's example, he set the out method as a return method and returned the sum as an out variable and returned the proudct as the method return value
        }
    }
}
