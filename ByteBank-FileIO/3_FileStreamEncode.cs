using System.Text;
using ByteBank_FileIO.Models;

partial class Program
{
    public static void CreatingFile()
    {
        string newFilePath = "exportedAccounts.txt"; 
        using(var fileStream = new FileStream(newFilePath, FileMode.Create))
        {
            string accountAsString = "456,7895,4785.40,Guilherme Machado";
            byte[] bytes = EncodeBuffer(accountAsString);
            fileStream.Write(bytes, 0 , bytes.Length);
        }
    }

    public static byte[] EncodeBuffer(string account)
    {
        return Encoding.UTF8.GetBytes(account);
    }
}
