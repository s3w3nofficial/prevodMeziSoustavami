using System;

namespace Prevod
{
	class MainClass
	{
		static string userinput0;
		static string userinput1;
		static string userinput2;

		static string vysledek;

		public static void Main (string[] args)
		{
			menu ();
		}

		public static void menu()
		{
			//Menu
			Console.Clear();
			Console.WriteLine ("Zvolte z jake soustavi chete prevadet");
			Console.WriteLine (".....................................");
			Console.WriteLine ("(0) Dvojkova");
			Console.WriteLine ("(1) Desitkova");
			Console.WriteLine ("(2) Sestnaskova");
			Console.WriteLine (".....................................");
			userinput0 = Console.ReadLine ();
			Console.Clear ();
			Console.WriteLine ("Zvolte do jake soustavi chcete prevadet");
			Console.WriteLine (".....................................");
			Console.WriteLine ("(0) Dvojkova");
			Console.WriteLine ("(1) Desitkova");
			Console.WriteLine ("(2) Sestnaskova");
			Console.WriteLine (".....................................");
			userinput1 = Console.ReadLine ();
			Console.Clear ();
			Console.WriteLine (".....................................");
			Console.WriteLine ("Zadejte Cislo ktere ma byt prevedeno");
			Console.WriteLine (".....................................");
			userinput2 = Console.ReadLine ();
			Console.Clear ();
			choase ();
		}

		public static void choase()
		{
			if (userinput0 == "0" && userinput1 == "0") {
				Console.WriteLine ("Zvolil jsi Kravinu");
				Console.ReadKey ();
				menu ();
			} else if (userinput0 == "1" && userinput1 == "1") {
				Console.WriteLine ("Zvolil jsi Kravinu");
				Console.ReadKey ();
				menu ();
			} else if (userinput0 == "2" && userinput1 == "2") {
				Console.WriteLine ("Zvolil jsi Kravinu");
				Console.ReadKey ();
				menu ();
			} else if (userinput0 == "1" && userinput1 == "0") {
				decimalToBinary (userinput2);
				Console.WriteLine (vysledek);
				Console.ReadKey ();
				menu ();
			} else if (userinput0 == "0" && userinput1 == "1") {
				binaryToDecimal (userinput2);
				Console.WriteLine (vysledek);
				Console.ReadKey ();
				menu ();
			} else if (userinput0 == "0" && userinput1 == "2") {
				binaryToHexadecimal (userinput2);
				Console.WriteLine (vysledek);
				Console.ReadKey ();
				menu ();
			} else if (userinput0 == "2" && userinput1 == "0") {
				hexadecimalToBinary (userinput2);
				Console.WriteLine (vysledek);
				Console.ReadKey ();
				menu ();
			} else if (userinput0 == "1" && userinput1 == "2") {
				decimalToHexadecimal (userinput2);
				Console.WriteLine (vysledek);
				Console.ReadKey ();
				menu ();
			} else if (userinput0 == "2" && userinput1 == "1") {
				hexadecimalToDecimal (userinput2);
				Console.WriteLine (vysledek);
				Console.ReadKey ();
				menu ();
			}
		}

		public static void binaryToDecimal(string binary)
		{
			long otp = Convert.ToInt64 (binary, 2);
			vysledek = otp.ToString ();
		}
		//oprava
		public static void binaryToHexadecimal(string binary)
		{
			string otp = Convert.ToInt32(binary , 2).ToString("X");
			vysledek = otp;
		}

		public static void decimalToBinary(string dec)
		{
			string counter = "";
			int n = Int32.Parse(dec);
			while (n >= 1)
			{
				counter = (n % 2) + counter;
				n = n / 2;
			}
			vysledek = counter.ToString();
		}

		public static void decimalToHexadecimal(string dec)
		{
			int tmp = Int32.Parse (dec);
			vysledek = tmp.ToString("X");
		}

		public static void hexadecimalToBinary(string hex)
		{
			hexadecimalToDecimal (hex);
			string tmp = vysledek;
			decimalToBinary (tmp);
		}

		public static void hexadecimalToDecimal(string hex)
		{
			string dec = Convert.ToInt32(hex, 16).ToString();
			vysledek = dec;
		}

	}
}

/*AUTHOR
___________                            __________       .__          __    
\__    ___/___   _____ _____    ______ \______   \ ____ |  | _____  |  | __
|    | /  _ \ /     \\__  \  /  ___/  |     ___// __ \|  | \__  \ |  |/ /
|    |(  <_> )  Y Y  \/ __ \_\___ \   |    |   \  ___/|  |__/ __ \|    < 
|____| \____/|__|_|  (____  /____  >  |____|    \___  >____(____  /__|_ \
	\/     \/     \/                 \/          \/     \/
*/