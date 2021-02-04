/*
 * 
 * 
 * Aufgabenstellung: Berechnung der Fakultät
 * Eingabe: Wert x
 * Ausgabe: x!  
 * zB. x=5!  ===>  x=1*2*3*4*5
 *     x=0!  ===>  x=1

 */
using System;
using System.Collections.Generic;

namespace Fakultaet
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int i,wert,ergebnis=1;
			
			Console.WriteLine("Fakultätsberechnung");
			Console.WriteLine("===================");
			Console.WriteLine();
			Console.Write("Bitte Wert eingeben: ");
			wert=Convert.ToInt32(Console.ReadLine());

			
			for (i=1;i<=wert;i++)
			{
				ergebnis=ergebnis*i;
			}
			
			Console.WriteLine("{0}! ergibt {1}",wert,ergebnis);

			Console.WriteLine("\nBitte geben Sie die Entertaste ein! \n");
			Console.ReadLine();
		}
	}
}