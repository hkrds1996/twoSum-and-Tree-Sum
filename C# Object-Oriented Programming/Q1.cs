using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Q1{
    internal abstract class Courses
    {
        public abstract string ? Name { get; set; }
        public abstract int ClassId { get; set; }
       
        const int classType = -1;
    }

    class InDoorClass:Courses
    {
        const int classType = 0;
        public override int ClassId { get; set;} = 0;

        public override string ? Name { get; set; }

    }

    class Math : InDoorClass
    {
        int studentNumber;

        //overloading
        public Math() {
            studentNumber = 0;
        }
        //overloading
        public Math(int studentNumber)
        {           
            this.studentNumber = studentNumber;
        }
    }

    class OutDoorClass : Courses
    {
        const int classType = 1;
        public override int ClassId { get; set; } = 1;

        public override string? Name { get; set; }
    }
}