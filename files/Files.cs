/*
using System;
using System.IO;

public class Program
{
    public static void Main(string[] args)
    {
        string sourcePath = "C:\\Users\\alberto.canezin\\Desktop\\NET\\files\\file_01.txt";
        string targetPath = "C:\\Users\\alberto.canezin\\Desktop\\NET\\files\\file_02.txt";

        try
        {
            FileInfo fileInfo = new FileInfo(sourcePath);
            fileInfo.CopyTo(targetPath);

            string[] lines = File.ReadAllLines(sourcePath);

            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
        catch (IOException e)
        {
            Console.WriteLine("An error occured " + e.Message);
        }
    }
}
*/
