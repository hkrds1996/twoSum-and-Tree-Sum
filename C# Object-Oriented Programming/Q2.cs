using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Q2{
    internal abstract class People
    {
        public string? Name { get; set; }
        public abstract void DoSomeThing();

        public void Type()
        {
            Console.WriteLine("I'm a persion");
        }
    }

    class Student : People
    {
        public override void DoSomeThing()
        {
            Console.WriteLine("I'm a student");
        }
    }
    class Teacher : People
    {

        public override void DoSomeThing()
        {
            Console.WriteLine("I'm a Teacher");
        }
    }
}
