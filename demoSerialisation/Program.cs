
using System.Text;
using System.Text.Json;
using demoSerialisation;

Voiture v1 = new Voiture("Rouge");
Voiture v2 = new Voiture("Vert");
Voiture v3 = new Voiture("Bleu");

Personne personne = new Personne("Quentin", "Geerts", v1, v2, v3);

// Sérialisation
string jsonString = JsonSerializer.Serialize(personne);
File.WriteAllText("personne.json", jsonString);
Console.WriteLine(jsonString);


// Désérialisation
string text = File.ReadAllText("personne.json");
Personne? p = JsonSerializer.Deserialize<Personne>(text, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });


// Affichage
if (p != null) Console.WriteLine(p);