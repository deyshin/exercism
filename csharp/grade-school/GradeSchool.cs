using System;
using System.Collections.Generic;
using System.Linq;

public class School
{
    private List<Student> studentList;
    public School()
    {
        studentList = new List<Student>();
    }
    public void Add(string student, int grade)
    {
        studentList.Add(new Student(student,grade));
    }

    public IEnumerable<string> Roster()
    {
        return studentList
                .Select(s => s.Name)
                .OrderBy(s => s)
                .ToArray();
    }

    public IEnumerable<string> Grade(int grade)
    {
        return studentList
                .Where(s => s.Grade == grade)
                .Select(s => s.Name)
                .OrderBy(s => s)
                .ToArray();
    }

    public class Student
    {
        public string Name {get; private set;}
        public int Grade {get; private set;}
        public Student(string n, int g)
        {
            Name = n;
            Grade = g;
        }
    }
}