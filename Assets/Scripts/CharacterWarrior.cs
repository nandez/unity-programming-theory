using UnityEngine;

// INHERITANCE
public class CharacterWarrior : CharacterBase
{
    [SerializeField] private int _armor;
    public int Armor => _armor;

    // POLYMORPHISM
    // Here we override the Greet method from the base class
    // to provide a unique greeting for the warrior character.
    public override string Greet()
    {
        return $"Hail, friend! I'm {name}, a warrior born for battle. Let the strength of my blade speak louder than words";
    }
}