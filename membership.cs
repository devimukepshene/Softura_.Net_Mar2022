using System;
interface package
{
void silver();
void gold();
void platinum();
}
class membership:package
{
      public void silver()
     {
      Console.WriteLine("For SILVER- 3 days accomodation at resort");
      }
            public void gold()
            {
             Console.WriteLine("For GOLD-5 days accomodation at resort and 2 dinners on the house");
             }
                    public void platinum()
                   {
                   Console.WriteLine("For PLATINUM-7 days accomodation at resort and 5 dinners on the house");
                   }
}
class imple
{
    public static void Main()
   {
    membership mobj=new membership();
    mobj.silver();
    mobj.gold();
    mobj.platinum();
   }
}
