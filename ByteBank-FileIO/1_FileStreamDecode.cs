using System.Text;

partial class Program
{
    public static void HandlingFileStream()
    {
        string filePath = "accounts.txt";

        using (var fileStream = new FileStream(filePath, FileMode.Open))
        {
            int readBytes = -1;
            byte[] buffer = new byte[1024]; //1KiB

            while (readBytes != 0)
            {
                readBytes = fileStream.Read(buffer, 0, 1024);
                Console.WriteLine($"Read bytes {readBytes}");

                string text = DecodeBuffer(buffer, readBytes);
                Console.WriteLine(text);
            }
        }
    }

    public static string DecodeBuffer(byte[] buffer, int readBytes)
    {
        return Encoding.UTF8.GetString(buffer, 0, readBytes);
    }
}
