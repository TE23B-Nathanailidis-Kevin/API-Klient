// string content = "hej";
// File.WriteAllText("grej.txt", content);
// string content = File.ReadAllText("grej.txt");
// Console.WriteLine(content);
// Console.ReadLine();


// Santa nick = new();
// nick.Name = "Nicholaus";
// nick.Beard = 2;
// nick.NumberOfPresentes = 4;

// string content = JsonSerializer.Serialize(nick);

// File.WriteAllText("santa.Json", content);

// string content = file.ReadAllText("santa.Json");
// Santa nick = JsonSerializer.Deserialize(content);
// Console.WriteLine(nick.name);

using System.Net.Http.Json;

HttpClient client = new();
client.BaseAddress = new Uri("https://swapi.py4e.com/api/");
var result = client.GetAsync("people/4/").Result;

StarWars p = result.Content.ReadFromJsonAsync<StarWars>().Result; 

Console.WriteLine(p.height);

// string content = result.Content.ReadAsByteArrayAsync().Result;
// Console.WriteLine(content);
Console.ReadLine();