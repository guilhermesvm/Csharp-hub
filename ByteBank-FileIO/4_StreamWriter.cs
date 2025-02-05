using System.Text;
using ByteBank_FileIO.Models;

partial class Program
{
    public static void HandlingStreamWriter()
    {
        string newFilePath = "exportedAccounts2.txt";
        using (var fileStream = new FileStream(newFilePath, FileMode.Create))
        {
            using (var writer = new StreamWriter(fileStream))
            {
                TestWriterSpeed(writer);
                //writer.WriteLine("456,7895,4785.40,Guilherme Machado");
            }
        }
    }

    public static void TestWriterSpeed(StreamWriter writer)
    {
        int n = 1000;
        for (int i = 0; i < n; i++)
        {
            writer.WriteLine($"Line {i}");
            writer.Flush(); //Dump buffer to stream
            Console.Write($"Line {i} was written. Press enter: ");
            Console.ReadLine();
        }
    }

}
