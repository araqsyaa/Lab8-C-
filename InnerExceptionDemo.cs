using System;
using System.IO;

class InnerExceptionDemo
{
    static void Main()
    {
        try
        {
            LoadFile();
        }
        catch (ApplicationException ex)
        {
            Console.WriteLine("Application error: " + ex.Message);
            if (ex.InnerException != null)
            {
                Console.WriteLine("Inner exception: " + ex.InnerException.Message);
            }
        }
    }

    static void LoadFile()
    {
        try
        {
            string fileName = "data.txt";
            string content = File.ReadAllText(fileName);
            Console.WriteLine("File content:\n" + content);
        }
        catch (FileNotFoundException ex)
        }
            throw new ApplicationException("Failed to load file.", ex);
        }
    }
}
