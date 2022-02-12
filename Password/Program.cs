
using System.Linq;
using System.Text;
using System.Linq;


string[] words = { "petko", "kotkata", "jenata", "windows", "linux" };
string[] digits = { "12", "21", "3", "4", "25" };

StringBuilder password = new StringBuilder();
Dictionary<char, string> example = new Dictionary<char, string>();

Random rnd = new Random();
int index = rnd.Next(password.Length);

foreach (var word in words)
{
    password.Append(word[0]);
    example.Add(word[0], word);
}




for (int i = 0; i < 2; i++)
{
    index = rnd.Next(password.Length);
    password.Insert(index, digits[rnd.Next(digits.Length)]);

    index = rnd.Next(password.Length);
    password.Replace(password[index] , char.ToUpper(password[index]));
}


foreach (var e in example)
{
    Console.WriteLine($"{e.Key} => {e.Value}");

}
Console.WriteLine();
Console.WriteLine(password);

