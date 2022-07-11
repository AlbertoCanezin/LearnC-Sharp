/*
using System;
using System.IO;

public class Program
{
    public static void Main(string[] args)
    {
        
        string path = "C:\\Users\\alberto.canezin\\Desktop\\NET\\files\\file_01.txt";

        try 
        {
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            }
        }
        catch (IOException e)
        {
            Console.WriteLine("An error occurred " + e.Message);
        }
    }
}
*/
