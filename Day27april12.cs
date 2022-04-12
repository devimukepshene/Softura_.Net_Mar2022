using System;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;
using System.Data.SqlTypes;

namespace Dataaa
{
    class Day27april12
    {
        public void Create()
        {
            SqlConnection con = new SqlConnection("data source =LAPTOP-U3SQAU6D\\MSSQLSERVER02 ;database= Trial;user id = sa;password=P@ssw0rd");
            con.Open();
            SqlCommand cmd = new SqlCommand("create table Enrollment(Sno int,Name varchar(20),MobNo varchar(15),gmail varchar(30))", con);
            cmd.ExecuteNonQuery();
            con.Close();
            Console.WriteLine("Completed");
        }
      public void Insert()
       {         SqlConnection con = new SqlConnection("data source =LAPTOP-U3SQAU6D\\MSSQLSERVER02 ;database= Trial;user id = sa;password=P@ssw0rd");
          con.Open();
         string sqlqry = "insert Enrollment values(1,'jhkj','58353856','@gmail.com')";
           SqlCommand cmd = new SqlCommand(sqlqry, con);
           cmd.ExecuteNonQuery();
            con.Close();
           Console.WriteLine("Row Inserted");
}
       public void Update()
        {
           SqlConnection con = new SqlConnection("data source =LAPTOP-U3SQAU6D\\MSSQLSERVER02 ;database= Trial;user id = sa;password=P@ssw0rd");

            string sqlqry = "update Enrollment set gmail='gmail',Name='ffghj' where Sno=1";
            SqlCommand cmd = new SqlCommand(sqlqry, con);
                      con.Open();
                      cmd.ExecuteNonQuery();
                      con.Close();
                       Console.WriteLine("Row Updated");
        }
        public void Delete()
        {
            SqlConnection con = new SqlConnection("data source =LAPTOP-U3SQAU6D\\MSSQLSERVER02 ;database= Trial;user id = sa;password=P@ssw0rd");

            string sqlqry = "delete Enrollment where Sno=1";
            SqlCommand cmd = new SqlCommand(sqlqry, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Console.WriteLine("Row Deleted");
        }

        public static void Main()
        {
            Day27april12 ob1 =new Day27april12();
            ob1.Create();
            ob1.Insert();
            ob1.Update();
            ob1.Delete();
            Console.Read();
        
        }
    }
}
