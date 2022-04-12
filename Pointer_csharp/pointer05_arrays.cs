
using System;  
class MyClass  
{  
    public unsafe void Method()  
    {  
        int[] iArray = new int[10];  
        for (int count = 0; count < 10; count++)  
        {  
            iArray[count] = count * count;  
        }  
        fixed (int* ptr = iArray)  
            Display(ptr);  
        //Console.WriteLine(*(ptr+2));  
        //Console.WriteLine((int)ptr);   
    }  
    public unsafe void Display(int* pt)  
    {  
        for (int i = 0; i < 14; i++)  
        {  
            Console.WriteLine(*(pt + i));  
        }  
    }  
}  
class MyClient  
{  
    public static void Main()  
    {  
        MyClass mc = new MyClass();  
        mc.Method();  
    }  
}  