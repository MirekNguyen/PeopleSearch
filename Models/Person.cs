using System.Collections.Generic;
using System;

class Person
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public DateTime Birthday { get; set; }
    public Person(string name, string surname, DateTime birthday)
    {
        Name = name;
        Surname = surname;
        Birthday = birthday;
    }
    public int age()
    {
        DateTime today = DateTime.Today;
        int age = today.Year - Birthday.Year;
        if (Birthday > today.AddYears(-age))
        {
            age--;
        }
        return age;
    }
    public override string ToString()
    {
        return $"{Name} {Surname} | " + Birthday.ToString("yyyy-MM-dd") + $" | age: {age()}";
    }
    public static void printList(List<Person> people)
    {
        foreach (var person in people)
        {
            Console.WriteLine(person);
        }

    }
}