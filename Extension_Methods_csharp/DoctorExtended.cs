using System;


namespace Utils
{
	public static class DoctorExtended
	{
		// Extension Method 1
		public static string Speciality(this Doctor doc)
		{
				return doc.Speciality;
		}
  
		// Extension Method 2
		public static string Speciality(this Doctor doc, string nationality)
		{
			return nationality + "  " + doc.Speciality;
		}
	}	
}	
	
/*
Important Points:

Here, Binding parameters are those parameters which are used to bind the new method with the existing class or structure. It does not take any value when you are calling the extension method because they are used only for binding not for any other use. In the parameter list of the extension method binding parameter is always present at the first place if you write binding parameter to second, or third, or any other place rather than first place then the compiler will give an error. The binding parameter is created using this keyword followed by the name of the class in which you want to add a new method and the parameter name. For example:
this Geek g
Here, this keyword is used for binding, Geek is the class name in which you want to bind, and g is the parameter name.

Extension methods are always defined as a static method, but when they are bound with any class or structure they will convert into non-static methods.
When an extension method is defined with the same name and the signature of the existing method, then the compiler will print the existing method, not the extension method. Or in other words, the extension method does not support method overriding.
You can also add new methods in the sealed class also using an extension method concept.
It cannot apply to fields, properties, or events.
It must be defined in top-level static class.
Multiple binding parameters are not allowed means an extension method only contains a single binding parameter. But you can define one or more normal parameter in the extension method.
Advantages:

The main advantage of the extension method is to add new methods in the existing class without using inheritance.
You can add new methods in the existing class without modifying the source code of the existing class.
It can also work with sealed class.

*/



