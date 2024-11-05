namespace Metodusok
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Koszonto();
            Console.WriteLine(Osszeadas(10,90));
			int a = 5;
            Console.WriteLine(Duplaz(a));
			int duplazott = Duplaz(a);
            Console.WriteLine(a);
            Console.WriteLine(duplazott);
			Console.WriteLine(Osszeg(10));
			int elso = 5;
			int masodik = 10;
			Csere(elso, masodik);
            Console.WriteLine(elso + " " + masodik);
			Duplaz();
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

		static int Duplaz(int szam)
		{
			return szam * 2;
		}

		static string Duplaz()
		{
			return "";
		}

		static int Duplaz(int szam1, int szam2)
		{
			return 0;
		}

		static int Osszeg(int a, int b = 5, int c = 2)
		{
			return a + b + c;
		}

		static void Csere(int a, int b)
		{
			int temp = a;
			a = b;
			b = temp;
			Console.WriteLine(a + " " + b);
		}

	}
}
