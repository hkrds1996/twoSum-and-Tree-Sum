using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

abstract class Person
{
    public DateTime BirthDate { get; set; }
    public int GetAge()
    {
        DateTime currDate = DateTime.Now;
        var age = currDate - BirthDate;
        return (int)(age.Days % 365.2425);
    }
    public double Salary { get; set; }
    public abstract double GetSalary();

    public List<string> Addresses { get; set; } = new List<string>();

}

class Instructor : Person
{
    public bool IsHead { get; set; }
    public string? Department { get; set; }
    public DateTime JoinDate { get; set; }

    public override double GetSalary()
    {
        DateTime currDate = DateTime.Now;
        var age = currDate - JoinDate;
        return Salary + age.Days;
    }
}

class Student : Person
{
    public List<Tuple<string, double, double>> courses { get; set; } = new List<Tuple<string, double, double>>();
    public override double GetSalary()
    {
        return Salary;
    }
    public double GetGPA()
    {
        double totalGPA = 0;
        double currGPA = 0;
        foreach (Tuple<string, double, double> t in courses)
        {

            currGPA = (currGPA * totalGPA + t.Item2) / (totalGPA + t.Item3);
            totalGPA += t.Item3;
        }
        return currGPA;
    }
    public String GetCourseGPA(string courseName)
    {
        var course = courses.First(x => x.Item1.Equals(courseName));
        double currGPA = course.Item3;
        if (currGPA == 4.0)
        {
            return "A";
        }
        else if (currGPA >= 3.0)
        {
            return "B";
        }
        else if (currGPA >= 2.0)
        {
            return "C";
        }
        else if (currGPA >= 1.0)
        {
            return "D";
        }
        else
        {
            return "F";
        }
    }
}

class Course
{
    public List<Student> StudentList { get; set; }=new List<Student>();
}

class Department
{
    public Instructor? Head { get; set; }
    public List<Course> CourseList { get; set; } = new List<Course>();

    public List<Tuple<Double,DateTime,DateTime>> Buget { get; set; } = new List<Tuple<Double,DateTime,DateTime>>();
}
