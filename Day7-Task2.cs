using System;
class tables
{
public static void Main()
{
Console.WriteLine("enter the tables");
int n=Convert.ToInt32(Console.ReadLine());
for(int i=1;i<=20;i++)
{
Console.WriteLine(" "+n+ " * "+ i + "="  + " "+n*i);


}
}
}
