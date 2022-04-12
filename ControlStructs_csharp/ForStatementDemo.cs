using System;

class ForLoopTest 
{
    static void Main() 
    {
        for (int i = 1; i <= 5; i++)
        {
            for(int j = 1; j<=5; j++)
			{
				Console.WriteLine(" i = {0} | j = {1}",i,j);	
			}
        }
    }
}