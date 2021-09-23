using System;


public class TopupStudent : Student
{
    private int grade;
    public int Grade 
    {
        get { return grade; }
        set { grade = value; } // HW: validate valude in [0, 100]
    }
    public TopupStudent()
    {
        grade = 40;
    }
    public TopupStudent(string name, int grade) : base(name)
    {
        Grade = grade;
    }

    public override string Rank()
    {
        if (grade >= 80) return "Distinction";
        else if (grade >= 60) return "Merit";
        else return "Normal";
    }
}