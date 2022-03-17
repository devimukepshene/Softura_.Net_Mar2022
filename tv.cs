using System;
class name
{
public static void Main()
{
Console.WriteLine("select the package A/B/C: ");
String package=Console.ReadLine();
switch(package)
{
case "A":Console.WriteLine("south special \n"+"children's club \n"+"movies \n"+"total rate is 250 \n");
    break;
case "B":Console.WriteLine("news \n"+"sports \n"+"movies \n"+"regional \n"+"total rate is 450 \n");
    break;
case "C":Console.WriteLine("discovery \n"+" history \n"+"national \n"+"total rate is 350 \n");
    break;
default:Console.WriteLine("enter a valid package");
    break;
}

}
}
 
