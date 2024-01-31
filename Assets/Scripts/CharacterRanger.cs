using UnityEngine;

// INHERITANCE
public class CharacterRanger : CharacterBase 
{
    [SerializeField] private float _criticalRate;

    public float CriticalRate => _criticalRate;


    // POLYMORPHISM
    // Here we override the Greet method from the base class
    // to provide a unique greeting for the ranger character.
    public override string Greet()
    {
        return $"Greetings! I'm {name}, a swift archer of the wild. Brace for the precision of my arrows and the dance of nature at my side.";
    }
}