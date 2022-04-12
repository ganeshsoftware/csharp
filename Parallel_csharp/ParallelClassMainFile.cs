


// Namespace: System.Threading.Tasks
/*
   1. Support for parallel loops.
   2. Mimics the sequential loops that most developers are used to.
   3. Mimics - a) Parallel.Invoke, b) Parallel. For and c) Parallel.ForEach.



*/

// Parallel.Invoke class .
	
public static class Parallel      
{      
  public static void Invoke(params Action[] actions);      
  public static void Invoke(ParallelOptions parallelOptions, params Action[] actions);      
}     

/*

As we can see the first parameter is an array of delegate-Action. Once you have passed the proper argument to the first given parameter the Parallel.Invoke will basically launch these Actions and run in parallel and once all are done the continue the classic fork/join model.

*/