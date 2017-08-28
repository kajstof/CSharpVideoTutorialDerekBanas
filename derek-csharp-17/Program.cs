using System;
using System.IO;
using System.Text;

namespace derek_csharp_17
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo currDir = new DirectoryInfo(".");
            DirectoryInfo krysiDir = new DirectoryInfo(@"C:\Users\krysi\");
            Console.WriteLine(krysiDir.FullName);
            Console.WriteLine(krysiDir.Name);
            Console.WriteLine(krysiDir.Parent);
            Console.WriteLine(krysiDir.Attributes);
            Console.WriteLine(krysiDir.CreationTime);
            DirectoryInfo dataDir = new DirectoryInfo(@"C:\Users\krysi\Desktop\C#Data");
            //Directory.Delete(@"C:\Users\krysi\Desktop\C#Data");
            string[] customers =
            {
                "Bob Smith",
                "Sally Smith",
                "Robert Smith"
            };
            string textFilePath = @"C:\Users\krysi\Desktop\C#Data\testfile1.txt";
            File.WriteAllLines(textFilePath, customers);
            foreach (string cust in File.ReadAllLines(textFilePath))
            {
                Console.WriteLine("Customer : {0}", cust);
            }
            DirectoryInfo myDataDir = new DirectoryInfo(@"C:\Users\krysi\Desktop\C#Data");
            FileInfo[] txtFiles = myDataDir.GetFiles("*.txt", SearchOption.AllDirectories);
            Console.WriteLine("Matches : {0}", txtFiles.Length);
            foreach(FileInfo file in txtFiles)
            {
                Console.WriteLine(file.Name);
                Console.WriteLine(file.Length);
            }
            string textFilePath2 = @"C:\Users\krysi\Desktop\C#Data\testfile2.txt";
            FileStream fs = File.Open(textFilePath2, FileMode.Create);
            string randString = "This is a random string";
            byte[] rsByteArray = Encoding.Default.GetBytes(randString);
            fs.Write(rsByteArray, 0, rsByteArray.Length);
            fs.Position = 0;
            byte[] fileByteArray = new byte[rsByteArray.Length];
            for (int i = 0; i < rsByteArray.Length; i++)
            {
                fileByteArray[i] = (byte)fs.ReadByte();
            }
            Console.WriteLine(Encoding.Default.GetString(fileByteArray));
            fs.Close();
            string textFilePath3 = @"C:\Users\krysi\Desktop\C#Data\testfile3.txt";
            StreamWriter sw = File.CreateText(textFilePath3);
            sw.Write("This is a random ");
            sw.WriteLine("sentence");
            sw.WriteLine("This is another sentence");
            sw.Close();
            StreamReader sr = File.OpenText(textFilePath3);
            Console.WriteLine("Peek : {0}", Convert.ToChar(sr.Peek()));
            Console.WriteLine("1st String : {0}", sr.ReadLine());
            Console.WriteLine("Everything : {0}", sr.ReadToEnd());
            string textFilePath4 = @"C:\Users\krysi\Desktop\C#Data\testfile4.txt";
            FileInfo datFile = new FileInfo(textFilePath4);
            BinaryWriter bw = new BinaryWriter(datFile.OpenWrite());
            string randText = "Random Text";
            int myAge = 42;
            double height = 6.25;
            bw.Write(randText);
            bw.Write(myAge);
            bw.Write(height);
            bw.Close();
            BinaryReader br = new BinaryReader(datFile.OpenRead());
            Console.WriteLine(br.ReadString());
            Console.WriteLine(br.ReadInt32());
            Console.WriteLine(br.ReadDouble());
            br.Close();
            Console.ReadKey();
        }
    }
}
