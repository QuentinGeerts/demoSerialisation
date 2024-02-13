namespace demoSerialisation;

[Serializable]
public class Voiture
{
    public Voiture(string couleur)
    {
        Couleur = couleur;
    }

    public Voiture()
    {
        
    }

    public string Couleur { get; set; }

    public override string ToString()
    {
        return $"Voiture {Couleur}";
    }
}