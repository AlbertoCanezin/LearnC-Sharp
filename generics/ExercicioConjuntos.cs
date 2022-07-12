/*
using System;
using System.IO;
using System.Collections.Generic;

public class LogRecord
{
    public string UserName { get; set; }
    public DateTime Instant { get; set; }
    
    public override int GetHashCode()
    {
        return UserName.GetHashCode();
    }

    public override bool Equals(object obj)
    {
        if (!(obj is LogRecord))
        {
            return false;
        }
        LogRecord other = obj as LogRecord;
        return UserName.Equals(other.UserName);
    }
    
}

class ExercicioConjuntos
{
    public static void Main(string[] args)
    {
        HashSet<LogRecord> set = new HashSet<LogRecord>();
        Console.Write("Enter file full path: ");
        string path = Console.ReadLine();

        try
        {
            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split(' ');
                    string name = line[0];
                    DateTime instant = DateTime.Parse(line[1]);
                    set.Add(new LogRecord { UserName = name, Instant = instant});               
                }
                Console.WriteLine("Total users: " + set.Count);
            }
        }
        catch (IOException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
*/
