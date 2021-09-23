using System;

public class BTECStudent : Student
{
    private string grade;

    public string Grade 
    {
        get { return grade; }
        set { grade = value; } // HW: validate value must be "P", "M", "D", else => "P"
    }

    public BTECStudent() 
    {
        grade = "P";
    }

    public BTECStudent(string name, string grade) : base(name)
    {
        Grade = grade;
    }

    public override string Rank()
    {
        if (grade == "M") return "Merit";
        else if (grade == "D") return "Distinction";
        else return "Normal";
    }
}