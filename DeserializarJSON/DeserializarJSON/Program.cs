using Library;
using System.Text.Json;

public class Program
{
    private static void Main(string[] args)
    {
        string users = "Usuários.json";
        string path = @"C:\Users\" + Environment.UserName + @"\";

        string pathFile = path + users;

        User user = new User()
        {
            Name = "Maria Costa Silva",
            Cpf = "123.456.789-12",
            Email = "mariacostasilva@gmail.com"
        };

        using (StreamReader sr = new StreamReader(pathFile))
        {
            string linesFile = sr.ReadToEnd();

            User? userDeserializer = JsonSerializer.Deserialize<User>(linesFile);

            Console.WriteLine(userDeserializer.Name);
            Console.WriteLine(userDeserializer.Cpf);
            Console.WriteLine(userDeserializer.Email);
        }
    }
}