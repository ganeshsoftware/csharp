using System;
using System.Collections;

// Simple business object.
public class Laptop
{
    public Laptop(string modelName, string brandName)
    {
        this.modelName = modelName;
        this.brandName = brandName;
    }

    string modelName;
    string brandName;
	
	public string ModelName
	{
		get { return modelName;}		
	}
	
	public string BrandName
	{
		get { return brandName;}		
	}
}

// Collection of Laptop objects. This class
// implements IEnumerable so that it can be used
// with ForEach syntax.
public class ClassRoom : IEnumerable
{
	private Laptop[] classRoom;	
	public ClassRoom(Laptop[] lapArray)
	{
        classRoom = new Laptop[lapArray.Length];

        for (int i = 0; i < lapArray.Length; i++)
        {
            classRoom[i] = lapArray[i];
        }
    }
	
	// Implementation for the GetEnumerator method.
    IEnumerator IEnumerable.GetEnumerator()
    {
       return (IEnumerator) GetEnumerator();
    }
	
	public LaptopEnum GetEnumerator()
    {
        return new LaptopEnum(classRoom);
    }
}

// When you implement IEnumerable, you must also implement IEnumerator.
public class LaptopEnum : IEnumerator
{
    public Laptop[] classroom;	
	
	// Enumerators are positioned before the first element
    // until the first MoveNext() call.
    int position = -1;
	
	public LaptopEnum(Laptop[] list)
    {
        classroom = list;
    }
	
	public bool MoveNext()
    {
        position++;
        return (position < classroom.Length);
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
	
	public Laptop Current
    {
        get
        {
            try
            {
                return classroom[position];
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
        Laptop[] laptopArray = new Laptop[3]
        {
            new Laptop("G40", "Lenovo"),
            new Laptop("Apple X3", "Apple Computers"),
            new Laptop("XPS15", "DELL"),
        };

        ClassRoom classroom234 = new ClassRoom(laptopArray);
	
		foreach (Laptop lap in classroom234)
            Console.WriteLine(lap.ModelName + " " + lap.BrandName);
    }
}
