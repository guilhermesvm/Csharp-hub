using System.Text.Json;
using System.Text.Json.Serialization;

class User
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Email { get; set; }

    public User(string name, int age, string email)
    {
        Name = name;
        Age = age;
        Email = email;
    }

    public void GenerateJSONFile()
    {
        string json = JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true});

        string fileName = $"user-{Name}.json";
        File.WriteAllText(fileName, json);
        Console.WriteLine("JSON has been created successfully.\n");
    }
}

class DeserializeUser
{
    [JsonPropertyName("Name")]
    public string Name { get; set; }
    [JsonPropertyName("Age")]
    public int Age { get; set; }
    [JsonPropertyName("Email")]
    public string Email { get; set; }
}

class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Serialize and Deserialize a single user");
            Console.WriteLine("2. Serialize and Deserialize multiple users");
            int op = int.Parse(Console.ReadLine()!);
            if (op == 1)
            {
                CreateUser();
            }
            else
            {
                CreateUsers();
                DeserializeUsers();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    static void CreateUser()
    {
        User user = ReadUserData();
        user.GenerateJSONFile();
        DeserializeUser(user.Name);
    }

    static void DeserializeUser(string userName)
    {
        string path = $"user-{userName}.json";
        if (File.Exists(path))
        {
            string userInfo = File.ReadAllText(path);
            var user = JsonSerializer.Deserialize<DeserializeUser>(userInfo);
            if (user != null)
            {
                Console.WriteLine($"Name: {user.Name}");
                Console.WriteLine($"Age: {user.Age}");
                Console.WriteLine($"E-mail: {user.Email}");
            }
            else
            {
                Console.WriteLine("Failed to deserialize user data.");
            }
        }
        else
        {
            Console.WriteLine("File does not exist.");
        }
    }

    static void CreateUsers()
    {
        Console.Write("How many users you want to insert? ");
        List<User> users = new List<User>();

        int n = int.Parse(Console.ReadLine()!);
        for (int i = 0; i < n; i++)
        {
            User user = ReadUserData();
            users.Add(user);
        }

        string fileName = "users.json";
        string json = JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(fileName, json);
        Console.WriteLine("JSON has been created successfully.\n");
    }

    static void DeserializeUsers()
    {
        string path = "users.json";
        if (File.Exists(path))
        {
            string usersInfoJSON = File.ReadAllText(path);
            var users = JsonSerializer.Deserialize<List<User>>(usersInfoJSON);
            if (users == null)
            {
                Console.WriteLine("Failed to deserialize user data.");
            }
            else
            {
                Console.Write("Enter an age to filter users by age: ");
                int age = int.Parse(Console.ReadLine()!);
                FilterUsersByAge(users, age);
            }
        }
        else
        {
            Console.WriteLine("File does not exist.");
        }
    }

    static void FilterUsersByAge(List<User> users, int age)
    {
        var filteredUsers = users.Where(user => user.Age.Equals(age)).ToList();
        if (filteredUsers.Any())
        {
            Console.WriteLine($"List of users whose age is {age}:\n");
            foreach (var user in filteredUsers)
            {
                Console.WriteLine($"Name: {user.Name}");
                Console.WriteLine($"Age: {user.Age}");
                Console.WriteLine($"E-mail: {user.Email}");
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("No users found with the specified age.");
        }
    }


    static User ReadUserData()
    {
        Console.Write("Enter person's name: ");
        string name = Console.ReadLine()!;
        Console.Write("Enter person's age: ");
        int age = int.Parse(Console.ReadLine()!);
        Console.Write("Enter person's email: ");
        string email = Console.ReadLine()!;
        Console.WriteLine();

        User user = new User(name, age, email);
        return user;
    }
}

