using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld
{
  public delegate void DegHello(string str);
  public delegate string DegS(string str);
	public class Program
	{
	  public void SayHello(string str){
	    Console.WriteLine(str);
	  }
	  
	  public static string StringStr(string str){
	    return str;
	  }
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");
			
			Program h = new Program();
			DegHello d = h.SayHello;
			
			DegS d1= Program.StringStr;
			d("hi");
			
			Console.WriteLine(d1("hiiiii"));
		}
	}
}
