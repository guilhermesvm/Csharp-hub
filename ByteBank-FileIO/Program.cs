using System.Text;

class Program
{
    static void Main()
    {
        string filePath = "accounts.txt";
        int readBytes = -1;
        byte[] buffer = new byte[1024]; //1KiB

        var fileStream = new FileStream(filePath, FileMode.Open);//enum

        while (readBytes != 0)
        {
            readBytes = fileStream.Read(buffer, 0, 1024);
            string text = DecodeBuffer(buffer, readBytes);
            WriteBuffer(text);
        }

        fileStream.Close();
    }

    public static string DecodeBuffer(byte[] buffer, int readBytes)
    {
        var utf8 = new UTF8Encoding();
        return utf8.GetString(buffer, 0, readBytes);
    }

    public static void WriteBuffer(string text)
    {
        Console.WriteLine(text);
    }
}
