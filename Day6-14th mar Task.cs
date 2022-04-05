using System;
class electicbill
{
public static void Main()
{
int amt,unit;
Console.WriteLine("enter the unit:");
unit=Convert.ToInt32(Console.ReadLine());
if(unit>0 && unit<=200)
{
amt=unit*2;
Console.WriteLine("amount: " +amt);
}

else if(unit>200 && unit<=350)
{
amt=((unit-200)*3)+(400);
Console.WriteLine("amount: " +amt);
}

else if(unit>350 && unit<=500)
{
amt=((unit-350)*5)+(850);
Console.WriteLine("amount: " +amt);
}
else (unit>500)
{
amt=((unit-500)*7)+750);
Console.WriteLine("amount: " +amt);
}
}
}
