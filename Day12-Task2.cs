using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Employee
    {
        public static void Main()

        {
            FileStream fs = new FileStream
                    ("D:\\Employee.text",
                    FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryWriter bw = new BinaryWriter(fs);
            BinaryWriter bw1 = new BinaryWriter(fs);
            BinaryWriter bw2 = new BinaryWriter(fs);
            BinaryWriter bw3 = new BinaryWriter(fs);
            bw.Write("ghid");
            bw1.Write("suvai");
            bw2.Write("24");
            bw2.Write("female");
            bw.Flush();
            fs.Close();
            FileStream fs1 = new FileStream(@"D:\Employee.text", FileMode.Open, FileAccess.ReadWrite);
            BinaryReader br = new BinaryReader(fs1);
            BinaryReader br1 = new BinaryReader(fs1);
            BinaryReader br2 = new BinaryReader(fs1);
            BinaryReader br3 = new BinaryReader(fs1);
            string str = br.ReadString();
            string str1 = br1.ReadString();
            string str2 = br2.ReadString();
            string str3 = br3.ReadString();
            Console.WriteLine(str);
            Console.WriteLine(str1);
            Console.WriteLine(str2);
            Console.WriteLine(str3);
            fs1.Close();
            Console.Read();
        }

    }
}