using System;
using System.Collections.Generic;
using System.Linq;

namespace Mimsys.CSTraining2021.LINQ
{
class Pulser
{
    static void Main()
    {	
		// A random set of pulse counts.  
        UInt16[] pulse_counts = new UInt16[] {76,90,79,108,100,92,89,61,85,98};

        // Querying the pulse counts array using LINQ query.
        IEnumerable<UInt16> query_Pulse =
            from pulse in pulse_counts
            where pulse > 90
            select pulse;

        // Execute the query.
        foreach (UInt16 count in query_Pulse)
        {
            Console.Write(count + " ");
        }
    }
} 
}






