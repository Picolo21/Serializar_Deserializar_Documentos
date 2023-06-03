using Library;
using System.Xml.Serialization;

public class Program
{
    private static void Main(string[] args)
    {
        string users = "Usuários.xml";
        string path = @"C:\Users\" + Environment.UserName + @"\";

        string pathFile = path + users;

        User user = new User()
        {
            Name = "José Costa Silva",
            Cpf = "123.456.789-12",
            Email = "josecostasilva@gmail.com"
        };

        XmlSerializer serializer = new XmlSerializer(typeof(User));

        using (StreamWriter sw = new StreamWriter(pathFile))
        {
            serializer.Serialize(sw, user);
        }

        using (StreamReader sr = new StreamReader(pathFile))
        {
            User? userDeserializer = serializer.Deserialize(sr) as User;

            Console.WriteLine(userDeserializer.Name);
            Console.WriteLine(userDeserializer.Cpf);
            Console.WriteLine(userDeserializer.Email);
        }
    }
}