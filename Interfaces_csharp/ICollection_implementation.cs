using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mimsys.CSTraining2021.Interfaces
{
	public class Doctor: ICollection<Doctor>
	{
		public Int32 Id { get; set; }
		public string Name { get; set; }
		
		Object[] doctors;
		Int16 doc_counter = 0;
		
		public Doctor()
		{

		}
		
		public Doctor(Int32 Id, string Name)
		{
			this.Id = Id;
			this.Name = Name;
		}		
		
        
		public void Add(Doctor doc)
        {
            doctors[doc_counter] = doc;
            doc_counter++;
        }
		
        public void Clear()
        {
            doctors = null;
        }		
        
		public bool Contains(Doctor doc)
        {
            
				throw new NotImplementedException();

        }		
		
        
		public void CopyTo(Doctor[] docarray, int docarrayIndex)
        {
            try
			{
				throw new NotImplementedException();
			}
			catch (NotImplementedException)
			{
				Console.WriteLine("Please implement your own version in this!");
			}
			finally
			{
				Console.WriteLine("Please implement your own version in this!");
			}
        }
				
        public int Count
        {
            get { return doc_counter; }
        }		

        public bool IsReadOnly
        {
			get {throw new NotImplementedException();}
		}
        
        
		public bool Remove(Doctor doc)
        {
            doctors[doc.Id] = null;
            return true;
        }		

        // IEnumerable implementations.
		
		public IEnumerator<Doctor> GetEnumerator()
        {
            foreach (Doctor doc in doctors)
            {
                if (doc == null)
                break;
					else
                yield return doc;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
           throw new NotImplementedException();
        }
	}
	

    class Program
    {
        static void Main(string[] args)
        {
            Doctor ramesh = new Doctor();
            
			ramesh.Add(new Doctor(11,"Suresh Kumar"));
            ramesh.Add(new Doctor(21,"Shriram Narayan"));

            foreach (Doctor doc in ramesh)
            {
               Console.WriteLine(ramesh.Id + "  " + ramesh.Name);
            }
            Console.ReadLine();
        }
    }	
}