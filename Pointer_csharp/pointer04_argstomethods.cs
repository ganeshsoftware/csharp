using System;  
class MyClass  
{  
    public unsafe void Method()  
    {  
        Int32 x = 10;  
        Int32 y = 20;  
        Int32* sum = swap(&x, &y);  
        Console.WriteLine(*sum);  
    }  
    public unsafe Int32* swap(Int32* x, Int32* y)  
    {  
        Int32 sum;  
        sum = *x + *y;  
        return &sum; 
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