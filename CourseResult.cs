using System;
namespace student;

class Program
{
    static void Main(string[] args)
    {

        Console.Write("Enter your name? ");
        string name = Console.ReadLine();
        Console.Write("Enter your mark? ");
        double m = double.Parse(Console.ReadLine());

        CourseResult c1 = new CourseResult();

        c1.Mark = m;

        c1.PrintResult(name, m);
    }

}
class CourseResult
{
    public string sName { get; set; }

    private double mark;
    public double Mark
    {
        get { return mark; }
        set
        {
            if (value >= 0 && value <= 100)
            { mark = value; }
        }
    }
    public string Grade
    {
        get
        {
            if (mark >= 90)
            { return "A"; }
            else if (mark >= 80)
            { return "B"; }
            else if (mark >= 70)
            { return "C"; }
            else if (mark >= 50)
            { return "D"; }
            else
            { return "F"; }
        }
    }
    public string Passed
    {
        get
        {
            if (mark >= 50)
            { return "Pass"; }
            else
            { return "fail"; }
        }

    }

    public void PrintResult(string name, double mark)
    {
        Console.WriteLine($"Mark is: {mark}");
        Console.WriteLine($"Grade is: {Grade}");
        Console.WriteLine($"Passed is: {Passed}");

    }
}
