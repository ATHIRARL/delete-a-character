using System;
public class Program
{
	public static void Main()
	{
		Console.WriteLine("string");
		string a=Console.ReadLine();
		int n=a.Length;
	//int [] a= new int[n];
		char[] b=new char[n-1];
	Console.WriteLine("position");
		int p=Convert.ToInt32(Console.ReadLine());
		
		for(int i=0;i<n;i++)
		{
			if(i<p)
				
			   {
				
				b[i]=a[i];
				
				
				  
			   }
			else
			{
				goto f;
					
			}
		
	
			Console.WriteLine(b[i]);
		}
		f:
		for(int i=p;i<n-1;i++)
		{
			char t=a[i+1];
			b[i]=t;
			
			Console.WriteLine(b[i]);
		}
	}
}
