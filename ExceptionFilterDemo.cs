using System;

class ExceptionFilterDemo
{
    static void Main()
    {
        try
        {
            ConnectToDatabase();
        }
        catch (Exception ex) when (ex.Message.Contains("DB"))
        {
            Console.WriteLine("Database-related error caught:");
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("General error caught:");
            Console.WriteLine(ex.Message);
        }
    }

    static void ConnectToDatabase()
    {
        throw new Exception("DB connection failed: Server not reachable.");
    }
}
