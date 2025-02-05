using ByteBank_FileIO.Models;

partial class Program
{
    public static void HandlingStreamReader()
    {
        var filePath = "accounts.txt";

        using (var fileStream = new FileStream(filePath, FileMode.Open))
        using(var reader = new StreamReader(fileStream))
        {
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine()!;
                CurrentAccount account = ConvertStringToCurrentAccount(line);
                Console.WriteLine(account.Agency);
                Console.WriteLine(account.Number);
                Console.WriteLine(account.Balance.ToString("F2"));
                Console.WriteLine(account.AccountHolder.Name);
                Console.WriteLine();
            }
        }
    }

    public static CurrentAccount ConvertStringToCurrentAccount(string line)
    {
        //375 4644 2483.13 Jonathan
        string[] result = line.Split(',');
        if (result.Length != 4)
        {
            throw new FormatException("Line must have 4 elements.");
        }

        if (!int.TryParse(result[0], out int agency) ||
            !int.TryParse(result[1], out int number) ||
            !double.TryParse(result[2].Replace('.', ','), out double balance))
        {
            throw new FormatException("Error whe converting values.");
        }

        var customer = new Customer() { Name = result[3] };

        CurrentAccount account = new CurrentAccount(agency, number);
        account.Deposit(balance);
        account.AccountHolder = customer;
        return account;
    }
}
