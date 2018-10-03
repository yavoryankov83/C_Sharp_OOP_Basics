using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Family
{
    private List<Person> persons;

    public Family()
    {
        this.persons = new List<Person>();
    }

    public void AddMember(Person person)
    {
        this.persons.Add(person);
    }

    public Person GetOldestMember()
    {
        return this.persons.OrderByDescending(p => p.Age).First();
    }
}

