using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Q4
{
    internal abstract class People
    {
        public string? Name { get; set; }
        public abstract void DoSomeThing();

        public void Type()
        {
            Console.WriteLine("I'm a persion");
        }
    }
}
