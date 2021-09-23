using System;

public abstract class Student
{
    protected string name;
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    protected int id;
    public int ID 
    {
        get { return id; }
    }

    protected static int count = 0;
    public Student(string name)
    {
        id = ++count;
        Name = name;
    }
    public Student()
    {
        id = ++count;
        name = "No name";
    }

    public override string ToString()
    {
        string info = "Student name: " + name + ", ID: " + id + ", Rank: " + Rank();
        return info;
    }

    public abstract string Rank();
}
