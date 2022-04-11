using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LYNK
{
    class Task0804
    {
        static int numgoat(int eyes,int legs)
						
		{
			int num = 0;
			num = (Legs) -  (eyes-1);
			num = num / 2;
			return num;
			

		}

	
		public static void Main()
		{
			int eyes = 52, Legs = 80;
			int Goat = numgoat(eyes, Legs);
			

			Console.WriteLine("no_of_Goat = " +
							Goat);
			Console.WriteLine("n0_of_Ducks = " +
							(Goat-2));
		}
	}
}