using System;
using System.IO;

class FileReader
{
    static void Main()
    {
        string fileName = "input.txt"; 
        StreamReader reader = null;

        try
        {
            reader = new StreamReader(fileName);
            string content = reader.ReadToEnd();
            Console.WriteLine("File Content:\n" + content);
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine($"Error: File '{fileName}' not found.");
        }
        finally
        {
            if (reader != null)
            {
                reader.Close();
                Console.WriteLine("File closed successfully.");
            }
        }
    }
}
