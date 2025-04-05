using Newtonsoft.Json;

Console.WriteLine("Hi, .Net Core!");

Console.Write("Enter your name: ");
string? name = Console.ReadLine();

Console.WriteLine("Hi, " + name);


var person = new { Name = "Mahmut", Age = 30 };
string strPerson = JsonConvert.SerializeObject(person);
Console.WriteLine(strPerson);