using System;
using System.Collections.Generic;

namespace Ganesh .Observer
{
    /// <summary>
    /// Observer Design Pattern
    /// </summary>

    public class Program
    {
        public static void Main(string[] args)
        {
            
			// Creating a Doctor instance called as Ganesh.
            Ganesh ganesh = new Ganesh("Ganesh", "ENT");
            
			
			// ataching 2 deans to the Doctor Ganesh - Ramesh , Suresh.
			ganesh.Attach(new Dean("Ramesh"));
			ganesh.Attach(new Dean("Suresh"));

           
			
            ganesh.Department = "Outpatient";
            ganesh.Department = "Billing Section";
            ganesh.Department = "Pharmacy";
            ganesh.Department = "Canteen";

            // Wait for user

            Console.ReadKey();
        }
    }

    /// <summary>
    /// The 'Subject' abstract class
    /// </summary>

    public abstract class Doctor
    {
        private string name;
        private string department;
        private List<IDean> deans = new List<IDean>();

        // Constructor

        public Doctor(string name, string department)
        {
            this.name = name;
            this.department = department;
        }

        public void Attach(IDean dean)
        {
            deans.Add(dean);
        }

        public void Detach(IDean dean)
        {
            deans.Remove(dean);
        }

        public void Notify()
        {
            foreach (IDean dean in deans)
            {
                dean.Update(this);
            }

            Console.WriteLine("");
        }

        // Gets or sets the department
        public string Department
        {
            get { return department; }
            set
            {
                if (!(department.Equals(value)))
                {
                    department = value;
                    Notify();
                }
            }
        }

        // Gets the title
        public string Name
        {
            get { return name; }
        }
    }


    /// <summary>
    /// The 'ConcreteSubject' class
    /// </summary>
    public class Ganesh : Doctor
    {
        // Constructor
        public Ganesh(string name, string department): base(name, department)
        {

        }
    }

    /// <summary>
    /// The 'Observer' interface
    /// </summary>

    public interface IDean
    {
        void Update(Doctor doctor);
    }

    /// <summary>
    /// The 'ConcreteObserver' class
    /// </summary>

    public class Dean : IDean
    {
        private string name;
        private Doctor doctor;

        // Constructor

        public Dean(string name)
        {
            this.name = name;
        }

        public void Update(Doctor doctor)
        {
            Console.WriteLine("Notified {0} of {1}'s change to {2}", name, doctor.Name, doctor.Department);
        }

        // Gets or sets the Doctor

        public Doctor Doctor
        {
            get { return doctor; }
            set { doctor = value; }
        }
    }
}
