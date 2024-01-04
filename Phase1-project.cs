using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan3AssistendProject
{
    internal class Phase1_project
    {
            public static void openAndReadFile()
            {
                bool result = File.Exists(@"C:\Users\Madhu\source\repos\studentData.txt");
                if (result == true)
                {
                    try
                    {
                        FileStream readStream = new FileStream(@"C:\Users\Madhu\source\repos\studentData.txt", FileMode.Open, FileAccess.Read);
                        StreamReader reader = new StreamReader(readStream);
                        string str = reader.ReadToEnd();
                        Console.WriteLine(str);
                        reader.Close();
                        readStream.Close();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else
                {
                    Console.WriteLine("File not exists!!");
                    FileStream writeStream = new FileStream(@"C:\Users\Madhu\source\repos\studentData.txt", FileMode.Create, FileAccess.Write);
                    StreamWriter writer = new StreamWriter(writeStream);
                    writer.WriteLine("This file contains\n Student data.");
                    writer.Close();
                    writeStream.Close();
                }
            }
            static void Main(string[] args)
            {
                openAndReadFile();
                Console.ReadLine();
            }
        }
    }


