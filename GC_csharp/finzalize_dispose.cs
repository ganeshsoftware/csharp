class Test
{
	~Test()
	{
		// necessary cleanup code.
	}
}



// -------------------------------------------------------------------------------------------------------------
// Finalize()
protected override void Finalize()
{
	try
	{
		// necessary cleanup code.
	}
	finally
	{
		base.Finalize();
	}
}


// -------------------------------------------------------------------------------------------------------------
//Dispose()
public interface IDisposable
{
	void Dispose();	
}

// -------------------------------------------------------------------------------------------------------------

// Dispose() implementation.
class Test: IDisposable
{
	private bool isDisposed = false;
	
	~Test()
	{
		Dispose(false)
        // The Finalize() will automatically be called. 		
	}
	

	
	protected void Dispose(bool disposing)
	{
		if (disposing)
		{
			// code to dispose the managed resources / components of the class.
		}
		
		// code to dispose the un-managed resources of the class.
		
		isDisposed = true;
	}
	

}



// -------------------------------------------------------------------------------------------------------------
public class Doctor:IDisposable
{
	private bool isDisposed = false;
	
    // Implemented by IDisposable.	
	public void Dispose()
	{
		Dispose(true);
	    
		// 
		GC.SupressFinalize(this);
	}
    
	protected virtual void Dispose(bool disposing)
	{
		if (!isDisposed)
		{
			if (disposing)
			{
				// code to dispose "managed resources" held by the class.
				
			}
		}
		// code to dispose unmanaged resources held by the class.
		isDisposed = true;
		base.Dispose(disposing);
	}
	
	~Doctor()
	{
		Dispose(false);		
	}
}


// 
public class Surgeon:Doctor
{
	protected override void Dispose(bool disposing)
	{
		if(disposing)
		{
			//Code to cleanup managed resources held by the class.
		}
		// code to clean up UN-MANAGED resources held by the class.
		base.Dispose(disposing);
	}
	// This doesn't have the IDisposable re-implemented. 	
}