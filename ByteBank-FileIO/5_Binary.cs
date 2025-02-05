using ByteBank_FileIO.Models;

partial class Program
{
    static void BinaryWriter()
    {
        string filePath = "currentAccount.txt";
        using(var fs = new FileStream(filePath, FileMode.Create))
        using (var binaryWriter = new BinaryWriter(fs))
        {
            binaryWriter.Write(456);
            binaryWriter.Write(4546453);
            binaryWriter.Write(4000.50);
            binaryWriter.Write("Guilherme Machado");
        }
    }

    static void BinaryStream()
    {
        string filePath = "currentAccount.txt";
        using(var fs = new FileStream(filePath, FileMode.Open))
        using(var binaryReader = new BinaryReader(fs))
        {
            int agency = binaryReader.ReadInt32();
            int number = binaryReader.ReadInt32();
            double balance = binaryReader.ReadDouble();
            string customer = binaryReader.ReadString();

            Console.WriteLine(agency);
            Console.WriteLine(number);
            Console.WriteLine(balance);
            Console.WriteLine(customer);
        }
    }
}
