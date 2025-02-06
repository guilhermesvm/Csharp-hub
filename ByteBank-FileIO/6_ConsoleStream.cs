using ByteBank_FileIO.Models;

partial class Program
{
    public static void ConsoleStream()
    {
        using (var stream = Console.OpenStandardInput())
        using(var fs = new FileStream("console.txt", FileMode.Create))
        {
            byte[] buffer = new byte[1024];
            while (true)
            {
                
                var readBytes = stream.Read(buffer, 0, buffer.Length);
                fs.Write(buffer, 0, readBytes);
                fs.Flush();
                Console.WriteLine($"Read bytes in console: {readBytes}");
            }
        }
    }
}
