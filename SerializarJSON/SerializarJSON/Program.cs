using Library;
using Newtonsoft.Json;

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

        string serializer = JsonConvert.SerializeObject(user);

        using (StreamWriter sw = new StreamWriter(pathFile))
        {
            sw.WriteLine(serializer);
        }
    }
}