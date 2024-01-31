using UnityEngine;

// Example of inheritance; here we inherit from the CharacterBase class
public class CharacterWizard : CharacterBase
{
    [SerializeField] private int _mana;
    public int Mana => _mana;

    // Example of polymorphism; here we override the Greet method from the base class
    // to provide a unique greeting for the wizard character.
    public override string Greet()
    {
        return $"Greetings! I am {name}, a sorcerer of arcane might. Brace yourself for the magic that flows through my fingertips.";
    }
}