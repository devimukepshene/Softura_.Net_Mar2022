using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Dataaa
{
    class SimpleActivity2
    {
        public string Namee { get; private set; }
        public string Gender { get; set; }
        public string Dob { get; set; }
        public string Conno { get; set; }
        public string Emailid { get; set; }
        public string City { get; set; }
        public void InsertData(string Namee, string Gender, string Dob, string Conno, string Emailid, string City)
        {
            SqlConnection con = new SqlConnection("data source=LAPTOP-U3SQAU6D\\MSSQLSERVER02; database=Trial;user id=sa; password=P@ssw0rd");
            string sqlqry = "insert CustomerTbl values('" + Namee + "','" + Gender + "','" + Dob + "','" + Conno + "','" + Emailid + "','" + City + "')";
            SqlCommand cmd = new SqlCommand(sqlqry, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine("custID:" + dr[0] + "Namee:" + dr[1] + "Gender:" + dr[2] + "Dob:" + dr[3] + "Conno:" + dr[4] + "EmailID:" + dr[5] + "City:" + dr[6]);
            }
            con.Close();
            Console.WriteLine("row inserted");
            Console.Read();
        }
        public void check(string Name1)
        {
            SqlConnection con = new SqlConnection("data source=LAPTOP-U3SQAU6D\\MSSQLSERVER02; database=Trial;user id=sa; password=P@ssw0rd");
            string sqlqry = "select Namee,Gender,Dob,Conno,Emailid,City from CustomerTbl where Namee='" + Name1+ "'";
            SqlCommand cmd = new SqlCommand(sqlqry, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine("custID:" + dr[0] + "   " + "Gender:" + dr[1] + "   " + "Dob:" + dr[2] + "    " + "conno:" + dr[3] + "   " + "EmailID:" + dr[4] + "   " + "City:" + dr[5]);
            }
            Console.Read();
            con.Close();
        }
    }
    class productTable
    {
        public void Calculate()
        {
            SqlConnection con = new SqlConnection("data source=LAPTOP-U3SQAU6D\\MSSQLSERVER02; database=Trial;user id=sa; password=P@ssw0rd");
            SqlCommand cmd = new SqlCommand("select * from dbo.ProductTable", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                Console.WriteLine(" prodID: " + dr[0] + " prodName : " + dr[1] + "price : " + dr[2]);
            }
            Console.WriteLine("Enter the Id ");
            int prodID = Convert.ToInt32(Console.ReadLine());
            switch(prodID)
            {
                case 5:

                    Console.WriteLine("Airpods");
                    Console.WriteLine("Enter Quantity");
                    int Quantity = Convert.ToInt32(Console.ReadLine());
                    SqlConnection con1 = new SqlConnection("data source=LAPTOP-U3SQAU6D\\MSSQLSERVER02; database=Trial;user id=sa; password=P@ssw0rd");
                    SqlCommand cmd1 = new SqlCommand("select price* " + Quantity + " from ProductTable where prodID = " + prodID + "", con1);
                    con1.Open();
                    cmd1.ExecuteNonQuery();
                    SqlDataReader dr1 = cmd1.ExecuteReader();
                    while (dr1.Read())
                    {
                        int Total1 = Convert.ToInt32(dr1[0]);
                        Console.WriteLine("Amt" + Total1);
                    }
                    con1.Close();
                    break;

                case 6:

                    Console.WriteLine("Smartwatch");
                    Console.WriteLine("Enter Quantity");
                    int Quantity2 = Convert.ToInt32(Console.ReadLine());
                    SqlConnection con2 = new SqlConnection("data source=LAPTOP-U3SQAU6D\\MSSQLSERVER02; database=Trial;user id=sa; password=P@ssw0rd");
                    SqlCommand cmd2 = new SqlCommand("select price* " + Quantity2 + " from ProductTable where prodID = " + prodID + "", con2);
                    con2.Open();
                    cmd2.ExecuteNonQuery();
                    SqlDataReader dr2 = cmd2.ExecuteReader();
                    while (dr2.Read())
                    {
                        int Total2 = Convert.ToInt32(dr2[0]);
                        Console.WriteLine("Amt" + Total2);
                    }
                    con2.Close();
                    break;

                case 7:

                    Console.WriteLine("Bluetoothheadphones");
                    Console.WriteLine("Enter Quantity");
                    int Quantity3 = Convert.ToInt32(Console.ReadLine());
                    SqlConnection con3 = new SqlConnection("data source=LAPTOP-U3SQAU6D\\MSSQLSERVER02; database=Trial;user id=sa; password=P@ssw0rd");
                    SqlCommand cmd3 = new SqlCommand("select price* " + Quantity3 + " from ProductTable where prodID = " + prodID + "", con3);
                    con3.Open();
                    cmd3.ExecuteNonQuery();
                    SqlDataReader dr3 = cmd3.ExecuteReader();
                    while (dr3.Read())
                    {
                        int Total3 = Convert.ToInt32(dr3[0]);
                        Console.WriteLine("Amt" + Total3);
                    }
                    con3.Close();
                    break;

                case 8:

                    Console.WriteLine("BluetoothSpeakers");
                    Console.WriteLine("Enter Quantity");
                    int Quantity4 = Convert.ToInt32(Console.ReadLine());
                    SqlConnection con4 = new SqlConnection("data source=LAPTOP-U3SQAU6D\\MSSQLSERVER02; database=Trial;user id=sa; password=P@ssw0rd");
                    SqlCommand cmd4 = new SqlCommand("select price* " + Quantity4 + " from ProductTable where prodID = " + prodID + "", con4);
                    con4.Open();
                    cmd4.ExecuteNonQuery();
                    SqlDataReader dr4 = cmd4.ExecuteReader();
                    while (dr4.Read())
                    {
                        int Total4 = Convert.ToInt32(dr4[0]);
                        Console.WriteLine("Amt" + Total4);
                    }
                    con4.Close();
                    break;
            }
        }
    }
        class MainSub
    {
        SqlConnection con = new SqlConnection("data source=LAPTOP-U3SQAU6D\\MSSQLSERVER02; database=Trial;user id=sa; password=P@ssw0rd");
        public static void Main()
        {
            SimpleActivity2 ob1 = new SimpleActivity2();
            Console.WriteLine("enter name");
            string Namee = Console.ReadLine();
            Console.WriteLine("enter gender");
            string Gender = Console.ReadLine();
            Console.WriteLine("enter dob");
            string Dob = Console.ReadLine();
            Console.WriteLine("enter emailid");
            string Emailid = Console.ReadLine();
            Console.WriteLine("enter contact");
            string Conno = Console.ReadLine();
            Console.WriteLine("1.chennai" + "  " + "2.Bangalore" + "  " + "3.Hyderabad" + "  " + "4.Trivandrum");
            Console.WriteLine("choose city ");
            string City = Console.ReadLine();
            ob1.InsertData(Namee, Gender, Dob, Conno, Emailid, City);

            Console.WriteLine("enter Namee:");
            string Name = Console.ReadLine();
            ob1.check(Name);

            productTable ob = new productTable();
             ob.Calculate();

        }

    }

}


