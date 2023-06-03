using Library;
using System.ComponentModel;
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
            CPF = "123.456.789-12",
            Email = "josecostasilva@gmail.com"
        };

        XmlSerializer serializer = new XmlSerializer(typeof(User));

        using (StreamWriter sw = new StreamWriter(pathFile))
        {
            serializer.Serialize(sw, user);
        }
    }
}