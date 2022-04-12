using System;
using System.Collections;

// Simple business object.
public class Person
{
    public Person(string fName, string lName)
    {
        this.firstName = fName;
        this.lastName = lName;
    }

    public string firstName;
    public string lastName;
}

// Collection of Person objects. This class
// implements IEnumerable so that it can be used
// with ForEach syntax.
public class People : IEnumerable
{
    private Person[] people;
    public People(Person[] pArray)
    {
        people = new Person[pArray.Length];

        for (int i = 0; i < pArray.Length; i++)
        {
            people[i] = pArray[i];
        }
    }

    // Implementation for the GetEnumerator method.
    IEnumerator IEnumerable.GetEnumerator()
    {
       return (IEnumerator) GetEnumerator();
    }

    public PeopleEnum GetEnumerator()
    {
        return new PeopleEnum(people);
    }
}

// When you implement IEnumerable, you must also implement IEnumerator.
public class PeopleEnum : IEnumerator
{
    public Person[] people;

    // Enumerators are positioned before the first element
    // until the first MoveNext() call.
    int position = -1;

    public PeopleEnum(Person[] list)
    {
        people = list;
    }

    public bool MoveNext()
    {
        position++;
        return (position < people.Length);
    }

    public void Reset()
    {
        position = -1;
    }

    object IEnumerator.Current
    {
        get
        {
            return Current;
        }
    }

    public Person Current
    {
        get
        {
            try
            {
                return people[position];
            }
            catch (IndexOutOfRangeException)
            {
                throw new InvalidOperationException();
            }
        }
    }
}

class App
{
    static void Main()
    {
        Person[] peopleArray = new Person[3]
        {
            new Person("John", "Smith"),
            new Person("Jim", "Johnson"),
            new Person("Sue", "Rabon"),
        };

        People peopleList = new People(peopleArray);
        
		foreach (Person p in peopleList)
            Console.WriteLine(p.firstName + " " + p.lastName);

    }
}

/* This code produces output similar to the following:
 *
 * John Smith
 * Jim Johnson
 * Sue Rabon
 *
 */