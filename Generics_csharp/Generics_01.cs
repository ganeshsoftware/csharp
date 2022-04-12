using System;
using System.Collections;
using System.Collections.Generic;





class MyGenericClass<T>
{
    private T genericMemberVariable;

    public MyGenericClass(T value)
    {
        genericMemberVariable = value;
    }

    public T genericMethod(T genericParameter)
    {
        Console.WriteLine("Parameter type: {0}, value: {1}", typeof(T).ToString(),genericParameter);
        Console.WriteLine("Return type: {0}, value: {1}", typeof(T).ToString(), genericMemberVariable);
            
        return genericMemberVariable;
    }

    public T genericProperty { get; set; }
}







class Test
{
	public static void Main()
	{
		MyGenericClass<Int32> m_MyGenericClass = new MyGenericClass<Int32>(10);
		m_MyGenericClass.genericMethod(108);
		
		
		
		MyGenericClass<double> m_MyGenericClass1 = new MyGenericClass<double>(53774.748);
		m_MyGenericClass1.genericMethod(108.74849);
		
		
		
		MyGenericClass<string> m_MyGenericClass2 = new MyGenericClass<string>("ganesh n");
		m_MyGenericClass2.genericMethod("narasimhan");
		
		
		
		MyGenericClass<bool> m_MyGenericClass3 = new MyGenericClass<bool>(true);
		m_MyGenericClass3.genericMethod(true);
	}
}

