
// 6. WAP to declear different types of variables, assign the values and print them.

using System;

namespace Program
{
	public class program6
	{
		public static void Main(string[] args)
		{
			// Integer
      int myInt; //declear
      myInt = 10; // assign
      Console.WriteLine("Integer: " + myInt); // print

      // Double
      double myDouble;//declear
      myDouble = 10.5;// assign
      Console.WriteLine("Double: " + myDouble);// print

      // String
      string myString;  // declear
      myString = "Hello, World!"; // assign
      Console.WriteLine("String: " + myString); // print

      // Boolean
      bool myBool;// declear
      myBool = true; // assign
      Console.WriteLine("Boolean: " + myBool);//print

      // Character
      char myChar; //declear
      myChar = 'A'; // assign
      Console.WriteLine("Character: " + myChar); //print


      // Float
      float myFloat;
      myFloat = 10.5f;
      Console.WriteLine("Float: " + myFloat);

      // Long
      long myLong;
      myLong = 1000000;
      Console.WriteLine("Long: " + myLong);

      // Short
      short myShort;
      myShort = 100;
      Console.WriteLine("Short: " + myShort);

      // Byte
      byte myByte;
      myByte = 10;
      Console.WriteLine("Byte: " + myByte);
		}
	}
}