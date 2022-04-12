using System;  

class Doctor  
{  
    public unsafe void Detail()  
    {  
        Int32 DocId = 108;  
        char DocInit = 'G';  
        Int32* ptr1 = &DocId;  
        char* ptr2 = &DocInit;  
        Console.WriteLine((Int32)ptr1);  
        Console.WriteLine((Int32)ptr2);  
        Console.WriteLine(*ptr1);  
        Console.WriteLine(*ptr2);  
    }  
}  
class MyClient  
{  
    public static void Main()  
    {  
        Doctor ganesh = new Doctor();  
        ganesh.Detail();  
    }  
}  