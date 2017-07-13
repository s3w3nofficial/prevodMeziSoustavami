using System;

namespace Prevod
{
	internal class MainClass
	{
		private static string _userinput0;
		private static string _userinput1;
		private static string _userinput2;

		private static string _vysledek;

		public static void Main (string[] args)
		{
			Menu ();
		}

		public static void Menu()
		{
			//Menu
			Console.Clear();
			Console.WriteLine ("Zvolte z jake soustavi chete prevadet");
			Console.WriteLine (".....................................");
			Console.WriteLine ("(0) Dvojkova");
			Console.WriteLine ("(1) Desitkova");
			Console.WriteLine ("(2) Sestnaskova");
			Console.WriteLine (".....................................");
			_userinput0 = Console.ReadLine ();
			Console.Clear ();
			Console.WriteLine ("Zvolte do jake soustavi chcete prevadet");
			Console.WriteLine (".....................................");
			Console.WriteLine ("(0) Dvojkova");
			Console.WriteLine ("(1) Desitkova");
			Console.WriteLine ("(2) Sestnaskova");
			Console.WriteLine (".....................................");
			_userinput1 = Console.ReadLine ();
			Console.Clear ();
			Console.WriteLine (".....................................");
			Console.WriteLine ("Zadejte Cislo ktere ma byt prevedeno");
			Console.WriteLine (".....................................");
			_userinput2 = Console.ReadLine ();
			Console.Clear ();
			Choase ();
		}

		public static void Choase()
		{
			if (_userinput0 == "0" && _userinput1 == "0") {
				Console.WriteLine ("Zvolil jsi Kravinu");
				Console.ReadKey ();
				Menu ();
			} else if (_userinput0 == "1" && _userinput1 == "1") {
				Console.WriteLine ("Zvolil jsi Kravinu");
				Console.ReadKey ();
				Menu ();
			} else if (_userinput0 == "2" && _userinput1 == "2") {
				Console.WriteLine ("Zvolil jsi Kravinu");
				Console.ReadKey ();
				Menu ();
			} else if (_userinput0 == "1" && _userinput1 == "0") {
				DecimalToBinary (_userinput2);
				Console.WriteLine (_vysledek);
				Console.ReadKey ();
				Menu ();
			} else if (_userinput0 == "0" && _userinput1 == "1") {
				BinaryToDecimal (_userinput2);
				Console.WriteLine (_vysledek);
				Console.ReadKey ();
				Menu ();
			} else if (_userinput0 == "0" && _userinput1 == "2") {
				BinaryToHexadecimal (_userinput2);
				Console.WriteLine (_vysledek);
				Console.ReadKey ();
				Menu ();
			} else if (_userinput0 == "2" && _userinput1 == "0") {
				HexadecimalToBinary (_userinput2);
				Console.WriteLine (_vysledek);
				Console.ReadKey ();
				Menu ();
			} else if (_userinput0 == "1" && _userinput1 == "2") {
				DecimalToHexadecimal (_userinput2);
				Console.WriteLine (_vysledek);
				Console.ReadKey ();
				Menu ();
			} else if (_userinput0 == "2" && _userinput1 == "1") {
				HexadecimalToDecimal (_userinput2);
				Console.WriteLine (_vysledek);
				Console.ReadKey ();
				Menu ();
			}
		}

		public static void BinaryToDecimal(string binary)
		{
			var otp = Convert.ToInt64 (binary, 2);
			_vysledek = otp.ToString ();
		}
		//oprava
		public static void BinaryToHexadecimal(string binary)
		{
			var otp = Convert.ToInt32(binary , 2).ToString("X");
			_vysledek = otp;
		}

		public static void DecimalToBinary(string dec)
		{
			var counter = "";
			var n = int.Parse(dec);
			while (n >= 1)
			{
				counter = (n % 2) + counter;
				n = n / 2;
			}
			_vysledek = counter;
		}

		public static void DecimalToHexadecimal(string dec)
		{
			var tmp = int.Parse (dec);
			_vysledek = tmp.ToString("X");
		}

		public static void HexadecimalToBinary(string hex)
		{
			HexadecimalToDecimal (hex);
			var tmp = _vysledek;
			DecimalToBinary (tmp);
		}

		public static void HexadecimalToDecimal(string hex)
		{
			var dec = Convert.ToInt32(hex, 16).ToString();
			_vysledek = dec;
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