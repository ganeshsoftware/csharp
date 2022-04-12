using System;
using System.Collections;

// Class Nurse.
public class Nurse
{
	public string FirstName{get; set;}
    public string Department{get; set;}
	
	public Nurse(string firstName, string department)
    {
        this.FirstName = firstName;
        this.Department = department;
    }
}

// Class Doctor.
public class Doctor
{
	public string FirstName{get; set;}
    public string Department{get; set;}
	
	public Doctor(string firstName, string department)
    {
        this.FirstName = firstName;
        this.Department = department;
    }
}


// Hospital is a collection of Nurses, Doctors and Patients.
public class Hospital:IEnumerable
{
	// Hospital is made up of nurses. so a nurses array.
	private Nurse[] _hospital;
	
	// Constructor
	public Hospital(Nurse[] nurseArray)
    {
        _hospital = new Nurse[nurseArray.Length];

        for (int i = 0; i < nurseArray.Length; i++)
        {
            _hospital[i] = nurseArray[i];
        }
    }
	
	// Implementation for the GetEnumerator method.
    IEnumerator IEnumerable.GetEnumerator()
    {
       return (IEnumerator) GetEnumerator();
    }

    public NurseEnum GetEnumerator()
    {
        return new NurseEnum(_hospital);
    }	
}

// Doctor.
public class DoctorEnum:IEnumerator
{
	public Doctor[] _doctorTeam;
	
	int position = -1;	

	public DoctorEnum(Doctor[] list)
	{
		_doctorTeam = list;
	}	
	
    public bool MoveNext()
    {
        position++;
        return (position < _doctorTeam.Length);
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
	
	public Doctor Current
    {
        get
        {
            try
            {
                return _doctorTeam[position];
            }
            catch (System.IndexOutOfRangeException)
            {
                throw new System.InvalidOperationException();
            }
        }
    }
}




// Nurse Enum.
public class NurseEnum:IEnumerator
{
	public Nurse[] _nurseTeam;
	
	int position = -1;	

	public NurseEnum(Nurse[] list)
	{
		_nurseTeam = list;
	}	
	
    public bool MoveNext()
    {
        position++;
        return (position < _nurseTeam.Length);
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
	
	public Nurse Current
    {
        get
        {
            try
            {
                return _nurseTeam[position];
            }
            catch (System.IndexOutOfRangeException)
            {
                throw new System.InvalidOperationException();
            }
        }
    }
}

class App
{
    static void Main()
    {
        Nurse[] nurses = new Nurse[3]
        {
            new Nurse("Radhakumari", "Cardiology"),
            new Nurse("Mariam", "Operation Theatre"),
            new Nurse("Fatima", "General Ward"),
        };

        Hospital nurseList = new Hospital(nurses);
		foreach (Nurse nur in nurseList)
            System.Console.WriteLine(nur.FirstName + " " + nur.Department);
    }
}

