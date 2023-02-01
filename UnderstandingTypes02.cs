using System.ComponentModel;
using System.IO;
using System.Text;

public class UnderstandingTypes02
{
    public static void Main(String[] args)
    {
        //Q1();
        //Q2();
        
    }

    public static void Q1()
    {
        Console.WriteLine("sbyte: number of bytes in memory:{0}, Maximum value is {1}, and Minmum value is {2}", sizeof(sbyte), sbyte.MaxValue, sbyte.MinValue);
        Console.WriteLine("byte: number of bytes in memory:{0}, Maximum value is {1}, and Minmum value is {2}", sizeof(byte), byte.MaxValue, byte.MinValue);
        Console.WriteLine("short: number of bytes in memory:{0}, Maximum value is {1}, and Minmum value is {2}", sizeof(short), short.MaxValue, short.MinValue);
        Console.WriteLine("ushort: number of bytes in memory:{0}, Maximum value is {1}, and Minmum value is {2}", sizeof(ushort), ushort.MaxValue, ushort.MinValue);
        Console.WriteLine("int: number of bytes in memory:{0}, Maximum value is {1}, and Minmum value is {2}", sizeof(int), int.MaxValue, int.MinValue);
        Console.WriteLine("uint: number of bytes in memory:{0}, Maximum value is {1}, and Minmum value is {2}", sizeof(uint), uint.MaxValue, uint.MinValue);
        Console.WriteLine("long: number of bytes in memory:{0}, Maximum value is {1}, and Minmum value is {2}", sizeof(long), long.MaxValue, long.MinValue);
        Console.WriteLine("ulong: number of bytes in memory:{0}, Maximum value is {1}, and Minmum value is {2}", sizeof(ulong), ulong.MaxValue, ulong.MinValue);
        Console.WriteLine("float: number of bytes in memory:{0}, Maximum value is {1}, and Minmum value is {2}", sizeof(float), float.MaxValue, float.MinValue);
        Console.WriteLine("double: number of bytes in memory:{0}, Maximum value is {1}, and Minmum value is {2}", sizeof(double), double.MaxValue, double.MinValue);
        Console.WriteLine("decimal: number of bytes in memory:{0}, Maximum value is {1}, and Minmum value is {2}", sizeof(decimal), decimal.MaxValue, decimal.MinValue);
    }
    public static void Q2()
    {
        Console.WriteLine("Please input centuries");
        try
        {
            uint centuries = Convert.ToUInt32(Console.ReadLine());
            uint years = 100 * centuries;
            ulong days = (ulong)(years * 365.2425);
            ulong hours = 24 * days;
            ulong minutes = 60 * hours;
            ulong seconds = 60 * minutes;
            StringBuilder sb = new StringBuilder(Convert.ToString(seconds));
            string milliseconds = sb.Append("000").ToString();
            string microseconds = sb.Append("000").ToString();
            string nanoseconds = sb.Append("000").ToString();
            Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes = {5} seconds = {6} milliseconds = {7} microseconds = {8} nanoseconds", centuries, years, days, hours, minutes, seconds, milliseconds, microseconds, nanoseconds);
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

    }
    //Controlling Flow and Converting Types
    //Test your Knowledge
    //1. What happens when you divide an int variable by 0?
    // it will throw an exception that a value is divided by 0
    //2. What happens when you divide a double variable by 0?
    // it will return infinity symbol 
    //3. What happens when you overflow an int variable, that is, set it to a value beyond its range?
    // When overflow happen, c# only caculate value withion the allocated address.
    //4. What is the difference between x = y++; and x = ++y;?
    // x will add previous y that doesn't add 1 in "x = y++". x will add y that already add 1 in "x = ++y"
    //5. What is the difference between break, continue, and return when used inside a loop statement?
    // break will leave current loop
    // continue will ignore after code in current block and start next iterator
    // return will return value to the parent function excuting current function and run parent function
    //6. What are the three parts of a for statement and which of them are required?
    // first part for initialize values in this block
    // second part loop check
    // third one is processing after each iterator
    // second part is required or loop can't end
    //7. What is the difference between the = and == operators ?
    // = caculator operator and will allocate right to left value
    // == is check operator and will don't change value in each values that run this operator
    //8.Does the following statement compile? for ( ; true; ) ;
    // yes
    //9. What does the underscore _ represent in a switch expression?
    // work as default
    //10. What interface must an object implement to be enumerated over by using the foreach statement ?
    // IEnumerable interface 


}