using System;
class userlogin
{
public void validate()
{
Console.WriteLine("Enter Email Id");
string email=Console.ReadLine();
Console.WriteLine("Enter password");
string pass=Console.ReadLine();
Console.WriteLine("Validation done");
}
public void validate(string mem,long pin)
{
Console.WriteLine("Membership Id is:"+mem);
Console.WriteLine("Pin is:"+pin);

Console.WriteLine("validation Done");
}
public void validate(long mob,long pin)
{
Console.WriteLine("Mobile Number is:"+mob);
Console.WriteLine("Pin is:"+pin);
Console.WriteLine("validation Done");
}
public static void Main()
{
userlogin obj=new userlogin();
obj.validate();
obj.validate("devi",134567);
obj.validate(9382341275,54321);
}
}