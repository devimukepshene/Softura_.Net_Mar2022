using System;
class Addsub
{
public void Add()
{
Console.WriteLine("addition");
int num1=Convert.ToInt32(Console.ReadLine());
int num2=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ans="+(num1+num2));
}

public void Sub()
{
Console.WriteLine("subraction");
int num1=Convert.ToInt32(Console.ReadLine());
int num2=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ans="+(num1-num2));
}
}
class Muldiv : Addsub
{
public void Mul()
{
Console.WriteLine("Multiplication");
int num1=Convert.ToInt32(Console.ReadLine());
int num2=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ans="+(num1*num2));
}
public void Div()
{
Console.WriteLine("division");
int num1=Convert.ToInt32(Console.ReadLine());
int num2=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ans="+(num1/num2));
}
}
class arithmetic
{
public static void Main()
{
Addsub obj=new Addsub();
obj.Add();
obj.Sub();
Muldiv obj1=new Muldiv();
obj1.Mul();
obj1.Div();
}
}
