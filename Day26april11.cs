using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections;

namespace Lynq
{
    class Day26april11
    {
        public static void Main()
        {
            IList<Docter> docdata = new List<Docter>()
                {
                new Docter(){DocterID = 1,Name ="gsufgigv",Degree="MBBS,FRCS",Age = 32,Empid =1},
                new Docter(){DocterID = 2,Name ="qiojqnknf",Degree="BDS,PH.D",Age=43,Empid=3},
                new Docter(){DocterID = 3,Name ="mjhnfugtdf",Degree="MBBS,FRCS,MD",Age = 45,Empid=2},
                new Docter(){DocterID = 4,Name ="awetyjgvuk",Degree="MBBS,FRCS,MD",Age = 40,Empid =1},
                new Docter(){DocterID = 5,Name ="ssgfhsgfsg",Degree="MBBS,FRCS,MD",Age = 48,Empid = 2 },
            };
            IList<specialization> spldata = new List<specialization>()
            {
                new specialization() { specializat = "pedietrician",Empid = 1 },
                new specialization() { specializat = "Gynoecologist",Empid = 2 },
                new specialization() { specializat = "Dentist",Empid = 3},
            };
            var grpJoin = from br in spldata
                          join Stu in docdata
                          on br.Empid equals Stu.Empid
                          into splgroup
                          select new
                          {
                              Docter = splgroup,
                              specializat = br.specializat
                          };
            foreach (var item in grpJoin)
            {
               
                Console.WriteLine(item.specializat);
                foreach (var stud in item.Docter)
                    Console.WriteLine("Degree is"+(string)stud.Degree);
                foreach (var stud in item.Docter)
                   Console.WriteLine("Name is"+stud.Name);
                foreach (var stud in item.Docter)
           
                    Console.WriteLine("Emp id"+stud.Empid);
                foreach (var stud in item.Docter)
                    Console.WriteLine("Age is"+stud.Age);



            }

        }
    }
    internal class specialization
    {
        internal int Splid;
        internal string specializat;
        internal int Empid;
    }

    internal class Docter
    {
        internal int DocterID;
        internal string Name;
        internal object Degree;
        internal int Age;
        internal int Empid;
    }
}
