using System;
class level
{
string name;
int age;
public level()
{
Console.WriteLine("enter Your name:");
name=Console.ReadLine();
Console.WriteLine("enter a age:");
age=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("your name is"+name+"and you are"+age+"years old");
}
public level(string name,int age)
{
this.name=name;
this.age=age;
Console.WriteLine("your name is "+this.name+"and your age is"+this.age+"years old");
}
public static void Main()
{
level obj=new level();
level obj1=new level("manju",43);
}
}
