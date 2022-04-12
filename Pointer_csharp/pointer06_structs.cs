using System;  
struct MyStruct  
{  
    public int x;  
    public int y;  
    public void SetXY(int i, int j)  
    {  
        x = i;  
        y = j;  
    }  
    public void ShowXY()  
    {  
        Console.WriteLine(x);  
        Console.WriteLine(y);  
    }  
} 
class MyClient  
{  
    public unsafe static void Main()  
    {  
        MyStruct ms = new MyStruct();  
        MyStruct* ms1 = &ms;  
        ms1->SetXY(10, 20);  
        ms1->ShowXY();  
    }  
} 