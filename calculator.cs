using System;
abstract class operation
{
public abstract void add();
public abstract void sub();
public abstract void mul();
public abstract void div();

}

class calculator:operation
{
  public override void add()
{
Console.WriteLine("enter for addition");
int num1=Convert.ToInt32(Console.ReadLine());
int num2=Convert.ToInt32(Console.ReadLine());
int res=num1+num2;
Console.WriteLine("addition="+res);
}
 public override void sub()
{
Console.WriteLine("enter for subtraction");
int num1=Convert.ToInt32(Console.ReadLine());
int num2=Convert.ToInt32(Console.ReadLine());
int res=num1-num2;
Console.WriteLine("subtraction="+res);
}
 public override void mul()
{
Console.WriteLine("enter for multiplication");
int num1=Convert.ToInt32(Console.ReadLine());
int num2=Convert.ToInt32(Console.ReadLine());
int res=num1*num2;
Console.WriteLine("multiplication="+res);
}
 public  override void div()
{
Console.WriteLine("enter for division");
int num1=Convert.ToInt32(Console.ReadLine());
int num2=Convert.ToInt32(Console.ReadLine());
int res=num1/num2;
Console.WriteLine("division="+res);
}
}

class arithmetic
{
public static void Main()
{
calculator aobj=new calculator();
aobj.add();
aobj.sub();
aobj.mul();
aobj.div();
}
}
