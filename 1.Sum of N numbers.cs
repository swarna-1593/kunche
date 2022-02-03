// See https://aka.ms/new-console-template for more information

using System;
namespace DemoCapgemini
{
    class Program
    {
        static void Main(string[]args)
        {
           int i,j,r;
	
     Console.Write("Display the pattern like right angle using asterisk:\n");
    Console.Write("------------------------------------------------------");
    Console.Write("\n\n");   
   
   Console.Write("Input: ");
   r= int.Parse(Console.ReadLine());   
   for(i=1;i<=rows;i++)
   {
	for(j=1;j<=i;j++)
    {
	   Console.Write("*");
    }
	Console.Write("\n");
   }
  }   
}

        }
    


