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
            string[] lines = File.ReadAllLines(sourcePath);

            using (StreamWriter sw = File.AppendText(targetPath)) 
            {
                foreach (string line in lines)
                {
                    sw.WriteLine(line.ToUpper());                    
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
