
// 5. WAP to convert various datatype to String using ToString Method.

using System;

namespace Program
{
	public class program5
	{
		public static void Main(string[] args)
		{
			int a = 10;
      float b = 10.23f;
      double c = 10.23;
      bool d = true;
      
      Console.WriteLine(a.GetType());
      Console.WriteLine(b.GetType());
      Console.WriteLine(c.GetType());
      Console.WriteLine(d.GetType());
      
      Console.WriteLine(a.ToString());
      Console.WriteLine(b.ToString());
      Console.WriteLine(c.ToString());
      Console.WriteLine(d.ToString());
       
      Console.WriteLine(a.ToString().GetType());
      Console.WriteLine(b.ToString().GetType());
      Console.WriteLine(c.ToString().GetType());
      Console.WriteLine(d.ToString().GetType());
      
			
		}
	}
}