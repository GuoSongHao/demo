using System;

class Script
{
	[STAThread]
	static public void Main(string[] args)
	{
		for (int i = 0; i < args.Length; i++)
		{
			Console.WriteLine(args[i]);
		}
	}
}

