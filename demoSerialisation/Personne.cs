using System.Text.Json.Serialization;

namespace demoSerialisation;

[Serializable]
public class Personne
{
    


    public Personne()
    {
        
    }

    public Personne(string firstName, string lastName, params Voiture[] voitures)
    {
        FirstName = firstName;
        LastName = lastName;

        foreach (var voiture in voitures)
        {
            Voitures.Add(voiture);
        }
    }

    
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public IList<Voiture> Voitures { get; set; } = new List<Voiture>();

    public override string ToString()
    {
        return $"{FirstName} {LastName}\nListe des voitures : {ListeVoiture()}";
    }

    public string ListeVoiture()
    {
        string str = "";
        foreach (var voiture in Voitures)
        {
            str += $"{voiture}";
        }

        return str;
    }
}