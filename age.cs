using System;
class name
{
public static void Main()
{
string name;
int age;
Console.WriteLine("enter your name:");
name=Console.ReadLine();
Console.WriteLine("enter your age:");
age=Convert.ToInt32(Console.ReadLine());

for( int i=0;i<age;i++)
{
Console.WriteLine(" your name is "+ name );
}

}
}