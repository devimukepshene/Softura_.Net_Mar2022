using System;
class VAT
{
public virtual void calculateTax(int cost)
{
int VAT=cost*20/100;
Console.WriteLine("VAT="+VAT);
}
}
class GST : VAT
{
public override void calculateTax(int cost)
{
int GST=cost*12/100;
Console.WriteLine("GST="+GST);
}
}
class TaxCalculation
{
public static void Main()
{
int cost;
Console.WriteLine("cost is:");
cost=Convert.ToInt32(Console.ReadLine());
VAT obj=new VAT();
obj.calculateTax(cost);
GST obj1=new GST();
obj1.calculateTax(cost);
}
}
