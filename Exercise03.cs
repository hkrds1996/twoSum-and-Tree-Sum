using System.Text;

public class Exercise03
{
    public static void Main(string[] args)
    {
        //Q1();
        //Q1_2();
        //Q1_3();
        //Q2(10);
        //Q4("08/25/1996");
        //Q5();
        //Q6();
    }

    public static string[] Q1()
    {
        string[] result = new string[100];
        for (int i = 1; i <= 100; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                result[i - 1] = "fizzbuzz";
            }
            else if (i % 3 == 0)
            {
                result[i - 1] = "fizz";
            }
            else if (i % 5 == 0)
            {
                result[i - 1] = "buzz";
            }
            else
            {
                result[i - 1] = Convert.ToString(i);
            }
            Console.WriteLine(result[i-1]);
        }
        return result;
    }

    public static void Q1_2()
    {
        int max = 500;
        try
        {
            checked
            {
                for (byte i = 0; i < max; i++)
                {

                    Console.WriteLine(i);
                }
            }            
        }
        catch (OverflowException e)
        {
            Console.WriteLine(e.ToString());
        }
    }
    public static void Q1_3()
    {
        int correctNumber = new Random().Next(3) + 1;
        try
        {
            while (true)
            {
                Console.WriteLine("Please Guess Value");
                int guessValue = Convert.ToInt32(Console.ReadLine());
                if (guessValue > 3 || guessValue < 1)
                {
                    Console.WriteLine("Unvaild Enter, please guess 1,2,3");
                }
                else if(guessValue==correctNumber)
                {
                    Console.WriteLine("you are right");
                    break;
                }
                else
                {
                    Console.WriteLine("please guess again");
                }
            }

        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
    public static void Q2(int level)
    {
        int maxLength = 2 * level - 1;
        int currStarNumber = 1;
        for(int i = 0; i < level; ++i)
        {
            StringBuilder sb = new StringBuilder();
            int currLeftSpace = (maxLength - currStarNumber) / 2;
            for(int j = 0; j < currLeftSpace; ++j)
            {
                sb.Append(" ");
            }
            for(int j = 0; j < currStarNumber; ++j)
            {
                sb.Append("*");
            }
            for(int j = 0; j < currLeftSpace; ++j)
            {
                sb.Append(" ");
            }
            currStarNumber += 2;
            Console.WriteLine(sb.ToString()); 
        }
    }
    public static void Q3()
    {
        int correctNumber = new Random().Next(3) + 1;
        try
        {
            while (true)
            {
                Console.WriteLine("Please Guess Value");
                int guessValue = Convert.ToInt32(Console.ReadLine());
                if (guessValue > 3 || guessValue < 1)
                {
                    Console.WriteLine("Unvaild Enter, please guess 1,2,3");
                }
                else if (guessValue == correctNumber)
                {
                    Console.WriteLine("you are right");
                    break;
                }
                else
                {
                    Console.WriteLine("please guess again");
                }
            }

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
    public static void Q4(String input)
    {
        String[] strings = input.Split('/');
        int year = Convert.ToInt32(strings[2]);
        int month = Convert.ToInt32(strings[0]);
        int day = Convert.ToInt32(strings[1]);
        DateTime preDate = new DateTime(year, month, day);
        
        DateTime today = DateTime.Now;
        var differentDate = (today - preDate);
        Console.WriteLine("next 10,000 day (about 27 years) anniversary is {0}", 10000 - (differentDate.Days) % 10000);
    }
    public static void Q5()
    {
        DateTime today = DateTime.Now;
        int time = today.Hour;
        if(time >=6 && time < 12)
        {
            Console.WriteLine("Good Morning");
        }
        if(time>=12 && time < 18) {
            Console.WriteLine("Good Afternoon");
        }
        if(time>=18 && time < 24) {
            Console.WriteLine("Good Afternoon");
        }
        if (time > 0 && time < 6)
        {
            Console.WriteLine("Good Evening");
        }
    }
    public static void Q6()
    {
        for(int i = 1; i <= 4; ++i)
        {
            int currValue = 0;
            while (currValue <= 24)
            {
                if (currValue == 24)
                {
                    Console.WriteLine(currValue);
                    break;
                }
                Console.Write(currValue + " ");
                currValue += i;
            }
        }
    }
}