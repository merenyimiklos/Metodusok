namespace Metodusok
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Koszonto();
            Console.WriteLine(Osszeadas(10,90));
			
		}

		static void Koszonto()
		{
            Console.WriteLine("Hello, világ!");
        }

		static int Osszeadas(int a, int b)
		{
			/*
			int osszeg = a + b;
			return osszeg;
			*/
			return a + b;
		}
	}
}
